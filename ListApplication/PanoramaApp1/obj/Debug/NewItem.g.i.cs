﻿#pragma checksum "C:\Users\Joseph\Documents\GitHub\FirstWP8App\ListApplication\PanoramaApp1\NewItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "11D0143C6ADFC8F8078E26189F969BB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class WindowsPhoneControl1 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl AddNewItem;
        
        internal System.Windows.Controls.Primitives.Popup AddNewControl;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox ItemName;
        
        internal System.Windows.Controls.Button AcceptText;
        
        internal System.Windows.Controls.Button CancelText;
        
        internal System.Windows.Controls.TextBox Quantity;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PanoramaApp1;component/NewItem.xaml", System.UriKind.Relative));
            this.AddNewItem = ((System.Windows.Controls.UserControl)(this.FindName("AddNewItem")));
            this.AddNewControl = ((System.Windows.Controls.Primitives.Popup)(this.FindName("AddNewControl")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ItemName = ((System.Windows.Controls.TextBox)(this.FindName("ItemName")));
            this.AcceptText = ((System.Windows.Controls.Button)(this.FindName("AcceptText")));
            this.CancelText = ((System.Windows.Controls.Button)(this.FindName("CancelText")));
            this.Quantity = ((System.Windows.Controls.TextBox)(this.FindName("Quantity")));
        }
    }
}

