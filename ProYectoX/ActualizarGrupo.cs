using System;
using Gtk;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ActualizarGrupo : Gtk.Window
    {
        int tipo;
        int id;
        int[] id_instructores;
        int[] id_cursos;
        int[] id_turnos;
        int[] id_estudiantes;
        ListStore list = new ListStore(typeof(int), typeof(string));
       
        ProYectoX.Validacioness vali;
        ProYectoX.ConectorBD cone;
        public ActualizarGrupo(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
            this.id = id;

            treeviewest_grupo.AppendColumn("id", new Gtk.CellRendererText(), "text", 0);
            treeviewest_grupo.AppendColumn("Nombre completo", new Gtk.CellRendererText(), "text", 1);
            treeviewest_grupo.Model = list;
            cone = new ProYectoX.ConectorBD(this);
            vali = new Validacioness();
            this.iniciar();
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
            
            cargarComboboxes();
            if (this.tipo == 1)
            {
                //crear
            }
            else
            {
                treeviewedit();
                //editar
                MySqlConnection con = this.cone.getConection();
                MySqlCommand cmd = new MySqlCommand("SELECT * from grupos WHERE id ='" + this.id + "'", con);

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        entcodigogrupo.Text = rea["cod_grupo"].ToString();
                        entcodigogrupo.Sensitive = false;
                        comboinstasigrupo.Active = vali.searchArrayPosition(id_instructores, (int)rea["instructor_id"]);
                        combocursasinggrupo.Active = vali.searchArrayPosition(id_cursos, (int)rea["curso_id"]);
                        comboturnoasiggrupo.Active = vali.searchArrayPosition(id_turnos, (int)rea["turno_id"]);
                        calendar7.Date = Convert.ToDateTime(rea["fecha_inicio"]);
                        calendar8.Date = Convert.ToDateTime(rea["fecha_fin"]);
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
        public void treeviewedit()
        {
           
            //editar
            MySqlConnection con = this.cone.getConection();
                                     MySqlCommand cmd = new MySqlCommand("SELECT e.id,e.nombres,e.apellidos from estudiante_grupos as eg JOIN estudiantes as e ON e.id = eg.id_estudiante WHERE e.estatus='A' AND eg.id_grupo = " + this.id, con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                while (rea.Read())
                {
                    System.Console.WriteLine(" Hay 1 " + rea["nombres"].ToString());
                    list.AppendValues((int)rea["id"], rea["nombres"].ToString() );

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
        public void cargarComboboxes(){
            comboinstructor();
            combocursos();
            comboturnos();
            comboestudiantes();

        }
        public void comboinstructor(){
            /// ============== instructores
            /// this.id
            int cont = this.cone.Contar("SELECT count(id) from instructores WHERE estatus='A'");
            this.id_instructores = new int[cont];


            Console.WriteLine(cont.ToString());


            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT id,apellidos,nombres from instructores WHERE estatus='A'", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                int i = 0;
                while (rea.Read())

                {
                    this.comboinstasigrupo.AppendText(rea["nombres"].ToString() + " " + rea["apellidos"].ToString());
                    id_instructores[i] = (int)rea["id"];
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
        public void combocursos(){
            /// ============== cursos

            int cont2 = this.cone.Contar("SELECT count(id) from cursos WHERE estatus='A'");
            this.id_cursos = new int[cont2];


            Console.WriteLine(cont2.ToString());


            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT id,descripcion from cursos WHERE estatus='A'", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                int i = 0;
                while (rea.Read())

                {
                    this.combocursasinggrupo.AppendText(rea["descripcion"].ToString());
                    id_cursos[i] = (int)rea["id"];
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
        public void comboturnos()
        {
            /// ============== cursos

            int cont2 = this.cone.Contar("SELECT count(id) from turnos WHERE estatus='A'");
            this.id_turnos = new int[cont2];


            Console.WriteLine(cont2.ToString());


            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT id,descripcion from turnos WHERE estatus='A'", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                int i = 0;
                while (rea.Read())

                {
                    this.comboturnoasiggrupo.AppendText(rea["descripcion"].ToString());
                    id_turnos[i] = (int)rea["id"];
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
        public void comboestudiantes()
        {
            /// ============== cursos

            int cont2 = this.cone.Contar("SELECT count(id) from estudiantes WHERE estatus='A'");
            this.id_estudiantes = new int[cont2];


            Console.WriteLine(cont2.ToString());

            MySqlCommand cmd;
            MySqlConnection con = this.cone.getConection();
            if (tipo == 1){
                cmd = new MySqlCommand("SELECT id,nombres,apellidos from estudiantes WHERE estatus='A'", con); 
            }else{
                cmd = new MySqlCommand("SELECT e.id,e.nombres,e.apellidos from estudiante_grupos as eg JOIN  estudiantes as e ON e.id <> eg.id_estudiante WHERE e.estatus='A' AND eg.id_grupo =" + this.id, con);
            }
          

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                int i = 0;
                while (rea.Read())

                {
                    this.comboest_grupo.AppendText(rea["nombres"].ToString() + " " + rea["apellidos"].ToString());
                
                    id_estudiantes[i] = (int)rea["id"];
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
        public void guardargrupo()
        {if (entcodigogrupo.Text == "")
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }

            else {}
         }
        public void agregarTreeview(int id, string  nombre)
        {
           
  
           

           list.AppendValues(id, nombre);
           id_estudiantes = vali.RemoveIndices(id_estudiantes, vali.searchArrayPosition(id_estudiantes, id));


        }

        public bool validarcurso()
        {
            if (entcodigogrupo.Text == "" || comboinstasigrupo.Active == -1 
                || combocursasinggrupo.Active == -1 || comboturnoasiggrupo.Active == -1
                || list.IterNChildren() < 1)
            {
              
                vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING");
                return false;
            }

            else
            {
                return true;
            }
        }
        protected void OnBtnguardargrupoClicked(object sender, EventArgs e)
        {

            if (validarcurso()){
                Console.WriteLine(calendar7.GetDate().ToString("yyyy-MM-dd"));
                string fecha_inicio = calendar7.GetDate().ToString("yyyy-MM-dd");
                string fecha_fin = calendar8.GetDate().ToString("yyyy-MM-dd");
                int instructor = id_instructores[this.comboinstasigrupo.Active];
                int curso = id_cursos[this.combocursasinggrupo.Active];
                int turno = id_turnos[this.comboturnoasiggrupo.Active];
                if (this.tipo == 1)
                {
                    //crear
                    Boolean busc = cone.BuscarSinEstatus("cod_grupo", "grupos", entcodigogrupo.Text);
                    if (busc == true)
                    {
                        vali.DialogOK("Error", "Ya existe un registro con esa clave principal", "error");
                    }
                    else
                    {
                        this.cone.EjecutarSentencia("INSERT INTO grupos(cod_grupo,fecha_inicio,fecha_fin,instructor_id,curso_id,turno_id) VALUES ('" + entcodigogrupo.Text + "'," +
                                                    "'" + fecha_inicio + "','" + fecha_fin + "', " + instructor + "," + curso + "," + turno + ")");

                        int lastid = Convert.ToInt16(cone.LeerUltimoCampo("id", "grupos"));

                        Gtk.TreeModel model = treeviewest_grupo.Model;
                        Gtk.TreeIter iter;
                        if (model.GetIterFirst(out iter))
                        {
                            do
                            {
                                this.cone.EjecutarSentencia("INSERT INTO estudiante_grupos(id_grupo,id_estudiante) VALUES (" + lastid + "," + model.GetValue(iter, 0) + ")");
                                Console.WriteLine("COLUMN 1: " + model.GetValue(iter, 0));
                                Console.WriteLine("COLUMN 2: " + model.GetValue(iter, 1));
                            } while (model.IterNext(ref iter));
                        }


                       
                        vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                        ListadoArchivos lista = new ListadoArchivos("grupos");
                        lista.Show();
                        Hide();
                    }

                
                    //crear
                }
                else
                {
                    this.cone.EjecutarSentencia("UPDATE grupos set cod_grupo='" + entcodigogrupo.Text + "', fecha_inicio = '" + fecha_inicio + "'," +
                                                "fecha_fin = '" + fecha_fin + "',instructor_id =" + instructor + ",curso_id = " + curso + ",turno_id = " + turno + "" +
                                                " WHERE id=" + this.id);
                    this.cone.EjecutarSentencia("Delete from estudiante_grupos WHERE id_grupo=" + this.id);
                    Gtk.TreeModel model = treeviewest_grupo.Model;
                    Gtk.TreeIter iter;
                    if (model.GetIterFirst(out iter))
                    {
                        do
                        {
                            this.cone.EjecutarSentencia("INSERT INTO estudiante_grupos(id_grupo,id_estudiante) VALUES (" + this.id + "," + model.GetValue(iter, 0) + ")");
                            Console.WriteLine("COLUMN 1: " + model.GetValue(iter, 0));
                            Console.WriteLine("COLUMN 2: " + model.GetValue(iter, 1));
                        } while (model.IterNext(ref iter));
                    }



                    vali.DialogOK("EXITO", "El registro se ha guardado correctamente", "info");
                    ListadoArchivos lista = new ListadoArchivos("grupos");
                    lista.Show();
                    Hide();
                }
                 
            }
          
        }

        protected void OnBtncancelargrupoClicked(object sender, EventArgs e)
        {
            Hide();
            ListadoArchivos list = new ListadoArchivos("grupos");
            list.Show();
        }

        protected void OnEntcodigogrupoChanged(object sender, EventArgs e)
        { 
            vali.ValidarAlfanum(entcodigogrupo);
        }

        protected void OnBtnagregarestGrupoClicked(object sender, EventArgs e)
        {
            int active = this.comboest_grupo.Active;
            string nomb = this.comboest_grupo.ActiveText;
            System.Console.WriteLine(nomb);
            System.Console.WriteLine(active.ToString());
            if (active != -1)
            {
                this.agregarTreeview(id_estudiantes[active],nomb);
                this.comboest_grupo.RemoveText(active);

            }
        }
       

        private void RemoveSelectedRows(TreeView treeView, ListStore listStore)
            {
                TreeIter iter;

                TreePath[] treePath = treeView.Selection.GetSelectedRows();

                for (int i  = treePath.Length; i > 0; i--)
                {
                    listStore.GetIter(out iter, treePath[(i - 1)]);

                string value = listStore.GetValue(iter, 0).ToString();
                    Console.WriteLine("Removing: " + value);

                    listStore.Remove(ref iter);
                }
            }

        protected void OnTreeviewestGrupoRowActivated(object o, RowActivatedArgs args)
        {
            var model = treeviewest_grupo.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);
            var id = model.GetValue(iter, 0);
            var nombre = model.GetValue(iter, 1);
            Console.WriteLine(id);
            ResponseType resp;
            resp = vali.DialogYESNO("OPCIONES", "ELIMINAR", "CANCELAR", "\n¿Deseas eliminar este registro?");
            if (resp == ResponseType.Yes)
            {

                //revisar si el curso no ha terminado
                if (DateTime.Now.ToFileTimeUtc() > calendar8.Date.ToFileTimeUtc()){
                    //finalizo puede borrar
                    RemoveSelectedRows(treeviewest_grupo, list);
                   // list.AppendValues(id, nombre);

                }else{
                    //no ha finalizado 
                    vali.DialogOK("AVISO", "\nDisculpe no puedes borrar a un estudiante hasta que haya finalizado el curso.", "WARNING");
                }
                }
         


            else{
                
            }
        }
    }
}
