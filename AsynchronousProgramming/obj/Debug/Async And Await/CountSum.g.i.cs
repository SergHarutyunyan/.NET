﻿#pragma checksum "..\..\..\Async And Await\CountSum.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AA7B12E480CB4930010A835B8D56F00A15BF2CC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainWindow.Async_And_Await;
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


namespace MainWindow.Async_And_Await {
    
    
    /// <summary>
    /// CountSum
    /// </summary>
    public partial class CountSum : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Async And Await\CountSum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sync;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Async And Await\CountSum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Async;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Async And Await\CountSum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Threaded;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Async And Await\CountSum.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt;
        
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
            System.Uri resourceLocater = new System.Uri("/MainWindow;component/async%20and%20await/countsum.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Async And Await\CountSum.xaml"
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
            this.Sync = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Async And Await\CountSum.xaml"
            this.Sync.Click += new System.Windows.RoutedEventHandler(this.Sync_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Async = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Async And Await\CountSum.xaml"
            this.Async.Click += new System.Windows.RoutedEventHandler(this.Async_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Threaded = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Async And Await\CountSum.xaml"
            this.Threaded.Click += new System.Windows.RoutedEventHandler(this.Threaded_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Txt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

