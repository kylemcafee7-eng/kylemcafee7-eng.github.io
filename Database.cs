using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

public static class Database
{
    private static string connString = "Server=localhost;Database=collectors_curator;Uid=root;Pwd=;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connString);
    }
}
