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
    /// Logika interakcji dla klasy CreditsWindow.xaml
    /// </summary>
    public partial class CreditsWindow : Window
    {
        public CreditsWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
