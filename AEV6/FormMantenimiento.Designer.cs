namespace AEV6
{
    partial class FormMantenimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimiento));
            this.lblTituloMantenimiento = new System.Windows.Forms.Label();
            this.btnSalirMantenimiento = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNifAltaEmpleado = new System.Windows.Forms.Label();
            this.txtNifAltaEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoAltaEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoAltaEmpleado = new System.Windows.Forms.TextBox();
            this.lblClaveAltaMantenimiento = new System.Windows.Forms.Label();
            this.txtClaveAltaMantenimiento = new System.Windows.Forms.TextBox();
            this.ckbAdministradorAltaMantenimiento = new System.Windows.Forms.CheckBox();
            this.lblNombreAltaMantenimiento = new System.Windows.Forms.Label();
            this.txtNombreAltaMantenimiento = new System.Windows.Forms.TextBox();
            this.lblRelojMantenimiento = new System.Windows.Forms.Label();
            this.timerRelojMantenimiento = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTituloMantenimiento
            // 
            this.lblTituloMantenimiento.AutoSize = true;
            this.lblTituloMantenimiento.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMantenimiento.Location = new System.Drawing.Point(12, 9);
            this.lblTituloMantenimiento.Name = "lblTituloMantenimiento";
            this.lblTituloMantenimiento.Size = new System.Drawing.Size(322, 49);
            this.lblTituloMantenimiento.TabIndex = 1;
            this.lblTituloMantenimiento.Text = "MANTENIMIENTO";
            // 
            // btnSalirMantenimiento
            // 
            this.btnSalirMantenimiento.Location = new System.Drawing.Point(9, 293);
            this.btnSalirMantenimiento.Name = "btnSalirMantenimiento";
            this.btnSalirMantenimiento.Size = new System.Drawing.Size(163, 63);
            this.btnSalirMantenimiento.TabIndex = 25;
            this.btnSalirMantenimiento.Text = "SALIR MANTENIMIENTO";
            this.btnSalirMantenimiento.UseVisualStyleBackColor = true;
            this.btnSalirMantenimiento.Click += new System.EventHandler(this.btnSalirMantenimiento_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(9, 204);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(163, 63);
            this.btnGenerarInforme.TabIndex = 24;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(21, 146);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(141, 40);
            this.btnEliminarEmpleado.TabIndex = 23;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(21, 92);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(141, 40);
            this.btnAgregarEmpleado.TabIndex = 22;
            this.btnAgregarEmpleado.Text = "AGREGAR";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(21, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 40);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNifAltaEmpleado
            // 
            this.lblNifAltaEmpleado.AutoSize = true;
            this.lblNifAltaEmpleado.Location = new System.Drawing.Point(271, 102);
            this.lblNifAltaEmpleado.Name = "lblNifAltaEmpleado";
            this.lblNifAltaEmpleado.Size = new System.Drawing.Size(39, 20);
            this.lblNifAltaEmpleado.TabIndex = 27;
            this.lblNifAltaEmpleado.Text = "NIF:";
            // 
            // txtNifAltaEmpleado
            // 
            this.txtNifAltaEmpleado.Location = new System.Drawing.Point(346, 102);
            this.txtNifAltaEmpleado.Name = "txtNifAltaEmpleado";
            this.txtNifAltaEmpleado.Size = new System.Drawing.Size(165, 26);
            this.txtNifAltaEmpleado.TabIndex = 28;
            // 
            // lblApellidoAltaEmpleado
            // 
            this.lblApellidoAltaEmpleado.AutoSize = true;
            this.lblApellidoAltaEmpleado.Location = new System.Drawing.Point(271, 215);
            this.lblApellidoAltaEmpleado.Name = "lblApellidoAltaEmpleado";
            this.lblApellidoAltaEmpleado.Size = new System.Drawing.Size(69, 20);
            this.lblApellidoAltaEmpleado.TabIndex = 29;
            this.lblApellidoAltaEmpleado.Text = "Apellido:";
            // 
            // txtApellidoAltaEmpleado
            // 
            this.txtApellidoAltaEmpleado.Location = new System.Drawing.Point(346, 215);
            this.txtApellidoAltaEmpleado.Name = "txtApellidoAltaEmpleado";
            this.txtApellidoAltaEmpleado.Size = new System.Drawing.Size(165, 26);
            this.txtApellidoAltaEmpleado.TabIndex = 30;
            // 
            // lblClaveAltaMantenimiento
            // 
            this.lblClaveAltaMantenimiento.AutoSize = true;
            this.lblClaveAltaMantenimiento.Location = new System.Drawing.Point(459, 303);
            this.lblClaveAltaMantenimiento.Name = "lblClaveAltaMantenimiento";
            this.lblClaveAltaMantenimiento.Size = new System.Drawing.Size(52, 20);
            this.lblClaveAltaMantenimiento.TabIndex = 31;
            this.lblClaveAltaMantenimiento.Text = "Clave:";
            // 
            // txtClaveAltaMantenimiento
            // 
            this.txtClaveAltaMantenimiento.Enabled = false;
            this.txtClaveAltaMantenimiento.Location = new System.Drawing.Point(517, 303);
            this.txtClaveAltaMantenimiento.Name = "txtClaveAltaMantenimiento";
            this.txtClaveAltaMantenimiento.Size = new System.Drawing.Size(165, 26);
            this.txtClaveAltaMantenimiento.TabIndex = 32;
            // 
            // ckbAdministradorAltaMantenimiento
            // 
            this.ckbAdministradorAltaMantenimiento.AutoSize = true;
            this.ckbAdministradorAltaMantenimiento.Location = new System.Drawing.Point(275, 299);
            this.ckbAdministradorAltaMantenimiento.Name = "ckbAdministradorAltaMantenimiento";
            this.ckbAdministradorAltaMantenimiento.Size = new System.Drawing.Size(133, 24);
            this.ckbAdministradorAltaMantenimiento.TabIndex = 33;
            this.ckbAdministradorAltaMantenimiento.Text = "Administrador";
            this.ckbAdministradorAltaMantenimiento.UseVisualStyleBackColor = true;
            this.ckbAdministradorAltaMantenimiento.CheckedChanged += new System.EventHandler(this.ckbAdministradorAltaMantenimiento_CheckedChanged);
            // 
            // lblNombreAltaMantenimiento
            // 
            this.lblNombreAltaMantenimiento.AutoSize = true;
            this.lblNombreAltaMantenimiento.Location = new System.Drawing.Point(271, 156);
            this.lblNombreAltaMantenimiento.Name = "lblNombreAltaMantenimiento";
            this.lblNombreAltaMantenimiento.Size = new System.Drawing.Size(69, 20);
            this.lblNombreAltaMantenimiento.TabIndex = 34;
            this.lblNombreAltaMantenimiento.Text = "Nombre:";
            // 
            // txtNombreAltaMantenimiento
            // 
            this.txtNombreAltaMantenimiento.Location = new System.Drawing.Point(346, 156);
            this.txtNombreAltaMantenimiento.Name = "txtNombreAltaMantenimiento";
            this.txtNombreAltaMantenimiento.Size = new System.Drawing.Size(165, 26);
            this.txtNombreAltaMantenimiento.TabIndex = 35;
            // 
            // lblRelojMantenimiento
            // 
            this.lblRelojMantenimiento.AutoSize = true;
            this.lblRelojMantenimiento.Location = new System.Drawing.Point(17, 58);
            this.lblRelojMantenimiento.Name = "lblRelojMantenimiento";
            this.lblRelojMantenimiento.Size = new System.Drawing.Size(0, 20);
            this.lblRelojMantenimiento.TabIndex = 36;
            // 
            // timerRelojMantenimiento
            // 
            this.timerRelojMantenimiento.Interval = 1000;
            this.timerRelojMantenimiento.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRelojMantenimiento);
            this.Controls.Add(this.lblNombreAltaMantenimiento);
            this.Controls.Add(this.txtNombreAltaMantenimiento);
            this.Controls.Add(this.ckbAdministradorAltaMantenimiento);
            this.Controls.Add(this.lblClaveAltaMantenimiento);
            this.Controls.Add(this.txtClaveAltaMantenimiento);
            this.Controls.Add(this.lblApellidoAltaEmpleado);
            this.Controls.Add(this.txtApellidoAltaEmpleado);
            this.Controls.Add(this.lblNifAltaEmpleado);
            this.Controls.Add(this.txtNifAltaEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSalirMantenimiento);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.lblTituloMantenimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMantenimiento;
        private System.Windows.Forms.Button btnSalirMantenimiento;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNifAltaEmpleado;
        private System.Windows.Forms.TextBox txtNifAltaEmpleado;
        private System.Windows.Forms.Label lblApellidoAltaEmpleado;
        private System.Windows.Forms.TextBox txtApellidoAltaEmpleado;
        private System.Windows.Forms.Label lblClaveAltaMantenimiento;
        private System.Windows.Forms.TextBox txtClaveAltaMantenimiento;
        private System.Windows.Forms.CheckBox ckbAdministradorAltaMantenimiento;
        private System.Windows.Forms.Label lblNombreAltaMantenimiento;
        private System.Windows.Forms.TextBox txtNombreAltaMantenimiento;
        private System.Windows.Forms.Label lblRelojMantenimiento;
        private System.Windows.Forms.Timer timerRelojMantenimiento;
    }
}