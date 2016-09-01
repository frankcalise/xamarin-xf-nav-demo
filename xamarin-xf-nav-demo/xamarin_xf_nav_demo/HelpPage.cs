using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class HelpPage : ContentPage
    {
        public HelpPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Help & feedback page" }
                }
            };
        }
    }
}
