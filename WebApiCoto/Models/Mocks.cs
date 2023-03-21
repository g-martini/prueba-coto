using System.Collections.Generic;

namespace WebApiCoto.Models
{
    public class Mocks
    {
        public Mocks()
        {
            #region TIPOS_VEHICULOS
            tiposVehiculo = new List<TiposVehiculo>();
            tiposVehiculo.Add(tipoSedan);
            tiposVehiculo.Add(tipoSuv);
            tiposVehiculo.Add(tipoOffroad);
            tiposVehiculo.Add(tipoSport);
            #endregion

            #region CENTROS_DISTRIBUCION
            centrosDistribucion = new List<CentrosDistribucion>();
            centrosDistribucion.Add(centro1);
            centrosDistribucion.Add(centro2);
            centrosDistribucion.Add(centro3);
            centrosDistribucion.Add(centro4);
            #endregion

            #region VENTAS
            ventas = new List<Ventas>();
            ventas.Add(venta1);
            ventas.Add(venta2);
            ventas.Add(venta3);
            ventas.Add(venta4);
            ventas.Add(venta5);
            ventas.Add(venta6);
            ventas.Add(venta7);
            ventas.Add(venta8);
            ventas.Add(venta9);
            ventas.Add(venta10);
            ventas.Add(venta11);
            ventas.Add(venta12);
            ventas.Add(venta13);
            #endregion
        }

        #region TIPOS_VEHICULOS
        private static readonly TiposVehiculo tipoSedan = new TiposVehiculo
        {
            Id = 1,
            nombre = "sedan",
            impuesto = 0,
            precio = 8000
        };
        private static readonly TiposVehiculo tipoSuv = new TiposVehiculo
        {
            Id = 2,
            nombre = "suv",
            impuesto = 0,
            precio = 9500
        };
        private static readonly TiposVehiculo tipoOffroad = new TiposVehiculo
        {
            Id = 3,
            nombre = "offroad",
            impuesto = 0,
            precio = 12500
        };
        private static readonly TiposVehiculo tipoSport = new TiposVehiculo
        {
            Id = 4,
            nombre = "sport",
            impuesto = (decimal).07,
            precio = 18200
        };

        public static List<TiposVehiculo> tiposVehiculo;
        #endregion

        #region CENTROS_DISTRIBUCION
        private static readonly CentrosDistribucion centro1 = new CentrosDistribucion
        {
            Id = 1,
            nombre = "Centro1"
        };
        private static readonly CentrosDistribucion centro2 = new CentrosDistribucion
        {
            Id = 2,
            nombre = "Centro2"
        };
        private static readonly CentrosDistribucion centro3 = new CentrosDistribucion
        {
            Id = 3,
            nombre = "Centro3"
        };
        private static readonly CentrosDistribucion centro4 = new CentrosDistribucion
        {
            Id = 4,
            nombre = "Centro4"
        };

        public static List<CentrosDistribucion> centrosDistribucion;
        #endregion

        #region VENTAS
        private static readonly Ventas venta1 = new Ventas
        {
            Id = 1,
            centroDistribucion = centro1,
            tipoVehiculo = tipoSedan
        };
        private static readonly Ventas venta2 = new Ventas
        {
            Id = 2,
            centroDistribucion = centro1,
            tipoVehiculo = tipoSedan
        };
        private static readonly Ventas venta3 = new Ventas
        {
            Id = 3,
            centroDistribucion = centro1,
            tipoVehiculo = tipoSport
        };
        private static readonly Ventas venta4 = new Ventas
        {
            Id = 4,
            centroDistribucion = centro1,
            tipoVehiculo = tipoSuv
        };

        private static readonly Ventas venta5 = new Ventas
        {
            Id = 5,
            centroDistribucion = centro2,
            tipoVehiculo = tipoOffroad
        };
        private static readonly Ventas venta6 = new Ventas
        {
            Id = 6,
            centroDistribucion = centro2,
            tipoVehiculo = tipoSuv
        };
        private static readonly Ventas venta7 = new Ventas
        {
            Id = 7,
            centroDistribucion = centro2,
            tipoVehiculo = tipoSuv
        };
        private static readonly Ventas venta8 = new Ventas
        {
            Id = 8,
            centroDistribucion = centro2,
            tipoVehiculo = tipoOffroad
        };

        private static readonly Ventas venta9 = new Ventas
        {
            Id = 9,
            centroDistribucion = centro3,
            tipoVehiculo = tipoSport
        };
        private static readonly Ventas venta10 = new Ventas
        {
            Id = 10,
            centroDistribucion = centro3,
            tipoVehiculo = tipoSuv
        };
        private static readonly Ventas venta11 = new Ventas
        {
            Id = 11,
            centroDistribucion = centro3,
            tipoVehiculo = tipoSport
        };
        private static readonly Ventas venta12 = new Ventas
        {
            Id = 12,
            centroDistribucion = centro3,
            tipoVehiculo = tipoSport
        };

        private static readonly Ventas venta13 = new Ventas
        {
            Id = 13,
            centroDistribucion = centro4,
            tipoVehiculo = tipoOffroad
        };
        private static readonly Ventas venta14 = new Ventas
        {
            Id = 14,
            centroDistribucion = centro4,
            tipoVehiculo = tipoSedan
        };
        private static readonly Ventas venta15 = new Ventas
        {
            Id = 15,
            centroDistribucion = centro4,
            tipoVehiculo = tipoSedan
        };
        private static readonly Ventas venta16 = new Ventas
        {
            Id = 16,
            centroDistribucion = centro4,
            tipoVehiculo = tipoSedan
        };

        public static List<Ventas> ventas;
        #endregion

    }
}
