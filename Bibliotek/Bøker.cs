using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    internal class Bøker
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Released { get; set; }
        public int ID { get; set; }
        public Bøker(string title, string author, int released, int id)
        {
            Title = title;
            Author = author;
            Released = released;
            ID = id;
        }
    }
}
