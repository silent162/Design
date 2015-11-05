using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Widget;

[assembly: ExportRenderer (typeof(ExtendedPicker), typeof(ExtendedPickerRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedPickerRenderer : PickerRenderer
	{
		
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Picker> e)
		{
			base.OnElementChanged (e);
		}


		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);		
			//UpdateText ();
			Control.SetBackgroundColor (Android.Graphics.Color.Transparent);
			Control.TextSize = 18;
			Control.SetPaddingRelative (210, 0, 40, 30);
			Control.SetBackgroundColor (global::Android.Graphics.Color.Transparent);
			Control.SetHintTextColor (global::Android.Graphics.Color.ParseColor ("#0377c3"));
			Control.SetTextColor (global::Android.Graphics.Color.ParseColor ("#0377c3"));

		}


		//		#region private helpers
		//
		//		private ExtendedPicker MyElement {
		//			get {
		//				return Element as ExtendedPicker;
		//			}
		//		}
		//
		//		private void UpdateText ()
		//		{
		//			if (MyElement == null || Control == null)
		//				return;
		//
		//			Control.Text = "13";
		//
		//		}
		//
		//
		//		#endregion
	}
}