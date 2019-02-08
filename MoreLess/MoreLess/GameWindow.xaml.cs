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
        SettingQuestion display;
        PlayerPoints points;
        Answer correctAnswer;
        Answer currentAnswer;
        int count = 0;
        int val = 0;
        bool next=false;
        public GameWindow()
        {
            InitializeComponent();
            display = new SettingQuestion();
            DisplayQuestion();
            next = true;
            points = new PlayerPoints(0);
        }

        private void DisplayQuestion()
        {
            if (next == true)
            {
                ++count;
                if (display.GetQuestion(count) == null)
                {
                    ShowTheEnd(points.PointsSum);
                    return;
                }
                questionDisplayBox.Text = display.GetQuestion(count).text;
                val = display.GetQuestion(count).value;
                correctAnswer = display.GetQuestion(count).correctAnswer;

                next = false;
            }
            else
            {
                questionDisplayBox.Text = display.GetQuestion(0).text;
                val = display.GetQuestion(count).value;
                correctAnswer = display.GetQuestion(0).correctAnswer;
            }
        }

        private void Less(object sender, RoutedEventArgs e)
        {
            currentAnswer = Answer.less;
            if (currentAnswer == correctAnswer)
            {
                points.ModifyPointsSum(val);
            }
            else
            {
                points.ModifyPointsSum(-val);
            }
            DisplayQuestion();
            next = true;
        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            currentAnswer = Answer.equals;
            if (currentAnswer == correctAnswer)
            {
                points.ModifyPointsSum(val);
            }
            else
            {
                points.ModifyPointsSum(-val);
            }
            DisplayQuestion();
            next = true;
        }
        private void More(object sender, RoutedEventArgs e)
        {
            currentAnswer = Answer.more;
            if (currentAnswer == correctAnswer)
            {
                points.ModifyPointsSum(val);
            }
            else
            {
                points.ModifyPointsSum(-val);
            }
            DisplayQuestion();
            next = true;
        }

        private void ShowTheEnd(int points)
        {
            EndWindow endWin = new EndWindow(points);
            endWin.Show();
            this.Close();
        }
    }
}
