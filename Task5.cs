using System;
using System.IO;

namespace ConsoleApp6
{
    public static class Task5FileReader
    {
        public static void Run()
        {
            Console.WriteLine("Enter the file path to read:");

            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("File contents:");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: File not found. ({ex.Message})");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: An I/O error occurred. ({ex.Message})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: An unexpected error occurred. ({ex.Message})");
            }
            finally
            {
                Console.WriteLine("File operation complete.");
            }
        }
    }
}
