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

namespace OneWayDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee emp;

        public MainWindow()
        {
            InitializeComponent();
            emp = new Employee()
            {
                Name = "Jane",
                Title = "CEO"
            };
            DataContext = emp;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            emp.Name = "Mark";
            emp.Title = "Designer";
        }
    }
}
