using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VISTAS
{
    public class VCobroCancelado : IComparable
    {
       
        public int Codigo { get; set; }
        
        public string Nombre { get; set; }
        
        public decimal Importe { get; set; }
        
        public decimal TotalPagado { get; set; }


       
        public int CompareTo(object obj)
        {
            if (this.TotalPagado < (obj as VCobroCancelado).TotalPagado)
            {
                return 1;
            }
            else if (this.TotalPagado > (obj as VCobroCancelado).TotalPagado)
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
