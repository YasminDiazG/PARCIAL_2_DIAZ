using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public abstract class Cobro : INTERFACES.ICobro, ICloneable, IComparable
    {

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public decimal Importe { get; set; }

        public Cliente Cliente { get; set; }

        public int RetrasoPorDiaPorcentaje { get; set; }

        public decimal RetrasoPorDiaMonto { get; set; }

        public DateTime FechaPagado { get; set; }

        public decimal TotalPagado { get; set; }

        public bool FueSaldado
        {
            get
            {
                if (this.FechaPagado != null && this.TotalPagado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Pago Pago { get; set; }

        public Cobro(int pCodigo, string pNombre, DateTime pFechaVencimiento, decimal pImporte)
        {
            this.Codigo = pCodigo;
            this.Nombre = pNombre;
            this.FechaVencimiento = pFechaVencimiento;
            this.Importe = pImporte;
        }

        public abstract Pago Saldar();

        public object Clone()
        {
            var oClone = this.MemberwiseClone() as Cobro;
            if (oClone.Cliente != null)
            {
                oClone.Cliente = this.Cliente.Clone() as Cliente;
            }
            if (this.Pago != null)
            {
                oClone.Pago = this.Pago.Clone() as Pago;
            }
            return oClone;
        }


        public object Clone(Cliente pCliente)
        {
            var oClone = this.MemberwiseClone() as Cobro;
            oClone.Cliente = pCliente;
            if (this.Pago != null)
            {
                oClone.Pago = this.Pago.Clone() as Pago;
            }
            return oClone;
        }


        public int CompareTo(object obj)
        {
            if (this.TotalPagado < (obj as Cobro).TotalPagado)
            {
                return 1;
            }
            else if (this.TotalPagado > (obj as Cobro).TotalPagado)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


    }
}
