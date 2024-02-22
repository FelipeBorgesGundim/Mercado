public class Produto
{
    public Produto(string nome, int codBarras, double preco, DateTime validade)
    {
        Nome = nome;
        CodBarras = codBarras;
        Preco = preco;
        Validade = validade;
    }

    public string Nome { get; }
    public int CodBarras { get; }
    public double Preco { get; }
    public DateTime Validade { get; }

    
    override public string ToString()
    {
        return $"Nome: {Nome}, Código de Barras: {CodBarras}";
    }
    public void dataDeValidade()
    {
        DateTime Validade = new DateTime(2024, 04, 01);
        TimeSpan diasRestantes = Validade - DateTime.Now;

        Console.WriteLine(Validade);
        Console.WriteLine(diasRestantes);
        Console.WriteLine(DateTime.Now);

        if (diasRestantes.TotalDays < 30 && diasRestantes.TotalDays > 0)
        {
            Console.WriteLine($"produto proximo ao vencimento, restam {diasRestantes.Days} dias.");
        }
        else if (diasRestantes.TotalDays <= 0)
        {
            Console.WriteLine("Produto Vencido");
        }
        else
        {
            Console.WriteLine("Produto com quantidade razoavel de tempo para vencimento");
        }
    }

}
