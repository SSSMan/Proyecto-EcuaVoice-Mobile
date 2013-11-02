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
    public partial class winDeletreos : PhoneApplicationPage
    {
        string letra; int contL = 0;

        //public static string path = "http://translate.google.com/translate_tts?tl=es&q=";

        VozDigitalizada speech = new VozDigitalizada();

        System.Windows.Threading.DispatcherTimer dtLetra = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer dtSilaba = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer dtPalabra = new System.Windows.Threading.DispatcherTimer();

        //variables de las silabas
        int p = 0, p1 = 0;
        string aux, vec;
        string auxL;

        //variables de las palabras
        int pcont = 0, pdim = 0;
        string[] pve = new string[50];
        string paux, pc;

        ClassMetodos objmet = new ClassMetodos();
        public winDeletreos()
        {
            InitializeComponent();
            dtLetra.Interval = TimeSpan.FromMilliseconds(750);
            dtSilaba.Interval = TimeSpan.FromMilliseconds(750);
            dtPalabra.Interval = TimeSpan.FromMilliseconds(750);
        }


        private void hablar(string dato)
        {
            speech.Speak(dato);
        }
        void dtPalabra_Tick(object sender, EventArgs e)
        {
            if (pcont < pdim - 1)
            {
                //medVoz.Source = new Uri(path + pve[pcont]);
                //medVoz.Play();
                hablar(pve[pcont]);
            }
            else
                dtPalabra.Stop();
            pcont++;
        }

        void dtSilaba_Tick(object sender, EventArgs e)
        {
            if (p1 <= vec.Length)
                p1 = p1 + objmet.posicion(vec, p1);

            if (p1 <= vec.Length)
            {
                for (int i = p; i < p1; i++)
                    aux = aux + vec[i];
                //medVoz.Source = new Uri(path + aux);
                //medVoz.Play();
                hablar(aux);
                aux = "";
                p = p1;
            }
            else
                dtSilaba.Stop();
        }


        void dtLetra_Tick(object sender, EventArgs e)
        {
            if (contL < letra.Length)
            {
                auxL = letra[contL].ToString();
                //medVoz.Source = new Uri(path + auxL);
                //medVoz.Play();
                hablar(auxL);
                //medVoz.Volume = 100;

            }
            else
            {
                dtLetra.Stop();
                //medVoz.Source = new Uri(path + "la palabra completa es" + letra);
                //medVoz.Play();
                hablar("la palabra completa es" + letra);
                //medVoz.Volume = 100;
            }
            contL++;
        }


        private void btnLetra_Click(object sender, RoutedEventArgs e)
        {
            contL = 0;
            letra = txtLetra.Text;

            dtLetra.Start();
            dtLetra.Tick += dtLetra_Tick;
        }

        private void btnSilaba_Click(object sender, RoutedEventArgs e)
        {
            p = 0; p1 = 0; aux = "";
            vec = txtSilaba.Text;

            dtSilaba.Start();
            dtSilaba.Tick += dtSilaba_Tick;
        }


        private void btnPalbra_Click(object sender, RoutedEventArgs e)
        {
            paux = txtPalabra.Text;
            pdim = 0;
            pcont = 0;
            cambio();

            dtPalabra.Start();
            dtPalabra.Tick += dtPalabra_Tick;
        }


        private void btnBorraLetra_Click(object sender, RoutedEventArgs e)
        {
            txtLetra.Text = "";
            txtSilaba.Text = "";
            txtPalabra.Text = "";
        }

        private void btnBorraSilaba_Click(object sender, RoutedEventArgs e)
        {
            txtLetra.Text = "";
            txtSilaba.Text = "";
            txtPalabra.Text = "";
        }

        private void btnBorraPalabra_Click(object sender, RoutedEventArgs e)
        {
            txtLetra.Text = "";
            txtSilaba.Text = "";
            txtPalabra.Text = "";
        }

        public void cambio()
        {
            for (int i = 0; i < paux.Length; i++)
            {
                if (paux[i] != ' ')
                    pc = pc + paux[i];

                if (paux[i] == ' ' || i == paux.Length - 1)
                {
                    pve[pdim] = pc;
                    pdim++;
                    pve[pdim] = "";
                    pdim++;
                    pc = "";
                }
            }
        }
    }
}