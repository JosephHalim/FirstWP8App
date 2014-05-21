using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;
using Windows.UI.Popups;




namespace PanoramaApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        Popup popup = new Popup();
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Update List Title and populate list
            Title.Text = myGlobals.CurrentList;
            Update();
          }

     
        

        void Add_New_Item(object sender, EventArgs e)
        {
          
            WindowsPhoneControl1 control = new WindowsPhoneControl1();
            popup.Child = control;
            popup.IsOpen = true;
            //Adds function to the accept text button
            control.AcceptText.Click += (s, args) =>
                {
                    string ProductName = control.ItemName.Text.ToString();
                    string NumberofUnits = control.Quantity.Text.ToString();
                    myGlobals.ListofObjects.Add(ProductName, NumberofUnits);
                    popup.IsOpen= false;
                    Update();
                };
            //Adds control to cancel button
            control.CancelText.Click += (s, args) =>
                {
                    popup.IsOpen = false;
                };
        }
        private void DeleteList(object sender, EventArgs e)
        {

        }
        private void SortData(object sender, EventArgs e)
        {

        }

        //run an update function, remove previous checkboxes. add new ones
        public void Update()
        {
            //clears previous content
            ListofItems.Children.Clear();
            int hold = 0;
            //Populates List
            foreach (KeyValuePair<string,string> item in myGlobals.ListofObjects)
            {
                hold++;
                CheckBox AddNewList = new CheckBox();
                AddNewList.Content = item.Key + "                   " + item.Value;
                AddNewList.FontSize = 30;
                AddNewList.Name = hold.ToString();
                ListofItems.Children.Add(AddNewList);
            }
        }

    }
    }

