﻿#pragma checksum "..\..\PeliculaWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "069A904C6B2385737E118D3CB0BB427D972D7521D99ACE672EAF242DCC4BAC2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentacion;
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


namespace Presentacion {
    
    
    /// <summary>
    /// PeliculaWindow
    /// </summary>
    public partial class PeliculaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbGenero;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitulo;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDirector;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPais;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateFechaEstreno;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPelicula;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBuscarPorGenero;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarPorGenero;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOrdenarPorFechaEstreno;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOrdenarPorFechaEstreno;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PeliculaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbModificarCampos;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentacion;component/peliculawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PeliculaWindow.xaml"
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
            this.cbGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.txtTitulo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDirector = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbPais = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.dateFechaEstreno = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnRegistrar = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\PeliculaWindow.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\PeliculaWindow.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\PeliculaWindow.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\PeliculaWindow.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgPelicula = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\PeliculaWindow.xaml"
            this.dgPelicula.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgPelicula_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\PeliculaWindow.xaml"
            this.dgPelicula.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.dgPelicula_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cbBuscarPorGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.btnBuscarPorGenero = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\PeliculaWindow.xaml"
            this.btnBuscarPorGenero.Click += new System.Windows.RoutedEventHandler(this.btnBuscarPorGenero_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cbOrdenarPorFechaEstreno = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.btnOrdenarPorFechaEstreno = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\PeliculaWindow.xaml"
            this.btnOrdenarPorFechaEstreno.Click += new System.Windows.RoutedEventHandler(this.btnOrdenarPorFechaEstreno_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\PeliculaWindow.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.lbModificarCampos = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
