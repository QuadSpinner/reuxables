Imports System.Windows

Public Class AlphaMessageBoxHandler

    Private m_MessageBoxStyle As MessageBoxButton
    Public Property MessageBoxStyle() As MessageBoxButton
        Get
            Return m_MessageBoxStyle
        End Get
        Set(ByVal value As MessageBoxButton)
            m_MessageBoxStyle = value
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

    Function Show(ByVal MessageText As String, ByVal MessageTitle As String, ByVal DialogStyle As MessageBoxButton) As MessageBoxResult
        Dim f As New AlphaMessageBox
        f.alphaMessageBoxStyle = DialogStyle
        f.Title = MessageTitle
        f.textPrompt.Text = MessageText
        f.ShowDialog()
        Dim temp As MessageBoxResult = f.MessageResult
        f.Close()
        Return temp
    End Function

End Class
