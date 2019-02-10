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
            lbllistado1.Text = "Listado " + tip;
            this.iniciar();
       

        }
        public void iniciar(){
     
            switch(tipo.ToString()){
                case "estudiantes":{
                        this.Datos = cargarEstudiantes();
                        treeviewlistado.Model = this.Datos;
                        break;
                    }
                case "usuarios":{
                        this.Datos = cargarUsuarios();
                        treeviewlistado.Model = this.Datos;  
                        break;
                    }
                case "cursos":
                    {
                        this.Datos = cargarCursos();
                        treeviewlistado.Model = this.Datos;
                        break;
                    }

                case "grupos":
                    {
                        this.Datos = cargarGrupos();
                        treeviewlistado.Model = this.Datos;
                        break;
                    }
                case "turnos":
                    {
                        this.Datos = cargarTurnos();
                        treeviewlistado.Model = this.Datos;
                        break;
                    }
                case "instructores":
                    {
                        this.Datos = cargarInstuctores();
                        treeviewlistado.Model = this.Datos;
                        break;
                    }
            }
          

        }
        protected void OnBtncancelarlistClicked(object sender, EventArgs e)
        {
            new ProYectoX.ArchivosMaestros();
            Hide();

        }

        // ==================== Estudiantes ======================
        public ListStore cargarEstudiantes()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string), typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("cedula", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("nombre", new CellRendererText(), "text", 3);
            treeviewlistado.AppendColumn("apellido", new CellRendererText(), "text", 4);


            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM estudiantes", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
                    System.Console.WriteLine((string)rea["estatus"]);
                    list.AppendValues((int) rea["id"], rea["estatus"].ToString(), rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString());

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

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string), typeof(string));


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
                        list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString());

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
           
        }
        // ==================== Usuarios ======================
        public ListStore cargarUsuarios()
        {
            
            Gtk.ListStore list = new Gtk.ListStore(typeof(int),typeof(string), typeof(string), typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("Nombre de usuario", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("tipo de usuario", new CellRendererText(), "text", 3);
          
            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT  u.id, u.nombre_usuario,t.descripcion,u.estatus FROM usuarios as u JOIN tipo_usuario as t ON u.id_tipousuario=t.id", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
                    list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["nombre_usuario"].ToString(), rea["descripcion"].ToString());
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
        public ListStore usuarioscod(string cod)
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string));



            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT u.id, u.nombre_usuario,t.descripcion,u.estatus FROM usuarios as u JOIN tipo_usuario as t ON u.id_tipousuario=t.id AND u.nombre_usuario LIKE '%" + cod + "%'", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["nombre_usuario"].ToString(), rea["descripcion"].ToString());

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

        }
        // ==================== Cursos ======================
        public ListStore cargarCursos()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("codigo", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("descripcion", new CellRendererText(), "text", 3);
      

            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
           
                    list.AppendValues((int)rea["id"], rea["estatus"].ToString(),rea["codigo"].ToString(), rea["descripcion"].ToString());

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
        public ListStore cursoscod(string cod)
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string));



            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM cursos WHERE codigo LIKE '%" + cod + "%' OR descripcion LIKE '%" + cod + "%'", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["codigo"].ToString(), rea["descripcion"].ToString());

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

        }
        // ==================== Instructores ======================
        public ListStore cargarInstuctores()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                                   typeof(string), typeof(string), typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("cedula", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("nombre", new CellRendererText(), "text", 3);
            treeviewlistado.AppendColumn("apeillido", new CellRendererText(), "text", 4);
            treeviewlistado.AppendColumn("direccion", new CellRendererText(), "text", 5);
            treeviewlistado.AppendColumn("telefono", new CellRendererText(), "text", 6);
      

            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM instructores", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {

                    list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString(),
                                      rea["direccion"].ToString(), rea["telefono"].ToString());

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
        public ListStore instructorescod(string cod)
        {


            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                                   typeof(string), typeof(string), typeof(string));



            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM instructores WHERE cedula LIKE '%" + cod + "%' OR nombres LIKE '%" + cod + "%'", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["cedula"].ToString(), rea["nombres"].ToString(), rea["apellidos"].ToString(),
                                          rea["direccion"].ToString(), rea["telefono"].ToString());

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

        }
        // ==================== Turnos ======================
        public ListStore cargarTurnos()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                                   typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("descipcion", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("hora inicio", new CellRendererText(), "text", 3);
            treeviewlistado.AppendColumn("hora fin", new CellRendererText(), "text", 4);
         ;

            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM turnos", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {

                    list.AppendValues((int)rea["id"],rea["estatus"].ToString(), rea["descripcion"].ToString(),
                                      rea["hora_inicio"].ToString(), rea["hora_fin"].ToString());

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
        public ListStore turnoscod(string cod)
        {


            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                               typeof(string));


            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM turnos WHERE descripcion LIKE '%" + cod + "%'", con);
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues((int)rea["id"],rea["estatus"].ToString(), rea["descripcion"].ToString(), rea["hora_inicio"].ToString(), rea["hora_fin"].ToString());

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

        }
        // ==================== Grupos ======================
        public ListStore cargarGrupos()
        {

            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                                   typeof(string), typeof(string), typeof(string),
                                                   typeof(string));
            treeviewlistado.AppendColumn("id", new CellRendererText(), "text", 0);
            treeviewlistado.AppendColumn("estatus", new CellRendererText(), "text", 1);
            treeviewlistado.AppendColumn("codigo", new CellRendererText(), "text", 2);
            treeviewlistado.AppendColumn("fecha inicio", new CellRendererText(), "text", 3);
            treeviewlistado.AppendColumn("fecha fin", new CellRendererText(), "text", 4);
            treeviewlistado.AppendColumn("insturctor", new CellRendererText(), "text", 5);
            treeviewlistado.AppendColumn("curso", new CellRendererText(), "text", 6);
            treeviewlistado.AppendColumn("turno", new CellRendererText(), "text", 7);


            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT g.id, g.cod_grupo, g.fecha_inicio, g.fecha_fin, i.nombres, c.descripcion, t.descripcion as turno, g.estatus " +
                                                "FROM grupos as g JOIN cursos as c ON g.curso_id = c.id " +
                                                "JOIN instructores as i ON g.instructor_id = i.id JOIN turnos as t ON g.turno_id = t.id", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {

                    list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["cod_grupo"].ToString(), rea["fecha_inicio"].ToString(), rea["fecha_fin"].ToString(),
                                      rea["nombres"].ToString(),rea["descripcion"].ToString(),rea["turno"].ToString());

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
        public ListStore  gruposcod(string cod)
        {


            Gtk.ListStore list = new Gtk.ListStore(typeof(int), typeof(string), typeof(string), typeof(string),
                                                typeof(string), typeof(string), typeof(string),
                                                typeof(string));
            using (MySqlConnection con = this.cone.getConection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT g.id, g.cod_grupo, g.fecha_inicio, g.fecha_fin, i.nombres, c.descripcion, t.descripcion as turno, g.estatus " +
                                              "FROM grupos as g JOIN cursos as c ON g.curso_id = c.id " +
                                              "JOIN instructores as i ON g.instructor_id = i.id JOIN turnos as t ON g.turno_id = t.id" +
                                                    " WHERE cod_grupo LIKE '%" + cod + "%'", con);
          
                cmd.CommandType = CommandType.Text;

                try
                {
                    con.Open();
                    MySqlDataReader rea = cmd.ExecuteReader();
                    while (rea.Read())
                    {
                        list.AppendValues((int)rea["id"], rea["estatus"].ToString(), rea["cod_grupo"].ToString(), rea["fecha_inicio"].ToString(), rea["fecha_fin"].ToString(),
                                      rea["nombres"].ToString(), rea["descripcion"].ToString(), rea["turno"].ToString());

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

        }
        protected void OnBtncrearClicked(object sender, EventArgs e)
        {
            switch (tipo.ToString())
            {
                case "estudiantes":
                    {
                        ActualizarEstudiante act = new ActualizarEstudiante(1);
                        act.Show();
                        Hide();
                        break;
                    }
                case "usuarios":
                    {
                        ActualizarUsuario act = new ActualizarUsuario(1);
                        act.Show();
                        Hide();
                        break;
                    }
                case "cursos":
                    {
                        ActualizarCursos act = new ActualizarCursos(1);
                        act.Show();
                        Hide();
                        break;
                    }

                case "grupos":
                    {
                        ActualizarGrupo act = new ActualizarGrupo(1);
                        act.Show();
                        Hide();
                        break;
                    }
                case "turnos":
                    {
                        ActualizarTurno act = new ActualizarTurno(1);
                        act.Show();
                        Hide();
                        break;
                    }
                case "instructores":
                    {
                        ActualizarInstructor act = new ActualizarInstructor(1);
                        act.Show();
                        Hide();
                        break;
                    }
            }
        }

        protected void OnEntbusquedaChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("test usuarios");
            //if para la busqueda
            switch (tipo.ToString())
            {
                case "estudiantes":
                    {
                        System.Console.WriteLine("test estudiantes");
                        treeviewlistado.Model = estudiantecod(entbusqueda.Text.Trim());
                        break;
                    }
                case "usuarios":
                    {
                        System.Console.WriteLine("test usuarios");
                        treeviewlistado.Model = usuarioscod(entbusqueda.Text.Trim());
                        break;
                    }
                case "cursos":
                    {
                        treeviewlistado.Model = cursoscod(entbusqueda.Text.Trim());
                        break;
                   
                    }

                case "grupos":
                    {
                        treeviewlistado.Model = gruposcod(entbusqueda.Text.Trim());
                        break;
                    }
                case "turnos":
                    {
                   
                        treeviewlistado.Model = turnoscod(entbusqueda.Text.Trim());
                        break;
                    }
                case "instructores":
                    {
                     
                        treeviewlistado.Model = instructorescod(entbusqueda.Text.Trim());
                        break;
                    }
            }
        
        }

        protected void OnTreeviewlistadoRowActivated(object o, RowActivatedArgs args)
        {

           

            var model = treeviewlistado.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);
            var id = model.GetValue(iter, 0);
            var estatus = model.GetValue(iter, 1);
            Console.WriteLine(id);
            ResponseType resp;
            if (estatus.ToString() == "D"){
                resp = vl.DialogYESNO("OPCIONES", "REACTIVAR", "CANCELAR", "\n¿Deseas editar este registro?");
                if (resp == ResponseType.Yes)
                {
                    switch (tipo.ToString())
                    {
                        case "estudiantes":
                            {
                                cone.EjecutarSentencia("UPDATE estudiantes set estatus='A' where id='" + id + "'");

                                break;
                            }
                        case "usuarios":
                            {
                                cone.EjecutarSentencia("UPDATE usuarios set estatus='A' where id='" + id + "'");

                                break;
                            }
                        case "cursos":
                            {
                                cone.EjecutarSentencia("UPDATE cursos set estatus='A' where id='" + id + "'");

                                break;
                            }

                        case "grupos":
                            {
                                cone.EjecutarSentencia("UPDATE grupos set estatus='A' where id='" + id + "'");

                                break;
                            }
                        case "turnos":
                            {
                                cone.EjecutarSentencia("UPDATE turnos set estatus='A' where id='" + id + "'");

                                break;
                            }
                        case "instructores":
                            {
                                cone.EjecutarSentencia("UPDATE instructores set estatus='A' where id='" + id + "'");

                                break;
                            }
                    }
                    vl.DialogOK("Exito", "Se ha modificado el campo correctamente", "info");
                    Hide();
                    ListadoArchivos lt = new ListadoArchivos(tipo); 
                    lt.Show();

                }
                else
                {
                    Console.WriteLine("OPCION2");
                }
            }else{
               resp = vl.DialogYESNO("OPCIONES", "EDITAR", "ELIMINAR", "\n¿Desea editar este registro?"); 
                if (resp == ResponseType.Yes)
                {
               
                    switch (tipo.ToString())
                    {
                        case "estudiantes":
                            {
                                ActualizarEstudiante act = new ActualizarEstudiante(2,(int)id);
                                act.Show();
                                Hide();
                                break;
                            }
                        case "usuarios":
                            {
                                ActualizarUsuario act = new ActualizarUsuario(2, (int)id);
                                act.Show();
                                Hide();
                                break;
                            }
                        case "cursos":
                            {
                                ActualizarCursos act = new ActualizarCursos(2, (int)id);
                                act.Show();
                                Hide();
                                break;
                            }

                        case "grupos":
                            {
                                ActualizarGrupo act = new ActualizarGrupo(2, (int)id);
                                act.Show();
                                Hide();
                                break;
                            }
                        case "turnos":
                            {
                                ActualizarTurno act = new ActualizarTurno(2, (int)id);
                                act.Show();
                                Hide();
                                break;
                            }
                        case "instructores":
                            {
                                ActualizarInstructor act = new ActualizarInstructor(2, (int)id);
                                act.Show();
                                Hide();
                                break;
                            }
                    }

                }
                else
                {
                    switch (tipo.ToString())
                    {
                        case "estudiantes":
                            {
                                cone.EjecutarSentencia("UPDATE estudiantes set estatus='D' where id='" + id +"'");
                              
                                break;
                            }
                        case "usuarios":
                            {
                                cone.EjecutarSentencia("UPDATE usuarios set estatus='D' where id='" + id + "'");
                           
                                break;
                            }
                        case "cursos":
                            {
                                cone.EjecutarSentencia("UPDATE cursos set estatus='D' where id='" + id + "'");
                           
                                break;
                            }

                        case "grupos":
                            {
                                cone.EjecutarSentencia("UPDATE grupos set estatus='D' where id='" + id + "'");
                        
                                break;
                            }
                        case "turnos":
                            {
                                cone.EjecutarSentencia("UPDATE turnos set estatus='D' where id='" + id + "'");
                        
                                break;
                            }
                        case "instructores":
                            {
                                cone.EjecutarSentencia("UPDATE instructores set estatus='D' where id='" + id + "'");
    
                                break;
                            }
                           

                    }
                    vl.DialogOK("Exito", "Se ha modificado el campo correctamente", "info");

                    Hide();
                    ListadoArchivos lt = new ListadoArchivos(tipo); 
                    lt.Show();
                }
            }   

           

          
        }
    }
}
