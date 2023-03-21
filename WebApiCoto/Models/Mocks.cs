using System.Collections.Generic;

namespace WebApiCoto.Models
{
    public class Mocks
    {
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

        private static List<TiposVehiculo> _tiposVehiculo;
        public static List<TiposVehiculo> tiposVehiculo
        {
            get
            {
                _tiposVehiculo = new List<TiposVehiculo>();
                _tiposVehiculo.Add(tipoSedan);
                _tiposVehiculo.Add(tipoSuv);
                _tiposVehiculo.Add(tipoOffroad);
                _tiposVehiculo.Add(tipoSport);
                return _tiposVehiculo;
            }
        }   
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

        private static List<CentrosDistribucion> _centrosDistribucion;
        public static List<CentrosDistribucion> centrosDistribucion
        {
            get
            {
                _centrosDistribucion = new List<CentrosDistribucion>();
                _centrosDistribucion.Add(centro1);
                _centrosDistribucion.Add(centro2);
                _centrosDistribucion.Add(centro3);
                _centrosDistribucion.Add(centro4);
                return _centrosDistribucion;
            }
        }
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

        private static List<Ventas> _ventas;
        public static List<Ventas> ventas
        {
            get
            {
                _ventas = new List<Ventas>();
                _ventas.Add(venta1);
                _ventas.Add(venta2);
                _ventas.Add(venta3);
                _ventas.Add(venta4);
                _ventas.Add(venta5);
                _ventas.Add(venta6);
                _ventas.Add(venta7);
                _ventas.Add(venta8);
                _ventas.Add(venta9);
                _ventas.Add(venta10);
                _ventas.Add(venta11);
                _ventas.Add(venta12);
                _ventas.Add(venta13);
                return _ventas;
            }
        }
        #endregion

    }
}
