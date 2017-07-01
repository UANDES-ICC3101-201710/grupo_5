using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Hechizos : Cartas
    {
        public Hechizos(string nombre, int costo) : base(nombre, costo, 0, 0)
        {
        }
    }
}
