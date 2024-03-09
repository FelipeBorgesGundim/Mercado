namespace Mercado.Modelos;
internal class Estoque
{

    private List<int> saida = new List<int>();
    private List<int> entrada= new List<int>();

    public Estoque(string nome)
    {
        Nome = nome;
        this.Quantidade = Quantidade;
    }
    public string Nome { get; }
    public int Quantidade { get => Quantidade; set => Quantidade = value; }
    public List<int> Vendas => saida;

    
    public void AdicionarEstoque(int Quantidade)
    {
        this.Quantidade += Quantidade;
    }
    public void RemoverEstoque(int Quantidade)
    {
        if (Quantidade <= this.Quantidade)
        {
            this.Quantidade -= Quantidade;
        }
        else
        {
            throw new Exception("Quantidade a remover excede o estoque disponível.");
        }
    }

}


