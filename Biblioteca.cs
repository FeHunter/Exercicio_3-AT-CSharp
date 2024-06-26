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
                if (Itens[i].Titulo.ToLower() == removeItem.ToLower())
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

        public void MenuRealizarEmprestimo ()
        {
            // mostra lista
            Console.Clear();
            Console.WriteLine("Livros e Revistas disponiveis:\n");
            foreach (ItemBiblioteca item in Itens)
            {
                // Mostra somente livros ou revistas disponiveis para empretismo
                if (!item.Emprestado)
                {
                    Console.WriteLine(item.ExibirInformacoes());
                }
            }

            Console.Write("\nDigite o livrou ou revista desejado: ");
            string empresta = Console.ReadLine();
            bool emprestado = false;

            for (int i=0; i < Itens.Count; i++)
            {
                if (Itens[i].Titulo.ToLower() == empresta.ToLower())
                {
                    Console.Clear();
                    RealizarEmprestimo(Itens[i]);
                    emprestado = true;
                }
            }

            // aviso caso não localize o livro ou revista
            if (!emprestado)
            {
                Console.Clear();
                Console.WriteLine($"'{empresta}' não localizado, verifique e tente novamente.");
            }

            Console.ReadKey();
        }

        void RealizarEmprestimo (ItemBiblioteca item)
        {
            item.Emprestar();
        }

        public void MenuRealizarDevolucao ()
        {
            // mostra lista
            Console.Clear();
            Console.WriteLine("Livros e Revistas a serem devolvidos:\n");
            foreach (ItemBiblioteca item in Itens)
            {
                // Mostra somente livros ou revistas que precisão ser devolvidos
                if (item.Emprestado)
                {
                    Console.WriteLine(item.ExibirInformacoes());
                }
            }

            Console.Write("\nDigite o livrou ou revista a ser devolvido: ");
            string devolver = Console.ReadLine();
            bool devolvido = false;

            for (int i=0; i < Itens.Count; i++)
            {
                if (Itens[i].Titulo.ToLower() == devolver.ToLower())
                {
                    Console.Clear();
                    RealizarDevolucao(Itens[i]);
                    devolvido = true;
                }
            }

            // aviso caso não localize o livro ou revista
            if (!devolvido)
            {
                Console.Clear();
                Console.WriteLine($"'{devolver}' não localizado, verifique e tente novamente.");
            }

            Console.ReadKey();
        }

        void RealizarDevolucao (ItemBiblioteca item)
        {
            item.Devolver();
        }
    }
}