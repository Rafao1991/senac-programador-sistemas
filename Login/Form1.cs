using MySql.Data.MySqlClient;

namespace Login
{
    public partial class FormLogin : Form
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        // Construtor da classe
        public FormLogin()
        {
            InitializeComponent();
        }

        // Método executado ao clicar no botão Entrar
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            // Busca o usuário e senha digitados
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            // Verifica se o usuário foi digitado
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execução do método
                return;
            }

            // Verifica se a senha foi digitada
            if (string.IsNullOrWhiteSpace(senha))
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Senha eh obrigatoria!!!";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execução do método
                return;
            }

            // Verifica se o usuário e senha estão corretos
            // Inicializa a variável autenticado como false
            bool autenticado = false;

            try 
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            // Verifica se o usuário e senha não foram encontrados
            if (!autenticado)
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario ou Senha incorretos...";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execução do método
                return;
            }

            // Se o usuário e senha foram encontrados, exibe mensagem de sucesso
            labelResultado.Text = "Autenticado com sucesso!";
            // Muda a cor da mensagem para verde
            labelResultado.ForeColor = Color.Green;

            // Limpa os campos de texto
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }

        // Método executado ao clicar no botão Cadastrar
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Busca o novo usuário e senha digitados
            string novoUsuario = textBoxNovoUsuario.Text;
            string novaSenha = textBoxNovaSenha.Text;

            // Verifica se o novo usuário foi digitado
            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            // Verifica se a nova senha foi digitada
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            // Verifica se a senha tem pelo menos 8 caracteres
            if (novaSenha.Length < 8)
            {
                labelResultado.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra maiúscula
            if (!novaSenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra minúscula
            if (!novaSenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            // Verifica se a senha tem pelo menos um número
            if (!novaSenha.Any(char.IsNumber))
            {
                labelResultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            // Verifica se a senha tem pelo menos um caracter especial
            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                labelResultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            // Verifica se a senha tem espaços em branco
            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelResultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            // Verifica se o novo usuário já está cadastrado
            bool encontrado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT email FROM usuario WHERE email = '{novoUsuario}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                encontrado = reader.Read();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            // Se o usuário já estiver cadastrado, exibe mensagem de erro
            if (encontrado)
            {
                labelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }

            // Adiciona o novo usuário na lista
            try
            {
                Connection.Open();

                string query = $"INSERT INTO usuario (email, senha) VALUES ('{novoUsuario}', '{novaSenha}');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                mySqlCommand.ExecuteNonQuery();

                labelResultado.Text = "Usuário cadastrado com sucesso!";
                textBoxNovoUsuario.Clear();
                textBoxNovaSenha.Clear();
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
