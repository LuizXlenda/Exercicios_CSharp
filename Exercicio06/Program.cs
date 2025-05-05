using System;

class Produto {
    public string nome;
    public double preco;
    public int qtd;

    // construtor 
    public Produto(string nome, double preco, int qtd) {
        this.nome = nome;
        this.preco = preco;
        this.qtd = qtd;
    }

    // vai calcular o total em estoque
    public double Total() {
        return preco * qtd;
    }
}

class Program {
    static void Main() {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++) {
            Console.WriteLine($"\nProduto {i + 1}");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Qtd: ");
            int qtd = int.Parse(Console.ReadLine());

            // vai criar o produto com os dados colocados
            produtos[i] = new Produto(nome, preco, qtd);
        }

        // parte q mostra os produtos cadastrados
        Console.WriteLine("\nProdutos cadastrados:");
        foreach (Produto p in produtos) {
            Console.WriteLine($"Nome: {p.nome}, Preço: R${p.preco}, Qtd: {p.qtd}, Total: R${p.Total()}");
        }
    }
}