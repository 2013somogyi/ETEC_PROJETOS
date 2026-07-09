'''
s = ['SOMA', 'ISSO', 'AI']
cont = len(s)  # A função len faz a contagem da quantidade de caracteres da variavel 's'
print(cont)

'''

#IMC
print('CÁLCULO DE IMC')
#Coleta
altura = float(input('Qual a sua altura?'))
peso = float(input('Qual é o seu peso?'))

#Processamento
imc = peso/(altura*altura)

#Saídas
if imc <= 18.5:
    print(f'Seu IMC é {imc:.2f}", você está abaixo do peso!')
elif imc > 18.5 and imc <= 24.9:
    print(f'Seu IMC é {imc:.2f}, você está no peso ideal')
elif imc >= 25 and imc <= 29.9:
    print(f'Seu IMC é {imc:.2f}, você está acima do peso')
elif imc >= 30 and imc <= 34.9:
    print(f'Seu IMC é {imc:.2f}, você está com tipo Obesidade I')
elif imc >=35 and imc <= 39.9:
    print(f'Seu IMC é {imc:.2f}, você está com tipo Obesidade II')
elif imc >= 40:
    print(f'Seu IMC é {imc:.2f}, você está com tipo Obesidade III')
else:
    print('Você digitou valores inválidos')
    
    

#Calculadora
print('CALCULADORA')
#Coleta
nmr1 = float(input('Digite o primeiro número:'))
nmr2 = float(input('Digite o segundo número:'))
calc = 'SOMA | SUBTRAÇÃO | MULTIPLICAÇÃO | DIVISÃO'
print(calc)
operacao = input('Digite a operação desejada:')

#Processamento e Saídas
if operacao == 'Soma':
    soma = nmr1 + nmr2
    print(f'Seu resultado é: {soma:.2f}')
elif operacao == 'Subtração':
    subtracao = nmr1 - nmr2
    print(f'Seu resultado é: {subtracao:.2f}')
elif operacao == 'Multiplicação':
    multiplicaçao = nmr1 * nmr2
    print(f'Seu resultado é: {multiplicaçao:.2f}')
elif operacao == 'Divisão':
    divisao = nmr1 / nmr2
    print(f'Seu resultado é: {divisao:.2f}')
else:
    print('Você digitou valores inválidos')
    


#Ajuste de Salário
print('AJUSTE DE SALÁRIO')
#Coleta
nome = input('Digite o nome do funcionário:')
salario = float(input('Digite o salário do funcionário:'))
ajuste = int(input('Digite o ajuste desejado em porcentagem:'))

#Processamento
resultado = (salario * ajuste)/100

#Saídas
print(f'{nome},o salário reajustado fica:{resultado:.2f}')