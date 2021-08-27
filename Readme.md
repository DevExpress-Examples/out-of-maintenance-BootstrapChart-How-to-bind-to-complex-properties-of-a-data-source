<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/257517164/19.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T881962)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# BootstrapChart - How to bind to complex properties of a data source

There are cases when you need to bind the [Bootstrap Chart](https://demos.devexpress.com/Bootstrap/Charts/Default.aspx) control to a server-side data source control (such as EntityDataSource, ObjectDataCource). These data sources may return objects with complex properties. This example demonstrates how to bind a chart to such data (we use ObjectDataSource as an example). The main idea is to reorganize a collection of objects retrieved from a data source into a new collection with plain object properties and then bind your Bootstrap Chart to this new collection.

_Files to look at_: 
 - [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
 - [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
 - [DSProvider.cs](./CS/WebSite/App_Code/DSProvider.cs) (VB: [DSProvider.vb](./VB/WebSite/App_Code/DSProvider.vb))
