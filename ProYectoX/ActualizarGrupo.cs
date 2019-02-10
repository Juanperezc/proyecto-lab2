using System;
namespace ProYectoX
{
    public partial class ActualizarGrupo : Gtk.Window
    {
        int tipo;
        public ActualizarGrupo(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
        }

        protected void OnBtnguardargrupoClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }
    }
}
