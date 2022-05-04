using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public sealed class CobroImporteAltoEventArgs : EventArgs
    {
        private Pago oPago;

       
        public CobroImporteAltoEventArgs(Pago pPago)
        {
            this.oPago = pPago;
        }

        
        public Pago Pago { get { return this.oPago; } }


    }
}
