using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASES
{
    public sealed class Tesoreria
    {
        private List<Cliente> Clientes;
        private List<Cobro> Cobros;

        // Eventos
        static public EventHandler<EventArgs> CobrosActualizacion;
        static public EventHandler<CobroImporteAltoEventArgs> CobroImporteAlto;

        public Tesoreria()
        {
            this.Clientes = new List<Cliente>();
            this.Cobros = new List<Cobro>();
        }


        #region "CLIENTES"

        
        public void AgregarCliente(Cliente pCliente)
        {
            if (this.LegajoExiste(pCliente.Legajo) == true)
            {
                throw new Exception("El numero de Legajo se encuentra en uso!");
            }
            this.Clientes.Add(pCliente.Clone() as Cliente);
        }


        
        public void EditarCliente(Cliente pCliente)
        {
            if (this.LegajoExiste(pCliente.Legajo) == false)
            {
                throw new Exception("No se ha encontrado el numero de Legajo!");
            }
            Cliente oCliente = this.BuscarCliente(pCliente.Legajo);
            oCliente.Nombre = pCliente.Nombre;
        }


      
        public void BajaCliente(Cliente pCliente)
        {
            Cliente oCliente = this.BuscarCliente(pCliente.Legajo);
            if (oCliente != null)
            {
                if (oCliente.CantidadDeCobros() > 0)
                {
                    throw new Exception("El cliente tiene cobros asignados y no puede ser eliminado!");
                }
                else
                {
                    this.Clientes.Remove(oCliente);
                }
            }
            else
            {
                throw new Exception("Cliente no encontrado en nuestros registros!");
            }
        }


        
        public void AsignarCobroACliente(int pLegajoCliente, int pCodigoCobro)
        {
            Cliente oCliente = this.BuscarCliente(pLegajoCliente);
            Cobro oCobro = this.BuscarCobro(pCodigoCobro);
            this.AsignarCobroACliente(oCliente, oCobro);
        }


        
        public void AsignarCobroACliente(Cliente pCliente, Cobro pCobro)
        {
            if (pCliente == null || pCobro == null)
            {
                throw new ArgumentNullException();
            }
           
            Cliente oCliente = this.BuscarCliente(pCliente);
            Cobro oCobro = this.BuscarCobro(pCobro);
            if (oCliente == null || oCobro == null)
            {
                throw new ArgumentNullException();
            }
            oCliente.AsignarCobro(oCobro);

           
            CobrosActualizacion?.Invoke(null, null);
        }


       
        private Cliente BuscarCliente(Cliente pCliente)
        {
            return this.BuscarCliente(pCliente.Legajo);
        }


       
        private Cliente BuscarCliente(int pLegajo)
        {
            return this.Clientes.Find(x => x.Legajo == pLegajo);
        }


       
        public bool LegajoExiste(int pLegajo)
        {
            bool Existe = true;
            Cliente oCliente = this.BuscarCliente(pLegajo);
            if (oCliente == null)
            {
                Existe = false;
            }
            return Existe;
        }


      
        public List<Cliente> RetornaClientes()
        {
            List<Cliente> lClientes = new List<Cliente>();
            foreach (Cliente oCliente in this.Clientes)
            {
                lClientes.Add(oCliente.Clone() as Cliente);
            }
            return lClientes;
        }


       
        public int ClienteCantidadDeCobrosAdeudados(Cliente pCliente)
        {
           
            Cliente oCliente = this.BuscarCliente(pCliente);
            return oCliente.CantidadDeCobrosAdeudados();
        }


        #endregion


        #region "COBROS"

        
        public void AgregarCobro(Cobro pCobro)
        {
            this.Cobros.Add(pCobro.Clone() as Cobro);
        }


       
        public Pago SaldarCobro(int pLegajo, int pCodigo)
        {
           
            Cliente oCliente = this.BuscarCliente(pLegajo);
            Cobro oCobro = this.BuscarCobro(pCodigo);
            if (oCliente == null || oCobro == null)
            {
                throw new ArgumentNullException();
            }
            Pago oPago = oCliente.SaldarCobro(oCobro);

            
            if (oCobro.Pago != null && oCobro.Pago.TotalPagado >= 10000)
            {
                CobroImporteAlto?.Invoke(null, new CobroImporteAltoEventArgs(oCobro.Pago));
            }

            
            CobrosActualizacion?.Invoke(null, null);

            return oPago;
        }


        
        private Cobro BuscarCobro(Cobro pCobro)
        {
            return this.Cobros.Find(x => x.Codigo == pCobro.Codigo);
        }


        
        private Cobro BuscarCobro(int pCodigo)
        {
            return this.Cobros.Find(x => x.Codigo == pCodigo);
        }


       
        public bool CobroCodigoExiste(int pCodigo)
        {
            bool Existe = true;
            Cobro oCobro = this.BuscarCobro(pCodigo);
            if (oCobro == null)
            {
                Existe = false;
            }
            return Existe;
        }


       
        public List<Cobro> RetornaCobros(Cliente pCliente)
        {
            // Buscamos el objeto Cliente real en nuestra lista
            Cliente oCliente = this.BuscarCliente(pCliente);
            List<Cobro> lCobro = new List<Cobro>();

            foreach (Cobro oCobro in oCliente.Cobros)
            {
                lCobro.Add(oCobro.Clone(oCliente) as Cobro);
            }
            return lCobro;
        }


       
        public List<Cobro> RetornaCobrosPendientes(Cliente pCliente)
        {
            
            Cliente oCliente = this.BuscarCliente(pCliente);
            List<Cobro> lCobro = new List<Cobro>();

            foreach (Cobro oCobro in oCliente.Cobros)
            {
                if (oCobro.FueSaldado == false)
                {
                    lCobro.Add(oCobro.Clone(oCliente) as Cobro);
                }
            }
            return lCobro;
        }


       
        public List<Cobro> RetornaCobrosCancelados(Cliente pCliente)
        {
            
            Cliente oCliente = this.BuscarCliente(pCliente);
            List<Cobro> lCobro = new List<Cobro>();

            foreach (Cobro oCobro in oCliente.Cobros)
            {
                if (oCobro.FueSaldado == true)
                {
                    lCobro.Add(oCobro.Clone(oCliente) as Cobro);
                }
            }
            return lCobro;
        }


        
        public IEnumerable<VISTAS.VCobroCancelado> RetornaCobrosCanceladosLINQ(Cliente pCliente)
        {
            
            Cliente oCliente = this.BuscarCliente(pCliente);

            var lCobrosCancelados = from cobro in oCliente.Cobros
                                    where cobro.FueSaldado == true
                                    select new VISTAS.VCobroCancelado
                                    {
                                        Codigo = cobro.Codigo,
                                        Nombre = cobro.Nombre,
                                        Importe = cobro.Importe,
                                        TotalPagado = cobro.TotalPagado
                                    };

            return lCobrosCancelados;
        }


       
        public List<Cobro> RetornaTodosLosCobros()
        {
            List<Cobro> lCobro = new List<Cobro>();
            foreach (Cobro oCobro in this.Cobros)
            {
                lCobro.Add(oCobro.Clone() as Cobro);
            }
            return lCobro;
        }


        #endregion


    }
}
