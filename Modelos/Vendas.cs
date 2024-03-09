namespace Mercado.Modelos;
class Vendas
{
    private List<Estoque> saida = new List<Estoque>();

    public int Saida { get; }
    public Vendas(int saida)
    {
        if (saida <= 0) saida = 0;
        Saida = saida;
    }
}