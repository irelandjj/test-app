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

namespace SimpleFormDemo
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder clientInfo = new StringBuilder();
            clientInfo.Append("Full name: " + FullName.Text);
            clientInfo.Append(" Sex: " + ((bool) Male.IsChecked ? "Male " : "Female "));
            clientInfo.Append("Computer: " + ((bool) Desktop.IsChecked ? "Desktop " : ""));
            clientInfo.Append(((bool) Laptop.IsChecked ? "Laptop " : ""));
            clientInfo.Append(((bool)Table.IsChecked ? "Table " : ""));
            clientInfo.Append("Job: " + Job.SelectionBoxItem.ToString());
            clientInfo.Append(" Delivery date: " + Date.SelectedDate);

            MessageBox.Show(clientInfo.ToString());
        }

        private void Job_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }
    }
}
