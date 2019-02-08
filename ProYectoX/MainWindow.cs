using System;
using Gtk;
using MySql.Data.MySqlClient;
using GLib;


public partial class MainWindow : Gtk.Window
{

    //   *******METODOS PARA EL CONTROL DE LA VENTANA********
    public static string nom;
    ProYectoX.Validacioness vl;
    ProYectoX.ConectorBD cone;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        this.ComenzarTimer();
        vl = new ProYectoX.Validacioness();
        cone = new ProYectoX.ConectorBD(this);
        // this.cone = new ProYectoX.ConectorBD();

    }


    public void entraralsistema()
    {

        if (entusuario.Text == "" || entcontrasena.Text == "")
        { vl.DialogOK("AVISO", "\nDisculpe, debe llenar todos los campos.", "WARNING"); }
        else
        {
            if (cone.Buscar("nombre_usuario", "usuarios", entusuario.Text, "estatus") == true)//Valida si lo encuentra
            {
                string sent = string.Format("Select contraseña, tipo_usuario from usuarios where nombre_usuario='{0}' and estatus='A'", entusuario.Text);
                //   "SELECT * FROM usuarios WHERE estatus= @estatus and nombre_usuario= @nombre_usuario and contraseña = @contraseña");
                string[] datos = cone.Listado(2, sent);

                if (datos[0] == entcontrasena.Text)
                {
                    new ProYectoX.Opciones(Convert.ToInt16(datos[1]));

                    this.Hide();
                }
                else
                {
                    vl.DialogOK("INCORRECTO", "\nDisculpe, debe ingresar un usuario o contraseña válidos.", "WARNING");
                    entusuario.IsFocus = true;

                }

            }
        }
    }




    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void OnBtningresarClicked(object sender, EventArgs e)
    {
        entraralsistema();
        //System.Console.WriteLine(this.cone.Cadenaconexion());
        //new ProYectoX.Opciones();
        //this.Destroy();
    }

    //*******METODOS PARA MOSTRAR FECHA Y HORA ACTUAL*******


    protected void ComenzarTimer()
    {
        // Se ejecuta cada 1000 milisegundos (1s)

        GLib.Timeout.Add(1000, new GLib.TimeoutHandler(update_fechahora));
    }

    protected bool update_fechahora()
    {

        lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");

        return true;
    }
    protected void OnBtnsalirClicked(object sender, EventArgs e)
    {
        Application.Quit();
    }

    protected void OnEntusuarioActivated(object sender, EventArgs e)
    {
        entraralsistema();
    }

    protected void OnEntcontrasenaActivated(object sender, EventArgs e)
    {
        entraralsistema();
    }

    protected void OnEntusuarioChanged(object sender, EventArgs e)
    {
        vl.ValidarAlfanum(entusuario);
    }

    protected void OnEntcontrasenaChanged(object sender, EventArgs e)
    {
        vl.ValidarAlfanum(entcontrasena);

    }
        

}
  