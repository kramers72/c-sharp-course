using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class ApplePhone : ISmartPhone
    {
        public void MakePhoneCall()
        {
            throw new NotImplementedException();
        }

        public string OpenWebPage()
        {
            throw new NotImplementedException();
        }

        public bool StartAnApp()
        {
            throw new NotImplementedException();
        }
    }
}
