; Autor: Nikodem Wspania�y
; Data ukonczenia: 12.01.2024
; Politechnika �l�ska, Gliwice, semestr 5, Kurs J�zyki Asemblerowe
; Temat projektu: opracowanie oraz zaiplementowanie filtra szarosci
; skr�t algorytmu:
; algorytm jest odpowiedzialny za konwersje obrazu na czarno bialy
; pobieramy z tablicy wejsciowej kolejne 4 wartosci 
; za pomoca wartosci wektorowych dodajemy je do siebie oraz dzielimy przez 3 (tutaj mnozymy przez dzielnik 0,33)
; nowa wartosc wpisujemy w kolejne 4 miejsca tablicy wyjsciowej 
; dzieki czemu na wyjsciu dostajemy tablice RGBARGBA... z wartosciami koncowymi dla filtra


.data
    dzielnik dd 0.33, 0.33, 0.33, 1.0 ;sta�a dzielnikowa
.code
filter proc
    ; Argumenty funkcji: bytes, start, koniec
    ; Argumenty te s� przekazywane z j�zyka wysokopoziomowego.
    ; RCX  Wska�nik do tablicy
    ; RDX  wska�nik na start iteracji tablicy ; na index
    ; R8   wska�nik na koniec iteracji tablicy ; na index
    ; R9   wsla�nik do tablicy z nowymi warto�ciami
    
    ;przygotowanie do p�tli g�ownej

    xor r11, r11 ; xor aby mie� pewno�� ze w rejestrze r11 nic si� nie znajduje
    xor r12, r12 ; xor aby mie� pewno�� ze w rejestrze r12 nic si� nie znajduje
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy z rcx do r11 (z rcx)
    mov r12, rdx ; index tablicy (punkt poczatku iteracji) wpisujemy do rejestru r12 (z rdx)
    shl r12, 2   ; pomnozenie indexu startu przez 4 (r12)
    shl r8, 2    ; pomnozenie indexu koncowego przez 4 (r8)
    movups xmm2, [dzielnik] ; wpisanie do xmm2 dzielnik z sekcji data
start_loop:         ; etykieta p�tli g�ownej
        cmp r12, r8 ; Por�wnaj iterator z ko�cem, je�li iterator >= koniec, to opu�� p�tl�
        jae endloop ; skok warunkowy do etykiety endloop

        movdqu xmm0, oword ptr[r11 + r12] ;pobranie jednego pixela z tablicy
        mulps xmm0, xmm2 ; mnozenie r g b a razy dzielnik 
                          ; teraz w xmm0 znajduje sie: R,G,B,A (pomnozone razy wspo�czynnik)
        haddps xmm0, xmm0 ; zsumowanie - wynik: R+G, B+A, R+G, B+A
        haddps xmm0, xmm0 ; ponowne zsumowanie - wsz�dzie s� sumy wszystkich

        movdqu oword ptr[r9 + r12], xmm0 ; wpisanie warto�ci do nowej tablicy
        add r12, 16                     ;incrementacja iteratora o 1 pixela (16 bajt�w)
        jmp start_loop ; skok bezwarunkowy do pocz�tku p�tli

endloop:
ret                     ;koniec programu
filter endp
end 