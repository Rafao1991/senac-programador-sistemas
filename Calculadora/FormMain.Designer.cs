namespace Calculadora
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNro1 = new TextBox();
            textBoxNro2 = new TextBox();
            textBoxResultado = new TextBox();
            buttonSoma = new Button();
            labelOperacao = new Label();
            labelResultado = new Label();
            labelErro = new Label();
            radioButtonSoma = new RadioButton();
            radioButtonSubtracao = new RadioButton();
            radioButtonMultiplicacao = new RadioButton();
            radioButtonDivisao = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxNro1
            // 
            textBoxNro1.Location = new Point(13, 50);
            textBoxNro1.Name = "textBoxNro1";
            textBoxNro1.Size = new Size(50, 23);
            textBoxNro1.TabIndex = 0;
            textBoxNro1.Visible = false;
            // 
            // textBoxNro2
            // 
            textBoxNro2.Location = new Point(90, 50);
            textBoxNro2.Name = "textBoxNro2";
            textBoxNro2.Size = new Size(50, 23);
            textBoxNro2.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Enabled = false;
            textBoxResultado.Location = new Point(167, 50);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(50, 23);
            textBoxResultado.TabIndex = 2;
            // 
            // buttonSoma
            // 
            buttonSoma.Location = new Point(13, 13);
            buttonSoma.Name = "buttonSoma";
            buttonSoma.Size = new Size(75, 23);
            buttonSoma.TabIndex = 3;
            buttonSoma.Text = "Calcular";
            buttonSoma.UseVisualStyleBackColor = true;
            buttonSoma.Click += buttonCalcular_Click;
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Location = new Point(69, 53);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(15, 15);
            labelOperacao.TabIndex = 4;
            labelOperacao.Text = "+";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(146, 53);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(15, 15);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "=";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErro.ForeColor = Color.Red;
            labelErro.Location = new Point(13, 536);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 20);
            labelErro.TabIndex = 6;
            // 
            // radioButtonSoma
            // 
            radioButtonSoma.AutoSize = true;
            radioButtonSoma.Location = new Point(13, 79);
            radioButtonSoma.Name = "radioButtonSoma";
            radioButtonSoma.Size = new Size(55, 19);
            radioButtonSoma.TabIndex = 7;
            radioButtonSoma.TabStop = true;
            radioButtonSoma.Text = "Soma";
            radioButtonSoma.UseVisualStyleBackColor = true;
            radioButtonSoma.CheckedChanged += radioButtonSoma_CheckedChanged;
            // 
            // radioButtonSubtracao
            // 
            radioButtonSubtracao.AutoSize = true;
            radioButtonSubtracao.Location = new Point(13, 104);
            radioButtonSubtracao.Name = "radioButtonSubtracao";
            radioButtonSubtracao.Size = new Size(78, 19);
            radioButtonSubtracao.TabIndex = 8;
            radioButtonSubtracao.TabStop = true;
            radioButtonSubtracao.Text = "Subtração";
            radioButtonSubtracao.UseVisualStyleBackColor = true;
            radioButtonSubtracao.CheckedChanged += radioButtonSubtracao_CheckedChanged;
            // 
            // radioButtonMultiplicacao
            // 
            radioButtonMultiplicacao.AutoSize = true;
            radioButtonMultiplicacao.Location = new Point(13, 129);
            radioButtonMultiplicacao.Name = "radioButtonMultiplicacao";
            radioButtonMultiplicacao.Size = new Size(97, 19);
            radioButtonMultiplicacao.TabIndex = 9;
            radioButtonMultiplicacao.TabStop = true;
            radioButtonMultiplicacao.Text = "Multiplicação";
            radioButtonMultiplicacao.UseVisualStyleBackColor = true;
            radioButtonMultiplicacao.CheckedChanged += radioButtonMultiplicacao_CheckedChanged;
            // 
            // radioButtonDivisao
            // 
            radioButtonDivisao.AutoSize = true;
            radioButtonDivisao.Location = new Point(13, 154);
            radioButtonDivisao.Name = "radioButtonDivisao";
            radioButtonDivisao.Size = new Size(63, 19);
            radioButtonDivisao.TabIndex = 10;
            radioButtonDivisao.TabStop = true;
            radioButtonDivisao.Text = "Divisão";
            radioButtonDivisao.UseVisualStyleBackColor = true;
            radioButtonDivisao.CheckedChanged += radioButtonDivisao_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(553, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(button1);
            Controls.Add(radioButtonDivisao);
            Controls.Add(radioButtonMultiplicacao);
            Controls.Add(radioButtonSubtracao);
            Controls.Add(radioButtonSoma);
            Controls.Add(labelErro);
            Controls.Add(labelResultado);
            Controls.Add(labelOperacao);
            Controls.Add(buttonSoma);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxNro2);
            Controls.Add(textBoxNro1);
            Name = "FormMain";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNro1;
        private TextBox textBoxNro2;
        private TextBox textBoxResultado;
        private Button buttonSoma;
        private Label labelOperacao;
        private Label labelResultado;
        private Label labelErro;
        private RadioButton radioButtonSoma;
        private RadioButton radioButtonSubtracao;
        private RadioButton radioButtonMultiplicacao;
        private RadioButton radioButtonDivisao;
        private Button button1;
    }
}
