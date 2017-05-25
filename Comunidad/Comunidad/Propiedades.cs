using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedades
    {
        private string _Tipo;
        private string _CodigoPropiedad;
        private double _MetrosCuadrados;
        private string _CodigoPropietario;
        private string _Gastos;

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public string CodigoPropiedad
        {
            get
            {
                return _CodigoPropiedad;
            }

            set
            {
                _CodigoPropiedad = value;
            }
        }

        public double MetrosCuadrados
        {
            get
            {
                return _MetrosCuadrados;
            }

            set
            {
                _MetrosCuadrados = value;
            }
        }

        public string CodigoPropietario
        {
            get
            {
                return _CodigoPropietario;
            }

            set
            {
                _CodigoPropietario = value;
            }
        }

        public string Gastos
        {
            get
            {
                return _Gastos;
            }

            set
            {
                _Gastos = value;
            }
        }
    }
}
