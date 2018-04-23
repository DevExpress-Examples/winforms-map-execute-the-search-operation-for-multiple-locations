Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace GetSearchLocationAdditionalInfo
    Partial Public Class Form1
        Inherits Form

        Private Const yourBingKey As String = "Your Bing Key"
        Private map As MapControl
        Private searchProvider As BingSearchDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            PrepareMap()
            AddHandler searchProvider.SearchCompleted, AddressOf searchDataProvider_SearchCompleted
        End Sub



        Private Sub search_Click(ByVal sender As Object, ByVal e As EventArgs) Handles search.Click

            idx = 0
            asyncResult = Me.BeginInvoke(CType(AddressOf SearchAsync, DoSearch))
        End Sub

        Private Delegate Sub DoSearch()
        Private asyncResult As IAsyncResult
        Private idx As Integer = 0
        Private addresses As New List(Of String) From {"505 N. Brand Blvd, Glendale CA 91203, USA", "1111 N Brand Blvd, Glendale, CA 91202, USA", "300 N Brand Blvd, Glendale, CA 91203, USA"}
        Private Sub SearchAsync()
            Me.EndInvoke(asyncResult)
            If idx < addresses.Count Then
            searchProvider.Search(addresses(idx))
            idx += 1
            End If
        End Sub

        Private Sub searchDataProvider_SearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
            Dim result As SearchRequestResult = e.RequestResult
            If result.ResultCode = RequestResultCode.Success Then
                Dim regions As List(Of LocationInformation) = result.SearchResults

                For Each region_Renamed As LocationInformation In regions
                    AddPushpin(region_Renamed.Location)
                    If idx = addresses.Count Then
                        map.ZoomToFitLayerItems()
                    End If
                Next region_Renamed

                DisplayResults(e.RequestResult)
                asyncResult = Me.BeginInvoke(CType(AddressOf SearchAsync, DoSearch))
            End If

            If result.ResultCode = RequestResultCode.BadRequest Then
                tbResults.Text &= "The Bing Search service does not work for this location."
            End If

        End Sub

        Private Sub AddPushpin(ByVal geoPoint As GeoPoint)
            Dim pin As New MapPushpin()
            pin.Location = geoPoint

            Dim layer As VectorItemsLayer = CType(Me.map.Layers(2), VectorItemsLayer)

            CType(layer.Data, MapItemStorage).Items.Add(pin)
        End Sub

        Private Sub NavigateTo(ByVal geoPoint As GeoPoint)
            map.CenterPoint = geoPoint
            map.ZoomLevel = 15
        End Sub

        Private Sub DisplayResults(ByVal requestResult As SearchRequestResult)
            Dim resultList As New StringBuilder("")

            If requestResult.ResultCode = RequestResultCode.Success Then
                Dim resCounter As Integer = 1
                For Each resultInfo As LocationInformation In requestResult.SearchResults
                    resultList.Append(String.Format(vbLf & " Result {0}:  " & vbLf, resCounter))
                    resultList.Append(String.Format(resultInfo.DisplayName & vbLf))
                    resultList.Append(String.Format("Geographical coordinates:  {0}", resultInfo.Location))
                    resultList.Append(String.Format(vbLf & "______________________________" & vbLf))
                    resCounter += 1
                Next resultInfo


            End If
            tbResults.Text &= resultList.ToString()
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
            Dim tilesLayer As New ImageLayer()
            map.Layers.Add(tilesLayer)

            ' Create an information layer and add it to the map.
            Dim infoLayer As New InformationLayer()

            map.Layers.Add(infoLayer)

            Dim items As New VectorItemsLayer()
            items.Data = New MapItemStorage()
            map.Layers.Add(items)

            ' Create a Bing data provider and specify the Bing key.
            Dim bingProvider As New BingMapDataProvider()
            tilesLayer.DataProvider = bingProvider
            bingProvider.BingKey = yourBingKey

            ' Create a Bing search data provider and specify the Bing key.
            searchProvider = New BingSearchDataProvider()
            infoLayer.DataProvider = searchProvider
            searchProvider.GenerateLayerItems = False
            searchProvider.BingKey = yourBingKey
            map.ShowSearchPanel = False
        End Sub
    End Class
End Namespace