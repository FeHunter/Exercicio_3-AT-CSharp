using System;

namespace AtCSharp03
{
    class Biblioteca
    {
        private List<ItemBiblioteca> _itens = new List<ItemBiblioteca>();

        internal List<ItemBiblioteca> Itens { get => _itens; set => _itens = value; }

        public int EscolherOpcoes ()
        {
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Adicionar Revista");
            int op = 0;
            do {
                op = int.Parse(Console.ReadLine());
            }while (op < 1 || op > 2);
            return op;
        }

        public void MenuAdicionarItem ()
        {
            int op = EscolherOpcoes();
            if (op == 1)
            {
                Console.WriteLine("Adicionar Livro");
                Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Ano de publicação: ");
                int ano = int.Parse(Console.ReadLine());

                Livro livro = new Livro(titulo, autor, ano);
                AdicionarItem(livro);
            }
            else if (op == 2)
            {
                Console.WriteLine("Adicionar Revista");
                Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Ano de publicação: ");
                int ano = int.Parse(Console.ReadLine());

                Revista revista = new Revista(titulo, autor, ano);
                AdicionarItem(revista);
            }
        }

        public void AdicionarItem (ItemBiblioteca item)
        {
            Itens.Add(item);
        }
    }
}