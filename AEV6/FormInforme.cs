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
    //Clase para gestionar el formulario donde se muestran los informes generados por mantenimiento
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            
            Usuario usu = new Usuario();
            List<Usuario> usus = new List<Usuario>();

            List<FIchaje> fichas = new List<FIchaje>();

            usus = usu.GenerarInforme1();    //Llamamos aquí al método de generarinforme del usuario
            foreach (Usuario usuario in usus)
            {
                dgvInformeDatos.Rows.Add(usuario.Nif, usuario.Nombre, usuario.Apellido, usuario.Admin);
            }
            //Se carga lo que devuelve el método (una lista de usuarios con sus datos) en el datagriedview de los datos


            fichas = usu.GenerarInforme2();
            foreach (FIchaje item in fichas)
            {
                dgvInformeFichaje.Rows.Add(item.Nif, item.Dia, item.HoraEntrada, item.HoraSalida, item.Fichado);
            }
            
        }

        private void dgvInformeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
