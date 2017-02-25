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
    public sealed partial class Sports : Page
    {
        public Sports()
        {
            this.InitializeComponent();
        }

        private async void connInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.connachtrugby.ie/mobile-fixtures/"));
        }

        private void connLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2795, Longitude = -9.0401 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void fcInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://galwayunitedfc.ie/fixtures-results/"));
        }

        private void fcLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2845, Longitude = -9.0563 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void gaelicInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.galwaygaa.ie/index.php/en/fixtures-this-week"));
        }

        private void gaelicLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2632, Longitude = -9.0843 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void raceInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.galwayraces.com/"));
        }

        private void raceLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2982, Longitude = -8.9968 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void hurlingLoc_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.galwaygaa.ie/index.php/en/current-hurling"));
        }

        private void hurlingInfo_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2632, Longitude = -9.0843 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }
    }
}
