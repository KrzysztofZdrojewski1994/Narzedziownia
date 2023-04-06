Imports System.Data.SqlClient
Imports System.Data

Public Class SQLServerConnection
    Private dbcon As New SqlConnection("SERVER=PI-INF-197\SQLEXPRESS;Trusted_Connection=Yes;DATABASE=Narzedziownia2")
    Private dbcmd As New SqlCommand

    Public dbda As New SqlDataAdapter
    Public dbdt As New DataTable
    Private DataBindingSource As New System.Windows.Forms.BindingSource()


    Public params As New List(Of SqlParameter)

    Private Arr(2, 0) As String
    Public RecordCount As Integer
    Public exception As String

    Public Sub New()

    End Sub
    Function BindingData(Query As String, ByVal MyDataGridView As ADGV.AdvancedDataGridView) As BindingSource
        exception = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(Query, dbcon)
            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            dbda.Fill(dbdt)
            DatabindingSource.DataSource = dbdt
            MyDataGridView.DataSource = DataBindingSource
            BindingData = DatabindingSource
            '    MsgBox(Query)

        Catch ex As Exception
            exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
            ' MyDataGridView.Dispose()
        End Try
    End Function
    Function DodajKolumneCheckbox(MyDataGridView As ADGV.AdvancedDataGridView, NameOfHeader As String) As DataGridViewCheckBoxColumn
        Dim mycol As New System.Windows.Forms.DataGridViewCheckBoxColumn
        mycol.DataPropertyName = NameOfHeader
        mycol.HeaderText = NameOfHeader
        mycol.MinimumWidth = 22
        mycol.Name = NameOfHeader
        mycol.ReadOnly = True
        mycol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        mycol.Width = 125
        MyDataGridView.Columns.Add(mycol)
    End Function

    Function DodajKolumne(MyDataGridView As ADGV.AdvancedDataGridView, NameOfHeader As String) As DataGridTextBoxColumn
        Dim mycol As New System.Windows.Forms.DataGridViewTextBoxColumn()
        mycol.DataPropertyName = NameOfHeader
        mycol.HeaderText = NameOfHeader
        mycol.MinimumWidth = 22
        mycol.Name = NameOfHeader
        mycol.ReadOnly = True
        mycol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        mycol.Width = 125
        MyDataGridView.Columns.Add(mycol)
    End Function

    Public Sub New(ConnectionString As String)
        dbcon = New SqlConnection(ConnectionString)
    End Sub

    Sub ArrayFill(Zmienna As String, Wartosc As String, Typ As Integer)

        Arr(0, UBound(Arr, 2)) = Zmienna
        Arr(1, UBound(Arr, 2)) = Wartosc
        Arr(2, UBound(Arr, 2)) = Typ
        ReDim Preserve Arr(2, UBound(Arr, 2) + 1)

    End Sub
    Public Function SpExec(SpName As String, OutputVariableName As String) As String
        Dim Zmienna As String, Wartosc As String, Typ As Integer

        dbcmd = New SqlCommand(SpName, dbcon)
        dbcmd.CommandType = CommandType.StoredProcedure

        Debug.Print(UBound(Arr, 2))
        '
        For i = 0 To UBound(Arr, 2) - 1
            Zmienna = Arr(0, i).ToString
            Wartosc = Arr(1, i).ToString
            Typ = Arr(2, i).ToString

            If Typ = 1 Then
                dbcmd.Parameters.AddWithValue(Zmienna, Wartosc)
                dbcmd.Parameters(Zmienna).Direction = ParameterDirection.Input
            ElseIf Typ = 2 Then
                dbcmd.Parameters.Add(Zmienna, SqlDbType.VarChar, 300)
                dbcmd.Parameters(Zmienna).Direction = ParameterDirection.Output
            Else
                SpExec = "Błędny typ ParameterDirection, przyjmuje wartości input/output 1/2"
                Exit Function
            End If

            Debug.Print(Zmienna & Wartosc & Typ)
        Next


        dbcon.Open()
        dbcmd.ExecuteNonQuery()

        SpExec = dbcmd.Parameters(OutputVariableName).Value.ToString

        dbcmd.Parameters.Clear()
        ReDim Arr(2, 0)
        dbcmd.Dispose()
        dbcon.Close()


    End Function
    Public Function ExecQueryDataSet(Query As String) As DataSet
        Dim dbds As DataSet
        'Reset Query stats
        exception = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(Query, dbcon)

            dbds = New DataSet
            dbda = New SqlDataAdapter(dbcmd)
            dbda.Fill(dbds)
            ExecQueryDataSet = dbds

            '            Debug.Print("test" & RecordCount)

        Catch ex As Exception
            exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try

    End Function




    Public Function ExecQuery(Query As String) As String
        'Reset Query stats
        RecordCount = "0"
        exception = ""
        Try
            dbcon.Open()
            dbcmd = New SqlCommand(Query, dbcon)

            'params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            'Debug.Print("Test")
            'params.Clear()

            dbdt = New DataTable
            dbda = New SqlDataAdapter(dbcmd)
            RecordCount = dbda.Fill(dbdt)
            ExecQuery = "Zmodyfikowano wiersz: "

        Catch ex As Exception
            exception = "ExecQuery Error: " & vbNewLine & ex.Message
            ExecQuery = exception
        Finally
            If dbcon.State = ConnectionState.Open Then dbcon.Close()
        End Try

    End Function
    Public Sub Loadgrid(sqlString As String, MyDataGrid As DataGridView)
        ExecQuery(sqlString)
        If HasException(True) Then
            Exit Sub
        End If
        MyDataGrid.DataSource = dbdt
    End Sub

    Public Sub Addparam(name As String, Value As Object)
        Dim newparam As New SqlParameter(name, Value)
        params.Add(newparam)

    End Sub
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(exception) Then Return False
        If Report = True Then MsgBox(exception, MsgBoxStyle.Critical)
        Return True
    End Function
End Class
