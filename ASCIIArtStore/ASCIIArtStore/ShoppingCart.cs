using System.Collections.Generic;

namespace ASCIIArtStore
{
    class ShoppingCart
    {
        public List<ASCIIArt> Items { get; private set; }

        public ShoppingCart()
        {
            Items = new List<ASCIIArt>();
        }

        public void AddItem(ASCIIArt item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ASCIIArt item)
        {
            Items.Add(item);
        }

    }
}