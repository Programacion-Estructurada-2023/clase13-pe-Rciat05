using System;       //Roberto Carlos Iglesias U20230727

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //For //Foreach


            //Caso simple "for"

            for(int i = 0; i < 10; i++) //i++ = cada que se recorre el ciclo y se aumenta el uno
            {

            Console.WriteLine($"El número {i}");

            } //Fin for

            //Declarar una tabla de multiplicar
            
            Console.WriteLine("\nIngrese un numero para elaborar la tabla de multiplicar: ");
            int numero =Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 10; i++){

            int multiplicacion = numero * i; 
            Console.WriteLine($"{numero} x {i} = {multiplicacion} " );
            }

            Console.ReadKey(); 

            //Foreach

            //Declarar una lista.

            List<int> numeros = new List<int> {
                24,10,8,35,14,7
            };

            int minimo = numeros[0];        //Inicializar un valor del indice 0.


        

            foreach (int numeroMinimo in numeros)
            {

                if (numeroMinimo < minimo)
                {
                    minimo = numeroMinimo; 
                }

            }

            Console.WriteLine("El numero más pequeño en la lista es >>>" + minimo);
            //Valores por iteraciones 
            //1 numero valdria 24 minimo 24 comparamos minimo 24
            //2 numero = 10 minimo 10 comparamos minimo = 10
            //3 numero = 8 minimo 8 comparamos minimo = 8
            //4 numero = 35 minimo 8 
            //5 numero = 14 minimo 8
            //6 numero = 26 

            Console.ReadKey();
        }
    }
}