using System;

namespace WebApiCoto
{
    public class TiposVehiculo
    {
        public long Id { get; set; }

        public string nombre { get; set; }

        public decimal precio;

        public decimal precioFinal => precio + (precio * impuesto);

        public decimal impuesto { get; set; }
    }
}
