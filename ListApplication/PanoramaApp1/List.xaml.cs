using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        // Adds new item to the list
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
                // new ListObject(ProductName, NumberofUnits, group);
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
        private void HandleTap(object sender, RoutedEventArgs e)
        {
            TextBlock hold = new TextBlock();
            hold = (TextBlock)sender;
            string[] split = hold.Text.Split(' ');
            List<ListObject> handle = new List<ListObject>();
            foreach (KeyValuePair<string, List<ListObject>> list in myGlobals.ListofItems)
            {
                if (list.Key == split[0])
                {
                    handle = list.Value;
                    break;
                }
            }
            NavigationService.Navigate(new Uri("/NewItem.xaml", UriKind.Relative));
        }
    
        private void HandleEdit(object sender, EventArgs e)
        {
                MessageBox.Show("HandleEdit");
                var temp = sender;
                var datacontext = (StackPanel)sender;
                var text = ((ListObject)datacontext.DataContext);
                MessageBox.Show(text.InCart.ToString());
                        
        }
        private void Checked(object sender, RoutedEventArgs e)
        {
            var CartData = this.ListData.ItemsSource;
            int count = 0;
            var FoundName = "temp";
            var FoundGroup = "temp";
            // checks First List for changed value
            foreach (List<ListObject> temp in CartData)
            {
                do
                {
                    //finds if data is in FirstList
                    if (temp.Count > 0)
                    {
                        if (temp[count].InCart.ToString() == "True")
                        {
                            FoundName = temp[count].Name;
                            FoundGroup = temp[count].Group;
                            break;
                        }
                    }
                    else // if data is not found change itemsource
                    {
                        CartData = this.InsideCartData.ItemsSource;
                        count = -1;
                        break;
                    }
                    count++;
                } while (temp.Count > count);
                if (count == 0)
                {
                    CartData = this.InsideCartData.ItemsSource;
                    count = -1;
                }
            }
            // count = -1 to signify that no data exists in the first column
            if (count == -1)
            {
                count = 0;
                foreach (List<ListObject> temp in CartData)
                {
                    do
                    {
                        //finds if data is in FirstList
                        if (temp.Count > 0)
                        {
                            if (temp[count].InCart.ToString() == "False")
                            {
                                FoundName = temp[count].Name;
                                FoundGroup = temp[count].Group;
                                break;
                            }
                        }
                        else // if data is not found change itemsource
                        {
                            count = -1;
                        }
                        count++;
                    } while (temp.Count > count);
                }
            }
            count = 0;
            UpdateListData(FoundGroup, FoundName);
            Update();
        }
        //Searches for data inside of the list, and changes value from True -> False, or False -> True
        private void UpdateListData(string Group, string Name)
        {
            //check if temp[0].Group = selected
            // separates data into two lists
            var has = myGlobals.ListofItemsinList.Find(ListObject => ListObject.Group == Group && ListObject.Name == Name);
            var t3 = myGlobals.ListofItemsinList.FindIndex(ListObject => ListObject.Group == Group && ListObject.Name == Name);
            // Updates existing data to show the change between lists.
            if (has.InCart == false)
            {
                ListObject holdlist = new ListObject(has.Name, has.Quantity, has.Group, true);
                myGlobals.ListofItemsinList[t3] = holdlist;
            }
            else
            {
                ListObject holdlist = new ListObject(has.Name, has.Quantity, has.Group, false);
                myGlobals.ListofItemsinList[t3] = holdlist;
            }
        }
        //run an update function, remove previous checkboxes. add new ones
        public void Update()
        {
            popup.IsOpen = false;
            List<ListObject> NotInCart = new List<ListObject>();
            List<ListObject> InsideCart = new List<ListObject>();
            // removes pairs from global list
            foreach (KeyValuePair<string, List<ListObject>> list in myGlobals.ListofItems)
            {
                if (list.Key == myGlobals.CurrentList)
                {
                    myGlobals.ListofItemsinList = list.Value;
                    break;
                }
                else { }
            }
            //Moves data to two different lists, based on value.InCart Data
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
            //Convert Key Groups into ItemSource and updates layout
            List<AlphaKeyGroup<ListObject>> DataSource = AlphaKeyGroup<ListObject>.CreateGroups(NotInCart, (ListObject s) => { return s.GroupList; }, true);
            ListData.ItemsSource = DataSource;
        //    this.ComboBox1.SelectedIndexChanged +=  new System.EventHandler(ComboBox1_SelectedIndexChanged); 
     //      ListData.SelectionChanged += new SelectionChangedEventHandler(HandleEdit);
            
            ListData.UpdateLayout();
          
           
            List<AlphaKeyGroup<ListObject>> InsideCartSource = AlphaKeyGroup<ListObject>.CreateGroups(InsideCart, (ListObject s) => { return s.GroupList; }, true);
            InsideCartData.ItemsSource = InsideCartSource;
            InsideCartData.UpdateLayout();
        }
    }
}