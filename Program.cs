using System;
using System.Collections.Generic;

namespace SeguridadTipos
{
    internal class Program
    {

        //Crear clase

        public class usuario
        {
            int id { get; set; }

            string nombre { get; set; } 
        }
        static void Main(string[] args)
        {
            //Colección no Genérica ArrayList
            /*ArrayList objectos = new ArrayList();

            objectos.Add(1);
            objectos.Add("Angel Arias");
            objectos.Add(new usuario());


            foreach (int i in objectos)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();*/


            //Colección Genérica List<T>

            List<int> objectos = new List<int>();

            objectos.Add(1);
            objectos.Add(2);
            objectos.Add(3);

            foreach (int i in objectos )
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();    

        }
    }
}
