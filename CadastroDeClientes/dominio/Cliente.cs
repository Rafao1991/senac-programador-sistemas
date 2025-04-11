using CadastroDeClientes.repositorio;

namespace CadastroDeClientes.dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio ClienteRepositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public TipoCliente Tipo { get; set; }
        public Etnia Etnia { get; set; }
        public Genero Genero { get; set; }
        public bool Estrangeiro { get; set; }
        public Endereco Endereco { get; set; }

        public List<Cliente> ListarClientes()
        {
            return ClienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novoCliente)
        {
            ClienteRepositorio.InserirCliente(novoCliente);
        }

        public Cliente BuscarClientePorId(int id)
        {
            return ClienteRepositorio.BuscarClientePorId(id);
        }

        public void DeletarCliente(int id)
        {
            ClienteRepositorio.DeletarCliente(id);
        }
    }
}
