using System;

class Program
{
    static void Main(){
       
       int opcao;
       
       
       do{

            Console.WriteLine("Selecione uma conversão: ");
            Console.WriteLine("[1] Celsius para Fahrenheit");
            Console.WriteLine("[2] Fahrenheit para Celsius");
            Console.WriteLine("[3] Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    Console.WriteLine("Digite a temperatura em Celsius: ");
                    double cel = double.Parse(Console.ReadLine());
                    double fah = cel * 9/5 + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é: {fah}°F");
                    break;
                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    double fah1 = double.Parse(Console.ReadLine());
                    double cel1 = 5/9 * (fah1 - 32);
                    Console.WriteLine($"A temperatura em Celsius é: {cel1}°C");
                    break;
                case 3:
                    Console.WriteLine("Programa encerrado!");
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;   
            } 


         }while(opcao != 3);

            



       




    }

    
}


