﻿using System;
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

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}