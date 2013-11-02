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
    public partial class winComunicador : PhoneApplicationPage
    {
        public static string path = "http://translate.google.com/translate_tts?tl=es&q=";
        public winComunicador()
        {
            InitializeComponent();
        }        

        private void SeleccionarPictograma(string palabra)
        {
            txbTexto.Text = txbTexto.Text + palabra + " ";
            //LeerBottonPalabra(palabra);
            //EmpezarNuevaPalabra();
        }

        private void btnQuiero_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("quiero");
        }

        private void btnYo_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Yo");
        }

        private void btnTu_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("tu");
        }

        private void btnEl_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("el");
        }

        private void btnElla_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("ella");
        }

        private void btnNoQuiero_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("no quiero");
        }

        private void btnComer_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("comer");
        }

        private void btnJugar_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("jugar");
        }

        private void btnAgua_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("agua");
        }

        private void btnGalletas_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("galletas");
        }

        private void btnLeche_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("leche");
        }

        private void btnSopa_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("sopa");
        }

        private void btnDondeesta_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Donde esta");
        }

        private void btnDondevamos_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Donde vamos");
        }

        private void btnQueDices_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Que dices");
        }

        private void btnQueeseso_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Que es eso");
        }

        private void btnHablar_Click(object sender, RoutedEventArgs e)
        {
            med1.Source = new Uri(path + txbTexto.Text);
            med1.Play();
            med1.Volume = 100;
            //med1.a
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txbTexto.Text = "";
        }
    }
}