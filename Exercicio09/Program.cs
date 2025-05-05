using System;

class Program {
    static void Main() {
        // esse treco (random) cria um gerador de número aleatório
        // random é uma classe do C# que serve para gerar números aleatórios, não consegui pensar em outra maneira para fazer oq ele pede.
        Random random = new Random();

        // vai um número aleatório entre 1 e 100
        int numSecreto = random.Next(1, 101);

        int tentativas = 0;
        int palpite;

        Console.WriteLine("Adivinhe o número entre 1 e 100!");

        // repeticão até o usuário acertar 
        do {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            // dicas
            if (palpite < numSecreto) {
                Console.WriteLine("O número é maior!");
            } else if (palpite > numSecreto) {
                Console.WriteLine("O número é menor!");
            }

        } while (palpite != numSecreto);

        // se acertar ent mostra isso
        Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
    }
}