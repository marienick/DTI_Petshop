using System;
using Model;
using Controllers;

class Program
{
    static void Main(string[] args)
    {
        //criei um objeto controller
        Controller controller = new Controller();
        int qtdPequeno, qtdGrande, dia, mes, ano;
        decimal preco;
        string dados;
        Console.WriteLine("Digite o dia/mês/ano e a quantidade de cachorros pequenos e grandes que você deseja mandar para tomar banho:\nExemplo: 03/08/2018 3 5");
        dados = Console.ReadLine();
        string[] array = dados.Split('/');
        dia = int.Parse(array[0]);
        mes = int.Parse(array[1]);
        string[] array2 = array[2].Split(" ");
        ano = int.Parse(array2[0]);
        qtdPequeno = int.Parse(array2[1]);
        qtdGrande = int.Parse(array2[2]);
        //esse controller antes das funções significa que essas funções pertencem a classe Controller
        bool data = Controller.diaDaSemana(ano, mes, dia);
        string melhorLugar = controller.melhorPetshop(controller.petshops, data, qtdPequeno, qtdGrande, out preco);
        Console.WriteLine("\nO melhor Petshop para estas condições é "+ melhorLugar + " no valor total de: R$" + preco.ToString("0.00"));

    }
}
