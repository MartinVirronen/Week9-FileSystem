using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywhishes = new List<string>();
            mywhishes.Add("new crocs");
            mywhishes.Add("new umbrella");
            mywhishes.Add("new coffe mug");

            //Console.WriteLine($"There are {mywhishes.Count} item on your wish list.");


            //Console.WriteLine(mywhishes[0]);
            //onsole.WriteLine(mywhishes[mywhishes.Count - 1]);

            foreach (string wish in mywhishes)
            {
                Console.WriteLine($"Item o your wish list {wish}:");
            }
            Console.WriteLine();

            Console.WriteLine("Enter a wish");
            string userWish = Console.ReadLine();

            mywhishes.Add(userWish);

            
        }
    }
}
