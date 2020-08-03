using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class ColasDobles
    {
        private string[] array;
        private int max;
        private int inicio;
        private int final;
        private int ingresados;

        public ColasDobles(int tamanio)
        {
            this.array = new string[tamanio];
            this.max = tamanio;
            this.inicio = 0;
            this.final = 0;
            this.ingresados = 0;

        }

        private bool ValidaVacio()
        {
            return (inicio == final);
        }

        private bool ValidaLleno()
        {
            return (ingresados == max);
        }

        public void AgregarInicio(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            //calculamos posicion donde guardaremos
            array[inicio] = dato;
            inicio++;
            ingresados++;
            if (final==0)
            {
                final = max;
            }
        }

        public void AgregarFinal(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            if (final == 0)
            {
                final = max;
            }
            else
            {
                final--;
            }
            array[final] = dato;
            ingresados++;
        }

        public void EliminarFinal()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[final] = null;
            if (final==max-1)
            {
                final = 0;
            }
            else if (inicio == final)
            {
                inicio = final = 0;
            }
            final++;
        }

        public void EliminarInicio()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[inicio-1] = null;
            inicio--;
            //if (inicio==final)
            //{
            //    inicio = final = 0;
            //}
            //else if (final == max - 1)
            //{
            //    final = 0;
            //}

        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return ("Arreglo Vacío");
            }

            for (int i = 0; i < max; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }

    }
}
