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
    public sealed partial class Feed : Page
    {
        public Feed()
        {
            this.InitializeComponent();
        }

        private void SparchLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2741, Longitude = -9.0500 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void SparchInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://galwaycity.galway-ireland.ie/spanish-arch.htm"));
        }

        private void MuseumLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2697, Longitude = -9.0537 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void MuseumInfo_Click(object sender, RoutedEventArgs e)
        {

            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.galwaycitymuseum.ie/"));
        }

        private void ChurchLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2727, Longitude = -9.0538 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void ChruchInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.stnicholas.ie/"));
        }

        private void EyreLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2740, Longitude = -9.0497 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void EyreInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://en.wikipedia.org/wiki/Eyre_Square"));
        }

        private async void DunguaireInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.shannonheritage.com/DaytimeAttractions/DunguaireCastle/"));
        }

        private void DunguaireLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.1422, Longitude = -8.9261 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void CathedraInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.galwaycathedral.ie/"));
        }

        private void CathedraLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2751, Longitude = -9.0575 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void JamesMitchellInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.nuigalway.ie/visitorsgeologymuseum/"));
        }

        private void JamesMitchellLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2775, Longitude = -9.0618 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void wallsInfo_Click(object sender, RoutedEventArgs e)
        {

            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.eyresquarecentre.com/galways-medieval-walls/"));
        }

        private void wallsLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2731, Longitude = -9.0498 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void redInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.discoverireland.ie/Arts-Culture-Heritage/hall-of-the-red-earl/92102"));
        }

        private void redLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2710, Longitude = -9.0536 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }
    }
}
