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
    public partial class winSilabasCompuestas : PhoneApplicationPage
    {
        //public static string path = "http://translate.google.com/translate_tts?tl=es&q=";
        VozDigitalizada speech = new VozDigitalizada();
        public winSilabasCompuestas()
        {
            InitializeComponent();
        }

        private void btnbla_Click(object sender, RoutedEventArgs e)
        {
            hablar("bla");
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

        private void btnble_Click(object sender, RoutedEventArgs e)
        {
            hablar("ble");
        }

        private void btnbli_Click(object sender, RoutedEventArgs e)
        {
            hablar("bli");
        }

        private void btnblo_Click(object sender, RoutedEventArgs e)
        {
            hablar("blo");
        }

        private void bntblu_Click(object sender, RoutedEventArgs e)
        {
            hablar("blu");
        }

        private void btncla_Click(object sender, RoutedEventArgs e)
        {
            hablar("cla");
        }

        private void btncle_Click(object sender, RoutedEventArgs e)
        {
            hablar("cle");
        }

        private void btncli_Click(object sender, RoutedEventArgs e)
        {
            hablar("cli");
        }

        private void btnclo_Click(object sender, RoutedEventArgs e)
        {
            hablar("clo");
        }

        private void bntclu_Click(object sender, RoutedEventArgs e)
        {
            hablar("clu");
        }

        private void btnfla_Click(object sender, RoutedEventArgs e)
        {
            hablar("fla");
        }

        private void btnfle_Click(object sender, RoutedEventArgs e)
        {
            hablar("fle");
        }

        private void btnfli_Click(object sender, RoutedEventArgs e)
        {
            hablar("fli");
        }

        private void btnflo_Click(object sender, RoutedEventArgs e)
        {
            hablar("flo");
        }

        private void bntflu_Click(object sender, RoutedEventArgs e)
        {
            hablar("b=flu");
        }

        private void btngla_Click(object sender, RoutedEventArgs e)
        {
            hablar("gla");
        }

        private void btngle_Click(object sender, RoutedEventArgs e)
        {
            hablar("gle");
        }

        private void btngli_Click(object sender, RoutedEventArgs e)
        {
            hablar("gli");
        }

        private void btnglo_Click(object sender, RoutedEventArgs e)
        {
            hablar("glo");
        }

        private void bntglu_Click(object sender, RoutedEventArgs e)
        {
            hablar("glu");
        }

        private void btnpla_Click(object sender, RoutedEventArgs e)
        {
            hablar("pla");
        }

        private void btnple_Click(object sender, RoutedEventArgs e)
        {
            hablar("ple");
        }

        private void btnpli_Click(object sender, RoutedEventArgs e)
        {
            hablar("pli");
        }

        private void btnplo_Click(object sender, RoutedEventArgs e)
        {
            hablar("plo");
        }

        private void bntplu_Click(object sender, RoutedEventArgs e)
        {
            hablar("plu");
        }

        private void btnbra_Click(object sender, RoutedEventArgs e)
        {
            hablar("bra");
        }

        private void btnbre_Click(object sender, RoutedEventArgs e)
        {
            hablar("bre");
        }

        private void btnbri_Click(object sender, RoutedEventArgs e)
        {
            hablar("bri");
        }

        private void btnbro_Click(object sender, RoutedEventArgs e)
        {
            hablar("bro");
        }

        private void bntbru_Click(object sender, RoutedEventArgs e)
        {
            hablar("bru");
        }

        private void btncra_Click(object sender, RoutedEventArgs e)
        {
            hablar("cra");
        }

        private void btncre_Click(object sender, RoutedEventArgs e)
        {
            hablar("cre");
        }

        private void btncri_Click(object sender, RoutedEventArgs e)
        {
            hablar("cri");
        }

        private void btncro_Click(object sender, RoutedEventArgs e)
        {
            hablar("cro");
        }

        private void bntcru_Click(object sender, RoutedEventArgs e)
        {
            hablar("cru");
        }

        private void btndra_Click(object sender, RoutedEventArgs e)
        {
            hablar("dra");
        }

        private void btndre_Click(object sender, RoutedEventArgs e)
        {
            hablar("dre");
        }

        private void btndri_Click(object sender, RoutedEventArgs e)
        {
            hablar("dri");
        }

        private void btndro_Click(object sender, RoutedEventArgs e)
        {
            hablar("dro");
        }

        private void bntdru_Click(object sender, RoutedEventArgs e)
        {
            hablar("dru");
        }

        private void btnfra_Click(object sender, RoutedEventArgs e)
        {
            hablar("fra");
        }

        private void btnfre_Click(object sender, RoutedEventArgs e)
        {
            hablar("fre");
        }

        private void btnfri_Click(object sender, RoutedEventArgs e)
        {
            hablar("fri");
        }

        private void btnfro_Click(object sender, RoutedEventArgs e)
        {
            hablar("fro");
        }

        private void bntfru_Click(object sender, RoutedEventArgs e)
        {
            hablar("fru");
        }

        private void btngra_Click(object sender, RoutedEventArgs e)
        {
            hablar("gra");
        }

        private void btngre_Click(object sender, RoutedEventArgs e)
        {
            hablar("gre");
        }

        private void btngri_Click(object sender, RoutedEventArgs e)
        {
            hablar("gri");
        }

        private void btngro_Click(object sender, RoutedEventArgs e)
        {
            hablar("gro");
        }

        private void bntgru_Click(object sender, RoutedEventArgs e)
        {
            hablar("gru");
        }

        private void btnpra_Click(object sender, RoutedEventArgs e)
        {
            hablar("pra");
        }

        private void btnpre_Click(object sender, RoutedEventArgs e)
        {
            hablar("pre");
        }

        private void btnpri_Click(object sender, RoutedEventArgs e)
        {
            hablar("pri");
        }

        private void btnpro_Click(object sender, RoutedEventArgs e)
        {
            hablar("pro");
        }

        private void bntpru_Click(object sender, RoutedEventArgs e)
        {
            hablar("pru");
        }

        private void btntra_Click(object sender, RoutedEventArgs e)
        {
            hablar("tra");
        }

        private void btntre_Click(object sender, RoutedEventArgs e)
        {
            hablar("tre");
        }

        private void btntri_Click(object sender, RoutedEventArgs e)
        {
            hablar("tri");
        }

        private void btntro_Click(object sender, RoutedEventArgs e)
        {
            hablar("tro");
        }

        private void bnttru_Click(object sender, RoutedEventArgs e)
        {
            hablar("tru");
        }
    }
}