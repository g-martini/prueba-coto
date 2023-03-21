using System;

namespace WebApiCoto
{
    public class Ventas
    {
        public long Id { get; set; }
        public CentrosDistribucion centroDistribucion { get; set; }
        public TiposVehiculo tipoVehiculo { get; set; }
    }
}
