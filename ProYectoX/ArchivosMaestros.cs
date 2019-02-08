using System;
namespace ProYectoX
{
    public partial class ArchivosMaestros : Gtk.Window
    {
        public ArchivosMaestros() :
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

        protected void OnBtnarchinstructorClicked(object sender, EventArgs e)
        {
            new ProYectoX.ActualizarInstructor();
            Hide();
        }

        protected void OnBtnestudianteClicked(object sender, EventArgs e)
        {
            new ProYectoX.ListadoArchivos();
            Hide();
        }
    }
}
