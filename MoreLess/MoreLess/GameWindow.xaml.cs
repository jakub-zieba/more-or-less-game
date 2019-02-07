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
    /// Logika interakcji dla klasy GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {

        public GameWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.Debt = "test";
        }
        private void Less(object sender, RoutedEventArgs e)
        {

        }
        private void Equal(object sender, RoutedEventArgs e)
        {

        }
        private void More(object sender, RoutedEventArgs e)
        {

        }
        public string Debt
        {
            get { return (string)GetValue(DebtProperty); }
            set { SetValue(DebtProperty, value); }
        }
        public static readonly DependencyProperty DebtProperty =
            DependencyProperty.Register("Debt", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));

    }
}
