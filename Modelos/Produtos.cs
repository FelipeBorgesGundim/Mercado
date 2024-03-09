namespace Mercado.Modelos;
internal class Produto
{
    public Produto(string nome)
    {
        Nome = nome;

    }
    public string Nome { get; }
    public int CodBarras { get; }
    public double Preco { get; }
    

    override public string ToString()
    {
        return $"Nome: {Nome}, Código de Barras: {CodBarras}, Valor Unitario: {Preco}.";
    }

}
