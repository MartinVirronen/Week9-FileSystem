using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\source\repos\Samples";
            Console.WriteLine("Enter Directory name:");
            string userDirectory = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            bool directoryExists = Directory.Exists(newDirectoryFullPath);


            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exist in {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userDirectory} has been created.");
            }


        }
    }
}