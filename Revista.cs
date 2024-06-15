
namespace AtCSharp03
{
    class Revista : ItemBiblioteca
    {
        public Revista(string titulo, string autor, int ano) : base(titulo, autor, ano)
        {
            Tipo = "revista";
        }
        public Revista(string titulo, string autor, int ano, bool emprestado) : base(titulo, autor, ano, emprestado)
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
            if (!Emprestado)
            {
                Emprestado = true;
                PrazoDevolucao = DateTime.Now.AddDays(7);
                Console.WriteLine($"A revista '{Titulo}' foi emprestasdo, prazo para devolução {PrazoDevolucao}.");
            }
            else 
            {
                Console.WriteLine($"A revista '{Titulo}' não esta disponivel, será devolvido até {PrazoDevolucao}.");
            }
        }

        public override string ExibirInformacoes()
        {
            return $"Revista: {Titulo} \nAutor: {Autor} \nAno de publicação: {Ano} \nDisponivel: {(!Emprestado ? "Sim" : "Não")} \n";
        }

        public override string FormatarParaSalvar()
        {
            return $"{Tipo},{Titulo},{Autor},{Ano},{(!Emprestado ? "Sim" : "Não")}";
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