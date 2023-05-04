using System;
//Ejercicio 1. Guardar 10 números y mostrar la suma.

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,Numeros,Suma;
            int [] VecNum ;      // declaracion de vector 
            const int VUELTAS=10;
                VecNum = new int [10]; // especificamos tamaño del vector
            for ( i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingresar 10 numeros por favor: ");
                 Numeros = int.Parse(Console.ReadLine());

                 VecNum[i] = Numeros;
            }
                        Suma = 0;           
            for ( i = 0; i < VUELTAS; i++)
            {
                Suma+=VecNum[i];
            }
            Console.WriteLine("La suma de todos los elementos del vector es de :" +Suma);
           
        }
    }
}
