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
            buttonCalcular = new Button();
            radioButtonVolume = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            textBoxResultado = new TextBox();
            labelResultado = new Label();
            label3 = new Label();
            labelAltura = new Label();
            labelLargura = new Label();
            textBoxComprimento = new TextBox();
            textBoxAltura = new TextBox();
            textBoxLargura = new TextBox();
            comboBoxOpcao = new ComboBox();
            labelErro = new Label();
            groupBoxQuadrado = new GroupBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBoxRetangulo.SuspendLayout();
            groupBoxQuadrado.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(buttonCalcular);
            groupBoxRetangulo.Controls.Add(radioButtonVolume);
            groupBoxRetangulo.Controls.Add(radioButtonArea);
            groupBoxRetangulo.Controls.Add(radioButtonPerimetro);
            groupBoxRetangulo.Controls.Add(textBoxResultado);
            groupBoxRetangulo.Controls.Add(labelResultado);
            groupBoxRetangulo.Controls.Add(label3);
            groupBoxRetangulo.Controls.Add(labelAltura);
            groupBoxRetangulo.Controls.Add(labelLargura);
            groupBoxRetangulo.Controls.Add(textBoxComprimento);
            groupBoxRetangulo.Controls.Add(textBoxAltura);
            groupBoxRetangulo.Controls.Add(textBoxLargura);
            groupBoxRetangulo.Location = new Point(12, 41);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(445, 154);
            groupBoxRetangulo.TabIndex = 3;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Visible = false;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(364, 22);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 11;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(230, 79);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 10;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            radioButtonVolume.CheckedChanged += radioButtonVolume_CheckedChanged;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(230, 50);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 9;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButtonArea_CheckedChanged;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(230, 23);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 8;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            radioButtonPerimetro.CheckedChanged += radioButtonPerimetro_CheckedChanged;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(97, 109);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(100, 23);
            textBoxResultado.TabIndex = 7;
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
            // textBoxComprimento
            // 
            textBoxComprimento.Enabled = false;
            textBoxComprimento.Location = new Point(97, 80);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(100, 23);
            textBoxComprimento.TabIndex = 2;
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(97, 51);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(100, 23);
            textBoxAltura.TabIndex = 1;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(97, 22);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(100, 23);
            textBoxLargura.TabIndex = 0;
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Quadrado", "Retangulo" });
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
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(button1);
            groupBoxQuadrado.Controls.Add(radioButton1);
            groupBoxQuadrado.Controls.Add(radioButton2);
            groupBoxQuadrado.Controls.Add(radioButton3);
            groupBoxQuadrado.Controls.Add(textBox1);
            groupBoxQuadrado.Controls.Add(label1);
            groupBoxQuadrado.Controls.Add(label2);
            groupBoxQuadrado.Controls.Add(label4);
            groupBoxQuadrado.Controls.Add(label5);
            groupBoxQuadrado.Controls.Add(textBox2);
            groupBoxQuadrado.Controls.Add(textBox3);
            groupBoxQuadrado.Controls.Add(textBox4);
            groupBoxQuadrado.Location = new Point(12, 221);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(445, 154);
            groupBoxQuadrado.TabIndex = 12;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(364, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(230, 79);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Volume";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(230, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Area";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(230, 23);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Perimetro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 109);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 112);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Resultado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "Comprimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Altura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 3;
            label5.Text = "Largura:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 0;
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxQuadrado);
            Controls.Add(labelErro);
            Controls.Add(comboBoxOpcao);
            Controls.Add(groupBoxRetangulo);
            Name = "NovoForm";
            Text = "NovoForm";
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
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
        private TextBox textBoxComprimento;
        private TextBox textBoxAltura;
        private TextBox textBoxLargura;
        private Button buttonCalcular;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonPerimetro;
        private TextBox textBoxResultado;
        private Label labelResultado;
        private GroupBox groupBoxQuadrado;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}