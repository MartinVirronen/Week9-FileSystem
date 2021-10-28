using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\source\repos\Samples\wishlist";
            Console.WriteLine("Enter file name:");
            string filename = Console.ReadLine();
            string FullFilePath = $@"{rootDirectory}\{filename}.txt";

            bool directoryExist = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(FullFilePath);

            if (directoryExist && fileExists)
            {
                Console.WriteLine($"File {filename} already exist in {rootDirectory}.");

            }
            else if (directoryExist)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(FullFilePath);

                
                

            }
            else
            {
                File.Exists(rootDirectory);
                Console.WriteLine($"File {filename}.txt has been created.");
            }

           
            

            
        }
    }
}
