using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0, valor=0;
            Console.WriteLine("Programa que suma valores");
            do
            {

                if (valor == 9999)
                {
                    break;
                }
                else
                {
                    suma = suma + valor;

                }

                 Console.WriteLine("Digite valor: ");
                valor=int.Parse(Console.ReadLine());
             
            }
            while(valor!=9999);
            Console.WriteLine("el valor acumulado es: "+ suma);

            if (suma == 0)
            {
                   Console.WriteLine("el avalor acumulado esigual a cero ");
        

            }
            else if(suma>0)
            {
                   Console.WriteLine("el  valoracumulado es mayor a cero");
            }
                else
                {
                       Console.WriteLine("el valor acumulado es menor");
            
                }
                Console.ReadKey();
        }
           
    }

    }
