// Updated by XamlIntelliSenseFileGenerator 23.06.2022 22:29:56
#pragma checksum "..\..\..\StartWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EF0B8F7CD4DADF13B2659F721D27D18527525AD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimpleTesting;
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


namespace SimpleTesting
{


    /// <summary>
    /// StartWindow
    /// </summary>
    public partial class StartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 19 "..\..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registerButton;

#line default
#line hidden


#line 29 "..\..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logInButton;

#line default
#line hidden


#line 39 "..\..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox namesComboBox;

#line default
#line hidden


#line 49 "..\..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button takeTestButton;

#line default
#line hidden


#line 62 "..\..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SimpleTesting;component/startwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\StartWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.StartWindowInstance = ((SimpleTesting.StartWindow)(target));

#line 11 "..\..\..\StartWindow.xaml"
                    this.StartWindowInstance.Loaded += new System.Windows.RoutedEventHandler(this.StartWindowLoaded);

#line default
#line hidden
                    return;
                case 2:
                    this.registerButton = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\..\StartWindow.xaml"
                    this.registerButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButtonClick);

#line default
#line hidden
                    return;
                case 3:
                    this.logInButton = ((System.Windows.Controls.Button)(target));

#line 29 "..\..\..\StartWindow.xaml"
                    this.logInButton.Click += new System.Windows.RoutedEventHandler(this.LogInButtonClick);

#line default
#line hidden
                    return;
                case 4:
                    this.namesComboBox = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.takeTestButton = ((System.Windows.Controls.Button)(target));

#line 49 "..\..\..\StartWindow.xaml"
                    this.takeTestButton.Click += new System.Windows.RoutedEventHandler(this.TakeTestButtonClick);

#line default
#line hidden
                    return;
                case 6:
                    this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window window;
    }
}

