namespace Calculadora
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        // Funções de validação

        // Recebe uma lista de RadioButtons e verifica se nenhum deles está selecionado
        // Utiliza o método All da classe Enumerable para verificar se todos os elementos da lista retornam false
        // Como paramentro para o metodo All, é passado uma função lambda que verifica se o RadioButton está selecionado
        private bool RadioNaoSelecionado(List<RadioButton> radios)
        {
            return radios.All(radio => !radio.Checked);
        }

        // Função que verifica se o valor passado é inválido
        // Verifica se o valor é nulo ou se contém algum caractere que não é um número
        // Utiliza o método All da classe Enumerable para verificar se todos os caracteres da string são números
        private bool ValorInvalido(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) || !valor.All(char.IsNumber);
        }

        // Função que valida o formulário do quadrado
        private bool ValidarQuadrado()
        {
            // Lista de RadioButtons que representam as operações possíveis
            List<RadioButton> radios = new List<RadioButton> { radioButtonPerimetroQuadrado, radioButtonAreaQuadrado, radioButtonVolumeQuadrado };
            // Verifica se nenhuma operação foi selecionada
            if (RadioNaoSelecionado(radios))
            {
                labelErro.Text = "Selecione uma operacao.";
                return false;
            }

            // Verifica se o valor do lado é inválido
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

        // Função que valida o formulário
        // Verifica se a opção foi selecionada e chama a função de validação correspondente
        // Retorna false se a validação falhar ou true se passar
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

        // Funções de eventos

        // Evento que é chamado quando o valor do ComboBox é alterado
        // Verifica qual opção foi selecionada e exibe o formulário correspondente
        // Utiliza a propriedade Visible dos GroupBox para exibir ou ocultar os formulários
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

        // Evento que é chamado quando o RadioButton de perimetro é selecionado
        // Desabilita o campo de comprimento
        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = false;
        }

        // Evento que é chamado quando o RadioButton de area é selecionado
        // Desabilita o campo de comprimento
        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = false;
        }

        // Evento que é chamado quando o RadioButton de volume é selecionado
        // Habilita o campo de comprimento
        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimentoRetangulo.Enabled = true;
        }

        // Evento que é chamado quando o botão de calcular retangulo é clicado
        // Verifica se o formulário é válido e executa o cálculo correspondente
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

        // Evento que é chamado quando o botão de calcular quadrado é clicado
        // Verifica se o formulário é válido e executa o cálculo correspondente
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

        // Evento que é chamado quando o botão de calcular circulo é clicado
        // Verifica se o formulário é válido e executa o cálculo correspondente
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
