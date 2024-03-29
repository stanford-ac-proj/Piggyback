﻿#pragma checksum "..\..\browserform.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22C12E2F2AB4C4B140090B9192264D4AF964E9155E73F8B19B8B9D763F67D7E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ControlLib;
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


namespace ActivityBrowser {
    
    
    /// <summary>
    /// BrowserForm
    /// </summary>
    public partial class BrowserForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ThemeMenu;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem activateMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem manualActivateMenu;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem beatMenu;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem offBeatMenuItem;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem aboutMenu;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem manualMenu;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gridSplitter1;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPanel;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ControlLib.Accordion ActivityPanel;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl1;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem InstructionTab;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DocumentViewer InstructionViewer;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem ActivityTab;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ActivityGrid;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem RecordingTab;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\browserform.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DocumentViewer RecordingViewer;
        
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
            System.Uri resourceLocater = new System.Uri("/Piggyback3;component/browserform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\browserform.xaml"
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
            
            #line 5 "..\..\browserform.xaml"
            ((ActivityBrowser.BrowserForm)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 5 "..\..\browserform.xaml"
            ((ActivityBrowser.BrowserForm)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Window_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ThemeMenu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            
            #line 24 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 29 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 30 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 31 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 32 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemeItem_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.activateMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\browserform.xaml"
            this.activateMenu.Click += new System.Windows.RoutedEventHandler(this.ActivateItem_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.manualActivateMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\browserform.xaml"
            this.manualActivateMenu.Click += new System.Windows.RoutedEventHandler(this.ActivateItem_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 45 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitItem_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.beatMenu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 15:
            this.offBeatMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 48 "..\..\browserform.xaml"
            this.offBeatMenuItem.Click += new System.Windows.RoutedEventHandler(this.beatMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 49 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.beatMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 50 "..\..\browserform.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.beatMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.aboutMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\browserform.xaml"
            this.aboutMenu.Click += new System.Windows.RoutedEventHandler(this.aboutMenu_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.manualMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 54 "..\..\browserform.xaml"
            this.manualMenu.Click += new System.Windows.RoutedEventHandler(this.manualMenu_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.gridSplitter1 = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 21:
            this.dockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 22:
            this.ActivityPanel = ((ControlLib.Accordion)(target));
            return;
            case 23:
            this.tabControl1 = ((System.Windows.Controls.TabControl)(target));
            return;
            case 24:
            this.InstructionTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 25:
            this.InstructionViewer = ((System.Windows.Controls.DocumentViewer)(target));
            return;
            case 26:
            this.ActivityTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 27:
            this.ActivityGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 28:
            this.RecordingTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 29:
            this.RecordingViewer = ((System.Windows.Controls.DocumentViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

