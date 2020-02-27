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
            //实现窗体拖动
            this.DragMove();
        }
        /// <summary>
        /// 窗体最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// 窗体关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            //this.Close();
            //App.Current.Shutdown();
        }
        /// <summary>
        /// 请求登陆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, RoutedEventArgs e)
        {
            //启动另一个可执行程序，一般是exe文件
            System.Diagnostics.Process.Start("FinalCombat.exe");
        }
        /// <summary>
        /// 用户协议超链接文字-鼠标进入 显示下划线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        /// <summary>
        /// 用户协议超链接文字-鼠标离开 隐藏下划线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_MouseLeave(object sender, MouseEventArgs e)
        {

        }
        /// <summary>
        /// 用户协议超链接文字-鼠标点击 打开用户协议
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
