using GalwayTouristGuide.Assets;
using System;
using Windows.Foundation;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GalwayTouristGuide
{

    public sealed partial class MainPage : Page
    {
        public static MediaPlayer BackgroundPlayer;

        public MainPage()
        {
            
            this.InitializeComponent();

            // Sets the size of the window on open
            ApplicationView.PreferredLaunchViewSize = new Size(432, 768);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            //Background music
            BackgroundPlayer = new MediaPlayer();
            BackgroundPlayer.Source = MediaSource.CreateFromUri(new Uri(@"ms-appx:///Assets/bensound-sweet.mp3"));
            BackgroundPlayer.Play();
            BackgroundPlayer.IsLoopingEnabled = true;

            //Move around the pages
            MyFrame.Navigate(typeof(Feed));
        }

        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            // Opening and closing menu
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void LandmarksBtn_Click(object sender, RoutedEventArgs e)
        {
            // class for navigating to landmarks
            MyFrame.Navigate(typeof(Feed));
        }

        private void FoodBtn_Click(object sender, RoutedEventArgs e)
        {
            // class for navigating to restaraunts
            MyFrame.Navigate(typeof(Food));
        }

        private void HotelBtn_Click(object sender, RoutedEventArgs e)
        {
            // class for navigating to hotels
            MyFrame.Navigate(typeof(Hotels));
        }

        private void NightBtn_Click(object sender, RoutedEventArgs e)
        {
            // class for navigating to nightlife
            MyFrame.Navigate(typeof(Nightlife));
        }

        private async void EventsBtn_Click(object sender, RoutedEventArgs e)
        {
            //Upcoming events link
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.galwaytourism.ie/pgalway-events-calendar.html"));
        }

        private async void Githubbtn_Click(object sender, RoutedEventArgs e)
        {
            // link to my github
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://github.com/ConorTighe1995/GalwayTourism"));
        }

        private void SportsBtn_Click(object sender, RoutedEventArgs e)
        {
            //Sports link
            MyFrame.Navigate(typeof(Sports));
        }

        private void Todobtn_Click(object sender, RoutedEventArgs e)
        {
            // to listings
            MyFrame.Navigate(typeof(Todo));
        }
    }
}
