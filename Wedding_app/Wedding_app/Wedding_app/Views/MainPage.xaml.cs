using Wedding_app.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wedding_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Homepage, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Homepage:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.RSVP:
                        MenuPages.Add(id, new NavigationPage(new RSVPPage()));
                        break;
                    case (int)MenuItemType.Program:
                        MenuPages.Add(id, new NavigationPage(new ProgramPage()));
                        break;
                    case (int)MenuItemType.Accomodation:
                        MenuPages.Add(id, new NavigationPage(new AccomodationPage()));
                        break;
                    case (int)MenuItemType.Venue:
                        MenuPages.Add(id, new NavigationPage(new VenuePage()));
                        break;
                    case (int)MenuItemType.Registry:
                        MenuPages.Add(id, new NavigationPage(new RegistryPage()));
                        break;
                    case (int)MenuItemType.Uploads:
                        MenuPages.Add(id, new NavigationPage(new UploadsPage()));
                        break;
                    case (int)MenuItemType.Socialize:
                        MenuPages.Add(id, new NavigationPage(new SocializePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}