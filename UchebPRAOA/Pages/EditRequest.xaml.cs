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

namespace UchebPRAOA.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditRequest.xaml
    /// </summary>
    public partial class EditRequest : Page
    {
        public EditRequest(Request request)
        {
            InitializeComponent();

            Description.Text = request.Description;
                
        }
    }
}
