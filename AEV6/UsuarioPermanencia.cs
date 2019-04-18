using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AEV6
{
    class UsuarioPermanencia
    {
        private string NIF;
        private string horaEntrada;
        private string horaSalida;
        private string fechaFichaje;
        //private DateTime horaCalculada;
        private string horaCalculada;
        private ConexionBD bdatos = new ConexionBD();

        public string Nif { get { return this.NIF; } set { this.NIF = value; } }
        public string HoraEntrada { get { return this.horaEntrada; } set { this.horaEntrada = value; } }
        public string HoraSalida { get { return this.horaSalida; } set { this.horaSalida = value; } }
        public string FechaFichaje { get { return this.fechaFichaje; } set { this.fechaFichaje = value; } }
        //public DateTime HoraCalculada { get { return this.horaCalculada; } set { this.horaCalculada = value; } }
        public string HoraCalculada { get { return this.horaCalculada; } set { this.horaCalculada = value; } }

        public UsuarioPermanencia(string nif, string horaEntrada, string horaSalida, string fechaFichaje, string horaCalculada)
        {
            this.NIF = nif;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.fechaFichaje = fechaFichaje;
            this.horaCalculada = horaCalculada;
        }

        public UsuarioPermanencia()
        {

        }


        public List<UsuarioPermanencia> Permanencia(string NIF, string fechaEntrada, string fechaSalida)
        {
            List<UsuarioPermanencia> usups = new List<UsuarioPermanencia>();
            while (ComprobarNif(NIF) == false)  //Comprueba si el NIF introducido tiene formato correcto y letra.
            {
                NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                if (NIF == "")
                {
                    break;
                }
            }


            if (NIF != "")
            {
                //Si conecta la BBDD
                
                if (bdatos.AbrirConexion())
                {
                    MySqlConnection conexion = bdatos.Conexion; //Le indicamos los datos de la BBDD a la que va a hacer la consulta
                    string consulta;    //Variable para guardar la consulta SQL
                    MySqlCommand comando;   //Aquí guardamos la bbdd y la consulta
                    int res;
                    string fechaBaseEntrada = DateTime.Parse(fechaEntrada).ToString("dd/mm/yy");
                    string fechaBaseSalida = DateTime.Parse(fechaSalida).ToString("dd/mm/yy");
                    consulta = String.Format("select nif, dia, horaEntrada, horaSalida from fichaje where nif='{0}' and dia between '{1}' and '{2}'", NIF, fechaEntrada, fechaSalida);
                    comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();
                    DateTime horaCalculada = DateTime.Parse("00:00:00");
                    while (reader.Read())
                    {
                        horaCalculada += DateTime.Parse(reader.GetString(3)) - DateTime.Parse(reader.GetString(2));
                        usups.Add(new UsuarioPermanencia(reader.GetString(0), reader.GetString(2), reader.GetString(3), reader.GetString(1), horaCalculada.ToString("HH:mm:ss")));
                        horaCalculada = DateTime.Parse("00:00:00"); //Esto lo pongo porque con un igual no dejava asignar la hora calculada y asi se ve la duracion de cada fichaje
                    }
                    //MessageBox.Show(this.horaCalculada.ToString("HH:mm:ss"));
                    //ExecuterReader devuelve la lista virtual de los datos que muestra la consulta que hemos hecho.

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    


                }

            }
            return usups;
        }







        private bool ComprobarNif(string NIF)
        {
            if (NIF.Length == 9)
            {
                string abecedario = "TRWAGMYFPDXBNJZSQVHLCKE";
                char letraoriginal = NIF[8];
                string NIFn = "";
                for (int i = 0; i <= 7; i++)     //Bucle for se puede intentar quitar en un futuro
                {
                    NIFn += NIF[i];
                }
                char letra = abecedario[int.Parse(NIFn) % 23];
                if (char.ToUpper(letraoriginal) == char.ToUpper(letra))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
