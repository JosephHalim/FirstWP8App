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
            var popup = new Popup();
            
      //  NewItem control = new AddNewControl();

            



        }
    }

}