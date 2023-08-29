using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA2
{
    internal class ModelRegister
    {
        public ModelRegister() { }
        public ModelRegister(String nameClient, String nameFilm, String typeFilm, String typeService)
        {
            NameClient = nameClient;
            TypeFilm = typeFilm;
            TypeService = typeService;
            NameFilm = nameFilm;
        }
        public String NameClient { get; set; }
        public String NameFilm { get; set; }
        public String TypeFilm { get; set; }
        public String TypeService { get; set; }
        public double MontoAPagar { get; set; }
    }
}
