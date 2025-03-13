namespace Calculadora
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LimparTextBox()
        {
            textBoxNro1.Clear();
            textBoxNro2.Clear();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxNro1.Text))
            {
                labelErro.Text = "O valor 1 eh obrigatorio.";
                textBoxNro1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNro2.Text))
            {
                labelErro.Text = "O valor 2 eh obrigatorio.";
                textBoxNro2.Focus();
                return false;
            }

            try
            {
                double doubleValor1 = Convert.ToDouble(textBoxNro1.Text);
                double doubleValor2 = Convert.ToDouble(textBoxNro2.Text);

                return true;
            }
            catch
            {
                labelErro.Text = "Insira somente numeros";
                LimparTextBox();
                textBoxNro1.Focus();
                return false;
            }
        }

        private static double Somar(double val1, double val2)
        {
            return val1 + val2;
        }

        private static double Subtrair(double val1, double val2)
        {
            return val1 - val2;
        }

        private static double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            labelErro.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor1 = Convert.ToDouble(textBoxNro1.Text);
            double doubleValor2 = Convert.ToDouble(textBoxNro2.Text);
            double resultado;

            switch (labelOperacao.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }

            textBoxResultado.Text = Convert.ToString(resultado);
            LimparTextBox();
        }

        private void radioButtonSoma_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNro1.Visible = true;
            labelOperacao.Text = "+";
        }

        private void radioButtonSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "-";
        }

        private void radioButtonMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "*";
        }

        private void radioButtonDivisao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperacao.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.Show();

            this.Hide();
        }
    }
}
