namespace Mercado.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, List<int>> produtosRegistrados, List<int> codProduto)
        {
            Console.Clear();
            Console.WriteLine("Portas Fechadas :)");
            Environment.Exit(0);
        }
    }
}
