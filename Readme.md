<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581528/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2396)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/EmptyWinApp/Form1.cs) (VB: [Form1.vb](./VB/EmptyWinApp/Form1.vb))
<!-- default file list end -->
# How to add and remove items from the filter drop-down list


<p>The following example shows how to add and remove items from the filter dropdown list.</p><p>In this example, the 'Beverages' item is hidden from the filter dropdown list of the Category field, and a dummy item is created and added to the list. To do this, the CustomFilterPopupItems event is handled. In the event handler, the 'Beverages' item is removed from the event parameter's Items collection, and a new item ('Dummy Item') is added to the collection.</p>

<br/>


