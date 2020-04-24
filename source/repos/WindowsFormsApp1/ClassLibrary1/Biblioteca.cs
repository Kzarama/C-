using BibliotecaIcesi;
using System;
using System.Collections;

namespace ClassLibrary1
{
    public class Biblioteca
    {

        private ArrayList ar;
        private Libro libro;
        private Double pesosTotales;

        public Biblioteca()
        {
            ar = new ArrayList();
            pesosTotales = 0;
        }

        public void agregarLibro(Double peso)
        {
            libro = new Libro(peso);
            ar.Add(libro);
            pesosTotales += peso;
        }

        public Double pesos()
        {
            return pesosTotales;
        }

        public double darPesosLibros()
        {
            Double pesos = 0;
            foreach(Double obj in ar)
            {
                pesos += obj;
            }
            return pesos;
        }

    }
}
