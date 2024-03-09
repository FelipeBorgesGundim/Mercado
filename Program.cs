using Mercado.Modelos;



Dictionary<string, List<int>> produtosRegistrados = new();
produtosRegistrados.Add("Manteiga", new List<int> { 10, 10 });
produtosRegistrados.Add("Leite", new List<int> { 15 });

void ExibirLogo()
{
    Console.WriteLine(@"

█▀▄▀█ █▀▀ █▀█ █▀▀ ▄▀█ █▀▄ █▀█
█░▀░█ ██▄ █▀▄ █▄▄ █▀█ █▄▀ █▄█
");
    Console.WriteLine("Boas vindas ao Mercadinho!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um Produto:");
    Console.WriteLine("Digite 2 para mostrar todas os Produtos:");
    Console.WriteLine("Digite 3 para adicionar quantidade de produtos ja cadastrados");
    Console.WriteLine("Digite 4 para exibir os detalhes de Produto");
    Console.WriteLine("Digite 9 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarProduto();
            break;
        case 2:
            MostrarProdutosRegistrados();
            break;
        case 3:
            AdicionarQuantidadeProduto();
            break;
        case 4:
            ExibirDetalhes();
            break;
        case 9:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarProduto()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Produtos"); // => Metodo linhas 153 a 160
    Console.Write("Digite o nome do produto que deseja registrar: ");
    string nomeDoProduto = Console.ReadLine()!;
    produtosRegistrados.Add(nomeDoProduto, new List<int>());
    Console.WriteLine($"O Produto {nomeDoProduto} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarProdutosRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os Produtos registrados na nossa aplicação");

    foreach (string banda in produtosRegistrados.Keys)
    {
        Console.WriteLine($"Produto: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AdicionarQuantidadeProduto()
{
    Console.Clear();
    ExibirTituloDaOpcao("Adicionar Quantidade de produto Cadastrado:");
    Console.Write("Digite o nome do produto que deseja adicionar no estoque: ");
    string nomeDoProduto = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoProduto))
    {
        Console.Write($"Qual a quantidade do {nomeDoProduto} deseja adicionar: ");
        int qtd = int.Parse(Console.ReadLine()!);
        produtosRegistrados[nomeDoProduto].Add(qtd);
        Console.WriteLine($"\nA Quantidade {qtd} foi registrada com sucesso para o produto {nomeDoProduto}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO Produto {nomeDoProduto} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes do Produto");
    Console.Write("Digite o nome do produto que deseja ver detalhes: ");
    string nomeDoProduto = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoProduto))
    {
        List<int> qtdProdutos = produtosRegistrados[nomeDoProduto];
        Console.WriteLine($"\nA quantidade do Produto {nomeDoProduto} é {qtdProdutos.Sum()}.");
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nO Produto {nomeDoProduto} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
ExibirOpcoesDoMenu();



