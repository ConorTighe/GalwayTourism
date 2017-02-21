﻿using System;
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
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.theskeff.ie/"));
        }
    }
}