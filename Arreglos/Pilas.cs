using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;
        //constructor
        public Pilas(int tamanio)
        {
            //this hace referencia a lo escrito dentro de la clase
            this.array = new string[tamanio];
            this.tope = 0;
            this.max = array.Length - 1;
        }

        //validar arreglo no vacio

        private bool ValidaVacio()
        {
            return (tope < 1);//Si tope en menor que uno es verdadero
        }

        private bool ValidaLLeno()
        {
            return (tope > max);
        }
        //requiere invocarse desde program
        public void Agregar(string dato)
        {
            if (ValidaLLeno())
            {
                throw new Exception("Arreglo LLeno");
            }
            array[tope] = dato;
            tope++;
        }
        //no recibe parametro dado que la regla de pilas elimina el ultimo ingresado
        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            tope--;
            array[tope] = null;//nullo es diferente de vacio
        }
        
        //no recibe parametro pero si regresa un string
        public string Imprimir()
        {
            string dato = string.Empty;

            if (ValidaVacio())
            {
                return "Arreglo Vacío";
            }

            for (int i = 0; i < tope; i++)
            {
                if (i>0)
                {
                    dato += "\n";
                }
                dato += $"[{i}]-{array[i]}";
            }
            return dato;
        }
    }
}
