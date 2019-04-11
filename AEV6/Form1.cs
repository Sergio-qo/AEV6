using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV6
{
    public partial class FormPrincipal : Form
    {
        

        public FormPrincipal()
        {
            InitializeComponent();
            timerReloj.Enabled = true;  //Inicializamos el timer para que se active nada más encender la aplicación

        }

        //A cada segundo se actualiza la DateTime.Now que lo convertimos a String para que lo muestre el label.
        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Cerrar aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccesoMantenimiento_Click(object sender, EventArgs e)
        {
            this.Hide(); //Se cierra el formulario actual (El principal)

            //Creamos objeto de "FormMantenimiento" para instanciarlo y así poder llamar al método SHOW.
            FormMantenimiento formularioMantenimiento = new FormMantenimiento();
            formularioMantenimiento.Show();

            

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {

            Usuario usu = new Usuario();
            usu.Entrada(txtNif.Text);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Salida(txtNif.Text);
        }
    }
}
