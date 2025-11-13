namespace VentasCapas.PresentationLayer
{
    partial class FrmProcesoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id cliente:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Location = new System.Drawing.Point(137, 123);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(100, 22);
            this.txtIdVenta.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(137, 177);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(129, 22);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtEntidad
            // 
            this.txtEntidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntidad.Location = new System.Drawing.Point(384, 123);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.ReadOnly = true;
            this.txtEntidad.Size = new System.Drawing.Size(429, 22);
            this.txtEntidad.TabIndex = 10;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(384, 177);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 11;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(518, 167);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(56, 39);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(137, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(288, 225);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 39);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idProducto,
            this.descripcion,
            this.precioUnitario,
            this.cantidad,
            this.subtotal});
            this.dgvLista.Location = new System.Drawing.Point(40, 278);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(848, 384);
            this.dgvLista.TabIndex = 7;
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item.HeaderText = "#";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 43;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 101;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // precioUnitario
            // 
            this.precioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioUnitario.HeaderText = "Precio unitario";
            this.precioUnitario.MinimumWidth = 6;
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.Width = 121;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 90;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 85;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(757, 225);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 39);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo comprobante:";
            // 
            // cboTipoComprobante
            // 
            this.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoComprobante.FormattingEnabled = true;
            this.cboTipoComprobante.Items.AddRange(new object[] {
            "Factura",
            "Boleta"});
            this.cboTipoComprobante.Location = new System.Drawing.Point(163, 36);
            this.cboTipoComprobante.Name = "cboTipoComprobante";
            this.cboTipoComprobante.Size = new System.Drawing.Size(154, 24);
            this.cboTipoComprobante.TabIndex = 0;
            this.cboTipoComprobante.SelectedIndexChanged += new System.EventHandler(this.cboTipoComprobante_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Número:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(397, 36);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(135, 22);
            this.txtSerie.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(643, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(148, 22);
            this.txtNumero.TabIndex = 8;
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(118, 80);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(32, 16);
            this.lblIGV.TabIndex = 13;
            this.lblIGV.Text = "IGV:";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(163, 77);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(100, 22);
            this.txtIGV.TabIndex = 1;
            // 
            // FrmProcesoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 709);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTipoComprobante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmProcesoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCESO VENTA";
            this.Load += new System.EventHandler(this.FrmProcesoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoComprobante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.TextBox txtIGV;
    }
}