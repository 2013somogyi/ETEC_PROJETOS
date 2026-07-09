print("--//--//--//--//--//--//--")
print("\nBem vindo ao Mercadinho Arretado")

total = 0
carrinho = []

produtos = [
            "1 - Trakinas  R$2,00",
            "2 - Toddynho  R$3,50",
            "3 - Doritos  R$8,50",
            "4 - Coca  R$3,00",
            "5 - Fini  R$5,00"
            ]
codigos = ["1", "2", "3", "4", "5"]
valores = [2.00, 3.50, 8.50, 3.00, 5.00]

while True:
    for itens in produtos:
        print(itens)

    escolha = input("\nDigite o código do produto ou FIM para sair:")
    if escolha.upper() == "FIM":
        break
    else:
    #CALCULOS
        qtd = int(input("Digite a quantidade:"))

        if escolha == codigos[0]:
            total = (valores[0] * qtd) + total
            carrinho.append("Trakinas")
            print("\n--Trakinas adicionado--")

        elif escolha == codigos[1]:
            total = (valores[1] * qtd) + total
            carrinho.append("Toddynho")
            print("\n--Toddynho adicionado--")

        elif escolha == codigos[2]:
            total = (valores[2] * qtd) + total
            carrinho.append("Doritos")
            print("\n--Doritos adicionado--")

        elif escolha == codigos[3]:
            total = (valores[3] * qtd) + total
            carrinho.append("Coca")
            print("\n--Coca adicionado--")

        elif escolha == codigos[4]:
            total = (valores[4] * qtd) + total
            carrinho.append("Fini")
            print("\n--Fini adicionado--")

        else:
            print("\nVocê digitou um código inexistente")

print("--//--//--//--//--//--//--")
print("\n--//--//--MEU CARRINHO--//--//--")
for item in carrinho:
    print("- " + item)

print(f"TOTAL A PAGAR R${total}!")
print("\n--//--//--//--//--//--//--")

