using System;
// Ejercicio 6. Guardar 10 números y buscar repetidos.

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,x,Numeros,Repetidos,Cont;
            int [] VecNum = new int [10];
            const int VUELTAS = 10;
            bool Ban;

            for ( i = 0; i < VUELTAS; i++)
            {
                Console.WriteLine("Ingrese numeros por favor: ");
                Numeros = int.Parse(Console.ReadLine());

                VecNum[i] = Numeros;
            }

            Ban=false;

            for ( i= 0; i < VUELTAS; i++)       //usamos 2 for para comparar si hay elementos que se repiten
                                            //cada vuelta del for grande se guarda en la variable repetidos
                                            //y compara con el valor actualizado.
            {
                    Repetidos = VecNum[i];
                    Cont = 0;

                    for ( x = 0; x < VUELTAS; x++)
                    {
                        if(Repetidos==VecNum[x]){
                                                    // aca hay que preguntar por el vector en x porque sino
                                                    // nos toma el mismo indice que el for i grande.
                            Cont++;
                        }



                    }
                    
                        if(Cont>=2){  // aca el contador va a dar 1 si o si en la priemra vuelta,por eso preguntamos
                                    // a partir del segundo repetido o mas que tenga..minimo 2 repetidos que haya
                                    // es suficiente para admitir que hay repetidos

                            Ban=true;
                        }


            }




                if(Ban){

                    Console.WriteLine("Hay repetidos");
                }else
                {
                Console.WriteLine("No hay repetidos");
                }

            
        }
    }
}
