﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KpKApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUS : ContentPage
    {
        public AboutUS()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}