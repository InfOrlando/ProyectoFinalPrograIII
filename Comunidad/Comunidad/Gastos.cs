using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Gastos:AtributosComunes
    {
        private string _TipoDeReparto;

        public string TipoDeReparto
        {
            get
            {
                return _TipoDeReparto;
            }

            set
            {
                _TipoDeReparto = value;
            }
        }
    }
}
