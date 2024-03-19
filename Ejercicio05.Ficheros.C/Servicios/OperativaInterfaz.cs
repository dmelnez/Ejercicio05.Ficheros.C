using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Ficheros.C.Servicios
{
    internal interface OperativaInterfaz
    {
        public void modificacionDeLinea(string rutaFichero, string[] lineas);
        public void insertarTexto(string rutaFichero, string[] lineas);


    }
}
