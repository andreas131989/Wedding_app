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
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Homepage" },
                new HomeMenuItem {Id = MenuItemType.RSVP, Title="RSVP" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Program" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Venue" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Accomodation" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Transportation" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Uploads" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Registry" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Socialize" }
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