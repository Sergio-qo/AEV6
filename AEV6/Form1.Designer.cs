namespace AEV6
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.grbFuncionalidadesBasicas = new System.Windows.Forms.GroupBox();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnAccesoMantenimiento = new System.Windows.Forms.Button();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.dgwPresencia = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPresencia = new System.Windows.Forms.Label();
            this.dgvPermanencia = new System.Windows.Forms.DataGridView();
            this.FechaFichaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPermanencia = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.grbFuncionalidadesBasicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPresencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(503, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de gestión de fichaje";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.SystemColors.Info;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(15, 25);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(194, 108);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(15, 152);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(194, 108);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // grbFuncionalidadesBasicas
            // 
            this.grbFuncionalidadesBasicas.Controls.Add(this.btnEntrada);
            this.grbFuncionalidadesBasicas.Controls.Add(this.btnSalida);
            this.grbFuncionalidadesBasicas.Location = new System.Drawing.Point(12, 112);
            this.grbFuncionalidadesBasicas.Name = "grbFuncionalidadesBasicas";
            this.grbFuncionalidadesBasicas.Size = new System.Drawing.Size(226, 278);
            this.grbFuncionalidadesBasicas.TabIndex = 3;
            this.grbFuncionalidadesBasicas.TabStop = false;
            // 
            // btnPresencia
            // 
            this.btnPresencia.Location = new System.Drawing.Point(273, 152);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(141, 40);
            this.btnPresencia.TabIndex = 4;
            this.btnPresencia.Text = "PRESENCIA";
            this.btnPresencia.UseVisualStyleBackColor = true;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.Location = new System.Drawing.Point(273, 206);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(141, 40);
            this.btnPermanencia.TabIndex = 5;
            this.btnPermanencia.Text = "PERMANENCIA";
            this.btnPermanencia.UseVisualStyleBackColor = true;
            // 
            // btnAccesoMantenimiento
            // 
            this.btnAccesoMantenimiento.Location = new System.Drawing.Point(261, 265);
            this.btnAccesoMantenimiento.Name = "btnAccesoMantenimiento";
            this.btnAccesoMantenimiento.Size = new System.Drawing.Size(164, 63);
            this.btnAccesoMantenimiento.TabIndex = 6;
            this.btnAccesoMantenimiento.Text = "ACCESO MANTENIMIENTO";
            this.btnAccesoMantenimiento.UseVisualStyleBackColor = true;
            this.btnAccesoMantenimiento.Click += new System.EventHandler(this.btnAccesoMantenimiento_Click);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(590, 292);
            this.dtpSalida.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpSalida.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 26);
            this.dtpSalida.TabIndex = 14;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(590, 245);
            this.dtpEntrada.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtpEntrada.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 26);
            this.dtpEntrada.TabIndex = 13;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(510, 245);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 20);
            this.lblEntrada.TabIndex = 15;
            this.lblEntrada.Text = "Entrada:";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(555, 180);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(164, 26);
            this.txtNif.TabIndex = 8;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(510, 298);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(53, 20);
            this.lblSalida.TabIndex = 16;
            this.lblSalida.Text = "Salida";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(510, 180);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(39, 20);
            this.lblNif.TabIndex = 7;
            this.lblNif.Text = "NIF:";
            // 
            // dgwPresencia
            // 
            this.dgwPresencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPresencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.HoraEntrada,
            this.HoraSalida});
            this.dgwPresencia.Location = new System.Drawing.Point(858, 112);
            this.dgwPresencia.Name = "dgwPresencia";
            this.dgwPresencia.RowTemplate.Height = 28;
            this.dgwPresencia.Size = new System.Drawing.Size(442, 132);
            this.dgwPresencia.TabIndex = 17;
            this.dgwPresencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Salida";
            this.HoraSalida.Name = "HoraSalida";
            // 
            // lblPresencia
            // 
            this.lblPresencia.AutoSize = true;
            this.lblPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresencia.Location = new System.Drawing.Point(854, 89);
            this.lblPresencia.Name = "lblPresencia";
            this.lblPresencia.Size = new System.Drawing.Size(285, 20);
            this.lblPresencia.TabIndex = 18;
            this.lblPresencia.Text = "Empleados en la empresa actualmente";
            this.lblPresencia.Visible = false;
            // 
            // dgvPermanencia
            // 
            this.dgvPermanencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermanencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaFichaje,
            this.Entrada,
            this.Salida,
            this.DuracionTotal});
            this.dgvPermanencia.Location = new System.Drawing.Point(858, 312);
            this.dgvPermanencia.Name = "dgvPermanencia";
            this.dgvPermanencia.RowTemplate.Height = 28;
            this.dgvPermanencia.Size = new System.Drawing.Size(442, 165);
            this.dgvPermanencia.TabIndex = 19;
            // 
            // FechaFichaje
            // 
            this.FechaFichaje.HeaderText = "Fecha";
            this.FechaFichaje.Name = "FechaFichaje";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Hora Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Hora salida";
            this.Salida.Name = "Salida";
            // 
            // DuracionTotal
            // 
            this.DuracionTotal.HeaderText = "Duracion total";
            this.DuracionTotal.Name = "DuracionTotal";
            // 
            // lblPermanencia
            // 
            this.lblPermanencia.AutoSize = true;
            this.lblPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanencia.Location = new System.Drawing.Point(854, 289);
            this.lblPermanencia.Name = "lblPermanencia";
            this.lblPermanencia.Size = new System.Drawing.Size(140, 20);
            this.lblPermanencia.TabIndex = 20;
            this.lblPermanencia.Text = "Historial empleado";
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(22, 78);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 20);
            this.lblReloj.TabIndex = 21;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 489);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblPermanencia);
            this.Controls.Add(this.dgvPermanencia);
            this.Controls.Add(this.lblPresencia);
            this.Controls.Add(this.dgwPresencia);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.txtNif);
            this.Controls.Add(this.btnAccesoMantenimiento);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.grbFuncionalidadesBasicas);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbFuncionalidadesBasicas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPresencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermanencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.GroupBox grbFuncionalidadesBasicas;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnAccesoMantenimiento;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.DataGridView dgwPresencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.Label lblPresencia;
        private System.Windows.Forms.DataGridView dgvPermanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFichaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionTotal;
        private System.Windows.Forms.Label lblPermanencia;
        public System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblReloj;
    }
}

