Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports System.Windows.Media

Namespace NestedDonutChart

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            If e.SeriesPoint.Value <= 10 Then
                e.DrawOptions.Color = Color.FromArgb(&HFF, &H51, &H89, &H03)
            ElseIf e.SeriesPoint.Value > 10 And e.SeriesPoint.Value <= 20 Then
                e.DrawOptions.Color = Color.FromArgb(&HFF, &HF9, &HAA, &H0F)
            ElseIf e.SeriesPoint.Value > 20 Then
                e.DrawOptions.Color = Color.FromArgb(&HFF, &HC7, &H39, &H0C)
            End If
        End Sub
    End Class
End Namespace
