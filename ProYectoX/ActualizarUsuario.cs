using System;
using Gtk;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ActualizarUsuario : Gtk.Window
    {
        Validacioness val;
        int tipo;
        int id;
        ProYectoX.ConectorBD cone;
        int[] id_tipousuario;

        public ActualizarUsuario(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
            this.id = id;
            val = new Validacioness();

            cone = new ProYectoX.ConectorBD(this);
            iniciar();


        }
        public void iniciar()

        {
            llenarroles();
            if (this.tipo == 1)
            {
                //crear
            }
            else
            {

                //editar
                MySqlConnection con = this.cone.getConection();
                MySqlCommand cmd = new MySqlCommand("SELECT * from usuarios WHERE id ='" + this.id + "'", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entnombreusuario.Text = rea["nombre_usuario"].ToString();
                        entry3.Text = rea["clave"].ToString();
                        combobox1.Active = val.searchArrayPosition(id_tipousuario, (int)rea["id_tipousuario"]);

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

        public void llenarroles()
        {
            /// ============== roles

            int cont2 = this.cone.Contar("SELECT count(id) from tipo_usuario WHERE estatus='A'");
            this.id_tipousuario = new int[cont2];


            Console.WriteLine(cont2.ToString());

            MySqlCommand cmd;
            MySqlConnection con = this.cone.getConection();
           
                cmd = new MySqlCommand("SELECT * from tipo_usuario WHERE estatus='A'", con);
           
           


            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                int i = 0;
                while (rea.Read())

                {
                    this.combobox1.AppendText(rea["descripcion"].ToString());

                    id_tipousuario[i] = (int)rea["id"];
                    i++;

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
        public bool validarusuario()
        {
            if (entnombreusuario.Text == "" || entry3.Text == "" || combobox1.Active == -1)
            {
                val.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING");
                return false;
            }

            else
            {
                return true;
            }
        }
        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
            ProYectoX.ListadoArchivos list = new ListadoArchivos("usuarios");
            list.Show();
            Hide();
        }

        protected void OnBtnsaliractusuClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
            if(validarusuario())
            {
                int idttiporol = id_tipousuario[combobox1.Active];
                if (this.tipo == 1){
                    Boolean busc = cone.BuscarSinEstatus("nombre_usuario", "usuarios", entnombreusuario.Text);
                    if (busc == true)
                    {
                        val.DialogOK("Error", "Ya existe un registro con esa clave principal", "error");
                    }
                    else
                    {
                        cone.EjecutarSentencia("INSERT INTO usuarios(nombre_usuario,clave,id_tipousuario) VALUES ('" + entnombreusuario.Text + "','" + entry3.Text + "'," + idttiporol + ")");
                        val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                        Hide();
                        ListadoArchivos list = new ListadoArchivos("usuarios");
                        list.Show();

                    }                
                }
                else
                {
                    cone.EjecutarSentencia("UPDATE usuarios SET nombre_usuario='" + entnombreusuario.Text + "',clave='" + entry3.Text + "', id_tipousuario='" + idttiporol + "'  WHERE id ='" + this.id + "'");
                    val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                    //editar   
                }

            }
        }
    }
}
