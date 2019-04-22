Imports System
Imports System.IO
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Navigation
Imports System.Windows.Media.Effects

Partial Public Class Window1
    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()

        ' Insert code required on object creation below this point.
    End Sub


    Private Sub OpenInterruptScreen(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Interrupt.Visibility = Windows.Visibility.Visible

        Dim b As New BlurEffect
        b.Radius = 0.0
        ' Change to Guassian for better quality
        ' at the expense of performance
        ' (NOT RECOMMENDED!)
        b.KernelType = KernelType.Box
        Dim blurIn As New DoubleAnimation(5.0, TimeSpan.FromMilliseconds(50))

        LayoutRoot.Effect = b
        LayoutRoot.IsEnabled = False
        LayoutRoot.Effect.BeginAnimation(BlurEffect.RadiusProperty, blurIn)
    End Sub

    Private Sub CloseInterruptScreen(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Interrupt.Visibility = Windows.Visibility.Hidden
        LayoutRoot.Effect = Nothing
        LayoutRoot.IsEnabled = True
    End Sub

    Private Sub ShowCustomMessageBox(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim f As New AlphaMessageBoxHandler
        f.Show("This is a custom Message Box. To launch it, all you have to do is create a new instance of the AlphaMessageBoxHandler class, and call the 'Show' method and use it like the normal MessageBox.Show() function.", "Odyssey Dog UX Kit - Custom Message Box", MessageBoxButton.YesNoCancel)
    End Sub
End Class
