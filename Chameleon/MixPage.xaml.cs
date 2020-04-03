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
using System.Globalization;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Chameleon
{
    public class Mix
    {
        private Color myColor1;
        private Color myColor2;
        private Color myColor3;
        private string hex;
        public Mix()
        {
            myColor1 = Color.FromArgb(255, 0x00, 0x00, 0x00); ;
            myColor2 = Color.FromArgb(255, 0x00, 0x00, 0x00); ;
            myColor3 = Color.FromArgb(255, 0x00, 0x00, 0x00); ;
            hex = "#FFFFFFFF";
        }
        public string do_mix()
        {
            Color myColor1 = Color.FromArgb(255, 0x34, 0x56, 0x34); ;
            Color myColor2 = Color.FromArgb(255, 0x10, 0x34, 0x46); ;
            byte R_3 = (byte)((myColor1.R + myColor2.R) / 2);
            byte G_3 = (byte)((myColor1.G + myColor2.G) / 2);
            byte B_3 = (byte)((myColor1.B + myColor2.B) / 2);
            myColor3 = Color.FromArgb(255, R_3, G_3, B_3);
            return hex = '#' + myColor2.A.ToString("X2") + myColor2.R.ToString("X2") + myColor2.G.ToString("X2") + myColor2.B.ToString("X2");
        }
    }
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MixPage : Page
    {
        private Color myColor1;
        private Color myColor2;
        private Color myColor3;
        int count1 = 0;
        int count2 = 0;
        string hex;
        public MixPage()
        {
            this.InitializeComponent();
        }

        private void confirmColor_Click1(object sender, RoutedEventArgs e)
        {
            if (count1 == 0)
                myColor1 = Color.FromArgb(255, 0x00, 0x00, 0x00);
            if (count2 == 0)
                myColor2 = Color.FromArgb(255, 0xFF, 0xFF, 0xFF);
            count1++;

            myColor1 = myColorPicker.Color;
            SolidColorBrush myColorBrush1 = new SolidColorBrush(myColor1);
            Border2.Background = myColorBrush1;

            hex = '#' + myColor1.A.ToString("X2") + myColor1.R.ToString("X2") + myColor1.G.ToString("X2") + myColor1.B.ToString("X2");
            TextBlock2.Text = hex;

            //Адитивное ("работает" при световом смешивании лучей, в некоторых графических программах):
            byte R_3 = (byte)((myColor1.R + myColor2.R) / 2);
            byte G_3 = (byte)((myColor1.G + myColor2.G) / 2);
            byte B_3 = (byte)((myColor1.B + myColor2.B) / 2);
            myColor3 = Color.FromArgb(255, R_3, G_3, B_3);
            SolidColorBrush myColorBrush3 = new SolidColorBrush(myColor3);
            Border6.Background = myColorBrush3;

            hex = '#' + myColor3.A.ToString("X2") + myColor3.R.ToString("X2") + myColor3.G.ToString("X2") + myColor3.B.ToString("X2");
            TextBlock5.Text = hex;
        }

        private void confirmColor_Click2(object sender, RoutedEventArgs e)
        {
            if (count1 == 0)
                myColor1 = Color.FromArgb(255, 0x00, 0x00, 0x00);
            if (count2 == 0)
                myColor2 = Color.FromArgb(255, 0xFF, 0xFF, 0xFF);
            count2++;

            myColor2 = myColorPicker.Color;
            SolidColorBrush myColorBrush2 = new SolidColorBrush(myColor2);
            Border4.Background = myColorBrush2;

            hex = '#' + myColor2.A.ToString("X2") + myColor2.R.ToString("X2") + myColor2.G.ToString("X2") + myColor2.B.ToString("X2");
            TextBlock3.Text = hex;

            //Адитивное:
            byte R_3 = (byte)((myColor1.R + myColor2.R) / 2);
            byte G_3 = (byte)((myColor1.G + myColor2.G) / 2);
            byte B_3 = (byte)((myColor1.B + myColor2.B) / 2);
            myColor3 = Color.FromArgb(255, R_3, G_3, B_3);
            SolidColorBrush myColorBrush3 = new SolidColorBrush(myColor3);
            Border6.Background = myColorBrush3;

            hex = '#' + myColor3.A.ToString("X2") + myColor3.R.ToString("X2") + myColor3.G.ToString("X2") + myColor3.B.ToString("X2");
            TextBlock5.Text = hex;
        }
    }
}
