using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Tablero
    {
        public TimeSpan Tiempo;
        public Jugador J1;
        public Jugador J2;
        public int Turno;
        public Manager manager;
        public TimeSpan reloj;
        public Random rdm = new Random();
        public List<Cartas> Historial = new List<Cartas>();
        public Hechizos Moneda = new Hechizos("The Coin", 0);
        public Boolean J1Jugando;
        

        public Tablero(Jugador J1, Jugador J2, Manager manager)
        {
            this.J1 = J1;
            this.J2 = J2;            
            this.manager = manager;
        }

        public void Partir()
        {

            // --CODIGO ELECCION DE QUIEN PARTE--
            int xy = rdm.Next(1, 2);
            if (xy == 1)
            {
                //manager.Aviso("Parte el jugador 1: " + J1.Nombre);
                while (J1.Mano.Count < 3)
                {
                  J1.Mano.Add(J1.Mazo.miMazo[0]);
                  J1.Mazo.miMazo.RemoveAt(0);
                  J1Jugando = true;
                }
                while (J2.Mano.Count < 4)
                {
                    J2.Mano.Add(J2.Mazo.miMazo[0]);
                    J2.Mazo.miMazo.RemoveAt(0);                  
                }
                J2.Mano.Add(Moneda);
            }
            else
            {
                //manager.Aviso("Parte el jugador 2: " + J2.Nombre);
                while (J1.Mano.Count < 4)
                {
                    J1.Mano.Add(J1.Mazo.miMazo[0]);
                    J1.Mazo.miMazo.RemoveAt(0);
                }
                while (J2.Mano.Count < 3)
                {
                    J2.Mano.Add(J2.Mazo.miMazo[0]);
                    J2.Mazo.miMazo.RemoveAt(0);
                    J1Jugando = false;
                }
                J1.Mano.Add(Moneda);
            }
            //CambioCartas(J1, J2);

                // --- INICIO DEL JUEGO ---

            if (xy == 1)
            {
               // InicioTurno(J1);
            }
            else
            {
               //InicioTurno(J2);
            }

        } //Listo

        public void CambioCartas3(Jugador J, int re1, int re2, int re3)//Ejecuta el cambio de cartas para el jugador que parte.
        {
            if (re1 == 1)
            {
                J.CambiarCarta(0);
            }
            if (re2 == 1)
            {
                J.CambiarCarta(1);
            }
            if (re3 == 1)
            {
                J.CambiarCarta(2);
            }
        }

        public void CambioCartas4(Jugador J, int re1, int re2, int re3, int re4)//Ejecuta el cambio de cartas para el jugador que juega segundo.
        {
            if (re1 == 1)
            {
                J.CambiarCarta(0);
            }
            if (re2 == 1)
            {
                J.CambiarCarta(1);
            }
            if (re3 == 1)
            {
                J.CambiarCarta(2);
            }
            if (re4 == 1)
            {
                J.CambiarCarta(3);
            }
        }

        /*public void CambioCartas(Jugador J1, Jugador J2)
        {
            manager.Aviso(J1.Nombre + " Desea cambiar cartas?");
            manager.Aviso("Mano actual:");
            InfoCartas(J1, J1.Mano);
            manager.Aviso("1 = Si, 2 = No");
            int respJ1 = manager.RecibirResp();
            if (respJ1 == 1)
            {
                manager.Aviso("Que cartas quiere cambiar? (Ingrese 1, para cambiar y 0, para no cambiar.");
                manager.Aviso("Desea Cambiar: " + J1.Mano[0].Nombre + "? (1/0 = si/no)");
                int re1 = manager.RecibirResp();
                manager.Aviso("Desea Cambiar: " + J1.Mano[1].Nombre + "? (1/0 = si/no)");
                int re2 = manager.RecibirResp();
                manager.Aviso("Desea Cambiar: " + J1.Mano[2].Nombre + "? (1/0 = si/no)");
                int re3 = manager.RecibirResp();
                if (J1.Mano.Count > 3)
                {
                    manager.Aviso("Desea Cambiar: " + J1.Mano[3].Nombre + "? (1/0 = si/no)");
                    int re4 = manager.RecibirResp();
                    if (re4 == 1)
                    {
                        J1.CambiarCarta(3);
                    }
                }
                if (re1 == 1)
                {
                    J1.CambiarCarta(0);
                }
                if (re2 == 1)
                {
                    J1.CambiarCarta(1);
                }
                if (re3 == 1)
                {
                    J1.CambiarCarta(2);
                }
            }
            manager.Aviso("Su mano actual es: ");
            InfoCartas(J1, J1.Mano);
            manager.Aviso("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");


            manager.Aviso(J2.Nombre + " Desea cambiar cartas?");
            manager.Aviso("Mano actual:");
            InfoCartas(J2, J2.Mano);
            manager.Aviso("1 = Si, 2 = No");
            int respJ2 = manager.RecibirResp();
            if (respJ2 == 1)
            {
                manager.Aviso("Que cartas quiere cambiar? (Ingrese 1, para cambiar y 0, para no cambiar.");
                manager.Aviso("Desea Cambiar: " + J2.Mano[0].Nombre + "? (1/0 = si/no)");
                int re1 = manager.RecibirResp();
                manager.Aviso("Desea Cambiar: " + J2.Mano[1].Nombre + "? (1/0 = si/no)");
                int re2 = manager.RecibirResp();
                manager.Aviso("Desea Cambiar: " + J2.Mano[2].Nombre + "? (1/0 = si/no)");
                int re3 = manager.RecibirResp();
                if (J2.Mano.Count > 3)
                {
                    manager.Aviso("Desea Cambiar: " + J2.Mano[3].Nombre + "? (1/0 = si/no)");
                    int re4 = manager.RecibirResp();
                    if (re4 == 1)
                    {
                        J2.CambiarCarta(3);
                    }
                }
                if (re1 == 1)
                {
                    J2.CambiarCarta(0);
                }
                if (re2 == 1)
                {
                    J2.CambiarCarta(1);
                }
                if (re3 == 1)
                {
                    J2.CambiarCarta(2);
                }               
            }
            manager.Aviso("Su mano actual es: ");
            InfoCartas(J2, J2.Mano);
            manager.Aviso("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");

        }*/ // [Obsoleto] Método para consola.

        public void InfoCartas(Jugador J, List<Cartas> L)// [Obsoleto] Método para consola.
        {
            int i = 0;
            manager.Aviso("                      (Costo/Ataque/Vida)");
            while(i < L.Count)
            {
                manager.Aviso(i + ". " + L[i].Nombre + " | " + L[i].Costo + "/" + L[i].Ataque + "/" + L[i].Vida);
                i += 1;
            }
        }

        public void Menu(Jugador J) // [Obsoleto] Método para consola.
        {
            manager.Aviso("Que desea hacer?, 1= BajarCarta, 2= UsarCarta, 3= UsarHabilidad, 4= FinTurno, 5= EnviarMensaje, 6= Conceder");
            int x = manager.RecibirResp();
            if (x == 1)
            {
                //BajarCarta(J);
            }
            else if (x == 2)
            {
                UsarCarta(J);
            }
            else if (x == 3)
            {
                UsarHabilidad(J);
            }
            else if (x == 4)
            {
                FinTurno(J);
            }
            else if (x == 5)
            {
                J.Heroe.Mensaje();
                Menu(J);
            }
            else
            {
                Conceder(J);
            }
        }

        public void InicioTurno(Jugador J) 
        {
            if (J1.Vida <= 0)
            {
                //Gano J2
                //manager.Aviso("Ha ganado " + J2.Nombre);
                //manager.RecibirResp();
            }
            else if (J2.Vida <= 0)
            {
                //Gano J1
                //manager.Aviso("Ha ganado " + J1.Nombre);
                //manager.RecibirResp();
            }
            Turno += 1;
            // Agregamos mana, y chequeamos si tiene más de 10, de ser así igualamos a 10
            J.ManaOrig += 1;
            J.Mana = J.ManaOrig;
            if (J.Mana >= 10)
            {
                J.Mana = 10;
            }
            // El jugador roba una carta y hacemos que revise si tiene más de 10.
            J.RobarCarta();
            J.RevMano();
            J.UsoHab = false;

            // Mostramos las cartas que hay en tablero y le mostramos la mano al jugador que le toca jugar.
            /*manager.Aviso("Vida de " + J1.Nombre + " " + J1.Vida + ", Armor: " + J1.Armor);
            manager.Aviso("Vida de " + J2.Nombre + " " + J2.Vida + ", Armor: " + J2.Armor);
            manager.Aviso("Tablero de " + J1.Nombre + ": ");
            InfoCartas(J1, J1.Tablero);
            manager.Aviso("Tablero de " + J2.Nombre + ": ");
            InfoCartas(J2, J2.Tablero);
            manager.Aviso(J.Nombre + " te toca jugar.");
            manager.Aviso("Cartas en mazo: " + J.Mazo.miMazo.Count);
            manager.Aviso("Maná: " + J.Mana);
            manager.Aviso("Cartas actuales en mano: ");
            InfoCartas(J, J.Mano);
            Menu(J);*/


        }

        /*public void TiempoTurno(int Turno, Jugador J)
            //entregarle el turno 
            //tiempo del turno son 75000 milisegundos la cuerda comienza a quemarse a los 55000 milisegundos
        {
            Stopwatch reloj = new Stopwatch();
            reloj.Start();
            TimeSpan ts = reloj.Elapsed;
            TimeSpan tc = new TimeSpan(0, 0, 55);
            TimeSpan tf = new TimeSpan(0, 0, 75);//tc son 55 segundos.
            int y = ts.CompareTo(tc);//compara si el tiempo que se lleva es mayor a 55 segundos para activar la cuerda.
            int x = ts.CompareTo(tf);//compara si el tiempo que se lleva es mayor a 75 segundos para terminar el turno
            while (true)
            {
                if (y == 0)
                {
                    manager.Aviso("Le quedan 20 segundos de juego (la cuerda se esta quemando).");
                }
                else if (x == 0)
                {
                    FinTurno(J);
                    break;
                }
            }
        }*/

        public void BajarCarta(Jugador J, int z)
        {
            //manager.Aviso("Maná disponible: " + J.Mana);
            if (J.Tablero.Count >= 7)
            {
                //manager.Aviso("Su tablero está lleno, no puede bajar cartas");
            }
            else
            {
                //manager.Aviso("Que carta desea bajar? ");
                //InfoCartas(J, J.Mano);
                //int z = manager.RecibirResp();
                Historial.Add(J.Mano[z]);
                J.BajarCarta(z);
            }           

            // ahora le mostramos el menú de opciones denuevo
            //Menu(J);
            
        } 

        public void UsarCarta(Jugador J)
        {
            if (J.Tablero.Count == 0)
            {
                manager.Aviso("No tiene cartas para usar.");
                Menu(J);
            }
            else
            {
                manager.Aviso("Que carta desea usar? ");
                InfoCartas(J, J.Tablero);
                if (J.Daño != 0 || J.Arma != null)
                {
                    manager.Aviso("Seleccione 7 Para atacar con su heroe.");
                }
                int x = manager.RecibirResp();
                manager.Aviso("En que posición está la carta que desea atacar? (0,1,2,3,4,5,6 o 7 = Heroe enemigo)");
                manager.Aviso("Tablero Enemigo: ");
                if (J.ID == true)
                {
                    InfoCartas(J2, J2.Tablero);
                }
                else
                {
                    InfoCartas(J1, J1.Tablero);
                }
                int y = manager.RecibirResp();
                if (x == 7)
                {
                    AtaqueHeroe(J, y);
                }
                else
                {
                    Ataque(x, J, y); // x posicion de carta del atacante, y posicion de carta del atacado
                }                
                Menu(J);
            }
            
        }

        public void Ataque(int x, Jugador J, int y)
        {
            //Ejecuta el ataque de minions, con todas las respectivas verificaciones, en el caso que ataque a un heroe debe revisar la armadura de este.
            if (J.ID == true && J1.Tablero[x].Memoria >= 1)
            {
                if (y < 7)
                {
                    J2.Tablero[y].Vida -= J1.Tablero[x].Ataque;
                    J1.Tablero[x].Vida -= J2.Tablero[y].Ataque;
                    if (J1.Tablero[x].Vida <= 0)
                    {
                        J1.Tablero.RemoveAt(x);
                        if (J2.Tablero[y].Vida <= 0)
                        {
                            J2.Tablero.RemoveAt(y);
                        }
                    }
                    else if (J2.Tablero[y].Vida <= 0)
                    {
                        J2.Tablero.RemoveAt(y);
                        if (J1.Tablero[x].Vida <= 0)
                        {
                            J1.Tablero.RemoveAt(x);
                        }
                    }
                }
                else if (y >= 7 && J1.Tablero[x].Memoria >= 1)// Revisamos si el jugador tiene armadura, para atacar primero esta antes que la vida.
                {
                    if(J2.Armor > 0)
                    {
                        J2.Armor -= J1.Tablero[x].Ataque;
                        if (J2.Armor > 0)
                        {

                        }
                        else
                        {
                            J2.Vida += J2.Armor;
                            J2.Armor = 0;
                        }
                    }
                    else
                    {
                        J2.Vida -= J1.Tablero[x].Ataque;
                    } 
                }

            }
            else if (J.ID == false && J2.Tablero[x].Memoria >= 1)
            {
                if (y < 7)
                {
                    J1.Tablero[y].Vida -= J2.Tablero[x].Ataque;
                    J2.Tablero[x].Vida -= J1.Tablero[y].Ataque;
                    if (J1.Tablero[y].Vida <= 0)
                    {
                        J1.Tablero.RemoveAt(y);
                        if (J2.Tablero[x].Vida <= 0)
                        {
                            J2.Tablero.RemoveAt(x);
                        }
                    }
                    else if (J2.Tablero[x].Vida <= 0)
                    {
                        J2.Tablero.RemoveAt(x);
                        if (J1.Tablero[y].Vida <= 0)
                        {
                            J1.Tablero.RemoveAt(y);
                        }
                    }
                }
                else if (y >= 7 && J2.Tablero[x].Memoria >= 1)
                {
                    if(J1.Armor > 0) // Revisamos si el jugador tiene armadura, para atacar primero esta antes que la vida.
                    {
                        J1.Armor -= J2.Tablero[x].Ataque;
                        if(J1.Armor > 0)
                        {

                        }
                        else
                        {
                            J1.Vida += J1.Armor;
                            J1.Armor = 0;
                        }
                    }
                    else
                    {
                        J1.Vida -= J2.Tablero[x].Ataque;
                    }

                }


            }
            else
            {
                manager.Aviso("No puede utilizar esa carta, la bajó este turno.");
            }

        }

        public void AtaqueHeroe (Jugador J, int y)
        {
            //Este metodo es muy extenso por todos lo casos bajo los cuales un heroe puede atacar y recibir daño
            //Ya sea que ataca con o sin arma (ej:druida sin y rogue con arma), tambien debe revizar si al atacar el es dañado
            //debe revizar si el y el oponente poseen armadura para quitar primero la armadura, y lo mismo para atacar a minions.
            if (J.ID == true && J.Arma != null)
            {
                if (y < 7)
                {
                    J2.Tablero[y].Vida -= (J1.Daño + J1.Arma.Ataque);
                    J1.Arma.Durabilidad -= 1;
                    if (J1.Arma.Durabilidad <= 0)
                    {
                        J1.Arma = null;
                    }
                    if(J1.Armor > 0)
                    {
                        J1.Armor -= J2.Tablero[y].Ataque;
                        if (J1.Armor > 0)
                        {

                        }
                        else
                        {
                            J1.Vida += J1.Armor;
                            J1.Armor = 0;
                        }

                    }
                    else
                    {
                        J1.Vida -= J1.Tablero[y].Ataque;
                    }
                    J1.Daño = 0;
                }
                else
                {
                    J2.Vida -= (J1.Daño + J1.Arma.Ataque);
                    J1.Arma.Durabilidad -= 1;
                    if (J1.Arma.Durabilidad <= 0)
                    {
                        J1.Arma = null;
                    }
                    if (J1.Armor > 0)
                    {
                        if (J2.Arma != null)
                        {
                            J1.Armor -= (J2.Daño + J2.Arma.Ataque);
                            J2.Arma.Durabilidad -= 1; //revisar si pierde durabilidad
                            if (J2.Arma.Durabilidad <= 0)
                            {
                                J2.Arma = null;
                            }
                            if (J1.Armor > 0)
                            {

                            }
                            else
                            {
                                J1.Vida += J1.Armor;
                                J1.Armor = 0;
                            }
                        }
                        else
                        {
                            J1.Armor -= (J2.Daño);
                            if (J1.Armor > 0)
                            {

                            }
                            else
                            {
                                J1.Vida += J1.Armor;
                                J1.Armor = 0;
                            }
                        }
                        J2.Daño = 0;
                    }    
                }
            }
            else if (J.ID == true && J.Arma == null)
            {
                if (y < 7)
                {
                    J2.Tablero[y].Vida -= (J1.Daño);
                    
                    if (J1.Armor > 0)
                    {
                        J1.Armor -= J2.Tablero[y].Ataque;
                        if (J1.Armor > 0)
                        {

                        }
                        else
                        {
                            J1.Vida += J1.Armor;
                            J1.Armor = 0;
                        }

                    }
                    else
                    {
                        J1.Vida -= J1.Tablero[y].Ataque;
                    }
                    J1.Daño = 0;
                }
                else
                {
                    J2.Vida -= (J1.Daño);
                    
                    if (J1.Armor > 0)
                    {
                        if (J2.Arma != null)
                        {
                            J1.Armor -= (J2.Daño + J2.Arma.Ataque);
                            J2.Arma.Durabilidad -= 1; //revisar si pierde durabilidad
                            if (J2.Arma.Durabilidad <= 0)
                            {
                                J2.Arma = null;
                            }
                            if (J1.Armor > 0)
                            {

                            }
                            else
                            {
                                J1.Vida += J1.Armor;
                                J1.Armor = 0;
                            }
                        }
                        else
                        {
                            J1.Armor -= (J2.Daño);
                            if (J1.Armor > 0)
                            {

                            }
                            else
                            {
                                J1.Vida += J1.Armor;
                                J1.Armor = 0;
                            }
                        }
                        J2.Daño = 0;
                    }
                }
            }
            else if (J.ID == false && J.Arma != null)
            {
                if (y < 7)
                {
                    J1.Tablero[y].Vida -= (J2.Daño + J2.Arma.Ataque);
                    J2.Arma.Durabilidad -= 1;
                    if (J2.Arma.Durabilidad <= 0)
                    {
                        J2.Arma = null;
                    }
                    if (J2.Armor > 0)
                    {
                        J2.Armor -= J1.Tablero[y].Ataque;
                        if (J2.Armor > 0)
                        {

                        }
                        else
                        {
                            J2.Vida += J2.Armor;
                            J2.Armor = 0;
                        }

                    }
                    else
                    {
                        J2.Vida -= J2.Tablero[y].Ataque;
                    }
                    J2.Daño = 0;
                }
                else
                {
                    J1.Vida -= (J2.Daño + J2.Arma.Ataque);
                    J2.Arma.Durabilidad -= 1;
                    if (J2.Arma.Durabilidad <= 0)
                    {
                        J2.Arma = null;
                    }
                    if (J2.Armor > 0)
                    {
                        if (J1.Arma != null)
                        {
                            J2.Armor -= (J1.Daño + J1.Arma.Ataque);
                            J1.Arma.Durabilidad -= 1; //revisar si pierde durabilidad
                            if (J1.Arma.Durabilidad <= 0)
                            {
                                J1.Arma = null;
                            }
                            if (J2.Armor > 0)
                            {

                            }
                            else
                            {
                                J2.Vida += J2.Armor;
                                J2.Armor = 0;
                            }
                        }
                        else
                        {
                            J2.Armor -= (J1.Daño);
                            if (J2.Armor > 0)
                            {

                            }
                            else
                            {
                                J2.Vida += J2.Armor;
                                J2.Armor = 0;
                            }
                        }
                        J1.Daño = 0;
                    }
                }
            }
            else if (J.ID == false && J.Arma == null)
            {
                if (y < 7)
                {
                    J1.Tablero[y].Vida -= (J2.Daño);

                    if (J2.Armor > 0)
                    {
                        J2.Armor -= J1.Tablero[y].Ataque;
                        if (J2.Armor > 0)
                        {

                        }
                        else
                        {
                            J2.Vida += J2.Armor;
                            J2.Armor = 0;
                        }

                    }
                    else
                    {
                        J2.Vida -= J2.Tablero[y].Ataque;
                    }
                    J2.Daño = 0;
                }
                else
                {
                    J1.Vida -= (J2.Daño);

                    if (J2.Armor > 0)
                    {
                        if (J1.Arma != null)
                        {
                            J2.Armor -= (J1.Daño + J1.Arma.Ataque);
                            J1.Arma.Durabilidad -= 1; //revisar si pierde durabilidad
                            if (J1.Arma.Durabilidad <= 0)
                            {
                                J2.Arma = null;
                            }
                            if (J2.Armor > 0)
                            {

                            }
                            else
                            {
                                J2.Vida += J2.Armor;
                                J2.Armor = 0;
                            }
                        }
                        else
                        {
                            J2.Armor -= (J1.Daño);
                            if (J2.Armor > 0)
                            {

                            }
                            else
                            {
                                J2.Vida += J2.Armor;
                                J2.Armor = 0;
                            }
                        }
                        J1.Daño = 0;
                    }
                }
            }
        }

        public void UsarHabilidad(Jugador J) // Terminar Jaina y Anduin
        {
            J.UsarHabilidad();
            int y = J.VarAuxDmg;
            J.VarAuxDmg = 0;
            if (J.ID == true)
            {
                if (J.Heroe.NombreHeroe == "Rexxar")
                {
                    J2.Vida -= y;
                }
                else if (J.Heroe.NombreHeroe == "Jaina") // Falta dejar que ataque a sus aliados y a si mismo
                {
                    manager.Aviso("Que desea atacar? : ");
                    InfoCartas(J2, J2.Tablero);
                    int res = manager.RecibirResp();
                    J2.Tablero[res].Vida -= y;                 
                }
                else if (J.Heroe.NombreHeroe == "Anduin") // Falta dejar que cure a sus enemigos
                {
                    manager.Aviso("A quien desea Curar? ");
                    InfoCartas(J1, J1.Tablero);
                    manager.Aviso("Si desea curar su vida de heroe use 7");
                    int res = manager.RecibirResp();
                    if (res == 7)
                    {
                        J1.Vida += 2;
                        if (J1.Vida >= 30)
                        {
                            J1.Vida = 30;
                        }
                    }
                    else
                    {
                        J1.Tablero[res].Vida += y;
                        if (J1.Tablero[res].Vida > J1.Tablero[res].VidaOriginal)
                        {
                            J1.Tablero[res].Vida = J1.Tablero[res].VidaOriginal;
                        }
                    }
                }
            }
            else
            {
                if (J.Heroe.NombreHeroe == "Rexxar")
                {
                    J1.Vida -= y;
                }
                else if (J.Heroe.NombreHeroe == "Jaina") // Falta dejar que ataque a sus aliados y a si mismo
                {
                    manager.Aviso("Que desea atacar? : ");
                    InfoCartas(J1, J1.Tablero);
                    int res = manager.RecibirResp();
                    J1.Tablero[res].Vida -= y;
                }
                else if (J.Heroe.NombreHeroe == "Anduin") // Falta dejar que cure a sus enemigos
                {
                    manager.Aviso("A quien desea Curar? ");
                    InfoCartas(J2, J2.Tablero);
                    manager.Aviso("Si desea curar su vida de heroe use 7");
                    int res = manager.RecibirResp();
                    if (res == 7)
                    {
                        J2.Vida += 2;
                        if (J2.Vida >= 30)
                        {
                            J2.Vida = 30;
                        }
                    }
                    else
                    {
                        J2.Tablero[res].Vida += y;
                        if (J2.Tablero[res].Vida > J2.Tablero[res].VidaOriginal)
                        {
                            J2.Tablero[res].Vida = J2.Tablero[res].VidaOriginal;
                        }
                    }
                }
            }
            J.VarAuxDmg = 0;
            // ahora le mostramos el menú de opciones denuevo
            // Menu(J);
        }

        public void FinTurno(Jugador J)
        {
            manager.Aviso("El jugador " + J.Nombre + " ha finalizado su turno");
            Memorias();
            //manager.Aviso("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            if (J.ID == true)
            {
                J1Jugando = false;
                J1.UsoHab = false;
                J2.UsoHab = false;
                InicioTurno(J2);
            }
            else
            {
                J1Jugando = true;
                J1.UsoHab = false;
                J2.UsoHab = false;
                InicioTurno(J1);
            }
        }

        public void Memorias()//Lleva la memoria de cartas en el tablero
        {
            foreach (Cartas i in J1.Tablero)
            {
                i.Memoria += 1;
            }
            foreach (Cartas p in J2.Tablero)
            {
                p.Memoria += 1;
            }
        }

        public void Conceder(Jugador J)
        {
            J.Vida = 0;
            FinTurno(J);
        }
    }

}
