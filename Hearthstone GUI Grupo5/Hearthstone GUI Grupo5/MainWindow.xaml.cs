﻿using System;
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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hearthstone_GUI_Grupo5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tablero Tablerini;
        int resp1;
        int resp2;
        int resp3;
        int resp4;
        int resp5;
        int resp6;
        int resp7;
        int resp8;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CambioImagenes(Heroe ally, Heroe enemy, String Ally, String Enemy)
        {
            //Hide();
            // CAMBIAMOS LA IMAGEN ALIADA
            NombreAliado.Content = Ally;
            NombreEnemigo.Content = Enemy;
            if (ally.NombreHeroe == "Rexxar")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Rexxar.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HRexxar.png"));
            }
            else if (ally.NombreHeroe == "Uther")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Uther.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HUther.png"));
            }
            else if (ally.NombreHeroe == "Valeera")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Valeera.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HValeera.png"));
            }
            else if (ally.NombreHeroe == "Anduin")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Anduin.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HAnduin.png"));
            }
            else if (ally.NombreHeroe == "Thrall")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Thrall.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HThrall.png"));
            }
            else if (ally.NombreHeroe == "Malfurion")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Malfurion.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HMalfurion.png"));
            }
            else if (ally.NombreHeroe == "Guldan")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Guldan.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HGuldan.png"));
            }
            else if (ally.NombreHeroe == "Garrosh")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Garrosh.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HGarrosh.png"));
            }
            else if (ally.NombreHeroe == "Jaina")
            {
                HabilidadAliado.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/Jaina.png")));
                HeroeAli.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadAliado), "Imagenes/HJaina.png"));
            }
            // CAMBIAMOS LA IMAGEN DEL ENEMIGO
            if (enemy.NombreHeroe == "Rexxar")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Rexxar.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HRexxar.png"));
            }
            else if (enemy.NombreHeroe == "Uther")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Uther.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HUther.png"));
            }
            else if (enemy.NombreHeroe == "Valeera")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Valeera.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HValeera.png"));
            }
            else if (enemy.NombreHeroe == "Anduin")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Anduin.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HAnduin.png"));
            }
            else if (enemy.NombreHeroe == "Thrall")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Thrall.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HThrall.png"));
            }
            else if (enemy.NombreHeroe == "Malfurion")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Malfurion.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HMalfurion.png"));
            }
            else if (enemy.NombreHeroe == "Guldan")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Guldan.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HGuldan.png"));
            }
            else if (enemy.NombreHeroe == "Garrosh")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Garrosh.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HGarrosh.png"));
            }
            else if (enemy.NombreHeroe == "Jaina")
            {
                HabilidadEnemigo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/Jaina.png")));
                HeroeEne.Source = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(HabilidadEnemigo), "Imagenes/HJaina.png"));
            }
            Inicio.Content = "";
            Inicio.Background = Brushes.Transparent;
            Inicio.Foreground = Brushes.Transparent;
            Inicio.BorderBrush = Brushes.Transparent;
            Inicio.IsEnabled = false;
            Inicio.Visibility = Visibility.Hidden;
            //ShowDialog();

        }

        private void HabilidadAliado_Click(object sender, RoutedEventArgs e)
        {
            //Tablerini.UsarHabilidad(Tablerini.J1);
        }

        private static void Save(Tablero tablero)
        {

            string fileName1 = "Savedgame/tablero.txt";
            // Creamos el Stream donde guardaremos nuestro juego

            FileStream fs_tablero = new FileStream(fileName1, FileMode.CreateNew);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs_tablero, tablero);
            fs_tablero.Close();

        }
        private static Tablero Load()//revisar cuantos metodos se deben hacer
        {
            string fileName1 = "Savedgame/tablero.txt";
            // Creamos el Stream donde se encuentra nuestro juego
            FileStream fs_tablero = new FileStream(fileName1, FileMode.CreateNew);
            IFormatter formatter = new BinaryFormatter();
            Tablero tablero = formatter.Deserialize(fs_tablero) as Tablero;
            fs_tablero.Close();
            return tablero;
        }

        private void InicioJuego(object sender, RoutedEventArgs e)
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
            Heroe R = new Heroe("Valeera", "Rogue", m);
            Heroe P = new Heroe("Uther", "Paladin", m);
            Heroe Pr = new Heroe("Anduin", "Priest", m);
            Heroe S = new Heroe("Thrall", "Shaman", m);
            Heroe Wk = new Heroe("Guldan", "Warlock", m);
            Heroe D = new Heroe("Malfurion", "Druid", m);
            Heroe M = new Heroe("Jaina", "Mage", m);

            MenuHeroes popup = new MenuHeroes(0);
            MenuHeroes popup1 = new MenuHeroes(1);
            popup.ShowDialog();
            popup1.ShowDialog();

            String z = popup.Nombre;
            int z1 = popup.Heroe;
            String z2 = popup1.Nombre;
            int z3 = popup1.Heroe;
            InitializeComponent();

            if (z1 == 1)
            {
                J1 = new Jugador(z, P1, true, W, m);
            }
            else if (z1 == 2)
            {
                J1 = new Jugador(z, P1, true, S, m);
            }
            else if (z1 == 3)
            {
                J1 = new Jugador(z, P1, true, R, m);
            }
            else if (z1 == 4)
            {
                J1 = new Jugador(z, P1, true, P, m);
            }
            else if (z1 == 5)
            {
                J1 = new Jugador(z, P1, true, H, m);
            }
            else if (z1 == 6)
            {
                J1 = new Jugador(z, P1, true, D, m);
            }
            else if (z1 == 7)
            {
                J1 = new Jugador(z, P1, true, Wk, m);
            }
            else if (z1 == 8)
            {
                J1 = new Jugador(z, P1, true, M, m);
            }
            else
            {
                J1 = new Jugador(z, P1, true, Pr, m);
            }
            if (z3 == 1)
            {
                J2 = new Jugador(z2, P2, false, W, m);
            }
            else if (z3 == 2)
            {
                J2 = new Jugador(z2, P2, false, S, m);
            }
            else if (z3 == 3)
            {
                J2 = new Jugador(z2, P2, false, R, m);
            }
            else if (z3 == 4)
            {
                J2 = new Jugador(z2, P2, false, P, m);
            }
            else if (z3 == 5)
            {
                J2 = new Jugador(z2, P2, false, H, m);
            }
            else if (z3 == 6)
            {
                J2 = new Jugador(z2, P2, false, D, m);
            }
            else if (z3 == 7)
            {
                J2 = new Jugador(z2, P2, false, Wk, m);
            }
            else if (z3 == 8)
            {
                J2 = new Jugador(z2, P2, false, M, m);
            }
            else
            {
                J2 = new Jugador(z2, P2, false, Pr, m);
            }


            Tablero Tab = new Tablero(J1, J2, m);
            Tablerini = Tab;
            Tablerini.Partir();
            if (Tablerini.J1Jugando == true)
            {
                CambioCartas pop = new CambioCartas(J1);
                CambioCartas pop1 = new CambioCartas(J2);
                pop.ShowDialog();
                pop1.ShowDialog();
                resp1 = pop.i1;
                resp2 = pop.i2;
                resp3 = pop.i3;
                resp4 = pop1.i1;
                resp5 = pop1.i2;
                resp6 = pop1.i3;
                resp7 = pop1.i4;
                Tablerini.CambioCartas3(J1, resp1, resp2, resp3);
                Tablerini.CambioCartas4(J2, resp4, resp5, resp6, resp7);
            } // GG WP
            else
            {
                CambioCartas pop = new CambioCartas(J2);
                CambioCartas pop1 = new CambioCartas(J1);
                pop.ShowDialog();
                pop1.ShowDialog();
                resp1 = pop1.i1;
                resp2 = pop1.i2;
                resp3 = pop1.i3;
                resp4 = pop1.i4;
                resp5 = pop.i1;
                resp6 = pop.i2;
                resp7 = pop.i3;
                Tablerini.CambioCartas3(J2, resp5, resp6, resp7);
                Tablerini.CambioCartas4(J1, resp1, resp2, resp3, resp4);
            }          
            ActGui();
            //CambioImagenes(J1.Heroe, J2.Heroe, J1.Nombre, J2.Nombre);
        }

        // Métodos de actualización de interfaz gráfica.
        private void ActGui()
        {
            Hide();
            if (Tablerini.J1Jugando == true)
            {
                NCartasEnem.Content = Tablerini.J2.Mano.Count + " Cartas en la mano.";
                CambioImagenes(Tablerini.J1.Heroe, Tablerini.J2.Heroe, Tablerini.J1.Nombre, Tablerini.J2.Nombre);
                ActManoAli(Tablerini.J1.Mano);
                ActTabAli(Tablerini.J1.Tablero);
                ActTabEne(Tablerini.J2.Tablero);
                VidaAli.Content = Tablerini.J1.Vida;
                VidaEnem.Content = Tablerini.J2.Vida;
                ManaAli.Content = Tablerini.J1.Mana;

            }
            else
            {
                NCartasEnem.Content = Tablerini.J1.Mano.Count + " Cartas en la mano.";
                CambioImagenes(Tablerini.J2.Heroe, Tablerini.J1.Heroe, Tablerini.J2.Nombre, Tablerini.J1.Nombre);
                ActManoAli(Tablerini.J2.Mano);
                ActTabAli(Tablerini.J2.Tablero);
                ActTabEne(Tablerini.J1.Tablero);
                VidaAli.Content = Tablerini.J2.Vida;
                VidaEnem.Content = Tablerini.J1.Vida;
                ManaAli.Content = Tablerini.J2.Mana;
            }
            ShowDialog();
        }
        private void ActManoAli(List<Cartas> Cartitas)
        {
            for (int i = 0; i < Cartitas.Count; i++)
            {
                if (Cartitas[i].Nombre == "Wisp")
                {
                    String Direccion = "Imagenes/Wisp.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Murloc Raider")
                {
                    String Direccion = "Imagenes/Murlocraider.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Imagenes/Bloodfenraptor.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "River Crocolisk")
                {
                    String Direccion = "Imagenes/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Magma Rager")
                {
                    String Direccion = "Imagenes/Magmarager.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Chillwind Yeti")
                {
                    String Direccion = "Imagenes/Chillwindyeti.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Imagenes/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Imagenes/Boulderfistogre.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "War Golem")
                {
                    String Direccion = "Imagenes/Wargolem.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Core Hound")
                {
                    String Direccion = "Imagenes/Corehound.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Silver hand recruit")
                {
                    String Direccion = "Imagenes/Silverhand.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Healing Totem")
                {
                    String Direccion = "Imagenes/Healingtotem.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Searing Totem")
                {
                    String Direccion = "Imagenes/Searingtotem.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Imagenes/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Imagenes/Airtotem.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Wicked Knife")
                {
                    String Direccion = "Imagenes/Wickedknife.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "Poisoned Dagger")
                {
                    String Direccion = "Imagenes/Poisoneddagger.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }
                else if (Cartitas[i].Nombre == "The Coin")
                {
                    String Direccion = "Imagenes/Thecoin.png";
                    if (i == 0)
                    {
                        CMAli1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        CMAli2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        CMAli3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        CMAli4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        CMAli5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        CMAli6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        CMAli7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli7), Direccion)));
                    }
                    else if (i == 7)
                    {
                        CMAli8.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli8), Direccion)));
                    }
                    else if (i == 8)
                    {
                        CMAli9.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli9), Direccion)));
                    }
                    else
                    {
                        CMAli10.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(CMAli10), Direccion)));
                    }
                }

            }
        }
        private void ActTabAli(List<Cartas> Cartitas)
        {
            for (int i = 0; i < Cartitas.Count; i++)
            {
                if (Cartitas[i].Nombre == "Wisp")
                {
                    String Direccion = "Imagenes/Wisp.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Murloc Raider")
                {
                    String Direccion = "Imagenes/Murlocraider.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Imagenes/Bloodfenraptor.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "River Crocolisk")
                {
                    String Direccion = "Imagenes/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Magma Rager")
                {
                    String Direccion = "Imagenes/Magmarager.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Chillwind Yeti")
                {
                    String Direccion = "Imagenes/Chillwindyeti.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Imagenes/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Imagenes/Boulderfistogre.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "War Golem")
                {
                    String Direccion = "Imagenes/Wargolem.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Core Hound")
                {
                    String Direccion = "Imagenes/Corehound.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Silver hand recruit")
                {
                    String Direccion = "Imagenes/Silverhand.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Healing Totem")
                {
                    String Direccion = "Imagenes/Healingtotem.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Searing Totem")
                {
                    String Direccion = "Imagenes/Searingtotem.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Imagenes/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Imagenes/Airtotem.png";
                    if (i == 0)
                    {
                        TA1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TA2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TA3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TA4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TA5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TA6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TA7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TA7), Direccion)));
                    }

                }

            }
        }
        private void ActTabEne(List<Cartas> Cartitas)
        {
            for (int i = 0; i < Cartitas.Count; i++)
            {
                if (Cartitas[i].Nombre == "Wisp")
                {
                    String Direccion = "Imagenes/Wisp.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Murloc Raider")
                {
                    String Direccion = "Imagenes/Murlocraider.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Bloodfen Raptor")
                {
                    String Direccion = "Imagenes/Bloodfenraptor.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "River Crocolisk")
                {
                    String Direccion = "Imagenes/Rivercrocolisk.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Magma Rager")
                {
                    String Direccion = "Imagenes/Magmarager.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Chillwind Yeti")
                {
                    String Direccion = "Imagenes/Chillwindyeti.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Oasis Snapjaw")
                {
                    String Direccion = "Imagenes/Oasissnapjaw.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Boulderfist Ogre")
                {
                    String Direccion = "Imagenes/Boulderfistogre.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "War Golem")
                {
                    String Direccion = "Imagenes/Wargolem.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Core Hound")
                {
                    String Direccion = "Imagenes/Corehound.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Silver hand recruit")
                {
                    String Direccion = "Imagenes/Silverhand.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Healing Totem")
                {
                    String Direccion = "Imagenes/Healingtotem.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Searing Totem")
                {
                    String Direccion = "Imagenes/Searingtotem.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Stoneclaw Totem")
                {
                    String Direccion = "Imagenes/Stoneclawtotem.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }
                else if (Cartitas[i].Nombre == "Wraith Of Air Totem")
                {
                    String Direccion = "Imagenes/Airtotem.png";
                    if (i == 0)
                    {
                        TE1.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE1), Direccion)));
                    }
                    else if (i == 1)
                    {
                        TE2.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE2), Direccion)));
                    }
                    else if (i == 2)
                    {
                        TE3.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE3), Direccion)));
                    }
                    else if (i == 3)
                    {
                        TE4.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE4), Direccion)));
                    }
                    else if (i == 4)
                    {
                        TE5.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE5), Direccion)));
                    }
                    else if (i == 5)
                    {
                        TE6.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE6), Direccion)));
                    }
                    else if (i == 6)
                    {
                        TE7.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(TE7), Direccion)));
                    }

                }

            }
        }

        private void Cambiocartas()
        {

            Cambiarcartas.Visibility = Visibility.Visible;
            Nocambiar.Visibility = Visibility.Visible;
            Nocambiar.IsEnabled = true;
            Sicambiar.Visibility = Visibility.Visible;
            Sicambiar.IsEnabled = true;
        }
        private void Nocambiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sicambiar_Click(object sender, RoutedEventArgs e)
        {
            CartaCambio1.Visibility = Visibility.Visible;
            CartaCambio1.IsEnabled = true;
            CartaCambio2.Visibility = Visibility.Visible;
            CartaCambio2.IsEnabled = true;
            CartaCambio3.Visibility = Visibility.Visible;
            CartaCambio3.IsEnabled = true;
            CartaCambio4.Visibility = Visibility.Visible;
            CartaCambio4.IsEnabled = true;
            Nocambiar.Visibility = Visibility.Hidden;
            Nocambiar.IsEnabled = false;
            Cambiarcartas.Content = "Haga click sobre las cartas que desea cambiar.";
        }

        private void CambioClick(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            if (Tablerini.J1Jugando == true)
            {
                if (boton.Name == "CartaCambio1")
                {
                    resp1 = 1;
                }
                else if (boton.Name == "CartaCambio2")
                {
                    resp2 = 1;
                }
                else if (boton.Name == "CartaCambio3")
                {
                    resp3 = 1;
                }
                else
                {
                    resp4 = 1;
                }
            }
            else
            {
                if (boton.Name == "CartaCambio1")
                {
                    resp5 = 1;
                }
                else if (boton.Name == "CartaCambio2")
                {
                    resp6 = 1;
                }
                else if (boton.Name == "CartaCambio3")
                {
                    resp7 = 1;
                }
                else
                {
                    resp8 = 1;
                }
            }            
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
