using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using EcuaVoiceMobile.Resources;

namespace EcuaVoiceMobile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        private void btnParesMinimos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winParesMinimos.xaml", UriKind.Relative));
        }

        private void btnLector_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winLector.xaml", UriKind.Relative));
        }

        private void btnTrabalenguas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winTrabalenguas.xaml", UriKind.Relative));
        }

        private void btnRimas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winRimas.xaml", UriKind.Relative));
        }

        private void btnSilabasCompuestas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winSilabasCompuestas.xaml", UriKind.Relative));
        }    

        private void btnDeletreos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winDeletreos.xaml", UriKind.Relative));
        }

        private void btnComunicador_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winComunicador.xaml", UriKind.Relative));
        }

        private void btnfonemas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/winFonemass.xaml", UriKind.Relative));
        }
    }
}