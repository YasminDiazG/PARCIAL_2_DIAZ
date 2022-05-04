using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.INTERFACES
{
    interface ICobro
    {
        int Codigo { get; set; }
        string Nombre { get; set; }
        DateTime FechaVencimiento { get; set; }
        decimal Importe { get; set; }
        CLASES.Cliente Cliente { get; set; }
        int RetrasoPorDiaPorcentaje { get; set; }
        decimal RetrasoPorDiaMonto { get; set; }
        CLASES.Pago Pago { get; set; }
        DateTime FechaPagado { get; set; }
        decimal TotalPagado { get; set; }
        bool FueSaldado { get; }

        CLASES.Pago Saldar();
    }
}
