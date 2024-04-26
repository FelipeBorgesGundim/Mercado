namespace Mercado.Menus
{
    public class MenuMostrarProdutosRegistrados : Menu
    {
        public override void Executar(Dictionary<string, List<int>> produtosRegistrados, List<int> codProduto)
        {
            base.Executar(produtosRegistrados, codProduto);
            ExibirTituloDaOpcao("Exibindo todos os Produtos registrados na nossa aplicação");

            foreach (string banda in produtosRegistrados.Keys)
            {
                Console.WriteLine($"Produto: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
