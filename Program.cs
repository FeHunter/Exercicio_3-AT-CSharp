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
                    biblioteca.ExibirItens();
                }
                else if (op == 2)
                {
                    biblioteca.MenuAdicionarItem();
                }
                else if (op == 3)
                {
                    biblioteca.MenuRemoverItem();
                }
                else if (op == 4)
                {
                    biblioteca.MenuRealizarEmprestimo();
                }
                else if (op == 5)
                {
                    biblioteca.MenuRealizarDevolucao();
                }
                else if (op == 6)
                {
                    fim = true;
                }
            }
        }

        static void AdicionarLivrosRevistas (Biblioteca biblioteca)
        {
            // Coloar livros e revistas na biblioteca "Já cadastrados".
            List<ItemBiblioteca> itens = new List<ItemBiblioteca>() {
                new Livro("Vanilla Sky", "Tom Cruise", 2001),
                new Livro("O Conde de Monte Cristo", "Edmond Dante", 1983),
                new Revista("Monet", "Ellis", 2004),
                new Revista("Caras", "Pedro", 2009)
            };
            foreach (ItemBiblioteca item in itens)
            {
                biblioteca.AdicionarItem(item);
            }
        }

        static int Menu ()
        {
            Console.Clear();
            Console.WriteLine("Sistema da Biblioteca");
            Console.WriteLine("1 - Exibir livros e revistas");
            Console.WriteLine("2 - Adicionar Item");
            Console.WriteLine("3 - Remover Item");
            Console.WriteLine("4 - Realizar Emprestimo");
            Console.WriteLine("5 - Realizar Devolução");
            Console.WriteLine("6 - Sair");
            int op = 0;
            do{
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Você deve inserir o número de acordo com a opção.");
                    // Console.WriteLine("Sistema da Biblioteca\n1 - Exibir livros e revistas\n2 - Adicionar Item\n3 - Sair");
                }
            }while (op < 1 || op > 6);
            return op;
        }
    }
}