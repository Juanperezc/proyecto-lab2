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
            if (cone.Buscar2("nombre_usuario", "usuarios", entusuario.Text, "clave", entcontrasena.Text) == true)//Valida si lo encuentra
            {
                System.Console.WriteLine("Test 1 paso");
                string sent = string.Format("SELECT id_tipousuario FROM usuarios WHERE nombre_usuario='{0}' AND estatus='A'", entusuario.Text);
                //   "SELECT * FROM usuarios WHERE estatus= @estatus and nombre_usuario= @nombre_usuario and contraseña = @contraseña");
                string[] datos = cone.Listado(1, sent);
              
                System.Console.WriteLine("Tipo de usuario :" + datos[0]);
                ProYectoX.Validacioness.rol = Convert.ToInt16(datos[0]);
                new ProYectoX.Opciones().Show();

                   this.Hide();
                    
           
       
            }

            else
                {
                 vl.DialogOK("INCORRECTO", "\nDisculpe, debe ingresar un usuario o contraseña válidos.", "WARNING");
      
                 entusuario.IsFocus = true;

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
        System.Console.WriteLine("Click 1");
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
  