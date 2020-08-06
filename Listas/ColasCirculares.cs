using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class ColasCirculares
    {
        private List<string> lista;
        int ingresados = 0;
        public ColasCirculares()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            //Agrega al final
            lista.Add(dato);
            ingresados++;
        }

        private bool ValidaVacio()
        {   
            //Si no hay elementos en la lista 
            return (lista.Count == 0);
        }

        public void Eliminar()
        {
            
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacía");
            }
            //debe eliminar al principio
            lista.RemoveAt(0);
            //decrementamos el numero de elementos
            ingresados--;
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "Lista Vacía";
            }

            for (int i = 0; i < ingresados; i++)
            {
                if (i==0)
                {
                    Console.WriteLine($"El numero de elementos Ingresados es: {ingresados}");
                }
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {lista[i]}";
            }
            return datos;
        }
    }
}
