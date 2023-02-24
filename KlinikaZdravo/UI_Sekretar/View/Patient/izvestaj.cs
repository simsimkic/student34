using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthClinic
{
    public class izvestaj : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private Stream docStream;
        public Stream DocStream
        {
            get
            {
                return docStream;
            }
            set
            {

                docStream = value;
                OnPropertyChanged("DocStream");

            }
        }

        public izvestaj()
        {
            docStream = new FileStream(@"..\..\izvestaj.pdf", FileMode.OpenOrCreate);
        }
    }
}
