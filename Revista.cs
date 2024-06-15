namespace AtCSharp03
{
    class Revista : ItemBiblioteca
    {
         public override void Devolver()
        {
            Console.WriteLine($"A revista {Titulo} foi devolvido.");
        }

        public override void Emprestar()
        {
            Console.WriteLine($"A revista {Titulo} foi emprestasdo.");
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano de publicação: {Ano}");
        }
    }
}