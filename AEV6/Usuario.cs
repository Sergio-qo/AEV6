using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace AEV6
{
    class Usuario
    {
        private bool admin = false;
        private string NIF;
        private string nombre;
        private string apellido;
        private string clave;
        private ConexionBD bdatos = new ConexionBD();

        //Propiedades de acceso de los atributos.
        public bool Admin { get {return this.admin; }}
        public string Nif { get { return this.NIF; } set { this.NIF = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Clave { get { return this.clave; }}

        //Primer constructor sin necesidad de pasar parametros.
        public Usuario()
        {
          
        }

        //Segundo constructor pasando parámetros básicos
        public Usuario(string NIF, string nombre, string apellido)
        {
            while (ComprobarNif(NIF) == false)  //Comprueba si el NIF introducido tiene formato correcto y letra.
            {
                NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                if (NIF == "")
                {
                    break;
                }
            }
            if (NIF == "")
            {

            }
            else
            {
                this.NIF = NIF;
                this.nombre = nombre;
                this.apellido = apellido;
                this.admin = false;
                this.clave = "";
            }
        }

        //Tercer constructor para crear un administrador
        public Usuario(string NIF, string nombre, string apellido, string clave)
        {
            while (ComprobarNif(NIF) == false)  //Comprueba si el NIF introducido tiene formato correcto y letra.
            {
                NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                if (NIF == "")
                {
                    break;
                }
            }
            if (NIF == "")
            {

            }
            else
            {
                this.NIF = NIF;
                this.nombre = nombre;
                this.apellido = apellido;
                this.admin = true;
                this.clave = clave;
            }
        }


        public void Entrada(string NIF)
        {
            while (ComprobarNif(NIF) == false)  //Comprueba si el NIF introducido tiene formato correcto y letra.
            {
                NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                if(NIF == "")
                {
                    break;
                }
            } 

            
            if(NIF != "")
            {
                //Si conecta la BBDD
                if (bdatos.AbrirConexion())
                {
                    MySqlConnection conexion = bdatos.Conexion; //Le indicamos los datos de la BBDD a la que va a hacer la consulta
                    string consulta;    //Variable para guardar la consulta SQL
                    MySqlCommand comando;
                    int res;

                    consulta = String.Format("select * from usuarios where nif='{0}'", NIF);
                    comando = new MySqlCommand(consulta, conexion);
                    res = comando.ExecuteNonQuery();

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    while (res <= 0 || ComprobarNif(NIF) == false)
                    {
                        
                        //Si el nif es correcto, significa que el nif no está en la bbdd (porque si no el ExecuteNonQuery hubiese devuelto algún valor)
                        if (ComprobarNif(NIF))
                        {
                            NIF = Interaction.InputBox("Introduce un DNI registrado", "DNI no registrado", "", 500, 300);
                            if(NIF == "")
                            {
                                break;
                            }
                        }
                        else        //Si no es correcto, muestra ventana para que el nif sea apto
                        {
                            NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                            if (NIF == "")
                            {
                                break;
                            }
                        }
                    }

                    //Si el ExecuteNonQuery devuelve un valor (O sea hay registros en la tabla que coincidan con ese nif)
                    if(NIF == "")
                    {

                    }
                    else
                    {
                        
                            consulta = String.Format("select * from usuarios where nif='{0}' and estado=true", NIF);
                            comando = new MySqlCommand(consulta, conexion);
                            res = comando.ExecuteNonQuery();

                        if(res >= 1)
                        {
                            MessageBox.Show("El usuario ya está dentro");
                        }
                        else
                        {
                            consulta = String.Format("update usuarios set estado=true");
                            comando = new MySqlCommand(consulta, conexion);
                            res = comando.ExecuteNonQuery();
                            MessageBox.Show("Bienvenido");
                        }                        
                    }
                    bdatos.CerrarConexion(); //Cierro la conexion
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
            
        }

        public void Salida(string NIF)
        {
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
                    MySqlCommand comando;
                    int res;

                    consulta = String.Format("select * from usuarios where nif='{0}'", NIF);
                    comando = new MySqlCommand(consulta, conexion);
                    res = comando.ExecuteNonQuery();

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    while (res <= 0 || ComprobarNif(NIF) == false)
                    {

                        //Si el nif es correcto, significa que el nif no está en la bbdd (porque si no el ExecuteNonQuery hubiese devuelto algún valor)
                        if (ComprobarNif(NIF))
                        {
                            NIF = Interaction.InputBox("Introduce un DNI registrado", "DNI no registrado", "", 500, 300);
                            if (NIF == "")
                            {
                                break;
                            }
                        }
                        else        //Si no es correcto, muestra ventana para que el nif sea apto
                        {
                            NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                            if (NIF == "")
                            {
                                break;
                            }
                        }
                    }

                    //Si el ExecuteNonQuery devuelve un valor (O sea hay registros en la tabla que coincidan con ese nif)
                    if (NIF == "")
                    {

                    }
                    else
                    {

                        consulta = String.Format("select * from usuarios where nif='{0}' and estado=false", NIF);
                        comando = new MySqlCommand(consulta, conexion);
                        res = comando.ExecuteNonQuery();

                        if (res >= 1)
                        {
                            MessageBox.Show("El usuario no está dentro");
                        }
                        else
                        {
                            consulta = String.Format("update usuarios set estado=false");
                            comando = new MySqlCommand(consulta, conexion);
                            res = comando.ExecuteNonQuery();
                            MessageBox.Show("Hasta la próxima");
                        }
                    }
                    bdatos.CerrarConexion(); //Cierro la conexion
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
        }

       public List<Usuario> Presencia()
       {
            List<Usuario> usus = new List<Usuario>(); //Creo la lista a devolver llena de usuarios
            if (bdatos.AbrirConexion()) //Hago esto si funciona la conxion
            {
                string consulta = String.Format("select * from usuarios"); //Creo la consulta
                MySqlConnection conexion = bdatos.Conexion; //Obtengo la conexion
                MySqlCommand comando = new MySqlCommand(consulta, conexion); //Creo el comando a enviar
                MySqlDataReader reader = comando.ExecuteReader(); //Creo un objeto reader con lo que devuelve execute reader del comando
                while (reader.Read()) //Por cada lectura creo un usuario y lo añado a la lista con los datos de el registro que devuelve
                {
                    usus.Add(new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
                bdatos.CerrarConexion(); //Cierro la conexion
            }
            else //Sino muestro un mensaje de error
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            return usus; //Devuelvo la lista de usuarios
       }

        //    public List<Usuario> Permanencia(string NIF)
        //    {

        //    }

        public string Mantenimiento(string NIF)
        {
            bool admin = false;
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
                    MySqlCommand comando;
                    int res;

                    consulta = String.Format("select * from usuarios where nif='{0}'", NIF);
                    comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    while (reader.HasRows ==false || ComprobarNif(NIF) == false)
                    {

                        //Si el nif es correcto, significa que el nif no está en la bbdd (porque si no el ExecuteNonQuery hubiese devuelto algún valor)
                        if (ComprobarNif(NIF))
                        {
                            NIF = Interaction.InputBox("Introduce un DNI registrado", "DNI no registrado", "", 500, 300);
                            if (NIF == "")
                            {
                                break;
                            }
                        }
                        else        //Si no es correcto, muestra ventana para que el nif sea apto
                        {
                            NIF = Interaction.InputBox("Introduce un NIF correcto", "DNI Incorrecto", "", 500, 300);
                            if (NIF == "")
                            {
                                break;
                            }
                        }
                        reader.Close();
                    }
                    reader.Close();

                    //Si el ExecuteNonQuery devuelve un valor (O sea hay registros en la tabla que coincidan con ese nif)
                    if (NIF == "")
                    {

                    }
                    else
                    {
                        string claveproporcionada;
                        string claveadmin = "";
                        bool hecho = false;
                        do
                        {
                            reader.Close();
                            if (hecho) //Si ha hecho un ciclo aviso de que la calve es incorrecat
                            {
                                claveproporcionada = Interaction.InputBox("Clave", "Clave incorrecta, introduzca su clave de administrador", "", 500, 300);
                            }
                            else //Si no se la pido
                            {
                                claveproporcionada = Interaction.InputBox("Clave", "Introduzca su clave de administrador", "", 500, 300);
                            }

                            //Hago una consulta que saque la calve de un nif
                            consulta = String.Format("select clave from usuarios where nif = '{0}'", NIF);
                            comando = new MySqlCommand(consulta, conexion);
                            reader = comando.ExecuteReader();
                            while (reader.Read()) //Saco la clave del admin
                            {
                                claveadmin = reader.GetString(0);
                            }
                            reader.Close();

                            consulta = String.Format("select admin from usuarios where nif = '{0}'", NIF);
                            comando = new MySqlCommand(consulta, conexion);
                            reader = comando.ExecuteReader();
                            while (reader.Read()) //Saco el campo admin
                            {
                                admin = reader.GetBoolean(0);
                            }
                            hecho = true; //Cuando hago el primer ciclo pongo hecho a true
                        } while (claveproporcionada != claveadmin && claveproporcionada != ""); //Hago esto mientras que la calve sea distinta a la proporcionada y que la clave sea vacia
                        if (claveproporcionada == "" || admin == false) //Si la clave esta vacia o admin es false es que ha cancelado o no es administrador y se avisa de los sucedido
                        {
                            MessageBox.Show("No eres administrador");
                        }
                        else //Sino devuelvo el nif
                        {
                            return NIF;
                        }
                    }
                    bdatos.CerrarConexion(); //Cierro la conexion
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
            return ""; //Si no se es admin al salir devolverá un string vacio
        }

        //    public void AgregarEmpleado(string NIF, string nombre, string apellido, string calve)
        //    {

        //    }

        //    public void EliminarEmpleado(string NIF)
        //    {

        //    }

        //    public void GenerarInforme()
        //    {

        //    }

        //    public void SalirMantenimiento()
        //    {

        //    }

        //    public void SalirAplicacion()
        //    {

        //    }

        //Método para comprobar si la letra del NIF es correcta
        private bool ComprobarNif(string NIF)
        {
            if(NIF.Length == 9)
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
