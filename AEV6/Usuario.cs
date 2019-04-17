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
        private string horaEntrada;
        private ConexionBD bdatos = new ConexionBD();
        FIchaje fich = new FIchaje();

        //Propiedades de acceso de los atributos.
        public bool Admin { get {return this.admin; }}
        public string Nif { get { return this.NIF; } set { this.NIF = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Clave { get { return this.clave; }}
        public string HoraEntrada { get { return this.horaEntrada; } set { this.horaEntrada = value; } }

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
                    //Rompe, se sale
                    break;
                }
            }
            if (NIF == "")
            {
                //No hace nada, se sale
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
                    MySqlCommand comando;   //Aquí guardamos la bbdd y la consulta
                    int res;

                    consulta = String.Format("select * from usuarios where nif='{0}'", NIF);
                    comando = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = comando.ExecuteReader();   //ExecuterReader devuelve la lista virtual de los datos que muestra la consulta que hemos hecho.

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    while (reader.HasRows == false || ComprobarNif(NIF) == false)
                    {
                        reader.Close();
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
                    reader.Close();

                    //Si el ExecuteNonQuery devuelve un valor (O sea hay registros en la tabla que coincidan con ese nif)
                    if(NIF == "")
                    {

                    }
                    else
                    {
                        
                            consulta = String.Format("select * from usuarios where nif='{0}' and estado=true", NIF);
                            comando = new MySqlCommand(consulta, conexion);
                            reader = comando.ExecuteReader();

                        if (reader.HasRows)  //Si el ExecuteReader tiene lineas en la lista virtual significa que ese usuario con ese nif ya está dentro
                        {
                            MessageBox.Show("El usuario ya está dentro");
                        }
                        else
                        {
                            //Si no actualiza la bbdd poniendo el estado a true de ese usuario con ese nif

                            reader.Close();
                            consulta = String.Format("update usuarios set estado=true where nif='{0}'", NIF);    //No sería update usuarios set estado=true where nif=loquesea
                            comando = new MySqlCommand(consulta, conexion);
                            res = comando.ExecuteNonQuery();    //Esto porque?
                            MessageBox.Show("Bienvenido");
                            fich.HoraEntrada = DateAndTime.Now.ToString("hh:mm tt");
                            fich.EntradaFichaje(DateAndTime.Now.ToString("dd/mm/yy"), DateAndTime.Now.ToString("hh:mm tt"), NIF);
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
                    MySqlDataReader reader = comando.ExecuteReader();

                    //Si la consulta no devuelve ningún valor o el nif es incorrecto entra en el WHILE
                    while (reader.HasRows == false || ComprobarNif(NIF) == false)
                    {
                        reader.Close();
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
                    reader.Close();
                    //Si el ExecuteNonQuery devuelve un valor (O sea hay registros en la tabla que coincidan con ese nif)
                    if (NIF == "")
                    {

                    }   
                    else
                    {

                        consulta = String.Format("select * from usuarios where nif='{0}' and estado=false", NIF);
                        comando = new MySqlCommand(consulta, conexion);
                        reader = comando.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("El usuario no está dentro");
                        }
                        else
                        {
                            reader.Close();
                            consulta = String.Format("update usuarios set estado=false where nif='{0}'",NIF);
                            comando = new MySqlCommand(consulta, conexion);
                            res = comando.ExecuteNonQuery();    //Esto porque?
                            MessageBox.Show("Hasta la próxima");

                            fich.SalidaFichaje(DateAndTime.Now.ToString("dd/mm/yy"), DateAndTime.Now.ToString("hh:mm tt"), NIF);
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
            if (bdatos.AbrirConexion()) //Hago esto si funciona la conexión
            {

                string consulta1 = String.Format("Select horaEntrada from fichaje where fichado='{0}'", 1);
                MySqlConnection conexion1 = bdatos.Conexion;
                MySqlCommand comando1 = new MySqlCommand(consulta1, conexion1);
                MySqlDataReader reader1 = comando1.ExecuteReader();
                int i = 0;
                while (reader1.Read())
                {
                    usus[i].horaEntrada = reader1.GetString(0);
                    i++;
                }
                bdatos.CerrarConexion();

                bdatos.AbrirConexion();
                string consulta2 = String.Format("select nombre,apellido from usuarios where estado='{0}'",1); //Creo la consulta
                MySqlConnection conexion2 = bdatos.Conexion; //Obtengo la conexion
                MySqlCommand comando2 = new MySqlCommand(consulta2, conexion2); //Creo el comando a enviar
                MySqlDataReader reader2 = comando2.ExecuteReader(); //Creo un objeto reader con lo que devuelve execute reader(lista virtual) del comando
                i = 0;
                while (reader2.Read()) //Por cada lectura creo un usuario y lo añado a la lista con los datos de el registro que devuelve
                {
                    foreach (Usuario item in usus)
                    {
                        item.Nombre = reader2.GetString(0);
                        item.Apellido = reader2.GetString(1);
                    }

                    //usus[i].Nombre = reader2.GetString(0);
                    //usus[i].Apellido = reader2.GetString(1);
                    //i++;
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
                            if (hecho) //Si ha hecho un ciclo aviso de que la calve es incorrecta
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
                                if (reader.IsDBNull(0)) //Si devuelve un valor nulo
                                {
                                    claveadmin = "NULL";
                                }
                                else
                                {
                                    claveadmin = reader.GetString(0);
                                }
                                
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









        public void AgregarEmpleado(string NIF, string nombre, string apellido, bool admin, string clave)
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
                if (bdatos.AbrirConexion())
                {
                    MySqlConnection conexion = bdatos.Conexion;
                    string consulta = String.Format("insert into usuarios values('{0}', '{1}', '{2}', {3}, '{4}', 0)", NIF, nombre, apellido, admin, clave);
                    string consulta2 = String.Format("select nif from usuarios where nif = '{0}'", NIF);    //Consulta para comprobar si ya existe ese nif
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);
                    MySqlCommand comando2 = new MySqlCommand(consulta2, conexion);  //Comando para la comprobación de si hay un usuario con esos datos


                    MySqlDataReader reader = comando2.ExecuteReader();
                    if (reader.Read())  //Si el reader devuelve algún valor es que el usuario ya está en la bbdd por lo tanto no se puede dar de alta
                    {
                        MessageBox.Show("El usuario ya existe");
                    }
                    else   //Si no si el ExecuteNonQuery devuelve un número positivo es porque ha agregado al usuario
                    {

                        int res = comando.ExecuteNonQuery();
                        if (res >= 0)
                        {
                            MessageBox.Show("Usuario agregado con éxito");
                        }
                        else  //Esta parte del else creo que no hace falta
                        {
                            MessageBox.Show("Error al agregar usuario");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
        }







        public void EliminarEmpleado(string NIF, string nombre, string apellido)
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
                if (bdatos.AbrirConexion())
                {
                    MySqlConnection conexion = bdatos.Conexion;
                    string consulta = String.Format("delete * from usuarios WHERE nif = '{0}'",NIF);
                    MySqlCommand comando = new MySqlCommand(consulta,conexion);

                    int resultado = comando.ExecuteNonQuery();

                    if(resultado >= 1)
                    {
                        MessageBox.Show("Usuario eliminado con éxito");

                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado");
                    }
                }
                else
                {
                    MessageBox.Show("Error al conectar con la base de datos");
                }
            }
        }






        public List<Usuario> GenerarInforme1()
        {
            
            List<Usuario> usus = new List<Usuario>();

            if (bdatos.AbrirConexion())
            {
                MySqlConnection conexion = bdatos.Conexion;
                string consulta = String.Format("select * from usuarios", NIF);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Por cada lectura creo un usuario y lo añado a la lista con los datos de el registro que devuelve
                    {
                        usus.Add(new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                    }

                }
                else
                {
                    MessageBox.Show("No hay usuarios registrados");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            bdatos.CerrarConexion();
            return usus;
        }






        public List<FIchaje> GenerarInforme2()
        {

            List<FIchaje> fichas = new List<FIchaje>();

            if (bdatos.AbrirConexion())
            {
                MySqlConnection conexion = bdatos.Conexion;
                string consulta = String.Format("select * from fichaje", NIF);
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) //Por cada lectura creo un usuario y lo añado a la lista con los datos de el registro que devuelve
                    {
                        fichas.Add(new FIchaje(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4)));
                        
                    }

                }
                else
                {
                    MessageBox.Show("No hay usuarios registrados");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
            bdatos.CerrarConexion();
            return fichas;
        }








        public void SalirMantenimiento()
        {
            FormPrincipal formularioPrincipal = new FormPrincipal();
            formularioPrincipal.Show();

        }








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
