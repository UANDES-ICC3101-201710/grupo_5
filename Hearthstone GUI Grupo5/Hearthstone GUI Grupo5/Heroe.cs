using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Heroe
    {
        public String Clase;
        public String NombreHeroe;
        public Manager manager;

        public Heroe(String NombreHeroe, String Clase, Manager manager)
        {
            this.Clase = Clase;
            this.NombreHeroe = NombreHeroe;
            this.manager = manager;
        }

        public void Mensaje()
        {
            manager.Aviso("Que mensaje quiere mandar?");
            manager.Aviso("0. Thanks");
            manager.Aviso("1. Well Played");
            manager.Aviso("2. Greetings");
            manager.Aviso("3. Wow");
            manager.Aviso("4. Oops");
            manager.Aviso("5. Threaten");
            int x = manager.RecibirResp();
            if (x == 0)
            {
                manager.Aviso("Thanks");
            }
            else if (x == 1)
            {
                manager.Aviso("Well Played");
            }
            else if (x == 2)
            {
                manager.Aviso("Greetings");
            }
            else if (x == 3)
            {
                manager.Aviso("Wow");
            }
            else if (x == 4)
            {
                manager.Aviso("Oops");
            }
            else
            {
                manager.Aviso("Threaten");
            }

        }
    }
}
