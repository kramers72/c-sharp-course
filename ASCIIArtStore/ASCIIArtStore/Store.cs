using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtStore
{
    class Store
    {
        //public Inventory Inventory { get; set; }
        private ArtRepository _repo;
        private ShoppingCart _cart;

        public event EventHandler<CheckoutEventArgs> Checkout;
        
        public Store()
        {
            _repo = new ArtRepository();
        }

        public void Begin()
        {
            PrintBanner();

            while (true)
            {
                PrintHeader();
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
            while (true)
            {
                Console.Clear();

                // list the inventory categories
                Console.WriteLine();
                Console.WriteLine("ASCII Art Categories");
                Console.WriteLine();

                foreach (var category in _repo.Categories)
                {
                    Console.Write($"{category.Id}. {category.Description}");
                    Console.Write("     ");
                }

                Console.WriteLine();
                // allow category selection
                Console.Write("Select a category: ");
                int categoryId = int.Parse(Console.ReadLine());
                Console.Clear();

                // display all art in that category
                foreach (var art in _repo.Categories.First(c => c.Id == categoryId).ASCIIArtPieces)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Id: {art.Id}");
                    Console.WriteLine(art);

                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("1. Make purchase.");
                Console.WriteLine("2. Main Menu.");
                Console.Write("Option: ");

                if (Console.ReadLine() == "1")
                {
                    // allow purchase and fire a sale event
                    Console.Write("Select your purchase: ");
                    int artId = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(_repo.Categories.SelectMany(c => c.ASCIIArtPieces).First(a => a.Id == artId));
                    Console.WriteLine("Has been added to your cart. Press Enter to continue shopping.");
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    Console.Clear();
                    return;
                }

            }
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
            Console.Write("Option: ");

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

        private void PrintHeader()
        {
            Console.WriteLine($"ASCII Art 1.0                                               Your Cart {0} items.");
        }


    }
}
