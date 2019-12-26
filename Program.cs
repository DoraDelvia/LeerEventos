using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeerEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Lee archivo 
            string archivo = System.IO.File.ReadAllText(@"C:\Users\dora_\source\repos\LeerEventos\texto.txt");

           
            string[] palabras = archivo.Split(',');
                


            ///Imprime lo que contiene el arreglo.
            foreach (string palabra in palabras)
            {
                Console.WriteLine("Evento: {0}", palabra);


            }

            Console.Write("");
            System.Console.ReadKey();
        }
    }
}
