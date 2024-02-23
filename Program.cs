using System;

List<Produto> produtos = new();
List<Estoque> estoques = new();

Produto produto1 = new Produto("Manteiga Qualy", 100, 7.50, new DateTime(2024, 04, 01));
Produto produto2 = new Produto("Leite URA", 200, 4.90, new DateTime(2024, 04, 01));
Produto produto3 = new Produto("Achocolatado Toddy", 300, 9.90, new DateTime(2024, 04, 01));

produtos.Add(produto1);
produtos.Add(produto2);
produtos.Add(produto3);

Estoque estoque1 = new Estoque("Manteiga Qualy", 1000);
Estoque estoque2 = new Estoque("Leite URA", 1000);
Estoque estoque3 = new Estoque("Achocolatado Toddy", 500);

estoques.Add(estoque1);
estoques.Add(estoque2);
estoques.Add(estoque3);


foreach (Produto produto in produtos)
{
    Console.WriteLine(produto);
}
foreach (Estoque estoque in estoques)
{
    Console.WriteLine(estoque);
}
produto1.dataDeValidade();




