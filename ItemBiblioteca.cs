namespace AtCSharp03
{
    abstract class ItemBiblioteca : IEmprestavel
    {
        private string _titulo;
        private string _autor;
        private int _ano;
        private bool _emprestado;
        private DateTime _prazoDevolucao;

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public bool Emprestado { get => _emprestado; protected set => _emprestado = value; }
        public DateTime PrazoDevolucao { get => _prazoDevolucao; protected set => _prazoDevolucao = value; }

        public ItemBiblioteca(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public abstract void Emprestar();
        public abstract void Devolver();
        public abstract string ExibirInformacoes();
        public virtual void VerificarDisponibilidade() {}
        public virtual void ObterPrazoDeDevolucao() {}
    }
}