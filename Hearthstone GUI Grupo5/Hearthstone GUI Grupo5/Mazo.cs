using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Mazo
    {
        public String NombreMazo;
        public List<Cartas> miMazo;
        public int FatigaCount;

        public Mazo(List<Cartas> miMazo, String NombreMazo)
        {
            this.miMazo = miMazo;
            this.NombreMazo = NombreMazo;
        }

        public int Fatiga()
        {
            FatigaCount += 1;
            return FatigaCount;
        }

    }

}
