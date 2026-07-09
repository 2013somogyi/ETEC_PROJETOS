#TABUADA
'''
x = 0
num1 = int(input("Digite o número para cálculo"))
while x <= 10:
    resultado = num1 * x
    print(f'{num1} * {x} = {resultado}')
    x += 1
'''
#LETRAS
'''
palavra = input("Digite uma palavra")
for letra in palavra:
    print(letra)
'''

#MERCADINHO
produtos = ["Trakinas", "Doritos", "Toddynho", "Coca"]
codigos = [1, 2, 3, 4]
valores = [2.00, 3.00, 4.00, 5.00]

print("Bem vindo ao mercadinho!")
print(f'{codigos[0]} - {produtos[0]} R$ {valores[0]:.2f}')
print(f'{codigos[1]} - {produtos[1]} R$ {valores[1]:.2f}')
print(f'{codigos[2]} - {produtos[2]} R$ {valores[2]:.2f}')
print(f'{codigos[3]} - {produtos[3]} R$ {valores[3]:.2f}')

x = 0
total = 0
while True:
    num = input("Digite o código do produto, ou digite 0 para finalizar")

    total += num
    x += 1
    print(f'Sua compra deu {total}')
    
