using System;
using Gtk;
namespace ProYectoX
{
    public partial class ReporteCursos : Gtk.Window
    {
        ListStore info = new ListStore(typeof(string), typeof(string), typeof(string));
        public ReporteCursos() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
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
    }
}
