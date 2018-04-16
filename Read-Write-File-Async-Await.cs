using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; 
using System.Threading.Tasks; 

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new System.IO.FileStream("./MyFile.bin", FileMode.OpenOrCreate);
            Console.WriteLine("Before Process");
            ProcessFileAsync(file);
            file.Close();
            Console.WriteLine("After Process");
            Console.ReadLine();
        }
        //This function open a new Thread when is launched
        private static async void ProcessFileAsync(FileStream file)
        {
            var message = "Hello World";
            var bytes = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < 1000; i++)
            {
                
                await file.WriteAsync(bytes, 0, bytes.Length);
                Console.WriteLine("Async Process finished");
            }
        }
    }
}
