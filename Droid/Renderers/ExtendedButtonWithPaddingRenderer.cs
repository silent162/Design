using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(ExtendedButtonWithPadding), typeof(ExtendedButtonWithPaddingRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedButtonWithPaddingRenderer : ButtonRenderer
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

		private ExtendedButtonWithPadding MyElement {
			get {
				return Element as ExtendedButtonWithPadding;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;
			
			Control.SetPadding (0, 0, 60, 0);
			Control.SetAllCaps (false);
		}


		#endregion
	}
}


