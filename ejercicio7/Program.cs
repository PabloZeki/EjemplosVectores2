using System;
//Registros de ventas. Lote y puntos a, b y c. son 15 articulos para cada articulo cantidad de ventas sin especificar
// termina la carga con un numero de articulo = 0.
//punto a) Numero de articulo que mas se vendio
// punto b) Numeros de articulos que no registraron ventas
// punto c) Mostrar las ventas del articulo numero 10 

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,NumArticulo,CanVentas,Art,NumArtMax;
            const int VUELTAS = 15;
            int [] VecAcu = new int [15];

            for ( i = 0; i < VUELTAS; i++)
            {
                VecAcu[i] = 0 ;             // inicializamos los 15 acumuladores en 0 
            }

            Console.WriteLine("Ingrese Numero de articulo por favor: ");
            NumArticulo = int.Parse(Console.ReadLine());
           
           
            while (NumArticulo!=0)
            
            {
                Console.WriteLine("Ingrese Cantidad de articulos vendidos: ");
                 CanVentas = int.Parse(Console.ReadLine());

                VecAcu[NumArticulo-1]+=CanVentas; // con esto -1 guardamos en el lugar correspondiente en el
                                                    // vector, por ej si se ingresa un 10 de numero de articulo
                                                    // se debe guardar en el espacio 9 del vector.
            

               Console.WriteLine("Ingrese Numero de articulo por favor: ");
            NumArticulo = int.Parse(Console.ReadLine());
                                               
            }

            Console.WriteLine("Las ventas del articulo 10 son: " +VecAcu[9]); //punto c

            for ( i = 0; i < VUELTAS; i++)
            {
                if(VecAcu[i]==0){
                                            //punto b  
                    Console.WriteLine("Los articulos que no registraron ventas son: " + (i+1));
                }
                
            }
                NumArtMax = VecAcu[0];    // articulo se arranca en 1 porque no sabemos si el primer numero
                Art = 1;                    // va a ser el maximo y nunca entra por el if y marcaria 0,osea
                                            // si el primer numero es el maximo mostraria el 1 
            for ( i = 0; i < VUELTAS; i++)
            {
                if(VecAcu[i]>NumArtMax){

                    NumArtMax = VecAcu[i];
                    Art = i+1;
                }
                
            }

            Console.WriteLine("El numero de articulo que mas ventas tuvo fue el " + Art + " Con un total de ventas de: " +NumArtMax);


        }
    }
}
