using CopyFiles.CopyCore;
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

namespace CopyFiles
{
    /// <summary>
    /// Interaction logic for Portal.xaml
    /// </summary>
    public partial class Portal : UserControl
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var copy = new FileStreamCopy();
            copy.Copy(@"F:\Wallpaper\oN2uZYz.jpg", @"F:\Wallpaper\1111oN2uZYz.jpg", (percentCopy, isCancel) =>
            {
                System.Diagnostics.Debug.WriteLine($"Process {percentCopy}");
            }, () =>
            {
                System.Diagnostics.Debug.WriteLine("Complete");
            });
        }
    }
}
