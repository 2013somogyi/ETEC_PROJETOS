pagamento = float(input("Qual o valor que deseja abastecer?: R$"))

desc = [0.02, 0.03, 0.05]
desc_final = 0

if pagamento >= 60 and pagamento < 90:
    desc_final = pagamento - (pagamento * desc[0])

elif pagamento >= 90 and pagamento < 100:
    desc_final = pagamento - (pagamento * desc[1])

else:
    desc_final = pagamento - (pagamento * desc[2])

print("*************************")
print("*Bomba de combustível*")
print("*************************")
comb = ["1 - GASOLINA", "2 - ALCOOL", "3 - DIESEL"]
for opcoes in comb:
    print(opcoes)

escolha = int(input("Selecione o código do combustível desejado?:"))
    
if escolha == 1:
    opcao = comb[0]

elif escolha == 2:
    opcao = comb[1]

if escolha == 3:
    opcao = comb[2]

print(f"Você escolheu a opção {opcao}, e recebeu um desconto de R${desc_final} no seu abastecimento. Boa viagem!!! ")



