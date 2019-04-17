namespace AEV6
{
    partial class FormInforme
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
            this.dgvInformeDatos = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformeFichaje = new System.Windows.Forms.DataGridView();
            this.NIFFICHAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAFICHAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORAENTRADAFICHAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORASALIDAFICHAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FICHADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloInformeDatos = new System.Windows.Forms.Label();
            this.lblDatosFichajes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeFichaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformeDatos
            // 
            this.dgvInformeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.NOMBRE,
            this.APELLIDO,
            this.ADMIN});
            this.dgvInformeDatos.Location = new System.Drawing.Point(7, 42);
            this.dgvInformeDatos.Name = "dgvInformeDatos";
            this.dgvInformeDatos.RowTemplate.Height = 28;
            this.dgvInformeDatos.Size = new System.Drawing.Size(664, 274);
            this.dgvInformeDatos.TabIndex = 0;
            this.dgvInformeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformeDatos_CellContentClick);
            // 
            // NIF
            // 
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // ADMIN
            // 
            this.ADMIN.HeaderText = "ADMIN";
            this.ADMIN.Name = "ADMIN";
            // 
            // dgvInformeFichaje
            // 
            this.dgvInformeFichaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeFichaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIFFICHAJE,
            this.DIAFICHAJE,
            this.HORAENTRADAFICHAJE,
            this.HORASALIDAFICHAJE,
            this.FICHADO});
            this.dgvInformeFichaje.Location = new System.Drawing.Point(-4, 385);
            this.dgvInformeFichaje.Name = "dgvInformeFichaje";
            this.dgvInformeFichaje.RowTemplate.Height = 28;
            this.dgvInformeFichaje.Size = new System.Drawing.Size(814, 256);
            this.dgvInformeFichaje.TabIndex = 1;
            // 
            // NIFFICHAJE
            // 
            this.NIFFICHAJE.HeaderText = "NIF";
            this.NIFFICHAJE.Name = "NIFFICHAJE";
            // 
            // DIAFICHAJE
            // 
            this.DIAFICHAJE.HeaderText = "DIA";
            this.DIAFICHAJE.Name = "DIAFICHAJE";
            // 
            // HORAENTRADAFICHAJE
            // 
            this.HORAENTRADAFICHAJE.HeaderText = "HORA DE ENTRADA";
            this.HORAENTRADAFICHAJE.Name = "HORAENTRADAFICHAJE";
            // 
            // HORASALIDAFICHAJE
            // 
            this.HORASALIDAFICHAJE.HeaderText = "HORA DE SALIDA";
            this.HORASALIDAFICHAJE.Name = "HORASALIDAFICHAJE";
            // 
            // FICHADO
            // 
            this.FICHADO.HeaderText = "FICHADO";
            this.FICHADO.Name = "FICHADO";
            // 
            // lblTituloInformeDatos
            // 
            this.lblTituloInformeDatos.AutoSize = true;
            this.lblTituloInformeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformeDatos.Location = new System.Drawing.Point(13, 13);
            this.lblTituloInformeDatos.Name = "lblTituloInformeDatos";
            this.lblTituloInformeDatos.Size = new System.Drawing.Size(200, 26);
            this.lblTituloInformeDatos.TabIndex = 2;
            this.lblTituloInformeDatos.Text = "Datos Empleados";
            // 
            // lblDatosFichajes
            // 
            this.lblDatosFichajes.AutoSize = true;
            this.lblDatosFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosFichajes.Location = new System.Drawing.Point(2, 356);
            this.lblDatosFichajes.Name = "lblDatosFichajes";
            this.lblDatosFichajes.Size = new System.Drawing.Size(170, 26);
            this.lblDatosFichajes.TabIndex = 3;
            this.lblDatosFichajes.Text = "Datos Fichajes";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 729);
            this.Controls.Add(this.lblDatosFichajes);
            this.Controls.Add(this.lblTituloInformeDatos);
            this.Controls.Add(this.dgvInformeFichaje);
            this.Controls.Add(this.dgvInformeDatos);
            this.Name = "FormInforme";
            this.Text = "FormInforme";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeFichaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInformeDatos;
        private System.Windows.Forms.DataGridView dgvInformeFichaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIFFICHAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAFICHAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORAENTRADAFICHAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORASALIDAFICHAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FICHADO;
        private System.Windows.Forms.Label lblTituloInformeDatos;
        private System.Windows.Forms.Label lblDatosFichajes;
    }
}