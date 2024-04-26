
namespace Mercado.Menus;

internal class MenuAdiconarQuantidade : Menu
{

    public override void Executar(Dictionary<string, List<int>> produtosRegistrados, List<int> codProduto)
    {
            base.Executar(produtosRegistrados, codProduto);
            ExibirTituloDaOpcao("Adicionar Quantidade de produto Cadastrado:");
            Console.Write("Digite o nome do produto que deseja adicionar no estoque: ");
            string nomeDoProduto = Console.ReadLine()!;
            if (produtosRegistrados.ContainsKey(nomeDoProduto))
            {
                Console.Write($"Qual a quantidade do {nomeDoProduto} deseja adicionar: ");
                int qtd = int.Parse(Console.ReadLine()!);
                produtosRegistrados[nomeDoProduto].Add(qtd);
                Console.WriteLine($"\nA Quantidade {qtd} foi registrada com sucesso para o produto {nomeDoProduto}");
                Thread.Sleep(2000);
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
