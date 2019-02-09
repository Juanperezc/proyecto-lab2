using System;
using Gtk;
namespace ProYectoX
{
    
    public partial class ActualizarCursos : Gtk.Window
                                               
    {
        Validacioness val;
        public ActualizarCursos():
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            val = new Validacioness();
        }

        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }

        protected void OnEntdescripcioncursoChanged(object sender, EventArgs e)
        {
            val.ValidarLetras(entdescripcioncurso);
        }
    }
}
