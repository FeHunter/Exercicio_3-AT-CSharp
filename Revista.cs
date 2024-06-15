
namespace AtCSharp03
{
    class Revista : ItemBiblioteca
    {
        public Revista(string titulo, string autor, int ano, bool emprestado, DateTime prazoDevolucao) : base(titulo, autor, ano, emprestado, prazoDevolucao)
        {
        }

        public override void Devolver()
        {
            Console.WriteLine($"A revista {Titulo} foi devolvido.");
            Emprestado = false;
        }

        public override void Emprestar()
        {
            Console.WriteLine($"A revista {Titulo} foi emprestasdo.");
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
                Console.WriteLine($"A revista {Titulo}, esta disponivel.");
            }
            else
            {
                Console.WriteLine($"A revista {Titulo}, não esta disponivel.");
            }
        }

        public override void ObterPrazoDeDevolucao()
        {
            Console.WriteLine($"O prazo devolução é da revista {Titulo} é {PrazoDevolucao}");
        }
    }
}