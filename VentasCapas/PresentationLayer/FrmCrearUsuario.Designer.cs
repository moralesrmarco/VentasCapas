namespace VentasCapas.PresentationLayer
{
    partial class FrmCrearUsuario
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
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellidosNombres = new System.Windows.Forms.TextBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rol:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Location = new System.Drawing.Point(230, 54);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtIdUsuario.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Location = new System.Drawing.Point(230, 142);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(178, 22);
            this.txtDni.TabIndex = 1;
            // 
            // txtApellidosNombres
            // 
            this.txtApellidosNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidosNombres.Location = new System.Drawing.Point(230, 98);
            this.txtApellidosNombres.Name = "txtApellidosNombres";
            this.txtApellidosNombres.Size = new System.Drawing.Size(246, 22);
            this.txtApellidosNombres.TabIndex = 0;
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Gerente"});
            this.cboRol.Location = new System.Drawing.Point(230, 274);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(178, 24);
            this.cboRol.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(171, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 29);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Confirmar contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Location = new System.Drawing.Point(230, 186);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(178, 22);
            this.txtClave.TabIndex = 2;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarClave.Location = new System.Drawing.Point(230, 230);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(178, 22);
            this.txtConfirmarClave.TabIndex = 3;
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(335, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(138, 29);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 392);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.txtApellidosNombres);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearUsuario";
            this.Load += new System.EventHandler(this.FrmCrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellidosNombres;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Button btnNuevo;
    }
}