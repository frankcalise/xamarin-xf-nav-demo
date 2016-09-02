using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class BiddingPage : ContentPage
    {
        public BiddingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Bidding content" }
                }
            };
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
