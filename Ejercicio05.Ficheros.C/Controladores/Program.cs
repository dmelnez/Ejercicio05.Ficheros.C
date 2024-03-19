using Ejercicio05.Ficheros.C.Servicios;

namespace Ejercicio05.Ficheros.C.Controladores
{

    class Program
    {
        static void Main(string[] args)
        {

            MenuInterfaz  me = new MenuImplementacion();


            OperativaInterfaz op = new  OperativaImplementacion();

            bool cerrarAplicacion = false;

            string rutaFichero = "C:\\Users\\dmelnez\\Desktop\\ActividadEjercicioC.txt";

            string[] lineas = File.ReadAllLines(rutaFichero);


            try
            {
                do
                {
                    int seleccionMenu = me.menuPrincipal();

                    switch (seleccionMenu)
                    {
                        case 0:
                            Console.WriteLine("SE CERRARA LA APLICACION");
                            cerrarAplicacion = true;
                            break;

                        case 1:
                            Console.WriteLine("MODIFICACION DE UNA LINEA"); 
                            op.modificacionDeLinea(rutaFichero, lineas);
                            break;

                        case 2:
                            Console.WriteLine("INSERTAR UNA LINEA");
                            op.insertarTexto(rutaFichero, lineas);
                            break;

                        default:
                            break;

                    }
                }

                while (!cerrarAplicacion);

            }

            catch (Exception ex)
            {
                
                Console.WriteLine("[INFO] -> SE HA PORDUCIDO UN ERROR");

            }

        }
    }

}
