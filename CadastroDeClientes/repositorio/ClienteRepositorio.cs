using CadastroDeClientes.banco_de_dados;
using CadastroDeClientes.dominio;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroDeClientes.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();
            
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";
                
                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        NomeSocial = nomeSocial,
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Tipo = (TipoCliente) reader.GetInt32("tipo"),
                        Etnia = (Etnia) reader.GetInt32("etnia"),
                        Genero = (Genero) reader.GetInt32("genero"),
                        Estrangeiro = reader.GetBoolean("estrangeiro"),
                        Endereco = new Endereco
                        {
                            Id = reader.GetInt32("id_endereco"),
                            Logradouro = reader.GetString("logradouro"),
                            Numero = reader.GetString("numero"),
                            Complemento = complemento,
                            Bairro = reader.GetString("bairro"),
                            Municipio = reader.GetString("municipio"),
                            Estado = reader.GetString("estado"),
                            CEP = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;
        }

        //public void AddCliente(Client client)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "INSERT INTO clients (name, email, phone) VALUES (@name, @email, @phone)";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@name", client.Name);
        //            cmd.Parameters.AddWithValue("@email", client.Email);
        //            cmd.Parameters.AddWithValue("@phone", client.Phone);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public void UpdateCliente(Client client)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "UPDATE clients SET name=@name, email=@email, phone=@phone WHERE id=@id";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", client.Id);
        //            cmd.Parameters.AddWithValue("@name", client.Name);
        //            cmd.Parameters.AddWithValue("@email", client.Email);
        //            cmd.Parameters.AddWithValue("@phone", client.Phone);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public void DeleteCliente(int id)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "DELETE FROM clients WHERE id=@id";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
