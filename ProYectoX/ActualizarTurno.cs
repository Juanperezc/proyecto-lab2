using System;
using Gtk;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ActualizarTurno : Gtk.Window
    {
        Validacioness val;
        int tipo;
        int id;
        ProYectoX.ConectorBD cone;
        string[] turno1 =  new string[10];
        public ActualizarTurno(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
            this.id = id;
            val = new Validacioness();

            cone = new ProYectoX.ConectorBD(this);
            iniciar();
        }

        public void llenarturnos()
        {
            turno1[0] = "8:00";
            turno1[1] = "9:00";
            turno1[2] = "10:00";
            turno1[3] = "11:00";
            turno1[4] = "12:00";
            turno1[5] = "13:00";
            turno1[6] = "14:00";
            turno1[7] = "15:00";
            turno1[8] = "16:00";
            turno1[9] = "17:00";
        }
        public void iniciar()

        {
            llenarturnos();
            if (this.tipo == 1)
            {
                //crear
            }
            else
            {

                //editar
                MySqlConnection con = this.cone.getConection();
                MySqlCommand cmd = new MySqlCommand("SELECT * from turnos WHERE id ='" + this.id + "'", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entdescripcionturno.Text = rea["descripcion"].ToString();
                        Console.Write(rea["hora_inicio"].ToString());
                        combobox2.Active = val.searchArrayPosition(turno1, rea["hora_inicio"].ToString());
                        combobox4.Active = val.searchArrayPosition(turno1, rea["hora_fin"].ToString());

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

        public bool validarturno()
        {
            if (entdescripcionturno.Text == "" || combobox2.Active == -1 || combobox4.Active == -1)
            {
                val.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING");
                return false;
            }

            else
            {
                return true;
            }
        }

        protected void OnBtncancelaractturnoClicked(object sender, EventArgs e)
        {
            ProYectoX.ListadoArchivos list = new ListadoArchivos("turnos");
            list.Show();
            Hide();
        }

        protected void OnBtnguardarturnoClicked(object sender, EventArgs e)
        {
            if(validarturno())
            {
                string turnoa = combobox2.ActiveText;
                string turnob = combobox4.ActiveText;              
                if (this.tipo == 1)
                {
                 
                   
                    cone.EjecutarSentencia("INSERT INTO turnos(descripcion,hora_inicio, hora_fin) VALUES ('" + entdescripcionturno.Text + "','" + turnoa + "','" + turnob + "')");
                        val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                        Hide();
                        ListadoArchivos list = new ListadoArchivos("turnos");
                        list.Show();


                }
                else
                {
                    cone.EjecutarSentencia("UPDATE turnos SET descripcion='" + entdescripcionturno.Text + "',hora_inicio='" + turnoa + "', hora_fin='" + turnob + "'  WHERE id ='" + this.id + "'");
                    val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                    //editar   
                }
            }
        }

        protected void OnEntdescripcionturnoChanged(object sender, EventArgs e)
        {
            val.ValidarLetras(entdescripcionturno);
        }
    }
}
