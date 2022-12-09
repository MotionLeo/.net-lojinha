// See https://aka.ms/new-console-template for more information
namespace armazem;

class Lojinha
{
    public static void Main(string[] args)
    {
        List<Produtos> produtos = new List<Produtos>();

        Console.WriteLine("Escolha uma opção:\n1-\n2-\n3-\n4-");
        int opc = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(opc);

        produtos.Add(new Produtos() { id=1, nome = "Alface", qtd = 4});
        produtos.Add(new Produtos() { id=2, nome = "Beterraba", qtd = 8});

        foreach(Produtos produto in produtos)
        {
            Console.WriteLine(produto.nome);
        }

    }
}

class Produtos
{
    public int id {get; set;}
    public string nome {get; set;}
    public int qtd {get; set;}

}

