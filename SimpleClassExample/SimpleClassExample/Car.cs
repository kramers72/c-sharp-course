using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        private string _petName;

        public string PetName
        {
            get
            {

                return _petName;
            }
            set
            {
                _petName = value;
            }
        }

        private int _currSpeed;
        public int CurrSpeed
        {
            get
            {
                return _currSpeed;
            }
            set
            {
                _currSpeed = value;
            }
        }



        internal void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", _petName, _currSpeed);
        }

        internal void SpeedUp(int delta)
        {

            _currSpeed += delta;

        }
    }
}
