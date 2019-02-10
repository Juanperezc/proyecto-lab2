using System;
namespace ProYectoX
{
    public partial class ActualizarUsuario : Gtk.Window
    {
        int tipo;
        public ActualizarUsuario(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtnsaliractusuClicked(object sender, EventArgs e)
        {
        }
    }
}
