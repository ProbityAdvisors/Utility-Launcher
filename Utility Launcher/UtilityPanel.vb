Public Class UtilityPanel
    Private m_Utility As Utility

    Public Sub New(Util As Utility)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_Utility = Util
        lblUtilityName.Text = m_Utility.DisplayName
        lblDescription.Text = m_Utility.Description
        Me.BackColor = Util.Color
    End Sub

    Public Event launch(FileSpec As String)

    Private Sub lblDescription_Click(sender As Object, e As EventArgs) Handles lblDescription.Click
        RaiseEvent launch(m_Utility.FileSpec)
    End Sub

    Private Sub lblUtilityName_Click(sender As Object, e As EventArgs) Handles lblUtilityName.Click
        RaiseEvent launch(m_Utility.FileSpec)
    End Sub

    Private Sub UtilityPanel_Click(sender As Object, e As EventArgs) Handles Me.Click
        RaiseEvent launch(m_Utility.FileSpec)
    End Sub

    Private Sub lblInstructions_Click(sender As Object, e As EventArgs)
        RaiseEvent launch(m_Utility.FileSpec)
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        RaiseEvent launch(m_Utility.FileSpec)
    End Sub
End Class
