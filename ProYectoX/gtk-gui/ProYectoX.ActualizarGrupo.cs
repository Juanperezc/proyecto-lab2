
// This file has been generated by the GUI designer. Do not modify.
namespace ProYectoX
{
	public partial class ActualizarGrupo
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label lblgrupo;

		private global::Gtk.HBox hbox1;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label lblcodgrupo;

		private global::Gtk.Entry entcodigogrupo;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label lblinstasiggrupo;

		private global::Gtk.ComboBox comboinstasigrupo;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label lblfechainicgrupo;

		private global::Gtk.Entry entfechainicgrupo;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label lblcursoasiggrupo1;

		private global::Gtk.ComboBox combocursasinggrupo;

		private global::Gtk.HBox hbox3;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label lblfechacierre;

		private global::Gtk.Entry entfechacierregrupo1;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label lblturnoasiggrupo2;

		private global::Gtk.ComboBox comboturnoasiggrupo;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Button btnguardargrupo;

		private global::Gtk.Button btncancelaractgrupo;

		private global::Gtk.HBox hbox12;

		private global::Gtk.DrawingArea drawingarea2;

		private global::Gtk.HBox hbox13;

		private global::Gtk.Label lblfecha;

		private global::Gtk.Label lblhora;

		private global::Gtk.DrawingArea drawingarea1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProYectoX.ActualizarGrupo
			this.Name = "ProYectoX.ActualizarGrupo";
			this.Title = global::Mono.Unix.Catalog.GetString("ActualizarGrupo");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProYectoX.ActualizarGrupo.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblgrupo = new global::Gtk.Label();
			this.lblgrupo.Name = "lblgrupo";
			this.lblgrupo.LabelProp = global::Mono.Unix.Catalog.GetString("Archivo grupo");
			this.vbox1.Add(this.lblgrupo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblgrupo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.lblcodgrupo = new global::Gtk.Label();
			this.lblcodgrupo.Name = "lblcodgrupo";
			this.lblcodgrupo.LabelProp = global::Mono.Unix.Catalog.GetString("Código");
			this.hbox4.Add(this.lblcodgrupo);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.lblcodgrupo]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entcodigogrupo = new global::Gtk.Entry();
			this.entcodigogrupo.CanFocus = true;
			this.entcodigogrupo.Name = "entcodigogrupo";
			this.entcodigogrupo.IsEditable = true;
			this.entcodigogrupo.InvisibleChar = '●';
			this.hbox4.Add(this.entcodigogrupo);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entcodigogrupo]));
			w3.Position = 1;
			this.hbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox4]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.lblinstasiggrupo = new global::Gtk.Label();
			this.lblinstasiggrupo.Name = "lblinstasiggrupo";
			this.lblinstasiggrupo.LabelProp = global::Mono.Unix.Catalog.GetString("Instructor asignado");
			this.hbox7.Add(this.lblinstasiggrupo);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.lblinstasiggrupo]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.comboinstasigrupo = global::Gtk.ComboBox.NewText();
			this.comboinstasigrupo.Name = "comboinstasigrupo";
			this.hbox7.Add(this.comboinstasigrupo);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.comboinstasigrupo]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox1.Add(this.hbox7);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox7]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.lblfechainicgrupo = new global::Gtk.Label();
			this.lblfechainicgrupo.Name = "lblfechainicgrupo";
			this.lblfechainicgrupo.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de inicio");
			this.hbox5.Add(this.lblfechainicgrupo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lblfechainicgrupo]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entfechainicgrupo = new global::Gtk.Entry();
			this.entfechainicgrupo.CanFocus = true;
			this.entfechainicgrupo.Name = "entfechainicgrupo";
			this.entfechainicgrupo.IsEditable = true;
			this.entfechainicgrupo.InvisibleChar = '●';
			this.hbox5.Add(this.entfechainicgrupo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entfechainicgrupo]));
			w10.Position = 1;
			this.hbox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox5]));
			w11.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lblcursoasiggrupo1 = new global::Gtk.Label();
			this.lblcursoasiggrupo1.Name = "lblcursoasiggrupo1";
			this.lblcursoasiggrupo1.LabelProp = global::Mono.Unix.Catalog.GetString("Curso asignado");
			this.hbox8.Add(this.lblcursoasiggrupo1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lblcursoasiggrupo1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.combocursasinggrupo = global::Gtk.ComboBox.NewText();
			this.combocursasinggrupo.Name = "combocursasinggrupo";
			this.hbox8.Add(this.combocursasinggrupo);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.combocursasinggrupo]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox2.Add(this.hbox8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox8]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lblfechacierre = new global::Gtk.Label();
			this.lblfechacierre.Name = "lblfechacierre";
			this.lblfechacierre.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de cierre");
			this.hbox6.Add(this.lblfechacierre);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.lblfechacierre]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entfechacierregrupo1 = new global::Gtk.Entry();
			this.entfechacierregrupo1.CanFocus = true;
			this.entfechacierregrupo1.Name = "entfechacierregrupo1";
			this.entfechacierregrupo1.IsEditable = true;
			this.entfechacierregrupo1.InvisibleChar = '●';
			this.hbox6.Add(this.entfechacierregrupo1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entfechacierregrupo1]));
			w17.Position = 1;
			this.hbox3.Add(this.hbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox6]));
			w18.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.lblturnoasiggrupo2 = new global::Gtk.Label();
			this.lblturnoasiggrupo2.Name = "lblturnoasiggrupo2";
			this.lblturnoasiggrupo2.LabelProp = global::Mono.Unix.Catalog.GetString("Turno asignado");
			this.hbox9.Add(this.lblturnoasiggrupo2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lblturnoasiggrupo2]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.comboturnoasiggrupo = global::Gtk.ComboBox.NewText();
			this.comboturnoasiggrupo.Name = "comboturnoasiggrupo";
			this.hbox9.Add(this.comboturnoasiggrupo);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.comboturnoasiggrupo]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.hbox3.Add(this.hbox9);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox9]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w22.Position = 3;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btnguardargrupo = new global::Gtk.Button();
			this.btnguardargrupo.CanFocus = true;
			this.btnguardargrupo.Name = "btnguardargrupo";
			this.btnguardargrupo.UseUnderline = true;
			this.btnguardargrupo.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox11.Add(this.btnguardargrupo);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.btnguardargrupo]));
			w23.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btncancelaractgrupo = new global::Gtk.Button();
			this.btncancelaractgrupo.CanFocus = true;
			this.btncancelaractgrupo.Name = "btncancelaractgrupo";
			this.btncancelaractgrupo.UseUnderline = true;
			this.btncancelaractgrupo.Label = global::Mono.Unix.Catalog.GetString("Cancelar");
			this.hbox11.Add(this.btncancelaractgrupo);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.btncancelaractgrupo]));
			w24.Position = 1;
			this.vbox1.Add(this.hbox11);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox11]));
			w25.Position = 4;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.drawingarea2 = new global::Gtk.DrawingArea();
			this.drawingarea2.Name = "drawingarea2";
			this.hbox12.Add(this.drawingarea2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.drawingarea2]));
			w26.Position = 0;
			// Container child hbox12.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.lblfecha = new global::Gtk.Label();
			this.lblfecha.Name = "lblfecha";
			this.lblfecha.Xpad = 96;
			this.lblfecha.Ypad = 2;
			this.lblfecha.Xalign = 0F;
			this.lblfecha.Yalign = 0F;
			this.hbox13.Add(this.lblfecha);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.lblfecha]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.lblhora = new global::Gtk.Label();
			this.lblhora.Name = "lblhora";
			this.lblhora.Xpad = 87;
			this.lblhora.Ypad = 2;
			this.lblhora.Xalign = 1F;
			this.lblhora.Yalign = 0F;
			this.hbox13.Add(this.lblhora);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.lblhora]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox12.Add(this.hbox13);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.hbox13]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.drawingarea1 = new global::Gtk.DrawingArea();
			this.drawingarea1.Name = "drawingarea1";
			this.hbox12.Add(this.drawingarea1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.drawingarea1]));
			w30.Position = 2;
			this.vbox1.Add(this.hbox12);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox12]));
			w31.Position = 5;
			w31.Expand = false;
			w31.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 440;
			this.DefaultHeight = 184;
			this.Show();
			this.btnguardargrupo.Clicked += new global::System.EventHandler(this.OnBtnguardargrupoClicked);
			this.btncancelaractgrupo.Clicked += new global::System.EventHandler(this.OnBtncancelaractusuClicked);
		}
	}
}