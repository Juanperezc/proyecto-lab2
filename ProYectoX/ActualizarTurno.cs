using System;
namespace ProYectoX
{
    public partial class ActualizarTurno : Gtk.Window
    {
        int tipo;
        public ActualizarTurno(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
        }
    }
}
