namespace Calculadora
{
    partial class NovoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxRetangulo = new GroupBox();
            buttonCalcularRetangulo = new Button();
            radioButtonVolumeRetangulo = new RadioButton();
            radioButtonAreaRetangulo = new RadioButton();
            radioButtonPerimetroRetangulo = new RadioButton();
            textBoxResultadoRetangulo = new TextBox();
            labelResultado = new Label();
            label3 = new Label();
            labelAltura = new Label();
            labelLargura = new Label();
            textBoxComprimentoRetangulo = new TextBox();
            textBoxAlturaRetangulo = new TextBox();
            textBoxLarguraRetangulo = new TextBox();
            groupBoxQuadrado = new GroupBox();
            buttonCalcularQuadrado = new Button();
            radioButtonVolumeQuadrado = new RadioButton();
            radioButtonAreaQuadrado = new RadioButton();
            radioButtonPerimetroQuadrado = new RadioButton();
            textBoxResultadoQuadrado = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBoxLadoQuadrado = new TextBox();
            comboBoxOpcao = new ComboBox();
            labelErro = new Label();
            groupBoxCirculo = new GroupBox();
            textBoxResultadoCirculo = new TextBox();
            labelResultadoCirculo = new Label();
            buttonCalcularCirculo = new Button();
            radioButtonVolume = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonDiametro = new RadioButton();
            label8 = new Label();
            textBoxRaio = new TextBox();
            groupBoxRetangulo.SuspendLayout();
            groupBoxQuadrado.SuspendLayout();
            groupBoxCirculo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(buttonCalcularRetangulo);
            groupBoxRetangulo.Controls.Add(radioButtonVolumeRetangulo);
            groupBoxRetangulo.Controls.Add(radioButtonAreaRetangulo);
            groupBoxRetangulo.Controls.Add(radioButtonPerimetroRetangulo);
            groupBoxRetangulo.Controls.Add(textBoxResultadoRetangulo);
            groupBoxRetangulo.Controls.Add(labelResultado);
            groupBoxRetangulo.Controls.Add(label3);
            groupBoxRetangulo.Controls.Add(labelAltura);
            groupBoxRetangulo.Controls.Add(labelLargura);
            groupBoxRetangulo.Controls.Add(textBoxComprimentoRetangulo);
            groupBoxRetangulo.Controls.Add(textBoxAlturaRetangulo);
            groupBoxRetangulo.Controls.Add(textBoxLarguraRetangulo);
            groupBoxRetangulo.Location = new Point(12, 41);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(445, 154);
            groupBoxRetangulo.TabIndex = 3;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Visible = false;
            // 
            // buttonCalcularRetangulo
            // 
            buttonCalcularRetangulo.Location = new Point(364, 22);
            buttonCalcularRetangulo.Name = "buttonCalcularRetangulo";
            buttonCalcularRetangulo.Size = new Size(75, 23);
            buttonCalcularRetangulo.TabIndex = 11;
            buttonCalcularRetangulo.Text = "Calcular";
            buttonCalcularRetangulo.UseVisualStyleBackColor = true;
            buttonCalcularRetangulo.Click += buttonCalcular_Click;
            // 
            // radioButtonVolumeRetangulo
            // 
            radioButtonVolumeRetangulo.AutoSize = true;
            radioButtonVolumeRetangulo.Location = new Point(230, 73);
            radioButtonVolumeRetangulo.Name = "radioButtonVolumeRetangulo";
            radioButtonVolumeRetangulo.Size = new Size(65, 19);
            radioButtonVolumeRetangulo.TabIndex = 10;
            radioButtonVolumeRetangulo.TabStop = true;
            radioButtonVolumeRetangulo.Text = "Volume";
            radioButtonVolumeRetangulo.UseVisualStyleBackColor = true;
            radioButtonVolumeRetangulo.CheckedChanged += radioButtonVolume_CheckedChanged;
            // 
            // radioButtonAreaRetangulo
            // 
            radioButtonAreaRetangulo.AutoSize = true;
            radioButtonAreaRetangulo.Location = new Point(230, 48);
            radioButtonAreaRetangulo.Name = "radioButtonAreaRetangulo";
            radioButtonAreaRetangulo.Size = new Size(49, 19);
            radioButtonAreaRetangulo.TabIndex = 9;
            radioButtonAreaRetangulo.TabStop = true;
            radioButtonAreaRetangulo.Text = "Area";
            radioButtonAreaRetangulo.UseVisualStyleBackColor = true;
            radioButtonAreaRetangulo.CheckedChanged += radioButtonArea_CheckedChanged;
            // 
            // radioButtonPerimetroRetangulo
            // 
            radioButtonPerimetroRetangulo.AutoSize = true;
            radioButtonPerimetroRetangulo.Location = new Point(230, 23);
            radioButtonPerimetroRetangulo.Name = "radioButtonPerimetroRetangulo";
            radioButtonPerimetroRetangulo.Size = new Size(77, 19);
            radioButtonPerimetroRetangulo.TabIndex = 8;
            radioButtonPerimetroRetangulo.TabStop = true;
            radioButtonPerimetroRetangulo.Text = "Perimetro";
            radioButtonPerimetroRetangulo.UseVisualStyleBackColor = true;
            radioButtonPerimetroRetangulo.CheckedChanged += radioButtonPerimetro_CheckedChanged;
            // 
            // textBoxResultadoRetangulo
            // 
            textBoxResultadoRetangulo.Location = new Point(97, 109);
            textBoxResultadoRetangulo.Name = "textBoxResultadoRetangulo";
            textBoxResultadoRetangulo.ReadOnly = true;
            textBoxResultadoRetangulo.Size = new Size(100, 23);
            textBoxResultadoRetangulo.TabIndex = 7;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(6, 112);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(62, 15);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "Resultado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "Comprimento:";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(6, 54);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(42, 15);
            labelAltura.TabIndex = 4;
            labelAltura.Text = "Altura:";
            // 
            // labelLargura
            // 
            labelLargura.AutoSize = true;
            labelLargura.Location = new Point(6, 25);
            labelLargura.Name = "labelLargura";
            labelLargura.Size = new Size(50, 15);
            labelLargura.TabIndex = 3;
            labelLargura.Text = "Largura:";
            // 
            // textBoxComprimentoRetangulo
            // 
            textBoxComprimentoRetangulo.Enabled = false;
            textBoxComprimentoRetangulo.Location = new Point(97, 80);
            textBoxComprimentoRetangulo.Name = "textBoxComprimentoRetangulo";
            textBoxComprimentoRetangulo.Size = new Size(100, 23);
            textBoxComprimentoRetangulo.TabIndex = 2;
            // 
            // textBoxAlturaRetangulo
            // 
            textBoxAlturaRetangulo.Location = new Point(97, 51);
            textBoxAlturaRetangulo.Name = "textBoxAlturaRetangulo";
            textBoxAlturaRetangulo.Size = new Size(100, 23);
            textBoxAlturaRetangulo.TabIndex = 1;
            // 
            // textBoxLarguraRetangulo
            // 
            textBoxLarguraRetangulo.Location = new Point(97, 22);
            textBoxLarguraRetangulo.Name = "textBoxLarguraRetangulo";
            textBoxLarguraRetangulo.Size = new Size(100, 23);
            textBoxLarguraRetangulo.TabIndex = 0;
            // 
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(buttonCalcularQuadrado);
            groupBoxQuadrado.Controls.Add(radioButtonVolumeQuadrado);
            groupBoxQuadrado.Controls.Add(radioButtonAreaQuadrado);
            groupBoxQuadrado.Controls.Add(radioButtonPerimetroQuadrado);
            groupBoxQuadrado.Controls.Add(textBoxResultadoQuadrado);
            groupBoxQuadrado.Controls.Add(label1);
            groupBoxQuadrado.Controls.Add(label5);
            groupBoxQuadrado.Controls.Add(textBoxLadoQuadrado);
            groupBoxQuadrado.Location = new Point(463, 41);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(445, 154);
            groupBoxQuadrado.TabIndex = 12;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Visible = false;
            // 
            // buttonCalcularQuadrado
            // 
            buttonCalcularQuadrado.Location = new Point(364, 22);
            buttonCalcularQuadrado.Name = "buttonCalcularQuadrado";
            buttonCalcularQuadrado.Size = new Size(75, 23);
            buttonCalcularQuadrado.TabIndex = 11;
            buttonCalcularQuadrado.Text = "Calcular";
            buttonCalcularQuadrado.UseVisualStyleBackColor = true;
            buttonCalcularQuadrado.Click += buttonCalcularQuadrado_Click;
            // 
            // radioButtonVolumeQuadrado
            // 
            radioButtonVolumeQuadrado.AutoSize = true;
            radioButtonVolumeQuadrado.Location = new Point(230, 73);
            radioButtonVolumeQuadrado.Name = "radioButtonVolumeQuadrado";
            radioButtonVolumeQuadrado.Size = new Size(65, 19);
            radioButtonVolumeQuadrado.TabIndex = 10;
            radioButtonVolumeQuadrado.TabStop = true;
            radioButtonVolumeQuadrado.Text = "Volume";
            radioButtonVolumeQuadrado.UseVisualStyleBackColor = true;
            // 
            // radioButtonAreaQuadrado
            // 
            radioButtonAreaQuadrado.AutoSize = true;
            radioButtonAreaQuadrado.Location = new Point(230, 48);
            radioButtonAreaQuadrado.Name = "radioButtonAreaQuadrado";
            radioButtonAreaQuadrado.Size = new Size(49, 19);
            radioButtonAreaQuadrado.TabIndex = 9;
            radioButtonAreaQuadrado.TabStop = true;
            radioButtonAreaQuadrado.Text = "Area";
            radioButtonAreaQuadrado.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetroQuadrado
            // 
            radioButtonPerimetroQuadrado.AutoSize = true;
            radioButtonPerimetroQuadrado.Location = new Point(230, 23);
            radioButtonPerimetroQuadrado.Name = "radioButtonPerimetroQuadrado";
            radioButtonPerimetroQuadrado.Size = new Size(77, 19);
            radioButtonPerimetroQuadrado.TabIndex = 8;
            radioButtonPerimetroQuadrado.TabStop = true;
            radioButtonPerimetroQuadrado.Text = "Perimetro";
            radioButtonPerimetroQuadrado.UseVisualStyleBackColor = true;
            // 
            // textBoxResultadoQuadrado
            // 
            textBoxResultadoQuadrado.Location = new Point(97, 51);
            textBoxResultadoQuadrado.Name = "textBoxResultadoQuadrado";
            textBoxResultadoQuadrado.ReadOnly = true;
            textBoxResultadoQuadrado.Size = new Size(100, 23);
            textBoxResultadoQuadrado.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Resultado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 3;
            label5.Text = "Lado:";
            // 
            // textBoxLadoQuadrado
            // 
            textBoxLadoQuadrado.Location = new Point(97, 22);
            textBoxLadoQuadrado.Name = "textBoxLadoQuadrado";
            textBoxLadoQuadrado.Size = new Size(100, 23);
            textBoxLadoQuadrado.TabIndex = 0;
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Quadrado", "Retangulo", "Circulo" });
            comboBoxOpcao.Location = new Point(12, 12);
            comboBoxOpcao.Name = "comboBoxOpcao";
            comboBoxOpcao.Size = new Size(121, 23);
            comboBoxOpcao.TabIndex = 1;
            comboBoxOpcao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.ForeColor = Color.Red;
            labelErro.Location = new Point(12, 426);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 2;
            // 
            // groupBoxCirculo
            // 
            groupBoxCirculo.Controls.Add(textBoxResultadoCirculo);
            groupBoxCirculo.Controls.Add(labelResultadoCirculo);
            groupBoxCirculo.Controls.Add(buttonCalcularCirculo);
            groupBoxCirculo.Controls.Add(radioButtonVolume);
            groupBoxCirculo.Controls.Add(radioButtonArea);
            groupBoxCirculo.Controls.Add(radioButtonPerimetro);
            groupBoxCirculo.Controls.Add(radioButtonDiametro);
            groupBoxCirculo.Controls.Add(label8);
            groupBoxCirculo.Controls.Add(textBoxRaio);
            groupBoxCirculo.Location = new Point(12, 201);
            groupBoxCirculo.Name = "groupBoxCirculo";
            groupBoxCirculo.Size = new Size(445, 145);
            groupBoxCirculo.TabIndex = 17;
            groupBoxCirculo.TabStop = false;
            groupBoxCirculo.Visible = false;
            // 
            // textBoxResultadoCirculo
            // 
            textBoxResultadoCirculo.Location = new Point(97, 51);
            textBoxResultadoCirculo.Name = "textBoxResultadoCirculo";
            textBoxResultadoCirculo.Size = new Size(100, 23);
            textBoxResultadoCirculo.TabIndex = 25;
            // 
            // labelResultadoCirculo
            // 
            labelResultadoCirculo.AutoSize = true;
            labelResultadoCirculo.Location = new Point(6, 54);
            labelResultadoCirculo.Name = "labelResultadoCirculo";
            labelResultadoCirculo.Size = new Size(62, 15);
            labelResultadoCirculo.TabIndex = 24;
            labelResultadoCirculo.Text = "Resultado:";
            // 
            // buttonCalcularCirculo
            // 
            buttonCalcularCirculo.Location = new Point(364, 22);
            buttonCalcularCirculo.Name = "buttonCalcularCirculo";
            buttonCalcularCirculo.Size = new Size(75, 23);
            buttonCalcularCirculo.TabIndex = 18;
            buttonCalcularCirculo.Text = "Calcular";
            buttonCalcularCirculo.UseVisualStyleBackColor = true;
            buttonCalcularCirculo.Click += buttonCalcularCirculo_Click;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(230, 98);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 23;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(230, 73);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 22;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(230, 48);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 21;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiametro
            // 
            radioButtonDiametro.AutoSize = true;
            radioButtonDiametro.Location = new Point(230, 23);
            radioButtonDiametro.Name = "radioButtonDiametro";
            radioButtonDiametro.Size = new Size(74, 19);
            radioButtonDiametro.TabIndex = 20;
            radioButtonDiametro.TabStop = true;
            radioButtonDiametro.Text = "Diametro";
            radioButtonDiametro.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 18;
            label8.Text = "Raio:";
            // 
            // textBoxRaio
            // 
            textBoxRaio.Location = new Point(97, 22);
            textBoxRaio.Name = "textBoxRaio";
            textBoxRaio.Size = new Size(100, 23);
            textBoxRaio.TabIndex = 19;
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 450);
            Controls.Add(groupBoxCirculo);
            Controls.Add(labelErro);
            Controls.Add(comboBoxOpcao);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(groupBoxQuadrado);
            Name = "NovoForm";
            Text = "NovoForm";
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            groupBoxCirculo.ResumeLayout(false);
            groupBoxCirculo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxOpcao;
        private GroupBox groupBoxRetangulo;
        private Label labelErro;
        private Label label3;
        private Label labelAltura;
        private Label labelLargura;
        private TextBox textBoxComprimentoRetangulo;
        private TextBox textBoxAlturaRetangulo;
        private TextBox textBoxLarguraRetangulo;
        private Button buttonCalcularRetangulo;
        private RadioButton radioButtonVolumeRetangulo;
        private RadioButton radioButtonAreaRetangulo;
        private RadioButton radioButtonPerimetroRetangulo;
        private TextBox textBoxResultadoRetangulo;
        private Label labelResultado;
        private GroupBox groupBoxQuadrado;
        private Button buttonCalcularQuadrado;
        private RadioButton radioButtonVolumeQuadrado;
        private RadioButton radioButtonAreaQuadrado;
        private RadioButton radioButtonPerimetroQuadrado;
        private TextBox textBoxResultadoQuadrado;
        private Label label1;
        private Label label5;
        private TextBox textBoxLadoQuadrado;
        private GroupBox groupBoxCirculo;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonDiametro;
        private Label label8;
        private TextBox textBoxRaio;
        private TextBox textBoxResultadoCirculo;
        private Label labelResultadoCirculo;
        private Button buttonCalcularCirculo;
    }
}