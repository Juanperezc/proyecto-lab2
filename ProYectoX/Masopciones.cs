using System;
namespace ProYectoX
{
    public partial class Masopciones : Gtk.Window
    {
        public Masopciones() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnsalirmasopcClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelarmasopcClicked(object sender, EventArgs e)
        {
            new ListadoArchivos();
            Hide();
        }
    }
}
