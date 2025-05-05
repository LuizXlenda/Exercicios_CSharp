using System;

class Program
{
    
    static bool VerificaMaiuscula(string texto){
        foreach (char c in texto)
        {
            if (char.IsUpper(c))
                return true;
        }
        return false;
    }

    static bool VerificaNumero(string texto){
        foreach (char c in texto)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }

    static bool VerificaCharEspecial(string texto){
        foreach (char c in texto)
        {
            if (!char.IsLetterOrDigit(c))
                return true;
        }
        return false;
    }

    static bool ValidarSenha(string senha)
    {
        return senha.Length >= 8 && VerificaMaiuscula(senha) && VerificaNumero(senha) && VerificaCharEspecial(senha);
    }
    static void Main()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        if (ValidarSenha(senha) == true)
        {
            Console.WriteLine("Senha criada!");
        }
        else
        {
            Console.WriteLine("Senha inválida. Certifique-se de que tenha:");
            if (senha.Length < 8){
                Console.WriteLine("- Pelo menos 8 caracteres");
            }

            if (!VerificaMaiuscula(senha)){
                Console.WriteLine("- Pelo menos uma letra maiúscula");
            }

            if (!VerificaNumero(senha)){
                Console.WriteLine("- Pelo menos um número");
            }
            
            if (!VerificaCharEspecial(senha)){
                Console.WriteLine("- Pelo menos um caractere especial (ex: @, #, !)");
            }
        }
    }

    
}

