using Arreglos;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pilas pila = new Pilas(5);

                pila.Agregar("cero");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("uno");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("dos");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("tres");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Agregar("cuatro");
                Console.WriteLine(pila.Imprimir());

                //Console.WriteLine("---------");
                //pila.Agregar("cinco");
                //Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine("---------");
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
