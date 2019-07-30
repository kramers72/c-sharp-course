using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class ASCIICategory
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<ASCIIArt> ASCIIArtPieces { get; set; }

        public ASCIICategory()
        {
            ASCIIArtPieces = new List<ASCIIArt>();
        }

    }
}
