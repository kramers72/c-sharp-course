using System;
using System.Collections.Generic;
using System.Linq;

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
            Store.StoreInstance.Checkout += StoreInstance_Checkout;
        }

        public void PrintHeader()
        {
            Console.WriteLine($"ASCII Art 1.0 \t\t\t\tYour Cart {Items.Count} items. Total: ${Items.Sum(a => a.Price)}");
        }

        public override string ToString()
        {
            string s = $"ASCII Art 1.0 \t\t\t\tYour Cart {Items.Count} items. Total: ${Items.Sum(a => a.Price)}";

            foreach (var item in Items)
            {
                s += item;
                s += "\r\n";
            }

            s += "\r\n";

            return s;
        }

        private void StoreInstance_Checkout(object sender, CheckoutEventArgs e)
        {

            Items.ForEach(i => i.NumberInCart = 0);
            Items.ForEach(i => i.NumberInStock--);

            Items.Clear();
        }

        private void StoreInstance_AddedToCart(object sender, AddToCartEvent e)
        {
            e.Item.NumberInCart++;
            Items.Add(e.Item);
        }

   }
}