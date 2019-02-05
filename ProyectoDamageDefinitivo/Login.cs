using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

 

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtniniciar1Clicked(object sender, EventArgs e)
    {
        ProyectoDamageDefinitivo.ActualizarEstudiante act= new ProyectoDamageDefinitivo.ActualizarEstudiante();
        this.Hide();
        act.Show();
    }

    protected void OnEntusuario1Changed(object sender, EventArgs e)
    {
        
            string cadena = entusuario1.Text;

            int x;

            for (x = 0; x < cadena.Length; x++)

            {

            if (cadena[x] >= 'A' && cadena[x] <= 'Z' || cadena[x] >= 'a' && cadena[x] <= 'z' || cadena[x] == ' ' ){} //Verifica que el caracter actual sea una letra mayúscula, minúscula o un espacio

                else

                entusuario1.Text = cadena.Substring(0, cadena.Length - 1); //Si no lo es, lo elimina

            }
    }

    protected void OnEntcontraseña1Changed(object sender, EventArgs e)
    {
        string cadena = entcontraseña1.Text;

        int x;

        for (x = 0; x < cadena.Length; x++)

        {

            if (cadena[x] >= 'A' && cadena[x] <= 'Z' || cadena[x] >= 'a' && cadena[x] <= 'z' || cadena[x] == ' ' || cadena[x] >= '0' && cadena[x] <= '9') { } //Similar al anterior, pero también incluye números naturales

            else

                entcontraseña1.Text = cadena.Substring(0, cadena.Length - 1);

        }
    }
}
