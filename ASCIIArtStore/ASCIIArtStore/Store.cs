using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class Store
    {
        public Inventory Inventory { get; set; }

        public void Begin()
        {
            PrintBanner();

            while (true)
            {
                string option = ShowOptions();

                switch (option)
                {
                    case "1":
                        ShowViewInventoryOption();
                        break;
                    case "2":
                        ShowManageInventoryOption();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowViewInventoryOption()
        {
            // list the inventory categories

            // allow category selection

            // display all art in that category

            // allow purchase and fire a sale event
        }

        private void ShowManageInventoryOption()
        {
            // add/remove items

            // update Art: change price, description, category
        }

        private string ShowOptions()
        {
            string option = string.Empty;

            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Manage Inventory");
            option = Console.ReadLine();

            return option;
        }

        private void PrintBanner()
        {
            string banner = @"
      .,:;:;,.
    .:;:;::,;::
    :;'''`' `':'
    ::-(.)-(.):;
    :`    c   ':      
    ::`.  o .':;    
    :;::`~~'::::      
  ..::;: `  ::;:,.    
.'     :    ;     `.  
:       `'''       ;
:   .          .   :
:   : ASCIIART ;   ;
:   ;  RULES!  :   :
:   :          :   :
:   :          :   ;
:...:          :...;
 ::::..........:;;;
    :          :
    :    :     : ";

            Console.WriteLine(banner);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Welcome to the ASCII Art Store!");

            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
