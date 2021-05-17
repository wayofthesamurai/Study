using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
            textBlock2.Text = "0";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "C")
            {
                textBlock1.Text = "";
                textBlock2.Text = "0";
            }
            else if (str == "CE")
            {
                textBlock2.Text = "0";
            }
            else if (str == "<")
            {
                textBlock1.Text = textBlock1.Text.Remove(textBlock1.Text.Length - 1);
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(textBlock1.Text, null).ToString();
                textBlock1.Text += str;
                textBlock2.Text = value;
            }
            else if (str == ",")
            {
                textBlock2.Text += str;
            }
            //else if (str == "+")
            //{
            //    textBlock1.Text = textBlock2.Text;
            //    textBlock1.Text += str;
            //}
            //else if (str == "-")
            //{
            //    textBlock1.Text = textBlock2.Text;
            //    textBlock1.Text += str;
            //}
            //else if (str == "*")
            //{
            //    textBlock1.Text = textBlock2.Text;
            //    textBlock1.Text += str;
            //}
            //else if (str == "/")
            //{
            //    textBlock1.Text = textBlock2.Text;
            //    textBlock1.Text += str;
            //}
            else
            {

                if (str == "0" || str == "1" || str == "2" || str == "3" || str == "4" || str == "5" || str == "6" || str == "7" || str == "8" || str == "9")
                    textBlock2.Text = str;
                else
                {
                    textBlock1.Text += textBlock2.Text;
                    textBlock1.Text += str;
                }
            }
            
            
        }
    }
}
