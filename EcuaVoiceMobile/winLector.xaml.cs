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
    public partial class winLector : PhoneApplicationPage
    {
        //public static string path = "http://translate.google.com/translate_tts?tl=es&q=";
        VozDigitalizada speech = new VozDigitalizada();
        public winLector()
        {
            InitializeComponent();
        }

        private void hablar(string dato)
        {
            speech.Speak(dato);
        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            //string text = (Lista2.SelectedItem as ListBoxItem).Content.ToString();
            //med1.Source = new Uri(path + txtparrafo.Text);
            //med1.Play();
            //med1.Volume = 100;
            hablar(txtparrafo.Text);
        }

        private void btnparar_Click(object sender, RoutedEventArgs e)
        {
            speech.Stop();
        }
    }
}