using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class FormDetalheCliente : Form
    {
        Cliente Cliente;

        public FormDetalheCliente()
        {
            InitializeComponent();
            Cliente = new Cliente();
        }

        public FormDetalheCliente(Object cliente)
        {
            InitializeComponent();
            Cliente = (Cliente)cliente;
        }

        private void FormDetalheCliente_Load(object sender, EventArgs e)
        {
            if (Cliente.Id == 0)
            {
                return;
            }

            label1.Text = Cliente.Id.ToString();
            label2.Text = Cliente.Nome;
            label3.Text = Cliente.Etnia.ToString();
            label4.Text = Cliente.DataNascimento;
            label5.Text = $"{Cliente.Endereco?.Logradouro}, {Cliente.Endereco?.Numero} - {Cliente.Endereco?.Bairro}";
        }
    }
}
