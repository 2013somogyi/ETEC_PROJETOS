'''
tabuada = int(input("Digite o número para pegar a tabuada: "))

for numero in range(11):
    resultado = tabuada * numero
    print(f"{tabuada} x {numero} = {resultado}")

'''

'''

lista = list(range(11))
tabuada = int(input("Digite o número aí: "))



for numero in lista:
    resultado = tabuada * numero
    print(f"{tabuada} x {numero} = {resultado}")

'''

'''
lista = [0,1,2,3,4,5,6,'mouse',8,9]
i = lista.index('mouse')
print(f'O valor de i é {i}')
print(f"O conteúdo é " + str(lista[i]))

'''

'''

produtos = ['tv', 'calular', 'tablet', 'mouse', 'teclado', 'geladeira', 'forno']
print(produtos)
estoque = [100, 150, 100, 120, 70, 100, 80]

produto = input("Insira o nome do produto em letra minúscula: ")
if produto in produtos:
    i = produtos.index(produto)
    qtd_estoque = estoque[i]
    print(f"Temos {qtd_estoque} unidades de {produto} no estoque.")
else:
    print(f"{produto} não existe no estoque")


# A função .append adiciona dados no array
# A função .remove remove dados do array
# A função .pop recorta o dado do array

'''

lista = []
for item in range(1, 5):
    produto = str(input(f"Digite o {item}° produto: "))
    lista.append(produto)

print(lista)
