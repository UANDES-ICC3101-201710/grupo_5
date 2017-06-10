using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Threading;

namespace Hearthstone_GUI_Grupo5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Minions x1 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x2 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x3 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x4 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x5 = new Minions("Magma Rager", 3, 1, 5);
            Minions x6 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x7 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x8 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x9 = new Minions("War Golem", 7, 7, 7);
            Minions x10 = new Minions("Core Hound", 7, 5, 9);
            Minions x11 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x12 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x13 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x14 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x15 = new Minions("Magma Rager", 3, 1, 5);
            Minions x16 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x17 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x18 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x19 = new Minions("War Golem", 7, 7, 7);
            Minions x20 = new Minions("Core Hound", 7, 5, 9);
            Minions x21 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x22 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x23 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x24 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x25 = new Minions("Magma Rager", 3, 1, 5);
            Minions x26 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x27 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x28 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x29 = new Minions("War Golem", 7, 7, 7);
            Minions x30 = new Minions("Core Hound", 7, 5, 9);
            Minions x31 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x32 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x33 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x34 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x35 = new Minions("Magma Rager", 3, 1, 5);
            Minions x36 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x37 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x38 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x39 = new Minions("War Golem", 7, 7, 7);
            Minions x40 = new Minions("Core Hound", 7, 5, 9);
            Minions x41 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x42 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x43 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x44 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x45 = new Minions("Magma Rager", 3, 1, 5);
            Minions x46 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x47 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x48 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x49 = new Minions("War Golem", 7, 7, 7);
            Minions x50 = new Minions("Core Hound", 7, 5, 9);
            Minions x51 = new Minions("Wisp", 0, 1, 1);//nombre, costo, vida, ataque
            Minions x52 = new Minions("Murloc Raider", 1, 1, 2);
            Minions x53 = new Minions("Bloodfen Raptor", 2, 2, 3);
            Minions x54 = new Minions("River Crocolisk", 2, 3, 2);
            Minions x55 = new Minions("Magma Rager", 3, 1, 5);
            Minions x56 = new Minions("Chillwind Yeti", 4, 5, 4);
            Minions x57 = new Minions("Oasis Snapjaw", 4, 7, 2);
            Minions x58 = new Minions("Boulderfist Ogre", 6, 7, 6);
            Minions x59 = new Minions("War Golem", 7, 7, 7);
            Minions x60 = new Minions("Core Hound", 7, 5, 9);
            Jugador J1;
            Jugador J2;
            List<Cartas> Mazo1 = new List<Cartas> { x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30 };
            List<Cartas> Mazo2 = new List<Cartas> { x31, x32, x33, x34, x35, x36, x37, x38, x39, x40, x41, x42, x43, x44, x45, x46, x47, x48, x49, x50, x51, x52, x53, x54, x55, x56, x57, x58, x59, x60 };
            Mazo1.Shuffle();
            Mazo2.Shuffle();
            Mazo P1 = new Mazo(Mazo1, "Mazito");
            Mazo P2 = new Mazo(Mazo2, "Mazin");
            Manager m = new Manager();
            Heroe H = new Heroe("Rexxar", "Hunter", m);
            Heroe W = new Heroe("Garrosh", "Warrior", m);
            
            MenuHeroes popup = new MenuHeroes(0);
            MenuHeroes popup1 = new MenuHeroes(1);
            popup.ShowDialog();
            popup1.ShowDialog();

            String z = popup.Nombre;
            int z1 = popup.Heroe;
            String z2 = popup1.Nombre;
            int z3 = popup1.Heroe;
            /*            m.Aviso("Jugador 1, ingrese su nombre.");
                        String z = m.RecibirNomb();
                        m.Aviso("Jugador 1, ingrese su heroe. 1 = Hunter, 2 = Warrior");
                        int z1 = m.RecibirResp();
                        m.Aviso("Jugador 2, ingrese su nombre.");
                        String z2 = m.RecibirNomb();
                        m.Aviso("Jugador 2, ingrese su heroe. 1 = Hunter, 2 = Warrior");
                        int z3 = m.RecibirResp();*/
            if (z1 == 1)
            {
                J1 = new Jugador(z, P1, true, H, m);
            }
            else
            {
                J1 = new Jugador(z, P1, true, W, m);
            }
            if (z3 == 1)
            {
                J2 = new Jugador(z2, P2, false, H, m);
            }
            else
            {
                J2 = new Jugador(z2, P2, false, W, m);
            }
            Tablero Tab = new Tablero(J1, J2, m);
            CambioHabilidad(J1.Heroe, J2.Heroe);
            //InitializeComponent();
            //Tab.Partir();


        }
        private void CambioHabilidad(Heroe ally, Heroe enemy)
        {
            if (ally.NombreHeroe == "Rexxar")
            {
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(@"imagenes/Rexxar.png"));
                HabilidadAliado.Background = brush;
            }
        }

        private void HabilidadAliado_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
