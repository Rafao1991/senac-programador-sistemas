namespace CadastroDeClientes
{
    public partial class FormListaClientes : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];

        public FormListaClientes()
        {
            InitializeComponent();

            Endereco enderecoRafael = new() { Logradouro = "Endereco do Rafael", Numero = "10", Bairro = "Bairro", CEP = "00000-001" };
            Cliente rafael = new() { Id = 1, Nome = "Rafael Sousa", DataNascimento = "31/08/1991", Etnia = Etnia.OUTROS, Tipo = TipoCliente.PF, Endereco = enderecoRafael };
            Clientes.Add(rafael);

            Endereco enderecoVanda = new() { Logradouro = "Endereco dos pais do Rafael", Numero = "301", Bairro = "Bairro", CEP = "00000-001" };
            Cliente vanda = new() { Id = 2, Nome = "Vanda Maria", DataNascimento = "08/03/1958", Etnia = Etnia.BRANCO, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(vanda);

            Cliente joao = new() { Id = 3, Nome = "Joao Sousa", DataNascimento = "14/07/1962", Etnia = Etnia.NEGRO, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(joao);


            BindingSource.DataSource = Clientes;
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endereco enderecoGustavo = new() { Logradouro = "Endereco dos Gustavo", Numero = "852", Bairro = "Bairro", CEP = "00000-002" };
            Cliente gustavo = new() { Id = 4, Nome = "Gustavo Sousa", DataNascimento = "09/11/1993", Etnia = Etnia.BRANCO, Tipo = TipoCliente.PF, Endereco = enderecoGustavo };
            Clientes.Add(gustavo);

            BindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes.RemoveAt(dataGridViewClientes.SelectedRows[0].Index);
            BindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDetalheCliente formDetalheCliente;
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                formDetalheCliente = new();
            }
            else
            {
                formDetalheCliente = new(Clientes.ElementAt(dataGridViewClientes.SelectedRows[0].Index));
            }

            formDetalheCliente.ShowDialog();
        }
    }
}
