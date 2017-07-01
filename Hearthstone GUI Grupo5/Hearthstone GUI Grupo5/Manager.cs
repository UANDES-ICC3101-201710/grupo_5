using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Manager {
        public string Aviso1;
        public Manager()
        {

        }

    public void Aviso(String txt)//Da el aviso a consola.
        {
            Aviso1 = txt;
        }
    public int RecibirResp()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    public String RecibirNomb()
        {
            return Console.ReadLine();
        }
    }
}
