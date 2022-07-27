// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Net;


namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int = armazena numeros Inteiros -1234 ou 4321
            // Float = -12,3 ou 32,1...
            // Bool (Boolean) - true our false
            // String - " "
            // Char - ''
            Console.WriteLine("Qual sua Idade?: ");
            var idade = int.Parse(Console.ReadLine());


            if ((idade >= 0) && (idade <= 3))
            {
                Console.WriteLine("você é Bebê");
            }
            else if((idade >= 4) && (idade <= 10))
            {
                Console.WriteLine("você é Criança");
            }
            else if ((idade >= 11) && (idade <= 17))
            {
                Console.WriteLine("você é Adolescente");
            }
            else if ((idade >= 18 && idade <= 59))
            {
                Console.WriteLine("você é Adulto(a)");
            }
            else
            {
                Console.WriteLine("você é Idoso");
            }
        }

    }











    }
}