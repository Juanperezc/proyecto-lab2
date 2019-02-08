using System;
namespace ProYectoX
{
    public partial class TiposReportes : Gtk.Window
    {
        public TiposReportes() :
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
            //lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            return true;
        }
        protected void OnBtncontinuarClicked(object sender, EventArgs e)
        {
            

            // if(radiobutton1.checked == true){}
            //pero no se como se llama el metodo en mono que funcione como 
            //checked
            //else {}
            //if(radiobutton1.Active == true){
            // //   new ProYectoX.ReporteCursos;
            //}
            //else{
            //   // new ProYectoX.ReporteGrupos;
            //}
        }
    }
}
