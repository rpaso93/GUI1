using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WindowsFormsApplication16
{

    public static class Sqlite
    {    /// <summary>
         /// QUEDO PENDIENTE RESOLVER QUE HACER CON LOS PERMISOS DE WINDOWS PARA QUE NO SEA OBLIGATORIO DEJAR LA BASE EN ESCRITORIO
         /// </summary>
        private static SQLiteConnection con = new SQLiteConnection(@"Data Source=D:\Proyecto\GUI1\WindowsFormsApplication16\Base de Datos\nuevabase.db3;Version=3;"); /// cambiar ubicacion para que funcione
        //private static SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\dimas\Desktop\nuevabase.db3;Version=3;"); /// cambiar ubicacion para que funcione

        public static List<Player> obtenerPlayers()
        {
            List<Player> players = new List<Player>();
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "SELECT * FROM PLAYERS order by kills desc";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                players.Add(new Player(Convert.ToInt32(reader["Id"]),reader["Nombre"].ToString(), Convert.ToInt32(reader["Kills"]), Convert.ToInt32(reader["Tiempo"]),reader["Fecha"].ToString()));
            }
            con.Close();
            return players;
        }

        public static void agregarPlayers(Player p)
        {
            List<Player> players = new List<Player>();
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);
            try{             
                cmd.CommandText = "INSERT INTO PLAYERS(FECHA,NOMBRE, KILLS, TIEMPO) VALUES ('" + p.Fecha + "','" + p.Nombre + "'," + p.Kills + "," + p.Tiempo + ")";
                cmd.ExecuteNonQuery();
                con.Close();            
               } catch(Exception ex)
            {
                throw(new Exception(ex.Message)); 
            }
        }

     
    }
}
