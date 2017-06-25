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

namespace Hearthstone_GUI_Grupo5
{
    /// <summary>
    /// Interaction logic for CambioCartas.xaml
    /// </summary>
    public partial class CambioCartas : Window
    {
        public int i1 = 0;
        public int i2 = 0;
        public int i3 = 0;
        public int i4 = 0;
        Jugador jeque;
        public CambioCartas(object jugador)
        {
            Jugador gamer = (Jugador)jugador;
            jeque = gamer;
            InitializeComponent();
            Nombre.Content = jeque.Nombre + " Cambia Cartas";
            List<Cartas> Cartitas = jeque.Mano;
            if (Cartitas.Count < 4)
            {
                Carta4.Visibility = Visibility.Hidden;
                Carta4.IsEnabled = false;
                Cart4.Visibility = Visibility.Hidden;
                Cart4.IsEnabled = false;
            }
            for (int i = 0; i < Cartitas.Count; i++)
            {
                if (Cartitas[i].Nombre == "Wisp")
                {
                    String Direccion = "Imagenes/Wisp.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Murloc Raider")
                {
                    String Direccion = "Imagenes/Murlocraider.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }


                }
                else if (Cartitas[i].Nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Imagenes/BloodfenRaptor.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }


                }
                else if (Cartitas[i].Nombre == "River Crocolisk")
                {
                    String Direccion = "Imagenes/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Magma Rager")
                {
                    String Direccion = "Imagenes/Magmarager.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Chillwind Yeti")
                {
                    String Direccion = "Imagenes/Chillwindyeti.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Imagenes/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Imagenes/Boulderfistogre.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "War Golem")
                {
                    String Direccion = "Imagenes/Wargolem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Core Hound")
                {
                    String Direccion = "Imagenes/Corehound.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Silver hand recruit")
                {
                    String Direccion = "Imagenes/Silverhand.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Healing Totem")
                {
                    String Direccion = "Imagenes/Healingtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Searing Totem")
                {
                    String Direccion = "Imagenes/Searingtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Imagenes/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Imagenes/Airtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }

            }
        }

        /*private void CambioCarta(Jugador J)
        {
            Nombre.Content = J.Nombre + "Cambia Cartas";
            List<Cartas> Cartitas = J.Mano;
            if (Cartitas.Count < 4)
            {
                Carta4.Visibility = Visibility.Hidden;
                Carta4.IsEnabled = false;               
            }
            for (int i = 0; i < Cartitas.Count; i++)
            {
                if (Cartitas[i].Nombre == "Wisp")
                {
                    String Direccion = "Imagenes/Wisp.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Murloc Raider")
                {
                    String Direccion = "Imagenes/Murlocraider.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }


                }
                else if (Cartitas[i].Nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Imagenes/Bloodfen Raptor.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }


                }
                else if (Cartitas[i].Nombre == "River Crocolisk")
                {
                    String Direccion = "Imagenes/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Magma Rager")
                {
                    String Direccion = "Imagenes/Magmarager.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Chillwind Yeti")
                {
                    String Direccion = "Imagenes/Chillwindyeti.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Imagenes/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Imagenes/Boulderfistogre.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "War Golem")
                {
                    String Direccion = "Imagenes/Wargolem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Core Hound")
                {
                    String Direccion = "Imagenes/Corehound.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Silver hand recruit")
                {
                    String Direccion = "Imagenes/Silverhand.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Healing Totem")
                {
                    String Direccion = "Imagenes/Healingtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Searing Totem")
                {
                    String Direccion = "Imagenes/Searingtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Imagenes/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Imagenes/Airtotem.png";
                    if (i == 0)
                    {
                        Carta1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        Carta2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        Carta3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        Carta4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(Carta4), Direccion)));
                    }

                }

            }
        }*/

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox a = (CheckBox)sender;
            if (a.Name == "Cart1")
            {
                i1 = 1;
            }
            else if (a.Name == "Cart2")
            {
                i2 = 1;
            }
            else if (a.Name == "Cart3")
            {
                i3 = 1;
            }
            else if (a.Name == "Cart4")
            {
                i4 = 1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
