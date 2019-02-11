using System;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

namespace ProYectoX
{
    public partial class ReportesCursos : Gtk.Window
    {
        ProYectoX.ConectorBD cone;

       
        Gtk.ListStore ds = new ListStore(typeof(string), typeof(string), typeof(string));
        public ReportesCursos() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            cone = new ProYectoX.ConectorBD(this);
            ComenzarTimer();
          
            treeview1.AppendColumn("CODIGO CURSO", new CellRendererText(), "text", 0);
            treeview1.AppendColumn("NOMBRE CURSO", new CellRendererText(), "text", 1);
            treeview1.AppendColumn("CANTIDAD DE GRUPOS", new CellRendererText(), "text", 2);
            treeview1.Model = ds;


        }
        public void buscarporfecha()
        {
            
          
            ds.Clear();
            MySqlConnection con = this.cone.getConection();

           
            Console.WriteLine(calendar1.GetDate().ToString("yyyy-MM-dd"));
            Console.WriteLine(calendar2.GetDate().ToString("yyyy-MM-dd"));
            string fecha_inicio = calendar1.GetDate().ToString("yyyy-MM-dd");
            string fecha_fin = calendar2.GetDate().ToString("yyyy-MM-dd");

          

            MySqlCommand cmd = new MySqlCommand("SELECT c.codigo, c.descripcion, count(g.id) as cantidad FROM grupos AS g JOIN cursos as c ON c.id = g.curso_id WHERE g.fecha_inicio >= '"+ fecha_inicio +"' AND g.fecha_fin <= '"+fecha_fin+"' AND g.estatus = 'A' GROUP BY g.id HAVING COUNT(g.id)",con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();
                while (rea.Read())
                {
                    Console.WriteLine(rea["cantidad"].ToString());
                    ds.AppendValues(rea["codigo"].ToString(), rea["descripcion"].ToString(), rea["cantidad"].ToString());
                    //(int)rea["cantidadgrupos"]);


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
        protected void OnCalendar1DaySelected(object sender, EventArgs e)
        {
            //throw new NotImplementedException ();
            buscarporfecha();
        }

        protected void OnCalendar2DaySelected(object sender, EventArgs e)
        {
            //throw new NotImplementedException ();
            buscarporfecha();
        }


       
        protected void OnButton5Clicked(object sender, EventArgs e)
        {
            this.Destroy();

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

        protected void OnBntcanClicked(object sender, EventArgs e)
        {
            
            new ProYectoX.TiposReportes();
            Hide();
        }
    }
}
