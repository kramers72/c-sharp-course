using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] board = new string[4][];
            IntializeBoard(board);
            RandomizeBoard(board);

            Console.WriteLine("Welcome to simple battleship. Select a choice below:");


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Attempt to sink the ship.");
                Console.WriteLine("2. Display board.");
                Console.WriteLine("3. Reveal board");
                Console.WriteLine("4. Exit game.");

                Console.WriteLine();
                Console.Write("Choice: ");

                object choice = Console.ReadLine();

                switch (choice)
                {
                    case string n when n == "1":

                        Console.WriteLine("You have three tries to find the ship. Enter a column and row:");
                        GetCoordinates(board);

                        break;
                    case string n when n == "2":
                        PrintBoard(board);
                        break;
                    case string n when n == "3":
                        RevealBoard(board);
                        break;
                    default:

                        return;
                }


            }
        }

        private static void GetCoordinates(string[][] board)
        {
            Console.WriteLine();
            int i = 0;
            int j = 0;
            string column;
            string row;
            int tries = 3;

            while (tries > 0)
            {

                while (true)
                {
                    Console.Write("Enter column: ");
                    column = Console.ReadLine();

                    switch (column)
                    {
                        case "A":
                            j = 0;
                            break;
                        case "B":
                            j = 1;
                            break;
                        case "C":
                            j = 2;
                            break;
                        case "D":
                            j = 3;
                            break;
                        default:
                            Console.WriteLine("Enter a valid column");
                            continue;

                    }

                    Console.Write("Enter row: ");
                    row = Console.ReadLine();

                    if (!int.TryParse(row, out i))
                    {
                        Console.WriteLine("Enter a valid row.");
                        continue;
                    }

                    i--;

                    break;
                }

                if (board[i][j] == "~")
                {
                    Console.WriteLine();
                    Console.WriteLine("Congrats you win!".ToUpper());
                    Console.WriteLine();
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Column: {column} Row: {row} is a miss.".ToUpper());
                    Console.WriteLine();
                    tries--;
                    Console.WriteLine($"You have {tries} left.");
                }
            }

            Console.WriteLine("Sorry. You're out of tries.");
        }

        public static void PrintBoard(string[][] board)
        {
            Console.WriteLine("   A B C D");
            Console.WriteLine("  ---------");
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(i + 1);
                Console.Write(" ");
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write($"| ");
                }

                Console.WriteLine("|");
                Console.WriteLine("  ---------");
            }
            //            Console.WriteLine("---------");
        }

        public static void RevealBoard(string[][] board)
        {
            Console.WriteLine("   A B C D");
            Console.WriteLine("  ---------");
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(i + 1);
                Console.Write(" ");
                for (int j = 0; j < board[i].Length; j++)
                {
                    Console.Write($"|{board[i][j]}");
                }

                Console.WriteLine("|");
                Console.WriteLine("  ---------");
            }
            //            Console.WriteLine("---------");
        }

        public static void IntializeBoard(string[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new string[4];

                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = " ";
                }
            }

        }

        public static void RandomizeBoard(string[][] board)
        {
            Random rand = new Random(DateTime.Now.Second);

            int randomRow1 = rand.Next(board[0].Length);
            int randomCol1 = 0;

            //int randomRow2 = rand.Next(board[0].Length);
            //int randomCol2 = rand.Next(board[0][1].Length);

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = new string[4];
                randomCol1 = rand.Next(board[0].Length);

                for (int j = 0; j < board[i].Length; j++)
                {
                    if (i == randomRow1 && j == randomCol1)
                    {
                        board[i][j] = "~";
                    }
                    else
                    {
                        board[i][j] = " ";

                    }
                }
            }

        }
    }
}
