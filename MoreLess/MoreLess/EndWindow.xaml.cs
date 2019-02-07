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
using System.Windows.Shapes;

namespace MoreLess
{
    /// <summary>
    /// Logika interakcji dla klasy EndWindow.xaml
    /// </summary>
    public partial class EndWindow : Window
    {
        public EndWindow(int points)
        {
            InitializeComponent();
            scoreDisplayBox.Text = points.ToString();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
