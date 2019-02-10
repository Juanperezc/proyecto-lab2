using System;
using Gtk;
namespace ProYectoX
{
    
    public partial class ActualizarCursos : Gtk.Window
                                               
    {
        ProYectoX.Validacioness vali;
        public ActualizarCursos():
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            vali = new ProYectoX.Validacioness();
        }

        public void guardarcursos()
        {
            if (entcodcurso.Text == "" || entdescripcioncurso.Text == "")
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }

            else{}
        }
        protected void OnBtnguardarClicked(object sender, EventArgs e)
        {
            guardarcursos();
            Hide();
        }

        protected void OnBtncancelaractusuClicked(object sender, EventArgs e)
        {
            
        }

        protected void OnEntdescripcioncursoChanged(object sender, EventArgs e)
        {
            vali.ValidarLetras(entdescripcioncurso);
        }

        protected void OnEntcodcursoChanged(object sender, EventArgs e)
        {
            vali.ValidarAlfanum(entcodcurso);
        }
    }
}
