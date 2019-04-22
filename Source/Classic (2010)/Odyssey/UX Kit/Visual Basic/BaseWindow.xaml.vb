Imports System
Imports System.IO
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Navigation

Partial Public Class BaseWindow
	Public Sub New()
		MyBase.New()

		Me.InitializeComponent()

		' Insert code required on object creation below this point.
	End Sub

    Private Sub thumbDragWindow_DragDelta(ByVal sender As System.Object, ByVal e As System.Windows.Controls.Primitives.DragDeltaEventArgs)
        Me.Left = Me.Left + e.HorizontalChange
        Me.Top = Me.Top + e.VerticalChange
    End Sub

    Private Sub buttonClose_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub buttonMinimize_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub

End Class
