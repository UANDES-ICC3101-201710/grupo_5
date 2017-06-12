using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone_GUI_Grupo5
{
    class Minions : Cartas, INotifyPropertyChanged
    {
        public int Vida;
        public int Ataque;
        public Boolean Estado;
        public int Memoria;
        public int VidaOriginal;

        public Minions(string nombre, int costo, int Vida, int Ataque) : base(nombre, costo, Vida, Ataque)
        {
            this.Vida = Vida;
            this.Ataque = Ataque;
            this.VidaOriginal = Vida;
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged(nombre);
            }
        }

        private void OnPropertyChanged(String Propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Propiedad));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
