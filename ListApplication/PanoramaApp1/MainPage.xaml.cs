﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PanoramaApp1
{
 
    public partial class MainPage : PhoneApplicationPage
    {
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            if (myGlobals.ListofItems.Count==0)
            {
                tbTemp.Text = "empty";
            }
            else
            {
                tbTemp.Text = myGlobals.ListofItems[0];
            }
     
    }

        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }
        public void Add_New_Item(Object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewList.xaml", UriKind.Relative));
        }
    }
}