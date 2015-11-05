//using System;
//using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms;
//using FirstProject;
//using FirstProject.Droid;
//using Android.Runtime;
//using System.ComponentModel;
//using Android.Widget;
//using Android.Hardware.Camera2;
//
//[assembly: ExportRenderer (typeof(ExtendedViewCell), typeof(ExtendedViewCellRenderer))]
//namespace FirstProject.Droid
//{
//	public class ExtendedViewCellRenderer : ViewCellRenderer
//	{
//
//		protected override void OnCellPropertyChanged (object sender, PropertyChangedEventArgs e)
//		{
//			base.OnCellPropertyChanged (sender, e);
//			this.Cell.Tapped += (senderr, es) => {
//				Console.Write ("vb");
//			};
//		}
//
//		protected override Android.Views.View GetCellCore (Cell item, Android.Views.View convertView, Android.Views.ViewGroup parent, Android.Content.Context context)
//		{
//			item.Tapped += (senderr, es) => {
//				Console.Write ("vb");
//			};
//			return base.GetCellCore (item, convertView, parent, context);
//		}



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
//	}
//}