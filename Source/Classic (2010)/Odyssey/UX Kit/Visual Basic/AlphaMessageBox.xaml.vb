Imports System
Imports System.IO
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Navigation

Partial Public Class AlphaMessageBox

    Private m_alphaMessageBoxStyle As MessageBoxButton
    Public Property alphaMessageBoxStyle() As MessageBoxButton
        Get
            Return m_alphaMessageBoxStyle
        End Get
        Set(ByVal value As MessageBoxButton)
            m_alphaMessageBoxStyle = value
        End Set
    End Property

    Private m_MessageBoxResult As MessageBoxResult
    Public Property MessageResult() As MessageBoxResult
        Get
            Return m_MessageBoxResult
        End Get
        Set(ByVal value As MessageBoxResult)
            m_MessageBoxResult = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()

        ' Insert code required on object creation below this point.
    End Sub

    Private Sub thumbDragWindow_DragDelta(ByVal sender As System.Object, ByVal e As System.Windows.Controls.Primitives.DragDeltaEventArgs)
        Me.Left = Me.Left + e.HorizontalChange
        Me.Top = Me.Top + e.VerticalChange
    End Sub

    Private Sub buttonOK_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles buttonOK.Click
        Me.MessageResult = MessageBoxResult.OK
        Me.Hide()
    End Sub

    Private Sub buttonYes_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles buttonYes.Click
        Me.MessageResult = MessageBoxResult.Yes
        Me.Hide()
    End Sub

    Private Sub buttonNo_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles buttonNo.Click
        Me.MessageResult = MessageBoxResult.No
        Me.Hide()
    End Sub

    Private Sub buttonCancel_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles buttonCancel.Click
        Me.MessageResult = MessageBoxResult.Cancel
        Me.Hide()
    End Sub

    Private Sub AlphaMessageBox_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Select Case alphaMessageBoxStyle
            Case MessageBoxButton.OK
                buttonCancel.Visibility = Windows.Visibility.Collapsed
                buttonYes.Visibility = Windows.Visibility.Collapsed
                buttonNo.Visibility = Windows.Visibility.Collapsed
            Case MessageBoxButton.OKCancel
                buttonYes.Visibility = Windows.Visibility.Collapsed
                buttonNo.Visibility = Windows.Visibility.Collapsed
            Case MessageBoxButton.YesNo
                buttonOK.Visibility = Windows.Visibility.Collapsed
                buttonCancel.Visibility = Windows.Visibility.Collapsed
            Case MessageBoxButton.YesNoCancel
                buttonOK.Visibility = Windows.Visibility.Collapsed
                buttonCancel.Style = FindResource("ButtonBlue")
        End Select
    End Sub

    Private Sub buttonClose_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles buttonClose.Click
        ' Force Result "Cancel"
        Me.MessageResult = MessageBoxResult.Cancel
        Me.Hide()
    End Sub
End Class
