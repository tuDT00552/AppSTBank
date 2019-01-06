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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace STBankApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            appView.Title = "Ngân Hàng STBank";
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Home));
            titleApp.Text = "Xin Chào Quý Khách Đào Tuấn Tú";
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            switch (panel.Tag)
            {
                case "Home":
                    MainFrame.Navigate(typeof(Home));
                    titleApp.Text = "Trang Chủ";
                    break;
                case "Account":
                    MainFrame.Navigate(typeof(Account));
                    titleApp.Text = "Thông Tin Tài Khoản";
                    break;
                case "Transfers":
                    MainFrame.Navigate(typeof(Transfers));
                    titleApp.Text = "Chuyển Tiền";
                    break;
                case "History":
                    MainFrame.Navigate(typeof(History));
                    titleApp.Text = "Lịch Sử Giao Dịch";
                    break;
            }
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FontIcon fontIcon = sender as FontIcon;
            switch (fontIcon.Tag)
            {
                case "Logout":
                    Frame.Navigate(typeof(LoginScreen), null);
                    break;
            }
        }
    }
}
