using System; //OS
using System.Collections.Generic; //Nose Bro diskulpa :v
using System.IO;
using System.Linq; //Nose Bro diskulpa :v x2
using System.Text; //Supongo que para escribir texto en consola
using System.Threading.Tasks; // Para manejar Hilos 2.0 :D

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new System.IO.FileStream("./MyFile.bin", FileMode.OpenOrCreate);
            Console.WriteLine("Antes de Procesar");
            ProcessFile(file);
            file.Close();
            Console.WriteLine("Después de Procesar");
            Console.ReadLine();
        }

        private static void ProcessFile(FileStream file)
        {
            var message = "Hello World";
            var bytes = Encoding.UTF8.GetBytes(message);
            for (int i = 0; i < 1000; i++)
            {
                file.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
