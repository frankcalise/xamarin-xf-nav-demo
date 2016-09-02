using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class ProcessPage : ContentPage
    {
        public ProcessPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Process content" }
                }
            };
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
