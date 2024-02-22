using System;

List<Produto> produtos = new();
List<Estoque> estoques = new();

Produto produto1 = new Produto("Manteiga Qualy", 100, 7.50);
Produto produto2 = new Produto("Leite URA", 200, 4.90);

produtos.Add(produto1);
produtos.Add(produto2);

Estoque estoque1 = new Estoque("Manteiga Qualy",1000);
Estoque estoque2 = new Estoque("Leite URA", 1000);

estoques.Add(estoque1);
estoques.Add(estoque2);


foreach (var produto in produtos)
{
  Console.WriteLine(produto);
}
foreach (var estoque in estoques)
{
    Console.WriteLine(estoque);
}



