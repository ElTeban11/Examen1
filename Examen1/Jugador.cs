using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inicializamos el jugador para empezar a jugar a la ruleta.

namespace Examen1
{
    public class Jugador
    {
        public int Dinero { get; set; }

        public Jugador(int DineroInicial)
        {
            Dinero = DineroInicial;
        }
    }
}
