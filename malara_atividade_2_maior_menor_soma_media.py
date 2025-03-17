print("****************************")
print("*** Escolha 10 numeros ***")
print("****************************")

maior = float('-inf') 
menor = float('inf')

for i in range(10):
    x = int (input ('Digite aqui: '))
    
    
    if x > maior:
        maior = x 
        
    if x < menor:
        menor = x
        

soma = maior + menor 

media = soma / 2

print("O maior numero digitado é: {maior}", (maior))
print('O menor numero digitado é: {menor}', (menor))
print('A soma do maior e menor numero digitado é: {soma}', (soma))
print('A media numero digitado é: {media} ', (media))