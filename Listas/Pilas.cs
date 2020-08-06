using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            //si la lista en su cuenta es cero esta vacia
            return (lista.Count == 0);
        }

        public void Eliminar()
        {
            //siempre se elimina el ultimo insertado por ser pila --lifo
            if (ValidaVacio())
            {
                throw new Exception("lista Vacía");
            }
            lista.RemoveAt(lista.Count-1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return "Lista Vacía";
            }

            int lstCount = lista.Count;

            for (int i = 0; i < lstCount; i++)
            {
                if (i>0)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {lista[i]}";
            }
            return datos;

        }
    }

}
