﻿#pragma checksum "C:\Users\Joseph\Documents\GitHub\FirstWP8App\ListApplication\PanoramaApp1\List.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0532B897132C95D151778BF43B8A36C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PanoramaApp1 {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PivotItem ListHeader;
        
        internal Microsoft.Phone.Controls.LongListSelector ListData;
        
        internal Microsoft.Phone.Controls.LongListSelector InsideCartData;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PanoramaApp1;component/List.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ListHeader = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("ListHeader")));
            this.ListData = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ListData")));
            this.InsideCartData = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("InsideCartData")));
        }
    }
}

