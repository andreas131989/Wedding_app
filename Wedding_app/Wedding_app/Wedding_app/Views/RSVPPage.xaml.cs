using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wedding_app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RSVPPage : ContentPage
	{
		public RSVPPage ()
		{
			InitializeComponent ();
		}

        private void RSVP_yes_Clicked(object sender, EventArgs e)
        {
            RSVP_yes.BackgroundColor = Color.Green;
            RSVP_no.BackgroundColor = Color.Default;
            RSVP_maybe.BackgroundColor = Color.Default;
        }

        private void RSVP_no_Clicked(object sender, EventArgs e)
        {
            RSVP_no.BackgroundColor = Color.Red;
            RSVP_yes.BackgroundColor = Color.Default;
            RSVP_maybe.BackgroundColor = Color.Default;
        }

        private void RSVP_maybe_Clicked(object sender, EventArgs e)
        {
            RSVP_maybe.BackgroundColor = Color.Yellow;
            RSVP_no.BackgroundColor = Color.Default;
            RSVP_yes.BackgroundColor = Color.Default;
        }

        private void own_trans_Clicked(object sender, EventArgs e)
        {
            own_trans.BackgroundColor = Color.DarkGray;
            rent_trans.BackgroundColor = Color.Default;
            none_trans.BackgroundColor = Color.Default;             
        }

        private void rent_trans_Clicked(object sender, EventArgs e)
        {
            rent_trans.BackgroundColor = Color.DarkGray;
            own_trans.BackgroundColor = Color.Default;
            none_trans.BackgroundColor = Color.Default;
        }

        private void none_trans_Clicked(object sender, EventArgs e)
        {
            none_trans.BackgroundColor = Color.DarkGray;
            own_trans.BackgroundColor = Color.Default;
            rent_trans.BackgroundColor = Color.Default;
        }

        private void Done_Clicked(object sender, EventArgs e)
        {
            RSVP_no.IsEnabled = false;
            RSVP_yes.IsEnabled = false;
            RSVP_maybe.IsEnabled = false;
            own_trans.IsEnabled = false;
            rent_trans.IsEnabled = false;
            none_trans.IsEnabled = false;
            arrival.IsEnabled = false;
            departure.IsEnabled = false;
            reg_email.IsEnabled = false;
            reg_phone.IsEnabled = false;
            reg_name.IsEnabled = false;
            reg_meal.IsEnabled = false;
            reg_surname.IsEnabled = false;
            plus_email.IsEnabled = false;
            plus_phone.IsEnabled = false;
            plus_name.IsEnabled = false;
            plus_surname.IsEnabled = false;
            plus_meal.IsEnabled = false;
        }

        private void Modify_Clicked(object sender, EventArgs e)
        {
            RSVP_no.IsEnabled = true;
            RSVP_yes.IsEnabled = true;
            RSVP_maybe.IsEnabled = true;
            own_trans.IsEnabled = true;
            rent_trans.IsEnabled = true;
            none_trans.IsEnabled = true;
            arrival.IsEnabled = true;
            departure.IsEnabled = true;
            reg_email.IsEnabled = true;
            reg_phone.IsEnabled = true;
            reg_name.IsEnabled = true;
            reg_meal.IsEnabled = true;
            reg_surname.IsEnabled = true;
            plus_email.IsEnabled = true;
            plus_phone.IsEnabled = true;
            plus_name.IsEnabled = true;
            plus_surname.IsEnabled = true;
            plus_meal.IsEnabled = true;
        }
    }
}