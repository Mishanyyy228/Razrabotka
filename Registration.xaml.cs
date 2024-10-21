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
using System.Windows.Shapes;

namespace LB
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Name_user_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if (Name_user.Text == "Введите имя пользователя")
            {
                Name_user.Text = string.Empty;
                Name_user.Foreground = Brushes.Black;
            }
        }

        private void Email_user_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Email_user.Text == "Введите почту")
            {
                Email_user.Text = string.Empty;
                Email_user.Foreground = Brushes.Black;
            }
        }

        private void Pass_user_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_user.Text == "Введите пароль")
            {
                Pass_user.Text = string.Empty;
                Pass_user.Foreground = Brushes.Black;
            }
        }

        private void Pass_user1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_user1.Text == "Повторите пароль")
            {
                Pass_user1.Text = string.Empty;
                Pass_user1.Foreground = Brushes.Black;
            }
        }

        private void Name_user_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name_user.Text == "")
            {
                Name_user.Text = "Введите имя пользователя";
                Name_user.Foreground = Brushes.Gray;
            }
        }

        private void Email_user_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email_user.Text == "")
            {
                Email_user.Text = "Введите почту";
                Email_user.Foreground = Brushes.Gray;
            }
        }

        private void Pass_user_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_user.Text == "")
            {
                Pass_user.Text = "Введите пароль";
                Pass_user.Foreground = Brushes.Gray;
            }
        }

        private void Pass_user1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Pass_user1.Text == "")
            {
                Pass_user1.Text = "Повторите пароль";
                Pass_user1.Foreground = Brushes.Gray;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w2 = new LogIn();
            Hide();
            w2.Show();
        }
    }
}
