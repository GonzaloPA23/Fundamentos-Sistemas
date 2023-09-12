using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA4.Models
{
    internal class Movie
    {
        public Movie() { }
        public String Uuid { get; set; }
        public String Country { get; set; }
        public String Name { get; set; }
        public String Genre { get; set; }
        public int DurationMinutes { get; set; }
        public List <Character> Characters { get; set; } 
    }
}
