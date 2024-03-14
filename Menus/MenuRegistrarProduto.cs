
namespace Mercado.Menus
{
    public class MenuRegistrarProduto : Menu
    {
        public override void Executar(Dictionary<string, List<int>> produtosRegistrados)
        {
            base.Executar(produtosRegistrados);
            ExibirTituloDaOpcao("Registro de Produtos");
            Console.Write("Digite o nome do produto que deseja registrar: ");
            string nomeDoProduto = Console.ReadLine()!;
            produtosRegistrados.Add(nomeDoProduto, new List<int>());
            Console.WriteLine($"O Produto {nomeDoProduto} foi registrada com sucesso!");
            Thread.Sleep(3000);
            Console.Clear();
        }

    }
}
