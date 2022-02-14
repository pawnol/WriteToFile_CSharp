/*
 * Write to File
 * Pawelski
 * 2/13/2022
 * We will discuss this program as part of the notes.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening the file to write to.
            const string FILE_PATH = @"GroceryList.txt";
            FileStream file = new FileStream(FILE_PATH, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            // Prompt the user to enter items to add to the list.
            string item, repeat;
            do
            {
                Console.Write("Enter an item to add to the list >> ");
                item = Console.ReadLine();
                writer.WriteLine(item);
                Console.Write("Do you want to add another item? (Y/N) >> ");
                repeat = Console.ReadLine();
            } while (repeat == "Y");

            // Closes the stream and file.
            writer.Close();
            file.Close();
        }
    }
}
