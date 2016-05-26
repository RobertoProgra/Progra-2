using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
                    
          

      

            String NombreCliente = "";
            String Numerotelefonico = "";
            int codigolibro = 0;
            double preciolibro = 0;
            
            String a = "";
            double descuento = 0;
            double impuesto = 0;
            int cantidad = 0;
            String[] libro = new String[10];
            String[] Listalibro = new String[99];
            double[] Listaprecio = new double[99];
            int validacion = 1;
            double montocompra = 0;
            int contador1 = 0;
            double Total = 0;
            int ValidacionFactura = 0;

            Console.WriteLine("Libreria el Buen Lector");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nuevo cliente");

            NombreCliente = Console.ReadLine();

            Console.WriteLine("Ingrese el numero telefonico");

            Numerotelefonico = Console.ReadLine();


            Console.WriteLine("Seleccione que libro desea agregar al carrito");
            Console.WriteLine("");
            libro[0] = "1 El señor de los anillos ,Las dos torres";
            libro[1] = "2 Alicia en el pais de las maravillas";
            libro[2] = "3 Cementerio de mascotas";
            libro[3] = "4 Quiero aprender";
            libro[4] = "5 El poder del pensamiento positivo";
            libro[5] = "6 Mi primer libro de matematicas";
            libro[6] = "7 Las aventuras de tom sawyer ";
            libro[7] = "8 El mago de OZ ";
            libro[8] = "9 La zona muerta";
            libro[9] = "10 Viaje al centro de la tierra ";

            for (int j = 0; validacion == 1; j++)
            {
                for (int i = 0; i < libro.Length; i++)
                {
                    Console.WriteLine(libro[i]);
                }
                codigolibro = Console.ReadLine();

                System.out.println("Cantidad");
                cantidad = entrada.nextInt();

                Listalibro[j] = libro[codigolibro - 1];
                contador1++;


                preciolibro = (cantidad * ((codigolibro) * 1000));
                Listaprecio[j] = preciolibro;

                montocompra = montocompra + preciolibro;




                System.out.println("Desea agregar otro libro");
                System.out.println("1.Si");
                System.out.println("2.No");

                validacion = entrada.nextInt();
            }
            System.out.println("El monto  de su compra es" + " " + montocompra);
            impuesto = montocompra * 0.13;

            System.out.println("IVA" + " " + impuesto);
            Total = montocompra + impuesto;
            System.out.println("TOTAL" + " " + Total);
            System.out.println("Su compra fue");

            for (int i = 0; i < contador1; i++)
            {

                System.out.println(Listalibro[i]);
            }

            System.out.println("Desea Factura");
            System.out.println("1.si");
            System.out.println("2.no");

            ValidacionFactura = entrada.nextInt();
            if (ValidacionFactura == 1)
            {

                System.out.println(" ");
                System.out.println(" ");
                System.out.println(" ");
                System.out.println(" ");
                System.out.println("========================================");
                System.out.println("*-*     Libreria El Buen Lector      *-*");
                System.out.println("========================================");
                System.out.println("Factura Proforma                 Nº 0001");
                System.out.println("Cliente" + " " + NombreCliente + "                         ");
                System.out.println("Telefono" + " " + Numerotelefonico + "                        ");
                System.out.println("---------------------------------------------");
                System.out.println("                   ITEMS            ");

                for (int i = 0; i < contador1; i++)
                {

                    System.out.println("   " + Listalibro[i]);
                }
                System.out.println("---------------------------------------------");
                System.out.println("Total Orden;" + "                   $" + montocompra);
                System.out.println("Descuento;" + "                     $0.00       ");
                System.out.println("Impuesto de Venta;" + "             $13%       ");
                System.out.println("Impuesto Total;" + "                $" + impuesto);
                System.out.println("Precio Neto;" + "                   $" + Total);
                System.out.println("---------------------------------------------");
                System.out.println("Monto Recibido;        $0.00                 ");
                System.out.println("Monto Cambio;        $0.00                 ");
                System.out.println("========================================");
                System.out.println("Gracias por su compra");






            }


        }
    }
    }
}
