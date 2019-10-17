using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public static int NumTires = 4;

        public List<int> PartNumbers { get; set; }


       

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

        public Color MyColor { get; set; }

        public Car() : this("Default PetName", -1)
        {
           
        }

        public Car(string petName) : this(petName, -1)
        {
          
        }

        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }

        internal void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH and is a flash of {2}.", _petName, _currSpeed, MyColor.ToString());
        }

        internal void SpeedUp(int delta)
        {

            _currSpeed += delta;

        }
    }
}
