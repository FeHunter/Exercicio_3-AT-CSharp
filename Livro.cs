namespace AtCSharp03
{
    class Livro : ItemBiblioteca
    {
        public override void Devolver()
        {
            Console.WriteLine($"O livro {Titulo} foi devolvido.");
        }

        public override void Emprestar()
        {
            Console.WriteLine($"O livero {Titulo} foi emprestasdo.");
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano de publicação: {Ano}");
        }
    }
}