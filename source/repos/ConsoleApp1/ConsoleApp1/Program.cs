using System;
using System.Linq;
using System.Collections.Generic;

    public class Program
    {
        //Para el ejercicio del año bisiesto
        /*class Comparador : IEqualityComparer<int> {
            public bool Equals(int año, int mes) {
                if (mes == 2)
                    return año % 4 == 0 && (año % 100 != 0 || año % 400 == 0);
                else return false; 
            }

            public int GetHashCode(int obj) {
                return obj.GetHashCode();
            }
        }
        */
        public static void Main()
    {
        //Ternas pitagóricas
        //Enumerable.Range(2,10).ToList().ForEach(n => Console.Write(2*n+" "+((n*n)-1)+" "+(n*n+1)+", "));

        //Fibonacci
        //int uno = 0;
        //int dos = 1;
        //Enumerable.Repeat(0, 16).Select(j => { j = uno + dos; dos = uno; uno = j; return uno; }).Where(i => i % 2 == 1).ToList().ForEach(k => Console.WriteLine(k));
        //Enumerable.Repeat(0, 12).Select(j => { j = uno + dos; dos = uno; uno = j ;return uno;}).ToList().ForEach(i => Console.WriteLine(i));

        //En el siguiente conjunto alguno de los nombres empieza por C?.
        //List<string> nombres = new List<string> { "Jesus", "Maria", "Julia", "Cardona" };
        //Console.WriteLine(nombres.Any(i => i.StartsWith("C")));		

        //Escriba un programa que indique si todos los nombres tienen cinco caracteres. 
        //List<string> names = new List<string> { "Jesus", "Maria", "Julia", "Marta" };
        //Console.WriteLine(names.All(i => i.Length == 5));

        //Escriba un programa que pida el número del mes del año y el año y retorne el número de días de ese mes. Abril, junio, septiembre
        //y noviembre tienen 30 días, los demás 31 excepto febrero que tiene 29 si el año es bisiesto. Un año es bisiesto si es divisible por 400, 
        //o es divisible por 4 pero no por 100. 
        /*int[] de30 = { 4, 6, 9, 11 }, de31 = { 1, 3, 5, 7, 8, 10, 12 };
        Console.WriteLine("Introduzca el mes del año (en números)");
        int mes = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el año");
        int año = Int32.Parse(Console.ReadLine());
        Comparador p = new Comparador();
        Console.WriteLine(de30.Contains(mes) ? "30" : de31.Contains(mes) ? "31" : p.Equals(año, mes) ? "29" : "28");
        */

        //Saber si una palabra es palíndroma o no
        /*
        Console.WriteLine("Ingrese la palabra que desea conocer si es palíndroma o no");
        string palabra = Console.ReadLine();
        Console.WriteLine(Enumerable.SequenceEqual(palabra.ToCharArray(), palabra.ToCharArray().Reverse()));
        */

        //Genere e imprima los números naturales entre 100 y 999 que sean iguales leídos de izquierda a derecha y de derecha a izquierda. 
        //Por ejemplo: 101, 111, 121,….., 979, 989, 999.
        /*
        int n = 100;
        var num = Enumerable.Repeat(100,900).Select(i => n = n + 1).Where(i => i.ToString().SequenceEqual(i.ToString().Reverse()));
        num.ToList().ForEach(z => Console.WriteLine(z));
        */

        //Generar núemros aleatorios de un millón mayores que 50 (contarlos)
        /*var num = new Random();
        Console.WriteLine(Enumerable.Range(0,1000000).Select(j => num.Next(1,100)).Count(n => n > 50));*/

        //Ejercicio: Indique en el siguiente conjunto cuántos nombres empiezan con A.
        /*string[] nombres = { "Mafalda", "Silvestre", "Paco", "Carlitos", "Luis", "James" };
        Console.WriteLine(nombres.Count(j => j.StartsWith("A")));*/

        //Ejercicio: Imprima el número de caracteres de la palabra más larga del siguiente arreglo de palabras.
        /*string[] p = { "Mafalda", "Silvestre", "Paco", "Carlitos", "Luis", "James" };
        Console.WriteLine(p.Max(n => n.Length));*/

        //Ejercicio: En el siguiente conjunto cuántos números están por encima del promedio.
        /*int[] números = { 5, 3, 8, 4, 5, 9, 6, 8, 1, 8, 4, 3, 5, 4, 3, 2, 1, 9, 3, 4, 7, 1 };
        double ave = números.Average();
        Console.WriteLine(números.Count(i => ave < i));
        */

        //Ejercicio: En el ejercicio anterior cuál es el promedio de los menores o iguales a siete. 
        /*int[] números = { 5, 3, 8, 4, 5, 9, 6, 8, 1, 8, 4, 3, 5, 4, 3, 2, 1, 9, 3, 4, 7, 1 };
        double ave = números.Average();
        Console.WriteLine();
        */

        //Ejercicio: En el ejercicio anterior cuál es el promedio de los menores o iguales a siete. 
        //int[] números = { 5, 3, 8, 4, 5, 9, 6, 8, 1, 8, 4, 3, 5, 4, 3, 2, 1, 9, 3, 4, 7, 1 };
        //Console.WriteLine(números.Where(i => i <=7).Average());

        //Ejercicio: En el siguiente conjunto cual es el promedio de los cuadrados de los números
        //int[] numeros = { 5, 3, 8, 4, 5, 9, 6, 8, 1, 8, 4, 3, 5, 4, 3, 2, 1, 9, 3, 4, 7, 1 };
        //Console.WriteLine(numeros.Average(n => Math.Pow(n, 2)));


        //Ejercicios. Escriba un programa que:

        //1.	Genere, calcule e imprima la sumatoria de los 10 primeros términos de la serie   Y = ∑ (K2 + 1) / K      para K = 1 hasta K = 10 		R/ 57.928968…
        //Console.WriteLine(Enumerable.Range(1, 10).Sum(n => (Math.Pow(n, 2) + 1) / n));

        //2.	Genere y sume los enteros pares positivos entre un entero positivo (>= 0 y <= 10) digitado por el usuario y el número 10. La suma debe contener 
        //el entero par inicial y el número 10.
        /*Console.WriteLine("Escriba un número entre 0 y 10");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(Enumerable.Range(numero, 11 - numero).Where(n => n % 2 == 0).Sum());*/

        //3.	Pida un entero mayor que cero y calcule su cuadrado utilizando el siguiente método: El cuadrado de un entero mayor que cero se puede obtener al 
        //sumar tantos números impares como indique el número empezando en 1. Por ejemplo, el cuadrado de 1 es 1, el cuadrado de 2 es 1 + 3, el cuadrado de
        //3 es 1 + 3 + 5, el cuadrado de 4 es 1 + 3 + 5 + 7, etc. 
        /*Console.WriteLine("Escriba un número mayor que cero");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(Enumerable.Range(1, numero).Sum(n => 2*n - 1));*/

        //Genere la secuencia de enteros entre 1 y 9 y en una sola consulta encuentre e imprima los números divisibles solo por dos, los divisibles solo por tres, los divisibles por dos y por tres y los no divisibles ni por dos ni por tres. 
        //Ni por dos ni por tres: 1 5 7 Solo por dos: 2 4 8 Solo por tres: 3 9 Por dos y por tres: 6

        //Encuentre e imprima la nota dominante del arreglo de notas. El elemento dominante es el que se repite en más del 50 % de las posiciones del arreglo.  notas = { 3.5, 4, 3.5, 2, 3.5, 5, 3.5, 3.5, 1}
        //double[] notas = { 3.5, 4, 3.5, 2, 3.5, 5, 3.5, 3.5, 1 };
        /*int[] notas = { 5, 3, 8, 4, 5, 9, 6, 8, 1, 8, 4, 3, 5, 4, 3, 2, 1, 9, 3, 4, 7, 1 };
        var a = notas.GroupBy(n => n);
        foreach(int e in notas)
        {
            Console.Write(e);
        }*/



        //Escriba un programa que calcule el promedio del semestre de un estudiante dadas las calificaciones de las seis materias que cursó durante el semestre y sus correspondientes créditos. Utilice los siguientes arreglos. notas = { 2.8, 3.9, 4.2, 3.6, 2.7, 4.1 } 	créditos = { 2, 3, 4, 3, 3, 2 }	R/ 3.6
        /*double[] notas = { 2.8, 3.9, 4.2, 3.6, 2.7, 4.1 };
        int[] créditos = { 2, 3, 4, 3, 3, 2 };
        Console.Write(notas.Zip(créditos, (a, b) => a * b).Sum() / créditos.Sum());
        */

        //String p = "perro";
        //Console.WriteLine(p.Split(' ').Aggregate((a, b) => b + a));

        int n = 145;

        Console.WriteLine(n);

    }

}
