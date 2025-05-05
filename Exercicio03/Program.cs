using System;

class Program
{
    static void Main()
    {
       Console.Write("Digite um numero positivo para fatorar: ");
        int numero = int.Parse(Console.ReadLine());
        uint fatorial = 1;
        int contador = numero;

        if (numero < 0){
            Console.WriteLine("Numero invalido. Digite um numero maior que zero.");
            return;
        }

        while (contador > 0){
            fatorial *= (uint)contador;
            Console.WriteLine($"{numero}! :|{fatorial}");
            contador--;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }

    
}


