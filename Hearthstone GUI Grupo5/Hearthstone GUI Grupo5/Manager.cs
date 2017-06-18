using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    class Manager {
        //Para la entrega 3 esta clase esta obsoleta, sigue en el programa,
        //ya que en la transicion muchos metodos ocupan esta clase,
        //y se esperara a terminar le programa anres de eliminar esta clase
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
