class Validade
{
    public Validade(int produto)
    {
        Produto = produto;
    }

    public int Produto { get; set; }
    public void dataDeValidade()
    {
        DateTime Produto = new DateTime(2024, 02, 01);
        TimeSpan diasRestantes = Produto - DateTime.Today;

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