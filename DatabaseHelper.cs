using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
public class DatabaseHelper
{
    // Update these credentials to match your local setup
    private string connString = "server=localhost;database=ProfileDB;uid=root;pwd=";

    public DataTable GetProfiles()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            string query = "SELECT * FROM Users";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public void ExecuteQuery(string query, MySqlParameter[] parameters)
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
