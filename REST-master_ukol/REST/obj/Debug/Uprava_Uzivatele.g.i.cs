﻿#pragma checksum "..\..\Uprava_Uzivatele.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "78D57B49DE71093C18EE77778FDF655E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using REST;
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


namespace REST {
    
    
    /// <summary>
    /// Uprava_Uzivatele
    /// </summary>
    public partial class Uprava_Uzivatele : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label id;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox jmeno;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prijmeni;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox rod_cislo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dat_nar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pohlavi;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ulozit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Uprava_Uzivatele.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button smazat;
        
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
            System.Uri resourceLocater = new System.Uri("/REST;component/uprava_uzivatele.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Uprava_Uzivatele.xaml"
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
            this.id = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.jmeno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.prijmeni = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rod_cislo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dat_nar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.pohlavi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ulozit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Uprava_Uzivatele.xaml"
            this.ulozit.Click += new System.Windows.RoutedEventHandler(this.ulozit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.smazat = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Uprava_Uzivatele.xaml"
            this.smazat.Click += new System.Windows.RoutedEventHandler(this.smazat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
