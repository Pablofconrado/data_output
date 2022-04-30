using System;
using System.Globalization;


namespace Comandos_de_saída
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 26;
            double saldo = 10.35784;
            string nome = "Maria";
            char genero = 'f';


            Console.WriteLine(idade);
            //WriteLine quebra a linha 
            Console.WriteLine(saldo);
            Console.Write(nome);
            //Write não quebra a linha 
            Console.WriteLine(genero);
            Console.WriteLine("---------------------------");
            Console.WriteLine(saldo.ToString("F2"));
            //ToString("F*" determina número de casas
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
            //cultureinfo.InvariantCulture - Mudança de "," para "."

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //PlaceHolders

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //Interpolação

            Console.WriteLine(nome + "tem" +  idade + "anos e tem saldo igual a" + saldo.ToString("F2", CultureInfo.InvariantCulture) + "reais");
        }   //Concatenação
    }
}
