using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Gastos:AtributosComunes
        
    {

        private double _Importe;
        private string _TipoZonaReparto;

        public double Importe
        {
            get
            {
                return _Importe;
            }

            set
            {
                _Importe = value;
            }
        }

        public string TipoZonaReparto
        {
            get
            {
                return _TipoZonaReparto;
            }

            set
            {
                _TipoZonaReparto = value;
            }
        }
    }
}
