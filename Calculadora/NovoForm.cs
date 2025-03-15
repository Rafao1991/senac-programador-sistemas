namespace Calculadora
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        private bool RadioNaoSelecionado(List<RadioButton> radios)
        {
            return radios.All(radio => !radio.Checked);
        }

        private bool ValorInvalido(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) || !valor.All(char.IsNumber);
        }

        private bool ValidarQuadrado()
        {
            List<RadioButton> radios = new List<RadioButton> { radioButtonPerimetroQuadrado, radioButtonAreaQuadrado, radioButtonVolumeQuadrado };
            if (RadioNaoSelecionado(radios))
            {
                labelErro.Text = "Selecione uma operacao.";
                return false;
            }

            if (ValorInvalido(textBoxLadoQuadrado.Text))
            {
                labelErro.Text = "Insira um lado valido.";
                return false;
            }

            return true;
        }

        private bool ValidarRetangulo()
        {
            List<RadioButton> radios = new List<RadioButton> { radioButtonPerimetroRetangulo, radioButtonAreaRetangulo, radioButtonVolumeRetangulo };
            if (RadioNaoSelecionado(radios))
            {
                labelErro.Text = "Selecione uma operacao.";
                return false;
            }

            if (ValorInvalido(textBoxLarguraRetangulo.Text))
            {
                labelErro.Text = "Insira uma largura valida.";
                return false;
            }

            if (ValorInvalido(textBoxAlturaRetangulo.Text))
            {
                labelErro.Text = "Insira uma altura valida.";
                return false;
            }

            if (radioButtonVolumeRetangulo.Checked && ValorInvalido(textBoxComprimentoRetangulo.Text))
            {
                labelErro.Text = "Insira uma comprimento valida.";
                return false;
            }

            return true;
        }

        private bool ValidarCirculo()
        {
            List<RadioButton> radios = new List<RadioButton> { radioButtonDiametro, radioButtonPerimetro, radioButtonArea, radioButtonVolume };
            if (RadioNaoSelecionado(radios))
            {
                labelErro.Text = "Selecione uma opção";
                return false;
            }

            if (ValorInvalido(textBoxRaio.Text))
            {
                labelErro.Text = "Inserir um raio de um numero valido";
                return false;
            }

            return true;
        }

        private bool ValidarForm()
        {
            labelErro.Text = "";

            if (comboBoxOpcao.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return false;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Quadrado")
            {
                return ValidarQuadrado();
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Retangulo")
            {
                return ValidarRetangulo();
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Circulo")
            {
                return ValidarCirculo();
            }

            return false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOpcao.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Quadrado")
            {
                groupBoxQuadrado.Visible = true;
                groupBoxRetangulo.Visible = false;
                groupBoxCirculo.Visible = false;
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Retangulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = true;
                groupBoxCirculo.Visible = false;
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Circulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = false;
                groupBoxCirculo.Visible = true;
                return;
            }
        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = false;
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }

            string largura = textBoxLarguraRetangulo.Text;
            string altura = textBoxAlturaRetangulo.Text;
            string comprimento = textBoxComprimentoRetangulo.Text;

            if (radioButtonPerimetroRetangulo.Checked)
            {
                double resultado = (Convert.ToDouble(altura) * 2) + (Convert.ToDouble(largura) * 2);

                textBoxResultadoRetangulo.Text = resultado.ToString();
                return;
            }

            if (radioButtonAreaRetangulo.Checked)
            {
                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura);

                textBoxResultadoRetangulo.Text = resultado.ToString();
                return;
            }

            if (radioButtonVolumeRetangulo.Checked)
            {
                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura) * Convert.ToDouble(comprimento);

                textBoxResultadoRetangulo.Text = resultado.ToString();
                return;
            }
        }

        private void buttonCalcularQuadrado_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }

            string lado = textBoxLadoQuadrado.Text;

            if (radioButtonPerimetroQuadrado.Checked)
            {
                double resultado = Convert.ToDouble(lado) * 4;
                textBoxResultadoQuadrado.Text = resultado.ToString();
                return;
            }

            if (radioButtonAreaQuadrado.Checked)
            {
                double resultado = Math.Pow(Convert.ToDouble(lado), 2);
                textBoxResultadoQuadrado.Text = resultado.ToString();
                return;
            }

            if (radioButtonVolumeQuadrado.Checked)
            {
                double resultado = Math.Pow(Convert.ToDouble(lado), 3);
                textBoxResultadoQuadrado.Text = resultado.ToString();
                return;
            }
        }

        private void buttonCalcularCirculo_Click(object sender, EventArgs e)
        {
            if (!ValidarForm())
            {
                return;
            }

            double raio = Convert.ToDouble(textBoxRaio.Text);
            double resultado;

            if (radioButtonDiametro.Checked)
            {
                resultado = 2 * raio;
                textBoxResultadoCirculo.Text = $"{resultado:N2}";
                return;
            }

            if (radioButtonPerimetro.Checked)
            {
                resultado = 2 * Math.PI * raio;
                textBoxResultadoCirculo.Text = $"{resultado:N2}";
                return;
            }

            if (radioButtonArea.Checked)
            {
                resultado = Math.PI * Math.Pow(raio, 2);
                textBoxResultadoCirculo.Text = $"{resultado:N2}";
                return;
            }

            if (radioButtonVolume.Checked)
            {
                resultado = (4 / 3) * Math.PI * Math.Pow(raio, 3);
                textBoxResultadoCirculo.Text = $"{resultado:N2}";
                return;
            }
        }
    }
}
