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
using System.Diagnostics;
namespace MoreLess
{
    /// <summary>
    /// Logika interakcji dla klasy GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        testSettingQuestion display;
        int Count = 0;
        bool next=false;
        public GameWindow()
        {
            InitializeComponent();
            display = new testSettingQuestion();
            this.DataContext = this;

        }

        private void DisplayQuestion()
        {
            if (next==true)
            {
                this.Debt = display.Metoda(++Count);
                next = false;
            }
            else this.Debt = display.Metoda(0);
        }

        private void Less(object sender, RoutedEventArgs e)
        {
            next = true;
            DisplayQuestion();


        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            DisplayQuestion();

            next = true;
            Trace.WriteLine("text");
        }
        private void More(object sender, RoutedEventArgs e)
        {
            DisplayQuestion();

            next = true;

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
