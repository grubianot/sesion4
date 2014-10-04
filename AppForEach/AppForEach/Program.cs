using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector;
            Console.WriteLine("Programa Vector 100");
            Console.WriteLine("Digitar el tañamo del vector");
            int tamanio,contador,contador3=0;
            tamanio = int.Parse(Console.ReadLine());
            vector = new int[tamanio];

            for (contador = 0; contador <= tamanio - 1; contador++)
            {
                Console.WriteLine("Digite el numero");
                vector[contador] = int.Parse(Console.ReadLine());

            }
            foreach (int contador2 in vector)
            {
                Console.WriteLine("El vector es: ");
                Console.WriteLine(contador2);
                if (contador2 > 100)
                {
                    contador3 = contador3 + 1;
                }
            }
            Console.WriteLine("los numero mayores de 100 son: "+contador3);

            Console.ReadKey();
        }
    }
}
