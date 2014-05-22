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
using System.ComponentModel;



namespace PanoramaApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        Popup popup = new Popup();
        
        
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
<<<<<<< HEAD
           
            //Update List Title and populate list
          Title.Text = myGlobals.CurrentList.ToString();
            
=======
            //Update List Title and populate list
            Title.Text = myGlobals.CurrentList;
>>>>>>> f3fc2ea63f5f2d520b61491b3bfae68ad9882df9
            Update();
          }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            

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
        protected override void OnBackKeyPress(CancelEventArgs e)
        {
           /* if (popup.IsOpen == true)
            {
                popup.IsOpen = false;
               // myGlobals.popuptext = true;
              
            }
            else
            { return; }
            */}

        private void DeleteList(object sender, EventArgs e)
        {

        }
        private void SortData(object sender, EventArgs e)
        {

        }

        //run an update function, remove previous checkboxes. add new ones
        public void Update()
        {
<<<<<<< HEAD
            popup.IsOpen = false;
=======
>>>>>>> f3fc2ea63f5f2d520b61491b3bfae68ad9882df9
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

