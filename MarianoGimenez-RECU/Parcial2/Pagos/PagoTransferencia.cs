using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Pagos
{
    public class PagoTransferencia : IPagoStrategy
    {
        public string Nombre => "Transferencia";
        public bool RequiereCuit => false;
        public bool PermiteCuotas => false;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            return -subtotal * 0.03m;
        }
    }
}
