using System.Collections.Generic;

namespace ASCIIArtStore
{
    class ShoppingCart
    {
        public List<ASCIIArt> Items { get; private set; }

        public int NumberInCart { get; set; }

        public ShoppingCart()
        {
            Items = new List<ASCIIArt>();
            Store.StoreInstance.AddedToCart += StoreInstance_AddedToCart;
        }

        private void StoreInstance_AddedToCart(object sender, AddToCartEvent e)
        {
            Items.Add(e.Item);
        }

    }
}