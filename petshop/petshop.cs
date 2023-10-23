using System;
using Petshop.Models;
class Program
{
    public static  int diaDaSemana(int ano, int mes, int dia)
    {
        DateTime dateValue = new DateTime(ano, mes, dia);
        return ((int)dateValue.DayOfWeek);
    }
    public static int meuCaninoFeliz(int data, int pequenos, int grandes)
    {
        int valorTotal;
        //Dias de semana:
        if (data >= 1 && data <= 5)
        {
            int banhoP = 0, banhoG = 0;
            banhoP = 20 * pequenos;
            banhoG = 40 * grandes; 
            valorTotal = banhoP + banhoG;
            return valorTotal;
        }
        //Final de semana:
        else
        {
            int banhoP = 0, banhoG = 0;
            banhoP = (20 + (20 * 20 / 100)) * pequenos;
            banhoG = (40 + (40 * 40 / 100)) * grandes;
            valorTotal = banhoP + banhoG;
            return valorTotal;
        }
    }
    public static int vaiRex(int data, int pequenos, int grandes)
    {
        int valorTotal;
        //Dias de semana:
        if (data >= 1 && data <= 5)
        {
            int banhoP = 0, banhoG = 0;
            banhoP = 15 * pequenos;
            banhoG = 50 * grandes;
            valorTotal = banhoP + banhoG;
            return valorTotal;
        }
        //Final de semana:
        else
        {
            int banhoP = 0, banhoG = 0;
            banhoP = 20 * pequenos;
            banhoG = 55 * grandes;
            valorTotal = banhoP + banhoG;
            return valorTotal;
        }
    }
    public static int chowChawgas(int data, int pequenos, int grandes)
    {
        int valorTotal;
        int banhoP = 0, banhoG = 0;
        banhoP = 30 * pequenos;
        banhoG = 45 * grandes;
        valorTotal = banhoP + banhoG;
        return valorTotal;
    }
    public static string melhorPetshop(int valorcf, int valorvr, int valorcc, out int preco)
    {
        preco = 0;
        int menorvalor = int.MaxValue;
        string empresa = "Empresa";
        if(valorcf != valorcc || valorcf != valorvr || valorvr != valorcc)
        {
            
            if(menorvalor > valorcc)
            {
                menorvalor = valorcc;
                empresa = "ChowChawgas";
            }
            if(menorvalor > valorcf)
            {
                menorvalor = valorcf;
                 empresa = "Meu Canino Feliz";
            }
            if(menorvalor > valorvr)
            {
                menorvalor = valorvr;
                empresa = "Vai Rex";
            }
            preco = menorvalor;
            return empresa;
        }
        else
        {
            if (valorcf != valorcc || valorcf != valorvr || valorvr != valorcc)
            {
                preco = valorcc;
                return "ChowChawgas";
            }
            if (valorcf == valorvr)
            {
                preco = valorvr;
                return "Vai Rex";
            }
            else if (valorcf == valorcc)
            {
                preco = valorcc;
                return "ChowChawgas";
            }
            else
            {
                preco = valorcc;
                return "ChowChawgas";
            }
        }
    }
    static void Main(string[] args)
    {
        int qtdPequeno, qtdGrande, dia, mes, ano;
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
        int data = diaDaSemana(ano, mes, dia);
        int valorcf =  new Petshop(data, qtdPequeno, qtdGrande), valorvr = vaiRex(data, qtdPequeno, qtdGrande), valorcc = chowChawgas(data, qtdPequeno, qtdGrande), melhorPreco;
        string melhorEmpresa = melhorPetshop(valorcf, valorvr, valorcc,out melhorPreco);
        Console.WriteLine($"{melhorEmpresa} {melhorPreco}");

    }
}