using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA4.Models
{
    internal class Character
    {
        public Character() { }
        public String Uuid { get; set; }
        public String NameCharacter { get; set; }
        public String NameActor { get; set; }
        public String Gender { get; set; }
        public int MinutesApparition { get; set; }
    }
}
