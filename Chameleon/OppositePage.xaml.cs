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
    public sealed partial class OppositePage : Page
    {
        private Color myColor;

        public OppositePage()
        {
            this.InitializeComponent();
        }

        private void confirmColor_Click(object sender, RoutedEventArgs e)
        {
            myColor = myColorPicker.Color;
            SolidColorBrush myColorBrush = new SolidColorBrush(myColor);
            Up.Fill = myColorBrush;
            string hex1;
            string hex2;
            Color newColor = new Color();
            newColor.A = myColor.A;
            newColor.R = (byte)(255 - myColor.R);
            newColor.G = (byte)(255 - myColor.G);
            newColor.B = (byte)(255 - myColor.B);
            SolidColorBrush myColorBrush1 = new SolidColorBrush(newColor);
            Down.Fill = myColorBrush1;

            hex1 = '#' + myColor.A.ToString("X2") + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            TextBlock1.Text = hex1;

            hex2 = '#' + newColor.A.ToString("X2") + newColor.R.ToString("X2") + newColor.G.ToString("X2") + newColor.B.ToString("X2");
            TextBlock2.Text = hex2;

        }

    }
}
