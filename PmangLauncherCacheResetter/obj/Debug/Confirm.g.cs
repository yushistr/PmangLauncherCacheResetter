﻿#pragma checksum "..\..\Confirm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "772014BF7566881AC6F4040D570A8B56"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace PmangLauncherCacheResetter {
    
    
    /// <summary>
    /// Confirm
    /// </summary>
    public partial class Confirm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CacheList;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartCacheDelete;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteSetectedCache;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ListUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/PmangLauncherCacheResetter;component/confirm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Confirm.xaml"
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
            this.CacheList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.StartCacheDelete = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Confirm.xaml"
            this.StartCacheDelete.Click += new System.Windows.RoutedEventHandler(this.StartCacheDelete_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteSetectedCache = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Confirm.xaml"
            this.DeleteSetectedCache.Click += new System.Windows.RoutedEventHandler(this.DeleteSetectedCache_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Confirm.xaml"
            this.ListUpdate.Click += new System.Windows.RoutedEventHandler(this.ListUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 12 "..\..\Confirm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

