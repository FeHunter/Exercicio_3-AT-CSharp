
namespace AtCSharp03
{
    class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string autor, int ano, bool emprestado, DateTime prazoDevolucao) : base(titulo, autor, ano, emprestado, prazoDevolucao)
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
    }
}