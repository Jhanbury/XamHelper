using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamHelper.Converters;

namespace XamHelperTest
{
    public class XamHelperTest : ContentPage
    {
        public XamHelperTest()
        {
            var converter = new InverseBooleanConverter();
            var button = new Button
            {
                Text = "Click Me!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsEnabled = (bool)converter.Convert(true,null,null,null)
            };

            int clicked = 0;
            button.Clicked += (s, e) => button.Text = "Clicked: " + clicked++;

            Content = button;
        }
    }
}
