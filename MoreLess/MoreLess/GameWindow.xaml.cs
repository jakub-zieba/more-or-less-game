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
using System.Timers;

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
        //Answer currentAnswer;
        int count = 0;
        int val = 0;
        int timeForAnswer = 20;
        bool next=false;
        //private TimeSpan startTimeSpan = TimeSpan.Zero;
        //private TimeSpan periodTimeSpan = TimeSpan.FromSeconds(1);
        public GameWindow()
        {
            InitializeComponent();
            display = new SettingQuestion();
            points = new PlayerPoints(0);
            DisplayQuestion();
            next = true;


            /*var timer = new System.Threading.Timer((e) =>
            {
                CountDown();
            }, null, startTimeSpan, periodTimeSpan);*/
        }

      /*  private void CountDown()
        {
            timeForAnswer--;
            timerDisplayBox.Text = timeForAnswer.ToString();
            if (timeForAnswer == 0)
            {
                timeForAnswer = 20;
                next = true;
                DisplayQuestion();
            }
        }*/

        private void DisplayQuestion()
        {
            timerDisplayBox.Text = timeForAnswer.ToString();

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
            SetActionResults(CheckAnswer(Answer.less));
            DisplayQuestion();
            next = true;
        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            SetActionResults(CheckAnswer(Answer.equals));
            DisplayQuestion();
            next = true;
        }
        private void More(object sender, RoutedEventArgs e)
        {
            SetActionResults(CheckAnswer(Answer.more));
            DisplayQuestion();
            next = true;
        }

        private bool CheckAnswer(Answer currentAnswer)
        {
            if (currentAnswer == correctAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void SetActionResults(bool rightOrWrong)
        {
            string message = "";
            if (rightOrWrong)
            {
                //Add players points
                points.ModifyPointsSum(val);
                // Configure message box
                message = "Good!";
            }
            else
            {
                //Decrease players points amount
                points.ModifyPointsSum(-val);
                // Configure message box
                message = "Wrong!";
            }
            // Show message box
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void ShowTheEnd(int points)
        {
            EndWindow endWin = new EndWindow(points);
            endWin.Show();
            this.Close();
        }
    }
}
