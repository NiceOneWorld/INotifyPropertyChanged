using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_12_INotifyPropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Author author1 = new Author("Viktor Pelevin", "Generation P");
            Catalogue catalogue = new Catalogue("Fantasy", author1);
            Client client = new Client("Vasya Pupkin", "+380675555555");
            LibraryCard libraryCard = new LibraryCard(1, client);
            Console.WriteLine(client);
            Console.WriteLine(author1);
            Console.WriteLine(catalogue);


          //  Console.WriteLine(libraryCard);

        }
    }
}
