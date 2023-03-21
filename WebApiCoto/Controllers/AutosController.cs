using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoto.Models;

namespace WebApiCoto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutosController : ControllerBase
    {
        private readonly ILogger<AutosController> _logger;

        public AutosController(ILogger<AutosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public decimal GetVolumenVentasTotal()
        {
            return Mocks.ventas.Sum(v => v.tipoVehiculo.precioFinal);
        }

        [HttpGet]
        public IEnumerable<VentasCentro> GetVolumenVentasPorCentro()
        {
            List<VentasCentro> ret = new List<VentasCentro>();

            var datos = Mocks.ventas.GroupBy(c => c.centroDistribucion).ToList();

            foreach (var d in datos)
            {
                VentasCentro v = new VentasCentro();
                v.Centro = d.Key.nombre;
                v.TotalVentas = d.Sum(v => v.tipoVehiculo.precioFinal);
                ret.Add(v); ;
            }

            return ret;
        }


        [HttpGet]
        public IEnumerable<PorcentajesVentasCentro> GetPorcentajes()
        {
            List<PorcentajesVentasCentro> ret = new List<PorcentajesVentasCentro>();

            var total = Mocks.ventas.Sum(a => a.Id);

            var datos = Mocks.ventas.GroupBy(c => c.centroDistribucion).ToList();

            foreach (var d in datos)
            {
                foreach (var d2 in d)
                {
                    PorcentajesVentasCentro v = new PorcentajesVentasCentro();
                    v.Centro = d.Key.nombre;
                    v.Modelo = d2.tipoVehiculo.nombre;
                    v.Porcentaje = (d.Where(t => t.tipoVehiculo.nombre == d2.tipoVehiculo.nombre).Sum(v => v.Id)) * 100 / total;
                    ret.Add(v);
                }
            }

            return ret;
        }


        [HttpPost]
        public async Task<ActionResult<Ventas>> PostVenta(Ventas venta)
        {
            //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(PostVenta), new { id = "1" }, venta);
        }
    }
}
