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
    public partial class winRimas : PhoneApplicationPage
    {
        VozDigitalizada speech = new VozDigitalizada();
        public winRimas()
        {
            InitializeComponent();
        }

        private void hablar(string dato)
        {            
            speech.Speak(dato);
        }

        private void txbGato_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            hablar(txbGato.Text);
        }

        private void btnparar_Click(object sender, RoutedEventArgs e)
        {
            speech.Stop();
        }
    }
}