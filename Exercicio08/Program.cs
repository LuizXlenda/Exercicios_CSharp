using System;

class Program
{
    static void Main(){
       
       Console.WriteLine("==========Calculadora de IMC==========");
       Console.WriteLine("Digite seu peso(kg):");
       double peso = double.Parse(Console.ReadLine());
       Console.WriteLine("Digite sua altura(m):");
       double altura = double.Parse(Console.ReadLine());

       double imc = peso / Math.Pow(altura, 2);

       Console.WriteLine($"Seu IMC é: {imc:F2}");

       if(imc <= 18.5) {
			Console.WriteLine("Classificação: Abaixo do peso.");
		}else if(imc > 18.5 && imc < 24.9) {
			Console.WriteLine("Classificação: Peso ideal.");
		}else if(imc > 25.0 && imc < 29.9) {
			Console.WriteLine("Classificação: Sobrepeso.");
		}else if(imc >= 30.0) {
			Console.WriteLine("Classificação: Obesidade.");
		}
            




       




    }

    
}



