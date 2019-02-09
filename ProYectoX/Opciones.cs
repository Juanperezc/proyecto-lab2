using System;
using Gtk;
namespace ProYectoX
{
    public partial class Opciones : Gtk.Window
    {ConectorBD conector;
        public Opciones(): base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            conector = new ConectorBD(this);
            ComenzarTimer();
            Permisos(ProYectoX.Validacioness.rol);

        }
        protected void Permisos(int tipo)
        {
            if (tipo == 1)
            {
                btnactualizar.Sensitive = true;
              
            }
            else if (tipo == 2)
            {
                btnreportes.Sensitive = true;
            }
            else if (tipo == 3)
            {
                btnactualizar.Sensitive = true;
               btnreportes.Sensitive = true;
            }
        }
        protected void OnBtnactualizarClicked(object sender, EventArgs e)
        {
            new ArchivosMaestros();
            this.Hide();


        }

        protected void OnBtnreportesClicked(object sender, EventArgs e)
        {
            new ProYectoX.TiposReportes();
 
            this.Hide();
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

        protected void OnBtnsaliropcionesClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncanClicked(object sender, EventArgs e)
        {
            new ProYectoX.MainClass();
            Hide();
        }
    }
  
}
