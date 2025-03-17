print("*********************")
print("**** Atividade 1 ****")
print("*********************")



idade = int(input('Digite sua idade: '))
genero = input("qual seu genero ( M para masculino e F para femino): ").strip().upper()
#upper() remove os espaços extras e strip para evitar erros de digitação
salario = float(input("digite seu salario: "))

if genero == "M" and idade < 18: 
    print("Masculino, com menos de 18 ano")
    
elif genero == "F" and salario > 50000 and idade > 40:
    print("Feminino com Salario a cima de 50.0000,00 e com idade acima de 40")

elif (genero == "M" or genero == "F") and 20 <= idade <= 30:
    print("Masculino ou feminino e idade entre 20 e 30 anos")
    
else: 
    print("Não se encaixa em nenhuma das possibilidades anteriores")
