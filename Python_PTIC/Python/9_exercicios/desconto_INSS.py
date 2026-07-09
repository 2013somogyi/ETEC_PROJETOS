salario = float(input("Digite seu salário:"))


if salario <= 1693.72:
    salario = salario - (salario * 0.08)
    print(f"Seu salário recebeu um desconto de 8% do INSS, ficando R${salario}.")

elif salario > 1693.72 and salario <= 2822.90:
    salario = salario - (salario * 0.09)
    print(f"Seu salário recebeu um desconto de 9% do INSS, ficando R${salario}.")

else:
    salario = salario - (salario * 0.11)
    print(f"Seu salário recebeu um desconto de 11% do INSS, ficando R${salario}.")