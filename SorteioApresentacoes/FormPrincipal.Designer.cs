namespace SorteioApresentacoes
{
    partial class FormPrincipal
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
            buttonCriarApresentacao = new Button();
            dataGridViewOrdermApresentacao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdermApresentacao).BeginInit();
            SuspendLayout();
            // 
            // buttonCriarApresentacao
            // 
            buttonCriarApresentacao.Location = new Point(12, 12);
            buttonCriarApresentacao.Name = "buttonCriarApresentacao";
            buttonCriarApresentacao.Size = new Size(165, 23);
            buttonCriarApresentacao.TabIndex = 0;
            buttonCriarApresentacao.Text = "Criar Apresentação";
            buttonCriarApresentacao.UseVisualStyleBackColor = true;
            buttonCriarApresentacao.Click += buttonCriarApresentacao_Click;
            // 
            // dataGridViewOrdermApresentacao
            // 
            dataGridViewOrdermApresentacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrdermApresentacao.Location = new Point(183, 12);
            dataGridViewOrdermApresentacao.Name = "dataGridViewOrdermApresentacao";
            dataGridViewOrdermApresentacao.Size = new Size(305, 305);
            dataGridViewOrdermApresentacao.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 329);
            Controls.Add(dataGridViewOrdermApresentacao);
            Controls.Add(buttonCriarApresentacao);
            Name = "FormPrincipal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrdermApresentacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCriarApresentacao;
        private DataGridView dataGridViewOrdermApresentacao;
    }
}
