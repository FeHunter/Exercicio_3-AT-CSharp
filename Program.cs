using System;

namespace AtCSharp03
{
    class Program
    {
        static void Main ()
        {

            // Livros e Revista
            Livro l1 = new Livro("Vanilla Sky", "Tom Cruise", 2001);
            Livro l2 = new Livro("O Conde de Monte Cristo", "Edmond Dante", 1983);
            Revista r1 = new Revista("Revista Monet", "Ellis", 2004);
            Revista r2 = new Revista("Revista Caras", "Pedro", 2009);

            bool fim = false;
            while (!fim)
            {
                int op = Menu();
            }
        }

        static int Menu ()
        {
            Console.WriteLine("Sistema da Biblioteca");
            Console.WriteLine("1 - Lista de livros e revistas");
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