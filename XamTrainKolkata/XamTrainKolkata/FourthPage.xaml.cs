﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamTrainKolkata
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
            Label vNewLabel = new Label { Text = "This is Created From Code", TextColor = Color.Blue };
            MainStack.Children.Add(vNewLabel);
        }
    }
}
