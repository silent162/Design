using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(MyEntry), typeof(MyEntryRenderer))]
namespace FirstProject.Droid
{
	public class MyEntryRenderer : EntryRenderer
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

		private MyEntry MyElement {
			get {
				return Element as MyEntry;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;

			Control.SetBackgroundColor (Android.Graphics.Color.Transparent);

		}


		#endregion
	}
}

