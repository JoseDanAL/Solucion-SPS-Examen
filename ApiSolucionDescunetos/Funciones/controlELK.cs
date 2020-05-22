using ApiSolucionDescunetos.Controllers;
using ApiSolucionDescunetos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSolucionDescunetos.Funciones
{
    public class FnControldescuentos
    {
        public static List<logUsuarios> _RegistroUsuarios = new List<logUsuarios>()
        {
            new logUsuarios() { Id = 1, usuario = "Luis" , FechaModificacion = DateTime.Now },
            new logUsuarios() { Id = 2, usuario = "Martin" , FechaModificacion = DateTime.Now },
            new logUsuarios() { Id = 3, usuario = "Brandon" , FechaModificacion = DateTime.Now }
        };

        public static List<Productos> _listaproductos = new List<Productos>()
        {
            new Productos() { IdProducto=1, nombreProducto = "producto1", precio = 100.50 , descuento = 15 },
            new Productos() { IdProducto=2, nombreProducto = "producto2", precio = 200.50 , descuento = 10 },
            new Productos() { IdProducto=3, nombreProducto = "producto3", precio = 120.90 , descuento = 12 }
        };

        public logUsuarios ObtenerUsuarios(int id)
        {
            var usuarios = _RegistroUsuarios.Where(cli => cli.Id == id);

            return usuarios.FirstOrDefault();
        }

       

        public Productos ObtenerProductos(string nombreProducto)
        {
            var usuarios = _listaproductos.Where(cli => cli.nombreProducto == nombreProducto);

            return usuarios.FirstOrDefault();
        }
       
        public void AgregarProducto(Productos nuevoCliente)
        {
            _listaproductos.Add(nuevoCliente);
        }
        public void ModificarDescuentoProdcuto(int producto,double descuento, int usuario )
        {
            var indice = _RegistroUsuarios[usuario].Notas.Length + 1;
            if (descuento >= 100)     
                _RegistroUsuarios[usuario].Notas[indice] = "Ha modificado un producto con un descuento de 100% "+ DateTime.Now.ToString();

            _listaproductos[producto].descuento = descuento;
            _RegistroUsuarios[usuario].Notas[indice] = "Se modifico el producto: " + producto + " a las " + DateTime.Now.ToString() + " por el usuario: " + usuario + " Correctamente";

        }
    }
}
