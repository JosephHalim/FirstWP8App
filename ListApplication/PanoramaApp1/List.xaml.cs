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
using Coding4Fun.Toolkit.Controls;
using System.Windows.Input;
using Windows.UI.Popups;


namespace PanoramaApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Title.Text = myGlobals.CurrentList;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }



        void Add_New_Item(object sender, EventArgs e)
        {
            Popup popup = new Popup();
            WindowsPhoneControl1 control = new WindowsPhoneControl1();
            popup.Child = control;
            popup.IsOpen = true;
        }
        private void DeleteList(object sender, EventArgs e)
        {

        }
        private void SortData(object sender, EventArgs e)
        {

        }






      
    }
    }

