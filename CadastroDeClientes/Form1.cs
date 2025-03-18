namespace CadastroDeClientes
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = [];

        public Form1()
        {
            InitializeComponent();

            Clientes.Add(new Cliente()
            {
                Id = 1,
                Nome = "Rafael"
            });

            Clientes.Add(new Cliente() {
                Id = 2,
                Nome = "João"
            });

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = Clientes;
            listBoxClientes.DisplayMember = "Nome";
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Clientes.Add(new Cliente()
            {
                Id = 3,
                Nome = "Maria"
            });

            AtualizarLista();
        }
    }
}
