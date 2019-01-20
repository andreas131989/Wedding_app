using Wedding_app.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wedding_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Homepage, Title="Homepage" },
                new HomeMenuItem {Id = MenuItemType.RSVP, Title="RSVP" },
                new HomeMenuItem {Id = MenuItemType.Program, Title="Program" },
                new HomeMenuItem {Id = MenuItemType.Venue, Title="Venue" },
                new HomeMenuItem {Id = MenuItemType.Accomodation, Title="Accomodation" },
                new HomeMenuItem {Id = MenuItemType.Uploads, Title="Uploads" },
                new HomeMenuItem {Id = MenuItemType.Registry, Title="Registry" },
                new HomeMenuItem {Id = MenuItemType.Socialize, Title="Socialize" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}