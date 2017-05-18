using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_POO_Grupo5
{
    class Manager {

        public Manager()
        {

        }

    public void Aviso(String txt)//Da el aviso a consola.
        {
            Console.WriteLine(txt);
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
