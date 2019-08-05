using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class Inventory
    {
        // you could use this class to keep counts of the different ASCIIArt objects and reduce that count as items are sold
        public List<ASCIIArt> ASCIIInventory { get; set; }

        public List<InventoryItem> ASCIIInventoryItems { get; set; }

        public Inventory()
        {
            RandomlyPopulate();
        }

        private void RandomlyPopulate()
        {
            

        }

        //public IEnumerable<string> Categories()
        //{
        //    return from i in ASCIIInventory
        //            group i by i.Category into g
        //            select g.Key;
        //}
    }
}
