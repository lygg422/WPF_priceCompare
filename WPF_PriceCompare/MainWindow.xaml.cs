using System;
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
using Panuon.UI;

namespace WPF_PriceCompare
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        public void Initiate()
        {
            //    PUTextBox PUTextBox1 = new PUTextBox();
            //    PUTextBox1.Width = 50;
            //    PUTextBox1.Height = 100;
            //    grd_main.Children.Add(PUTextBox1);
            //    grd_main.RegisterName("txt_itemName", PUTextBox1);




        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PUButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PUButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            wd_main.Close();
        }
    }
}
