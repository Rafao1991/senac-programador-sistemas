using CadastroDeClientes.dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroDeClientes
{
    public partial class FormListaClientes : Form
    {
        private Cliente Cliente = new()
        {
            Endereco = new()
        };

        private readonly BindingSource BindingSource = [];

        public FormListaClientes()
        {
            InitializeComponent();
        }

        private bool CriarCliente()
        {
            if (!DateTime.TryParse(maskedTextBoxDataNascimento.Text, out DateTime dataNascimento))
            {
                labelErro.Text = "Data de nascimento invalida.";
                return false;
            }

            Cliente.Endereco.Logradouro = textBoxLogradouro.Text;
            Cliente.Endereco.Numero = textBoxNumero.Text;
            Cliente.Endereco.Bairro = textBoxBairro.Text;
            Cliente.Endereco.CEP = maskedTextBoxCEP.Text.Replace("-", "");
            Cliente.Endereco.Municipio = textBoxMunicipio.Text;
            Cliente.Endereco.Estado = textBoxEstado.Text;
            Cliente.Endereco.Complemento = textBoxComplemento.Text;

            Cliente.Nome = textBoxNome.Text;
            Cliente.NomeSocial = textBoxNomeSocial.Text;
            Cliente.DataNascimento = dataNascimento;
            Cliente.Email = textBoxEmail.Text;
            Cliente.Telefone = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            Cliente.Etnia = (Etnia)comboBoxEtnia.SelectedIndex;
            Cliente.Genero = (Genero)comboBoxGenero.SelectedIndex;
            Cliente.Tipo = radioButtonPf.Checked ? TipoCliente.PF : TipoCliente.PJ;
            Cliente.Estrangeiro = checkBoxEstrangeiro.Checked;

            string validacaoEndereco = Cliente.Endereco.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoEndereco))
            {
                labelErro.Text = validacaoEndereco;
                return false;
            }

            string validacaoCLiente = Cliente.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoCLiente))
            {
                labelErro.Text = validacaoCLiente;
                return false;
            }

            return true;
        }

        private void LimparForm()
        {
            textBoxNome.Clear();
            textBoxNomeSocial.Clear();
            maskedTextBoxDataNascimento.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
            comboBoxEtnia.SelectedIndex = -1;
            radioButtonPf.Checked = false;
            radioButtonPj.Checked = false;

            textBoxLogradouro.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            maskedTextBoxCEP.Clear();

            labelErro.Text = string.Empty;
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            labelErro.Text = "";

            Enum.GetNames(typeof(Etnia)).ToList().ForEach(etnia => comboBoxEtnia.Items.Add(etnia));
            Enum.GetNames(typeof(Genero)).ToList().ForEach(genero => comboBoxGenero.Items.Add(genero));

            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(!CriarCliente())
            {
                return;
            }

            Cliente.InserirCliente();
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

            LimparForm();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            Cliente.DeletarCliente(id);

            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            var cliente = Cliente.BuscarClientePorId(id);

            if (cliente == null)
            {
                return;
            }

            Cliente = cliente;

            textBoxLogradouro.Text = Cliente.Endereco.Logradouro;
            textBoxNumero.Text = Cliente.Endereco.Numero;
            textBoxBairro.Text = Cliente.Endereco.Bairro;
            maskedTextBoxCEP.Text = Cliente.Endereco.CEP;
            textBoxMunicipio.Text = Cliente.Endereco.Municipio;
            textBoxEstado.Text = Cliente.Endereco.Estado;
            textBoxComplemento.Text = Cliente.Endereco.Complemento;

            textBoxNome.Text = Cliente.Nome;
            textBoxNomeSocial.Text = Cliente.NomeSocial;
            maskedTextBoxDataNascimento.Text = Cliente.DataNascimento.ToString();
            textBoxEmail.Text = Cliente.Email;
            maskedTextBoxTelefone.Text = Cliente.Telefone;
            comboBoxEtnia.SelectedIndex = (int)Cliente.Etnia;
            comboBoxGenero.SelectedIndex = (int)Cliente.Genero;
            radioButtonPf.Checked = Cliente.Tipo == TipoCliente.PF;
            radioButtonPj.Checked = Cliente.Tipo == TipoCliente.PJ;
            checkBoxEstrangeiro.Checked = Cliente.Estrangeiro;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            Cliente.AtualizarCliente();
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

            LimparForm();
        }
    }
}
