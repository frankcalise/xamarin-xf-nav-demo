using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Profile page" }
                }
            };


        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
