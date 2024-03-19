using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Ficheros.C.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuPrincipal()
        {
            Console.WriteLine("[0] -> CERRAR APLICACION");
            Console.WriteLine("[1] -> MODIFICACION DE UNA LINEA");
            Console.WriteLine("[2] -> INSERTAR TEXTO");

            int seleccionMenuUsu = Convert.ToInt32(Console.ReadLine());

            return seleccionMenuUsu;

        }

    }
}
