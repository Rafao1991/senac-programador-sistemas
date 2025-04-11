namespace CadastroDeClientes.dominio
{
    internal class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Logradouro))
            {
                return "O campo Logradouro é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Numero))
            {
                return "O campo Número é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Bairro))
            {
                return "O campo Bairro é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(CEP) || CEP.Length != 8)
            {
                return "O campo CEP é obrigatório";
            }

            return string.Empty;
        }
    }
}
