﻿#pragma checksum "..\..\NuevaCarrera.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "22A9D04CD535A3B9808112CD4FD33501"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace Proyecto_Avituallamientos {
    
    
    /// <summary>
    /// NuevaCarrera
    /// </summary>
    public partial class NuevaCarrera : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNombreCarrera;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNombreCarrera;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCarrera1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelAvituallamientos;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditarAvituallamientos;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NuevaCarrera.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNuevaCarrera;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto_Avituallamientos;component/nuevacarrera.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NuevaCarrera.xaml"
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
            this.LabelNombreCarrera = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TextBoxNombreCarrera = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LabelCarrera1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelAvituallamientos = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.EditarAvituallamientos = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\NuevaCarrera.xaml"
            this.EditarAvituallamientos.Click += new System.Windows.RoutedEventHandler(this.NuevoMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonNuevaCarrera = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

