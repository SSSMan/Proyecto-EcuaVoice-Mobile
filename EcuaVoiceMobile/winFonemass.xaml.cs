using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace EcuaVoiceMobile
{
    public partial class winFonemass : PhoneApplicationPage
    {
        public winFonemass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // mv.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mv.Play();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mvv.Play();
        }
    }
}