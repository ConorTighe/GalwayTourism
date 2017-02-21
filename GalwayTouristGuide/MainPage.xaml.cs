using GalwayTouristGuide.Assets;
using GalwayTouristGuide.Common;
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
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GalwayTouristGuide
{
  
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Feed));
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void LandmarksBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Feed));
        }

        private void FoodBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Food));
        }

        private void HotelBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Hotels));
        }
    }
}
