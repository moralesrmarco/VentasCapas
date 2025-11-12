namespace VentasCapas.PresentationLayer
{
    partial class FrmMantenimientoClienteBuscarCliente
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
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad:";
            // 
            // txtEntidad
            // 
            this.txtEntidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntidad.Location = new System.Drawing.Point(108, 30);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(598, 22);
            this.txtEntidad.TabIndex = 1;
            this.txtEntidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEntidad_KeyUp);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.entidad,
            this.ruc,
            this.idCliente});
            this.dgvLista.Location = new System.Drawing.Point(29, 78);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(746, 360);
            this.dgvLista.TabIndex = 2;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item.HeaderText = " #";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 46;
            // 
            // entidad
            // 
            this.entidad.HeaderText = "Entidad";
            this.entidad.MinimumWidth = 6;
            this.entidad.Name = "entidad";
            this.entidad.ReadOnly = true;
            this.entidad.Width = 125;
            // 
            // ruc
            // 
            this.ruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ruc.HeaderText = "RUC";
            this.ruc.MinimumWidth = 6;
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Width = 65;
            // 
            // idCliente
            // 
            this.idCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 88;
            // 
            // btnLimpiarTxt
            // 
            this.btnLimpiarTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTxt.Location = new System.Drawing.Point(706, 24);
            this.btnLimpiarTxt.Name = "btnLimpiarTxt";
            this.btnLimpiarTxt.Size = new System.Drawing.Size(40, 34);
            this.btnLimpiarTxt.TabIndex = 3;
            this.btnLimpiarTxt.Text = "X";
            this.btnLimpiarTxt.UseVisualStyleBackColor = true;
            this.btnLimpiarTxt.Click += new System.EventHandler(this.btnLimpiarTxt_Click);
            // 
            // FrmMantenimientoClienteBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiarTxt);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMantenimientoClienteBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnLimpiarTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
    }
}