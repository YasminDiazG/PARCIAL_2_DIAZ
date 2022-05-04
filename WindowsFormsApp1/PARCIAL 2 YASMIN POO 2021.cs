using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CLASES.Tesoreria oTesoreria;
        public Form1()
        {
            InitializeComponent();
            this.oTesoreria = new CLASES.Tesoreria();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Subscripcion a eventos
                CLASES.Tesoreria.CobrosActualizacion += CobrosActualizacion;
                CLASES.Tesoreria.CobroImporteAlto += CobroImporteAlto;

                dtpCobroVencimiento.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CobrosActualizacion(object sender, EventArgs e)
        {
            

            try
            {
                this.CargarCobrosPendientes();
                this.CargarCobrosCanceladosLINQ();
                this.CargarCobrosCanceladosIComparable();
                this.CargarTodosCobrosCanceladosLINQAnon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CobroImporteAlto(object sender, CLASES.CobroImporteAltoEventArgs e)
        {
            try
            {
                string MensajeMostrar = $"* IMPORTANTE *" + Environment.NewLine + Environment.NewLine;
                MensajeMostrar += $"El pago realizado supera los $10.000!";
                MessageBox.Show(MensajeMostrar, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDGV(DataGridView pDGV, Object pValue)
        {
            try
            {
                pDGV.DataSource = null;
                pDGV.DataSource = pValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatosCliente(false) == true)
                {
                    CLASES.Cliente oCliente = new CLASES.Cliente(Convert.ToInt32(txtLegajo.Text), txtNombre.Text);
                    oTesoreria.AgregarCliente(oCliente);

                    MostrarDGV(dgvClientes, oTesoreria.RetornaClientes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatosCliente(false) == true)
                {
                    CLASES.Cliente oCliente = new CLASES.Cliente(Convert.ToInt32(txtLegajo.Text), txtNombre.Text);
                    oTesoreria.AgregarCliente(oCliente);

                    MostrarDGV(dgvClientes, oTesoreria.RetornaClientes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLegajo.Text.Length > 0)
                {
                    CLASES.Cliente oCliente = new CLASES.Cliente(Convert.ToInt32(txtLegajo.Text), txtNombre.Text);
                    oTesoreria.BajaCliente(oCliente);

                    MostrarDGV(dgvClientes, oTesoreria.RetornaClientes());
                }
                else
                {
                    MessageBox.Show("Numero de Legajo se encuentra vacio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private bool ValidarDatosCliente(bool pEditar)
        {
            bool EsValido = true;
            string MessageValidacion = "";

            try
            {
                if (Information.IsNumeric(txtLegajo.Text) == false)
                {
                    EsValido = false;
                    MessageValidacion += $"El numero de Legajo del Cliente debe ser en forma numerica!" + Environment.NewLine;
                }
                else
                {
                    if (oTesoreria.LegajoExiste(Convert.ToInt32(txtLegajo.Text)))
                    {
                        // Alta - da error de validacion. Editar esta ok.
                        if (pEditar == false)
                        {
                            EsValido = false;
                            MessageValidacion += $"El numero de Legajo del Cliente se encuentra en uso!" + Environment.NewLine;
                        }
                    }
                }
                if (txtNombre.Text.Length <= 0)
                {
                    EsValido = false;
                    MessageValidacion += $"El nombre del Cliente no puede ser vacio!" + Environment.NewLine;
                }

                if (EsValido == false)
                {
                    MessageBox.Show(MessageValidacion, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return EsValido;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;

                    txtLegajo.Text = oCliente.Legajo.ToString();
                    txtNombre.Text = oCliente.Nombre;

                    txtCobroCliente.Text = oCliente.Legajo.ToString() + " - " + oCliente.Nombre.ToString();

                    this.CargarCobrosPendientes();
                    this.CargarCobrosCanceladosLINQ();
                    this.CargarCobrosCanceladosIComparable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCobrosPendientes()
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;
                    VISTAS.VCobroPendiente VistaCobroPendiente = new VISTAS.VCobroPendiente();

                    this.MostrarDGV(dgvCobrosPendientes, VistaCobroPendiente.Cargar(oTesoreria.RetornaCobrosPendientes(oCliente)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCobrosCanceladosLINQ()
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;

                    this.MostrarDGV(dgvCobrosCanceladosLINQ, oTesoreria.RetornaCobrosCanceladosLINQ(oCliente).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCobrosCanceladosIComparable()
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;

                    //this.MostrarDGV(dgvCobrosCanceladosLINQ, oTesoreria.RetornaCobrosCanceladosLINQ(oCliente).ToList());
                    List<VISTAS.VCobroCancelado> lCobrosCancelados = oTesoreria.RetornaCobrosCanceladosLINQ(oCliente).ToList();

                    if (rbtASC.Checked == true)
                    {
                        lCobrosCancelados.Sort();
                        lCobrosCancelados.Reverse();
                    }
                    else
                    {
                        lCobrosCancelados.Sort();
                    }
                    this.MostrarDGV(dgvCobrosCanceladosIComparable, lCobrosCancelados);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTodosCobrosCanceladosLINQAnon()
        {
            try
            {
                // Traemos un clon fiel de la lista de cobros 
                List<CLASES.Cobro> lCobro = oTesoreria.RetornaTodosLosCobros();

                // LINQ + anon
                var lCobrosCancelados = from Cobro in lCobro
                                        where Cobro.FueSaldado == true
                                        select new
                                        {
                                            Nombre = Cobro.Cliente.Nombre,
                                            ImporteTotal = Cobro.Pago.TotalPagado
                                        };

                // Vinculamos a la grilla
                dgvCobrosCanceladosLINQAnon.DataSource = null;
                dgvCobrosCanceladosLINQAnon.DataSource = lCobrosCancelados.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCobroAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CobroAlta())
                {
                    this.LimpiarCamposCobro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CobroAlta()
        {
            bool Resultado = false;
            try
            {
                // Revisamos que los datos del Cobro sean correctos
                if (this.ValidarDatosCobro() == true)
                {
                    // Verificamos que el cliente no tenga mas de 2 cobros
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;

                    if (oTesoreria.ClienteCantidadDeCobrosAdeudados(oCliente) >= 2)
                    {
                        throw new Exception("El cliente no puede tener mas de 2 importes al cobro al mismo tiempo!");
                    }

                    CLASES.Cobro oCobro;
                    if (rbtCobroNormal.Checked == true)
                    {
                        oCobro = new CLASES.CobroNormal(Convert.ToInt32(txtCobroCodigo.Text), txtCobroNombre.Text, Convert.ToDateTime(dtpCobroVencimiento.Value), Convert.ToDecimal(txtCobroImporte.Text));
                    }
                    else
                    {
                        oCobro = new CLASES.CobroEspecial(Convert.ToInt32(txtCobroCodigo.Text), txtCobroNombre.Text, Convert.ToDateTime(dtpCobroVencimiento.Value), Convert.ToDecimal(txtCobroImporte.Text));
                    }
                    oTesoreria.AgregarCobro(oCobro);
                    oTesoreria.AsignarCobroACliente(dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente, oCobro);
                    Resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Resultado;
        }

        private bool ValidarDatosCobro()
        {
            bool EsValido = true;
            string MessageValidacion = "";

            try
            {
                if (dgvClientes.SelectedRows.Count == 0)
                {
                    EsValido = false;
                    MessageValidacion += $"Debe elejir un Cliente para generar un Cobro!" + Environment.NewLine;
                }
                if (Information.IsNumeric(txtCobroCodigo.Text) == false)
                {
                    EsValido = false;
                    MessageValidacion += $"El numero de Codigo del Cobro debe ser en forma numerica!" + Environment.NewLine;
                }
                else
                {
                    if (oTesoreria.CobroCodigoExiste(Convert.ToInt32(txtCobroCodigo.Text)))
                    {
                        EsValido = false;
                        MessageValidacion += $"El numero de Codigo del Cobro se encuentra en uso!" + Environment.NewLine;
                    }
                }
                if (txtCobroNombre.Text.Length <= 0)
                {
                    EsValido = false;
                    MessageValidacion += $"El Nombre del Cobro no puede ser vacio!" + Environment.NewLine;
                }
                if (Information.IsDate(dtpCobroVencimiento.Value) == false)
                {
                    EsValido = false;
                    MessageValidacion += $"La Fecha de Vencimiento del Cobro debe ser valida!" + Environment.NewLine;
                }
                if (Information.IsNumeric(txtCobroImporte.Text) == false)
                {
                    EsValido = false;
                    MessageValidacion += $"El Importe del Cobro debe ser en forma numerica!" + Environment.NewLine;
                }

                if (EsValido == false)
                {
                    MessageBox.Show(MessageValidacion, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return EsValido;
        }

        private void btnCobroPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0 && dgvCobrosPendientes.SelectedRows.Count > 0)
                {
                    CLASES.Pago oPago = oTesoreria.SaldarCobro((dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente).Legajo, (dgvCobrosPendientes.SelectedRows[0].DataBoundItem as VISTAS.VCobroPendiente).Codigo);

                    string MensajeDesglosadoDePago = $"SubTotal original: ${ oPago.Importe }" + Environment.NewLine;
                    // Pago Con Interes
                    if (oPago.DiasRetrasados > 0)
                    {
                        MensajeDesglosadoDePago += $"Pago Vencido: Si" + Environment.NewLine;
                        MensajeDesglosadoDePago += $"Dias retrasado: { oPago.DiasRetrasados } " + Environment.NewLine;
                        MensajeDesglosadoDePago += $"Interes diario: { oPago.RetrasoPorDiaPorcentaje }% " + Environment.NewLine;
                        MensajeDesglosadoDePago += $"Cargo fijo por tipo de deuda: ${ oPago.RetrasoPorDiaMonto } " + Environment.NewLine;
                        MensajeDesglosadoDePago += $"Interes por dia vencido: ${ oPago.InteresPorDia } " + Environment.NewLine;
                        MensajeDesglosadoDePago += $"Interes Total: ${ oPago.InteresTotal } " + Environment.NewLine;
                    }
                    else // Pago Sin Interes
                    {
                        MensajeDesglosadoDePago += $"Pago Vencido: No" + Environment.NewLine;
                    }
                    MensajeDesglosadoDePago += $"Pago Total: ${ oPago.TotalPagado } " + Environment.NewLine;

                    MessageBox.Show(MensajeDesglosadoDePago, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtASC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.CargarCobrosCanceladosIComparable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCobrosPendientes_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void LimpiarCamposCobro()
        {
            try
            {
                txtCobroCodigo.Text = "";
                txtCobroNombre.Text = "";
                txtCobroImporte.Text = "";
                rbtCobroNormal.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    CLASES.Cliente oCliente = dgvClientes.SelectedRows[0].DataBoundItem as CLASES.Cliente;

                    txtLegajo.Text = oCliente.Legajo.ToString();
                    txtNombre.Text = oCliente.Nombre;

                    txtCobroCliente.Text = oCliente.Legajo.ToString() + " - " + oCliente.Nombre.ToString();

                    this.CargarCobrosPendientes();
                    this.CargarCobrosCanceladosLINQ();
                    this.CargarCobrosCanceladosIComparable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvCobrosPendientes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCobrosPendientes.SelectedRows.Count > 0)
                {
                    VISTAS.VCobroPendiente VistaCobroPendiente = dgvCobrosPendientes.SelectedRows[0].DataBoundItem as VISTAS.VCobroPendiente;
                    txtCobroCodigo.Text = VistaCobroPendiente.Codigo.ToString();
                    txtCobroNombre.Text = VistaCobroPendiente.Nombre;
                    dtpCobroVencimiento.Value = Convert.ToDateTime(VistaCobroPendiente.FechaVencimiento);
                    txtCobroImporte.Text = VistaCobroPendiente.Importe.ToString();
                }
                else
                {
                    this.LimpiarCamposCobro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
