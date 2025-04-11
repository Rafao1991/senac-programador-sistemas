using CadastroDeClientes.dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroDeClientes
{
    public partial class FormListaClientes : Form
    {
        private readonly Cliente Cliente = new();

        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];

        public FormListaClientes()
        {
            InitializeComponent();
        }

        private bool NomeInvalido()
        {
            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                labelErro.Text = "O campo Nome é obrigatório";
                textBoxNome.Focus();
                return true;
            }

            if (!textBoxNome.Text.Contains(' '))
            {
                labelErro.Text = "O campo Nome deve conter nome e sobrenome";
                textBoxNome.Focus();
                return true;
            }

            labelErro.Text = "";
            return false;
        }

        private bool DataNascimentoInvalida()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxDataNascimento.Text) || maskedTextBoxDataNascimento.Text == "  /  /" || maskedTextBoxDataNascimento.Text.Length < 10)
            {
                labelErro.Text = "O campo Data de Nascimento é obrigatório";
                maskedTextBoxDataNascimento.Focus();
                return true;
            }

            if (!DateTime.TryParse(maskedTextBoxDataNascimento.Text, out DateTime dataNascimento))
            {
                labelErro.Text = "O campo Data de Nascimento deve ser uma data válida";
                maskedTextBoxDataNascimento.Focus();
                return true;
            }

            if (dataNascimento > DateTime.Today)
            {
                labelErro.Text = "O campo Data de Nascimento deve ser uma data no passado";
                maskedTextBoxDataNascimento.Focus();
                return true;
            }

            if (DateTime.Today.Year - dataNascimento.Year < 18)
            {
                labelErro.Text = "O campo Data de Nascimento deve ser de um cliente maior de idade";
                maskedTextBoxDataNascimento.Focus();
                return true;
            }

            if (DateTime.Today.Year - dataNascimento.Year > 120)
            {
                labelErro.Text = "O campo Data de Nascimento deve ser de um cliente menor de 120 anos";
                maskedTextBoxDataNascimento.Focus();
                return true;
            }

            labelErro.Text = "";
            return false;
        }

        private bool EmailInvalido()
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                labelErro.Text = "O campo Email é obrigatório";
                textBoxEmail.Focus();
                return true;
            }

            if (!textBoxEmail.Text.Contains('@') && !textBoxEmail.Text.Contains('.'))
            {
                labelErro.Text = "O campo Email deve ser um email válido";
                textBoxEmail.Focus();
                return true;
            }

            labelErro.Text = "";
            return false;
        }

        private bool TelefoneInvalido()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) || maskedTextBoxTelefone.Text == "(  )      -" || maskedTextBoxTelefone.Text.Length < 15)
            {
                labelErro.Text = "O campo Telefone é obrigatório";
                maskedTextBoxTelefone.Focus();
                return true;
            }

            labelErro.Text = "";
            return false;
        }

        private bool TipoClienteInvalido()
        {
            if (!radioButtonPf.Checked && !radioButtonPj.Checked)
            {
                labelErro.Text = "O campo Tipo de Cliente é obrigatório";
                return true;
            }
            labelErro.Text = "";
            return false;
        }

        private bool EtniaInvalida()
        {
            if (comboBoxEtnia.SelectedIndex == -1)
            {
                labelErro.Text = "O campo Etnia é obrigatório";
                comboBoxEtnia.Focus();
                return true;
            }
            labelErro.Text = "";
            return false;
        }

        private bool LogradouroInvalido()
        {
            if (string.IsNullOrWhiteSpace(textBoxLogradouro.Text))
            {
                labelErro.Text = "O campo Logradouro é obrigatório";
                textBoxLogradouro.Focus();
                return true;
            }
            labelErro.Text = "";
            return false;
        }

        private bool NumeroInvalido()
        {
            if (string.IsNullOrWhiteSpace(textBoxNumero.Text))
            {
                labelErro.Text = "O campo Número é obrigatório";
                textBoxNumero.Focus();
                return true;
            }
            labelErro.Text = "";
            return false;
        }

        private bool BairroInvalido()
        {
            if (string.IsNullOrWhiteSpace(textBoxBairro.Text))
            {
                labelErro.Text = "O campo Bairro é obrigatório";
                textBoxBairro.Focus();
                return true;
            }
            labelErro.Text = "";
            return false;
        }

        private bool CEPInvalido()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxCEP.Text) || maskedTextBoxCEP.Text == "     -" || maskedTextBoxCEP.Text.Length < 9)
            {
                labelErro.Text = "O campo CEP é obrigatório";
                maskedTextBoxCEP.Focus();
                return true;
            }
            labelErro.Text = "";
            return false;
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
            if (NomeInvalido() || DataNascimentoInvalida() || EmailInvalido() || TelefoneInvalido() || TipoClienteInvalido() || EtniaInvalida())
            {
                return;
            }

            if (LogradouroInvalido() || NumeroInvalido() || BairroInvalido() || CEPInvalido())
            {
                return;
            }

            DateTime.TryParse(maskedTextBoxDataNascimento.Text, out DateTime dataNascimento);

            Endereco novoEndereco = new()
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Bairro = textBoxBairro.Text,
                CEP = maskedTextBoxCEP.Text.Replace("-", ""),
                Municipio = textBoxMunicipio.Text,
                Estado = textBoxEstado.Text,
                Complemento = textBoxComplemento.Text,
            };

            Cliente novoCliente = new()
            {
                Nome = textBoxNome.Text,
                NomeSocial = textBoxNomeSocial.Text,
                DataNascimento = dataNascimento,
                Email = textBoxEmail.Text,
                Telefone = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                Etnia = (Etnia)comboBoxEtnia.SelectedIndex,
                Genero = (Genero)comboBoxGenero.SelectedIndex,
                Tipo = radioButtonPf.Checked ? TipoCliente.PF : TipoCliente.PJ,
                Estrangeiro = checkBoxEstrangeiro.Checked,
                Endereco = novoEndereco
            };

            novoCliente.InserirCliente(novoCliente);
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

            textBoxLogradouro.Text = cliente.Endereco.Logradouro;
            textBoxNumero.Text = cliente.Endereco.Numero;
            textBoxBairro.Text = cliente.Endereco.Numero;
            maskedTextBoxCEP.Text = cliente.Endereco.CEP;
            textBoxMunicipio.Text = cliente.Endereco.Municipio;
            textBoxEstado.Text = cliente.Endereco.Estado;
            textBoxComplemento.Text = cliente.Endereco.Complemento;

            textBoxNome.Text = cliente.Nome;
            textBoxNomeSocial.Text = cliente.NomeSocial;
            maskedTextBoxDataNascimento.Text = cliente.DataNascimento.ToString();
            textBoxEmail.Text = cliente.Email;
            maskedTextBoxTelefone.Text = cliente.Telefone;
            comboBoxEtnia.SelectedIndex = (int) cliente.Etnia;
            comboBoxGenero.SelectedIndex = (int) cliente.Genero;
            radioButtonPf.Checked = cliente.Tipo == TipoCliente.PF;
            radioButtonPj.Checked = cliente.Tipo == TipoCliente.PJ;
            checkBoxEstrangeiro.Checked = cliente.Estrangeiro;

        }
    }
}
