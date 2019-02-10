using System;
namespace ProYectoX
{
    public partial class ActualizarInstructor : Gtk.Window
    {
        ProYectoX.Validacioness vali;
        public ActualizarInstructor() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            vali = new ProYectoX.Validacioness();
        }

        public void guardarinstructor()
        {
            if (entcedinst.Text == "" || entnombinst.Text == ""
                || entapellidoinst.Text == "" || entdireccioninst.Text == ""
                || enttelefonoinst.Text == "")
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }
            else { }
        }
        protected void OnEntcedinstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entcedinst);
        }

        protected void OnEntnombinstChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entnombinst);
        }

        protected void OnEntapellidoinstChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entapellidoinst);
        }

        protected void OnEntdireccioninstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entdireccioninst);
        }

        protected void OnEnttelefonoinstChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(enttelefonoinst);  
        }


        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
            guardarinstructor();
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
        }
    }
}
