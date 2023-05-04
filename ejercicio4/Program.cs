using System;
// Ejercicio 4. Guardar 20 números. Determinar si está ordenado.

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,Numeros,NumMayor;
            int [] VecNum = new int [20];
            const int VUELTAS = 10;
            bool Ban;

            for ( i = 0; i < VUELTAS; i++)
            {                                              //Carga de vector
                Console.WriteLine("Ingrese 20 numeros por favor: ");
                Numeros = int.Parse(Console.ReadLine());

                VecNum[i] = Numeros;
            }
            NumMayor = VecNum[0];
            Ban = true;

            for ( i = 0; i < VUELTAS; i++)
            {
                if(VecNum[i]>=NumMayor){
                    NumMayor = VecNum[i];
                }else
                {
                    Ban = false;
                }
            }
            if(Ban){
                Console.WriteLine("Estan ordenados");
            }else
            {
                Console.WriteLine("Estan desordenados");
            }

            
        }
    }
}
