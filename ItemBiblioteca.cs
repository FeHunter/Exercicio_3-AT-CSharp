namespace AtCSharp03
{
    abstract class ItemBiblioteca : IEmprestavel
    {
        private string _titulo;
        private string _autor;
        private int _ano;

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Ano { get => _ano; set => _ano = value; }

        public abstract void Emprestar();
        public abstract void Devolver();
        public abstract void ExibirInformacoes();
        public virtual void VerificarDisponibilidade() {}
        public virtual void ObterPrazoDeDevolucao() {}
    }
}