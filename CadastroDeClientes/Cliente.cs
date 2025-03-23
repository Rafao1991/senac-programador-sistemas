using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    internal class Cliente
    {
        public required int Id { get; set; }
        public required string Nome { get; set; }
        public string? NomeSocial { get; set; }
        public required string DataNascimento { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public required TipoCliente Tipo { get; set; }
        public required Etnia Etnia { get; set; }
        public required Endereco Endereco { get; set; }
    }
}
