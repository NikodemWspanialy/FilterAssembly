.code
filter proc
    ; Argumenty funkcji: bytes, start, koniec
    ; Argumenty te s¹ przekazywane z jêzyka wysokopoziomowego.
    ; RCX  WskaŸnik do tablicy
    ; RDX  wskaŸnik na start iteracji tablicy ; na index
    ; R8   wskaŸnik na koniec iteracji tablicy ; na index
    ; R9   wslaŸnik do tablicy z nowymi wartoœciami
    
    ;wpiszmy wskaznik do mniej narazonych rejestrow :)
    xor r11, r11 ;0
    xor r12, r12 ;0
    mov r11, rcx ; wskaznik na poczatek tabicy wppisujemy do rejestru r11
    mov r12, rdx ; index tablicy
    xor r10, r10 ; wyzerowania r10 (dzielnika)
    mov r10, 3 ; wpisanie do r10 wartosci 3
start_loop:
        cmp r12, r8 ; Porównaj iterator z koñcem, jeœli iterator >= koniec, to opuœæ pêtlê
        jae endloop

        xor rax, rax ; 0
        xor rdx, rdx
        mov al, byte ptr [r11 + r12] ; Odczytaj trzy kolejne wartoœci w tablicabytes wskazywane przez iterator
        mov dl, byte ptr [r11 + r12 + 1]
        add ax, dx
        xor rdx, rdx
        mov dl, byte ptr [r11 + r12 + 2]
        add ax, dx
        xor rdx,rdx
        div r10 ; dzielimy rejest rax przez zawartosc r10 wynik w rax
        xor r13, r13
        add r13, rax
        mov [r9 + r12], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator 
        mov [r9 + r12 + 1], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator + 1
        mov [r9 + r12 + 2], al ; Zapisz œredni¹ do tablicy w miejscu wskazywanym przez iterator + 2 

        add r12, 3 ; Przesuñ iterator o 3 bajty
        
       
        jmp start_loop ; Powtórz pêtlê

endloop:
 xor rax, rax
 mov rax, [rcx]
ret
filter endp
end 
