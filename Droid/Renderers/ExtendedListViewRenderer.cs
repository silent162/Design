using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using FirstProject;
using FirstProject.Droid;
using Android.Runtime;
using System.ComponentModel;
using Android.Graphics;
using Android.Hardware.Camera2;
using System.Threading;

[assembly: ExportRenderer (typeof(ExtendedListView), typeof(ExtendedListViewRenderer))]
namespace FirstProject.Droid
{
	public class ExtendedListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<ListView> e)
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

		private ExtendedListView MyElement {
			get {
				return Element as ExtendedListView;
			} 
		}

		private void UpdateText ()
		{
			if (MyElement == null)
				return;
			

			Control.Selector = new Android.Graphics.Drawables.ColorDrawable (Xamarin.Forms.Color.Transparent.ToAndroid ());

			Control.ItemClick += (sender, e) => {				
				for (int i = 1; i < Control.ChildCount; i++) {
					Control.GetChildAt (i).SetBackgroundColor (Xamarin.Forms.Color.FromHex ("#212c56").ToAndroid ());
				}
			
				var child = e.View;
				if (child != null)
					child.SetBackgroundColor (Xamarin.Forms.Color.FromHex ("#1D274D").ToAndroid ());
//				
			};

		}

		public override void ScrollTo (int x, int y)
		{
			base.ScrollTo (x, y);
		}

		public override void SetScrollIndicators (int indicators)
		{
			base.SetScrollIndicators (indicators);
		}

		protected override void OnScrollChanged (int l, int t, int oldl, int oldt)
		{
			base.OnScrollChanged (l, t, oldl, oldt);
		}

		#endregion
	}
}


