using CadastroDeClientes.dominio;

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

            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Email == textBoxEmail.Text)
                {
                    labelErro.Text = "O campo Email deve ser único";
                    textBoxEmail.Focus();
                    return true;
                }
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

            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Telefone == maskedTextBoxTelefone.Text)
                {
                    labelErro.Text = "O campo Telefone deve ser único";
                    maskedTextBoxTelefone.Focus();
                    return true;
                }
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

        private int GerarId()
        {
            if (Clientes.Count == 0)
            {
                return 1;
            }

            int novoId = 0;
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Id > novoId)
                {
                    novoId = cliente.Id;
                }
            }

            return novoId + 1;
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

            //Endereco novoEndereco = new()
            //{
            //    Logradouro = textBoxLogradouro.Text,
            //    Numero = textBoxNumero.Text,
            //    Bairro = textBoxBairro.Text,
            //    CEP = maskedTextBoxCEP.Text,
            //};

            //Cliente novoCliente = new()
            //{
            //    Id = GerarId(),
            //    Nome = textBoxNome.Text,
            //    NomeSocial = textBoxNomeSocial.Text,
            //    DataNascimento = maskedTextBoxDataNascimento.Text,
            //    Email = textBoxEmail.Text,
            //    Telefone = maskedTextBoxTelefone.Text,
            //    Etnia = (Etnia)comboBoxEtnia.SelectedIndex,
            //    Tipo = radioButtonPf.Checked ? TipoCliente.PF : TipoCliente.PJ,
            //    Endereco = novoEndereco
            //};
            //Clientes.Add(novoCliente);

            BindingSource.ResetBindings(false);

            LimparForm();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }

            Clientes.RemoveAt(dataGridViewClientes.SelectedRows[0].Index);
            BindingSource.ResetBindings(false);
        }
    }
}
