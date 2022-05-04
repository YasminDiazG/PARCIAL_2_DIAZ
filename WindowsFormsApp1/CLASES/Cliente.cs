using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public class Cliente : ICloneable
    {
        public List<Cobro> Cobros;
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        public Cliente(int pLegajo, string pNombre)
        {
            this.Cobros = new List<Cobro>();
            this.Legajo = pLegajo;
            this.Nombre = pNombre;
        }

        public void AsignarCobro(Cobro pCobro)
        {
            pCobro.Cliente = this;
            this.Cobros.Add(pCobro);
        }

        public Pago SaldarCobro(Cobro pCobro)
        {
            Cobro oCobro = this.Cobros.Find(x => x.Codigo == pCobro.Codigo);
            return oCobro.Saldar();
        }

        public int CantidadDeCobros()
        {
            return this.Cobros.Count;
        }

        public int CantidadDeCobrosAdeudados()
        {
            int Cantidad = 0;
            foreach (Cobro oCobro in this.Cobros)
            {
                if (oCobro.FueSaldado == false)
                {
                    Cantidad++;
                }
            }
            return Cantidad;
        }



        public object Clone()
        {
            var oClone = this.MemberwiseClone() as Cliente;
            oClone.Cobros = new List<Cobro>();
            foreach (Cobro oCobro in this.Cobros)
            {
                oClone.AsignarCobro(oCobro.Clone(oClone) as Cobro);
            }
            return oClone;
        }


    }
}
