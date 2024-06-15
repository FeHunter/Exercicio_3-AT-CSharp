using System;

namespace AtCSharp03
{
    class Biblioteca
    {
        private List<ItemBiblioteca> _itens = new List<ItemBiblioteca>();

        internal List<ItemBiblioteca> Itens { get => _itens; set => _itens = value; }

        public int EscolherOpcoes ()
        {
            Console.Clear();
            Console.WriteLine("Escolha o que deseja adicionar:");
            Console.WriteLine("1 - Livro");
            Console.WriteLine("2 - Revista");
            int op = 0;
            // Evitar entradas invalidas
            do {
                try {
                    op = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Você deve digitar um dos números das opções");   
                }
            }while (op < 1 || op > 2);
            return op;
        }

        public void MenuAdicionarItem ()
        {
            int op = EscolherOpcoes();
            if (op == 1)
            {
                Console.Clear();
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
                Console.Clear();
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

        public void MenuRemoverItem ()
        {
            Console.Clear();

            // mostra lista
            foreach (ItemBiblioteca item in Itens)
            {
                Console.WriteLine(item.ExibirInformacoes());
            }

            // Mensagem de como funciona
            Console.WriteLine("Digite o nome do livro ou revista a ser removido");
            Console.Write("Nome: ");
            string removeItem = Console.ReadLine();
            bool removido = false;

            // Procuar item na lista
            for (int i=0; i < Itens.Count; i++)
            {
                if (Itens[i].Titulo == removeItem)
                {
                    Console.Clear();
                    Console.WriteLine($"'{Itens[i].Titulo}' foi removido da lista.");
                    Itens.Remove(Itens[i]);
                    removido = true;
                }
            }

            // mostra aviso caso item não seja encontrado
            if (!removido)
            {
                Console.Clear();
                Console.WriteLine($"Não foi possivel localizar '{removeItem}', verifique se não foi digitado algo errado e tente novamente");
            }

            Console.ReadKey();
        }

        public void RemoverItem (ItemBiblioteca item)
        {
            Itens.Remove(item);
        }

        public void ExibirItens ()
        {
            Console.Clear();
            Console.WriteLine("Lista de Livros e Revistas:\n");
            int op = 0;
            do {
                Console.WriteLine("1 - Livros \n2 - Revistas \n3 - Todos");
                try {
                    op = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Você deve digitar um dos números das opções");   
                }
            } while( op < 1 || op > 3);

            // Mostrar somente os livros
            if (op == 1)
            {
                Console.Clear();
                for (int i=0; i < Itens.Count; i++)
                {
                    if (Itens[i].Tipo == "livro")
                    {
                        Console.WriteLine(Itens[i].ExibirInformacoes());
                    }
                }
            }
            // Mostrar somente as revistas
            else if (op == 2)
            {
                Console.Clear();
                for (int i=0; i < Itens.Count; i++)
                {
                    if (Itens[i].Tipo == "revista")
                    {
                        Console.WriteLine(Itens[i].ExibirInformacoes());
                    }
                }
            }
            // Mostrar todos os itens
            else {
                Console.Clear();
                foreach (ItemBiblioteca item in Itens)
                {
                    Console.WriteLine(item.ExibirInformacoes());
                }
            }
            Console.ReadKey();
        }

        public void RealizarEmprestimo (ItemBiblioteca item)
        {
            item.Emprestar();
        }
    }
}