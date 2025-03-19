namespace CadastroDeClientes
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = [];

        public Form1()
        {
            InitializeComponent();

            Endereco enderecoRafael = new Endereco() { Logradouro = "Endereco do Rafael", Numero = "10" };
            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Sousa", DataNascimento = "31/08/1991", Etnia = Etnia.OUTROS, Tipo = TipoCliente.PF, Endereco = enderecoRafael };
            Clientes.Add(rafael);

            Endereco enderecoVanda = new Endereco() { Logradouro = "Endereco dos pais do Rafael", Numero = "301" };
            Cliente vanda = new Cliente() { Id = 2, Nome = "Vanda Maria", DataNascimento = "08/03/1958", Etnia = Etnia.BRANCO, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(vanda);

            Cliente joao = new Cliente() { Id = 3, Nome = "Joao Sousa", DataNascimento = "14/07/1962", Etnia = Etnia.NEGRO, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(joao);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogradouro.Text))
            {
                labelErro.Text = "deu erro";
                textBoxLogradouro.Focus();
                return;
            }
        }
    }
}
