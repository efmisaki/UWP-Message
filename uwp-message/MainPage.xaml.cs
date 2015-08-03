using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.Diagnostics;
// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace uwp_message
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("本文(初期)","タイトル(初期)");
            msg.Title = "タイトル（変更後）";
            msg.Content = "本文(変更後)";
            msg.Commands.Add(new UICommand("選択1", new UICommandInvokedHandler(this.CommandInvokedHandler_select1)));
            msg.Commands.Add(new UICommand("選択2", new UICommandInvokedHandler(this.CommandInvokedHandler_select2)));

            msg.ShowAsync();   
        }


        private void CommandInvokedHandler_select1(IUICommand command)
        {
            Debug.WriteLine("[選択1]が選択されました。");
        }
        private void CommandInvokedHandler_select2(IUICommand command)
        {
            Debug.WriteLine("[選択2]が選択されました。");
        }
    }
}
