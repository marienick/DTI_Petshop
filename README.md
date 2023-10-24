# Programa para Comparação de Preços de Petshops.
## Tabela de conteúdos do README:
- Premissas Assumidas (##prememissas-assumidas)
-  Decisões do Projeto (##decisões-do-projeto)
- Instruções Para Executar o Projeto (##instruções-para-executar-o-projeto)
## Premissas assumidas:
**1-Variação nos valores dos banhos:** Todos os três petshops oferecem valores distintos para os seus serviços.
**2-Acréscimo nos preços:** Nos petshops "Meu Canino Feliz" e "Vai Rex" há um acrescimo no valor habitual dos banhos nos fins de semana, por exemplo: nos fins de semana o banho no Meu Canino Feliz tem um aumento de 20%.
**3-Facilidade para saber o melhor petshop:** Com este programa o usuário só necessita saber o dia desejado para o banho e a quantidade de cães grandes e pequenos para descobrir qual petshop é mais acessível para ele.
## Decisões do Projeto:
Algumas decisões de projeto importantes incluem:
1- Utilização da linguagem C# para o desenvolvimento deste programa;
2- Criação da Classe Petshop com os atributos necessários para se calcular o valor do banho, além de utilizar um array para armazenar os 3 petshops fixos que foram pediddos no enunciado do teste;
3- Estruturação do programa em classes distintas (Petshop, Controller e Program) para tornar o código mais organizado e legível.
## Instruções para executar o sistema:
## Pré requisitos:
- Possuir um ambiente de desenvolvimento C#  configurado na sua máquina;
## Executando o Programa:
- Clone este repositório para sua máquina local:
bash
git clone https://github.com/seu-usuario/seu-repositorio.git
- Navegue até o diretório do programa:
bash
cd seu-repositorio
- Compile o programa:
bash
csc Program.cs
- Execute o Programa:
bash
mono Program.exe
- O programa pedirá para que você insira a data desejada para o banho (dia/mês/ano) e a quantidade de cães pequenos e grandes que você deseja dar banho.
- Depos de inserir esses dados o programa vai retornar qual é o petshop mais acessível e informará o preço total de acordo com os dados inseridos.
  
