.code
filter proc
    ; Argumenty funkcji: bytes, start, koniec
    ; Argumenty te s� przekazywane z j�zyka wysokopoziomowego.
    ; RCX  Wska�nik do tablicy
    ; RDX  wska�nik na start iteracji tablicy ; na index
    ; R8   wska�nik na koniec iteracji tablicy ; na index
    ; R9   wsla�nik do tablicy z nowymi warto�ciami
    
    ;wpiszmy wskaznik do mniej narazonych rejestrow :)
    xor r11, r11 ;0
    xor r12, r12 ;0
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy do rejestru r11
    mov r12, rdx ; index tablicy
    xor r10, r10 ; wyzerowania r10 (dzielnika)
    mov r10, 3 ; wpisanie do r10 wartosci 3
start_loop:
        cmp r12, r8 ; Por�wnaj iterator z ko�cem, je�li iterator >= koniec, to opu�� p�tl�
        jae endloop

        xor rax, rax ; 0
        xor rdx, rdx
        mov al, byte ptr [r11 + r12] ; Odczytaj trzy kolejne warto�ci w tablicabytes wskazywane przez iterator
        mov dl, byte ptr [r11 + r12 + 1]
        add ax, dx
        xor rdx, rdx
        mov dl, byte ptr [r11 + r12 + 2]
        add ax, dx
        xor rdx,rdx
        div r10 ; dzielimy rejest rax przez zawartosc r10 wynik w rax
        xor r13, r13
        add r13, rax
        mov [r9 + r12], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator 
        mov [r9 + r12 + 1], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator + 1
        mov [r9 + r12 + 2], al ; Zapisz �redni� do tablicy w miejscu wskazywanym przez iterator + 2 

        add r12, 3 ; Przesu� iterator o 3 bajty
        
       
        jmp start_loop ; Powt�rz p�tl�

endloop:
 xor rax, rax
 mov rax, [rcx]
ret
filter endp
end 
