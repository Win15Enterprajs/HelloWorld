using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAgain
{
    class Program
    {
        public static void Snow() //// LET IT SNOW!
        {
            Board board = new Board();
            do
            {
                Board arr = new Board();
                int[,] boardArr = new int[20, 20];
                boardArr = arr.addValues(boardArr);
                arr.printArr(boardArr);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.Clear();
            } while (true);
        }
        static void Main(string[] args)
        {
            // Adding a line for the Hello world program
            Console.WriteLine("Hello world");
        }
    }
}
