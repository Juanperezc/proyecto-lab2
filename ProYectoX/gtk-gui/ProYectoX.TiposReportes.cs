
// This file has been generated by the GUI designer. Do not modify.
namespace ProYectoX
{
	public partial class TiposReportes
	{
		private global::Gtk.HBox hbox3;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HSeparator hseparator11;

		private global::Gtk.Label lbltitulo;

		private global::Gtk.HSeparator hseparator12;

		private global::Gtk.RadioButton radiobutton1;

		private global::Gtk.RadioButton radiobutton2;

		private global::Gtk.HSeparator hseparator13;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button btncontinuar;

		private global::Gtk.Button btnsalir;

		private global::Gtk.HSeparator hseparator14;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label lblfecha;

		private global::Gtk.Label lblhora;

		private global::Gtk.VSeparator vseparator2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProYectoX.TiposReportes
			this.Name = "ProYectoX.TiposReportes";
			this.Title = global::Mono.Unix.Catalog.GetString("TiposReportes");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ProYectoX.TiposReportes.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox3.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vseparator1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator11 = new global::Gtk.HSeparator();
			this.hseparator11.Name = "hseparator11";
			this.vbox2.Add(this.hseparator11);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator11]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lbltitulo = new global::Gtk.Label();
			this.lbltitulo.Name = "lbltitulo";
			this.lbltitulo.Ypad = 5;
			this.lbltitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Seleccione el reporte que desea");
			this.vbox2.Add(this.lbltitulo);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lbltitulo]));
			w3.Position = 1;
			w3.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator12 = new global::Gtk.HSeparator();
			this.hseparator12.Name = "hseparator12";
			this.vbox2.Add(this.hseparator12);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator12]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radiobutton1 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Listados de Cursos"));
			this.radiobutton1.CanFocus = true;
			this.radiobutton1.Name = "radiobutton1";
			this.radiobutton1.DrawIndicator = true;
			this.radiobutton1.UseUnderline = true;
			this.radiobutton1.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.vbox2.Add(this.radiobutton1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radiobutton1]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.radiobutton2 = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Listado de Grupos Culminados"));
			this.radiobutton2.CanFocus = true;
			this.radiobutton2.Name = "radiobutton2";
			this.radiobutton2.DrawIndicator = true;
			this.radiobutton2.UseUnderline = true;
			this.radiobutton2.Group = this.radiobutton1.Group;
			this.vbox2.Add(this.radiobutton2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.radiobutton2]));
			w6.Position = 4;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator13 = new global::Gtk.HSeparator();
			this.hseparator13.Name = "hseparator13";
			this.vbox2.Add(this.hseparator13);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator13]));
			w7.Position = 5;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btncontinuar = new global::Gtk.Button();
			this.btncontinuar.CanFocus = true;
			this.btncontinuar.Name = "btncontinuar";
			this.btncontinuar.UseUnderline = true;
			this.btncontinuar.Label = global::Mono.Unix.Catalog.GetString("Continuar");
			this.hbox4.Add(this.btncontinuar);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btncontinuar]));
			w8.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnsalir = new global::Gtk.Button();
			this.btnsalir.CanFocus = true;
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.UseUnderline = true;
			this.btnsalir.Label = global::Mono.Unix.Catalog.GetString("Atras");
			this.hbox4.Add(this.btnsalir);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnsalir]));
			w9.Position = 1;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator14 = new global::Gtk.HSeparator();
			this.hseparator14.Name = "hseparator14";
			this.vbox2.Add(this.hseparator14);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator14]));
			w11.Position = 7;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label();
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Xpad = 44;
			this.lblfecha.Xalign = 0F;
			this.hbox8.Add(this.lblfecha);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lblfecha]));
			w12.Position = 1;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label();
			this.lblhora.HeightRequest = 28;
			this.lblhora.Name = "lblhora";
			this.lblhora.Xpad = 55;
			this.lblhora.Xalign = 1F;
			this.hbox8.Add(this.lblhora);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lblhora]));
			w13.Position = 2;
			this.vbox2.Add(this.hbox8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox8]));
			w14.Position = 8;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox3.Add(this.vbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vbox2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.hbox3.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.vseparator2]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.Add(this.hbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 255;
			this.DefaultHeight = 202;
			this.Show();
			this.btncontinuar.Clicked += new global::System.EventHandler(this.OnBtncontinuarClicked);
			this.btnsalir.Clicked += new global::System.EventHandler(this.OnBtnsalirClicked);
		}
	}
}
