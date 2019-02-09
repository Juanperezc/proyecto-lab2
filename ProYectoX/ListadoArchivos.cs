using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ListadoArchivos : Gtk.Window
    {
        private static string tipo = null;
        ProYectoX.ConectorBD cone;
        ListStore Datos;
        ProYectoX.Validacioness vl;
        /* Constructor listado
         * string tipo
         * */
        public ListadoArchivos(string tip) : base(Gtk.WindowType.Toplevel)
        {
            tipo = tip;
            cone = new ProYectoX.ConectorBD(this);
            vl = new ProYectoX.Validacioness();
            this.Build();
            Datos = cargarEstudiantes();
            treeviewlistado.Model = Datos;

        }

        protected void OnBtncancelarlistClicked(object sender, EventArgs e)
        {
            new ProYectoX.ArchivosMaestros();
            Hide();

        }
        public ListStore cargarEstudiantes()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(string), typeof(string), typeof(string), typeof(string));
            treeviewlistado.AppendColumn("cedula", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("nombre", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("apellido", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("estado", new CellRendererText(), "text", 3);

            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
                    System.Console.WriteLine((string)rea["estatus"]);
                    list.AppendValues(rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString(), rea["estatus"].ToString());

                }
                rea.Close();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("error : " + ex);
                throw new Exception(ex.Message);
            }
            con.Close();
            return list;
        }
        public ListStore estudiantecod(string cod)
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(string), typeof(string), typeof(string), typeof(string));



            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM proyectolabii.estudiantes WHERE cedula LIKE '%" + cod + "%' OR nombres LIKE '%" + cod + "%' OR apellidos LIKE '%" + cod + "%'", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues(rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString(), rea["estatus"].ToString());

                    }
                    rea.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                con.Close();
                return list;
            }
            //}
        }
        protected void OnBtncrearClicked(object sender, EventArgs e)
        {
        }

        protected void OnEntbusquedaChanged(object sender, EventArgs e)
        {
            //if para la busqueda
            treeviewlistado.Model = estudiantecod(entbusqueda.Text.Trim());
        }

        protected void OnTreeviewlistadoRowActivated(object o, RowActivatedArgs args)
        {
            var model = treeviewlistado.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);
            var value = model.GetValue(iter, 0);
            var estatus = model.GetValue(iter, 3);
            Console.WriteLine(value);
            ResponseType resp;
            if (estatus.ToString() == "D"){
                resp = vl.DialogYESNO("OPCIONES", "REACTIVAR", "CANCELAR", "\n¿Desea realmente guardar estos cambios?");
            }else{
               resp = vl.DialogYESNO("OPCIONES", "EDITAR", "ELIMINAR", "\n¿Desea realmente guardar estos cambios?"); 
            }   

           

            if (resp == ResponseType.Yes)
            {
                Console.WriteLine("OPCION1");


            }else{
                Console.WriteLine("OPCION2");
            }
        }
    }
}
