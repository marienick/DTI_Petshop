using System;
using Model;
using Controllers;
class Program
{

    static void Main(string[] args)
    {
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
        bool data = Controller.diaDaSemana(ano, mes, dia);
        string melhorPetshop = controller.melhorPetshop(data, qtdPequeno, qtdGrande, out preco);
        Console.WriteLine(melhorPetshop + " " + preco);
    }
}