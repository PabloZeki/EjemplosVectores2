using System;
// Ejercicio 2. Guardar 50 números. Buscar máximo y posición.

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,Numeros,Posicion,NumMaximo;
            int [] VecNum;
            const int VUELTAS = 10;
            VecNum = new int [50];
            for ( i = 0; i < VUELTAS; i++)
            {
                Console.WriteLine("Ingresa 50 numeros: ");
                Numeros = int.Parse(Console.ReadLine());

                VecNum[i] = Numeros;
                
            }
                NumMaximo=VecNum[0];
                Posicion=1;          // En este caso ponemos la iniciamos en 1 porque quizas no vaya nunca para 
                                    // el lado del if y nunca actulize la posicion,por ejemplo si el primer valor 
                                     //es el mayor de todo el vector, en ese caso queda que su posicion va a ser 1.
            for (i = 0; i < VUELTAS; i++)
            {
                if(VecNum[i]>NumMaximo){

                    NumMaximo = VecNum[i];
                    Posicion = i+1;

                }
                
            }

            Console.WriteLine("El numero maximo del vector es: "+NumMaximo + "Y su posicion es: "+Posicion);
            
        }
    }
}
