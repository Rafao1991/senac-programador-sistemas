namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            
            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            
            if (usuario == "rafael.sousa" && senha == "12345")
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
