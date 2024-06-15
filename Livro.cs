
namespace AtCSharp03
{
    class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor, int ano) : base(titulo, autor, ano)
        {
        }

        public override void Devolver()
        {
            Console.WriteLine($"O livro {Titulo} foi devolvido.");
            Emprestado = false;
        }

        public override void Emprestar()
        {
            Console.WriteLine($"O livero {Titulo} foi emprestasdo.");
            Emprestado = true;
            PrazoDevolucao = DateTime.Now.AddDays(7);
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano de publicação: {Ano}");
        }

        public override void VerificarDisponibilidade()
        {
            if (Emprestado)
            {
                Console.WriteLine($"O livro {Titulo}, esta disponivel.");
            }
            else
            {
                Console.WriteLine($"O livro {Titulo}, não esta disponivel.");
            }
        }

        public override void ObterPrazoDeDevolucao()
        {
            Console.WriteLine($"O prazo devolução é do livro {Titulo} é {PrazoDevolucao}");
        }
    }
}