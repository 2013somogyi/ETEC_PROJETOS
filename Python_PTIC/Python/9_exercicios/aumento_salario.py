nome = input("Digite seu nome:")
salario = float(input("Digite o valor do seu salário:"))

if salario <= 2100:
    salario = salario + (salario * 0.05)
    print(f"{nome}, seu salário com aumento ficou R${salario}.")

else:
    salario = salario + (salario * 0.02)
    print(f"{nome}, seu salário com aumento ficou R${salario}.")
    