using System;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ActualizarEstudiante : Gtk.Window
    {
        Validacioness vali;
        int tipo;
        int id;
        ProYectoX.ConectorBD cone;
        public ActualizarEstudiante(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.tipo = tip;
            this.Build();
            this.tipo = tip;
            this.id = id;
            System.Console.WriteLine("tipo " + this.tipo.ToString());
            System.Console.WriteLine("id " + this.id.ToString());
            cone = new ProYectoX.ConectorBD(this);
            vali = new ProYectoX.Validacioness();
            iniciar();
            ComenzarTimer();
       
        }
        protected void ComenzarTimer()
        {
            // Se ejecuta cada 1000 milisegundos (1s)

            GLib.Timeout.Add(1000, new GLib.TimeoutHandler(update_fechahora));
        }

        protected bool update_fechahora()
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            return true;
        }
        public void iniciar()
        {
            if (this.tipo == 1)
            {
                //crear
            }
            else
            {

                //editar
                MySqlConnection con = this.cone.getConection();
                MySqlCommand cmd = new MySqlCommand("SELECT * from estudiantes WHERE id =" + this.id + "", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entcedest.Text = rea["cedula"].ToString();
                        entcedest.Sensitive = false;
                        entnombest.Text = rea["nombres"].ToString();
                        entapellidoest.Text = rea["apellidos"].ToString();
                        entdireccionest.Text = rea["direccion"].ToString();
                        enttelefonoest.Text = rea["telefono"].ToString();
                        if (rea["sexo"].ToString() == "F")
                            comboboxsexest.Active = 0;
                        else
                            comboboxsexest.Active = 1;


                        calendar6.Date = Convert.ToDateTime(rea["fecha_nacimiento"]);

                    }
                    rea.Close();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("error : " + ex);
                    throw new Exception(ex.Message);
                }
                con.Close();


            }
        }
        public Boolean validarestudiante()
        {
            if (entcedest.Text == "" || entnombest.Text == ""
                || entapellidoest.Text == "" || entdireccionest.Text == ""
                || enttelefonoest.Text == "" || comboboxsexest.Active == -1)
            {
                vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING");
                return false;
            }
            else
            {

                return true;




            }
        }

        protected void OnBtnguardarestudianteClicked(object sender, EventArgs e)
        {
            //guardarinstructor();
            if (validarestudiante())
            {
                string fecha_nacimiento = calendar6.GetDate().ToString("yyyy-MM-dd");
                string sexo = comboboxsexest.ActiveText;
                if (this.tipo == 1)
                {
                    //crear
                    Boolean busc = cone.BuscarSinEstatus("cedula", "estudiantes", entcedest.Text);
                    if (busc == true)
                    {
                        vali.DialogOK("Error", "Ya existe un registro con esa clave principal", "error");
                    }
                    else
                    {

                        cone.EjecutarSentencia("INSERT INTO estudiantes(cedula,nombres,apellidos,direccion,telefono,fecha_nacimiento,sexo) VALUES " +
                                               "('" + entcedest.Text + "','" + entnombest.Text + "'" +
                                               ",'" + entapellidoest.Text + "','" + entdireccionest.Text + "'," +
                                               "'" + enttelefonoest.Text + "','" + fecha_nacimiento + "','" + sexo + "')");
                        vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                        Hide();
                        ListadoArchivos list = new ListadoArchivos("instructores");
                        list.Show();
                    }

                }
                else
                {
                    cone.EjecutarSentencia("UPDATE estudiantes SET nombres='" + entnombest.Text + "', apellidos='" + entapellidoest.Text + "'" +
                                           ",direccion='" + entdireccionest.Text + "', telefono='" + enttelefonoest.Text + "'," +
                                           "fecha_nacimiento='" + fecha_nacimiento + "', sexo='" + sexo + "' WHERE id ='" + this.id + "'");
                    vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                    //editar


                }
            }
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
            ListadoArchivos list = new ListadoArchivos("estudiantes");
            list.Show();
            Hide();
        }

        protected void OnEntcedestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entcedest);
        }

        protected void OnEntnombestChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entnombest);
        }

       /* protected void OnEntapellidoestActivated(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoest);
        }*/

        protected void OnEntdireccionestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entdireccionest);
        }

        protected void OnEnttelefonoestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(enttelefonoest);
        }



        protected void OnEntapellidoestChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoest);
        }

        protected void OnComboboxsexestChanged(object sender, EventArgs e)
        {
        }
    }
}
