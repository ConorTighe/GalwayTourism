﻿#pragma checksum "C:\Users\Conor\Documents\Visual Studio 2015\Projects\GalwayTouristGuide\GalwayTouristGuide\Todo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE466AAB138555DBE80C5407A8A671B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GalwayTouristGuide
{
    partial class Todo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.UpdateBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\Todo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.UpdateBtn).Click += this.UpdateBtn_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.PlacesSeen = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
