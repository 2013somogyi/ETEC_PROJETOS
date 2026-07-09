produtos = []
estoque = []

for valores in range(0, 3):
    produto = input('Digite o novo produto: ')
    qtd = input('Digite a quantidade do novo produto: ')
    produtos.append(produto)
    estoque.append(qtd)

for itens in range(0, 3):
    print(f"{estoque[itens]} unidades do item - {produtos[itens]}!")
    
# A função .index percorre o array procurando a posição no indice do dado solicitado

produto = ["Tablet", "Calular", "Tv"]

i = produto.index()

print(i)