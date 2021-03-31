﻿using SwissTransportView.ViewModels;
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

namespace SwissTransportView.Views
{
    /// <summary>
    /// Interaction logic for EmailShareWindow.xaml
    /// </summary>
    public partial class EmailShareWindow : Window
    {
        EmailShareWindowViewModel vm = new EmailShareWindowViewModel();
        public EmailShareWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
