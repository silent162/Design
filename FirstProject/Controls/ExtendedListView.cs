using System;

using Xamarin.Forms;

namespace FirstProject
{
    public class ExtendedListView : ListView
    {
        public ExtendedListView()
        {
			
        }

        public static readonly BindableProperty ItemSelectedColorProperty =
            BindableProperty.Create<ExtendedListView, Color>(p => p.ItemSelectedColor, default(Color));

        public Color ItemSelectedColor
        {
            get { return (Color)GetValue(ItemSelectedColorProperty); }
            set { SetValue(ItemSelectedColorProperty, value); }
        }
    }
}


