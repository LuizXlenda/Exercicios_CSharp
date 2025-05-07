using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluida = new List<bool>();

        string opcao;

        do{
            Console.WriteLine("=== Lista de Tarefas ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao){
                case "1":
                    Console.Write("Digite a nova tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    concluida.Add(false);
                    break;

                case "2":
                    Console.WriteLine("\nTarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluida[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    Console.WriteLine("\nPressione Enter para continuar...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa a marcar como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int numero) &&
                        numero >= 1 && numero <= tarefas.Count)
                    {
                        concluida[numero - 1] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    Console.ReadLine();
                    break;

                case "0":
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Console.ReadLine();
                    break;
            }

        } while (opcao != "0");
    }
}

