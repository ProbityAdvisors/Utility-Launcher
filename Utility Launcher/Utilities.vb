Imports System.IO

Public Class Utilities
    Private m_List As New SortedList(Of String, Utility)

    Public Sub Add(util As Utility)
        m_List.Add(util.DisplayName, util)
    End Sub

    Public Sub Add(FileSpec As String, Description As String)
        Dim util As New Utility(FileSpec, Description)
        m_List.Add(util.DisplayName, util)
    End Sub

    Public Sub Delete(Key As String)
        m_List.Remove(Key)
    End Sub
    Public ReadOnly Property List() As SortedList(Of String, Utility)
        Get
            Return m_List
        End Get
    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return m_List.Count
        End Get
    End Property

    Public ReadOnly Property Keys() As IList(Of String)
        Get
            Return m_List.Keys
        End Get
    End Property


End Class

Public Class Utility
    Public Property Name As String
    Public Property DisplayName As String
    Public Property FilePath As String
    Public Property Description As String
    Public Property FileSpec As String
    Public Property Color As Color

    Public Sub New()


    End Sub

    Public Sub New(FileSpec As String, Description As String)
        Me.Name = Path.GetFileName(FileSpec)
        Me.DisplayName = Path.GetFileNameWithoutExtension(FileSpec)
        Me.FilePath = Path.GetDirectoryName(FileSpec)
        Me.FileSpec = FileSpec
        Me.Description = Description
    End Sub
    'Public Sub New(Name As String, Path As String, Description As String)
    '    Me.Name = Name
    '    Me.FilePath = Path
    '    Me.Description = Description
    'End Sub


    'Public ReadOnly Property FileSpec() As String

    '    Get
    '        Return Path.Combine(Name, FilePath)
    '    End Get
    'End Property

    Public Shadows Property ToString
        Get
            Return DisplayName
        End Get
        Set(value)

        End Set
    End Property



End Class
