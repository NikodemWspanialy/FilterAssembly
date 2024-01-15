.code
filter proc
    ; Argumenty funkcji: bytes, start, koniec
    ; Argumenty te s¹ przekazywane z jêzyka wysokopoziomowego.
    ; RCX  WskaŸnik do tablicy
    ; RDX  wskaŸnik na start iteracji tablicy ; na index
    ; R8   wskaŸnik na koniec iteracji tablicy ; na index
    ; R9   wslaŸnik do tablicy z nowymi wartoœciami
    
    ;przygotowanie do pêtli g³ownej

    xor r11, r11 ; xor aby mieæ pewnoœæ ze w rejestrze nic siê nie znajduje
    xor r12, r12 ; xor aby mieæ pewnoœæ ze w rejestrze nic siê nie znajduje
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy do rejestru r11
    mov r12, rdx ; index tablicy
    xor r10, r10 ; xor aby mieæ pewnoœæ ze w rejestrze nic siê nie znajduje
    mov r10, 3 ; wpisanie do r10 wartosci 3 - sta³ej dzielnikowej
start_loop:
        cmp r12, r8 ; Porównaj iterator z koñcem, jeœli iterator >= koniec, to opuœæ pêtlê
        jae endloop ; skok warunkowy do etykiety endloop

        xor rax, rax ; xor aby mieæ pewnoœæ ze w rejestrze nic siê nie znajduje
        xor rdx, rdx ; xor aby mieæ pewnoœæ ze w rejestrze nic siê nie znajduje
        mov al, byte ptr [r11 + r12] ;do al wpisujemy pierwsz¹ wartoœæ tablicy (R) z padresu r11 - wska¿nik na tablice, r12 - iterator
        mov dl, byte ptr [r11 + r12 + 1] ; do dl wpisujemy drug¹ wartoœæ tablicy (G)
        add ax, dx ; dodajemy do ax, dx - w ax teraz suma R oraz G
        xor rdx, rdx ; czyœcimy rejestr rdx
        mov dl, byte ptr [r11 + r12 + 2] ; do rejestru dl wpisujemy trzeci¹ wartoœæ talicy (B)
        add ax, dx ; oddajemy rejestry - teraz a ax suma R+G+B
        xor rdx,rdx ; czyœcimy rejestr rdx
        div r10 ; dzielimy rejest rax przez zawartosc r10 wynik w rax - wynik w ax reszta w dx 
        mov [r9 + r12], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator 
        mov [r9 + r12 + 1], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator + 1
        mov [r9 + r12 + 2], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator + 2 

        add r12, 3 ; Przesuñ iterator o 3 bajty
        
       
        jmp start_loop ; Powtórz pêtlê

endloop:
ret
filter endp
end 