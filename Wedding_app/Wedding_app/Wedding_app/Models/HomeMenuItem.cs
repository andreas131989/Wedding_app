using System;
using System.Collections.Generic;
using System.Text;

namespace Wedding_app.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        RSVP
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
