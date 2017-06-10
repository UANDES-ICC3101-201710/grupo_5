using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    interface IJugar
    {
        void RobarCarta();
        void BajarCarta(int z);
        void CambiarCarta(int z);
        Cartas UsarCarta(int z);
        void UsarHabilidad();
        void FinTurno();
        void Conceder();
    }
}
