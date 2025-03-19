using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public TipoCliente Tipo { get; set; }
        public Endereco Endereco { get; set; }
        public Etnia Etnia { get; set; }

        public bool Validar()
        {
            if (DataNascimento == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(Endereco.Logradouro))
            {
                return false;
            }

            .
            .
            .
            .
            .
            .
            .

            return true;
    }
}
