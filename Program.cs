using System;

namespace imcexer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];
            double[] altura = new double[3];
            double[] peso = new double[3];

            for (int i = 0; i < 3; i++)
            {
                
            Console.WriteLine("Digite o seu nome:");
            nome[i]= Console.ReadLine();

            Console.WriteLine("Digite a sua altura:");
            altura[i] = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o seu peso:");
            peso[i] = double.Parse(Console.ReadLine());  

            Console.WriteLine($"{nome[i]} seu IMC é: {peso[i]/(altura[i]*altura[i])}");
            }

            
        }
    }
}
