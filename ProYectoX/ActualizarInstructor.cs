using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProYectoX
{
    public partial class ActualizarInstructor : Gtk.Window
    {
        Validacioness vali;
        int tipo;
        int id;
        ProYectoX.ConectorBD cone;
        public ActualizarInstructor(int tip, int id = 0) :
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
                MySqlCommand cmd = new MySqlCommand("SELECT * from instructores WHERE id =" + this.id + "", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entcedinst.Text = rea["cedula"].ToString();
                        entcedinst.Sensitive = false;
                        entnombinst.Text = rea["nombres"].ToString();
                        entapellidoinst.Text = rea["apellidos"].ToString();
                        entdireccioninst.Text = rea["direccion"].ToString();
                        enttelefonoinst.Text = rea["telefono"].ToString();
                        if (rea["sexo"].ToString() == "F")
                            combobox2.Active = 0;
                        else
                            combobox2.Active = 1; 


                        calendar5.Date =Convert.ToDateTime(rea["fecha_nacimiento"]); 

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
        public Boolean validarinstructor()
        {
            if (entcedinst.Text == "" || entnombinst.Text == ""
                || entapellidoinst.Text == "" || entdireccioninst.Text == ""
                || enttelefonoinst.Text == "" || combobox2.Active == -1)
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING");
                return false;
            }
            else {
                // Save today's date.
                var today = DateTime.Today;
                // Calculate the age.
                var age = today.Year - calendar5.Year;
                System.Console.WriteLine( combobox2.ActiveText);
                System.Console.WriteLine(age.ToString());
                if ( (combobox2.ActiveText == "F" && age > 20 && age < 30) || (combobox2.ActiveText == "M" && age > 25 && age < 40)){
                    return true;
                }else{
                    vali.DialogOK("AVISO", "\nDisculpe, no cumple con los requisitos de edad.", "WARNING");
                    return false;
                   
                }
                  

           
            }
        }
        protected void OnEntcedinstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entcedinst);
        }

        protected void OnEntnombinstChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entnombinst);
        }

        protected void OnEntapellidoinstChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoinst);
        }

        protected void OnEntdireccioninstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entdireccioninst);
        }

        protected void OnEnttelefonoinstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(enttelefonoinst);  
        }


        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
            //guardarinstructor();
            if (validarinstructor()){
                string fecha_nacimiento = calendar5.GetDate().ToString("yyyy-MM-dd");
                string sexo = combobox2.ActiveText;
                if (this.tipo == 1)
                {
                    //crear
                    Boolean busc = cone.BuscarSinEstatus("cedula", "instructores", entcedinst.Text);
                    if (busc == true)
                    {
                        vali.DialogOK("Error", "Ya existe un registro con esa clave principal", "error");
                    }
                    else
                    {
                        
                        cone.EjecutarSentencia("INSERT INTO instructores(cedula,nombres,apellidos,direccion,telefono,fecha_nacimiento,sexo) VALUES " +
                                               "('" + entcedinst.Text + "','" + entnombinst.Text + "'" +
                                               ",'" + entapellidoinst.Text + "','" + entdireccioninst.Text + "'," +
                                               "'" + enttelefonoinst.Text + "','" + fecha_nacimiento + "','" + sexo + "')");
                        vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                        Hide();
                        ListadoArchivos list = new ListadoArchivos("instructores");
                        list.Show();
                    }

                }
                else
                {
                    cone.EjecutarSentencia("UPDATE instructores SET nombres='" + entnombinst.Text + "', apellidos='" + entapellidoinst.Text + "'" +
                                           ",direccion='" + entdireccioninst.Text + "', telefono='" + enttelefonoinst.Text + "'," +
                                           "fecha_nacimiento='" + fecha_nacimiento + "', sexo='" + sexo + "' WHERE id ='" + this.id + "'");
                    vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                    //editar


                }
            }
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
            Hide();
            ListadoArchivos list = new ListadoArchivos("instructores");
            list.Show();
        }

    }
}
