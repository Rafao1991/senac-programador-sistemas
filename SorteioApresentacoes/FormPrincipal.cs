using MySql.Data.MySqlClient;

namespace SorteioApresentacoes
{
    public partial class FormPrincipal : Form
    {
        private static readonly string connectionString = "datasource=localhost;username=root;password=;database=sorteio_apresentacoes;";
        private static readonly List<ApresentacaoModel> apresentacoes = [];

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCriarApresentacao_Click(object sender, EventArgs e)
        {
            if (apresentacoes.Count > 0)
            {
                return;
            }

            CriarOrdemApresentacao(CriarApresentacao());
            CarregarApresentacao();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarApresentacao();
        }

        private void CarregarApresentacao()
        {
            dataGridViewOrdermApresentacao.DataSource = null;
            apresentacoes.Clear();

            var hoje = DateTime.Now;
            var query = "SELECT o.ordem, g.nome " +
                "FROM apresentacao a " +
                "INNER JOIN ordem o ON a.id = o.id_apresentacao " +
                "INNER JOIN grupo g ON o.id_grupo = g.id " +
                "WHERE a.data_apresentacao = @hoje " +
                "ORDER BY o.ordem ASC;";

            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@hoje", $"{hoje.Year}-{hoje.Month}-{hoje.Day}");

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                apresentacoes.Add(new ApresentacaoModel()
                {
                    Ordem = reader.GetInt32(0),
                    NomeGrupo = reader.GetString(1),
                });
            }

            dataGridViewOrdermApresentacao.DataSource = apresentacoes;
        }

        private int CriarApresentacao()
        {
            var query = "INSERT INTO apresentacao () VALUES ();" +
                "SELECT id FROM apresentacao ORDER BY id DESC LIMIT 1;";

            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var id = reader.Read() ? reader.GetInt32(0) : 0;

            return id;
        }

        private void CriarOrdemApresentacao(int idApresentacao)
        {
            int[] array = [1, 2, 3, 4, 5, 6];
            Random random = new();
            random.Shuffle(array);

            var query = "INSERT INTO ordem (id_apresentacao, id_grupo, ordem) VALUES (@apresentacao, @grupo, @ordem);";

            using var connection = new MySqlConnection(connectionString);
            connection.Open();

            for (int i = 0; i < array.Length; i++)
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue($"@apresentacao", idApresentacao);
                    command.Parameters.AddWithValue($"@grupo", i + 1);
                    command.Parameters.AddWithValue($"@ordem", array[i]);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
