
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label lblusuario;

	private global::Gtk.Entry entusuario;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label lblcontrasena;

	private global::Gtk.Entry entcontrasena;

	private global::Gtk.Button btningresar;

	private global::Gtk.Button btnsalir;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label lblfecha;

	private global::Gtk.Label lblhora;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lblusuario = new global::Gtk.Label();
		this.lblusuario.Name = "lblusuario";
		this.lblusuario.Xalign = 1F;
		this.lblusuario.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Usuario:</b>");
		this.lblusuario.UseMarkup = true;
		this.hbox3.Add(this.lblusuario);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.lblusuario]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entusuario = new global::Gtk.Entry();
		global::Gtk.Tooltips w2 = new Gtk.Tooltips();
		w2.SetTip(this.entusuario, "ATENCIÓN: En este campo las mayúsculas NO son tomadas en cuenta.", "ATENCIÓN: En este campo las mayúsculas NO son tomadas en cuenta.");
		this.entusuario.WidthRequest = 171;
		this.entusuario.CanFocus = true;
		this.entusuario.Name = "entusuario";
		this.entusuario.IsEditable = true;
		this.entusuario.MaxLength = 10;
		this.entusuario.InvisibleChar = '•';
		this.hbox3.Add(this.entusuario);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entusuario]));
		w3.Position = 1;
		this.vbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lblcontrasena = new global::Gtk.Label();
		this.lblcontrasena.Name = "lblcontrasena";
		this.lblcontrasena.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Contraseña:</b>");
		this.lblcontrasena.UseMarkup = true;
		this.hbox4.Add(this.lblcontrasena);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lblcontrasena]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entcontrasena = new global::Gtk.Entry();
		w2.SetTip(this.entcontrasena, "ATENCIÓN: En este campo las mayúsculas SON tomadas en cuenta.", "ATENCIÓN: En este campo las mayúsculas SON tomadas en cuenta.");
		this.entcontrasena.CanFocus = true;
		this.entcontrasena.Name = "entcontrasena";
		this.entcontrasena.IsEditable = true;
		this.entcontrasena.MaxLength = 20;
		this.entcontrasena.Visibility = false;
		this.entcontrasena.InvisibleChar = '•';
		this.hbox4.Add(this.entcontrasena);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entcontrasena]));
		w6.Position = 1;
		this.vbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btningresar = new global::Gtk.Button();
		this.btningresar.CanFocus = true;
		this.btningresar.Name = "btningresar";
		this.btningresar.UseUnderline = true;
		this.btningresar.Label = global::Mono.Unix.Catalog.GetString("Ingresar");
		this.vbox2.Add(this.btningresar);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.btningresar]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.btnsalir = new global::Gtk.Button();
		this.btnsalir.CanFocus = true;
		this.btnsalir.Name = "btnsalir";
		this.btnsalir.UseUnderline = true;
		this.btnsalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
		this.vbox2.Add(this.btnsalir);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.btnsalir]));
		w9.Position = 4;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblfecha = new global::Gtk.Label();
		this.lblfecha.Name = "lblfecha";
		this.lblfecha.Xalign = 0F;
		this.hbox2.Add(this.lblfecha);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblfecha]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblhora = new global::Gtk.Label();
		this.lblhora.HeightRequest = 28;
		this.lblhora.Name = "lblhora";
		this.lblhora.Xalign = 1F;
		this.hbox2.Add(this.lblhora);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblhora]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w12.Position = 5;
		w12.Expand = false;
		w12.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 334;
		this.DefaultHeight = 467;
		this.Show();
	}
}