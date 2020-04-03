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
using Windows.UI;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Chameleon
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class OpacityPage : Page
    {
        private Color myColor;

        public OpacityPage()
        {
            this.InitializeComponent();

            myColor = Color.FromArgb(245, 0x1B, 0x19, 0x19);
            SolidColorBrush myColorBrush1 = new SolidColorBrush(myColor);
            Border1.Background = myColorBrush1;

            myColor = Color.FromArgb(227, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush2 = new SolidColorBrush(myColor);
            Border2.Background = myColorBrush2;

            myColor = Color.FromArgb(199, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush3 = new SolidColorBrush(myColor);
            Border3.Background = myColorBrush3;

            myColor = Color.FromArgb(171, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush4 = new SolidColorBrush(myColor);
            Border4.Background = myColorBrush4;

            myColor = Color.FromArgb(143, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush5 = new SolidColorBrush(myColor);
            Border5.Background = myColorBrush5;

            myColor = Color.FromArgb(115, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush6 = new SolidColorBrush(myColor);
            Border6.Background = myColorBrush6;

            myColor = Color.FromArgb(87, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush7 = new SolidColorBrush(myColor);
            Border7.Background = myColorBrush7;

            myColor = Color.FromArgb(59, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush8 = new SolidColorBrush(myColor);
            Border8.Background = myColorBrush8;

            myColor = Color.FromArgb(31, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush9 = new SolidColorBrush(myColor);
            Border9.Background = myColorBrush9;
        }

        private void confirmColor_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush myColorBrush000 = new SolidColorBrush(Colors.Black);
            TextBlock2.Foreground = myColorBrush000;
            TextBlock3.Foreground = myColorBrush000;
            TextBlock4.Foreground = myColorBrush000;
            TextBlock5.Foreground = myColorBrush000;
            TextBlock6.Foreground = myColorBrush000;
            TextBlock7.Foreground = myColorBrush000;
            TextBlock8.Foreground = myColorBrush000;
            TextBlock9.Foreground = myColorBrush000;

            myColor = myColorPicker.Color;
            SolidColorBrush myColorBrush1 = new SolidColorBrush(myColor);
            Border1.Background = myColorBrush1;
            string hex;

            myColor = Color.FromArgb(227, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush2 = new SolidColorBrush(myColor);
            Border2.Background = myColorBrush2;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock2.Text = hex;

            myColor = Color.FromArgb(199, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush3 = new SolidColorBrush(myColor);
            Border3.Background = myColorBrush3;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock3.Text = hex;

            myColor = Color.FromArgb(171, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush4 = new SolidColorBrush(myColor);
            Border4.Background = myColorBrush4;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock4.Text = hex;

            myColor = Color.FromArgb(143, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush5 = new SolidColorBrush(myColor);
            Border5.Background = myColorBrush5;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock5.Text = hex;

            myColor = Color.FromArgb(115, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush6 = new SolidColorBrush(myColor);
            Border6.Background = myColorBrush6;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock6.Text = hex;

            myColor = Color.FromArgb(87, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush7 = new SolidColorBrush(myColor);
            Border7.Background = myColorBrush7;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock7.Text = hex;

            myColor = Color.FromArgb(59, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush8 = new SolidColorBrush(myColor);
            Border8.Background = myColorBrush8;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock8.Text = hex;

            myColor = Color.FromArgb(31, myColor.R, myColor.G, myColor.B);
            SolidColorBrush myColorBrush9 = new SolidColorBrush(myColor);
            Border9.Background = myColorBrush9;
            hex = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock9.Text = hex;
        }

    }
}

