using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Hearthstone_GUI_Grupo5
{
    [Serializable]
    class Minions : Cartas, INotifyPropertyChanged
    {
        public int Ataque;
        public Boolean Estado;
        public int Memoria;
        public int VidaOriginal;
        private string nombre;
        private int vida;

        public Minions(string nombre, int costo, int Vida, int Ataque) : base(nombre, costo, Vida, Ataque)
        {
            this.vida = Vida;
            this.Ataque = Ataque;
            this.VidaOriginal = Vida;
        }


        public int Vida
        {
            get { return vida; }
            set { vida = value;
                OnPropertyChanged(vida);
            }
        }

        private void OnPropertyChanged(int Propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Propiedad"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
