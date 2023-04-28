Public Class Logowanie
    Public sql As New SQLServerConnection
    Public IDproperty As Integer
    Public LvlProperty As String

    Private Sub ZalogujBtn_Click(sender As Object, e As EventArgs) Handles ZalogujBtn.Click
        sql.ArrayFill("@Login", Login.Text, 1)
        sql.ArrayFill("@Hasło", Haslo.Text, 1)
        sql.ArrayFill("@NrId", "", 2)
        IDproperty = sql.SpExec("[dbo].[Logowanie]", "@NrId")
        If IDproperty < 0 Then
            ErrLbl.Visible = True
            Select Case IDproperty
                Case -3
                    ErrLbl.Text = "Podany login nie istnieje w bazie!"
                    Exit Sub
                Case -2
                    ErrLbl.Text = "Błędne hasło!"
                    Exit Sub
                Case Else
                    ErrLbl.Text = "Wystapił błąd serwera o numerze: " & (-1 * IDproperty)
                    Exit Sub
            End Select
        End If
        LvlProperty = sql.SelectQuery("Select lvlDostep from uzytkownicy where ID = " & IDproperty)
        Me.Hide()
        My.Forms.Menu.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Haslo.PasswordChar = ""
    End Sub
    Private Sub Button2_Leave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Haslo.PasswordChar = "*"
    End Sub


End Class