using System;
namespace ProYectoX
{
    public partial class ActualizarEstudiante : Gtk.Window
    {
        int tipo;
        ProYectoX.ConectorBD cone;
        ProYectoX.Validacioness vali;
        public ActualizarEstudiante(int tip, int id = 0) :
                base(Gtk.WindowType.Toplevel)
        {
                 this.Build();
            this.tipo = tip;
            vali = new ProYectoX.Validacioness();
        }

        public void guardarestudiante()
        {
            if (entcedest.Text == "" || entnombest.Text == "" 
                || entapellidoest.Text == "" || entdireccionest.Text == "" 
                || enttelefonoest.Text == "")
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }
            else {}
            
        }

        protected void OnBtnguardarestudianteClicked(object sender, EventArgs e)
        {
            guardarestudiante();
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }

        protected void OnEntcedestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entcedest);
        }

        protected void OnEntnombestChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entnombest);
        }

       /* protected void OnEntapellidoestActivated(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoest);
        }*/

        protected void OnEntdireccionestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entdireccionest);
        }

        protected void OnEnttelefonoestChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(enttelefonoest);
        }



        protected void OnEntapellidoestChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoest);
        }
    }
}
