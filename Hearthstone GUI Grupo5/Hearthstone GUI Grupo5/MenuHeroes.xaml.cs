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
using System.Windows.Shapes;

namespace Hearthstone_GUI_Grupo5
{
    /// <summary>
    /// Interaction logic for MenuHeroes.xaml
    /// </summary>
    public partial class MenuHeroes : Window
    {
        public int Heroe = 0;
        public String Nombre = "";
        public int j1;
        public MenuHeroes(int j1)
        {
            this.j1 = j1;
            InitializeComponent();
            if (j1 == 0)
            {
                tbp.Content = "Player 1";
            }
            else
            {
                tbp.Content = "Player 2";
            }
        }

        private void ClickHeroe(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == "Warrior")
            {
                Heroe = 1;
            }
            else if (b.Name == "Shaman")
            {
                Heroe = 2;
            }
            else if (b.Name == "Rogue")
            {
                Heroe = 3;
            }
            else if (b.Name == "Paladin")
            {
                Heroe = 4;
            }
            else if (b.Name == "Hunter")
            {
                Heroe = 5;
            }
            else if (b.Name == "Druid")
            {
                Heroe = 6;
            }
            else if (b.Name == "Warlock")
            {
                Heroe = 7;
            }
            else if (b.Name == "Mage")
            {
                Heroe = 8;
            }
            else
            {
                Heroe = 9;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Nombre = tb.Text;
        }

        private void Listo(object sender, RoutedEventArgs e)
        {
            if ((Heroe != 0) && (Nombre != ""))
            {
                Close();
            }
            else
            {

            }
        }
    }
}
