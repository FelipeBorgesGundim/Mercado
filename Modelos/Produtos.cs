namespace Mercado.Modelos;
internal class Produto
{
    public Produto(string nome, int codBarras)
    {
        Nome = nome;
        CodBarras = codBarras;

    }
    public string Nome { get; set; }
    public int CodBarras { get; set; }
    public double Preco { get; set; }
    

    override public string ToString()
    {
        return $"Nome: {Nome}, Código de Barras: {CodBarras}, Valor Unitario: {Preco}.";
    }

}
