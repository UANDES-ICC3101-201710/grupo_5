using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_POO_Grupo5
{
    class Armas : Cartas
    {
        public int Ataque;
        public int Durabilidad;

        public Armas(string nombre, int costo, int Ataque, int Durabilidad) : base(nombre, costo, Ataque, 0)
        {
            this.Durabilidad = Durabilidad;
            this.Ataque = Ataque;
        }
    }
}
