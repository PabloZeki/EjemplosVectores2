using System;
 // Ordenar Vector de manera decreciente,y mostrar la pocision original,utilizando metodo burbuja

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,x,Numeros,Auxi;
            const int VUELTAS=20;
            int [] VecNum = new int [20];
            int [] VecPos = new int [20];

            for ( i = 0; i < VUELTAS; i++)
            {
                 Console.WriteLine("Ingrese numeros por favor: ");
                 Numeros = int.Parse(Console.ReadLine());
                  
                 VecNum[i]= Numeros;                                               //carga del vector

            }

            for ( i = 0; i < VUELTAS; i++)
            {
                VecPos[i] = i+1;  
                                            // este vector me va a guardar las posiciones originales
            }
                
                          
                for( x = 0; x < VUELTAS; x++)
                {


            for ( i = 0; i < 19; i++)  // aca da 19 vueltas si llega a la vuelta 20 se rompe,porque va comparando
                                       // todo el tiempo con el de al lado.
            {
                if(VecNum[i]<VecNum[i+1]){

                Auxi = VecNum[i+1];
                VecNum[i+1] = VecNum[i];        // lo que hacemos es preguntar si el elemento que esta al lado en el
                VecNum[i] = Auxi;             // vector es mas chico,si es asi hacemos un enroque,cambio la poscion
                Auxi = VecPos[i+1];          // de derecha a izquierda asi se van ordenando los numeros de mayor a
                 VecPos[i+1] = VecPos[i];     // menor,usamos una variable auxiliar para guardar temporalmente el numero
                VecPos[i] = Auxi;            // que teniamos en la pocision para luego hacer el cambio.
               
                   
                  }             

            }


                }

                for ( i = 0; i < VUELTAS; i++)
                {
                    Console.WriteLine("El vector ordenado de meyor a menor quedo de esta forma: " +VecNum[i] + " y la posiscion original de los elementos es: " +VecPos[i]);
                    
                }
           
        }
    }
}
