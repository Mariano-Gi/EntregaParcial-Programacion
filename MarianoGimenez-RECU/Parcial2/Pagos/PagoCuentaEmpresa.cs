using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Pagos
{
    public class PagoCuentaEmpresa : IPagoStrategy
    {
        public const decimal Descuento = 0.05m;
        public const decimal MinimoParaDescuento = 100000m;
        public const decimal MinimoSubtotal = 20000m;

        public string Nombre => "Cuenta empresa";
        public bool PermiteCuotas => false;
        public bool RequiereCuit => true;

        public decimal CalcularAjuste(decimal subtotal, int cuotas)
        {
            if (subtotal < MinimoSubtotal)
                throw new InvalidOperationException("El subtotal tiene que ser mayor a 20.000$");
            if (subtotal > MinimoParaDescuento)
                return -subtotal * Descuento;

            return subtotal;
        }
    }
}
