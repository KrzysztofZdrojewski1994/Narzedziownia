Public Class MyDataGridSetting

    Dim CountLbl As Label
    Dim sqlKL As New SQLServerConnection
    Dim SqlString As String
    Public MyBindingSource As BindingSource


    Property MyTab As ADGV.AdvancedDataGridView
        Set(value As ADGV.AdvancedDataGridView)
            tabela = value
        End Set
        Get
            Return tabela
        End Get
    End Property
    Property MySqlString As String
        Set(value As String)
            If value <> "" Then
                SqlString = value
            End If

        End Set
        Get
            Return SqlString
        End Get
    End Property


    Private tabela As ADGV.AdvancedDataGridView
    Public Sub New()

    End Sub

    Public Sub RefreshData(tab As ADGV.AdvancedDataGridView, SqlString As String, Licznik As Label)
        tabela = tab
        CountLbl = Licznik
        AddHandler tabela.SortStringChanged, AddressOf Tabela_SortStringChanged
        AddHandler tabela.FilterStringChanged, AddressOf Tabela_FiltrStringChanged
        MyBindingSource = sqlKL.BindingData(SqlString, tabela)
        CountLbl.Text = "Liczba wierszy: " & Me.MyBindingSource.List.Count.ToString
    End Sub

    Private Sub Tabela_SortStringChanged(sender As Object, e As EventArgs)
        Me.MyBindingSource.Sort = Me.tabela.SortString
    End Sub
    Private Sub Tabela_FiltrStringChanged(sender As Object, e As EventArgs)
        Me.MyBindingSource.Filter = Me.tabela.FilterString
        CountLbl.Text = "Liczba wierszy: " & Me.MyBindingSource.List.Count.ToString
    End Sub

End Class
