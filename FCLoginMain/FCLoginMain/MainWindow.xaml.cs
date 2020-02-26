using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FCLoginMain
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //设置窗体的启动位置
            double screenW = SystemParameters.ScrollWidth;
            double screenH = SystemParameters.ScrollHeight;
            double offsetHorizontal = 100;
            double offsetVertical = 200;
            this.Left = (this.Width - screenW ) / 2 - offsetHorizontal;
            this.Top = (this.Height - screenH) / 2 - offsetVertical;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnLogon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
