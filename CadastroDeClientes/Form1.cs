using System.Data;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = [];
        BindingSource bindingSource = new BindingSource();

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


            bindingSource.DataSource = Clientes;
            dataGridViewClientes.DataSource = bindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endereco enderecoGustavo = new Endereco() { Logradouro = "Endereco dos Gustavo", Numero = "852" };
            Cliente gustavo = new Cliente() { Id = 4, Nome = "Gustavo Sousa", DataNascimento = "09/11/1993", Etnia = Etnia.BRANCO, Tipo = TipoCliente.PF, Endereco = enderecoGustavo };
            Clientes.Add(gustavo);

            bindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes.RemoveAt(dataGridViewClientes.SelectedRows[0].Index);
            bindingSource.ResetBindings(false);
        }
    }
}
