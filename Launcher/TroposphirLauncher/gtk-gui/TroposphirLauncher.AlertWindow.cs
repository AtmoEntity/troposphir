
// This file has been generated by the GUI designer. Do not modify.
namespace TroposphirLauncher
{
	public partial class AlertWindow
	{
		private global::Gtk.Table table1;
		private global::Gtk.Label alertText;
		private global::Gtk.Button okButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TroposphirLauncher.AlertWindow
			this.WidthRequest = 200;
			this.HeightRequest = 100;
			this.Name = "TroposphirLauncher.AlertWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AlertWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 200;
			this.DefaultHeight = 100;
			// Container child TroposphirLauncher.AlertWindow.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table1.WidthRequest = 200;
			this.table1.HeightRequest = 100;
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(3));
			this.table1.ColumnSpacing = ((uint)(3));
			this.table1.BorderWidth = ((uint)(3));
			// Container child table1.Gtk.Table+TableChild
			this.alertText = new global::Gtk.Label ();
			this.alertText.WidthRequest = 200;
			this.alertText.HeightRequest = 66;
			this.alertText.Name = "alertText";
			this.alertText.LabelProp = "?";
			this.alertText.Justify = ((global::Gtk.Justification)(2));
			this.table1.Add (this.alertText);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.alertText]));
			w1.BottomAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.okButton = new global::Gtk.Button ();
			this.okButton.WidthRequest = 66;
			this.okButton.HeightRequest = 25;
			this.okButton.CanFocus = true;
			this.okButton.Name = "okButton";
			this.okButton.UseUnderline = true;
			this.okButton.Label = "OK";
			this.table1.Add (this.okButton);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.okButton]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.okButton.Clicked += new global::System.EventHandler (this.Close);
		}
	}
}
