
// This file has been generated by the GUI designer. Do not modify.
namespace ProYectoX
{
	public partial class ActualizarEstudiante
	{
		private global::Gtk.VBox vbox5;

		private global::Gtk.VBox vbox8;

		private global::Gtk.Label lblestudiante;

		private global::Gtk.HBox hbox11;

		private global::Gtk.HBox hbox15;

		private global::Gtk.Label lblcedest;

		private global::Gtk.Entry entcedest;

		private global::Gtk.HBox hbox16;

		private global::Gtk.Label lbltelefonoest;

		private global::Gtk.Entry enttelefonoest;

		private global::Gtk.HBox hbox12;

		private global::Gtk.HBox hbox18;

		private global::Gtk.Label lblnombreest;

		private global::Gtk.Entry entnombest;

		private global::Gtk.HBox hbox17;

		private global::Gtk.Label lblsexoest;

		private global::Gtk.ComboBox comboboxsexest;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox13;

		private global::Gtk.HBox hbox19;

		private global::Gtk.Label lblapellidoest;

		private global::Gtk.Entry entapellidoest;

		private global::Gtk.HBox hbox20;

		private global::Gtk.DrawingArea drawingarea9;

		private global::Gtk.HBox hbox14;

		private global::Gtk.HBox hbox21;

		private global::Gtk.Label lbldireccionest;

		private global::Gtk.Entry entdireccionest;

		private global::Gtk.Label lblfechanacest;

		private global::Gtk.HBox hbox22;

		private global::Gtk.DrawingArea drawingarea10;

		private global::Gtk.Calendar calendar6;

		private global::Gtk.VBox vbox7;

		private global::Gtk.HBox hbox23;

		private global::Gtk.Button btnguardarestudiante;

		private global::Gtk.Button btncancelaractusu;

		private global::Gtk.HBox hbox4;

		private global::Gtk.DrawingArea drawingarea12;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label lblfecha;

		private global::Gtk.Label lblhora;

		private global::Gtk.DrawingArea drawingarea11;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProYectoX.ActualizarEstudiante
			this.Name = "ProYectoX.ActualizarEstudiante";
			this.Title = global::Mono.Unix.Catalog.GetString("ActualizarEstudiante");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProYectoX.ActualizarEstudiante.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.lblestudiante = new global::Gtk.Label();
			this.lblestudiante.Name = "lblestudiante";
			this.lblestudiante.LabelProp = global::Mono.Unix.Catalog.GetString("Archivo estudiante");
			this.vbox8.Add(this.lblestudiante);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.lblestudiante]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.lblcedest = new global::Gtk.Label();
			this.lblcedest.Name = "lblcedest";
			this.lblcedest.LabelProp = global::Mono.Unix.Catalog.GetString("Cedula");
			this.hbox15.Add(this.lblcedest);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.lblcedest]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.entcedest = new global::Gtk.Entry();
			this.entcedest.CanFocus = true;
			this.entcedest.Name = "entcedest";
			this.entcedest.IsEditable = true;
			this.entcedest.InvisibleChar = '●';
			this.hbox15.Add(this.entcedest);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.entcedest]));
			w3.Position = 1;
			w3.Expand = false;
			this.hbox11.Add(this.hbox15);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.hbox15]));
			w4.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.hbox16 = new global::Gtk.HBox();
			this.hbox16.Name = "hbox16";
			this.hbox16.Spacing = 6;
			// Container child hbox16.Gtk.Box+BoxChild
			this.lbltelefonoest = new global::Gtk.Label();
			this.lbltelefonoest.Name = "lbltelefonoest";
			this.lbltelefonoest.LabelProp = global::Mono.Unix.Catalog.GetString("Telefono");
			this.hbox16.Add(this.lbltelefonoest);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.lbltelefonoest]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.enttelefonoest = new global::Gtk.Entry();
			this.enttelefonoest.CanFocus = true;
			this.enttelefonoest.Name = "enttelefonoest";
			this.enttelefonoest.IsEditable = true;
			this.enttelefonoest.InvisibleChar = '●';
			this.hbox16.Add(this.enttelefonoest);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.enttelefonoest]));
			w6.Position = 1;
			this.hbox11.Add(this.hbox16);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.hbox16]));
			w7.Position = 1;
			this.vbox8.Add(this.hbox11);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox11]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.hbox18 = new global::Gtk.HBox();
			this.hbox18.Name = "hbox18";
			this.hbox18.Spacing = 6;
			// Container child hbox18.Gtk.Box+BoxChild
			this.lblnombreest = new global::Gtk.Label();
			this.lblnombreest.Name = "lblnombreest";
			this.lblnombreest.LabelProp = global::Mono.Unix.Catalog.GetString("Nombres");
			this.hbox18.Add(this.lblnombreest);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.lblnombreest]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox18.Gtk.Box+BoxChild
			this.entnombest = new global::Gtk.Entry();
			this.entnombest.CanFocus = true;
			this.entnombest.Name = "entnombest";
			this.entnombest.IsEditable = true;
			this.entnombest.InvisibleChar = '●';
			this.hbox18.Add(this.entnombest);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.entnombest]));
			w10.Position = 1;
			w10.Expand = false;
			this.hbox12.Add(this.hbox18);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.hbox18]));
			w11.Position = 0;
			// Container child hbox12.Gtk.Box+BoxChild
			this.hbox17 = new global::Gtk.HBox();
			this.hbox17.Name = "hbox17";
			this.hbox17.Spacing = 6;
			// Container child hbox17.Gtk.Box+BoxChild
			this.lblsexoest = new global::Gtk.Label();
			this.lblsexoest.Name = "lblsexoest";
			this.lblsexoest.LabelProp = global::Mono.Unix.Catalog.GetString("Sexo");
			this.hbox17.Add(this.lblsexoest);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.lblsexoest]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox17.Gtk.Box+BoxChild
			this.comboboxsexest = global::Gtk.ComboBox.NewText();
			this.comboboxsexest.AppendText(global::Mono.Unix.Catalog.GetString("F"));
			this.comboboxsexest.AppendText(global::Mono.Unix.Catalog.GetString("M"));
			this.comboboxsexest.Name = "comboboxsexest";
			this.hbox17.Add(this.comboboxsexest);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.comboboxsexest]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox12.Add(this.hbox17);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.hbox17]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox8.Add(this.hbox12);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox12]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox5.Add(this.vbox8);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox8]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.hbox19 = new global::Gtk.HBox();
			this.hbox19.Name = "hbox19";
			this.hbox19.Spacing = 6;
			// Container child hbox19.Gtk.Box+BoxChild
			this.lblapellidoest = new global::Gtk.Label();
			this.lblapellidoest.Name = "lblapellidoest";
			this.lblapellidoest.LabelProp = global::Mono.Unix.Catalog.GetString("Apellidos");
			this.hbox19.Add(this.lblapellidoest);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox19[this.lblapellidoest]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox19.Gtk.Box+BoxChild
			this.entapellidoest = new global::Gtk.Entry();
			this.entapellidoest.CanFocus = true;
			this.entapellidoest.Name = "entapellidoest";
			this.entapellidoest.IsEditable = true;
			this.entapellidoest.InvisibleChar = '●';
			this.hbox19.Add(this.entapellidoest);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox19[this.entapellidoest]));
			w18.Position = 1;
			w18.Expand = false;
			this.hbox13.Add(this.hbox19);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hbox19]));
			w19.Position = 0;
			// Container child hbox13.Gtk.Box+BoxChild
			this.hbox20 = new global::Gtk.HBox();
			this.hbox20.Name = "hbox20";
			this.hbox20.Spacing = 6;
			// Container child hbox20.Gtk.Box+BoxChild
			this.drawingarea9 = new global::Gtk.DrawingArea();
			this.drawingarea9.Name = "drawingarea9";
			this.hbox20.Add(this.drawingarea9);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox20[this.drawingarea9]));
			w20.Position = 0;
			this.hbox13.Add(this.hbox20);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hbox20]));
			w21.Position = 1;
			this.vbox6.Add(this.hbox13);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox13]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.hbox21 = new global::Gtk.HBox();
			this.hbox21.Name = "hbox21";
			this.hbox21.Spacing = 6;
			// Container child hbox21.Gtk.Box+BoxChild
			this.lbldireccionest = new global::Gtk.Label();
			this.lbldireccionest.Name = "lbldireccionest";
			this.lbldireccionest.LabelProp = global::Mono.Unix.Catalog.GetString("Direccion");
			this.hbox21.Add(this.lbldireccionest);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.lbldireccionest]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox21.Gtk.Box+BoxChild
			this.entdireccionest = new global::Gtk.Entry();
			this.entdireccionest.CanFocus = true;
			this.entdireccionest.Name = "entdireccionest";
			this.entdireccionest.IsEditable = true;
			this.entdireccionest.InvisibleChar = '●';
			this.hbox21.Add(this.entdireccionest);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.entdireccionest]));
			w24.Position = 1;
			w24.Expand = false;
			this.hbox14.Add(this.hbox21);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.hbox21]));
			w25.Position = 0;
			// Container child hbox14.Gtk.Box+BoxChild
			this.lblfechanacest = new global::Gtk.Label();
			this.lblfechanacest.Name = "lblfechanacest";
			this.lblfechanacest.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de nacimiento");
			this.hbox14.Add(this.lblfechanacest);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.lblfechanacest]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox6.Add(this.hbox14);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox14]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox22 = new global::Gtk.HBox();
			this.hbox22.Name = "hbox22";
			this.hbox22.Spacing = 6;
			// Container child hbox22.Gtk.Box+BoxChild
			this.drawingarea10 = new global::Gtk.DrawingArea();
			this.drawingarea10.Name = "drawingarea10";
			this.hbox22.Add(this.drawingarea10);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox22[this.drawingarea10]));
			w28.Position = 0;
			// Container child hbox22.Gtk.Box+BoxChild
			this.calendar6 = new global::Gtk.Calendar();
			this.calendar6.CanFocus = true;
			this.calendar6.Name = "calendar6";
			this.calendar6.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.hbox22.Add(this.calendar6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox22[this.calendar6]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox6.Add(this.hbox22);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox22]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox5.Add(this.vbox6);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox6]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox23 = new global::Gtk.HBox();
			this.hbox23.Name = "hbox23";
			this.hbox23.Spacing = 6;
			// Container child hbox23.Gtk.Box+BoxChild
			this.btnguardarestudiante = new global::Gtk.Button();
			this.btnguardarestudiante.CanFocus = true;
			this.btnguardarestudiante.Name = "btnguardarestudiante";
			this.btnguardarestudiante.UseUnderline = true;
			this.btnguardarestudiante.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox23.Add(this.btnguardarestudiante);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.btnguardarestudiante]));
			w32.Position = 0;
			// Container child hbox23.Gtk.Box+BoxChild
			this.btncancelaractusu = new global::Gtk.Button();
			this.btncancelaractusu.CanFocus = true;
			this.btncancelaractusu.Name = "btncancelaractusu";
			this.btncancelaractusu.UseUnderline = true;
			this.btncancelaractusu.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.hbox23.Add(this.btncancelaractusu);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.btncancelaractusu]));
			w33.Position = 1;
			this.vbox7.Add(this.hbox23);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox23]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.drawingarea12 = new global::Gtk.DrawingArea();
			this.drawingarea12.Name = "drawingarea12";
			this.hbox4.Add(this.drawingarea12);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.drawingarea12]));
			w35.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label();
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Xpad = 96;
			this.lblfecha.Ypad = 2;
			this.lblfecha.Xalign = 0F;
			this.lblfecha.Yalign = 0F;
			this.hbox5.Add(this.lblfecha);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lblfecha]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label();
			this.lblhora.Name = "lblhora";
			this.lblhora.Xpad = 87;
			this.lblhora.Ypad = 2;
			this.lblhora.Xalign = 1F;
			this.lblhora.Yalign = 0F;
			this.hbox5.Add(this.lblhora);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lblhora]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w38.Position = 1;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.drawingarea11 = new global::Gtk.DrawingArea();
			this.drawingarea11.Name = "drawingarea11";
			this.hbox4.Add(this.drawingarea11);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.drawingarea11]));
			w39.Position = 2;
			this.vbox7.Add(this.hbox4);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox4]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			this.vbox5.Add(this.vbox7);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox7]));
			w41.Position = 2;
			w41.Expand = false;
			w41.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 533;
			this.DefaultHeight = 389;
			this.Show();
			this.entcedest.Changed += new global::System.EventHandler(this.OnEntcedestChanged);
			this.enttelefonoest.Changed += new global::System.EventHandler(this.OnEnttelefonoestChanged);
			this.entnombest.Changed += new global::System.EventHandler(this.OnEntnombestChanged);
			this.entapellidoest.Changed += new global::System.EventHandler(this.OnEntapellidoestChanged);
			this.entdireccionest.Changed += new global::System.EventHandler(this.OnEntdireccionestChanged);
			this.btnguardarestudiante.Clicked += new global::System.EventHandler(this.OnBtnguardarestudianteClicked);
			this.btncancelaractusu.Clicked += new global::System.EventHandler(this.OnBtncancelaractusuClicked);
		}
	}
}
