# import para limpar o terminal e adicionar "delay" no código
import os
import time

estoque = []
categorias = []
totalVendas = 0

#<--\\--\\--\\--\\--\\--\\--\\--\\--CADASTRAR PRODUTO--\\--\\--\\--\\--\\--\\--\\--\\-->
def cadastrar_produto():
    os.system('cls' if os.name == 'nt' else 'clear')
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("     Cadastrar Produto     ")
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("Digite SAIR ou 0 para retornar ao menu principal")
    while True:

        #++--++--++--NOME--++--++--++#

        nome = input("Digite o nome do produto: ").upper()
        
        #VALIDA
        if nome == "":
            print("O nome do produto não pode ser vazio. Por favor, tente novamente.")
            continue

        if nome == "SAIR" or nome == "0":
            tela_inicial()
            break

        #VALIDAÇÃO NO ESTOQUE
        produto_existe = False
        for produto in estoque:
            if produto["nome"] == nome:
                produto_existe = True
                break
        if produto_existe:
            print("Produto já cadastrado. Por favor, tente novamente.")
            continue

        #++--++--++--CATEGORIAS--++--++--++#
        '''
        print("Categorias disponíveis:\n  1 - Ação\n  2 - Aventura\n  3 - RPG\n  4 - Esportes\n  5 - Estratégia")
        categoria = input("Digite a categoria do produto: ")

        #VALIDA
        if categoria == "":
            print("A categoria do produto não pode ser vazia. Por favor, tente novamente.")
            continue

        if categoria == "0" or categoria == "SAIR":
            tela_inicial()
            break

        elif categoria == "1":
            categoria = "Ação"
        elif categoria == "2":
            categoria = "Aventura"
        elif categoria == "3":
            categoria = "RPG"
        elif categoria == "4":
            categoria = "Esportes"
        elif categoria == "5":
            categoria = "Estratégia"
        else:
            print("Categoria inválida. Por favor, tente novamente.")
            continue 
        '''

        categoria = input("Digite a categoria do produto: ").upper()
        
        #VALIDA
        if categoria == "":
            print("A categoria do produto não pode ser vazio. Por favor, tente novamente.")
            continue

        if categoria == "SAIR" or categoria == "0":
            tela_inicial()
            break

        #++--++--++--QTD ESTOQUE--++--++--++#

        qtd_estoque = int(input("Digite a quantidade em estoque: "))
        
        #VALIDA
        if qtd_estoque <= 0:
            print("A quantidade em estoque não pode ser zero ou negativa. Por favor, tente novamente.")
            continue

        if qtd_estoque == "SAIR":
            tela_inicial()
            break
        
        #++--++--++--PREÇO--++--++--++#

        preco = float(input("Digite o preço do produto: "))
        
        #VALIDA
        if preco <= 0 or preco == "":
            print("O preço do produto não pode ser zero ou negativo. Por favor, tente novamente.")
            continue

        if preco == "SAIR":
            tela_inicial()
            break
        
        #++--++--++--APPEND NO ESTOQUE--++--++--++#

        produto = {
            "nome": nome,
            # "categoria": categoria,
            "qtd_estoque": qtd_estoque,
            "preco": preco
        }

        categorias.append(categoria)
        estoque.append(produto)

        print(f"Produto '{nome}' e categoria '{categoria}' cadastrados com sucesso!")
        escolha = input("Deseja continuar? (S/N): ").upper()
        if escolha == "S":
            cadastrar_produto()
        else:
            tela_inicial()
    return

#<--\\--\\--\\--\\--\\--\\--\\--\\--CONSULTAR ESTOQUE--\\--\\--\\--\\--\\--\\--\\--\\-->
def consultar_estoque():
    os.system('cls' if os.name == 'nt' else 'clear')
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("     Consultar Estoque     ")
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")







    #++--++--++--MOSTRA ESTOQUE--++--++--++#
    if len(estoque) == 0:
        print(">>>>>>>>>>>>>>>>>>>>>>")
        print(" O ESTOQUE ESTÁ VAZIO! ")
        print(">>>>>>>>>>>>>>>>>>>>>>")

    else:
        print("Estoque:")
        for produto in estoque:
            print(f"Nome: {produto['nome']}\n Categoria: {categorias[estoque.index(produto)]}\n Quantidade em Estoque: {produto['qtd_estoque']}\n Preço: R${produto['preco']:.2f}\n")
            continue









    escolha = input("Digite SAIR ou 0 para retornar ao menu principal: ")
    if escolha == "SAIR" or escolha == "0":
        tela_inicial()

#<--\\--\\--\\--\\--\\--\\--\\--\\--REALIZAR VENDA--\\--\\--\\--\\--\\--\\--\\--\\-->
def realizar_venda():
    os.system('cls' if os.name == 'nt' else 'clear')
    
    #CHAMADA DA VARIAVEL GLOBAL
    global totalVendas

    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("      Realizar Venda       ")
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("Digite SAIR ou 0 para retornar ao menu principal")

    print("Estoque:")
    i = 0
    for produto in estoque:
        print((f"{i+1} - Nome: {produto['nome']}\n Quantidade em Estoque: {produto['qtd_estoque']}\n Preço: R${produto['preco']:.2f}\n"))
        i += 1
        continue

        #++--++--++--PRODUTO VENDIDO--++--++--++#

    while True:

        venda = input("Digite o nome do produto a ser vendido: ").upper()

        #VALIDA
        if venda == "":
            print("O nome do produto não pode ser vazio. Por favor, tente novamente.")
            continue
        
        if venda == "SAIR" or venda == "0":
            tela_inicial()
            break

        #++--++--++--QTD VENDIDA--++--++--++#
        qtd_venda = int(input("Digite a quantidade a ser vendida: "))

        #VALIDA
        if qtd_venda <= 0 or qtd_venda == "":
            print("A quantidade a ser vendida deve ser maior que zero. Por favor, tente novamente.")
            continue

        if qtd_venda == "SAIR":
            tela_inicial()
            break
        
        #VALIDAÇÃO NO ESTOQUE 
        produto_encontrado = False
        for produto in estoque:
            if produto["nome"] == venda:
                produto_encontrado = True

                #++--++--++--LÓGICA DE VENDA--++--++--++#
                if qtd_venda <= produto["qtd_estoque"] and qtd_venda > 0:
                    
                    #ATUALIZA O ESTOQUE E O TOTAL DE VENDAS
                    produto["qtd_estoque"] -= qtd_venda

                    #SOMA O VALOR DA VENDA AO TOTAL DE VENDAS
                    totalVendas += qtd_venda * produto["preco"]
                    print(f"Venda realizada com sucesso! Total da venda: R${qtd_venda * produto['preco']:.2f}")
                    break 
                else:
                    print("Quantidade insuficiente em estoque. Por favor, tente novamente.")
                    break
                
        if produto_encontrado == False:
            print("Produto não encontrado. Por favor, tente novamente.")
        escolha = input("Deseja continuar? (S/N): ").upper()
        if escolha == "S":
            realizar_venda()
        else:
            tela_inicial()
    return

#<--\\--\\--\\--\\--\\--\\--\\--\\--RELATÓRIO GERAL--\\--\\--\\--\\--\\--\\--\\--\\-->
def relatorio_geral():
    os.system('cls' if os.name == 'nt' else 'clear')
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    print("      Relatório Geral      ")
    print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
    
    #++--++--++--LÓGICA NUMERAÇÃO--++--++--++#
    print("Estoque:")
    i = 0
    for produto in estoque:
        i += 1
        print(f"{i} - Nome: {produto['nome']}\n Quantidade em Estoque: {produto['qtd_estoque']}\n Preço: R${produto['preco']:.2f}\n")
        continue

    #++--++--++--VALOR TOTAL DO ESTOQUE--++--++--++#
    valor_total_estoque = sum(produto['qtd_estoque'] * produto['preco'] for produto in estoque)
    print(f"Valor Total do Estoque: R${valor_total_estoque:.2f}")
    print(f"Valor Total das Vendas: R${totalVendas:.2f}")

    escolha = input("Digite SAIR ou 0 para retornar ao menu principal: ")
    if escolha == "SAIR" or escolha == "0":
        tela_inicial()

#<--\\--\\--\\--\\--\\--\\--\\--\\--BUSCAR PRODUTO--\\--\\--\\--\\--\\--\\--\\--\\-->
def buscar_produto():
    while True:
        os.system('cls' if os.name == 'nt' else 'clear')
        print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")
        print("      Buscar Produto      ")
        print("|_|_|_|_|_|_|_|_|_|_|_|_|_|")

        busca = input("Digite o nome do produto a ser buscado: ").upper()

        #VALIDA
        if busca == "":
            print("O nome do produto não pode ser vazio. Por favor, tente novamente.")
            input("Pressione Enter para continuar...")
            continue

        if busca == "SAIR" or busca == "0":
            tela_inicial()
            return

        produto_encontrado = False
        for produto in estoque:
            if produto["nome"] == busca:
                produto_encontrado = True
                print(f"Produto encontrado:\n Nome: {produto['nome']}\n Categoria: {categorias[estoque.index(produto)]}\n Quantidade em Estoque: {produto['qtd_estoque']}\n Preço: R${produto['preco']:.2f}\n")
                break

        if produto_encontrado == False:
            print("Produto não encontrado. Por favor, tente novamente.")

        escolha = input("Deseja continuar? (S/N): ").upper()
        if escolha == "S":
            continue
        else:
            tela_inicial()
            return

#<--\\--\\--\\--\\--\\--\\--\\--\\--TELA INICIAL--\\--\\--\\--\\--\\--\\--\\--\\-->

def tela_inicial():
    os.system('cls' if os.name == 'nt' else 'clear')
    print("--------------------------")
    print("      PEDRITO GAMES      ")
    print("--------------------------")
    print("1 - Cadastrar Produto")
    print("2 - Consultar Estoque")
    print("3 - Realizar Venda")
    print("4 - Relatório Geral")
    print("5 - Buscar Produto")
    print("0 - Encerrar Sistema")
    print("--------------------------")
    opcao = input("Digite a opção desejada: ")
    if opcao == "1":
        cadastrar_produto()
    elif opcao == "2":
        consultar_estoque()
    elif opcao == "3":
        realizar_venda()
    elif opcao == "4":
        relatorio_geral()
    elif opcao == "5":
        buscar_produto()
    elif opcao == "0":
        os.system('cls' if os.name == 'nt' else 'clear')
        print("Encerrando o sistema...")
        time.sleep(2)
        os.system('cls' if os.name == 'nt' else 'clear')
        print("Sistema encerrado.")
        exit()
    else:
        print("Opção inválida. Por favor, tente novamente.")
        tela_inicial()

tela_inicial()