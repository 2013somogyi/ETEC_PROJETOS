nmr = int(input("Digite o número para consultar a tabuada:"))

# x = 0
# while x <=10:
#     resultado = nmr * x
#     print(f"{nmr} x {x} = {resultado}")
#     x = x + 1

tabuada = [1,2,3,4,5,6,7,8,9,10]
for numero in tabuada:
    resultado = numero * nmr
    print(f"{nmr} x {numero} = {resultado}")
