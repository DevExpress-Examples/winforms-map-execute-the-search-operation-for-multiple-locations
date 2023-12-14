' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066
' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066
' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. All search parameters are passed to the
' Search method and you can see the result in the rich text box element. The
' results contain a display name, and address associated with the search location.
' In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066
' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location and keywords using
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location and a keyword) in the custom Search
' panel and click the Search button. This handles the search_Click event and all
' search parameters are passed to the Search method and you can see the result in
' the rich text box element. The results contain a display name, and address
' associated with the search location. In addition, the
' SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Note that if you
' run this sample as is, you will get a warning message saying that the specified
' Bing Maps key is invalid. To learn how to register a Bing Maps account and
' create a key for it, refer to the How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066
' Developer Express Code Central Example:
' How to get additional search results using the Bing Map Search service
' 
' This example demonstrates how to provide search for location, keywords and other
' additional parameters using the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method. In this example, the built-in Search panel is disabled (the
' BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false), because a custom panel is used instead. To start
' search, specify search parameters (location, a keyword, start search index,
' geographical point coordinates) in the custom Search panel and click the Search
' button. This handles the search_Click event and all search parameters are passed
' to the Search method and you can see the result in the rich text box element.
' The results contain a display name, entity type and address associated with the
' search location. In addition, the SearchRequestResult.AlternateSearchRegions
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_AlternateSearchRegionstopic)
' property returns results of searching for alternate regions. Moreover, you can
' see search request information returned by the RequestResultBase.ResultCode
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapRequestResultBase_ResultCodetopic),
' RequestResultBase.FaultReason
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapRequestResultBase_FaultReasontopic)
' and SearchRequestResult.EstimatedMatches
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchRequestResult_EstimatedMatchestopic)
' properties. Note that if you run this sample as is, you will get a warning
' message saying that the specified Bing Maps key is invalid. To learn how to
' register a Bing Maps account and create a key for it, refer to the How to: Get a
' Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5066
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace GetSearchLocationAdditionalInfo.Properties

    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>
        Friend Sub New()
        End Sub

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared ReadOnly Property ResourceManager As Global.System.Resources.ResourceManager
            Get
                If(GetSearchLocationAdditionalInfo.Properties.Resources.resourceMan Is Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(GetSearchLocationAdditionalInfo.Properties.Resources).Assembly)
                    GetSearchLocationAdditionalInfo.Properties.Resources.resourceMan = temp
                End If

                Return GetSearchLocationAdditionalInfo.Properties.Resources.resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Shared Property Culture As Global.System.Globalization.CultureInfo
            Get
                Return GetSearchLocationAdditionalInfo.Properties.Resources.resourceCulture
            End Get

            Set(ByVal value As Global.System.Globalization.CultureInfo)
                GetSearchLocationAdditionalInfo.Properties.Resources.resourceCulture = value
            End Set
        End Property
    End Class
End Namespace
