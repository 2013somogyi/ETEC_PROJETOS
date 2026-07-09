palavra = input("Digite a palavra desejada:")
x = 0
for letra in palavra:
    x+=1
    print(letra.upper())
print(f"A palavra:{palavra} tem {x} letras!")