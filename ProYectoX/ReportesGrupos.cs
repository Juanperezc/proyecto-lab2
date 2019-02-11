using System;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ReportesGrupos : Gtk.Window
    {
        ProYectoX.ConectorBD cone;

        Gtk.ListStore dt = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(int));
        public ReportesGrupos() : base(Gtk.WindowType.Toplevel)

        {
            this.Build();
            ComenzarTimer();
            cone = new ProYectoX.ConectorBD(this);
            treart.Model = dt;
            treart.AppendColumn("Codigo del Curso", new CellRendererText(), "text", 0);
            treart.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
            treart.AppendColumn("Fecha Inicial", new CellRendererText(), "text", 2);
            treart.AppendColumn("Fecha Final", new CellRendererText(), "text", 3);
            treart.AppendColumn("Turno", new CellRendererText(), "text", 4);
            selecporfecha();

        }

        public void selecporfecha()
        {
            
           

            DateTime fecha = DateTime.Today;
            Console.WriteLine(fecha.ToString("yyyy-MM-dd"));
            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT g.cod_grupo, c.descripcion, g.fecha_inicio, g.fecha_fin, g.turno_id FROM grupos as g JOIN cursos as c ON c.id = g.curso_id WHERE g.fecha_fin <= '" + fecha.ToString("yyyy-MM-dd") + "' AND c.estatus = 'A' AND g.estatus = 'A'", con); 

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
                    dt.AppendValues(rea["cod_grupo"].ToString(), rea["descripcion"].ToString(), rea["fecha_inicio"].ToString(), rea["fecha_fin"].ToString(), (int)rea["turno_id"]);

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

        protected void OnBtnsssClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnBtncaaClicked(object sender, EventArgs e)
        {
            new ProYectoX.TiposReportes();
            Hide();
        }
    }
    }
