using System;
namespace ProYectoX
{
    public partial class ActualizarGrupo : Gtk.Window
    {
        ProYectoX.Validacioness vali;
        public ActualizarGrupo() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            vali = new Validacioness();
        }

        public void guardargrupo()
        {if (entcodigogrupo.Text == "")
            { vali.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }

            else {}
         }
        protected void OnBtnguardargrupoClicked(object sender, EventArgs e)
        {
        }

        protected void OnBtncancelargrupoClicked(object sender, EventArgs e)
        {
        }

        protected void OnEntcodigogrupoChanged(object sender, EventArgs e)
        { 
            vali.ValidarAlfanum(entcodigogrupo);
        }
    }
}
