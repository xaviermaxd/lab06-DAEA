﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Insert(object sender, RoutedEventArgs e)
        {
            InsertEmp insertEmp = new InsertEmp();
            insertEmp.Show();
        }

        private void Button_Click_Select(object sender, RoutedEventArgs e)
        {
            ListEmp listEmp = new ListEmp();
            listEmp.Show();
        }
    }
}