using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratJCDecaux
{
    public class Position
    {

        public string latitude { get; set; }
        public string longitude { get; set; }

        public override string ToString()
        {
            return "(L: " + latitude + "; l: " + longitude + ")";
        }
    }
}
