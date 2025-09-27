// Desarrollar un programa que permita ingresar un vector de 8 elementos e informe:
// El valor acumulado de todos los elementos del vector.
// El valor acumulado de los elementos del vector que sean mayores a 36.
// Cantidad de valores mayores a 50.

using System;

namespace ocho_elementos_array
{
    class ocho_elementos_array
    {
        private int[] vector;
        private int suma;
        private int mayor36;
        private int mayor50;

        public void Cargar()
        {
            vector = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Ingrese un nuemro entero {i+1}: ");
                vector[i] = int.Parse(Console.ReadLine());

            }
        }

        public void Suma()
        {
            for (int j = 0; j < 8; j++)
            {
                suma = suma + vector[j];

            }
            Console.WriteLine($"El valor acumulado es: {suma}");
        }

        public void Mayor()
        {
            for (int k = 0; k < 8; k++)
            {
                if (vector[k] > 36 && vector[k] < 50)
                {
                    mayor36 = mayor36 + 1;

                }
                else if (vector[k] > 50)
                {
                    mayor50 = mayor50 + 1;
                }

            }
            Console.WriteLine($"Hay {mayor36} mayor a 36 y menor a 50");
            Console.WriteLine($"Hay {mayor50} mayores a 50");
        }

        static void Main(string[] args)
        {
            ocho_elementos_array pv = new ocho_elementos_array();
            pv.Cargar();
            pv.Suma();
            pv.Mayor();
        }
    }
}