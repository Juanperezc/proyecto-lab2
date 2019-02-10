using System;
namespace ProYectoX
{
    public partial class ActualizarInstructor : Gtk.Window
    {
        int tipo;
        public ActualizarInstructor(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.tipo = tip;
        }
    }
}
