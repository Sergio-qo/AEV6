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
            this.dgvInformeFichaje = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.APELLIDO});
            this.dgvInformeDatos.Location = new System.Drawing.Point(8, 8);
            this.dgvInformeDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformeDatos.Name = "dgvInformeDatos";
            this.dgvInformeDatos.RowTemplate.Height = 28;
            this.dgvInformeDatos.Size = new System.Drawing.Size(336, 168);
            this.dgvInformeDatos.TabIndex = 0;
            this.dgvInformeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformeDatos_CellContentClick);
            // 
            // dgvInformeFichaje
            // 
            this.dgvInformeFichaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeFichaje.Location = new System.Drawing.Point(361, 11);
            this.dgvInformeFichaje.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInformeFichaje.Name = "dgvInformeFichaje";
            this.dgvInformeFichaje.RowTemplate.Height = 28;
            this.dgvInformeFichaje.Size = new System.Drawing.Size(161, 168);
            this.dgvInformeFichaje.TabIndex = 1;
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
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
    }
}