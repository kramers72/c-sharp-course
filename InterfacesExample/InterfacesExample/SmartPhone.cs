using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public abstract class SmartPhone
    {
        private bool _powerButtonPressed;

        public abstract void MakePhoneCall();

        public abstract string OpenWebPage();

        public abstract bool StartAnApp();

        public void Power()
        {
            if (_powerButtonPressed)
            {

                PowerDown();
            }
        }

        private void PowerDown()
        {
            throw new NotImplementedException();
        }
    }
}
