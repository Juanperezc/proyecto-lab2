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
            ProYectoX.ListadoArchivos list = new ListadoArchivos();
            list.Show();
            Hide();
        }

        protected void OnBtnestudianteClicked(object sender, EventArgs e)
        {
            ListadoArchivos listarch = new ProYectoX.ListadoArchivos("estudiantes");
            listarch.Show();
            Hide();
        }

        protected void OnButton1Clicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncursoClicked(object sender, EventArgs e)
        {
            ProYectoX.ActualizarCursos actcurso = new ProYectoX.ActualizarCursos();
            actcurso.Show();
            Hide();
        }

        protected void OnBtngrupoClicked(object sender, EventArgs e)
        {
            ProYectoX.ActualizarGrupo actgrupo = new ProYectoX.ActualizarGrupo();
            actgrupo.Show();
            Hide();
        }

        protected void OnButton4Clicked(object sender, EventArgs e)
        {
        }

        protected void OnBtnsalirlistClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelarlistClicked(object sender, EventArgs e)
        {
           // new ProYectoX.Opciones();
            // Hide();
        }
    }
}
