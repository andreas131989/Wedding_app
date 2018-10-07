using System;
using System.Collections.Generic;
using System.Text;

namespace Wedding_app.Models
{
    public enum MenuItemType
    {
        Homepage,
        About,
        RSVP,
        Program,
        Venue,
        Accomodation,
        Transportation,
        Uploads,
        Registry,
        Socialize
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
