﻿using System;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;
namespace ProYectoX
{
    public partial class ReporteGrupos : Gtk.Window
    {
        ProYectoX.ConectorBD cone;
        ListStore dt = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
        public ReporteGrupos() : base(Gtk.WindowType.Toplevel)

        {
            this.Build();
            ComenzarTimer();
            cone = new ProYectoX.ConectorBD(this);
            treart.AppendColumn("Codigo del Curso", new CellRendererText(), "text", 0);
            treart.AppendColumn("Nombre del Curso", new CellRendererText(), "text", 1);
            treart.AppendColumn("Fecha Inicial", new CellRendererText(), "text", 2);
            treart.AppendColumn("Fecha Finl", new CellRendererText(), "text", 3);
            treart.AppendColumn("Turno", new CellRendererText(), "text", 4);
        }

        public void selecporfecha()
        {
            DateTime fecha = DateTime.Today;
            MySqlConnection con = this.cone.getConection();
            MySqlCommand cmd = new MySqlCommand("SELECT cod_grupo, curso_id, fecha_inicio, fecha_fin, turno_id FROM grupos WHERE fecha_fin <= '" + fecha + "'AND estatus = 'A'", con);

            try
            {
                con.Open();
                MySqlDataReader rea = cmd.ExecuteReader();

                while (rea.Read())
                {
                    dt.AppendValues((string)rea["cod_grupo"],(int)rea["curso_id"],(string)rea["fecha_inicio"],(string)rea["fecha_fin"],(int)rea["turno_id"]);

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
    }
}
