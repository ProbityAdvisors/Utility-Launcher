Imports SCS
Imports System.IO
Imports Utility_Launcher

Public Class frmMain
    Private Const csName = "Name"
    Private Const csDisplayName = "DisplayName"
    Private Const csPath = "FilePath"
    Private Const csFileSpec = "FileSpec"
    Private Const csDescription = "Description"
    Private Const csBGColor = "BGColor"
    '    Private Const cs = ""
    Private m_DefaultColor As Color = Color.Aqua

    Private m_Pref As AppSettingsIni
    Private m_Utilities As New SortedList(Of String, Utility)
    Private m_Panels As New List(Of UtilityPanel)

    Private m_Seperator As Integer = 20
    Private m_Items As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        m_Pref = New AppSettingsIni(Path.ChangeExtension(Application.ExecutablePath, "ini"))
        SetTitle()
        GetSettings()
        m_Pref.GetFormState(Me)
        LoadUtilityNames()
        LoadUtilityPanels()

    End Sub

    Private Sub LoadUtilityPanels()
        tabutilities.Controls.Clear()
        m_Panels.Clear()
        Dim Util As Utility
        Dim Keys = m_Utilities.Keys
        For Each key In Keys
            Util = m_Utilities.Item(key)
            AddUtility(Util)
        Next

    End Sub

    Private Sub AddUtility(util As Utility)
        Dim pnl As UtilityPanel
        Dim Top As Integer
        Dim left As Integer
        If m_Panels.Count > 0 Then
            With m_Panels
                pnl = .Item(.Count - 1)
                left = pnl.Left + pnl.Width + m_Seperator
                If left + pnl.Width > Me.Width Then
                    left = m_Seperator
                    Top = pnl.Top + pnl.Height + m_Seperator
                Else
                    Top = pnl.Top
                End If
            End With
        Else
            Top = m_Seperator
            left = m_Seperator
        End If

        pnl = New UtilityPanel(util)
        pnl.Top = Top
        pnl.Left = left
        pnl.Visible = True
        AddHandler pnl.launch, AddressOf Utility_Launcher
        m_Panels.Add(pnl)
        tabutilities.Controls.Add(pnl)


    End Sub

    Private Sub Utility_Launcher(FileSpec As String)
        Shell(FileSpec, AppWinStyle.MaximizedFocus)
    End Sub


    Private Sub LoadUtilityNames()
        Dim Util As Utility
        cboUtilities.Items.Clear()
        Dim Keys = m_Utilities.Keys
        For Each key In Keys
            Util = m_Utilities.Item(key)
            cboUtilities.Items.Add(Util.DisplayName)
        Next

    End Sub

    Private Sub GetSettings()
        Dim Work As String
        Dim Work2 As String
        Dim Count As Integer
        With m_Pref
            .GetSectionEntries("Utilities")
            Count = .EntryCount
            For Index = 1 To Count
                Work = .GetEntryValue(Index)
                .PushSection(Work)
                GetUtilityInto(Work)
                .PopSection()
            Next
        End With


    End Sub

    Private Sub GetUtilityInto(work As String)
        Dim Util As New Utility
        With m_Pref
            Util.Name = .GetEntry(csName)
            Util.DisplayName = .GetEntry(csDisplayName)
            Util.FilePath = .GetEntry(csPath)
            Util.Description = .GetEntry(csDescription)
            Util.FileSpec = .GetEntry(csFileSpec)
            Util.Color = .GetColor(csBGColor)
            m_Utilities.Add(Util.DisplayName, Util)
        End With
    End Sub

    Private Sub SetTitle()
        With My.Application.Info
            Me.Text = $"{ .AssemblyName} - { .Version.ToString}"
        End With
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        BrowseForexecutable()
    End Sub

    Private Sub BrowseForexecutable()
        Dim fileSpec As String = "*.exe"
        Dim dlg As New OpenFileDialog()
        With dlg
            .FileName = fileSpec
            .Filter = "Executable Files (*.exe)|*.exe"
            If .ShowDialog = DialogResult.OK Then
                fileSpec = .FileName
                txtName.Text = Path.GetFileName(fileSpec)
                txtDisplayName.Text = Path.GetFileNameWithoutExtension(fileSpec)
                txtPath.Text = Path.GetDirectoryName(fileSpec)
                txtDescription.Text = ""
                txtColor.BackColor = m_DefaultColor
                txtColor.Text = m_DefaultColor.ToString
                EnableUptateButton()
            End If

        End With

    End Sub

    Private Sub EnableUptateButton()
        btnUpdate.Visible = txtName.TextLength > 0 AndAlso
                            txtPath.TextLength > 0 AndAlso
                            txtDescription.TextLength > 0

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim util As Utility
        Dim Method As String = ""
        Try
            util = m_Utilities.Item(txtDisplayName.Text)
            util.Description = txtDescription.Text
            util.Color = txtColor.BackColor
            SaveSettings()
            Method = "Updated"
        Catch ex As Exception
            util = New Utility(Path.Combine(txtPath.Text, txtName.Text), txtDescription.Text)
            util.Color = txtColor.BackColor
            cboUtilities.Items.Add(txtDisplayName.Text)
            m_Utilities.Add(util.DisplayName, util)
            SaveSettings()
            Method = "Added"
        End Try
        LoadUtilityPanels()
        ClearUtilityInfo()
        With util
            MessageBox.Show($"Utility { .DisplayName} - { .Description} {Method}")
        End With
    End Sub

    Private Sub ClearUtilityInfo()
        txtName.Clear()
        txtDisplayName.Clear()
        txtPath.Clear()
        txtDescription.Clear()
        btnUpdate.Visible = False
        btnDelete.Visible = False
        cboUtilities.SelectedIndex = -1
    End Sub

    Private Sub SaveSettings()
        Dim Count As Integer
        Dim keys = m_Utilities.Keys
        Dim name As String
        Dim Util As Utility
        RemoveUtilityEntries()

        With m_Pref
            .Section = "Utilities"
            Count = m_Utilities.Count
            For Index = 0 To Count - 1
                Util = m_Utilities.Item(keys(Index))
                name = Util.DisplayName
                .PutEntry("Utility" & Index + 1, name)
                .PushSection("Utilities")
                SaveUtility(Util)
                .PopSection()
            Next
        End With
    End Sub

    Private Sub RemoveUtilityEntries()
        With m_Pref
            .Section = "Utilities"
            Dim Count As Integer = m_Utilities.Count + 2
            For Index As Integer = 1 To Count
                .DeleteEntry("Utility" & Index)
            Next
        End With
    End Sub

    Private Sub SaveUtility(util As Utility)
        With m_Pref
            .Section = util.DisplayName
            .PutEntry(csName, util.Name)
            .PutEntry(csDisplayName, util.DisplayName)
            .PutEntry(csPath, util.FilePath)
            .PutEntry(csDescription, util.Description)
            .PutEntry(csBGColor, util.Color)
            .PutEntry(csFileSpec, util.FileSpec)
        End With
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        EnableUptateButton()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        With dlgColor
            If .ShowDialog = DialogResult.OK Then
                txtColor.Text = .Color.ToString
                txtColor.BackColor = .Color
            End If
        End With
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        m_Pref.SaveFormState(Me)
    End Sub

    Private Sub cboUtilities_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUtilities.SelectedIndexChanged
        Dim Util As Utility = m_Utilities.Item(cboUtilities.SelectedItem)
        With Util
            txtName.Text = .Name
            txtDisplayName.Text = .DisplayName
            txtDescription.Text = .Description
            txtPath.Text = .FilePath
            txtColor.BackColor = .Color
            txtColor.Text = .Color.ToString
        End With
        btnUpdate.Visible = True
        btnDelete.Visible = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Util As Utility = m_Utilities.Item(cboUtilities.SelectedItem)
        With Util
            txtName.Text = .Name
            txtDisplayName.Text = .DisplayName
            txtPath.Text = .FilePath
            txtDescription.Text = .Description
            txtColor.BackColor = .Color
            txtColor.Text = .Color.ToString

            If MessageBox.Show($"Are you sure you want to delete { .DisplayName} - { .Description}", "Confirm deletion of Utility", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                m_Utilities.Remove(Util.DisplayName)
                cboUtilities.Items.RemoveAt(cboUtilities.SelectedIndex)
                m_Pref.DeleteSection(Util.DisplayName)
                SaveSettings()
                ClearUtilityInfo()
                LoadUtilityPanels()
            End If
        End With
    End Sub
End Class
