using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WindowsFormsApplication16
{

    public static class Sqlite
    {
        private static SQLiteConnection con = new SQLiteConnection(@"Data Source=.\Resources\Basededatos.db;Version=3;");

        public static List<Player> obtenerPlayers()
        {
            List<Player> players = new List<Player>();
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM PLAYERS";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                players.Add(new Player(reader["Nombre"].ToString(), Convert.ToInt32(reader["Kills"]), Convert.ToInt32(reader["Time"])));
            }

            return players;
        }

        public static void agregarPlayers(Player p)
        {
            List<Player> players = new List<Player>();
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO PLAYERS(NOMBRE, KILLS, TIME) VALUES (" + p.Nombre + "," + p.Kills + "," + p.Tiempo + ")";
            cmd.ExecuteNonQuery();

        }

        public static void cerrarConexion()
        {
            con.Close();
        }
    }
}
