﻿#pragma checksum "C:\Chameleon\Chameleon\OppositePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7DE7665AAFD8DDE22C3E389E39BA450"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chameleon
{
    partial class OppositePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // OppositePage.xaml line 38
                {
                    this.myColorPicker = (global::Windows.UI.Xaml.Controls.ColorPicker)(target);
                }
                break;
            case 3: // OppositePage.xaml line 51
                {
                    this.Up = (global::Windows.UI.Xaml.Shapes.Polygon)(target);
                }
                break;
            case 4: // OppositePage.xaml line 59
                {
                    this.TextBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // OppositePage.xaml line 74
                {
                    this.TextBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // OppositePage.xaml line 89
                {
                    this.Down = (global::Windows.UI.Xaml.Shapes.Polygon)(target);
                }
                break;
            case 7: // OppositePage.xaml line 98
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.confirmColor_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

