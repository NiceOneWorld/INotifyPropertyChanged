using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz_12_INotifyPropertyChanged
{
    public class Client :INotifyPropertyChanged
    {
        private string _name;
        private string _phoneNumber;
        public Client(string name, string phone)
        {
            _name = name;
            _phoneNumber = phone;
        }
        public string Name 
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value != _phoneNumber)
                {
                    _phoneNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }
      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Info(object sender, PropertyChangedEventArgs e)
        {
            if (sender is Catalogue)
            {
                Console.Write($"Catalogue for Client -> {e.PropertyName}");
            }
        }
        public override string ToString()
        {
            return $"Client: {Name}, Phone: {PhoneNumber}";
        }
    }
}
