﻿#pragma checksum "..\..\..\..\Windows\RequestAddDialogs.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A5AEE1CF052F7D427CD63EC5546F071346178BD"
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
using technoServise.Dialogs;


namespace technoServise.Dialogs {
    
    
    /// <summary>
    /// RequestAddDialogs
    /// </summary>
    public partial class RequestAddDialogs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeFayltComboBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox equipmentTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clientsComboBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock selectButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink addClientButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddRequest;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\RequestAddDialogs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/technoService;component/windows/requestadddialogs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\RequestAddDialogs.xaml"
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
            this.typeFayltComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.equipmentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.clientsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.selectButton = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.addClientButton = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 33 "..\..\..\..\Windows\RequestAddDialogs.xaml"
            this.addClientButton.Click += new System.Windows.RoutedEventHandler(this.addClient_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonAddRequest = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Windows\RequestAddDialogs.xaml"
            this.buttonAddRequest.Click += new System.Windows.RoutedEventHandler(this.buttonAddRequest_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Windows\RequestAddDialogs.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.exitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

