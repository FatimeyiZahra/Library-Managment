﻿#pragma checksum "..\..\..\..\Windows\AddUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5FB716195B66EEC91B81082FF1B8915126A23F7D"
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
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdAddUser;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUserName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUserPassword;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUserBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editUser;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteUser;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdUser;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addUser;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Managment;component/windows/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddUser.xaml"
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
            this.grdAddUser = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TxtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtUserPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Windows\AddUser.xaml"
            this.addUserBtn.Click += new System.Windows.RoutedEventHandler(this.addCustomers_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editUser = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Windows\AddUser.xaml"
            this.editUser.Click += new System.Windows.RoutedEventHandler(this.editUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Windows\AddUser.xaml"
            this.deleteUser.Click += new System.Windows.RoutedEventHandler(this.deleteUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.grdUser = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\..\Windows\AddUser.xaml"
            this.grdUser.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grdUser_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addUser = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Windows\AddUser.xaml"
            this.addUser.Click += new System.Windows.RoutedEventHandler(this.addUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

