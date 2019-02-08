using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProYectoX
{
    public class ConectorBD
    {
        private MySqlConnection con;
        Window Vn;
        public ConectorBD(Window nomvent)
        {
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = "localhost";
            scb.Port = 3306;
            scb.UserID = "root";
            scb.Database = "proyectolabii";
            scb.Password = "";
            con = new MySqlConnection(scb.ConnectionString);
            Vn = nomvent;

        }


        /*
         * LO QUE HIZO SHELY
        public string Cadenaconexion()
        {
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = "localhost:3306";
            scb.UserID = "root";
            scb.Database = "damage";
            scb.Password = "";
            return scb.ConnectionString;
        }*/





        //Envía un mensaje en un cuadro de diálogo
        public ResponseType Mensaje(string Msj, ButtonsType Tb, MessageType Tm, string titulo)
        {
            MessageDialog Men = new MessageDialog(Vn, DialogFlags.DestroyWithParent, Tm, Tb, Msj);
            ResponseType Respuesta = (ResponseType)Men.Run();
            Men.Title = titulo;
            Men.Destroy();
            return Respuesta;
        }

        public ResponseType MensajeN(string Msj)
        {
            MessageDialog Men = new MessageDialog(Vn, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Ok, Msj);
            ResponseType Respuesta = (ResponseType)Men.Run();
            Men.Destroy();
            return Respuesta;
        }
                          
        private bool Conectar()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                System.Console.Write(ex.Message);
            }
            return false;
        }

        //Desconecta de la base de datos.
        private bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
            }
            return false;
        }

        //(Inserta, actualiza, elimina)
        public void EjecutarSentencia(string sentencia)
        {
            //Abre la conexión
            if (Conectar() == true)
            {
                //Crea un comando y asigna la conexión.
                MySqlCommand cmd = new MySqlCommand(sentencia, con);
                try
                {
                    //Ejecuta el comando.
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
        }
        //(Validar si existe antes de añadir)
        public bool Buscar(string col, string tabla, string parametro, string estatus)
        {
            string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}' AND {3} = 'A'", col, tabla, parametro, estatus);
            //Abre la conexión.
            if (Conectar())
            {
                //Crea un comando
                MySqlCommand cmd = new MySqlCommand(sentencia, con);

                try
                {
                    int n = Convert.ToInt16(cmd.ExecuteScalar());
                    if (n == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return false;
        }
        public bool Buscar2(string col, string tabla, string parametro, string col2, string parametro2)
        {
            string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}' AND {3} = '{4}' AND estatus = 'A'", col, tabla, parametro, col2, parametro2);
            //Abre la conexión.
            if (Conectar())
            {
                //Crea un comando
                MySqlCommand cmd = new MySqlCommand(sentencia, con);

                try
                {
                    int n = Convert.ToInt16(cmd.ExecuteScalar());
                    if (n == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return false;
        }
        //Verifica si un registro fue previamente eliminado
        public bool BuscarEliminado(string col, string tabla, string parametro, string estatus)
        {
            string sentencia = string.Format("SELECT count({0}) FROM {1} WHERE {0} = '{2}' AND {3} = 'I'", col, tabla, parametro, estatus);
            //Abre la conexión.
            if (Conectar())
            {
                //Crea un comando
                MySqlCommand cmd = new MySqlCommand(sentencia, con);

                try
                {
                    int n = Convert.ToInt16(cmd.ExecuteScalar());
                    if (n == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return false;
        }
        //Cuenta el número de registros que cumplan un requerimiento
        public int Contar(string sentencia)
        {
            int c = -1;

            //Abre la conexión.
            if (Conectar() == true)
            {
                //Crea un comando
                MySqlCommand cmd = new MySqlCommand(sentencia, con);

                //Ejecuta el comando con ExecuteScalar
                try
                {
                    c = int.Parse(cmd.ExecuteScalar() + "");
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return c;
        }
        //Hacer búsqueda de registros en una tabla
        public string[] Listado(int p, string sentencia)
        {
            //Crea arreglo de string que cargará con los datos leídos.
            string[] array = new string[p];

            //Abre la conexión.
            if (Conectar() == true)
            {
                //Crea el comando MySql.
                MySqlCommand cmd = new MySqlCommand(sentencia, con);
                try
                {
                    //Crea y ejecuta el lector de datos.
                    MySqlDataReader read;
                    read = cmd.ExecuteReader();

                    while (read.Read())
                    {

                        //Cargar el arreglo con los datos leídos
                        for (int i = 0; i < p; i++)
                            array[i] = read[i].ToString();
                    }
                    //Cierra el lector
                    read.Close();
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return array;
        }
        public string[] ListadoMD(int i, int j, string sentencia)
        {
            int nelem = i * j;
            int l = 0;
            //Crea arreglo de string que cargará con los datos leídos.
            string[] array = new string[nelem];

            //Abre la conexión.
            if (Conectar() == true)
            {
                //Crea el comando MySql.
                MySqlCommand cmd = new MySqlCommand(sentencia, con);
                try
                {
                    //Crea y ejecuta el lector de datos.
                    MySqlDataReader read;
                    read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        //Cargar el arreglo con los datos leídos
                        for (int k = 0; k < i; k++)
                        {
                            array[k + i * l] = read[k].ToString();
                        }
                        l++;
                    }
                    //Cierra el lector
                    read.Close();
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }
            return array;
        }
        public string EjecutarScalar(string sentencia)
        {
            string escalar = "";

            //Abre la conexión
            if (Conectar() == true)
            {
                //Crea un comando y asigna la conexión.
                MySqlCommand cmd = new MySqlCommand(sentencia, con);
                try
                {
                    //Ejecuta el comando.
                    escalar = cmd.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {
                    Mensaje(ex.Message, ButtonsType.Ok, MessageType.Error, "Error");
                }
                finally
                {
                    cmd.Dispose();
                    Desconectar();
                }
            }

            return escalar;
        }

    }
}