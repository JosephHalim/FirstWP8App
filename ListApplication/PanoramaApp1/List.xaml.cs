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
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

            ListofItems.Children.Clear();
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
                    string group = control.Category.Text.ToString();
                    //ListObject Item = new ListObject(ProductName, NumberofUnits, group);
                  //  new ListObject(ProductName, NumberofUnits, group);
                    
                    myGlobals.ListofItemsinList.Add(new ListObject(ProductName, NumberofUnits, group)); 
                    myGlobals.ListofItems[myGlobals.CurrentList] = myGlobals.ListofItemsinList;
                  
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
          //checks if popup is up, if it is, cancel the popup windows
            if (popup.IsOpen == true)
            {
                popup.IsOpen = false;
                e.Cancel = true;
            }
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
            
            popup.IsOpen = false;

            //clears previous content
           ListofItems.Children.Clear();
            TextColumn.Children.Clear();
            CheckboxColumn.Children.Clear();
           
            foreach (KeyValuePair<string, List<object>> list in myGlobals.ListofItems)
            {
                if (list.Key == myGlobals.CurrentList)
                {
                    myGlobals.ListofItemsinList = list.Value;
                    break;
                }
                else
                {
                  
                }
            }
          
            int hold = 0;
            object hold2 = myGlobals.ListofItemsinList;


         //   foreach (ListObject list in value)
            //Populates List
            if (myGlobals.ListofItemsinList == null)
            {
                
                myGlobals.ListofItemsinList.Add("text");
            }
            else
            {
             
               // foreach (ListObject list in myGlobals.ListofItemsinList)
                    foreach(ListObject list in myGlobals.ListofItemsinList)
                {

                    hold++;
                    CheckBox AddNewList = new CheckBox();
                    object text = (object)list;
                    TextBlock Content = new TextBlock();
                    Content.Text = (list.NameofItem + "                   " + list.NumberofItems);
                    AddNewList.FontSize = 30;
                    Content.FontSize = 30;
                    AddNewList.Name = hold.ToString();
                    Content.Margin = new Thickness(15);

                    Content.Tap += new EventHandler<System.Windows.Input.GestureEventArgs>(HandleTap);

                    //ListofItems.Children.Add(AddNewList);
                    ListofItems.ShowGridLines = true;
                    //   ListofItems.Children.Add(Content);
                    TextColumn.Children.Add(Content);
                    CheckboxColumn.Children.Add(AddNewList);

                }
                ListofItems.Children.Add(TextColumn);
                ListofItems.Children.Add(CheckboxColumn);
            }

             
        }
        private void HandleTap(object sender, RoutedEventArgs e)
        {

            TextBlock hold = new TextBlock();
            hold = (TextBlock)sender;
            string[] split = hold.Text.Split(' ');
            

            MessageBox.Show(split[0]);
        }

    }
    }

