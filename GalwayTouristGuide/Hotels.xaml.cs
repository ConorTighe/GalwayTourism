using System;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GalwayTouristGuide.Assets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Hotels : Page
    {
        public Hotels()
        {
            this.InitializeComponent();
        }

        /* The Loc_Click functions use Giopoints to set the desired location using custom coordinates for each place,
         * The Info_Click functions are used to bring the user to a page with more information and acts as a resource from where I go the info */

        private async void radInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.radissonhotelgalway.com/"));
        }

        private void radLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2742, Longitude = -9.0438 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void RadBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/radisson-sas-spa-galway.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-41381_dev-desktop_los-1_bw-13_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-13_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-41381&"));
        }

        private async void RadExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.660779.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=660779"));
        }

        private async void RadHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=208227"));
        }

        private async void RadRadison_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.radissonblu.com/reservation/itineraryEntrance.do?csref=agn_pfx_meta_ghf_bid_Glocal_MSYRF_hpa_GWYZH&endDate=20170306&facilitatorId=GOOGLEHPAREZIDOR&hotelCode=GWYZH&numberAdults=2&numberChildren=0&startDate=20170305&rateSortFilter=(sort(availableRates))"));
        }

        private async void Harbour_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.harbour.ie/en/reservations/?nn=1&utm_campaign=Gha_867&utm_medium=integration&hotel_id=867&user_currency=EUR&dlink_f=5&service_model=2&guide_id=2&date_in=2017-03-05&user_language=en&date_out=2017-03-06&utm_source=google&utm_content=IE_Harbour"));
        }

        private async void HarbourHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=276670"));
        }

        private async void HarbourExpedia_Click_1(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.583248.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#destination=Galway+(county),+Ireland&startDate=05/03/2017&endDate=06/03/2017&adults=2&regionId=603082&selected=583248&inventory=regular&sort=guestRating"));
        }

        private async void HarbourBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/harbourgalway.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-229267_dev-desktop_los-1_bw-13_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-13_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-229267&"));
        }

        private async void TheGSite_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/the-g.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-40821_dev-desktop_los-1_bw-13_dow-Sunday_room-4082101_92001951_0_1_0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&sb_price_type=total&show_room=4082101&type=total&utm_campaign=IE&utm_content=los-1_bw-13_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-40821&"));
        }

        private async void FlanBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.google.ie/url?sa=t&rct=j&q=&esrc=s&source=web&cd=8&cad=rja&uact=8&ved=0ahUKEwiC-IbwqKHSAhWLVRQKHc5kD64QwTEIJigFMAc&url=https%3A%2F%2Fwww.google.com%2Ftravel%2Fclk%3Fpc%3DhwAAAE3MJn-CI26NJWrZbtwwwKq2C94V6r_O69pkiBYXHlKVTP2VNcP4PpWXILExYZLJMoiZoIW3UDMRJkN_AwmE16xNmV_JNlS2Y1uQKcYg6PXVOGqk-vwT5_or9LzkcLOu7M9CWNZMSPHp4Vh_RtodWaLcqSp5Q409UkvI8rS7XHw2Cqoonp7w6dcaV8Bm5MXeEw&usg=AFQjCNE-ze4mG8cGEupZO6LDTppJiFuzgg&sig2=y4YbmPF44a1q1P_R4VP9EQ&bvm=bv.147448319,d.bGg"));
        }

        private async void FlanExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.1993.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=1993"));
        }

        private async void FlanAmoma_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.amoma.com/hotel.php?key=201703052017030612050000005000000500001111113613&id=8744&referer=06658ghpullaHty5C&langid=1&curid=EUR&exchange-rate=1.0000&session-key=LSEtU0ZuZUl1WlhBcTA1azh0UVFjUmY0M2drai9sZlQ3b3Z0UFZyK0dYRmcrcDJmdmhyZ1NpWkNkTXNkbnRxSTcwQ08zSzhTVU9OWGRQYWUwNUUzdDZoRTN3Ly81MjRDaWNtVVdLOWxmekhJTkU9&reqsource=2&clickThroughId=582494927"));
        }

        private async void connBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/the-connacht-hotel.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-220491_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-220491&"));
        }

        private async void connExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.16232.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=16232"));
        }

        private async void connGala_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.galahotels.com/en/Hotel/ireland_109/galway_10542/the_connacht_135389?sid=102885286&hc=1&ppn=1&psort=popularity&utm_source=googlehotelads&utm_medium=Meta&utm_campaign=#available-rooms"));
        }

        private async void JuryBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/jurys-inn-galway.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-40434_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-40434&"));
        }

        private async void JuryHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=183517"));
        }

        private async void JuryGala_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.galahotels.com/en/Hotel/ireland_109/galway_10542/jurys_inn_galway_135365?sid=102888841&hc=1&ppn=1&psort=popularity&utm_source=googlehotelads&utm_medium=Meta&utm_campaign=#available-rooms"));
        }

        private async void SaltBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/salthill.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-40978_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-40978&"));
        }

        private async void SaltHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=278833"));
        }

        private async void SaltGala_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.2360434.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=2360434"));
        }

        private async void BayBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/galwaybaysalthill.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-126294_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-126294&"));
        }

        private async void BayHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?f-hotel-id=178581&destination-id=697179&q-check-out=2017-03-06&q-room-0-adults=2&q-rooms=1&q-check-in=2017-03-05&q-room-0-children=0&pos=HCOM_IE&wapa7=178581&hotelid=178581&locale=en_IE&rffrid=sem.hcom.IE.156.003.localuniversal.02.desktop-1.kwrd%3DGGMETA.178581IEen-20170305-D"));
        }

        private async void BayExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.106984.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=106984"));
        }

        private async void ParkBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/park-house.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-40498_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-40498&"));
        }

        private async void ParkHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=238650"));
        }

        private async void ParkExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.1404798.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=1404798"));
        }

        private async void ClayBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/clayton.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-40317_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-40317&"));
        }

        private async void ClayHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?f-hotel-id=272453&destination-id=697179&q-check-out=2017-03-06&q-room-0-adults=2&q-rooms=1&q-check-in=2017-03-05&q-room-0-children=0&pos=HCOM_IE&wapa7=272453&hotelid=272453&locale=en_IE&rffrid=sem.hcom.IE.156.003.localuniversal.02.desktop-1.kwrd%3DGGMETA.272453IEen-20170305-D"));
        }

        private async void ClayExpedia_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.expedia.ie/Hotel-Search?mdpdtl=HTL.2166715.20170305.20170306.DDT&mctc=10&room1=2&MDPCID=IE.META.HPA.HOTEL-CORESEARCH-localuniversal.HOTEL.desktop#startDate=05%2F03%2F2017&endDate=06%2F03%2F2017&selected=2166715"));
        }

        private async void travelBooking_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.booking.com/hotel/ie/bookingstravelodge.en-gb.html?aid=356998;label=adtechgdynamic-link-localuniversalIE-hotel-231446_dev-desktop_los-1_bw-12_dow-Sunday_room-0_lang-en_curr-EUR;sid=a805c272b1d425eb64ffe2882f55a3a1;checkin=2017-03-05&checkout=2017-03-06&dist=0&group_adults=2&no_rooms=1&sb_price_type=total&type=total&utm_campaign=IE&utm_content=los-1_bw-12_dow-Sunday_lang-en_curr-EUR&utm_medium=localuniversal&utm_source=adtechgdynamic&utm_term=hotel-231446&"));
        }

        private async void travelHotels_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://ie.hotels.com/search.do?resolved-location=CITY%3A697179%3AUNKNOWN%3AUNKNOWN&destination-id=697179&q-destination=Galway,%20Ireland&q-check-in=2017-03-05&q-check-out=2017-03-06&q-rooms=1&q-room-0-adults=2&q-room-0-children=0&f-hotel-id=212893"));
        }

        private async void travelgala_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.galahotels.com/en/Hotel/ireland_109/galway_10542/travelodge_galway_city_135407?sid=102926553&hc=1&ppn=1&psort=popularity&utm_source=googlehotelads&utm_medium=Meta&utm_campaign=#available-rooms"));
        }

        private async void HarbourInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.harbour.ie/"));
        }

        private void HarbourLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2708, Longitude = -9.0477 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void TheGInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.theghotel.ie/"));
        }

        private void TheGLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2821, Longitude = -9.0329 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void FlanInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.flanneryshotelgalway.com/"));
        }

        private void FlanLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2781, Longitude = -9.0149 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void ConnInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.theconnacht.ie/"));
        }

        private void connLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.8376, Longitude = -8.9584 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void JuryInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.jurysinns.com/hotels/galway"));
        }

       
        private void JuryLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2708, Longitude = -9.0546 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void SalthillInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.salthillhotel.com/en/"));
        }

        private void SalthillLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2586, Longitude = -9.0873 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void BayInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.galwaybayhotel.net/"));
        }

        private void BayLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2582, Longitude = -9.0849 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void ParkInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.parkhousehotel.ie/"));
        }

        private void ParkLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2745, Longitude = -9.0467 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void ClayInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.claytonhotelgalway.ie/"));
        }

        private void ClayLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2913, Longitude = -8.9893 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }

        private async void travelInfo_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://www.travelodge.ie/hotels/252/Galway-City-hotel"));
        }

        private void travelLoc_Click(object sender, RoutedEventArgs e)
        {
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 53.2828, Longitude = -9.0363 };
            Geopoint cityCenter = new Geopoint(cityPosition);
            MyFrame.Navigate(typeof(MapView), cityCenter);
        }
    }
}
