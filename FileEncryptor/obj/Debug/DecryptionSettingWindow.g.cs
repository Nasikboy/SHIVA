﻿#pragma checksum "..\..\DecryptionSettingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0DCE220E3E8E38D023399A2FC1F8518E1DBA94324841D0FD74CE362965B9DFD0"
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


namespace FileEncryptor {
    
    
    /// <summary>
    /// DecryptionSettingWindow
    /// </summary>
    public partial class DecryptionSettingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\DecryptionSettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_descryptKey;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\DecryptionSettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_manifestPath;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\DecryptionSettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_selManifest;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\DecryptionSettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_importDescryptKey;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DecryptionSettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_OK;
        
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
            System.Uri resourceLocater = new System.Uri("/SHIFA;component/decryptionsettingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DecryptionSettingWindow.xaml"
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
            this.tb_descryptKey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_manifestPath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.bt_selManifest = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\DecryptionSettingWindow.xaml"
            this.bt_selManifest.Click += new System.Windows.RoutedEventHandler(this.Bt_selManifest_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_importDescryptKey = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\DecryptionSettingWindow.xaml"
            this.bt_importDescryptKey.Click += new System.Windows.RoutedEventHandler(this.Bt_importDescryptKey_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_OK = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\DecryptionSettingWindow.xaml"
            this.bt_OK.Click += new System.Windows.RoutedEventHandler(this.Bt_OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

