using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;//
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;

namespace EcuaVoiceMobile
{
    public partial class winParesMinimos : PhoneApplicationPage
    {
        public static string path = "http://translate.google.com/translate_tts?tl=es&q=";
        public winParesMinimos()
        {
            InitializeComponent();
        }


        private void Lista1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (Lista1.SelectedItem as ListBoxItem).Content.ToString();
            med1.Source = new Uri(path + text);
            //med1.Source = new Uri(path + Lista1.SelectedItem.ToString());
            //med1.Source = new Uri(path + Lista1.SelectedValue.ToString());
            //med1.Source = new Uri(path + hola.Content.ToString()); si funciona
            //med1.Source = new Uri(path + Lista1.SelectedValue.ToString());
            med1.Play();
            med1.Volume = 100;

        }

        private void Lista2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (Lista2.SelectedItem as ListBoxItem).Content.ToString();
            med1.Source = new Uri(path + text);
            med1.Play();
            med1.Volume = 100;
        }
    }
}