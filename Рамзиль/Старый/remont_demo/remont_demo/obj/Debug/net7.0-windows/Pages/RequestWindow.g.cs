﻿#pragma checksum "..\..\..\..\Pages\RequestWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C78DB2628EB9BF66AF857453652AC609E46A948"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using remont_demo.Pages;


namespace remont_demo.Pages {
    
    
    /// <summary>
    /// RequestWindow
    /// </summary>
    public partial class RequestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userRoleLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userFioLabel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button breakButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRequestButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox serchTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\RequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/remont_demo;component/pages/requestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RequestWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.userRoleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.userFioLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.breakButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\RequestWindow.xaml"
            this.breakButton.Click += new System.Windows.RoutedEventHandler(this.breakButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\RequestWindow.xaml"
            this.addRequestButton.Click += new System.Windows.RoutedEventHandler(this.addRequestButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.serchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\Pages\RequestWindow.xaml"
            this.serchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.serchTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\Pages\RequestWindow.xaml"
            this.serchTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.serchTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.list = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 38 "..\..\..\..\Pages\RequestWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

