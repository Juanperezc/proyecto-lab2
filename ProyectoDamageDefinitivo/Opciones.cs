using System;
namespace ProyectoDamageDefinitivo
{
    public partial class Validaciones : Gtk.Window
    {
        public Validaciones() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnactualizarClicked(object sender, EventArgs e)
        {
        }
    }
}
