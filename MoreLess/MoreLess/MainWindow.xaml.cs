﻿using System;
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

namespace MoreLess
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Play(object sender, MouseEventArgs e)
        {
            GameWindow gameWin = new GameWindow();
            gameWin.Show();
            this.Close();
        }
        private void Credits(object sender, MouseEventArgs e)
        {

        }
        private void Exit(object sender, MouseEventArgs e)
        {

        }
    }
}
