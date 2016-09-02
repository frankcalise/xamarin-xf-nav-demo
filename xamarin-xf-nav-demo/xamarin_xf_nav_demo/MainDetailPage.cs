using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class MainDetailPage : ContentPage
    {
        ICommand OnSiteClickCommand { get; set; }

        public MainDetailPage()
        {
            var items = new List<MasterPageItem>();
            items.Add(new MasterPageItem { Title = "Site 1" });
            items.Add(new MasterPageItem { Title = "Site 2" });
            items.Add(new MasterPageItem { Title = "Site 3" });

            OnSiteClickCommand = new Command<string>(OnSiteSelected);

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                        new ListView {
                            ItemsSource = items,
                            ItemTemplate = new DataTemplate(() => {
                                var imageCell = new ImageCell();
                                imageCell.SetBinding(TextCell.TextProperty, "Title");
                                //imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                                imageCell.Command = OnSiteClickCommand;
                                return imageCell;
                            }),
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            SeparatorVisibility = SeparatorVisibility.None
                        }
                    }
            };

            Title = "Site List";
        }

        void OnSiteSelected(string siteInfo)
        {
            
            Navigation.PushModalAsync(new SiteDetailPage());
        }

    }
}
