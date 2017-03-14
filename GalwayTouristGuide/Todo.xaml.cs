using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Storage;
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
    public sealed partial class Todo : Page
    {
        StorageFolder localFolder = ApplicationData.Current.LocalFolder;
        StorageFile placesFile;
        string fileContents = "You have  visited no locations";
        public Todo()
        {
            this.InitializeComponent();
            PlacesSeen.Text = fileContents;
        }

        private async void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (await localFolder.GetFileAsync("Sites.txt") == null)
            {
                placesFile = await localFolder.CreateFileAsync("Sites.txt");
            }else
            {
                placesFile = await localFolder.GetFileAsync("Sites.txt");
            }
            fileContents = await FileIO.ReadTextAsync(placesFile);
            PlacesSeen.Text = fileContents;
        }
    }
}
