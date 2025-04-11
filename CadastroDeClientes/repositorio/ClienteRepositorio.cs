using CadastroDeClientes.banco_de_dados;
using CadastroDeClientes.dominio;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                        Tipo = (TipoCliente)reader.GetInt32("tipo"),
                        Etnia = (Etnia)reader.GetInt32("etnia"),
                        Genero = (Genero)reader.GetInt32("genero"),
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

        public Cliente? BuscarClientePorId(int id)
        {
            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id WHERE c.id = @param;";
            return BuscarClientePorUnique(query, id.ToString());
        }

        public Cliente? BuscarClientePorEmail(string email)
        {
            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id WHERE c.email = @param;";
            return BuscarClientePorUnique(query, email);
        }

        public Cliente? BuscarClientePorTelefone(string telefone)
        {
            string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id WHERE c.telefone = @param;";
            return BuscarClientePorUnique(query, telefone);
        }

        public void InserirCliente(Cliente novoCliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                                        "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.Endereco.Complemento);
                    cmd.ExecuteNonQuery();
                }

                int idEndereco = -1;
                string queryIdEndereco = "SELECT id FROM endereco " +
                                            "WHERE logradouro = @logradouro " +
                                            "AND numero = @numero " +
                                            "AND bairro = @bairro " +
                                            "AND municipio = @municipio " +
                                            "AND estado = @estado " +
                                            "AND cep = @cep " +
                                            "AND complemento = @complemento;";
                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.Endereco.CEP);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.Endereco.Complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        idEndereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }

                string query = "INSERT INTO cliente (nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) " +
                                    "VALUES (@nome, @nome_social, @data_nascimento, @email, @telefone, @tipo, @etnia, @genero, @estrangeiro, @id_endereco);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                    cmd.Parameters.AddWithValue("@nome_social", novoCliente.NomeSocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", novoCliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@email", novoCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.Telefone);
                    cmd.Parameters.AddWithValue("@tipo", novoCliente.Tipo);
                    cmd.Parameters.AddWithValue("@etnia", novoCliente.Etnia);
                    cmd.Parameters.AddWithValue("@genero", novoCliente.Genero);
                    cmd.Parameters.AddWithValue("@estrangeiro", novoCliente.Estrangeiro);
                    cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "UPDATE endereco SET logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, municipio = @municipio, estado = @estado, cep = @cep WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", cliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", cliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", cliente.Endereco.Complemento);
                    cmd.Parameters.AddWithValue("@bairro", cliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@municipio", cliente.Endereco.Municipio);
                    cmd.Parameters.AddWithValue("@estado", cliente.Endereco.Estado);
                    cmd.Parameters.AddWithValue("@cep", cliente.Endereco.CEP);

                    cmd.Parameters.AddWithValue("@id", cliente.Endereco.Id);


                    cmd.ExecuteNonQuery();
                }

                string query = "UPDATE cliente SET nome = @nome, nome_social = @nome_social, data_nascimento = @data_nascimento, email = @email, telefone = @telefone, tipo = @tipo, etnia = @etnia, genero = @genero, estrangeiro = @estrangeiro WHERE id = @id;";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@nome_social", cliente.NomeSocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@tipo", cliente.Tipo);
                    cmd.Parameters.AddWithValue("@etnia", cliente.Etnia);
                    cmd.Parameters.AddWithValue("@genero", cliente.Genero);
                    cmd.Parameters.AddWithValue("@estrangeiro", cliente.Estrangeiro);

                    cmd.Parameters.AddWithValue("@id", cliente.Id);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarCliente(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM cliente WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Cliente? BuscarClientePorUnique(string query, string param)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using var reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        return null;
                    }

                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";

                    return new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        NomeSocial = nomeSocial,
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Tipo = (TipoCliente)reader.GetInt32("tipo"),
                        Etnia = (Etnia)reader.GetInt32("etnia"),
                        Genero = (Genero)reader.GetInt32("genero"),
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
                    };
                }
            }
        }
    }
}
