using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PanoramaApp1
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }



        public  void Add_New_List(Object sender, EventArgs e)
        {
            
            string hold = txbNewList.Text;
           myGlobals.ListofItems.Add(hold);
           NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));
          
        }

  
    }
}