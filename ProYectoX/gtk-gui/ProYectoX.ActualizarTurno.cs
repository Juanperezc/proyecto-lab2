
// This file has been generated by the GUI designer. Do not modify.
namespace ProYectoX
{
	public partial class ActualizarTurno
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label lblturno;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Label lbldescrpcionturno;

		private global::Gtk.Entry entdescripcionturno;

		private global::Gtk.HBox hbox15;

		private global::Gtk.Label lblhorainicturno;

		private global::Gtk.ComboBox combobox2;

		private global::Gtk.HBox hbox16;

		private global::Gtk.Label lblhoracierreturno;

		private global::Gtk.ComboBox combobox4;

		private global::Gtk.HBox hbox19;

		private global::Gtk.Button btnguardarturno;

		private global::Gtk.Button btncancelaractturno;

		private global::Gtk.HBox hbox17;

		private global::Gtk.DrawingArea drawingarea4;

		private global::Gtk.HBox hbox18;

		private global::Gtk.Label lblfecha;

		private global::Gtk.Label lblhora;

		private global::Gtk.DrawingArea drawingarea3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProYectoX.ActualizarTurno
			this.Name = "ProYectoX.ActualizarTurno";
			this.Title = global::Mono.Unix.Catalog.GetString("ActualizarTurno");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProYectoX.ActualizarTurno.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lblturno = new global::Gtk.Label();
			this.lblturno.Name = "lblturno";
			this.lblturno.LabelProp = global::Mono.Unix.Catalog.GetString("Archivo turno");
			this.vbox2.Add(this.lblturno);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lblturno]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.lbldescrpcionturno = new global::Gtk.Label();
			this.lbldescrpcionturno.Name = "lbldescrpcionturno";
			this.lbldescrpcionturno.LabelProp = global::Mono.Unix.Catalog.GetString("Descripción");
			this.hbox14.Add(this.lbldescrpcionturno);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.lbldescrpcionturno]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.entdescripcionturno = new global::Gtk.Entry();
			this.entdescripcionturno.CanFocus = true;
			this.entdescripcionturno.Name = "entdescripcionturno";
			this.entdescripcionturno.IsEditable = true;
			this.entdescripcionturno.InvisibleChar = '●';
			this.hbox14.Add(this.entdescripcionturno);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.entdescripcionturno]));
			w3.Position = 1;
			this.vbox2.Add(this.hbox14);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox14]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.lblhorainicturno = new global::Gtk.Label();
			this.lblhorainicturno.Name = "lblhorainicturno";
			this.lblhorainicturno.LabelProp = global::Mono.Unix.Catalog.GetString("Hora de inicio");
			this.hbox15.Add(this.lblhorainicturno);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.lblhorainicturno]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.combobox2 = global::Gtk.ComboBox.NewText();
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("8:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("9:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("10:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("11:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("12:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("13:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("14:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("15:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("16:00"));
			this.combobox2.AppendText(global::Mono.Unix.Catalog.GetString("17:00"));
			this.combobox2.AppendText("");
			this.combobox2.Name = "combobox2";
			this.combobox2.Active = 0;
			this.hbox15.Add(this.combobox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.combobox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add(this.hbox15);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox15]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox16 = new global::Gtk.HBox();
			this.hbox16.Name = "hbox16";
			this.hbox16.Spacing = 6;
			// Container child hbox16.Gtk.Box+BoxChild
			this.lblhoracierreturno = new global::Gtk.Label();
			this.lblhoracierreturno.Name = "lblhoracierreturno";
			this.lblhoracierreturno.LabelProp = global::Mono.Unix.Catalog.GetString("Hora de cierre");
			this.hbox16.Add(this.lblhoracierreturno);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.lblhoracierreturno]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.combobox4 = global::Gtk.ComboBox.NewText();
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("8:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("9:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("10:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("11:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("12:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("13:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("14:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("15:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("16:00"));
			this.combobox4.AppendText(global::Mono.Unix.Catalog.GetString("17:00"));
			this.combobox4.Name = "combobox4";
			this.combobox4.Active = 0;
			this.hbox16.Add(this.combobox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.combobox4]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox2.Add(this.hbox16);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox16]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox19 = new global::Gtk.HBox();
			this.hbox19.Name = "hbox19";
			this.hbox19.Spacing = 6;
			// Container child hbox19.Gtk.Box+BoxChild
			this.btnguardarturno = new global::Gtk.Button();
			this.btnguardarturno.CanFocus = true;
			this.btnguardarturno.Name = "btnguardarturno";
			this.btnguardarturno.UseUnderline = true;
			this.btnguardarturno.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox19.Add(this.btnguardarturno);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox19[this.btnguardarturno]));
			w11.Position = 0;
			// Container child hbox19.Gtk.Box+BoxChild
			this.btncancelaractturno = new global::Gtk.Button();
			this.btncancelaractturno.CanFocus = true;
			this.btncancelaractturno.Name = "btncancelaractturno";
			this.btncancelaractturno.UseUnderline = true;
			this.btncancelaractturno.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.hbox19.Add(this.btncancelaractturno);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox19[this.btncancelaractturno]));
			w12.Position = 1;
			this.vbox2.Add(this.hbox19);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox19]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox17 = new global::Gtk.HBox();
			this.hbox17.Name = "hbox17";
			this.hbox17.Spacing = 6;
			// Container child hbox17.Gtk.Box+BoxChild
			this.drawingarea4 = new global::Gtk.DrawingArea();
			this.drawingarea4.Name = "drawingarea4";
			this.hbox17.Add(this.drawingarea4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.drawingarea4]));
			w14.Position = 0;
			// Container child hbox17.Gtk.Box+BoxChild
			this.hbox18 = new global::Gtk.HBox();
			this.hbox18.Name = "hbox18";
			this.hbox18.Spacing = 6;
			// Container child hbox18.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label();
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Xpad = 96;
			this.lblfecha.Ypad = 2;
			this.lblfecha.Xalign = 0F;
			this.lblfecha.Yalign = 0F;
			this.hbox18.Add(this.lblfecha);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.lblfecha]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox18.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label();
			this.lblhora.Name = "lblhora";
			this.lblhora.Xpad = 87;
			this.lblhora.Ypad = 2;
			this.lblhora.Xalign = 1F;
			this.lblhora.Yalign = 0F;
			this.hbox18.Add(this.lblhora);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.lblhora]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox17.Add(this.hbox18);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.hbox18]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox17.Gtk.Box+BoxChild
			this.drawingarea3 = new global::Gtk.DrawingArea();
			this.drawingarea3.Name = "drawingarea3";
			this.hbox17.Add(this.drawingarea3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.drawingarea3]));
			w18.Position = 2;
			this.vbox2.Add(this.hbox17);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox17]));
			w19.Position = 5;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 404;
			this.DefaultHeight = 186;
			this.Show();
			this.btnguardarturno.Clicked += new global::System.EventHandler(this.OnBtnguardarturnoClicked);
			this.btncancelaractturno.Clicked += new global::System.EventHandler(this.OnBtncancelaractturnoClicked);
		}
	}
}
