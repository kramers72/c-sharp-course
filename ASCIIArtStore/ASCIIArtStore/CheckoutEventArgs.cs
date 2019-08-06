using System.Collections.Generic;

namespace ASCIIArtStore
{
    class CheckoutEventArgs
    {
        private Store _store { get; set; }

        public CheckoutEventArgs(Store store)
        {
            store = _store;
        }
    }
}