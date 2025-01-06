using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoesningSession7.ViewModel
{
    internal class Bil : INotifyPropertyChanged
    {
        private string model;
        private int hk;
        private bool elbil;

        public Bil(string model, int hk, bool elbil)
        {
            Model = model;
            Hk = hk;
            Elbil = elbil;
        }

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Model)));
            }
        }
        public int Hk
        {
            get { return hk; }
            set
            {
                hk = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Hk)));
            }
        }
        public bool Elbil
        {
            get { return elbil; }
            set
            {
                elbil = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Elbil)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };
    }
}
