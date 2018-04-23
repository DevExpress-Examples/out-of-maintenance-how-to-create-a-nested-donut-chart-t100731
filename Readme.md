# How to create a Nested Donut chart


<p>The following example demonstrates how to create a<strong> Nested Donut </strong>chart. <br />To do this, it is necessary to assign the <a href="http://larix/ReferenceBrowserMain_14_1/LoadItem.aspx?Member=P%3aDevExpress.Xpf.Charts.ChartControl.Diagram&Template=MemberPropertyTopic">ChartControl.Diagram</a> property to <a href="http://larix/ReferenceBrowserMain_14_1/LoadItem.aspx?Member=T%3aDevExpress.Xpf.Charts.SimpleDiagram2D&Template=ClassTopic">SimpleDiagram2D</a>, and then add two <strong>NestedDonutSeries2D</strong> objects with points to the diagram's <a href="http://larix/ReferenceBrowserMain_14_1/LoadItem.aspx?Member=P%3aDevExpress.Xpf.Charts.Diagram.Series&Template=MemberPropertyTopic">Diagram.Series</a> collection.<br />Also, this example shows how to change the color of each series point according to its values using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_CustomDrawSeriesPointtopic">ChartControl.CustomDrawSeriesPoint</a> event. As a result, segments of an outer donut representing kinds of products are colored with a specific Product group color (an inner donut).</p>

<br/>


