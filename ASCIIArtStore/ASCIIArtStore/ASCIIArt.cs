using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class ASCIIArt
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string ASCII { get; set; }

        public decimal Price { get; set; }

        public ASCIICategory Category { get; set; }

        public override string ToString()
        {
            return ASCII;
        }


    }
}
