namespace CadastroDeClientes
{
    partial class Form1
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
            listBoxClientes = new ListBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(83, 77);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(519, 94);
            listBoxClientes.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(678, 102);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCadastrar);
            Controls.Add(listBoxClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxClientes;
        private Button buttonCadastrar;
    }
}
