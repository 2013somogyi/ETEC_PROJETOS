nmr1 = float(input("Digte o primeiro número:"))
nmr2 = float(input("Digte o segundo número:"))

print("_________________________")
oper = ["Soma", "Subtração", "Multiplicação", "Divisão"]
for itens in oper:
    print(itens)
print("_________________________")

print("_________________________")
escolha = input("Escolha a operação desejada:")
print("_________________________")

if escolha == oper[0]:
    somar = nmr1 + nmr2
    print(f"Sua soma deu: {somar}.")

elif escolha == oper[1]:
    subtr = nmr1 + nmr2
    print(f"Sua subtração deu: {subtr}.")

elif escolha == oper[2]:
    multi = nmr1 + nmr2
    print(f"Sua multiplicaçãp deu: {multi}.")

else:
    divid = nmr1 / nmr2
    print(f"Sua divisão deu: {divid}.")
