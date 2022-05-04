using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public class Pago : ICloneable
    {
       
        public decimal Importe { get; set; }
        
        public DateTime FechaVencimiento { get; set; }
        
        public DateTime FechaPagado { get; set; }
       
        public int RetrasoPorDiaPorcentaje { get; set; }
        
        public decimal RetrasoPorDiaMonto { get; set; }
        
        public decimal InteresPorDia { get; set; }
        
        public decimal InteresTotal { get; set; }
        
        public int DiasRetrasados { get; set; }
       
        public decimal TotalPagado { get; set; }


      
        public Pago(decimal pImporte, DateTime pFechaVencimiento, DateTime pFechaPagado, int pRetrasoPorDiaPorcentaje, decimal pRetrasoPorDiaMonto)
        {
            this.Importe = pImporte;
            this.FechaVencimiento = pFechaVencimiento;
            this.FechaPagado = pFechaPagado;
            this.RetrasoPorDiaPorcentaje = pRetrasoPorDiaPorcentaje;
            this.RetrasoPorDiaMonto = pRetrasoPorDiaMonto;

            this.InteresPorDia = 0;
            this.InteresTotal = 0;
            this.DiasRetrasados = 0;
            this.TotalPagado = 0;
        }


        
        public void CalcularInteres()
        {
            decimal Interes = 0;
            try
            {
                int dias = Convert.ToInt32(this.FechaPagado.Subtract(FechaVencimiento).TotalDays);

                // Si es un pago atrasado, calcular el interes diario adeudado y sumarlo al total
                if (dias > 0)
                {
                    this.DiasRetrasados = dias;

                    // Calculo el valor por porcentaje
                    this.InteresPorDia = (this.Importe * this.RetrasoPorDiaPorcentaje / 100);

                    Interes = this.InteresPorDia * this.DiasRetrasados;
                    this.InteresTotal = Interes;
                    this.TotalPagado = this.Importe + this.InteresTotal + this.RetrasoPorDiaMonto;
                }
                else // no es un pago atrasado. Pagar unicamente el importe original adeudado
                {
                    this.TotalPagado = this.Importe;
                }

            }
            catch (Exception)
            {
                throw new Exception("Fallo al caclular el Interes adeudado");
            }
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
