using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class Inventory
    {
        public List<Art> ASCIIInventory { get; set; }

        public IEnumerable<string> Categories()
        {
            return from i in ASCIIInventory
                    group i by i.Category into g
                    select g.Key;
        }
    }
}
