Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace GetSearchLocationAdditionalInfo

    Partial Public Class Form1
        Inherits Form

        Const yourAzureKey As String = "Your Azure key here."

        Private map As MapControl

        Private searchProvider As AzureSearchDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PrepareMap()

            AddHandler Me.searchProvider.SearchCompleted, AddressOf SearchProvider_SearchCompleted
        End Sub

        Private Sub SearchProvider_SearchCompleted(ByVal sender As Object, ByVal e As AzureSearchCompletedEventArgs)
            Dim result As SearchRequestResult = e.RequestResult
            If result.ResultCode = RequestResultCode.Success Then
                Dim regions As List(Of LocationInformation) = result.SearchResults
                For Each region As LocationInformation In regions
                    AddPushpin(region.Location)
                    If idx = addresses.Count Then map.ZoomToFitLayerItems()
                Next

                DisplayResults(e.RequestResult)
                asyncResult = Me.BeginInvoke(CType(AddressOf SearchAsync, DoSearch))
            End If

            If result.ResultCode = RequestResultCode.BadRequest Then tbResults.Text += "The Azure Search service does not work for this location."
        End Sub

        Private Sub search_Click(ByVal sender As Object, ByVal e As EventArgs)
            idx = 0
            asyncResult = Me.BeginInvoke(CType(AddressOf SearchAsync, DoSearch))
        End Sub

        Friend Delegate Sub DoSearch()

        Private asyncResult As IAsyncResult

        Private idx As Integer = 0

        Private addresses As List(Of String) = New List(Of String) From {"505 N. Brand Blvd, Glendale CA 91203, USA", "1111 N Brand Blvd, Glendale, CA 91202, USA", "300 N Brand Blvd, Glendale, CA 91203, USA"}

        Private Sub SearchAsync()
            Me.EndInvoke(asyncResult)
            If idx < addresses.Count Then searchProvider.Search(addresses(System.Math.Min(System.Threading.Interlocked.Increment(idx), idx - 1)))
        End Sub

        Private Sub AddPushpin(ByVal geoPoint As GeoPoint)
            Dim pin As MapPushpin = New MapPushpin()
            pin.Location = geoPoint
            Dim layer As VectorItemsLayer = CType(map.Layers(2), VectorItemsLayer)
            CType(layer.Data, MapItemStorage).Items.Add(pin)
        End Sub

        Private Sub DisplayResults(ByVal requestResult As SearchRequestResult)
            Dim resultList As New StringBuilder("")
            If requestResult.ResultCode = RequestResultCode.Success Then
                Dim resCounter As Integer = 1
                For Each resultInfo As LocationInformation In requestResult.SearchResults
                    resultList.Append([String].Format(Microsoft.VisualBasic.Constants.vbLf & " Result {0}:  " & Microsoft.VisualBasic.Constants.vbLf, resCounter))
                    resultList.Append([String].Format(resultInfo.DisplayName & Microsoft.VisualBasic.Constants.vbLf))
                    resultList.Append([String].Format("Geographical coordinates:  {0}", resultInfo.Location))
                    resultList.Append([String].Format(Microsoft.VisualBasic.Constants.vbLf & "______________________________" & Microsoft.VisualBasic.Constants.vbLf))
                    resCounter += 1
                Next
            End If

            tbResults.Text += resultList.ToString()
        End Sub

        Private Sub PrepareMap()
            ' Create a map control.
            map = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the map control to the window.
            Me.Controls.Add(map)
            ' Bring the map to the front.
            map.BringToFront()
            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As ImageLayer = New ImageLayer()
            map.Layers.Add(tilesLayer)
            ' Create an information layer and add it to the map.
            Dim infoLayer As InformationLayer = New InformationLayer()
            map.Layers.Add(infoLayer)
            Dim items As VectorItemsLayer = New VectorItemsLayer()
            items.Data = New MapItemStorage()
            map.Layers.Add(items)
            ' Create an Azure data provider and specify the Azure key.
            Dim azureProvider As AzureMapDataProvider = New AzureMapDataProvider()
            tilesLayer.DataProvider = azureProvider
            azureProvider.Tileset = AzureTileset.BaseLabelsRoad Or AzureTileset.Imagery
            azureProvider.AzureKey = yourAzureKey
            ' Create an Azure search data provider and specify the Azure key.
            searchProvider = New AzureSearchDataProvider With {.GenerateLayerItems = False, .AzureKey = yourAzureKey}
            infoLayer.DataProvider = searchProvider
            map.SearchPanelOptions.Visible = False
        End Sub
    End Class
End Namespace
