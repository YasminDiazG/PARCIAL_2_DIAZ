
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCobrosPendientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCobroPagar = new System.Windows.Forms.Button();
            this.btnCobroAlta = new System.Windows.Forms.Button();
            this.rbtCobroEspecial = new System.Windows.Forms.RadioButton();
            this.rbtCobroNormal = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCobroImporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCobroVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCobroNombre = new System.Windows.Forms.TextBox();
            this.txtCobroCodigo = new System.Windows.Forms.TextBox();
            this.txtCobroCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCobrosCanceladosLINQ = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvCobrosCanceladosIComparable = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbtDESC = new System.Windows.Forms.RadioButton();
            this.rbtASC = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvCobrosCanceladosLINQAnon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosPendientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosLINQ)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosIComparable)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosLINQAnon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTES";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvClientes.Location = new System.Drawing.Point(9, 18);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(538, 216);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBajaCliente);
            this.groupBox3.Controls.Add(this.btnEditarCliente);
            this.groupBox3.Controls.Add(this.btnAltaCliente);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtLegajo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(586, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ABM Cliente";
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBajaCliente.Location = new System.Drawing.Point(231, 156);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBajaCliente.TabIndex = 6;
            this.btnBajaCliente.Text = "BAJA";
            this.btnBajaCliente.UseVisualStyleBackColor = false;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarCliente.Location = new System.Drawing.Point(131, 156);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 5;
            this.btnEditarCliente.Text = "EDITAR";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAltaCliente.Location = new System.Drawing.Point(26, 156);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAltaCliente.TabIndex = 4;
            this.btnAltaCliente.Text = "ALTA";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(85, 29);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(221, 22);
            this.txtLegajo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCobrosPendientes);
            this.groupBox2.Location = new System.Drawing.Point(3, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COBROS PENDIENTES CLIENTE";
            // 
            // dgvCobrosPendientes
            // 
            this.dgvCobrosPendientes.AllowUserToAddRows = false;
            this.dgvCobrosPendientes.AllowUserToDeleteRows = false;
            this.dgvCobrosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobrosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobrosPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCobrosPendientes.Location = new System.Drawing.Point(6, 30);
            this.dgvCobrosPendientes.MultiSelect = false;
            this.dgvCobrosPendientes.Name = "dgvCobrosPendientes";
            this.dgvCobrosPendientes.ReadOnly = true;
            this.dgvCobrosPendientes.RowHeadersWidth = 51;
            this.dgvCobrosPendientes.RowTemplate.Height = 24;
            this.dgvCobrosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobrosPendientes.Size = new System.Drawing.Size(538, 194);
            this.dgvCobrosPendientes.TabIndex = 0;
            this.dgvCobrosPendientes.SelectionChanged += new System.EventHandler(this.dgvCobrosPendientes_SelectionChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCobroPagar);
            this.groupBox4.Controls.Add(this.btnCobroAlta);
            this.groupBox4.Controls.Add(this.rbtCobroEspecial);
            this.groupBox4.Controls.Add(this.rbtCobroNormal);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCobroImporte);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtpCobroVencimiento);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCobroNombre);
            this.groupBox4.Controls.Add(this.txtCobroCodigo);
            this.groupBox4.Controls.Add(this.txtCobroCliente);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(586, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 298);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ALTA COBRO";
            // 
            // btnCobroPagar
            // 
            this.btnCobroPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCobroPagar.Location = new System.Drawing.Point(337, 78);
            this.btnCobroPagar.Name = "btnCobroPagar";
            this.btnCobroPagar.Size = new System.Drawing.Size(75, 23);
            this.btnCobroPagar.TabIndex = 14;
            this.btnCobroPagar.Text = "PAGAR";
            this.btnCobroPagar.UseVisualStyleBackColor = false;
            this.btnCobroPagar.Click += new System.EventHandler(this.btnCobroPagar_Click);
            // 
            // btnCobroAlta
            // 
            this.btnCobroAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCobroAlta.Location = new System.Drawing.Point(337, 36);
            this.btnCobroAlta.Name = "btnCobroAlta";
            this.btnCobroAlta.Size = new System.Drawing.Size(75, 23);
            this.btnCobroAlta.TabIndex = 13;
            this.btnCobroAlta.Text = "ALTA";
            this.btnCobroAlta.UseVisualStyleBackColor = false;
            this.btnCobroAlta.Click += new System.EventHandler(this.btnCobroAlta_Click);
            // 
            // rbtCobroEspecial
            // 
            this.rbtCobroEspecial.AutoSize = true;
            this.rbtCobroEspecial.Location = new System.Drawing.Point(196, 254);
            this.rbtCobroEspecial.Name = "rbtCobroEspecial";
            this.rbtCobroEspecial.Size = new System.Drawing.Size(82, 21);
            this.rbtCobroEspecial.TabIndex = 12;
            this.rbtCobroEspecial.TabStop = true;
            this.rbtCobroEspecial.Text = "Especial";
            this.rbtCobroEspecial.UseVisualStyleBackColor = true;
            // 
            // rbtCobroNormal
            // 
            this.rbtCobroNormal.AutoSize = true;
            this.rbtCobroNormal.Location = new System.Drawing.Point(106, 256);
            this.rbtCobroNormal.Name = "rbtCobroNormal";
            this.rbtCobroNormal.Size = new System.Drawing.Size(74, 21);
            this.rbtCobroNormal.TabIndex = 11;
            this.rbtCobroNormal.TabStop = true;
            this.rbtCobroNormal.Text = "Normal";
            this.rbtCobroNormal.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo:";
            // 
            // txtCobroImporte
            // 
            this.txtCobroImporte.Location = new System.Drawing.Point(106, 207);
            this.txtCobroImporte.Name = "txtCobroImporte";
            this.txtCobroImporte.Size = new System.Drawing.Size(200, 22);
            this.txtCobroImporte.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Importe:";
            // 
            // dtpCobroVencimiento
            // 
            this.dtpCobroVencimiento.Location = new System.Drawing.Point(106, 170);
            this.dtpCobroVencimiento.Name = "dtpCobroVencimiento";
            this.dtpCobroVencimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpCobroVencimiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vencimiento:";
            // 
            // txtCobroNombre
            // 
            this.txtCobroNombre.Location = new System.Drawing.Point(106, 119);
            this.txtCobroNombre.Name = "txtCobroNombre";
            this.txtCobroNombre.Size = new System.Drawing.Size(200, 22);
            this.txtCobroNombre.TabIndex = 5;
            // 
            // txtCobroCodigo
            // 
            this.txtCobroCodigo.Location = new System.Drawing.Point(106, 78);
            this.txtCobroCodigo.Name = "txtCobroCodigo";
            this.txtCobroCodigo.Size = new System.Drawing.Size(200, 22);
            this.txtCobroCodigo.TabIndex = 4;
            // 
            // txtCobroCliente
            // 
            this.txtCobroCliente.Location = new System.Drawing.Point(106, 36);
            this.txtCobroCliente.Name = "txtCobroCliente";
            this.txtCobroCliente.Size = new System.Drawing.Size(200, 22);
            this.txtCobroCliente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cliente:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCobrosCanceladosLINQ);
            this.groupBox5.Location = new System.Drawing.Point(9, 568);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(538, 268);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cobros Cancelados Cliente - LINQ";
            // 
            // dgvCobrosCanceladosLINQ
            // 
            this.dgvCobrosCanceladosLINQ.AllowUserToAddRows = false;
            this.dgvCobrosCanceladosLINQ.AllowUserToDeleteRows = false;
            this.dgvCobrosCanceladosLINQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobrosCanceladosLINQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobrosCanceladosLINQ.Location = new System.Drawing.Point(12, 34);
            this.dgvCobrosCanceladosLINQ.MultiSelect = false;
            this.dgvCobrosCanceladosLINQ.Name = "dgvCobrosCanceladosLINQ";
            this.dgvCobrosCanceladosLINQ.ReadOnly = true;
            this.dgvCobrosCanceladosLINQ.RowHeadersWidth = 51;
            this.dgvCobrosCanceladosLINQ.RowTemplate.Height = 24;
            this.dgvCobrosCanceladosLINQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobrosCanceladosLINQ.Size = new System.Drawing.Size(526, 201);
            this.dgvCobrosCanceladosLINQ.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvCobrosCanceladosIComparable);
            this.groupBox6.Location = new System.Drawing.Point(923, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(477, 246);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cobros Cancelados Cliente - IComparable";
            // 
            // dgvCobrosCanceladosIComparable
            // 
            this.dgvCobrosCanceladosIComparable.AllowUserToAddRows = false;
            this.dgvCobrosCanceladosIComparable.AllowUserToDeleteRows = false;
            this.dgvCobrosCanceladosIComparable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobrosCanceladosIComparable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobrosCanceladosIComparable.Location = new System.Drawing.Point(6, 29);
            this.dgvCobrosCanceladosIComparable.MultiSelect = false;
            this.dgvCobrosCanceladosIComparable.Name = "dgvCobrosCanceladosIComparable";
            this.dgvCobrosCanceladosIComparable.ReadOnly = true;
            this.dgvCobrosCanceladosIComparable.RowHeadersWidth = 51;
            this.dgvCobrosCanceladosIComparable.RowTemplate.Height = 24;
            this.dgvCobrosCanceladosIComparable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobrosCanceladosIComparable.Size = new System.Drawing.Size(459, 205);
            this.dgvCobrosCanceladosIComparable.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbtDESC);
            this.groupBox8.Controls.Add(this.rbtASC);
            this.groupBox8.Location = new System.Drawing.Point(1037, 264);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(315, 91);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ordenar";
            // 
            // rbtDESC
            // 
            this.rbtDESC.AutoSize = true;
            this.rbtDESC.Location = new System.Drawing.Point(167, 45);
            this.rbtDESC.Name = "rbtDESC";
            this.rbtDESC.Size = new System.Drawing.Size(113, 21);
            this.rbtDESC.TabIndex = 1;
            this.rbtDESC.TabStop = true;
            this.rbtDESC.Text = "Descendente";
            this.rbtDESC.UseVisualStyleBackColor = true;
            // 
            // rbtASC
            // 
            this.rbtASC.AutoSize = true;
            this.rbtASC.Location = new System.Drawing.Point(40, 45);
            this.rbtASC.Name = "rbtASC";
            this.rbtASC.Size = new System.Drawing.Size(104, 21);
            this.rbtASC.TabIndex = 0;
            this.rbtASC.TabStop = true;
            this.rbtASC.Text = "Ascendente";
            this.rbtASC.UseVisualStyleBackColor = true;
            this.rbtASC.CheckedChanged += new System.EventHandler(this.rbtASC_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvCobrosCanceladosLINQAnon);
            this.groupBox7.Location = new System.Drawing.Point(612, 568);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(584, 268);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cobros Cancelados Todos - LINQ + Anonimos";
            // 
            // dgvCobrosCanceladosLINQAnon
            // 
            this.dgvCobrosCanceladosLINQAnon.AllowUserToAddRows = false;
            this.dgvCobrosCanceladosLINQAnon.AllowUserToDeleteRows = false;
            this.dgvCobrosCanceladosLINQAnon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobrosCanceladosLINQAnon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobrosCanceladosLINQAnon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCobrosCanceladosLINQAnon.Location = new System.Drawing.Point(11, 34);
            this.dgvCobrosCanceladosLINQAnon.MultiSelect = false;
            this.dgvCobrosCanceladosLINQAnon.Name = "dgvCobrosCanceladosLINQAnon";
            this.dgvCobrosCanceladosLINQAnon.ReadOnly = true;
            this.dgvCobrosCanceladosLINQAnon.RowHeadersWidth = 51;
            this.dgvCobrosCanceladosLINQAnon.RowTemplate.Height = 24;
            this.dgvCobrosCanceladosLINQAnon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobrosCanceladosLINQAnon.Size = new System.Drawing.Size(545, 201);
            this.dgvCobrosCanceladosLINQAnon.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 848);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosPendientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosLINQ)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosIComparable)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobrosCanceladosLINQAnon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCobrosPendientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCobroVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCobroNombre;
        private System.Windows.Forms.TextBox txtCobroCodigo;
        private System.Windows.Forms.TextBox txtCobroCliente;
        private System.Windows.Forms.Button btnCobroPagar;
        private System.Windows.Forms.Button btnCobroAlta;
        private System.Windows.Forms.RadioButton rbtCobroEspecial;
        private System.Windows.Forms.RadioButton rbtCobroNormal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCobroImporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCobrosCanceladosLINQ;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvCobrosCanceladosIComparable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbtDESC;
        private System.Windows.Forms.RadioButton rbtASC;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvCobrosCanceladosLINQAnon;
    }
}

