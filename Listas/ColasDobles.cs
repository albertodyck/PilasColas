using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class ColasDobles
    {
        private List<string> lista;
        private int ingresados;

        public ColasDobles()
        {
            lista = new List<string>();
            this.ingresados = 0;
        }

        public void AgregarInicio(string dato)
        {
            //Agrega datos string al inicio
            lista.Insert(0,dato);
            ingresados++;
        }

        public void AgregarFinal(string dato)
        {
            //Agrega dato string como siempre al final
            lista.Add(dato);
            ingresados++;
        }

        private bool ValidaVacio()
        {
            return (ingresados==0);
        }

        public void EliminarInicio()
        {
            //elimina al inicio de la cola
            //1valida que no este vacia
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            //Se elimina el primer elemento de la cola
            lista.RemoveAt(0);
            ingresados--;
        }

        public void EliminarFinal() 
        {
            //elimina al final de la cola
            //validar que no este vacia
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacío");
            }
            //Se elimina el ultimo elemento en la cola y se decrementan los elementos
            lista.RemoveAt(lista.Count-1);
            ingresados--;
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "Lista Vacía";
            }
            Console.WriteLine($"El numero de elementos Ingresados es: {ingresados}");
            for (int i = 0; i < lista.Count; i++)
            {
                datos += "\n";
                datos += $"[{i}] - {lista[i]}";
            }
            return datos;
        }
    }
}
