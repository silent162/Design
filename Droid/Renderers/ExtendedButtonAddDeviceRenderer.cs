using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Views;

[assembly: ExportRenderer (typeof(ExtendedButtonAddDevice), typeof(ExtendedButtonAddDeviceRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedButtonAddDeviceRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
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

		private ExtendedButtonAddDevice MyElement {
			get {
				return Element as ExtendedButtonAddDevice;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;


			//Control.Selector = new Android.Graphics.Drawables.ColorDrawable (Xamarin.Forms.Color.Transparent.ToAndroid ());
			Control.SetPadding (60, 0, 20, 0);
			//Control.SetPaddingRelative (0, 0, 0, 0);
			Control.SetAllCaps (false);
			//Control.Gravity = GravityFlags.Left;
		}


		#endregion
	}
}


