using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Contexto())
            {
                //1.	Para todas las categorías nombre de la categoría y número total de multas aplicadas a ejemplares de esa categoría. 
                //ctx.Multas.GroupBy(x => x.Detalle.Ejemplar.Documento.Categoria.Nombre).ToList().ForEach(x => Console.WriteLine("Categoria: " + x.Key + " Multas: " + x.Count()));

                //2.Categoría con mayor número de multas.R / Reserva
                //Console.WriteLine(ctx.Multas.GroupBy(x => x.Detalle.Ejemplar.Documento.Categoria.Nombre).OrderByDescending(x => x.Count()).First().Key);
            }
        }
    }
}
