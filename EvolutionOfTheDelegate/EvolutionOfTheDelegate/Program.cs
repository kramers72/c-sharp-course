using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionOfTheDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstEvolution();
            SecondEvolution();
            ThirdEvolution();
            FourthEvolution();
            FifthEvolution();
            SixthEvolution();
            Console.ReadLine();
        }


        #region SixthEvolution
        private static void SixthEvolution()
        {
            // lambda

            EventGenerator gen = new EventGenerator();
            gen.Fire += (sender, e) => Console.WriteLine("anonymous method handled the fire");



            List<int> l = new List<int>();

            var intGreaterThan0 = l.Where(delegate (int i) { return i > 0; });
            var intGreaterThan0Simple = l.Where(i => i > 0);


            Action<int> myAction = (i) => Console.WriteLine("arg is: " + i);

            myAction(80);

            Func<int, int> doubleIt = (val) =>
            {
                int retval = val * val;

                return retval;

            };

            Console.WriteLine(doubleIt(5));
        }

        #endregion

        #region FifthEvolution

        private static void FifthEvolution()
        {
            EventGenerator gen = new EventGenerator();
            gen.Fire += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("anonymous method handled the fire");
            };


            List<int> l = new List<int>();

        }
        #endregion

        #region FourthEvolution

        private static void FourthEvolution()
        {
            // now instead of declaring a delegate just use Action and Func


            List<int> list = new List<int>();

            Func<int, bool> whereClause = new Func<int, bool>(greaterThen0);

            list.Where(whereClause);

            // Use the Action<> delegate to point to DisplayMessage. 
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            /*
            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);
            */

            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2(90, 300);
            Console.WriteLine(sum);

        }

        private static bool greaterThen0(int arg)
        {
            return arg > 0;
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text. 
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // Restore color. 
            Console.ForegroundColor = previous;
        }

        // Targets for the Func<> delegate. 
        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
        #endregion

        #region ThirdEvolution

        private static void ThirdEvolution()
        {
            // generic delegates
            Console.WriteLine("***** Generic Delegates *****\n");

            // Register targets.
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data");

            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

        }

        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }

        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }
        #endregion

        #region Second Evolution


        private static void SecondEvolution()
        {
            // built in events
            EventGenerator firesEvents = new EventGenerator();
            firesEvents.Fire += new EventHandler(HandleFire);

            for (int i = 0; i < 3; i++)
            {
                firesEvents.FiresEvents();
            }
        }

        static void HandleFire(object sender, EventArgs e)
        {
            Console.WriteLine("handled fire event");
        }

        #endregion

        #region FirstEvolution


        private static void FirstEvolution()
        {
            // delegate used as a function pointer
            FunctionHandler handler = new FunctionHandler(DisplayMessage);

            handler(25);
        }

        static void DisplayMessage(object o)
        {
            Console.WriteLine("Function called with: " + o.ToString());

        }

        #endregion

    }
}
