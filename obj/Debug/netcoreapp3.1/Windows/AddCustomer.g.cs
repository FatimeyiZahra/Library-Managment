﻿#pragma checksum "..\..\..\..\Windows\AddCustomer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1476B942E63FFD218FF65C057C3B9A6E723748E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Managment.Windows;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Library_Managment.Windows {
    
    
    /// <summary>
    /// AddCustomer
    /// </summary>
    public partial class AddCustomer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCusername;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCsurname;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCphone;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCemail;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addCustomers;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editCustomer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteCustomer;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\AddCustomer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdCustomer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library Managment;component/windows/addcustomer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddCustomer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TxtCusername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtCsurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtCphone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtCemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.addCustomers = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Windows\AddCustomer.xaml"
            this.addCustomers.Click += new System.Windows.RoutedEventHandler(this.addCustomers_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Windows\AddCustomer.xaml"
            this.editCustomer.Click += new System.Windows.RoutedEventHandler(this.editCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deleteCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Windows\AddCustomer.xaml"
            this.deleteCustomer.Click += new System.Windows.RoutedEventHandler(this.deleteCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grdCustomer = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\..\Windows\AddCustomer.xaml"
            this.grdCustomer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grdCustomer_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

