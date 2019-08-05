using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class AddToCartEvent
    {
        public ASCIIArt Item { get; set; }

        public AddToCartEvent(ASCIIArt item)
        {
            Item = item;

        }
    }
}
