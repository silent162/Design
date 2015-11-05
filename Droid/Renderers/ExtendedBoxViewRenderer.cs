using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Graphics;
using Android.Hardware.Camera2;

[assembly: ExportRenderer (typeof(ExtendedBoxView), typeof(ExtendedBoxViewRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedBoxViewRenderer : BoxRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged (e);
			UpdateText ();
		}

		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);		
			UpdateText ();
		}

		public override void Draw (Android.Graphics.Canvas canvas)
		{
			//base.Draw (canvas);

			var box = Element as ExtendedBoxView;
			var rect = new Rect ();
			var paint = new Paint () {
				Color = box.BackgroundColor.ToAndroid (),
				AntiAlias = true,
			};
			GetDrawingRect (rect);
			canvas.DrawRoundRect (new RectF (rect), 100, 100, paint);



		}

		#region private helpers

		private ExtendedBoxView MyElement {
			get {
				return Element as ExtendedBoxView;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null)
				return;

			//MyElement.Bounds.Width = 10;
		}


		#endregion
	}
}


