using System;
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
<<<<<<< HEAD
           /* if (myGlobals.popuptext == true)
=======
            NavigationService.RemoveBackEntry();
            if (!App.ViewModel.IsDataLoaded)
>>>>>>> f3fc2ea63f5f2d520b61491b3bfae68ad9882df9
            {
                NavigationService.Navigate(new Uri("List.xaml",UriKind.Relative));

            }
            else
            {*/
                NavigationService.RemoveBackEntry();
                if (!App.ViewModel.IsDataLoaded)
                {
                    App.ViewModel.LoadData();

                }

                //Runs everytime program loads,
                if (myGlobals.ListofItems.Count == 0) { }
                else
                {
                    //Remove Past TextBlocks


                    ListNamePanel.Children.Clear();

                    //Add TextBlocks to ListColumn
                    for (int x = 0; x < (myGlobals.ListofItems.Count); x++)
                    {
                        TextBlock ListColumn = new TextBlock();
                        {
                            ListColumn.FontSize = 30;
                            ListColumn.Name = x.ToString();
                            ListColumn.Text = myGlobals.ListofItems[x];

                        };
                        ListNamePanel.Children.Add(ListColumn);
                        ListColumn.Tap += new EventHandler<System.Windows.Input.GestureEventArgs>(HandleTap);



                    }

                }
            //}
    }
        
        private void Pivot_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }
        public void Add_New_Item(Object sender, EventArgs e)
        {
            //Navigation to New List page
            NavigationService.Navigate(new Uri("/NewList.xaml", UriKind.Relative));
        }

       void HandleTap(Object sender, EventArgs e)
        {

            // on selected Textblock, move to that list
         TextBlock tb= new TextBlock();
           tb = (TextBlock)sender;
           myGlobals.CurrentList = tb.Text;
           NavigationService.Navigate(new Uri("/List.xaml", UriKind.Relative));
        }

        void HandleHold(object sender, EventArgs e)
       {

       }
    }
}