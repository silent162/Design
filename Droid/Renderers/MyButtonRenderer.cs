using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;

[assembly: ExportRenderer (typeof(MyButton), typeof(MyButtonRenderer))]
namespace FirstProject.Droid
{
	public class MyButtonRenderer : ButtonRenderer
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

		private MyButton MyElement {
			get {
				return Element as MyButton;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null || Control == null)
				return;

			Control.SetAllCaps (false);
		}


		#endregion
	}
}

