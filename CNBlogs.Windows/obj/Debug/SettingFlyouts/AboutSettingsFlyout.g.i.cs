﻿

#pragma checksum "E:\GitHub\cnblogs-UAP\CNBlogs.Windows\SettingFlyouts\AboutSettingsFlyout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F18783D5E3EE986CFDBAE99D99321489"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNBlogs
{
    partial class AboutSettingsFlyout : global::Windows.UI.Xaml.Controls.SettingsFlyout
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard sb_LogoMoveUp; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Image image_Logo; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.StackPanel sp_aboutContent; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock tbkVersion; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///SettingFlyouts/AboutSettingsFlyout.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            sb_LogoMoveUp = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("sb_LogoMoveUp");
            image_Logo = (global::Windows.UI.Xaml.Controls.Image)this.FindName("image_Logo");
            sp_aboutContent = (global::Windows.UI.Xaml.Controls.StackPanel)this.FindName("sp_aboutContent");
            tbkVersion = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("tbkVersion");
        }
    }
}



