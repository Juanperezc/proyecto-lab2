using System;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProYectoX
{
    
    public partial class ActualizarCursos : Gtk.Window
                                               
    {
        Validacioness val;
        int tipo;
        int id;
        ProYectoX.ConectorBD cone;
    
        public ActualizarCursos(int tip, int id = 0):
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
            this.id = id;
            val = new Validacioness();

            cone = new ProYectoX.ConectorBD(this);
            iniciar();

        }
        public void iniciar(){
            if (this.tipo == 1){
                //crear
            }else{
                
                //editar
                MySqlConnection con = this.cone.getConection();
                MySqlCommand cmd = new MySqlCommand("SELECT codigo, descripcion from cursos WHERE id ='"+ this.id +"'", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entcodcurso.Text = rea["codigo"].ToString();
                        entcodcurso.Sensitive = false;
                        entdescripcioncurso.Text = rea["descripcion"].ToString();
                     
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
        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
            if (this.tipo == 1)
            {
                //crear
                Boolean busc = cone.BuscarSinEstatus("codigo", "cursos", entcodcurso.Text);
                if (busc == true){
                    val.DialogOK("Error", "Ya existe un registro con esa clave principal", "error");
                }else{
                    cone.EjecutarSentencia("INSERT INTO cursos(codigo,descripcion) VALUES ('" + entcodcurso.Text + "','" + entdescripcioncurso.Text +"')");
                    val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                }

            }
            else
            {
                cone.EjecutarSentencia("UPDATE cursos SET descripcion='" + entdescripcioncurso.Text + "' WHERE id ='" + this.id + "'");
                val.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                //editar

            }
           

        }
        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
            Hide();
            ListadoArchivos list = new ListadoArchivos("cursos");
            list.Show();
        }

        protected void OnEntdescripcioncursoChanged(object sender, EventArgs e)
        {
            val.ValidarLetras(entdescripcioncurso);
        }
    }
}
