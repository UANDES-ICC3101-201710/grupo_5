using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Jugador : IJugar, INotifyPropertyChanged
    {
        public String Nombre;
        public List<Cartas> Mano = new List<Cartas>();
        public Mazo Mazo;
        public List<Cartas> Tablero = new List<Cartas>();
        public Boolean ID;//true para jugador 1 y false para jugador 2.
        public Manager manager;
        public Random rdm = new Random();
        private int vida = 30;
        public int ManaOrig;
        public int Mana;
        public int Armor;
        public Heroe Heroe;
        public int VarAuxDmg = 0; //VarAuxDmg, HabMej y UsoHab son  variables auxiliares que se ocupan para implementar la habilidad de heroes
        public bool HabMej;
        public bool UsoHab;
        public Armas Arma = new Armas("nada", 0, 0, 0);
        public int Daño = 0;
        public int totem0count = 0;
        public int totem1count = 0;
        public int totem2count = 0;
        public int totem3count = 0;

        //Lista que guarda los silver hand warriors que crea la habilidad del paladin
        public List<Minions> SilverHand = new List<Minions>();
        //Lista que guarda los totems que crea la habilidad del shaman
        public List<Minions> Totems = new List<Minions>();
        //Creacion de totems para poder ingresarlos a la lista totems
        //Los efectos de los totems no estan implementados
        Minions totem1 = new Minions("Healing Totem", 1, 2, 0);//Al final de el turno del jugador da 1 de vida al resto de los minions del tablero del jugador.
        Minions totem2 = new Minions("Searing Totem", 1, 1, 1);
        Minions totem3 = new Minions("Stoneclaw Totem", 1, 2, 0);// Posee Taunt, habilidad que obliga a los minions enemigos a destruir este minion u otro que posea taunt antes de atacar al resto.
        Minions totem4 = new Minions("Wraith Of Air Totem", 1, 2, 0);// Otorga al jugador +1 spelldamage mientras este totem este vivo.

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
                //manager.Aviso("No tienes suficiente mana para bajar esa carta.");
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
                    if (Mano[z].GetType() == typeof(Minions))
                        {
                        Mana -= Mano[z].Costo;
                        Mano[z].Memoria = 0;
                        Tablero.Add((Minions)(Mano[z]));
                        Mano.RemoveAt(z);
                        }
                    else
                    {
                        //manager.Aviso("La carta que quiere bajar no es un minion.");
                    }

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

        public void CambiarCarta(int z)//pasarle la carta a cambiar, y re barajar el mazo
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

        public void RobarCarta() //Ejecuta el robar carta
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

        public void UsarHabilidad() //implementa todas las habilidades de heroe
        {
            if (Mana < 2)
            {
                manager.Aviso("No tiene suficiente maná: " + Mana);
            }
            else if (UsoHab == true)
            {
                manager.Aviso("Ya utilizó la habilidad este turno.");
            }
            else
            {
                Mana -= 2; 
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
                else if (Heroe.Clase == "Paladin" && HabMej == true)
                {
                    Minions s1 = new Minions("Silver hand recruit", 1, 1, 1);
                    Minions s2 = new Minions("Silver hand recruit", 1, 1, 1);
                    Tablero.Add(s1);
                    Tablero.Add(s2);
                }
                else if (Heroe.Clase == "Paladin" && HabMej == false)
                {
                    Minions silver1 = new Minions("Silver hand recruit", 1, 1, 1);
                    Tablero.Add(silver1);
                }
                else if (Heroe.Clase == "Warlock" && HabMej == true)
                {
                    RobarCarta();
                }
                else if (Heroe.Clase == "Warlock" && HabMej == false)
                {
                    RobarCarta();
                    vida -= 2;
                }
                else if (Heroe.Clase == "Mage" && HabMej == true)
                {
                    VarAuxDmg = 2;
                }
                else if (Heroe.Clase == "Mage" && HabMej == false)
                {
                    VarAuxDmg = 1;
                }
                else if (Heroe.Clase == "Priest" && HabMej == true)
                {
                    VarAuxDmg = 2;
                }
                else if (Heroe.Clase == "Priest" && HabMej == false)
                {
                    VarAuxDmg = 4;
                }
                else if (Heroe.Clase == "Druid" && HabMej == true)
                {
                    Armor += 2;
                    Daño = 2;
                }
                else if (Heroe.Clase == "Druid" && HabMej == false)
                {
                    Armor += 1;
                    Daño = 1;
                }
                else if (Heroe.Clase == "Rogue" && HabMej == true) // Generamos un arma 2/2 y la equipamos
                {
                    Armas a2 = new Armas("Poisoned Dagger", 2, 2, 2);
                    Arma = a2;
                }
                else if (Heroe.Clase == "Rogue" && HabMej == false) // Generamos un arma 2/1 y la equipamos
                {
                    Armas a1 = new Armas("Wicked Knife", 2, 1, 2);
                    Arma = a1;
                }
                else if (Heroe.Clase == "Shaman" && HabMej == true)
                {
                    //El programa no implimenta la carta Justicar Truehearth por lo que se deja para despues la implementacion de habilidad mejorada para shaman
                    ///eleccion de totem.
                    ///creacion de totem.
                }
                else if (Heroe.Clase == "Shaman" && HabMej == false)
                //OBSERVACION DEL METODO, ESTE METODO ASIGNA UN RANDOM ENTER 1 Y 4 PARA ELEGIR ENTRE 4 TOTEMS DISTINTOS
                //PERO SI EXISTE UN TOTEM EN EL TABLERO EL RANDOM SIGUIENTE EXCLUYE AL TOTEM QUE ESTA EN EL TABLERO, HASTA QUE SALGAN LOS 4
                //POR ESTO ANTES DE CREAR UN TOTEM REVISA (con 4 contadores de los 4 totems) QUE ESTE YA ESTE O NO CREADO.
                {
                    bool totem = true;
                    int totemPick = rdm.Next(0, 5);
                    while (totem == true)
                    {                        
                        if (totemPick == 1)
                        {
                            if (totem0count <= totem1count && totem0count <= totem2count && totem0count <= totem3count)
                            {
                                GenTotem0();
                                totem0count += 1;
                                totem = false;
                            }
                            else
                            {
                                totemPick = rdm.Next(0, 5);
                                continue;
                            }
                        }
                        else if (totemPick == 2)
                        {
                            if (totem1count <= totem0count && totem1count <= totem2count && totem1count <= totem3count)
                            {
                                GenTotem1();
                                totem1count += 1;
                                totem = false;
                            }
                            else
                            {
                                totemPick = rdm.Next(0, 5);
                                continue;
                            }
                        }
                        else if (totemPick == 3)
                        {
                            if (totem2count <= totem0count && totem2count <= totem1count && totem2count <= totem3count)
                            {
                                GenTotem2();
                                totem2count += 1;
                                totem = false;
                            }
                            else
                            {
                                totemPick = rdm.Next(0, 5);
                                continue;
                            }

                        }
                        else if (totemPick == 4)
                        {
                            if (totem3count <= totem0count && totem3count <= totem1count && totem3count <= totem2count)
                            {
                                GenTotem3();
                                totem3count += 1;
                                totem = false;
                            }
                            else
                            {
                                totemPick = rdm.Next(0, 5);
                                continue;
                            }
                        }
                        else
                        {
                            totemPick = rdm.Next(0, 5);
                        }

                    }
                    

                }
            }

        }

        public void GenTotem0()//Genera un healing totem
        {
            totem1 = new Minions("Healing Totem", 1, 2, 0);
            Tablero.Add(totem1);
        }

        public void GenTotem1()//Genera un Searing totem
        {
            totem2 = new Minions("Searing Totem", 1, 1, 1);
            Tablero.Add(totem2);
        }

        public void GenTotem2()//Genera un stoneclaw totem
        {
            totem3 = new Minions("Stoneclaw Totem", 1, 2, 0);
            Tablero.Add(totem3);
        }

        public void GenTotem3()//Genera un wraith of air totem
        {
            totem4 = new Minions("Wraith Of Air Totem", 1, 2, 0);
            Tablero.Add(totem4);
        }

        public void Fatiga()
        {
            Vida = Vida - Mazo.Fatiga();
        }

        //Metodo y evento Property Change no estan en uso ya que se presenta un error en el biding con XAML
        public event PropertyChangedEventHandler PropertyChanged;

        public int Vida
        {
            get { return vida; }
            set
            {
                vida = value;
                OnPropertyChanged(vida);
            }
        }

        private void OnPropertyChanged(int VidaJugador)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("VidaJugador"));
            }
        }

        public void FinTurno()
        {
            throw new NotImplementedException();
        }
    }
}
