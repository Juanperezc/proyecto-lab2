using System;
namespace ProYectoX
{
    public partial class ActualizarEstudiante : Gtk.Window
    {
        int tipo;
        ProYectoX.ConectorBD cone;
        public ActualizarEstudiante(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
        }

        protected void OnBtnguardarestudianteClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }
    }
}
