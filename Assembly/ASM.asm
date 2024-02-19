; Autor: Nikodem Wspania³y
; Data ukonczenia: 12.01.2024
; Politechnika œl¹ska, Gliwice, semestr 5, Kurs Jêzyki Asemblerowe
; Temat projektu: opracowanie oraz zaiplementowanie filtra szarosci
; skrót algorytmu:
; algorytm jest odpowiedzialny za konwersje obrazu na czarno bialy
; pobieramy z tablicy wejsciowej kolejne 4 wartosci 
; za pomoca wartosci wektorowych dodajemy je do siebie oraz dzielimy przez 3 (tutaj mnozymy przez dzielnik 0,33)
; nowa wartosc wpisujemy w kolejne 4 miejsca tablicy wyjsciowej 
; dzieki czemu na wyjsciu dostajemy tablice RGBARGBA... z wartosciami koncowymi dla filtra


.data
    dzielnik dd 0.33, 0.33, 0.33, 1.0 ;sta³a dzielnikowa
.code
filter proc
    ; Argumenty funkcji: bytes, start, koniec
    ; Argumenty te s¹ przekazywane z jêzyka wysokopoziomowego.
    ; RCX  WskaŸnik do tablicy
    ; RDX  wskaŸnik na start iteracji tablicy ; na index
    ; R8   wskaŸnik na koniec iteracji tablicy ; na index
    ; R9   wslaŸnik do tablicy z nowymi wartoœciami
    
    ;przygotowanie do pêtli g³ownej

    xor r11, r11 ; xor aby mieæ pewnoœæ ze w rejestrze r11 nic siê nie znajduje
    xor r12, r12 ; xor aby mieæ pewnoœæ ze w rejestrze r12 nic siê nie znajduje
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy z rcx do r11 (z rcx)
    mov r12, rdx ; index tablicy (punkt poczatku iteracji) wpisujemy do rejestru r12 (z rdx)
    shl r12, 2   ; pomnozenie indexu startu przez 4 (r12)
    shl r8, 2    ; pomnozenie indexu koncowego przez 4 (r8)
    movups xmm2, [dzielnik] ; wpisanie do xmm2 dzielnik z sekcji data
start_loop:         ; etykieta pêtli g³ownej
        cmp r12, r8 ; Porównaj iterator z koñcem, jeœli iterator >= koniec, to opuœæ pêtlê
        jae endloop ; skok warunkowy do etykiety endloop

        movdqu xmm0, oword ptr[r11 + r12] ;pobranie jednego pixela z tablicy
        mulps xmm0, xmm2 ; mnozenie r g b a razy dzielnik 
                          ; teraz w xmm0 znajduje sie: R,G,B,A (pomnozone razy wspo³czynnik)
        haddps xmm0, xmm0 ; zsumowanie - wynik: R+G, B+A, R+G, B+A
        haddps xmm0, xmm0 ; ponowne zsumowanie - wszêdzie s¹ sumy wszystkich

        movdqu oword ptr[r9 + r12], xmm0 ; wpisanie wartoœci do nowej tablicy
        add r12, 16                     ;incrementacja iteratora o 1 pixela (16 bajtów)
        jmp start_loop ; skok bezwarunkowy do pocz¹tku pêtli

endloop:
ret                     ;koniec programu
filter endp
end 