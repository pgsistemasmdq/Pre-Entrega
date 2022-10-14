
namespace PROYECTO_FINAL
{
    using System.Collections.Generic;
    using PROYECTO_FINAL.Handlers;
    using PROYECTO_FINAL.Modelos;
    using static Program;
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            Console.WriteLine("--= TRAER USUARIO =--");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese el Usuario a buscar : ");
            entrada =  Console.ReadLine();
            if (!string.IsNullOrEmpty(entrada))
            {
                UsuarioHandler usu = new UsuarioHandler();
                Usuario usuario = usu.TraerUsuario(entrada);
                if (!string.IsNullOrEmpty(usuario.Apellido))
                {
                    Console.WriteLine("--= FICHA DE USUARIO =--");
                    Console.WriteLine("------------------------");
                    Console.WriteLine(
                        "Id........: " +  usuario.Id + "\r\n"
                        + "Nombre ..: " + usuario.Nombre + "\r\n"
                        + "Apellido.: " + usuario.Apellido + "\r\n"
                        + "Usuario..: " + usuario.NombreUsuario + "\r\n"
                        + "Clave....: " + usuario.Contraseña + "\r\n"
                        + "Mail.....: " + usuario.Mail + "\r\n"
                        );
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("--= USUARIO INEXISTENTE !!!!! =--");
                    Console.WriteLine("---------------------------------");
                }
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("--= INGRESO INVALIDO !!!!! =--");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar : ");
            Console.ReadLine();
            Console.Clear();
            //
            // INICIO SESION
            //
            string nombre = string.Empty;
            string password = string.Empty;
            Console.WriteLine("--= INICIO SESION =--");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese el Usuario : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el contraseña : ");
            password = Console.ReadLine();

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(password))
            {
                UsuarioHandler usu = new UsuarioHandler();
                Usuario usuario = usu.InicioSesion(nombre , password);
                if (!string.IsNullOrEmpty(usuario.Apellido))
                {
                    Console.WriteLine("--= FICHA DE USUARIO =--");
                    Console.WriteLine("------------------------");
                    Console.WriteLine(
                        "Id........: " + usuario.Id + "\r\n"
                        + "Nombre ..: " + usuario.Nombre + "\r\n"
                        + "Apellido.: " + usuario.Apellido + "\r\n"
                        + "Usuario..: " + usuario.NombreUsuario + "\r\n"
                        + "Clave....: " + usuario.Contraseña + "\r\n"
                        + "Mail.....: " + usuario.Mail + "\r\n"
                        );
                }
                else
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("--= LOGIN INCORRECTO !!!!! =--");
                    Console.WriteLine(
                        "Id........: " + usuario.Id + "\r\n"
                        + "Nombre ..: " + usuario.Nombre + "\r\n"
                        + "Apellido.: " + usuario.Apellido + "\r\n"
                        + "Usuario..: " + usuario.NombreUsuario + "\r\n"
                        + "Clave....: " + usuario.Contraseña + "\r\n"
                        + "Mail.....: " + usuario.Mail + "\r\n"
                        );
                }
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("--= INGRESO INVALIDO !!!!! =--");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar : ");
            Console.ReadLine();
            Console.Clear();
            //
            // TRAER PRODUCTO CARGADOS POR UN USUARIO 
            //
            long IdUsuario = 0;
            Console.WriteLine("--=  TRAER PRODUCTOS =--");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese el Id de Usuario a buscar : ");
            IdUsuario = Convert.ToInt64(Console.ReadLine());
            ProductoHandler prd = new ProductoHandler();
            List<Producto> productos = prd.TraerProducto(IdUsuario);
            Console.WriteLine("Id Prod\tDescripcion                   \tCosto\tP.Venta\tStock\tIdUsaurio");
            foreach (Producto prod in productos)
            {
                Console.WriteLine(prod.Id + "\t" + prod.Descripciones.PadRight(30) + "\t" + prod.Costo + "\t" + prod.PrecioVenta + "\t" + prod.Stock + "\t" + prod.IdUsuario);
            }

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar : ");
            Console.ReadLine();
            Console.Clear();
            //
            // TRAER PRODUCTO CARGADOS POR UN USUARIO 
            //
            Console.WriteLine("--=  TRAER PRODUCTOS VENDIDOS SEGUN USUARIO DEL PRODUCTO=--");
            Console.WriteLine("--=              USANDO METODO ANTERIOR                 =--");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese el Id de Usuario a buscar : ");
            IdUsuario = Convert.ToInt64(Console.ReadLine());
            ProductoVendidoHandler prdVendido = new ProductoVendidoHandler();
            List<ProductoVendido> productosVendidos = prdVendido.TraerProductoVendidos(IdUsuario);

            Console.WriteLine("Id Venta\tId Prod\t\tStock");
            foreach (ProductoVendido prodVendido in productosVendidos)
            {
                Console.WriteLine(prodVendido.IdVenta + "\t\t" + prodVendido.IdProducto + "\t\t" + prodVendido.Stock);
            }

            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar : ");
            Console.ReadLine();
            Console.Clear();
            //
            // TRAER ventas
            //
            Console.WriteLine("--=  TRAER VENTAS =--");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese el Id de Usuario a buscar : ");
            IdUsuario = Convert.ToInt64(Console.ReadLine());
            VentaHandler vta = new VentaHandler();
            List<Venta> ventas = vta.TraerVentas(IdUsuario);

            Console.WriteLine("Id Venta\tComentarios\t\tIdUsuario");
            foreach (Venta venta in ventas)
            {
                Console.WriteLine(venta.Id + "\t\t" + venta.Comentarios + "\t\t" + venta.IdUsuario);
            }
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para continuar : ");
            Console.ReadLine();
            Console.Clear();
        }

    }

}