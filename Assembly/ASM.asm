.data
    dzielnik dd 0.33, 0.33, 0.33, 1.0 
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
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy z rcx do r11
    mov r12, rdx ; index tablicy (punkt poczatku iteracji) wpisujemy do rejestru r12
    shl r12, 2
    shl r8, 2    ; pomnozenie indexu koncowego przez 4
    movups xmm2, [dzielnik] ; wpisanie do xmm2 dzielnika 
start_loop:
        cmp r12, r8 ; Por�wnaj iterator z ko�cem, je�li iterator >= koniec, to opu�� p�tl�
        jae endloop ; skok warunkowy do etykiety endloop

        movdqu xmm0, oword ptr[r11 + r12]
        mulps xmm0, xmm2 ; mnozenie r g b a razy dzielnik 

        haddps xmm0, xmm0
        haddps xmm0, xmm0

        movdqu oword ptr[r9 + r12], xmm0
        add r12, 16
        jmp start_loop ; powt�rz p�tle
        ;xor rax, rax ; xor aby mie� pewno�� ze w rejestrze nic si� nie znajduje
        ;xor rdx, rdx ; xor aby mie� pewno�� ze w rejestrze nic si� nie znajduje
        ;mov al, byte ptr [r11 + r12] ;do al wpisujemy pierwsz� warto�� tablicy (R) z padresu r11 - wska�nik na tablice, r12 - iterator
        ;mov dl, byte ptr [r11 + r12 + 1] ; do dl wpisujemy drug� warto�� tablicy (G)
        ;add ax, dx ; dodajemy do ax, dx - w ax teraz suma R oraz G
        ;xor rdx, rdx ; czy�cimy rejestr rdx
        ;mov dl, byte ptr [r11 + r12 + 2] ; do rejestru dl wpisujemy trzeci� warto�� talicy (B)
        ;add ax, dx ; oddajemy rejestry - teraz a ax suma R+G+B
        ;xor rdx,rdx ; czy�cimy rejestr rdx
        ;div r10 ; dzielimy rejest rax przez zawartosc r10 wynik w rax - wynik w ax reszta w dx 
        ;mov [r9 + r12], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator 
        ;mov [r9 + r12 + 1], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator + 1
        ;mov [r9 + r12 + 2], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator + 2 

        ;add r12, 3 ; Przesu� iterator o 3 bajty
        
       
        ;jmp start_loop ; Powt�rz p�tl�

endloop:
ret
filter endp
end 