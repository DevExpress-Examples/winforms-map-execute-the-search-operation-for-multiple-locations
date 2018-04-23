
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace GetSearchLocationAdditionalInfo {
    public partial class Form1 : Form {

        const string yourBingKey = "Your Bing Key";
        MapControl map;
        BingSearchDataProvider searchProvider;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PrepareMap();
            searchProvider.SearchCompleted +=
                new BingSearchCompletedEventHandler(searchDataProvider_SearchCompleted);
        }

      

        private void search_Click(object sender, EventArgs e) {

            idx = 0;
            asyncResult = this.BeginInvoke((DoSearch)SearchAsync);
        }

        delegate void DoSearch();
        IAsyncResult asyncResult;
        int idx = 0;
        List<string> addresses = new List<string> {"505 N. Brand Blvd, Glendale CA 91203, USA", 
            "1111 N Brand Blvd, Glendale, CA 91202, USA", "300 N Brand Blvd, Glendale, CA 91203, USA" };
        void SearchAsync()
        {
            this.EndInvoke(asyncResult);
            if (idx < addresses.Count)
            searchProvider.Search(addresses[idx++]);
        }

        private void searchDataProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            SearchRequestResult result = e.RequestResult;
            if (result.ResultCode == RequestResultCode.Success) {
                List<LocationInformation> regions = result.SearchResults;
                foreach (LocationInformation region in regions) { 
                    AddPushpin(region.Location);
                    if (idx == addresses.Count)
                        map.ZoomToFitLayerItems();
                }

                DisplayResults(e.RequestResult);
                asyncResult = this.BeginInvoke((DoSearch)SearchAsync);
            }

            if (result.ResultCode == RequestResultCode.BadRequest)
                tbResults.Text += "The Bing Search service does not work for this location.";

        }

        private void AddPushpin(GeoPoint geoPoint)
        {
            MapPushpin pin = new MapPushpin();
            pin.Location = geoPoint;

            VectorItemsLayer layer = (VectorItemsLayer)this.map.Layers[2];

            ((MapItemStorage)layer.Data).Items.Add(pin);
        }

        void NavigateTo(GeoPoint geoPoint) {
            map.CenterPoint = geoPoint;
            map.ZoomLevel = 15;
        }

        private void DisplayResults(SearchRequestResult requestResult) {
            StringBuilder resultList = new StringBuilder("");

            if (requestResult.ResultCode == RequestResultCode.Success) {
                int resCounter = 1;
                foreach (LocationInformation resultInfo in requestResult.SearchResults) {
                    resultList.Append(String.Format("\n Result {0}:  \n", resCounter));
                    resultList.Append(String.Format(resultInfo.DisplayName + "\n"));
                    resultList.Append(String.Format("Geographical coordinates:  {0}", resultInfo.Location));
                    resultList.Append(String.Format("\n______________________________\n"));
                    resCounter++;
                }

  
            }
            tbResults.Text += resultList.ToString();
        }

        private void PrepareMap() {
            // Create a map control.
            map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Bring the map to the front.
            map.BringToFront();

            // Create an image tiles layer and add it to the map.
            ImageLayer tilesLayer = new ImageLayer();
            map.Layers.Add(tilesLayer);

            // Create an information layer and add it to the map.
            InformationLayer infoLayer = new InformationLayer();
            
            map.Layers.Add(infoLayer);

            VectorItemsLayer items = new VectorItemsLayer();
            items.Data = new MapItemStorage();
            map.Layers.Add(items);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a Bing search data provider and specify the Bing key.
            searchProvider = new BingSearchDataProvider();
            infoLayer.DataProvider = searchProvider;
            searchProvider.GenerateLayerItems = false;
            searchProvider.BingKey = yourBingKey;
            map.ShowSearchPanel = false;
        }
    }
}