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
            label13 = new Label();
            comboBoxGenero = new ComboBox();
            checkBoxEstrangeiro = new CheckBox();
            textBoxEstado = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxMunicipio = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            buttonEditar = new Button();
            buttonAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(860, 279);
            buttonAdicionar.Margin = new Padding(7, 6, 7, 6);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
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
            dataGridViewClientes.Location = new Point(9, 8);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.Size = new Size(643, 598);
            dataGridViewClientes.TabIndex = 12;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(658, 556);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 11;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(662, 11);
            label1.Margin = new Padding(7, 6, 7, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 999;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 38);
            label2.Margin = new Padding(7, 6, 7, 6);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 999;
            label2.Text = "Nome Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 65);
            label3.Margin = new Padding(7, 6, 7, 6);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 999;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(662, 92);
            label4.Margin = new Padding(7, 6, 7, 6);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 999;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(662, 119);
            label5.Margin = new Padding(7, 6, 7, 6);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 999;
            label5.Text = "Etnia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(662, 146);
            label6.Margin = new Padding(7, 6, 7, 6);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 999;
            label6.Text = "Endereço";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(662, 588);
            labelErro.Margin = new Padding(7, 6, 7, 6);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 999;
            labelErro.Text = "label7";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(792, 10);
            textBoxNome.Margin = new Padding(2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(212, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(792, 37);
            textBoxNomeSocial.Margin = new Padding(2);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(212, 23);
            textBoxNomeSocial.TabIndex = 1;
            // 
            // maskedTextBoxDataNascimento
            // 
            maskedTextBoxDataNascimento.Location = new Point(792, 64);
            maskedTextBoxDataNascimento.Margin = new Padding(2);
            maskedTextBoxDataNascimento.Mask = "00/00/0000";
            maskedTextBoxDataNascimento.Name = "maskedTextBoxDataNascimento";
            maskedTextBoxDataNascimento.Size = new Size(212, 23);
            maskedTextBoxDataNascimento.TabIndex = 2;
            maskedTextBoxDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // radioButtonPf
            // 
            radioButtonPf.AutoSize = true;
            radioButtonPf.Location = new Point(792, 91);
            radioButtonPf.Margin = new Padding(2);
            radioButtonPf.Name = "radioButtonPf";
            radioButtonPf.Size = new Size(38, 19);
            radioButtonPf.TabIndex = 15;
            radioButtonPf.TabStop = true;
            radioButtonPf.Text = "PF";
            radioButtonPf.UseVisualStyleBackColor = true;
            // 
            // radioButtonPj
            // 
            radioButtonPj.AutoSize = true;
            radioButtonPj.Location = new Point(836, 91);
            radioButtonPj.Margin = new Padding(2);
            radioButtonPj.Name = "radioButtonPj";
            radioButtonPj.Size = new Size(35, 19);
            radioButtonPj.TabIndex = 16;
            radioButtonPj.TabStop = true;
            radioButtonPj.Text = "PJ";
            radioButtonPj.UseVisualStyleBackColor = true;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(792, 118);
            comboBoxEtnia.Margin = new Padding(2);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(212, 23);
            comboBoxEtnia.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(662, 173);
            label7.Margin = new Padding(7, 6, 7, 6);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 999;
            label7.Text = "Logradouro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(662, 200);
            label8.Margin = new Padding(7, 6, 7, 6);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 999;
            label8.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(662, 227);
            label9.Margin = new Padding(7, 6, 7, 6);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 999;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(662, 254);
            label10.Margin = new Padding(7, 6, 7, 6);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 999;
            label10.Text = "CEP";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(792, 172);
            textBoxLogradouro.Margin = new Padding(2);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(212, 23);
            textBoxLogradouro.TabIndex = 6;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(792, 226);
            textBoxBairro.Margin = new Padding(2);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(212, 23);
            textBoxBairro.TabIndex = 8;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(792, 199);
            textBoxNumero.Margin = new Padding(2);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(212, 23);
            textBoxNumero.TabIndex = 7;
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(792, 253);
            maskedTextBoxCEP.Margin = new Padding(2);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(212, 23);
            maskedTextBoxCEP.TabIndex = 9;
            maskedTextBoxCEP.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1012, 11);
            label11.Margin = new Padding(7, 6, 7, 6);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 999;
            label11.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1012, 38);
            label12.Margin = new Padding(7, 6, 7, 6);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 999;
            label12.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(1106, 8);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(212, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(1106, 38);
            maskedTextBoxTelefone.Margin = new Padding(2);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(212, 23);
            maskedTextBoxTelefone.TabIndex = 4;
            maskedTextBoxTelefone.ValidatingType = typeof(DateTime);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1012, 121);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 1000;
            label13.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(1106, 116);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(212, 23);
            comboBoxGenero.TabIndex = 1001;
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Location = new Point(1012, 91);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.RightToLeft = RightToLeft.Yes;
            checkBoxEstrangeiro.Size = new Size(85, 19);
            checkBoxEstrangeiro.TabIndex = 1003;
            checkBoxEstrangeiro.Text = "Estrangeiro";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(1106, 197);
            textBoxEstado.Margin = new Padding(2);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(212, 23);
            textBoxEstado.TabIndex = 1005;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(1106, 224);
            textBoxComplemento.Margin = new Padding(2);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(212, 23);
            textBoxComplemento.TabIndex = 1006;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(1106, 170);
            textBoxMunicipio.Margin = new Padding(2);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(212, 23);
            textBoxMunicipio.TabIndex = 1004;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1013, 227);
            label14.Margin = new Padding(7, 6, 7, 6);
            label14.Name = "label14";
            label14.Size = new Size(84, 15);
            label14.TabIndex = 1007;
            label14.Text = "Complemento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1013, 200);
            label15.Margin = new Padding(7, 6, 7, 6);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 1008;
            label15.Text = "Estado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1013, 173);
            label16.Margin = new Padding(7, 6, 7, 6);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 1009;
            label16.Text = "Municipio";
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(658, 527);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 1010;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(1175, 279);
            buttonAtualizar.Margin = new Padding(7, 6, 7, 6);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 1011;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // FormListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 614);
            Controls.Add(buttonAtualizar);
            Controls.Add(buttonEditar);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxMunicipio);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(checkBoxEstrangeiro);
            Controls.Add(comboBoxGenero);
            Controls.Add(label13);
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
        private Label label13;
        private ComboBox comboBoxGenero;
        private CheckBox checkBoxEstrangeiro;
        private TextBox textBoxEstado;
        private TextBox textBoxComplemento;
        private TextBox textBoxMunicipio;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button buttonEditar;
        private Button buttonAtualizar;
    }
}
