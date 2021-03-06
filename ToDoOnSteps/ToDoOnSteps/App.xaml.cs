﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoOnSteps
{
    public partial class App : Application
    {
        public static string DataBaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string dbName)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            DataBaseLocation = dbName;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
