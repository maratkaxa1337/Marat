﻿#pragma checksum "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37173737F48E15DE5AA4E43C78B432FA04D6084CDE268F54752976289ED59AFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Marat.Views.Pages;
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


namespace Marat.Views.Pages {
    
    
    /// <summary>
    /// ApplicantsViewPage
    /// </summary>
    public partial class ApplicantsViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid viewApplicants;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBack;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonOpenToEdit;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonRemove;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker searchEmploymentDate;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/Marat;component/views/pages/applicantspages/applicantsviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
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
            
            #line 7 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            ((Marat.Views.Pages.ApplicantsViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewApplicants = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.buttonBack = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.buttonBack.Click += new System.Windows.RoutedEventHandler(this.buttonBack_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.buttonExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonOpenToEdit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.buttonOpenToEdit.Click += new System.Windows.RoutedEventHandler(this.buttonOpenToEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonRemove = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.buttonRemove.Click += new System.Windows.RoutedEventHandler(this.buttonRemove_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.searchEmploymentDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.buttonSearch = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\Views\Pages\ApplicantsPages\ApplicantsViewPage.xaml"
            this.buttonSearch.Click += new System.Windows.RoutedEventHandler(this.buttonSearch_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
