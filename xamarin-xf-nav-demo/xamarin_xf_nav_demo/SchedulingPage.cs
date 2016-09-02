using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class SchedulingPage : ContentPage
    {
        public SchedulingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Scheduling content" }
                }
            };
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
