using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GalwayTouristGuide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Nightlife : Page
    {
        public Nightlife()
        {
            this.InitializeComponent();
        }

        private async void rosinInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.roisindubh.net/"));
        }

        private void rosinLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2702, Longitude = -9.0581 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void frontInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.frontdoorpub.com/"));
        }

        private void frontLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2716, Longitude = -9.0536 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void pucanInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://anpucan.ie/"));
        }

        private void pucanLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2746, Longitude = -9.0474 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void karmaInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.karma.ie/"));
        }

        private void karmaLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2739, Longitude = -9.0503 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void carbonInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.carbongalway.ie/"));
        }

        private void carbonLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2744, Longitude = -9.0526 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void electricInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.electricgalway.com/"));
        }

        private void elecLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2738, Longitude = -9.0529 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void haloInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.halonightclub.com/"));
        }

        private void haloLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2736, Longitude = -9.0526 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void kingsInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.thekingshead.ie/"));
        }

        private void KingsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2722, Longitude = -9.0534 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }
    }
}
