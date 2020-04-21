# BootstrapChart - How to bind to complex properties of a data source

There are cases when you need to bind the [Bootstrap Chart](https://demos.devexpress.com/Bootstrap/Charts/Default.aspx) control to a server-side data source control (such as EntityDataSource, ObjectDataCource). These data sources may return objects with complex properties. This example demonstrates how to bind a chart to such data (we use ObjectDataSource as an example). The main idea is to reorganize a collection of objects retrieved from a data source into a new collection with plain object properties and then bind your Bootstrap Chart to this new collection.

_Files to look at_: 
 - [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
 - [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
 - [DSProvider.cs](./CS/WebSite/App_Code/DSProvider.cs) (VB: [DSProvider.vb](./VB/WebSite/App_Code/DSProvider.vb))
