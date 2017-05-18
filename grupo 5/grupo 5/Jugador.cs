using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Hearthstone_POO_Grupo5
{
    class Jugador : IJugar
    {
        public String Nombre;
        public List<Cartas> Mano = new List<Cartas>();
        public Mazo Mazo;
        public List<Cartas> Tablero = new List<Cartas>();
        public Boolean ID;//true para jugador 1 y false para jugador 2.
        public Manager manager;
        public Random rdm = new Random();
        public int Vida = 30;
        public int Mana;
        public int Armor;
        public Heroe Heroe;
        public int VarAuxDmg;
        public bool HabMej;
        public bool UsoHab;

        public Jugador(String Nombre, Mazo Mazo, bool ID, Heroe Heroe, Manager manager)
        {
            this.Nombre = Nombre;
            this.Mazo = Mazo;
            this.ID = ID;
            this.Heroe = Heroe;
            this.manager = manager;
        }

        public void BajarCarta(int z)  //pasarle la carta a bajar
        {
            if (Mano[z].Costo > Mana)
            {
                manager.Aviso("No tienes suficiente mana para bajar esa carta.");
            }
            else
            {
                if (Mano[z].Nombre == "The Coin")
                {
                    Mana += 1;
                    Mano.RemoveAt(z);
                }
                else
                {
                    Mano[z].Memoria = 0;
                    Tablero.Add(Mano[z]);                    
                    Mano.RemoveAt(z);
                }

            }

           
        }

        public void RevMano()
        {
            if (Mano.Count > 10)
            {
                Mano.RemoveAt(10);
            }
        }

        public void CambiarCarta(int z)//pasarle la carta a cambiar
        {
            //Mostrar cartas a elegir.
            Mazo.miMazo.Add(Mano[z]);
            Mazo.miMazo.Shuffle();
            Mano.RemoveAt(z);
            Mano.Insert(z ,Mazo.miMazo[0]);
            Mazo.miMazo.RemoveAt(0);
        }

        public void Conceder()
        {
        }

        public void RobarCarta()
        {
            if (Mazo.miMazo.Count == 0)
            {
                Fatiga();
                manager.Aviso("Fatiga, no le quedan cartas para robar. Su vida se reduce en: " + Mazo.FatigaCount);
            }
            else
            {
                Mano.Add(Mazo.miMazo[0]);
                Mazo.miMazo.RemoveAt(0);
            }

        }

        public Cartas UsarCarta(int z)
        {
            return Mano[z];
        }

        public void UsarHabilidad()
        {
            if (Mana < 2)
            {
                manager.Aviso("No tiene suficiente maná: " + Mana);
            }
            else if(UsoHab == true)
            {
                manager.Aviso("Ya utilizó la habilidad este turno.");
            }
            else
            {
                Mana -= 2; // agregar opcion para que el coste de mana sea 
                UsoHab = true;
                if (Heroe.Clase == "Hunter" && HabMej == true)
                {
                    VarAuxDmg = 3;
                }
                else if (Heroe.Clase == "Hunter" && HabMej == false)
                {
                    VarAuxDmg = 2;
                }
                else if (Heroe.Clase == "Warrior" && HabMej == true)
                {
                    Armor += 3;
                }
                else if (Heroe.Clase == "Warrior" && HabMej == false)
                {
                    Armor += 2;
                }
            }

        }

        public void Fatiga()
        {
            Vida = Vida - Mazo.Fatiga();
        }

        public void FinTurno()
        {
            throw new NotImplementedException();
        }
    }
}
