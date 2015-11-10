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

[assembly: ExportRenderer(typeof(ExtendedListView), typeof(ExtendedListViewRenderer))]
namespace FirstProject.Droid
{
    

    public class ExtendedListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            UpdateText();

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ExtendedListView.ItemSelectedColorProperty.PropertyName)
                UpdateSelectedColor();
            UpdateText();
        }


        private void UpdateSelectedColor()
        {
            
        }

        #region private helpers

        private ExtendedListView MyElement
        {
            get
            {
                return Element as ExtendedListView;
            } 
        }

        private void UpdateText()
        {
            if (MyElement == null)
                return;


            Control.Selector = new Android.Graphics.Drawables.ColorDrawable(Xamarin.Forms.Color.Transparent.ToAndroid());

            Control.ItemClick += (sender, e) =>
            {
                if (CElement == null)
                    return;

                CElement.ItemSelectedColor = Xamarin.Forms.Color.FromHex(Constants.BACKGRAUND_COLOR_CELL);
                var color = CElement.ItemSelectedColor.ToAndroid();
                
                for (int i = 1; i < Control.ChildCount; i++)
                {
                    Control.GetChildAt(i).SetBackgroundColor(color);
                }


                CElement.ItemSelectedColor = Xamarin.Forms.Color.FromHex(Constants.BACKGRAUND_COLOR_SELECTEDCELL);
                color = CElement.ItemSelectedColor.ToAndroid();
                var child = e.View;
                if (child != null)
                    child.SetBackgroundColor(color);
                              
            };

        }




        #endregion

        private ExtendedListView CElement
        {
            get { return Element as ExtendedListView; }
        }
    }
}


