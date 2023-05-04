using System;
// ejemplo de bajo nivel de como funciona un vector tipo char para guardar letras o carcateres

namespace ejemplodeCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            // CADENA DE CARACTERES
           // char[] frase = new char[10];
            // BARRA CERO
            // \0                 // CUANDO TERMINO DE CARGAR MI NOMBRE TENGO QUE TERMINAR CON \0 

            // STRING
            // CADENA DE CARACTERES
            // VECTOR DE CHAR

            // int,float,bool,char,string no
            //char[] nombre = new char[11];

           // char letra;
           // int indice = 0;
            //j = char.Parse(Console.Readline());

          //  Console.WriteLine("Ingrese su nombre letra por letra...(termina con punto)");
            //while (letra != '.' && indice < 10 )
            //{
           // nombre[indice] = letra;                // usamos un while porque si usamos un for el for da todas las vueltas
            // letra = char.Parse(Console.ReadLine()); //del tamaño del vector de char y si el nombre es mas corto nos va a seguir
            // indice++;                              //pidiendo letras y no es correcto.
            
            
            
            //}
          //  if(indice == 10)
          //  {                               // por ejemplo si queremos guardar un nombre con 10 carcteres usamos 11
           //     indice --;                  // poque hay que tener el cuenta el \0 de corte
          //  }
         //   nombre[indice] = '\0';      // con esto hacemos que no muestre el . cuando termine el while
            // | m| a| x| i| \0| | | | |

           // Console.WriteLine("Hola " + nombre);
            
          //  Console.Write("Hola ");
          //  indice = 0;
           // while (nombre[indice] != '\0')
           // {
          //      Console.Write(nombre[indice]);
           //     indice++;                       // para mostrar el vector char
          //  }

                              
            string nombre;                              // todo lo que himcimos aca es todo lo anterior en bajo nivel
            Console.WriteLine("Ingrese su nombre...");
            nombre = Console.ReadLine();                // aca no hace falta usar el .parse porque readline admite string
           Console.WriteLine(" Hola " +nombre);
        }
    }
}
