using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());

        for(int i=0; i<10; i++){
            double res = numero * i;
            Console.WriteLine($"{numero} x {i} = {res}");
        }

        
    }

    
}

