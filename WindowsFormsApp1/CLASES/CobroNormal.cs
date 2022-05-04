using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public sealed class CobroNormal : Cobro, INTERFACES.ICobro
    {

       
        public CobroNormal(int pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte) : base(pCodigo, pNombre, pFechaVencimiento, pImporte)
        {
            this.RetrasoPorDiaMonto = 0;
            this.RetrasoPorDiaPorcentaje = 1;
        }


       
        public override Pago Saldar()
        {
            this.FechaPagado = DateTime.Now;

            Pago oInteres = new Pago(this.Importe, this.FechaVencimiento, this.FechaPagado, this.RetrasoPorDiaPorcentaje, this.RetrasoPorDiaMonto);
            this.Pago = oInteres;
            this.Pago.CalcularInteres();
            this.TotalPagado = oInteres.TotalPagado;

            return this.Pago;
        }


    }
}
