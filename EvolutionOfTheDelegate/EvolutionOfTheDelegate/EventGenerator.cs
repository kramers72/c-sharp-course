using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionOfTheDelegate
{
    class EventGenerator
    {
        public event EventHandler Fire;

        public void FiresEvents()
        {
            if (Fire != null)
            {
                Fire(this, new EventArgs());
            }
        }
    }
}
