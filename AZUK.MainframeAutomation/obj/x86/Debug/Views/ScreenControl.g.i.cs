﻿#pragma checksum "..\..\..\..\Views\ScreenControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "598F227BAD25F7893AB0C10D12865EE8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AZUK.MainframeAutomationRobot.Controls;
using AZUK.MainframeAutomationRobot.Helpers;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using Microsoft.Windows.Shell;
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
using System.Windows.Interactivity;
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


namespace AZUK.MainframeAutomationRobot.Views {
    
    
    /// <summary>
    /// ScreenControl
    /// </summary>
    public partial class ScreenControl : AZUK.MainframeAutomationRobot.Controls.ModernUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AZUK.MainframeAutomationRobot.Views.ScreenControl Screen;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtScreenName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtExitCommand;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbxRepeatable;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListCustomers;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\ScreenControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVScreenMapping;
        
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
            System.Uri resourceLocater = new System.Uri("/AZUK.MainframeAutomationRobot;component/views/screencontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ScreenControl.xaml"
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
            this.Screen = ((AZUK.MainframeAutomationRobot.Views.ScreenControl)(target));
            return;
            case 2:
            this.txtScreenName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtExitCommand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbxRepeatable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.ListCustomers = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.LVScreenMapping = ((System.Windows.Controls.ListView)(target));
            
            #line 99 "..\..\..\..\Views\ScreenControl.xaml"
            this.LVScreenMapping.TargetUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.listView_TargetUpdated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
