class Estoque
{
    public Estoque(string produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public string Produto { get; set; }
    public int Quantidade{ get; set; }

    override public string ToString()
    {
        return $"Nome: {Produto} - {Quantidade} unidades";
    }
}
