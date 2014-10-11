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
using EterManager.UserInterface.ViewModels;

namespace EterManager.UserInterface.Views.UserControls
{
    /// <summary>
    /// Interaction logic for IssuesListView.xaml
    /// </summary>
    public partial class IssuesListView : UserControl
    {
        public IssuesListView()
        {
            InitializeComponent();
            DataContext = ((App)Application.Current).GetInstance<IssuesListViewModel>();
        }
    }
}