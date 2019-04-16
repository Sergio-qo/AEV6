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
            this.dgvInformeDatos.Location = new System.Drawing.Point(11, 38);
            this.dgvInformeDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformeDatos.Name = "dgvInformeDatos";
            this.dgvInformeDatos.RowTemplate.Height = 28;
            this.dgvInformeDatos.Size = new System.Drawing.Size(443, 168);
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
            this.dgvInformeFichaje.Location = new System.Drawing.Point(10, 253);
            this.dgvInformeFichaje.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformeFichaje.Name = "dgvInformeFichaje";
            this.dgvInformeFichaje.RowTemplate.Height = 28;
            this.dgvInformeFichaje.Size = new System.Drawing.Size(543, 139);
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
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 403);
            this.Controls.Add(this.dgvInformeFichaje);
            this.Controls.Add(this.dgvInformeDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInforme";
            this.Text = "FormInforme";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeFichaje)).EndInit();
            this.ResumeLayout(false);

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
    }
}