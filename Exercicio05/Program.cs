using System;
class Program {
    static void Main() {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine();

        string texto = entrada.Replace(" ", "").ToLower();

        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        
        string textoInvertido = new string(array);

        if (texto == textoInvertido)
        {
            Console.WriteLine("É um palíndromo.");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }





    }

}