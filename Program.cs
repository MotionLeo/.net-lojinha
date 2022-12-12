// See https://aka.ms/new-console-template for more information
namespace armazem;

class Lojinha
{
    public static void Main(string[] args)
    {
        int opc = 0;
        List<Produtos> produtos = new List<Produtos>();

        //produtos.Add(new Produtos (1, "Alface", 4));
        //produtos.Add(new Produtos (2, "Beterraba", 8));

        do{
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Escolha uma opção:\n1-Cadastrar novo produto\n"+
                "2-Listar todos os produtos\n3-Calcular quantidade total de estoque\n4-Sair");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Cadastro de Produto selecionado");
                    int idProd = produtos.Count() + 1;
                    Console.WriteLine($"ID desse produto: {idProd}");
                    Console.WriteLine("Digite o nome do produto: ");
                    string nomeProd = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade do produto: ");
                    int qtdProd = Convert.ToInt16(Console.ReadLine());
                    produtos.Add(new Produtos (idProd, nomeProd, qtdProd));


                    Console.WriteLine("Cadastro finalizado");
                    break;
                case 2:
                    Console.WriteLine("-------------------------------");
                    if(produtos.Count() > 0){    
                        foreach(Produtos produto in produtos)
                        {
                            Console.WriteLine($"ID: {produto.id}, Nome: {produto.nome}, Quantidade: {produto.qtd}");
                        }
                    }else{
                        Console.WriteLine("Lista de produtos vazia");
                    }
                    break;
                case 3:
                    Console.WriteLine("-------------------------------");
                    int qtdTotal = 0;
                    if(produtos.Count() > 0){
                        foreach(Produtos qtdDoProd in produtos)
                        {
                            qtdTotal += qtdDoProd.qtd;
                        }
                        Console.WriteLine($"Quantidade total dos produtos em estoque: {qtdTotal}");
                    }else{
                        Console.WriteLine("Lista de produtos vazia");
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }

            /*foreach(Produtos produto in produtos)
            {
                Console.WriteLine(produto.nome);
            }

            Console.WriteLine(produtos.Count());*/

        }while (opc != 4);
    }
}

class Produtos
{
    public int id {get; set;}
    public string nome {get; set;}
    public int qtd {get; set;}

    public Produtos (int id, string nome, int qtd)
    {
        this.id = id;
        this.nome = nome;
        this.qtd = qtd;
    }

}

