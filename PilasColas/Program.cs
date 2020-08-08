using Arreglos;
using Listas;
using System;

namespace PilasColas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArregloPilas();
            //ArregloColas();
            //ArregloColasCirculares();
            //ArregloColasDobles();
            //ListaPilas();
            //ListasColas();
            //ListasColasCirculares();
            ListasColasDobles();

        }

        static void ArregloPilas()
        {
            try
            {
                Arreglos.Pilas pila = new Arreglos.Pilas(5);

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

        static void ArregloColas()
        {
            try
            {
                Arreglos.Colas colas = new Arreglos.Colas(5);

                Console.WriteLine(colas.Imprimir());

                colas.Agregar("cero");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("uno");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("dos");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("tres");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("cuatro");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ArregloColasCirculares()
        {
            try
            {
                Arreglos.ColasCirculares colasCirculares = new Arreglos.ColasCirculares(5);

                Console.WriteLine(colasCirculares.Imprimir());

                colasCirculares.Agregar("cero");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("uno");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("dos");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("tres");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("cuatro");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ArregloColasDobles()
        {
            try
            {
                Arreglos.ColasDobles colasdobles = new Arreglos.ColasDobles(5);

                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.AgregarInicio("cero");
                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.AgregarFinal("cuatro");
                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.AgregarInicio("uno");
                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.AgregarFinal("tres");
                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.EliminarFinal();
                Console.WriteLine(colasdobles.Imprimir());

                colasdobles.EliminarInicio();
                Console.WriteLine(colasdobles.Imprimir());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListaPilas()
        {
            try
            {
                Listas.Pilas pila = new Listas.Pilas();

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

        static void ListasColas()
        {
            try
            {
                Listas.Colas colas = new Listas.Colas();

                Console.WriteLine(colas.Imprimir());

                colas.Agregar("cero");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("uno");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("dos");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("tres");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Agregar("cuatro");
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());

                Console.WriteLine("---------");
                colas.Eliminar();
                Console.WriteLine(colas.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListasColasCirculares()
        {
            try
            {
                Listas.ColasCirculares colasCirculares = new Listas.ColasCirculares();

                Console.WriteLine(colasCirculares.Imprimir());

                colasCirculares.Agregar("cero");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("uno");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("dos");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("tres");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Agregar("cuatro");
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());

                Console.WriteLine("---------");
                colasCirculares.Eliminar();
                Console.WriteLine(colasCirculares.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ListasColasDobles()
        {
            try
            {
                Listas.ColasDobles colasDobles = new Listas.ColasDobles();

                colasDobles.AgregarInicio("tres");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.AgregarFinal("cuatro");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.AgregarInicio("dos");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.AgregarFinal("cinco");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.AgregarInicio("uno");
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.EliminarInicio();
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.EliminarFinal();
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.EliminarInicio();
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.EliminarFinal();
                Console.WriteLine(colasDobles.Imprimir());

                Console.WriteLine("---------");
                colasDobles.EliminarInicio();
                Console.WriteLine(colasDobles.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //terminado
    }
}
