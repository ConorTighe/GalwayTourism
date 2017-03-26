using GalwayTouristGuide.Common;
using System;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GalwayTouristGuide
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MapView : Page
    {
       //Library class is required to use map
        public Library Library = new Library();
        public int indexPosition = 1;

        public MapView()
        {
            this.InitializeComponent();
        }

        private void addIconToLocation(Geopoint location, string name)
        {

            //Create Icon and Add text to map
            MapIcon mapIcon = new MapIcon();
            mapIcon.Location = location;
            mapIcon.Title = String.Format("{0}\nLatLng:{1}\nLongLng:{2}", name, location.Position.Latitude, location.Position.Longitude);

        }

        private async void ShowRouteOnMap(Geopoint startPoint, Geopoint endPoint)
        {
            //Creates the coloured trail to guide the user using there GPS
            MapRouteFinderResult routeResult = await MapRouteFinder.GetDrivingRouteAsync(
                startPoint, endPoint,
                MapRouteOptimization.Time,
                MapRouteRestrictions.None);

            // Do the following if maps route is found
            if (routeResult.Status == MapRouteFinderStatus.Success)
            {
                myMap.Routes.Clear(); 
                MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                viewOfRoute.RouteColor = Colors.Yellow;
                viewOfRoute.OutlineColor = Colors.Black;

                myMap.Routes.Add(viewOfRoute);
                await myMap.TrySetViewBoundsAsync(routeResult.Route.BoundingBox, null, MapAnimationKind.None);

            }
            else
            {
                // Handle the error of no map route
                var message = new MessageDialog("Can't find routes");
                await message.ShowAsync();
            }
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            /* This function sets up the map, calls our functions and 
            * create the path that guides the user when we arrive on the page */
            Geopoint Destination = (Geopoint)e.Parameter;
            Geopoint myPoint = await Library.Position();
            myMap.ZoomLevel = 16;
            myMap.Center = myPoint;
            indexPosition++;
            ShowRouteOnMap(myPoint, Destination);

            Geopoint position = await Library.Position();
            DependencyObject marker = Library.Marker();
            myMap.Children.Add(marker);
            MapControl.SetLocation(marker, position);
            MapControl.SetNormalizedAnchorPoint(marker, new Point(0.5, 0.5));
            myMap.ZoomLevel = 12;
            myMap.Center = position;

        }
    }
}
