using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11
{
    public class Books
    {
        public string Autors { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public Books() { }

        public Books(string authors, string name, string genre)
        {
            Autors = authors;
            Name = name;
            Genre = genre;
        }
}
    }
      
