﻿#pragma checksum "..\..\..\Gui\AfficherEntrepriseRappel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B651C743546E8C0DA82BB15E3CB93C881DBF1E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace la_foire.Gui {
    
    
    /// <summary>
    /// AfficherEntrepriseRappel
    /// </summary>
    public partial class AfficherEntrepriseRappel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEntreprise;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBFiltres;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBFiltresent;
        
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
            System.Uri resourceLocater = new System.Uri("/la_foire;component/gui/afficherentrepriserappel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
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
            this.DataGridEntreprise = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
            this.DataGridEntreprise.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.DataGridEntreprise_MouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBFiltres = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.TBFiltresent = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\Gui\AfficherEntrepriseRappel.xaml"
            this.TBFiltresent.KeyUp += new System.Windows.Input.KeyEventHandler(this.TBFiltresent_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

