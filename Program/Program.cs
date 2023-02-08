using PrimerEntregaProyectoFinal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Función me devuelve lista de todos los objetos Producto
            List<Producto> productos = ManejadorProducto.ObtenerProductos();

            // Función que recibe un id y devuelve un Producto
            long id = 2;
            Producto producto = ManejadorProducto.ObtenerProducto(id);

            // Función que permita crear un producto
            /*
            Producto nuevoProducto = new Producto
            {
                Descripciones = "Pantalón Jean Negro",
                Costo = 9000,
                PrecioVenta = 12000,
                Stock = 99,
                IdUsuario = 2
            };
            if (ManejadorProducto.InsertarProducto(nuevoProducto) >= 1)
            {
                Console.WriteLine("Producto insertado");
            }else
            {
                Console.WriteLine("No se pudo insertar el producto");
            }
            */

            // Función que recibe un long id y devuelve un objeto Usuario
            long id_usuario = 1;
            Usuario usuario = ManejadorUsuario.ObtenerUsuario(id_usuario);
            Console.WriteLine($"Nombre: {usuario.Nombre} \nApellido: {usuario.Apellido}");

            // Función que recibe un long id de usuario y devuelve una lista de objetos Producto cargados por ese usuario
            List<Producto> productos_cargados_usuario = ManejadorProducto.ObtenerProductosUsuario(id_usuario);
            Console.WriteLine($"Productos ingresados por el usuario con id {id_usuario}");
            for (int i = 0; i < productos_cargados_usuario.Count; i++)
            {
                Console.WriteLine($"Id: {productos_cargados_usuario[i].Id}, Producto: {productos_cargados_usuario[i].Descripciones}");
            }

            // Función que recibe un long id de usuario y devuelve  una lista de objetos ProductoVendido por ese usuario 
            List<ProductoVendido> productoVendidoUsuario = ManejadorProductoVendido.ObtenerProductoVendido(id_usuario);
            Console.WriteLine($"Productos vendidos por el usuario con id {id_usuario}");
            for (int i = 0; i < productoVendidoUsuario.Count; i++)
            {
                Console.WriteLine($"Id de venta: {productoVendidoUsuario[i].IdVenta}, Id del producto: {productoVendidoUsuario[i].IdProducto}");
            }

            // Función que recibe un long id de usuario y devuelve una lista de objetos Venta realizada por ese usuario

            List<Venta> ventaPorUsuario = ManejadorVenta.ObtenerVentasUsuario(id_usuario);
            Console.WriteLine($"Ventas realizadas por el usuario con id {id_usuario}");
            // Dejo en evidencia que los datos cargados en la base de datos Sql estan incompletos. Considero lógico que en el apartados comentarios, se disponga que productos fueron vendidos y la fecha de la venta. Mejor aún sería agregarle atributos al objeto venta para que sea más organizado y visible. 
            // Debido a este error de planteo en la base de datos, los comentarios que se printean a continuación destacan por su falta de información.
            for (int i = 0; i < ventaPorUsuario.Count; i++)
            {
                Console.WriteLine($"Id: {ventaPorUsuario[i].Id}, Comentarios: {ventaPorUsuario[i].Comentarios}");
            }

            // Función que recibe un string nombreUsuario y un string contraseña y devuelve un objeto Usuario si los datos son correctos.
            string nombreUsuario = "eperez";
            string contraseña = "NuevaContraseña";
            Usuario usuario_login = ManejadorUsuario.Login(nombreUsuario, contraseña);
            

            
        }
    }
}
