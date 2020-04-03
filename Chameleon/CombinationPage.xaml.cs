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

using System.Collections;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Chameleon
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CombinationPage : Page
    {
        string name;
        string filename;
        string myColor;

        public CombinationPage()
        {
            this.InitializeComponent();
            name = "primo";
            filename = name + ".txt";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            name = pressed.Name.ToString();
            filename = name + ".txt";
        }

        static string[] Search4(string hex, string adress)
        {
            string str;
            string[] str1 = new string[4];
            try
            {
                using (StreamReader sr = new StreamReader(adress))
                {
                    while (true)
                    {
                        str = sr.ReadLine();
                        if (str.StartsWith(hex) == true)
                        {
                            str1[0] = str.Substring(0, 7);
                            str1[1] = str.Substring(8, 7);
                            str1[2] = str.Substring(16, 7);
                            str1[3] = str.Substring(24, 7);
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return str1;
        }

        private void DrawBorder(string str, Border border)
        {
            string str0 = "";
            str0 = "" + str[1] + str[2];
            byte R_3 = byte.Parse(str0, System.Globalization.NumberStyles.HexNumber);
            str0 = "" + str[3] + str[4];
            byte G_3 = byte.Parse(str0, System.Globalization.NumberStyles.HexNumber);
            str0 = "" + str[5] + str[6];
            byte B_3 = byte.Parse(str0, System.Globalization.NumberStyles.HexNumber);
            Color myColor0 = Color.FromArgb(255, R_3, G_3, B_3);
            SolidColorBrush myColorBrush0 = new SolidColorBrush(myColor0);
            border.Background = myColorBrush0;

            if ((R_3 == 38) && (G_3 == 38) && (B_3 == 38))
            {
                TextBlock4.Text = "";
            }
        }

        private void Output()
        {
            switch (name)
            {
                case "primo":
                case "secondo":
                case "quarto":
                    string[] str4 = new string[4];
                    str4 = Search4(myColor, filename);
                    DrawBorder(str4[0], ColorMain);
                    DrawBorder(str4[1], Color1);
                    DrawBorder(str4[2], Color2);
                    DrawBorder(str4[3], Color3);

                    TextBlock1.Text = "#FF" + str4[0].Substring(1);
                    TextBlock2.Text = "#FF" + str4[1].Substring(1);
                    TextBlock3.Text = "#FF" + str4[2].Substring(1);
                    break;

                case "terzo":
                    str4 = new string[4];
                    str4 = Search4(myColor, filename);
                    DrawBorder(str4[0], ColorMain);
                    DrawBorder(str4[1], Color1);
                    DrawBorder(str4[2], Color2);
                    DrawBorder(str4[3], Color3);

                    TextBlock1.Text = "#FF" + str4[0].Substring(1);
                    TextBlock2.Text = "#FF" + str4[1].Substring(1);
                    TextBlock3.Text = "#FF" + str4[2].Substring(1);
                    TextBlock4.Text = "#FF" + str4[3].Substring(1);
                    break;
            }
        }

        //---------------------------1-------------------------------
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFFCC";
            Output();
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFF99";
            Output();
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFF66";
            Output();
        }
        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFF33";
            Output();
        }
        private void Button_Click15(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFF00";
            Output();
        }
        private void Button_Click16(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCC00";
            Output();
        }
        //---------------------------2-------------------------------
        private void Button_Click21(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCC66";
            Output();
        }
        private void Button_Click22(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCC00";
            Output();
        }
        private void Button_Click23(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCC33";
            Output();
        }
        private void Button_Click24(object sender, RoutedEventArgs e)
        {
            myColor = "#CC9900";
            Output();
        }
        private void Button_Click25(object sender, RoutedEventArgs e)
        {
            myColor = "#CC9933";
            Output();
        }
        private void Button_Click26(object sender, RoutedEventArgs e)
        {
            myColor = "#996600";
            Output();
        }
        //---------------------------3-------------------------------
        private void Button_Click31(object sender, RoutedEventArgs e)
        {
            myColor = "#FF9900";
            Output();
        }
        private void Button_Click32(object sender, RoutedEventArgs e)
        {
            myColor = "#FF9933";
            Output();
        }
        private void Button_Click33(object sender, RoutedEventArgs e)
        {
            myColor = "#CC9966";
            Output();
        }
        private void Button_Click34(object sender, RoutedEventArgs e)
        {
            myColor = "#CC6600";
            Output();
        }
        private void Button_Click35(object sender, RoutedEventArgs e)
        {
            myColor = "#996633";
            Output();
        }
        private void Button_Click36(object sender, RoutedEventArgs e)
        {
            myColor = "#663300";
            Output();
        }
        //---------------------------4-------------------------------
        private void Button_Click41(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCC99";
            Output();
        }
        private void Button_Click42(object sender, RoutedEventArgs e)
        {
            myColor = "#FF9966";
            Output();
        }
        private void Button_Click43(object sender, RoutedEventArgs e)
        {
            myColor = "#FF6600";
            Output();
        }
        private void Button_Click44(object sender, RoutedEventArgs e)
        {
            myColor = "#CC6633";
            Output();
        }
        private void Button_Click45(object sender, RoutedEventArgs e)
        {
            myColor = "#993300";
            Output();
        }
        private void Button_Click46(object sender, RoutedEventArgs e)
        {
            myColor = "#660000";
            Output();
        }
        //---------------------------5-------------------------------
        private void Button_Click51(object sender, RoutedEventArgs e)
        {
            myColor = "#FF6633";
            Output();
        }
        private void Button_Click52(object sender, RoutedEventArgs e)
        {
            myColor = "#CC3300";
            Output();
        }
        private void Button_Click53(object sender, RoutedEventArgs e)
        {
            myColor = "#FF3300";
            Output();
        }
        private void Button_Click54(object sender, RoutedEventArgs e)
        {
            myColor = "#FF0000";
            Output();
        }
        private void Button_Click55(object sender, RoutedEventArgs e)
        {
            myColor = "#CC0000";
            Output();
        }
        private void Button_Click56(object sender, RoutedEventArgs e)
        {
            myColor = "#990000";
            Output();
        }
        //---------------------------6-------------------------------
        private void Button_Click61(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCCCC";
            Output();
        }
        private void Button_Click62(object sender, RoutedEventArgs e)
        {
            myColor = "#FF9999";
            Output();
        }
        private void Button_Click63(object sender, RoutedEventArgs e)
        {
            myColor = "#FF6666";
            Output();
        }
        private void Button_Click64(object sender, RoutedEventArgs e)
        {
            myColor = "#FF3333";
            Output();
        }
        private void Button_Click65(object sender, RoutedEventArgs e)
        {
            myColor = "#FF0033";
            Output();
        }
        private void Button_Click66(object sender, RoutedEventArgs e)
        {
            myColor = "#CC0033";
            Output();
        }
        //---------------------------7-------------------------------
        private void Button_Click71(object sender, RoutedEventArgs e)
        {
            myColor = "#CC9999";
            Output();
        }
        private void Button_Click72(object sender, RoutedEventArgs e)
        {
            myColor = "#CC6666";
            Output();
        }
        private void Button_Click73(object sender, RoutedEventArgs e)
        {
            myColor = "#CC3333";
            Output();
        }
        private void Button_Click74(object sender, RoutedEventArgs e)
        {
            myColor = "#993333";
            Output();
        }
        private void Button_Click75(object sender, RoutedEventArgs e)
        {
            myColor = "#990033";
            Output();
        }
        private void Button_Click76(object sender, RoutedEventArgs e)
        {
            myColor = "#330000";
            Output();
        }
        //---------------------------8-------------------------------
        private void Button_Click81(object sender, RoutedEventArgs e)
        {
            myColor = "#FF6699";
            Output();
        }
        private void Button_Click82(object sender, RoutedEventArgs e)
        {
            myColor = "#FF3366";
            Output();
        }
        private void Button_Click83(object sender, RoutedEventArgs e)
        {
            myColor = "#FF0066";
            Output();
        }
        private void Button_Click84(object sender, RoutedEventArgs e)
        {
            myColor = "#CC3366";
            Output();
        }
        private void Button_Click85(object sender, RoutedEventArgs e)
        {
            myColor = "#996666";
            Output();
        }
        private void Button_Click86(object sender, RoutedEventArgs e)
        {
            myColor = "#663333";
            Output();
        }
        //---------------------------9-------------------------------
        private void Button_Click91(object sender, RoutedEventArgs e)
        {
            myColor = "#FF99CC";
            Output();
        }
        private void Button_Click92(object sender, RoutedEventArgs e)
        {
            myColor = "#FF3399";
            Output();
        }
        private void Button_Click93(object sender, RoutedEventArgs e)
        {
            myColor = "#FF0099";
            Output();
        }
        private void Button_Click94(object sender, RoutedEventArgs e)
        {
            myColor = "#CC0066";
            Output();
        }
        private void Button_Click95(object sender, RoutedEventArgs e)
        {
            myColor = "#993366";
            Output();
        }
        private void Button_Click96(object sender, RoutedEventArgs e)
        {
            myColor = "#660033";
            Output();
        }
        //---------------------------10-------------------------------
        private void Button_Click101(object sender, RoutedEventArgs e)
        {
            myColor = "#FF66CC";
            Output();
        }
        private void Button_Click102(object sender, RoutedEventArgs e)
        {
            myColor = "#FF00CC";
            Output();
        }
        private void Button_Click103(object sender, RoutedEventArgs e)
        {
            myColor = "#FF33CC";
            Output();
        }
        private void Button_Click104(object sender, RoutedEventArgs e)
        {
            myColor = "#CC6699";
            Output();
        }
        private void Button_Click105(object sender, RoutedEventArgs e)
        {
            myColor = "#CC0099";
            Output();
        }
        private void Button_Click106(object sender, RoutedEventArgs e)
        {
            myColor = "#990066";
            Output();
        }
        //---------------------------11-------------------------------
        private void Button_Click111(object sender, RoutedEventArgs e)
        {
            myColor = "#FFCCFF";
            Output();
        }
        private void Button_Click112(object sender, RoutedEventArgs e)
        {
            myColor = "#FF99FF";
            Output();
        }
        private void Button_Click113(object sender, RoutedEventArgs e)
        {
            myColor = "#FF66FF";
            Output();
        }
        private void Button_Click114(object sender, RoutedEventArgs e)
        {
            myColor = "#FF33FF";
            Output();
        }
        private void Button_Click115(object sender, RoutedEventArgs e)
        {
            myColor = "#FF00FF";
            Output();
        }
        private void Button_Click116(object sender, RoutedEventArgs e)
        {
            myColor = "#CC3399";
            Output();
        }
        //---------------------------12-------------------------------
        private void Button_Click121(object sender, RoutedEventArgs e)
        {
            myColor = "#CC99CC";
            Output();
        }
        private void Button_Click122(object sender, RoutedEventArgs e)
        {
            myColor = "#CC66CC";
            Output();
        }
        private void Button_Click123(object sender, RoutedEventArgs e)
        {
            myColor = "#CC00CC";
            Output();
        }
        private void Button_Click124(object sender, RoutedEventArgs e)
        {
            myColor = "#CC33CC";
            Output();
        }
        private void Button_Click125(object sender, RoutedEventArgs e)
        {
            myColor = "#990099";
            Output();
        }
        private void Button_Click126(object sender, RoutedEventArgs e)
        {
            myColor = "#993399";
            Output();
        }
        //---------------------------13-------------------------------
        private void Button_Click131(object sender, RoutedEventArgs e)
        {
            myColor = "#CC66FF";
            Output();
        }
        private void Button_Click132(object sender, RoutedEventArgs e)
        {
            myColor = "#CC33FF";
            Output();
        }
        private void Button_Click133(object sender, RoutedEventArgs e)
        {
            myColor = "#CC00FF";
            Output();
        }
        private void Button_Click134(object sender, RoutedEventArgs e)
        {
            myColor = "#9900CC";
            Output();
        }
        private void Button_Click135(object sender, RoutedEventArgs e)
        {
            myColor = "#996699";
            Output();
        }
        private void Button_Click136(object sender, RoutedEventArgs e)
        {
            myColor = "#660066";
            Output();
        }
        //---------------------------14-------------------------------
        private void Button_Click141(object sender, RoutedEventArgs e)
        {
            myColor = "#CC99FF";
            Output();
        }
        private void Button_Click142(object sender, RoutedEventArgs e)
        {
            myColor = "#9933CC";
            Output();
        }
        private void Button_Click143(object sender, RoutedEventArgs e)
        {
            myColor = "#9933FF";
            Output();
        }
        private void Button_Click144(object sender, RoutedEventArgs e)
        {
            myColor = "#9900FF";
            Output();
        }
        private void Button_Click145(object sender, RoutedEventArgs e)
        {
            myColor = "#660099";
            Output();
        }
        private void Button_Click146(object sender, RoutedEventArgs e)
        {
            myColor = "#663366";
            Output();
        }
        //---------------------------15-------------------------------
        private void Button_Click151(object sender, RoutedEventArgs e)
        {
            myColor = "#9966CC";
            Output();
        }
        private void Button_Click152(object sender, RoutedEventArgs e)
        {
            myColor = "#9966FF";
            Output();
        }
        private void Button_Click153(object sender, RoutedEventArgs e)
        {
            myColor = "#6600CC";
            Output();
        }
        private void Button_Click154(object sender, RoutedEventArgs e)
        {
            myColor = "#6633CC";
            Output();
        }
        private void Button_Click155(object sender, RoutedEventArgs e)
        {
            myColor = "#663399";
            Output();
        }
        private void Button_Click156(object sender, RoutedEventArgs e)
        {
            myColor = "#330033";
            Output();
        }
        //---------------------------16-------------------------------
        private void Button_Click161(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCCFF";
            Output();
        }
        private void Button_Click162(object sender, RoutedEventArgs e)
        {
            myColor = "#9999FF";
            Output();
        }
        private void Button_Click163(object sender, RoutedEventArgs e)
        {
            myColor = "#6633FF";
            Output();
        }
        private void Button_Click164(object sender, RoutedEventArgs e)
        {
            myColor = "#6600FF";
            Output();
        }
        private void Button_Click165(object sender, RoutedEventArgs e)
        {
            myColor = "#330099";
            Output();
        }
        private void Button_Click166(object sender, RoutedEventArgs e)
        {
            myColor = "#330066";
            Output();
        }
        //---------------------------17-------------------------------
        private void Button_Click171(object sender, RoutedEventArgs e)
        {
            myColor = "#9999CC";
            Output();
        }
        private void Button_Click172(object sender, RoutedEventArgs e)
        {
            myColor = "#6666FF";
            Output();
        }
        private void Button_Click173(object sender, RoutedEventArgs e)
        {
            myColor = "#6666CC";
            Output();
        }
        private void Button_Click174(object sender, RoutedEventArgs e)
        {
            myColor = "#666699";
            Output();
        }
        private void Button_Click175(object sender, RoutedEventArgs e)
        {
            myColor = "#333399";
            Output();
        }
        private void Button_Click176(object sender, RoutedEventArgs e)
        {
            myColor = "#333366";
            Output();
        }
        //---------------------------18-------------------------------
        private void Button_Click181(object sender, RoutedEventArgs e)
        {
            myColor = "#3333FF";
            Output();
        }
        private void Button_Click182(object sender, RoutedEventArgs e)
        {
            myColor = "#3300FF";
            Output();
        }
        private void Button_Click183(object sender, RoutedEventArgs e)
        {
            myColor = "#3300CC";
            Output();
        }
        private void Button_Click184(object sender, RoutedEventArgs e)
        {
            myColor = "#3333CC";
            Output();
        }
        private void Button_Click185(object sender, RoutedEventArgs e)
        {
            myColor = "#000099";
            Output();
        }
        private void Button_Click186(object sender, RoutedEventArgs e)
        {
            myColor = "#000066";
            Output();
        }
        //---------------------------19-------------------------------
        private void Button_Click191(object sender, RoutedEventArgs e)
        {
            myColor = "#6699FF";
            Output();
        }
        private void Button_Click192(object sender, RoutedEventArgs e)
        {
            myColor = "#3366FF";
            Output();
        }
        private void Button_Click193(object sender, RoutedEventArgs e)
        {
            myColor = "#0000FF";
            Output();
        }
        private void Button_Click194(object sender, RoutedEventArgs e)
        {
            myColor = "#0000CC";
            Output();
        }
        private void Button_Click195(object sender, RoutedEventArgs e)
        {
            myColor = "#0033CC";
            Output();
        }
        private void Button_Click196(object sender, RoutedEventArgs e)
        {
            myColor = "#000033";
            Output();
        }
        //---------------------------20-------------------------------
        private void Button_Click201(object sender, RoutedEventArgs e)
        {
            myColor = "#0066FF";
            Output();
        }
        private void Button_Click202(object sender, RoutedEventArgs e)
        {
            myColor = "#0066CC";
            Output();
        }
        private void Button_Click203(object sender, RoutedEventArgs e)
        {
            myColor = "#3366CC";
            Output();
        }
        private void Button_Click204(object sender, RoutedEventArgs e)
        {
            myColor = "#0033FF";
            Output();
        }
        private void Button_Click205(object sender, RoutedEventArgs e)
        {
            myColor = "#003399";
            Output();
        }
        private void Button_Click206(object sender, RoutedEventArgs e)
        {
            myColor = "#003366";
            Output();
        }
        //---------------------------21-------------------------------
        private void Button_Click211(object sender, RoutedEventArgs e)
        {
            myColor = "#99CCFF";
            Output();
        }
        private void Button_Click212(object sender, RoutedEventArgs e)
        {
            myColor = "#3399FF";
            Output();
        }
        private void Button_Click213(object sender, RoutedEventArgs e)
        {
            myColor = "#0099FF";
            Output();
        }
        private void Button_Click214(object sender, RoutedEventArgs e)
        {
            myColor = "#6699CC";
            Output();
        }
        private void Button_Click215(object sender, RoutedEventArgs e)
        {
            myColor = "#336699";
            Output();
        }
        private void Button_Click216(object sender, RoutedEventArgs e)
        {
            myColor = "#006699";
            Output();
        }
        //---------------------------22-------------------------------
        private void Button_Click221(object sender, RoutedEventArgs e)
        {
            myColor = "#66CCFF";
            Output();
        }
        private void Button_Click222(object sender, RoutedEventArgs e)
        {
            myColor = "#33CCFF";
            Output();
        }
        private void Button_Click223(object sender, RoutedEventArgs e)
        {
            myColor = "#00CCFF";
            Output();
        }
        private void Button_Click224(object sender, RoutedEventArgs e)
        {
            myColor = "#3399CC";
            Output();
        }
        private void Button_Click225(object sender, RoutedEventArgs e)
        {
            myColor = "#0099CC";
            Output();
        }
        private void Button_Click226(object sender, RoutedEventArgs e)
        {
            myColor = "#003333";
            Output();
        }
        //---------------------------23-------------------------------
        private void Button_Click231(object sender, RoutedEventArgs e)
        {
            myColor = "#99CCCC";
            Output();
        }
        private void Button_Click232(object sender, RoutedEventArgs e)
        {
            myColor = "#66CCCC";
            Output();
        }
        private void Button_Click233(object sender, RoutedEventArgs e)
        {
            myColor = "#339999";
            Output();
        }
        private void Button_Click234(object sender, RoutedEventArgs e)
        {
            myColor = "#669999";
            Output();
        }
        private void Button_Click235(object sender, RoutedEventArgs e)
        {
            myColor = "#006666";
            Output();
        }
        private void Button_Click236(object sender, RoutedEventArgs e)
        {
            myColor = "#336666";
            Output();
        }
        //---------------------------24-------------------------------
        private void Button_Click241(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFFFF";
            Output();
        }
        private void Button_Click242(object sender, RoutedEventArgs e)
        {
            myColor = "#99FFFF";
            Output();
        }
        private void Button_Click243(object sender, RoutedEventArgs e)
        {
            myColor = "#66FFFF";
            Output();
        }
        private void Button_Click244(object sender, RoutedEventArgs e)
        {
            myColor = "#33FFFF";
            Output();
        }
        private void Button_Click245(object sender, RoutedEventArgs e)
        {
            myColor = "#00FFFF";
            Output();
        }
        private void Button_Click246(object sender, RoutedEventArgs e)
        {
            myColor = "#00CCCC";
            Output();
        }
        //---------------------------25-------------------------------
        private void Button_Click251(object sender, RoutedEventArgs e)
        {
            myColor = "#99FFCC";
            Output();
        }
        private void Button_Click252(object sender, RoutedEventArgs e)
        {
            myColor = "#66FFCC";
            Output();
        }
        private void Button_Click253(object sender, RoutedEventArgs e)
        {
            myColor = "#33FFCC";
            Output();
        }
        private void Button_Click254(object sender, RoutedEventArgs e)
        {
            myColor = "#00FFCC";
            Output();
        }
        private void Button_Click255(object sender, RoutedEventArgs e)
        {
            myColor = "#33CCCC";
            Output();
        }
        private void Button_Click256(object sender, RoutedEventArgs e)
        {
            myColor = "#009999";
            Output();
        }
        //---------------------------26-------------------------------
        private void Button_Click261(object sender, RoutedEventArgs e)
        {
            myColor = "#66CC99";
            Output();
        }
        private void Button_Click262(object sender, RoutedEventArgs e)
        {
            myColor = "#33CC99";
            Output();
        }
        private void Button_Click263(object sender, RoutedEventArgs e)
        {
            myColor = "#00CC99";
            Output();
        }
        private void Button_Click264(object sender, RoutedEventArgs e)
        {
            myColor = "#339966";
            Output();
        }
        private void Button_Click265(object sender, RoutedEventArgs e)
        {
            myColor = "#009966";
            Output();
        }
        private void Button_Click266(object sender, RoutedEventArgs e)
        {
            myColor = "#006633";
            Output();
        }
        //---------------------------27-------------------------------
        private void Button_Click271(object sender, RoutedEventArgs e)
        {
            myColor = "#66FF99";
            Output();
        }
        private void Button_Click272(object sender, RoutedEventArgs e)
        {
            myColor = "#33FF99";
            Output();
        }
        private void Button_Click273(object sender, RoutedEventArgs e)
        {
            myColor = "#00FF99";
            Output();
        }
        private void Button_Click274(object sender, RoutedEventArgs e)
        {
            myColor = "#33CC66";
            Output();
        }
        private void Button_Click275(object sender, RoutedEventArgs e)
        {
            myColor = "#00CC66";
            Output();
        }
        private void Button_Click276(object sender, RoutedEventArgs e)
        {
            myColor = "#009933";
            Output();
        }
        //---------------------------28-------------------------------
        private void Button_Click281(object sender, RoutedEventArgs e)
        {
            myColor = "#99FF99";
            Output();
        }
        private void Button_Click282(object sender, RoutedEventArgs e)
        {
            myColor = "#66FF66";
            Output();
        }
        private void Button_Click283(object sender, RoutedEventArgs e)
        {
            myColor = "#33FF66";
            Output();
        }
        private void Button_Click284(object sender, RoutedEventArgs e)
        {
            myColor = "#00FF66";
            Output();
        }
        private void Button_Click285(object sender, RoutedEventArgs e)
        {
            myColor = "#339933";
            Output();
        }
        private void Button_Click286(object sender, RoutedEventArgs e)
        {
            myColor = "#006600";
            Output();
        }
        //---------------------------29-------------------------------
        private void Button_Click291(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFFCC";
            Output();
        }
        private void Button_Click292(object sender, RoutedEventArgs e)
        {
            myColor = "#99CC99";
            Output();
        }
        private void Button_Click293(object sender, RoutedEventArgs e)
        {
            myColor = "#66CC66";
            Output();
        }
        private void Button_Click294(object sender, RoutedEventArgs e)
        {
            myColor = "#669966";
            Output();
        }
        private void Button_Click295(object sender, RoutedEventArgs e)
        {
            myColor = "#336633";
            Output();
        }
        private void Button_Click296(object sender, RoutedEventArgs e)
        {
            myColor = "#003300";
            Output();
        }
        //---------------------------30-------------------------------
        private void Button_Click301(object sender, RoutedEventArgs e)
        {
            myColor = "#33FF33";
            Output();
        }
        private void Button_Click302(object sender, RoutedEventArgs e)
        {
            myColor = "#00FF33";
            Output();
        }
        private void Button_Click303(object sender, RoutedEventArgs e)
        {
            myColor = "#00FF00";
            Output();
        }
        private void Button_Click304(object sender, RoutedEventArgs e)
        {
            myColor = "#00CC00";
            Output();
        }
        private void Button_Click305(object sender, RoutedEventArgs e)
        {
            myColor = "#33CC33";
            Output();
        }
        private void Button_Click306(object sender, RoutedEventArgs e)
        {
            myColor = "#00CC33";
            Output();
        }
        //---------------------------31-------------------------------
        private void Button_Click311(object sender, RoutedEventArgs e)
        {
            myColor = "#66FF00";
            Output();
        }
        private void Button_Click312(object sender, RoutedEventArgs e)
        {
            myColor = "#66FF33";
            Output();
        }
        private void Button_Click313(object sender, RoutedEventArgs e)
        {
            myColor = "#33FF00";
            Output();
        }
        private void Button_Click314(object sender, RoutedEventArgs e)
        {
            myColor = "#33CC00";
            Output();
        }
        private void Button_Click315(object sender, RoutedEventArgs e)
        {
            myColor = "#339900";
            Output();
        }
        private void Button_Click316(object sender, RoutedEventArgs e)
        {
            myColor = "#009900";
            Output();
        }
        //---------------------------32-------------------------------
        private void Button_Click321(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFF99";
            Output();
        }
        private void Button_Click322(object sender, RoutedEventArgs e)
        {
            myColor = "#99FF66";
            Output();
        }
        private void Button_Click323(object sender, RoutedEventArgs e)
        {
            myColor = "#66CC00";
            Output();
        }
        private void Button_Click324(object sender, RoutedEventArgs e)
        {
            myColor = "#66CC33";
            Output();
        }
        private void Button_Click325(object sender, RoutedEventArgs e)
        {
            myColor = "#669933";
            Output();
        }
        private void Button_Click326(object sender, RoutedEventArgs e)
        {
            myColor = "#336600";
            Output();
        }
        //---------------------------33-------------------------------
        private void Button_Click331(object sender, RoutedEventArgs e)
        {
            myColor = "#99FF00";
            Output();
        }
        private void Button_Click332(object sender, RoutedEventArgs e)
        {
            myColor = "#99FF33";
            Output();
        }
        private void Button_Click333(object sender, RoutedEventArgs e)
        {
            myColor = "#99CC66";
            Output();
        }
        private void Button_Click334(object sender, RoutedEventArgs e)
        {
            myColor = "#99CC00";
            Output();
        }
        private void Button_Click335(object sender, RoutedEventArgs e)
        {
            myColor = "#99CC33";
            Output();
        }
        private void Button_Click336(object sender, RoutedEventArgs e)
        {
            myColor = "#669900";
            Output();
        }
        //---------------------------34-------------------------------
        private void Button_Click341(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFF66";
            Output();
        }
        private void Button_Click342(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFF00";
            Output();
        }
        private void Button_Click343(object sender, RoutedEventArgs e)
        {
            myColor = "#CCFF33";
            Output();
        }
        private void Button_Click344(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCC99";
            Output();
        }
        private void Button_Click345(object sender, RoutedEventArgs e)
        {
            myColor = "#666633";
            Output();
        }
        private void Button_Click346(object sender, RoutedEventArgs e)
        {
            myColor = "#333300";
            Output();
        }
        //---------------------------35-------------------------------
        private void Button_Click351(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCC66";
            Output();
        }
        private void Button_Click352(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCC33";
            Output();
        }
        private void Button_Click353(object sender, RoutedEventArgs e)
        {
            myColor = "#999966";
            Output();
        }
        private void Button_Click354(object sender, RoutedEventArgs e)
        {
            myColor = "#999933";
            Output();
        }
        private void Button_Click355(object sender, RoutedEventArgs e)
        {
            myColor = "#999900";
            Output();
        }
        private void Button_Click356(object sender, RoutedEventArgs e)
        {
            myColor = "#666600";
            Output();
        }
        //---------------------------36-------------------------------
        private void Button_Click361(object sender, RoutedEventArgs e)
        {
            myColor = "#FFFFFF";
            Output();
        }
        private void Button_Click362(object sender, RoutedEventArgs e)
        {
            myColor = "#CCCCCC";
            Output();
        }
        private void Button_Click363(object sender, RoutedEventArgs e)
        {
            myColor = "#999999";
            Output();
        }
        private void Button_Click364(object sender, RoutedEventArgs e)
        {
            myColor = "#666666";
            Output();
        }
        private void Button_Click365(object sender, RoutedEventArgs e)
        {
            myColor = "#333333";
            Output();
        }
        private void Button_Click366(object sender, RoutedEventArgs e)
        {
            myColor = "#000000";
            Output();
        }
    }
}