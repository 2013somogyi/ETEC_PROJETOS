'''

palavra = "Paralelepipedo"
for letra in palavra:
    print(letra)
    
lista = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1]
for dados in lista:
    print(dados)

x = 0
num1 =int(input("Digite o número da tabuada desejada:"))
while x <= 10:
    result = num1 * x
    print(f'{num1} * {x} = {result}')
    x += 1

    '''

'''
nome = input("Digite o nome do aluno:")
n = 0
qtd = int(input("Digite quantas notas serão utilizadas para calcular a média:"))

total = 0
while qtd > n:
    dig = float(input("Digite a nota do aluno:"))
    total += dig
    n += 1
media = total / qtd
if media >= 7:
    status = "Aprovado"
else:
    status = "Reprovado"
print(f'A média do {nome} foi {media:.2f}, portanto ele está {status}!!!')

'''


nome = input("Digite o nome do aluno:")
n = 0
total = 0   
while True:
    dig = input("Digite a nota do aluno, ou digite FIM para encerrar:")
    if dig.upper() == "FIM":
        break
    total += float(dig)
    n += 1
media = total / n
if media >= 7:
    status = "Aprovado"
else:
    status = "Reprovado"
print(f'A média do {nome} foi {media:.2f}, portanto ele está {status}!!!')