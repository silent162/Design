using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedButtonRenderer : ButtonRenderer
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

		private ExtendedButton MyElement {
			get {
				return Element as ExtendedButton;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;

			Control.SetAllCaps (false);
			//Control.SetPadding (100, 0, 100, 0);
			Control.SetPaddingRelative (60, 0, 100, 0);
		}


		#endregion
	}
}

