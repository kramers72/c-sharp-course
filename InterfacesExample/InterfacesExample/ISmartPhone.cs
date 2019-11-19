using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public interface ISmartPhone
    {
        void MakePhoneCall();

        string OpenWebPage();

        bool StartAnApp();

        int MyProperty { get; set; }
    }
}
