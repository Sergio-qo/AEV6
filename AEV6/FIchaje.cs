using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AEV6
{
    class FIchaje
    {
        private string nif;
        private string dia;
        private string horaEntrada;
        private string horaSalida;
        private bool fichado;

        public void EntradaFichaje(string dia, string horaEntrada, string horaSalida)
        {
            this.fichado = true;
            this.dia = dia;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;

            ConexionBD conexion = new ConexionBD();
            if (conexion.AbrirConexion())
            {
                string consulta = String.Format("insert into fichaje (nif, dia, horaEntrada, horaSalida, fichado values('{0}', '{1}', '{2}', '{3}', '{4}'))", this.nif, this.dia, this.horaEntrada, this.horaSalida, this.fichado);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                comando.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }
    }
}
