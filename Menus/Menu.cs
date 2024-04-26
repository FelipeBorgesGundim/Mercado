﻿
namespace Mercado.Menus
{
    public class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(Dictionary<string, List<int>> produtosRegistrados, List<int> codProduto)
        {
            Console.Clear();
        }
    }
}
