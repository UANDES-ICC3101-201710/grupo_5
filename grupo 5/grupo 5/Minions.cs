using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_POO_Grupo5
{
    class Minions : Cartas
    {
        public int Vida;
        public int Ataque;
        public Boolean Estado;
        public int Memoria;

        public Minions(string nombre, int costo, int Vida, int Ataque) : base(nombre, costo, Vida, Ataque)
        {
            this.Vida = Vida;
            this.Ataque = Ataque;
        }
    }
}
