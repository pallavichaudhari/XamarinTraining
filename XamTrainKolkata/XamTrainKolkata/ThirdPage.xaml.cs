﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamTrainKolkata
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        public void onButtonClick(object s, EventArgs e)
        {
            Navigation.PushAsync(new FourthPage());
        }
    }
}
