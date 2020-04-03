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
using Windows.UI.ViewManagement;

namespace Chameleon
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            var bounds = ApplicationView.GetForCurrentView().VisibleBounds;

            ApplicationView.PreferredLaunchViewSize = new Size(bounds.Width, bounds.Height);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            // установка заголовка
            appView.Title = "Хамелеон";
            // получаем ссылку на TitleBar
            Windows.UI.ViewManagement.ApplicationViewTitleBar titleBar = appView.TitleBar;
            // установка цвета панели
            titleBar.BackgroundColor = Windows.UI.Colors.Black;
            titleBar.ButtonBackgroundColor = Windows.UI.Colors.Black;
            //устанавливает предпочтительные границы для окна приложения
            //appView.SetDesiredBoundsMode();
        }
        #region NavigationView event handlers
        private void nvTopLevelNav_Loaded(object sender, RoutedEventArgs e)
        {
            // set the initial SelectedItem
            foreach (NavigationViewItemBase item in nvTopLevelNav.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "Home_Page")
                {
                    nvTopLevelNav.SelectedItem = item;
                    break;
                }
            }
            contentFrame.Navigate(typeof(HomePage));
        }

        private void nvTopLevelNav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
        }

        private void nvTopLevelNav_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            TextBlock ItemContent = args.InvokedItem as TextBlock;
            if (ItemContent != null)
            {
                switch (ItemContent.Tag)
                {
                    case "Nav_Home":
                        contentFrame.Navigate(typeof(HomePage));
                        break;

                    case "Nav_Mix":
                        contentFrame.Navigate(typeof(MixPage));
                        break;

                    case "Nav_Combination":
                        contentFrame.Navigate(typeof(CombinationPage));
                        break;

                    case "Nav_Opposite":
                        contentFrame.Navigate(typeof(OppositePage));
                        break;

                    case "Nav_Opacity":
                        contentFrame.Navigate(typeof(OpacityPage));
                        break;
                }
            }
        }
        #endregion
    }
}
