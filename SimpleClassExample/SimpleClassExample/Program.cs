using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.PetName = "Henry";
            myCar.CurrSpeed = 10;

            myCar.PrintState();

            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Car[] carArray = new Car[10];

            for (int i = 0; i < 10; i++)
            {
                carArray[i] = new Car();
                carArray[i].CurrSpeed = 5 + i;
                carArray[i].PetName = $"Car{i}";
            }

            foreach (Car item in carArray)
            {
                item.PrintState();
            }

            Console.ReadLine();
        }
    }
}
