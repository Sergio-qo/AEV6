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
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
            timerRelojMantenimiento.Enabled = true;  //Inicializamos el timer para que se active nada más encender la aplicación
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Controla que al marcar la casilla de Administrador desbloquea el campo para introducir una Clave.
        private void ckbAdministradorAltaMantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAdministradorAltaMantenimiento.Checked)
            {
                txtClaveAltaMantenimiento.Enabled = true;
            }
            else txtClaveAltaMantenimiento.Enabled = false; ;

        }

        private void btnSalirMantenimiento_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.SalirMantenimiento();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelojMantenimiento.Text = DateTime.Now.ToString();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            bool admin = false;
            if (ckbAdministradorAltaMantenimiento.Checked)
            {
                admin = true;
            }
            usu.AgregarEmpleado(txtNifAltaEmpleado.Text, txtNombreAltaMantenimiento.Text, txtApellidoAltaEmpleado.Text, admin, txtClaveAltaMantenimiento.Text);
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.EliminarEmpleado(txtNifAltaEmpleado.Text, txtNombreAltaMantenimiento.Text, txtApellidoAltaEmpleado.Text);
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            
            //Se llama directamente al otro formulario que es donde se va a mostrar la información
            FormInforme informe = new FormInforme();
            informe.Show();
            

            
        }
    }
}
