using System;

namespace AtCSharp03
{
    class Program
    {
        static void Main ()
        {

            const string path = "DadosDaBiblioteca.csv";

            Biblioteca biblioteca = new Biblioteca();
            AdicionarLivrosRevistas(biblioteca, path);

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

            // salvar dados antes de finalizar
            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    foreach(ItemBiblioteca item in biblioteca.Itens)
                    {
                        sw.WriteLine(item.FormatarParaSalvar());
                        Console.Clear();
                        Console.WriteLine("Salvando...");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}. Tente novamente mais tarde");
                }
                Console.WriteLine("Os dados foram salvos.");
            }
        }

        static void AdicionarLivrosRevistas (Biblioteca biblioteca, string path)
        {
            if (!File.Exists(path))
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
            else 
            {
                // Carrega dados
                using (StreamReader sr = new StreamReader(path))
                {
                    try
                    {
                        string lerDados;
                        while ((lerDados = sr.ReadLine()) != null)
                        {
                            string[] dados = lerDados.Split(',');
                            if (dados.Length == 5)
                            {
                                string tipo = dados[0];
                                string titulo = dados[1];
                                string autor = dados[2];
                                int ano = int.Parse(dados[3]);
                                bool disponivel = dados[4].ToLower() == "sim";

                                if (tipo == "livro")
                                {
                                    biblioteca.AdicionarItem(new Livro(titulo, autor, ano, disponivel));
                                    Console.WriteLine($"{tipo}, {titulo}, {autor}, {ano}");
                                }
                                else if (tipo == "revista")
                                {
                                    biblioteca.AdicionarItem(new Revista(titulo, autor, ano, disponivel));
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Linha inválida: {lerDados}");
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("Dados carregados com sucesso! Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: \n{e.Message} \nTente novamente mais tarde.");
                        Console.ReadKey();
                    }
                }
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