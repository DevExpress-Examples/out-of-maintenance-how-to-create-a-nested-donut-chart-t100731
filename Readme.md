<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569515/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T100731)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/NestedDonutChart/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/NestedDonutChart/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/NestedDonutChart/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/NestedDonutChart/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create a Nested Donut chart

The following example demonstrates how to create a [Nested Donut](https://docs.devexpress.com/WPF/17090/controls-and-libraries/charts-suite/chart-control/fundamentals/series-fundamentals/2d-series-types/pie-and-donut-series/nested-donut?p=netframework) chart. 

To do this, it is necessary to assign the [ChartControl.Diagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.Diagram?p=netframework) property to [SimpleDiagram2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.SimpleDiagram2D?p=netframework), and then add two [NestedDonutSeries2D](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.NestedDonutSeries2D?p=netframework) objects with points to the diagram's [Series](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.Diagram.Series?p=netframework) collection.

Also, this example shows how to change the color of each series point according to its values using the [ChartControl.CustomDrawSeriesPoint](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl.CustomDrawSeriesPoint?p=netframework) event. As a result, segments of an outer donut representing kinds of products are colored with a specific Product group color (an inner donut).

