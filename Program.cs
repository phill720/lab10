using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Lab10_Common;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Movie List Application!");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine();
            Console.WriteLine("Here is a list of the categories:");
            Console.WriteLine("====================================");
            List<string> cats = Movie.Categories();
            foreach (string item in cats)
            {
                Console.WriteLine(i + ":   " + item);
                i++;
            }
            Console.WriteLine("====================================\n");
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("What category are you interested in? (Choose a number)\t");
            int CatNum = int.Parse(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Movie.GetCategory(CatNum);
        }
    }
}