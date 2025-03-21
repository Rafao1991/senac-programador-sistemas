namespace CadastroDeClientes
{
    partial class FormListaClientes
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
            buttonAdicionar = new Button();
            dataGridViewClientes = new DataGridView();
            buttonRemover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelErro = new Label();
            textBoxNome = new TextBox();
            textBoxNomeSocial = new TextBox();
            maskedTextBoxDataNascimento = new MaskedTextBox();
            radioButtonPf = new RadioButton();
            radioButtonPj = new RadioButton();
            comboBoxEtnia = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxLogradouro = new TextBox();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            maskedTextBoxCEP = new MaskedTextBox();
            label11 = new Label();
            label12 = new Label();
            textBoxEmail = new TextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(1149, 465);
            buttonAdicionar.Margin = new Padding(10);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(107, 38);
            buttonAdicionar.TabIndex = 10;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(13, 14);
            dataGridViewClientes.Margin = new Padding(4, 5, 4, 5);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.Size = new Size(839, 996);
            dataGridViewClientes.TabIndex = 12;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(860, 927);
            buttonRemover.Margin = new Padding(4, 5, 4, 5);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(107, 38);
            buttonRemover.TabIndex = 11;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(866, 19);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 999;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(866, 64);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 999;
            label2.Text = "Nome Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(866, 109);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 999;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(866, 154);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 999;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(866, 199);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 999;
            label5.Text = "Etnia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(866, 244);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 999;
            label6.Text = "Endereço";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(866, 980);
            labelErro.Margin = new Padding(10);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(59, 25);
            labelErro.TabIndex = 999;
            labelErro.Text = "label7";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(1052, 16);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(301, 31);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(1052, 61);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(301, 31);
            textBoxNomeSocial.TabIndex = 1;
            // 
            // maskedTextBoxDataNascimento
            // 
            maskedTextBoxDataNascimento.Location = new Point(1052, 106);
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
            maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            maskedTextBoxDataNascimento.Size = new Size(301, 31);
            maskedTextBoxDataNascimento.TabIndex = 2;
            maskedTextBoxDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // radioButtonPf
            // 
            radioButtonPf.AutoSize = true;
            radioButtonPf.Location = new Point(1052, 152);
            radioButtonPf.Name = "radioButtonPf";
            radioButtonPf.Size = new Size(56, 29);
            radioButtonPf.TabIndex = 15;
            radioButtonPf.TabStop = true;
            radioButtonPf.Text = "PF";
            radioButtonPf.UseVisualStyleBackColor = true;
            // 
            // radioButtonPj
            // 
            radioButtonPj.AutoSize = true;
            radioButtonPj.Location = new Point(1114, 152);
            radioButtonPj.Name = "radioButtonPj";
            radioButtonPj.Size = new Size(52, 29);
            radioButtonPj.TabIndex = 16;
            radioButtonPj.TabStop = true;
            radioButtonPj.Text = "PJ";
            radioButtonPj.UseVisualStyleBackColor = true;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(1052, 196);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(301, 33);
            comboBoxEtnia.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(866, 289);
            label7.Margin = new Padding(10);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 999;
            label7.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(866, 334);
            label8.Margin = new Padding(10);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 999;
            label8.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(866, 379);
            label9.Margin = new Padding(10);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 999;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(866, 424);
            label10.Margin = new Padding(10);
            label10.Name = "label10";
            label10.Size = new Size(42, 25);
            label10.TabIndex = 999;
            label10.Text = "CEP";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(1052, 286);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(301, 31);
            textBoxLogradouro.TabIndex = 6;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(1052, 376);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(301, 31);
            textBoxBairro.TabIndex = 8;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(1052, 331);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(301, 31);
            textBoxNumero.TabIndex = 7;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(1052, 421);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(301, 31);
            maskedTextBoxCEP.TabIndex = 9;
            maskedTextBoxCEP.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1366, 19);
            label11.Margin = new Padding(10);
            label11.Name = "label11";
            label11.Size = new Size(54, 25);
            label11.TabIndex = 999;
            label11.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1366, 64);
            label12.Margin = new Padding(10);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 999;
            label12.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(1456, 16);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(301, 31);
            textBoxEmail.TabIndex = 3;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(1456, 61);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(301, 31);
            maskedTextBoxTelefone.TabIndex = 4;
            maskedTextBoxTelefone.ValidatingType = typeof(DateTime);
            // 
            // FormListaClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxEtnia);
            Controls.Add(radioButtonPj);
            Controls.Add(radioButtonPf);
            Controls.Add(maskedTextBoxDataNascimento);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(textBoxNome);
            Controls.Add(labelErro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRemover);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonAdicionar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdicionar;
        private DataGridView dataGridViewClientes;
        private Button buttonRemover;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelErro;
        private TextBox textBoxNome;
        private TextBox textBoxNomeSocial;
        private MaskedTextBox maskedTextBoxDataNascimento;
        private RadioButton radioButtonPf;
        private RadioButton radioButtonPj;
        private ComboBox comboBoxEtnia;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxLogradouro;
        private TextBox textBoxBairro;
        private TextBox textBoxNumero;
        private MaskedTextBox maskedTextBoxCEP;
        private Label label11;
        private Label label12;
        private TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxTelefone;
    }
}
