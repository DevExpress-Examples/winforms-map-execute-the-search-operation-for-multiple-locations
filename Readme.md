<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576743/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T546604)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GetSearchLocationAdditionalInfo/Form1.cs) (VB: [Form1.vb](./VB/GetSearchLocationAdditionalInfo/Form1.vb))
<!-- default file list end -->
# How to perform the Search operation for multiple locations


The <a href="https://documentation.devexpress.com/windowsforms/16711/Controls-and-Libraries/Map-Control/GIS-Data/Search">Search</a> operation is executed in an asynchronous manner and the next Search operation cannot be invoked while waiting for the result from the previous Search request. To resolve this issue, include subsequent Search method calls into the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraMap.BingSearchDataProvider.SearchCompleted.event">SearchCompleted</a> event handler.

<br/>


