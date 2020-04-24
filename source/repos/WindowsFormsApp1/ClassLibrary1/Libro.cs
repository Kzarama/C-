using System;

namespace BibliotecaIcesi
{
    public class Libro
    {

        private Double peso;

        public Libro(double peso)
        {
            this.peso = peso;
        }

        public double Peso { get => peso; set => peso = value; }

    }
}
