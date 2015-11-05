using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Views;

[assembly: ExportRenderer (typeof(ExtendedButtonMainMenu), typeof(ExtendedButtonMainMenuRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedButtonMainMenuRenderer : ButtonRenderer
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

		private ExtendedButtonMainMenu MyElement {
			get {
				return Element as ExtendedButtonMainMenu;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;
			
			Control.SetPadding (40, 40, 0, 0);
			Control.SetAllCaps (false);
			Control.Gravity = GravityFlags.Left;
		}


		#endregion
	}
}


	