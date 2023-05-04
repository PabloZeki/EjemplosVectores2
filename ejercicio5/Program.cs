using System;
//Ejercicio 5. Vector de valores Char de 50. Intercambiar caracteres dados la 'A' por la 'E'.
// si se ingresa un '.' se termina la carga de letras del vector (usar while),la palabra
// a reemplzar es ( Hola muchachada como estan),deberia quedar "Hole muchechede como esten"

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letras;
            char [] VecLetras = new char [50];
            int i;
            const int VUELTAS = 50;

            Console.WriteLine("Ingrese letras por favor: ");
            Letras = char.Parse(Console.ReadLine());
            i=0;
            while (Letras!='.'&& i<50)  // menos de 50 para que no se rompa, es el maximo a cargar
            {
                VecLetras[i] = Letras;

                                                        //Carga 
                 Console.WriteLine("Ingrese letras por favor: ");
                Letras = char.Parse(Console.ReadLine());

                i++;
            }

            for ( i = 0; i < VUELTAS; i++)
            {
                if(VecLetras[i]=='a'){          // Reemplazo

                    VecLetras[i]= 'e';
                }
            }

            i=0;

            while (VecLetras[i]!='.')
            {
                    
                 Console.WriteLine("El vector modificado quedo asi: " +VecLetras[i]);   
                    
                    i++;                            // Mostrar . tambien podria usar un for de 50
                                                    // con while solo muestro hasta donde se carga el '.'
            }

        }
    }
}
