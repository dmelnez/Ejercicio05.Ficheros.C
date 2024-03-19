using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Ficheros.C.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void modificacionDeLinea(string rutaFichero, string[] lineas)
        {

            Console.WriteLine("INTRODUZA EL NUMERO DE LINEA");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TEXTO A REEMPLAZAR");
            string textoAReemplazar = Console.ReadLine();

            lineas[numeroLinea - 1] = textoAReemplazar;

            File.WriteAllLines(rutaFichero, lineas);


        }


        public void insertarTexto(string rutaFichero, string[] lineas)
        {
            Console.WriteLine("INTRODUZA EL NUMERO DE LINEA");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INTRODUZA LA POSICION DE LA LINEA");
            int posicionLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TEXTO A REEMPLAZAR");
            string textoAReemplazar = Console.ReadLine();


            string lineaReemplazada = lineas[numeroLinea - 1].Insert(posicionLinea, textoAReemplazar);

            lineas[numeroLinea -1] = lineaReemplazada;

            File.WriteAllLines(rutaFichero, lineas);

        }



    }
}
