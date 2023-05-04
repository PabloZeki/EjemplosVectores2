using System;
// Ejercicio 3. Guardar 100 números. Calcular promedio, mostrar los mayores.

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,Numeros;
            double  Acu,Promedio = 0;
            int [] VecNum = new int [100];
            const int VUELTAS = 10;

            for ( i = 0; i < VUELTAS; i++)
            {
                Console.WriteLine("Ingrese numeros por favor: ");
                Numeros = int.Parse(Console.ReadLine());
                                                                    // Carga de un vector
                VecNum[i] = Numeros;

            }
                Acu = 0;
              //  Cont = 1;
            for ( i = 0; i < VUELTAS; i++)
            {
                Acu += VecNum[i];
                
            }   
            
            // Punto A

            Promedio = Acu/i;       // aca podemos usar la i para usarla como contador 
            Console.WriteLine("El promedio del total de numeros del vector es: " +Promedio);

       //punto b mayores al promedio 

            for ( i = 0; i < VUELTAS; i++)
            {                            // Recorremos el vector y preguntamos cuales son mayores al promedio
              if(VecNum[i]>Promedio){

                Console.WriteLine("Los numeros mayores al promedio son: " +VecNum[i]);
              }



            }


          }    
    }
}