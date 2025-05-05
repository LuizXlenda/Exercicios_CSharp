using System;

class Program {
    static void Main() {
        int[] numeros = new int[10];
        int soma = 0;

        // vai ler 10 números do usuário
        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // vai verificar se o número é par e  ent somar
            if (numeros[i] % 2 == 0) {
                soma += numeros[i];
            }
        }

        // resultado
        Console.WriteLine($"\nSoma dos números pares: {soma}");
    }
}
