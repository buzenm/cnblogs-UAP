﻿

#pragma checksum "E:\wp\CNBlogs\CNBlogs.Windows\Pages\BestBloggersPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "33284489E7992D4757195EDEA381E2C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNBlogs.Pages
{
    partial class BestBloggersPage : global::CNBlogs.FlatNavigationPage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.FlatNavigationPage pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.PageTitleControl TitleControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView gv_Bloggers; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_Refresh; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Pages/BestBloggersPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::CNBlogs.FlatNavigationPage)this.FindName("pageRoot");
            TitleControl = (global::CNBlogs.PageTitleControl)this.FindName("TitleControl");
            gv_Bloggers = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("gv_Bloggers");
            btn_Refresh = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_Refresh");
        }
    }
}


