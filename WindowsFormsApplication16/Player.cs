using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication16
{
    public class Player
    {
        string nombre;
        int kills;
        int tiempo;

        public Player(string pNombre, int pKills, int pTiempo)
        {
            nombre = pNombre;
            kills = pKills;
            tiempo = pTiempo;
        }

        public string Nombre
        {
            get => nombre;
            
            set => nombre = value;
         
        }

        public int Kills
        {
            get => kills;
            
            set => kills = value;
            
        }

        public int Tiempo
        {
            get => tiempo;

            set => tiempo = value;
        }


    }
}
