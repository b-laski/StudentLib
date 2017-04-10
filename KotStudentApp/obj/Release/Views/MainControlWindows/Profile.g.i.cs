﻿#pragma checksum "..\..\..\..\Views\MainControlWindows\Profile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F460B753C2EB0291DA75A092541D9C88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KotStudentApp.ViewModels;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace KotStudentApp.ViewModels {
    
    
    /// <summary>
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Viewbox viewBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock firstNameProfil;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemProfil;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemMessage;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemSettings;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemLogout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KotStudentApp;component/views/maincontrolwindows/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imageBox = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.viewBox = ((System.Windows.Controls.Viewbox)(target));
            return;
            case 3:
            this.firstNameProfil = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.itemProfil = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
            this.itemProfil.Click += new System.Windows.RoutedEventHandler(this.itemProfil_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.itemMessage = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
            this.itemMessage.Click += new System.Windows.RoutedEventHandler(this.itemMessage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.itemSettings = ((System.Windows.Controls.MenuItem)(target));
            
            #line 43 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
            this.itemSettings.Click += new System.Windows.RoutedEventHandler(this.itemSettings_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.itemLogout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 48 "..\..\..\..\Views\MainControlWindows\Profile.xaml"
            this.itemLogout.Click += new System.Windows.RoutedEventHandler(this.itemLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

