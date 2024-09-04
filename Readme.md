<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576743/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T546604)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Map - How to Execute the Search Operation for Multiple Locations

Initially, the [Search](https://documentation.devexpress.com/windowsforms/16711/Controls-and-Libraries/Map-Control/GIS-Data/Search) operation is executed in an asynchronous manner and the next Search operation cannot be invoked while waiting for the result from the previous Search request. This example shows how to resolve this issue and include subsequent Search method calls into the [SearchCompleted](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraMap.BingSearchDataProvider.SearchCompleted.event) event handler.

## Files to Review

* [Form1.cs](./CS/GetSearchLocationAdditionalInfo/Form1.cs) (VB: [Form1.vb](./VB/GetSearchLocationAdditionalInfo/Form1.vb))

## Documentation

* [Search](https://docs.devexpress.com/WindowsForms/16711/controls-and-libraries/map-control/gis-data/search)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-execute-the-search-operation-for-multiple-locations&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-execute-the-search-operation-for-multiple-locations&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
