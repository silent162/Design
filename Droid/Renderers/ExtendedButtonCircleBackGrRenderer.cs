using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Views;

[assembly: ExportRenderer (typeof(ExtendedButtonCircleBackGr), typeof(ExtendedButtonCircleBackGrRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedButtonCircleBackGrRenderer : ButtonRenderer
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

		private ExtendedButtonCircleBackGr MyElement {
			get {
				return Element as ExtendedButtonCircleBackGr;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;



			Control.SetPadding (22, 0, 0, 0);

		}


		#endregion
	}
}


