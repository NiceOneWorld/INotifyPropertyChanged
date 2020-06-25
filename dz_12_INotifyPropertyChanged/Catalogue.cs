using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz_12_INotifyPropertyChanged
{
    public class Catalogue : INotifyPropertyChanged
    {
        private string _nameCatalog;
        public string NameCatalog 
        {
            get { return _nameCatalog; }
            set
            {
                _nameCatalog = value;
                NotifyPropertyChanged("Catalog Name");
            }
        }
        public Author _author;

        public Catalogue(string nameCatalog, Author author)
        {
            _nameCatalog = nameCatalog;
            _author = author;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Info(object sender, PropertyChangedEventArgs ev)
        {
            if (sender is Author)
            {
                Console.Write($"Author for Catalogue -> {ev.PropertyName}");
            }
        }
        public override string ToString()
        {
            return$"Catalog: {NameCatalog}, Author {_author.Pseudonym}.";
        }
    }
}
