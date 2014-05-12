﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;

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
            //Runs everytime program loads, 
            if (myGlobals.ListofItems.Count == 0) { }
            else
            {
                
              for(int x=0; x<(myGlobals.ListofItems.Count);x++)
              {
                  TextBlock ListColumn = new TextBlock();
                  {
                  ListColumn.FontSize = 30;
                  ListColumn.Name = x.ToString();
                  ListColumn.Text = myGlobals.ListofItems[x];
                  };
                  ListColumn.Tap += new EventHandler<GestureEventArgs>(HandleTap);
                
                  ListNamePanel.Children.Add(ListColumn);
                  
              }
               // tbTemp.Text = myGlobals.ListofItems[0];
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

       void HandleTap(Object sender, GestureEventArgs e)
        {

            object ListName = sender.GetType();//.GetProperty("Name", typeof(string)).ToString();
         TextBlock tb= new TextBlock();
           tb = (TextBlock)sender;
           string hold = tb.Text;
           MessageBox.Show(hold);
           
        }

        void HandleHold(object sender, GestureEventArgs e)
       {

       }
    }
}