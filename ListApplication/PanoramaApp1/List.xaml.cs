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

            ListHeader.Header = myGlobals.CurrentList;
            Update();
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

            //ListofItems.Children.Clear();
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
                    bool incart = false;
                    //ListObject Item = new ListObject(ProductName, NumberofUnits, group);
                    //  new ListObject(ProductName, NumberofUnits, group);

                    myGlobals.ListofItemsinList.Add(new ListObject(ProductName, NumberofUnits, group, incart));
                    myGlobals.ListofItems[myGlobals.CurrentList] = myGlobals.ListofItemsinList;

                    popup.IsOpen = false;
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
            List<ListObject> NotInCart = new List<ListObject>();
            List<ListObject> InsideCart = new List<ListObject>();
            foreach (KeyValuePair<string, List<object>> list in myGlobals.ListofItems)
            {
                if (list.Key == myGlobals.CurrentList)
                {
                    myGlobals.ListofItemsinList = list.Value;
                    break;
                }
                else { }
            }
            foreach (ListObject value in myGlobals.ListofItemsinList)
            {
                if (value.InCart == false)
                {
                    NotInCart.Add(new ListObject(value.NameofItem, value.NumberofItems, value.GroupList, value.InCart));
                }
                else
                {
                    InsideCart.Add(new ListObject(value.NameofItem, value.NameofItem, value.GroupList, value.InCart));

                }
            }

            List<AlphaKeyGroup<ListObject>> DataSource = AlphaKeyGroup<ListObject>.CreateGroups(NotInCart, (ListObject s) => { return s.GroupList; }, true);
            ListData.ItemsSource = DataSource;
            List<AlphaKeyGroup<ListObject>> InsideCartSource = AlphaKeyGroup<ListObject>.CreateGroups(InsideCart, (ListObject s) => { return s.GroupList; }, true);
            InsideCartData.ItemsSource = InsideCartSource;

        }
        private void HandleTap(object sender, RoutedEventArgs e)
        {

            TextBlock hold = new TextBlock();
            hold = (TextBlock)sender;
            string[] split = hold.Text.Split(' ');
            List<object> handle = new List<object>();
            foreach (KeyValuePair<string, List<object>> list in myGlobals.ListofItems)
            {
                if (list.Key == split[0])
                {
                    handle = list.Value;
                    break;
                }
            }
            NavigationService.Navigate(new Uri("/NewItem.xaml", UriKind.Relative));
        }
        private void HandleEdit(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("HandleEdit");
        }
        private void Checked(object sender, RoutedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked == true)
            {
                MessageBox.Show("checked");

                object hold = this.ListData.ItemsSource;
                
            }
            else
            {
                MessageBox.Show("Not Checked");
            }
        }
    }
}

