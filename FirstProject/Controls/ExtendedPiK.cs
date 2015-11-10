using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace FirstProject
{
    public class ExtendedPiK : ContentView
    {
		
        public ExtendedPiK()
        {					
            //this.BindingContext = new {asd = 100};
            //pickerBackground.SetBinding (Button.BorderRadiusProperty, "asd");

            // Create the RelativeLayout
            RelativeLayout relativeLayout = new RelativeLayout();

            ExtendedButton pickerBackground = new ExtendedButton
            {
                Text = "",
                BorderRadius = 100,
                BorderColor = Color.FromHex(Constants.BORDER_COLOR),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex(Constants.BACKGRAUND_COLOR),
                HeightRequest = 40,
            };

            relativeLayout.Children.Add(pickerBackground,				
                widthConstraint: Constraint.RelativeToParent((parent) =>
                    {
                        return parent.Width;
                    }));
			
            ExtendedButtonCircleBackGr circleBtn = new ExtendedButtonCircleBackGr
            {
                Text = "",
                BorderRadius = 100,
                BorderColor = Color.FromHex(Constants.BORDER_COLOR),
                BorderWidth = 1,
                BackgroundColor = Color.FromHex("#212c56"),
                Image = "menu_filter_arrow",

            };
            relativeLayout.Children.Add(circleBtn,				
                Constraint.RelativeToView(pickerBackground, (parent, sibling) =>
                    {
                        return sibling.Width - 35;
                    }),
                Constraint.RelativeToView(pickerBackground, (parent, sibling) =>
                    {
                        return sibling.Height - 35;
                    }),
                Constraint.RelativeToView(pickerBackground, (parent, sibling) =>
                    {
                        return sibling.Height - 9;
                    }),
                Constraint.RelativeToView(pickerBackground, (parent, sibling) =>
                    {
                        return sibling.Height - 9;
                    })
            );

            ExtendedPicker picker = new ExtendedPicker
            {
                Title = "все"
            };
            picker.Items.Add("C#");
            picker.Items.Add("C++");
            picker.Items.Add("Java");
            picker.Items.Add("все");

            relativeLayout.Children.Add(picker,				
                widthConstraint: Constraint.RelativeToParent((parent) =>
                    {
                        return parent.Width;
                    }),
                heightConstraint: Constraint.RelativeToParent((parent) =>
                    {
                        return parent.Height;
                    })
            );			
			
            Content = relativeLayout;		

        }
    }
}


