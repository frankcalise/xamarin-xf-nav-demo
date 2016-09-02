using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace xamarin_xf_nav_demo
{
    public class SiteDetailPage : TabbedPage
    {
        public SiteDetailPage()
        {
            var profilePage = new NavigationPage(new ProfilePage());
            profilePage.Title = "Profile";

            var processPage = new NavigationPage(new ProcessPage());
            processPage.Title = "Process";

            var schedulingPage = new NavigationPage(new SchedulingPage());
            schedulingPage.Title = "Scheduling";

            var biddingPage = new NavigationPage(new BiddingPage());
            biddingPage.Title = "Bidding";

            Children.Add(profilePage);
            Children.Add(processPage);
            Children.Add(schedulingPage);
            Children.Add(biddingPage);
        }
    }
}
