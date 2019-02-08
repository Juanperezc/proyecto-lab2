using System;
namespace ProYectoX
{
    public partial class ListadoArchivos : Gtk.Window
    {
        public ListadoArchivos() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtncancelarlistClicked(object sender, EventArgs e)
        {
            new ProYectoX.ArchivosMaestros();
            Hide();

        }

        protected void OnBtncrearClicked(object sender, EventArgs e)
        {
        }
    }
}
