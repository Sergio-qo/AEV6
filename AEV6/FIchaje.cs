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

        public string Nif { get {return this.nif; } set {this.nif=value; } }
        public string Dia { get { return this.dia; } set { this.dia = value; } }
        public string HoraEntrada { get { return this.horaEntrada; } set { this.horaEntrada = value; } }
        public string HoraSalida { get { return this.horaSalida; } set { this.horaSalida = value; } }
        public bool Fichado { get { return this.fichado; } set { this.fichado = value; } }

        //Constructor 1
        public FIchaje()
        {

        }

        public FIchaje(string nif, string dia, string horaEntrada, string horaSalida, bool fichado)
        {
            this.nif = nif;
            this.dia = dia;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.fichado = fichado;
        }






        public void EntradaFichaje(string dia, string horaEntrada, string nif)
        {
            this.fichado = true;
            this.dia = dia;
            this.horaEntrada = horaEntrada;
            this.nif = nif;

            ConexionBD conexion = new ConexionBD();
            if (conexion.AbrirConexion())
            {
                string consulta = String.Format("select * from fichaje where fichado='{0}' And nif='{1}'", 1,this.nif);   //Selecciona los todo de los que esten con el estado a 1 y nif sea igual (Esten fichados)
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows) //Si devuelve filas
                {
                    reader.Close();
                    MessageBox.Show("Usuario ya ha fichado");
                   
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






        public void SalidaFichaje(string dia, string horaSalida, string nif)
        {
            this.fichado = false;
            this.dia = dia;
            this.horaSalida = horaSalida;
            this.nif = nif;
            

            ConexionBD conexion = new ConexionBD();
            if (conexion.AbrirConexion())
            {
                string consulta = String.Format("select * from fichaje where nif='{0}' AND fichado='{1}'", this.nif, 1);
                MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    consulta = String.Format("update fichaje set horaSalida='{0}', fichado={1}, dia='{2}' WHERE nif='{3}'AND fichado='{4}' ", this.horaSalida, this.fichado, this.dia, this.nif, 1);
                    comando = new MySqlCommand(consulta, conexion.Conexion);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("El usuario no ha fichado");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }


    }
}
