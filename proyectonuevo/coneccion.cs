using MySql.Data.MySqlClient;
using system;
using System.Data;
using System.Data.MySqlClient;


namespace MySqlCon{

      string connectionString = "Server=LocalHost;Database=proyecto_c;Uid=root;";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM empleado";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Procesar resultados
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }
        }
}