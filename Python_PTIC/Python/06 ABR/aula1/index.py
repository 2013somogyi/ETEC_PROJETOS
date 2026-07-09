#EntradaNome
aluno = input('Ponhe teu nome aí:')

#EntradaNota
n1 = float(input('Digite a nota aí:'))
n2 = float(input('Digite outra nota aí:'))
n3 = float(input('Digite mais uma nota aí:'))
n4 = float(input('Digita a nota aí:'))

#Processamento
media = (n1 + n2 + n3 + n4) / 4
if media >= 7:
    print(f'{aluno}Tu foi aprovado com {media}, parabéns')

elif media >= 5 and media <=6.99:
    print(f'{aluno}, seu bisonho, tu ficou de recuperação com {media}')

else:
    print(f'{aluno}, tu foi REPROVADO, com {media}')

#Saída
#print(f'{aluno}, seu bobalhão...Sua nota é: {media}')


#---------------------2°Código-----------------------#
'''
print('Ola Mundo')
print('Ola \nMundo')
print('=' *100) # Insere 100 vezes o sinal de =
print('3 + 4 =', 3+4) # Adição
print('3 - 4 =', 3-4) # Subtração
print('2 * 5 =', 2*5) # Multiplicação
print('20 * 5 =', 20/5) # Divisão
print('3 elevado a 2 =', 3**2) # Potenciação
print('Nota1:10 Nota2:8 -> Média = ', (10+8)/2) # Média
'''