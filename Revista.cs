
namespace AtCSharp03
{
    class Revista : ItemBiblioteca
    {
        public Revista(string titulo, string autor, int ano) : base(titulo, autor, ano)
        {
            Tipo = "revista";
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

        public override string ExibirInformacoes()
        {
            return $"Revista: {Titulo} \nAutor: {Autor} \nAno de publicação: {Ano} \n Disponivel: {(!Emprestado ? "Sim" : "Não")}";
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