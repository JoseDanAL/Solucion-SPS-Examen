using ApiSolucionDescunetos.Funciones;
using ApiSolucionDescunetos.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiSolucionDescunetos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ELKController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new object[] {
                new { Mensaje= "Bienvenido ",Metodos="GetProducto(string id) \n"+"GetBitacora(string id) \n"+"AgregarProducto(Productos nuevoCliente)\n"+"ModificarDescuento(string producto, string descuento, string usuario)\n"},
            });

        }

        [HttpGet("{id}")]
        public IActionResult GetProducto(string id)
        {
            FnControldescuentos rpCli = new FnControldescuentos();

            var cliRet = rpCli.ObtenerProductos(id);


            if (cliRet == null)
            {
                var nf = NotFound("El usuario " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpGet("{id}")]
        public IActionResult GetBitacora(string id)
        {
            FnControldescuentos rpCli = new FnControldescuentos();

            var cliRet = rpCli.ObtenerProductos(id);


            if (cliRet == null)
            {
                var nf = NotFound("El producto " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }
        

        [HttpPost("agregar")]
        public IActionResult AgregarProducto(Productos nuevoCliente)
        {
            try
            {
                FnControldescuentos rpCli = new FnControldescuentos();
                rpCli.AgregarProducto(nuevoCliente);
                return CreatedAtAction(nameof(AgregarProducto), nuevoCliente);
            }
            catch (Exception ex) { return BadRequest("Fallo actualización" + ex); }
        }


        [HttpPost("{producto},{descuento},{usuario}")]
        public IActionResult ModificarDescuento(string producto, string descuento, string usuario)
        {
            try
            {
                FnControldescuentos rpCli = new FnControldescuentos();
                rpCli.ModificarDescuentoProdcuto(Convert.ToInt32(producto), Convert.ToDouble(descuento), Convert.ToInt32(usuario));
                return CreatedAtAction(nameof(ModificarDescuento), producto, descuento, usuario);
            }
            catch (Exception ex){ return BadRequest("Fallo actualización" + ex); }
        }
    }
}
