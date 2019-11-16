using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication16
{
    public class Player
    {
        int id;
        string nombre;
        string fecha;
        int kills;
        int tiempo;


      public Player(int pId, string pNombre,  int pKills, int pTiempo, string pFecha)
       // public Player(int pId, string pNombre, int pKills, int pTiempo)

        {
            id = pId;
            fecha = pFecha;
            nombre = pNombre;
            kills = pKills;
            tiempo = pTiempo;
        }


        public int  Id
        {
            get => id;

            set => id = value;

        }

        public string Fecha
        {
            get => fecha;

            set
            {
                fecha = value;
            }
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
