using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VISTAS
{
    public sealed class VCobroPendiente
    {
       
        public int Codigo { get; set; }
        
        public string Nombre { get; set; }
        
        public DateTime FechaVencimiento { get; set; }
        
        public decimal Importe { get; set; }

        
        public List<VCobroPendiente> Cargar(List<CLASES.Cobro> pCobros)
        {
            List<VCobroPendiente> lVCobroPendiente = new List<VCobroPendiente>();
            foreach (CLASES.Cobro oCobro in pCobros)
            {
                VCobroPendiente VCP = new VCobroPendiente();
                VCP.Codigo = oCobro.Codigo;
                VCP.Nombre = oCobro.Nombre;
                VCP.FechaVencimiento = oCobro.FechaVencimiento;
                VCP.Importe = oCobro.Importe;

                lVCobroPendiente.Add(VCP);
            }
            return lVCobroPendiente;
        }

    }
}
