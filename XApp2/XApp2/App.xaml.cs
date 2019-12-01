﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = (new XApp2.Views.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
