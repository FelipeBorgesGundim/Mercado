public class Produto
{
    public Produto(string nome, int codBarras, double preco)
    {
        Nome = nome;
        CodBarras = codBarras;
        Preco = preco;
    }

    public string Nome { get; }
    public int CodBarras { get; }
    public double Preco { get; }
    public int Validade { get; set; }

    
    override public string ToString()
    {
        return $"Nome: {Nome}, Código de Barras: {CodBarras}";
    }
   
}
