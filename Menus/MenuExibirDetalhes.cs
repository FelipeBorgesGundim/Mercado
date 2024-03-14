
namespace Mercado.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, List<int>> produtosRegistrados)
    {
        base.Executar(produtosRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes do Produto");
        Console.Write("Digite o nome do produto que deseja ver detalhes: ");
        string nomeDoProduto = Console.ReadLine()!;
        if (produtosRegistrados.ContainsKey(nomeDoProduto))
        {
            List<int> qtdProdutos = produtosRegistrados[nomeDoProduto];
            Console.WriteLine($"\nA quantidade do Produto {nomeDoProduto} é {qtdProdutos.Sum()}.");
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nO Produto {nomeDoProduto} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
