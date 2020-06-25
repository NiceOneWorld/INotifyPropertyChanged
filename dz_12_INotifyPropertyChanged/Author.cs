using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz_12_INotifyPropertyChanged
{
    public class Author : INotifyPropertyChanged
    {
        private string _titleBoock;
        private string _pseudonym;
        public string TitleBoock
        {
            get { return _titleBoock; }
            set
            {
                if (value != _titleBoock)
                {
                    _titleBoock = value;
                    NotifyPropertyChanged("Title boock");
                }
            }
        }
        public string Pseudonym
        { 
            get{ return _pseudonym; }
            set
            {
                if (value != _pseudonym)
                {
                    _pseudonym = value;
                    NotifyPropertyChanged("Pseudonym");
                }; 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Info(object sender, PropertyChangedEventArgs ev)
        {
            if (sender is Catalogue)
            {
                Console.Write($"Catalogue for Client -> {ev.PropertyName}");
            }
        }
        public Author(string name, string titleBoock)
        {
            Pseudonym = name;
            TitleBoock = titleBoock;
        }
        public override string ToString()
        {
            return $"Author: {Pseudonym}, Boock: {TitleBoock}";
        }
    }
}
