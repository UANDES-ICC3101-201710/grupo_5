using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    abstract class Cartas
    {
        public String Nombre;
        public int Costo;
        public int Vida;
        public int Ataque;
        public int Memoria;


        public Cartas(string nombre, int costo, int Vida, int Ataque)
        {
            this.Nombre = nombre;
            this.Costo = costo;
            this.Vida = Vida;
            this.Ataque = Ataque;
        }

        public void AplicarEfecto()
        {

        }
    }
    //de tener efectos crear interfaz efectos donde se contienen todos los efectos y se le dan a las cartas que correspondan
   
}
