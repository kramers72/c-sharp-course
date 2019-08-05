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

        public int NumberInStock { get; set; }

        public int NumberAvailable
        {
            get
            {
                return NumberInStock - NumberInCart;
            }
        }

        public int NumberInCart { get; set; }

        public ASCIICategory Category { get; set; }

        public ASCIIArt()
        {
        }

        public override string ToString()
        {
            return ASCII;
        }

        public void Store_AddedToCart(object sender, AddToCartEvent e)
        {
            NumberInCart++;
        }
    }
}
