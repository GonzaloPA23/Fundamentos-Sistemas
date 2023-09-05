using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA3
{
    internal class MovieModel
    {
        public MovieModel() { }
        public String Uuid { get; set; }
        public String Name { get; set; }
        public String Genre { get; set; }
        public String Country { get; set; }
        public int Duration { get; set; }
        public int QuantityCharacters { get; set; }
    }
}
