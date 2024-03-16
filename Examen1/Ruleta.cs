using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


public enum Color //Lo deje afuera pq me daba error cuandoe staba dentro de la class ruleta
{
    Rojo,
    Negro,
    SinColor,
}

namespace Examen1
{
    public class Ruleta
    {
      

        private static Random random = new Random();

        public int Girar()
        {
            return random.Next(0, 37); //Ponemos 37 para que el 36 entre en de la pool

        }
        
        public Color obtenerColor(int num)
        {
            if (num == 0) 
            {
                return Color.SinColor; //El 0 es el unico sin color como especifica en los requerimentos.
            }
            
            else if (num % 2 == 0) 
            {
                return Color.Negro;
            }

            else
            {
                return Color.Rojo;
            }

        }

    }
}
