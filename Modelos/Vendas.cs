//namespace Mercado.Modelos;
internal class Vendas
//{
//    private List<Estoque> saida = new List<Estoque>();

//    public int Saida { get; }
//    public Vendas(int saida)
//    {
//        if (saida <= 0) saida = 0;
//        Saida = saida;
//    }
//}


{
    private static void Main(string[] args)
    {
        //EXEMPLO DE ESTOQUE
        int estoqueTotal = 3400;

        //EXEMPLO PARA VENDAS
        int[] vendasPorDia = { 10, 20, 30, 110, 35, 100, 300, 1 };

        //CALCULA A MÉDIA DE VENDAS NO MÊS
        int totalVendas = 0;
        foreach (int vendas in vendasPorDia)
        {
            totalVendas += vendas;
        }
        double mediaVendasDiaria = totalVendas / vendasPorDia.Length;

        Console.WriteLine($"media de vendas diaria: {mediaVendasDiaria}");

        //VERIFICA O RESTANTE DO ESTOQUE
        int estoqueRestante = estoqueTotal - totalVendas;

        // AJUSTA O PREÇO DO PRODUTO COM BASE NA MÉDIA DE VENDAS
        double precoProduto = 100; // Preço inicial do produto

        Console.WriteLine($"\nEstoque inicial: {estoqueTotal}");
        Console.WriteLine($"Total de vendas: {totalVendas} em {vendasPorDia.Length} dias!");
        Console.WriteLine($"Estoque atual: {estoqueRestante}");
        Console.WriteLine();

        if (mediaVendasDiaria > 50)
        {
            precoProduto *= 1.2; // Aumenta o preço em 20%
            Console.WriteLine("A média de vendas está acima de 40%. O preço do produto foi aumentado.");
            Console.WriteLine("Novo preço do produto: $" + precoProduto);
        }
        else if (mediaVendasDiaria <= 20)
        {
            precoProduto *= 0.8; // Diminui o preço em 20%
            Console.WriteLine("A média de vendas está abaixo de 20%. O preço do produto foi diminuído.");
            Console.WriteLine("Novo preço do produto: $" + precoProduto);
        }
        else
        {
            Console.WriteLine("A média está dentro de vendas está dentro do esperado");
            Console.WriteLine("Preço se mantem: $" + precoProduto);
        }
    }
}