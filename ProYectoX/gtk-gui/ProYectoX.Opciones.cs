
// This file has been generated by the GUI designer. Do not modify.
namespace ProYectoX
{
	public partial class Opciones
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label lbltitulo;

		private global::Gtk.Button btnactualizar;

		private global::Gtk.Button btnreportes;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button btncan;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label lblfecha;

		private global::Gtk.Label lblhora;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProYectoX.Opciones
			this.Name = "ProYectoX.Opciones";
			this.Title = global::Mono.Unix.Catalog.GetString("Opciones");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child ProYectoX.Opciones.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lbltitulo = new global::Gtk.Label();
			this.lbltitulo.Name = "lbltitulo";
			this.lbltitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Opciones");
			this.vbox2.Add(this.lbltitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lbltitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.vbox3.Add(this.vbox2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.vbox2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.btnactualizar = new global::Gtk.Button();
			this.btnactualizar.Sensitive = false;
			this.btnactualizar.CanFocus = true;
			this.btnactualizar.Name = "btnactualizar";
			this.btnactualizar.UseUnderline = true;
			this.btnactualizar.Label = global::Mono.Unix.Catalog.GetString("Actualización");
			this.vbox3.Add(this.btnactualizar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.btnactualizar]));
			w3.Position = 1;
			w3.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.btnreportes = new global::Gtk.Button();
			this.btnreportes.Sensitive = false;
			this.btnreportes.CanFocus = true;
			this.btnreportes.Name = "btnreportes";
			this.btnreportes.UseUnderline = true;
			this.btnreportes.Label = global::Mono.Unix.Catalog.GetString("Reportes");
			this.vbox3.Add(this.btnreportes);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.btnreportes]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.btncan = new global::Gtk.Button();
			this.btncan.CanFocus = true;
			this.btncan.Name = "btncan";
			this.btncan.UseUnderline = true;
			this.btncan.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.hbox3.Add(this.btncan);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btncan]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox3.Add(this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label();
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Xpad = 143;
			this.lblfecha.Xalign = 0F;
			this.hbox2.Add(this.lblfecha);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblfecha]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label();
			this.lblhora.HeightRequest = 28;
			this.lblhora.Name = "lblhora";
			this.lblhora.Xpad = 131;
			this.lblhora.Xalign = 1F;
			this.hbox2.Add(this.lblhora);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblhora]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox3.Add(this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w9.Position = 4;
			w9.Expand = false;
			w9.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 554;
			this.DefaultHeight = 360;
			this.Show();
			this.btnactualizar.Clicked += new global::System.EventHandler(this.OnBtnactualizarClicked);
			this.btnreportes.Clicked += new global::System.EventHandler(this.OnBtnreportesClicked);
		}
	}
}
