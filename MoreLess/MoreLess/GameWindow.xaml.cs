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
            DisplayQuestion();
            next = true;
        }

        private void DisplayQuestion()
        {
            if (next==true)
            {
                questionDisplayBox.Text = display.Question(++Count);
                next = false;
            }
            else questionDisplayBox.Text = display.Question(0);
        }

        private void Less(object sender, RoutedEventArgs e)
        {
            DisplayQuestion();
            next = true;
        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            DisplayQuestion();
            next = true;
        }
        private void More(object sender, RoutedEventArgs e)
        {
            DisplayQuestion();
            next = true;
        }
    }
}
