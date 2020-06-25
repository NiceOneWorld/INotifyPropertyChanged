using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz_12_INotifyPropertyChanged
{
    public class LibraryCard : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get {return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }
        public Client _client;
        public LibraryCard(int id, Client client)
        {
            _id = id;
            _client = client;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Info(object sender, PropertyChangedEventArgs ev)
        {
            if (sender is Client)
            {
                Console.WriteLine($"Client for LibraryCard -> {ev.PropertyName}");
            }
        }

    }
}
