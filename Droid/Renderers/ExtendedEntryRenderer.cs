using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
			UpdateText ();
		}

		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);		
			UpdateText ();
		}

		#region private helpers

		private ExtendedEntry MyElement {
			get {
				return Element as ExtendedEntry;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;

			Control.SetBackgroundColor (Android.Graphics.Color.Transparent);
			Control.TextSize = Constants.ENTRY_FONT_SIZE;
			Control.SetPaddingRelative (0, 30, 0, 30);
		}


		#endregion
	}
}

