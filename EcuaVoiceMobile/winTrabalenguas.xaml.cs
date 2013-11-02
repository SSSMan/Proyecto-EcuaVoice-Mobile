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
    public partial class winTrabalenguas : PhoneApplicationPage
    {
        VozDigitalizada speech = new VozDigitalizada();
        public winTrabalenguas()
        {
            InitializeComponent();
        }

        private void hablar(string dato)
        {
            //med1.Source = new Uri(path + dato);
            //med1.Play();
            //med1.Volume = 100;

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //await synth.SpeakTextAsync(dato);
            speech.Speak(dato);
        }

        private void txbComo_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            hablar(txbComo.Text);
        }

        private void btnparar_Click(object sender, RoutedEventArgs e)
        {
            speech.Stop();
        }

       
    }
}