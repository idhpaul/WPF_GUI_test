﻿using System.Windows;
using System.Windows.Controls;

using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Navigation;
using System;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Frame.Navigate(new Page_Main());
        }

    }

}

