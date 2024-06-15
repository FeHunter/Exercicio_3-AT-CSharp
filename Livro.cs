
namespace AtCSharp03
{
    class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor, int ano) : base(titulo, autor, ano)
        {
            Tipo = "livro";
        }
        public Livro(string titulo, string autor, int ano, bool emprestado) : base(titulo, autor, ano, emprestado)
        {
            Tipo = "livro";
        }

        public override void Devolver()
        {
            Console.WriteLine($"O livro {Titulo} foi devolvido.");
            Emprestado = false;
        }

        public override void Emprestar()
        {
            if (!Emprestado)
            {
                Emprestado = true;
                PrazoDevolucao = DateTime.Now.AddDays(7);
                Console.WriteLine($"O livro '{Titulo}' foi emprestasdo, prazo para devolução {PrazoDevolucao}.");
            }
            else 
            {
                Console.WriteLine($"O livro '{Titulo}' não esta disponivel, será devolvido até {PrazoDevolucao}.");
            }
        }

        public override string ExibirInformacoes()
        {
            return $"Livro: {Titulo} \nAutor: {Autor} \nAno de publicação: {Ano} \nDisponivel: {(!Emprestado ? "Sim" : "Não")} \n";
        }

        public override string FormatarParaSalvar()
        {
            return $"{Tipo}, {Titulo}, {Autor}, {Ano}, {(!Emprestado ? "Sim" : "Não")}";
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