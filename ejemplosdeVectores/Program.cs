using System;
    // ejemplo con vectores para registrar la tempartura a la mañana,tarde y noche de los 31 dias del mes
    // por ejemplo si el programa nos pide ingresar dias junto con temperaturas
namespace ejemplosdeVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //int (long,short)            // ejemplo de tipo de datos
            //float - double - decimal


            int Dia;
            double Temperatura;
            double[] muestraMatutina = new double [31];
            double[] muestraVespertina = new double [31];  // vectores para guardar las 3 temperaturas
            double[] muestraNocturna = new double [31];

            // Carga
            // Registro matutino
            Console.WriteLine("Cargue el resgistro Matutino: ");
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Ingrese dia: ");
                Dia = int.Parse (Console.ReadLine());      // aca podemos usar el dia como indice porque sabemos que 
                Console.WriteLine("Ingrese Temperatura:"); // van del 1 al 31,porque no usamos la x? porque no sabemos
                Temperatura = double.Parse(Console.ReadLine()); // si la carga de dias esta ordenada del 1,2,3... de esta
                                                               // forma en la carga ya lo dejamos ordenado al vector                     
                
                 muestraMatutina[Dia-1] = Temperatura;  // dia-1 porque el vector arranca de 0 en adelante 

                
            }

            for (int i = 0; i < 31; i++)
            {
                // aca cargamos el vector de vespertino con indice dia -1 tmb
            }

            for (int i = 0; i < 31; i++)
            {
                // aca cargamos el vector nocturno con indice tmb dia - 1 
            }

            // leer vectores
            double acu =0;
            for (int i = 0; i < 31; i++)
            {
                acu+= muestraMatutina[i];   // aca ya puedo usar la i como indice porque los datos ya me
            }                                // quedaron ordenados en la carga


            double[] sueldos = new double[50];
            int[] legajos = new double[50];    // aca no se puede usar el legajo como indice,porque no tienen
                                             // relacion los numeros con los sueldos,los legajos pueden estar
                                               // guardados en cualquier lugar del vector ahi si usamos i
                for (int i = 0; i < 50; i++)
                {
                    sueldos[i] = 123;  // van a cargarse parejo en la primera vuelta por ejemplo [0]
                    legajos[i] = 456;    // el sueldo y el legajo van a cargarse en la misma posicion de cada vector
                }


                // ejemplos de vectores de bool
                bool[] asistenciasQuincena1 = new bool [15];
                for (int i = 0; i < 15; i++)
                {
                    // dia.
                    // asistencia. como el ejemplo de arriba, con el vector bool me tira true o false,la persona asistio o no
                }

                bool[] asistencia = new bool [100];
                bool[] legajos = new bool [100];

                for (int i = 0; i < 100; i++)
                {
                    // carga vectores

                    asistencia[i] = asistencia;
                    legajos[i] = legajos;        // aca como el ejemplo segundo no tiene relacion el legajo con la 
                }                               // asistencia por eso usamos la x para los 2 vectores 

        }
    }
}
