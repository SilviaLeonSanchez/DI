﻿#pragma checksum "..\..\..\interfaz\VentanaCarreras.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "57D3F47CE021A0E7841C59F9A704ACE8"
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


namespace Proyecto_Avituallamientos.interfaz {
    
    
    /// <summary>
    /// VentanaCarreras
    /// </summary>
    public partial class VentanaCarreras : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridCarreras;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAniadirCarrera;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEditarCarrera;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBorrarCarrera;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCarreras;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\interfaz\VentanaCarreras.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonVolver;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto_Avituallamientos;component/interfaz/ventanacarreras.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\interfaz\VentanaCarreras.xaml"
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
            this.DataGridCarreras = ((System.Windows.Controls.DataGrid)(target));
            
            #line 6 "..\..\..\interfaz\VentanaCarreras.xaml"
            this.DataGridCarreras.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataGridCarreras_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonAniadirCarrera = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\interfaz\VentanaCarreras.xaml"
            this.ButtonAniadirCarrera.Click += new System.Windows.RoutedEventHandler(this.ButtonAniadirCarrera_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonEditarCarrera = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\interfaz\VentanaCarreras.xaml"
            this.ButtonEditarCarrera.Click += new System.Windows.RoutedEventHandler(this.ButtonEditarCarrera_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonBorrarCarrera = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\interfaz\VentanaCarreras.xaml"
            this.ButtonBorrarCarrera.Click += new System.Windows.RoutedEventHandler(this.ButtonBorrarCarrera_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LabelCarreras = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ButtonVolver = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

