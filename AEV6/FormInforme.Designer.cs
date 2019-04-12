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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeFichaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInformeDatos
            // 
            this.dgvInformeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvInformeDatos.Name = "dgvInformeDatos";
            this.dgvInformeDatos.RowTemplate.Height = 28;
            this.dgvInformeDatos.Size = new System.Drawing.Size(342, 259);
            this.dgvInformeDatos.TabIndex = 0;
            // 
            // dgvInformeFichaje
            // 
            this.dgvInformeFichaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeFichaje.Location = new System.Drawing.Point(376, 12);
            this.dgvInformeFichaje.Name = "dgvInformeFichaje";
            this.dgvInformeFichaje.RowTemplate.Height = 28;
            this.dgvInformeFichaje.Size = new System.Drawing.Size(242, 259);
            this.dgvInformeFichaje.TabIndex = 1;
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInformeFichaje);
            this.Controls.Add(this.dgvInformeDatos);
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
    }
}