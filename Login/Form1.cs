using System.Linq;

namespace Login
{
    public partial class FormLogin : Form
    {
        // Declaração de uma lista de usuários
        List<Usuario> usuarios = new List<Usuario>();

        // Construtor da classe
        public FormLogin()
        {
            InitializeComponent();

            // Adicionando usuários na lista
            usuarios.Add(new Usuario() { Email = "neymar.jr@email.com", Senha = "Brun@123" });
            usuarios.Add(new Usuario() { Email = "pablo.vitar@email.com", Senha = "12345Abc!" });
            usuarios.Add(new Usuario() { Email = "sukuna.silva@email.com", Senha = "Sete7Sete!" });
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
            // Percorre a lista de usuários usando um laço de repetição
            for (int i = 0; i < usuarios.Count; i++) {
                // Verifica se o usuário e senha digitados são iguais ao usuário e senha da lista
                if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    // Se forem iguais, muda a variável autenticado para true
                    autenticado = true;
                }
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
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novoUsuario)
                {
                    encontrado = true;
                }
            }

            // Se o usuário já estiver cadastrado, exibe mensagem de erro
            if (encontrado)
            {
                labelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }

            // Adiciona o novo usuário na lista
            usuarios.Add(new Usuario() { Email = novoUsuario, Senha = novaSenha });
            labelResultado.Text = "Usuário cadastrado com sucesso!";
            textBoxNovoUsuario.Clear();
            textBoxNovaSenha.Clear();
        }
    }
}
