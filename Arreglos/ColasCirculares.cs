using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class ColasCirculares
    {
        private string[] array;
        private int max;
        private int inicio;
        private int ingresados;

        public ColasCirculares(int tamanio)
        {
            this.array = new string[tamanio];
            this.max = tamanio;
            this.inicio = 0;
            this.ingresados = 0;

        }

        private bool ValidaVacio()
        {
            return (inicio == ingresados);
        }

        private bool ValidaLleno()
        {
            return (ingresados == max);
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }

            //calculamos posicion donde guardaremos
            array[(inicio + ingresados) % max] = dato;
            ingresados++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            //Se elimina el primer elemento de la cola
            array[inicio] = null;

            //se calcula la nueva posicion inicial
            inicio = (inicio + 1) % max;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return ("Arreglo Vacío");
            }

            for (int i = inicio; i < max; i++)
            {
                if (i > inicio)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }

    }
}
