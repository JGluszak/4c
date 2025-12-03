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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, word!");
            btnStart.Opacity = 0.5;
            btnStart.Opacity = 1;
        }

        private void BtnCzasOn(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void BtnCzasOff(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }
    }
}
