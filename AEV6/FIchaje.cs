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

        public void EntradaFichaje(string dia, string horaEntrada, string horaSalida, string nif)
        {
            this.fichado = true;
            this.dia = dia;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.nif = nif;

            ConexionBD conexion = new ConexionBD();
            if (conexion.AbrirConexion())
            {
                string consulta = String.Format("select * from fichaje where nif='{0}'", this.nif);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    consulta = String.Format("update fichaje set horaEntrada='{0}', horaSalida='{1}', fichado={2}, dia='{3}'", this.horaEntrada, this.horaSalida, this.fichado, this.dia);
                    comando = new MySqlCommand(consulta, conexion.Conexion);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    consulta = String.Format("insert into fichaje (nif, dia, horaEntrada, horaSalida, fichado) values('{0}', '{1}', '{2}', '{3}', {4})", this.nif, this.dia, this.horaEntrada, this.horaSalida, this.fichado);
                    comando = new MySqlCommand(consulta, conexion.Conexion);
                    comando.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }
    }
}
