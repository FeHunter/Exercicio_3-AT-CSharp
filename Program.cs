using System;

namespace AtCSharp03
{
    class Program
    {
        static void Main ()
        {

            Biblioteca biblioteca = new Biblioteca();
            AdicionarLivrosRevistas(biblioteca);

            bool fim = false;
            while (!fim)
            {
                int op = Menu();

                if (op == 1)
                {

                }
            }
        }

        static void AdicionarLivrosRevistas (Biblioteca biblioteca)
        {
            // Coloar livros e revistas na biblioteca "Já cadastrados".
            List<ItemBiblioteca> itens = new List<ItemBiblioteca>() {
                new Livro("Vanilla Sky", "Tom Cruise", 2001),
                new Livro("O Conde de Monte Cristo", "Edmond Dante", 1983),
                new Revista("Revista Monet", "Ellis", 2004),
                new Revista("Revista Caras", "Pedro", 2009)
            };
            foreach (ItemBiblioteca item in itens)
            {
                biblioteca.AdicionarItem(item);
            }
        }

        static int Menu ()
        {
            Console.WriteLine("Sistema da Biblioteca");
            Console.WriteLine("1 - Exibir livros e revistas");
            Console.WriteLine("2 - Adicionar Item");
            Console.WriteLine("3 - Sair");
            int op = 0;
            do{
                op = int.Parse(Console.ReadLine());
            }while (op < 1 || op > 3);
            return op;
        }
    }
}