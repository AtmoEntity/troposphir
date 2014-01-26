
// This file has been generated by the GUI designer. Do not modify.
namespace TroposphirLauncher
{
	public partial class SettingsWindow
	{
		private global::Gtk.Table layoutRoot;
		private global::Gtk.Button atmoPathSelect;
		private global::Gtk.Entry atmoPathTextBox;
		private global::Gtk.CheckButton autoUpdateCheckbox;
		private global::Gtk.Button button2;
		private global::Gtk.Label label1;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.CheckButton onlineCheckbox;
		private global::Gtk.Entry serverUrlTextBox;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TroposphirLauncher.SettingsWindow
			this.WidthRequest = 400;
			this.HeightRequest = 200;
			this.Name = "TroposphirLauncher.SettingsWindow";
			this.Title = "Launcher Settings";
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 400;
			this.DefaultHeight = 200;
			// Container child TroposphirLauncher.SettingsWindow.Gtk.Container+ContainerChild
			this.layoutRoot = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
			this.layoutRoot.WidthRequest = 400;
			this.layoutRoot.HeightRequest = 100;
			this.layoutRoot.Name = "layoutRoot";
			this.layoutRoot.RowSpacing = ((uint)(3));
			this.layoutRoot.ColumnSpacing = ((uint)(3));
			this.layoutRoot.BorderWidth = ((uint)(3));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.atmoPathSelect = new global::Gtk.Button ();
			this.atmoPathSelect.CanFocus = true;
			this.atmoPathSelect.Name = "atmoPathSelect";
			this.atmoPathSelect.UseUnderline = true;
			this.atmoPathSelect.Label = "Browse..";
			this.layoutRoot.Add (this.atmoPathSelect);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.atmoPathSelect]));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.atmoPathTextBox = new global::Gtk.Entry ();
			this.atmoPathTextBox.HeightRequest = 25;
			this.atmoPathTextBox.CanFocus = true;
			this.atmoPathTextBox.Name = "atmoPathTextBox";
			this.atmoPathTextBox.IsEditable = true;
			this.atmoPathTextBox.InvisibleChar = '●';
			this.layoutRoot.Add (this.atmoPathTextBox);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.atmoPathTextBox]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.autoUpdateCheckbox = new global::Gtk.CheckButton ();
			this.autoUpdateCheckbox.CanFocus = true;
			this.autoUpdateCheckbox.Name = "autoUpdateCheckbox";
			this.autoUpdateCheckbox.Label = "Check for Updates";
			this.autoUpdateCheckbox.Active = true;
			this.autoUpdateCheckbox.DrawIndicator = true;
			this.autoUpdateCheckbox.UseUnderline = true;
			this.layoutRoot.Add (this.autoUpdateCheckbox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.autoUpdateCheckbox]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = "Save";
			this.layoutRoot.Add (this.button2);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.button2]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = "Atmosphir Folder:";
			this.layoutRoot.Add (this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.label1]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = "Server address:";
			this.layoutRoot.Add (this.label3);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.label3]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = "Launcher and server software created by\nKevin Sonoda and Leonardo Scur\nwith great" +
			" support from the OneMoreBlock community.\nLicensed under the GNU Affero General " +
			"Public License\n\nhttps://github.com/MusicalIdiot/Troposphir";
			this.label4.Justify = ((global::Gtk.Justification)(2));
			this.layoutRoot.Add (this.label4);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.label4]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.onlineCheckbox = new global::Gtk.CheckButton ();
			this.onlineCheckbox.CanFocus = true;
			this.onlineCheckbox.Name = "onlineCheckbox";
			this.onlineCheckbox.Label = "Online Mode";
			this.onlineCheckbox.Active = true;
			this.onlineCheckbox.DrawIndicator = true;
			this.onlineCheckbox.UseUnderline = true;
			this.layoutRoot.Add (this.onlineCheckbox);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.onlineCheckbox]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutRoot.Gtk.Table+TableChild
			this.serverUrlTextBox = new global::Gtk.Entry ();
			this.serverUrlTextBox.CanFocus = true;
			this.serverUrlTextBox.Name = "serverUrlTextBox";
			this.serverUrlTextBox.IsEditable = true;
			this.serverUrlTextBox.InvisibleChar = '●';
			this.layoutRoot.Add (this.serverUrlTextBox);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.layoutRoot [this.serverUrlTextBox]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(3));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.layoutRoot);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDelete);
			this.serverUrlTextBox.Changed += new global::System.EventHandler (this.UpdateServerAddress);
			this.onlineCheckbox.Toggled += new global::System.EventHandler (this.UpdateOnlineMode);
			this.autoUpdateCheckbox.Toggled += new global::System.EventHandler (this.UpdateAutoUpdate);
			this.atmoPathTextBox.Changed += new global::System.EventHandler (this.UpdateExecutablePath);
			this.atmoPathSelect.Clicked += new global::System.EventHandler (this.OpenAtmoPathSelector);
		}
	}
}