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
using MahApps.Metro.Controls;

namespace EncodeDecodeDemoApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void encode_Click(object sender, RoutedEventArgs e)
        {
            var utf8 = new UTF8Encoding();
            var data = utf8.GetBytes(input.Text);
            var ret = Convert.ToBase64String(data);
            result.Text = ret;
        }

        private void decode_Click(object sender, RoutedEventArgs e)
        {
            var utf8 = new UTF8Encoding();
            var ret = utf8.GetString(Convert.FromBase64String(result.Text));
            input.Text = ret;
        }
    }
}
