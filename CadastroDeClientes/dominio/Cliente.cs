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

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo Nome é obrigatório";
            }

            if (!Nome.Contains(' '))
            {
                return "O campo Nome deve conter nome e sobrenome";
            }

            if (DataNascimento > DateTime.Today)
            {
                return "O campo Data de Nascimento deve ser uma data no passado";
            }

            if (DateTime.Today.Year - DataNascimento.Year < 18)
            {
                return "O campo Data de Nascimento deve ser de um cliente maior de idade";
            }

            if (DateTime.Today.Year - DataNascimento.Year > 120)
            {
                return "O campo Data de Nascimento deve ser de um cliente menor de 120 anos";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "O campo Email é obrigatório";
            }

            if (!Email.Contains('@') && !Email.Contains('.'))
            {
                return "O campo Email deve ser um email válido";
            }

            var clienteExistente = ClienteRepositorio.BuscarClientePorEmail(Email);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse email.";
            }

            if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Length != 11)
            {
                return "O campo Telefone é obrigatório";
            }

            clienteExistente = ClienteRepositorio.BuscarClientePorTelefone(Telefone);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse telefone.";
            }

            if (Tipo != TipoCliente.PF && Tipo != TipoCliente.PJ)
            {
                return "O campo Tipo de Cliente é obrigatório";
            }

            if (Etnia < 0)
            {
                return "O campo Etnia é obrigatório";
            }

            return string.Empty;
        }

        public List<Cliente> ListarClientes()
        {
            return ClienteRepositorio.ListarClientes();
        }

        public void InserirCliente()
        {
            ClienteRepositorio.InserirCliente(this);
        }

        public Cliente? BuscarClientePorId(int id)
        {
            return ClienteRepositorio.BuscarClientePorId(id);
        }

        public void AtualizarCliente()
        {
            ClienteRepositorio.AtualizarCliente(this);
        }

        public void DeletarCliente(int id)
        {
            ClienteRepositorio.DeletarCliente(id);
        }
    }
}
