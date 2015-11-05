using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Graphics;
using Android.Hardware.Camera2;

[assembly: ExportRenderer (typeof(ExtendedFrame), typeof(ExtendedFrameRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedFrameRenderer : FrameRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Frame> e)
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

			var box = Element as ExtendedFrame;
			var rect = new Rect ();
			var paint = new Paint () {
				Color = box.BackgroundColor.ToAndroid (),
				AntiAlias = true,
			};
			GetDrawingRect (rect);
			canvas.DrawRoundRect (new RectF (rect), 100, 100, paint);


		}

		#region private helpers

		private ExtendedFrame MyElement {
			get {
				return Element as ExtendedFrame;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null)
				return;

			//MyElement.

		}


		#endregion
	}
}


