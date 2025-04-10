using MySql.Data.MySqlClient;

namespace CadastroDeClientes.banco_de_dados
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
