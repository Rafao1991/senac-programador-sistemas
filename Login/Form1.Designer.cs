namespace Login
{
    partial class FormLogin
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(118, 21);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(191, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.Text = "rafael";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(118, 50);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(191, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(176, 79);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 23);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 53);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "senha";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BorderStyle = BorderStyle.FixedSingle;
            labelResultado.Font = new Font("Segoe UI", 14F);
            labelResultado.Location = new Point(64, 139);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(2, 27);
            labelResultado.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(533, 321);
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            Text = "Login :)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonEntrar;
        private Label label1;
        private Label label2;
        private Label labelResultado;
    }
}
