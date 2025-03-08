using System.Linq;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public FormLogin()
        {
            InitializeComponent();
            usuarios.Add(new Usuario() { Email = "neymar.jr@email.com", Senha = "Brun@123" });
            usuarios.Add(new Usuario() { Email = "pablo.vitar@email.com", Senha = "12345Abc!" });
            usuarios.Add(new Usuario() { Email = "sukuna.silva@email.com", Senha = "Sete7Sete!" });
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;
            for (int i = 0; i < usuarios.Count; i++) {
                if (usuarios[i].Email == usuarioBuscado && usuarios[i].Senha == senha)
                {
                    autenticado = true;
                }
            }

            if (!autenticado)
            {
                labelResultado.Text = "Usuario ou Senha incorretos...";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            labelResultado.Text = "Autenticado com sucesso!";
            labelResultado.ForeColor = Color.Green;
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string novoUsuario = textBoxNovoUsuario.Text;
            string novaSenha = textBoxNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelResultado.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                labelResultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            if (!novaSenha.Any(char.IsNumber))
            {
                labelResultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                labelResultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (novaSenha.Any(char.IsWhiteSpace))
            {
                labelResultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            bool encontrado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Email == novoUsuario && usuarios[i].Senha == novaSenha)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                labelResultado.Text = "Já existe um usuário cadastrado";
                return;
            }

            usuarios.Add(new Usuario() { Email = novoUsuario, Senha = novaSenha });
            labelResultado.Text = "Usuário cadastrado com sucesso!";
            textBoxNovoUsuario.Clear();
            textBoxNovaSenha.Clear();
        }
    }
}
