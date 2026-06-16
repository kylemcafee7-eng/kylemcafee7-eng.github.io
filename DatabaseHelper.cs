using MySql.Data.MySqlClient;
using System.Data;

public static class DatabaseHelper
{
    private static string connectionString = "Server=localhost;Database=collectors_curator;Uid=root;Pwd=;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public static DataTable GetInventoryItems()
    {
        DataTable table = new DataTable();

        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = @"SELECT 
                                item_id,
                                name,
                                item_type,
                                game_name,
                                set_name,
                                rarity,
                                `condition`,
                                quantity,
                                cost,
                                market_value,
                                vendor,
                                image_path,
                                date_added,
                                eoq,
                                rop,
                                itr
                            FROM inventory_items;";


            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
        }

        return table;
    }
}
