


Public Class form
    Public sql As New SQLServerConnection
    Public SqlDostawca As New SQLServerConnection
    Public SqlNarzędzie As New SQLServerConnection
    Public SqlPracownik As New SQLServerConnection
    Public SqlSerwis As New SQLServerConnection
    Public SqlFakturySerwis As New SQLServerConnection
    Public SqlFaktury As New SQLServerConnection
    Public SqlTypNarzedzia As New SQLServerConnection
    Public SqlTypStanMagazynu As New SQLServerConnection

    Public MyId As Integer = 14
    Public MyLVL As Integer


    Dim StringSqlDostawca As String = "
        select ID, Nazwa, Telefon, Mail, Opiekun, Miasto, Adres, KodPocztowy, NIP, Aktywny
        from Dostawca order by Id desc"
    Dim StringSqlNarzędzie As String = "
        Select narzedzia.ID, Model, TypNarzedzia.Nazwa as TypNarzedzia, narzedzia.Aktywny, NumerSeryjny, Gwarancja  
        from narzedzia 
        left join dbo.TypNarzedzia on
        TypNarzedzia.Id = narzedzia.TypNarzedziaID
        Order by narzedzia.Id desc"
    Dim StringSqlPracownik As String = "
        Select ID, Imie, Nazwisko, eMail, 
        case when LvlDostep = 1 then 'Zwykły użytkownik' else 'Administrator' end as LvlDostep, LOGIN,  Aktywny
        from uzytkownicy 
        order by Id desc"
    Dim StringSqlSerwis As String = "
        Select ID, NazwaSerwisu, Telefon, Mail, Opiekun, Miasto, Adres, KodPocztowy, NIP, Aktywny 
        from serwis order by Id desc"
    Dim StringSqlFakturySerwis As String = "
        Select FakturySerwis.ID, NrFaktury, DataFaktury, serwis.NazwaSerwisu, serwis.NIP, Serwis.Miasto, TerminPłatności, FormaPłatności, FakturySerwis.Aktywny
        from FakturySerwis 
        left join Serwis
        on SerwisID = serwis.ID
        order by Id desc"
    Dim StringSqlFaktury As String = "
        Select Faktury.ID, NrFaktury, DataFaktury, Dostawca.Nazwa, Dostawca.NIP, Dostawca.Miasto, TerminPłatności, FormaPłatności, Faktury.Aktywny
        from Faktury 
        Left join Dostawca
        on
        dostawcaID = Dostawca.ID
        order by Id desc"
    Dim StringSqlTypNarzedzia As String = "Select ID, Nazwa, Aktywny from TypNarzedzia order by Id desc"
    Dim StringSqlStanMagazynu As String = "SELECT [ID], [Model], [Nazwa], [Aktywny], [NumerSeryjny], [Gwarancja] FROM [Narzedziownia2].[dbo].[StanMagazynu] order by Id desc"


    Public SerwisBinding As BindingSource
    Public FakturySerwisBinding As BindingSource
    Public FakturyBindingSource As BindingSource
    Public NarzedziaBinding As BindingSource
    Public SerwisBindingSource As BindingSource
    Public TypNarzedziaBindingSource As BindingSource
    Public DostawcaBindingSource As BindingSource
    Public StanMagazynuBindingSource As BindingSource

    Dim MyBindingSource As BindingSource
    Dim EditSqlString As String
    Dim tabelaNazwa As String

    Dim InputValidation As New InputValidation

    Function CheckBoxAktywny(Tabela As ADGV.AdvancedDataGridView, MyBindingSource As BindingSource, SqlServerConnection As Narzedziownia.SQLServerConnection, SqlString As String, SqlTable As String)


        If Tabela.CurrentCell.OwningColumn.HeaderText = "Aktywny" Then
            'MsgBox(Tabela.CurrentCell.Value)
            'MsgBox(IsDBNull(Tabela.CurrentCell.Value))
            If IsDBNull(Tabela.CurrentCell.Value) Then
                sql.ExecQuery("
                update " & SqlTable & " 
                set Aktywny = 1
                where Id = " & Tabela.CurrentRow.Cells("ID").Value)
                MyBindingSource = SqlServerConnection.BindingData(SqlString, Tabela)
                Exit Function
            End If

            If Tabela.CurrentCell.Value = 1 Then
                sql.ExecQuery("
                update " & SqlTable & " 
                set Aktywny = 0
                where Id = " & Tabela.CurrentRow.Cells("ID").Value)
            Else
                sql.ExecQuery("
                update " & SqlTable & "
                set Aktywny = 1
                where Id = " & Tabela.CurrentRow.Cells("ID").Value)
            End If
            MyBindingSource = SqlServerConnection.BindingData(SqlString, Tabela)
        End If

    End Function
    Function CheckFill(MyTab As Panel) As Boolean
        Dim InputCtrl As Control
        CheckFill = False
        For Each InputCtrl In MyTab.Controls
            If TypeOf InputCtrl Is TextBox Then
                If String.IsNullOrEmpty(InputCtrl.Text) Then
                    CheckFill = True
                    Return CheckFill
                End If
            End If
        Next

    End Function
    Function CheckWarns(MyTab As Panel) As Boolean
        Dim InputCtrl As Control
        CheckWarns = False
        For Each InputCtrl In MyTab.Controls
            If TypeOf InputCtrl Is TextBox Then
                If InputCtrl.BackColor = Color.Red Then
                    CheckWarns = True
                    Return CheckWarns
                End If
            End If
        Next

    End Function

    Private Sub Narzędziownia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabelaDodajNarzędzie.Columns.Clear()
        sql.DodajKolumne(TabelaDodajNarzędzie, "ID")
        sql.DodajKolumne(TabelaDodajNarzędzie, "Model")
        sql.DodajKolumne(TabelaDodajNarzędzie, "TypNarzedzia")
        sql.DodajKolumneCheckbox(TabelaDodajNarzędzie, "Aktywny")
        sql.DodajKolumne(TabelaDodajNarzędzie, "NumerSeryjny")
        sql.DodajKolumne(TabelaDodajNarzędzie, "Gwarancja")
        NarzedziaBinding = SqlNarzędzie.BindingData(StringSqlNarzędzie, TabelaDodajNarzędzie)
        LicznikNarzędzia.Text = "Liczba wierszy: " & Me.NarzedziaBinding.List.Count.ToString


        TabelaDodajPracownika.Columns.Clear()
        sql.DodajKolumne(TabelaDodajPracownika, "ID")
        sql.DodajKolumne(TabelaDodajPracownika, "Imie")
        sql.DodajKolumne(TabelaDodajPracownika, "Nazwisko")
        sql.DodajKolumne(TabelaDodajPracownika, "eMail")
        sql.DodajKolumne(TabelaDodajPracownika, "lvlDostep")
        sql.DodajKolumneCheckbox(TabelaDodajPracownika, "Aktywny")
        sql.DodajKolumne(TabelaDodajPracownika, "Login")
        PracownikBinding = SqlPracownik.BindingData(StringSqlPracownik, TabelaDodajPracownika)
        LicznikDodajPracownika.Text = "Liczba wierszy: " & Me.PracownikBinding.List.Count.ToString


        TabelaDodajDostawce.Columns.Clear()
        sql.DodajKolumne(TabelaDodajDostawce, "ID")
        sql.DodajKolumne(TabelaDodajDostawce, "Nazwa")
        sql.DodajKolumne(TabelaDodajDostawce, "Opiekun")
        sql.DodajKolumne(TabelaDodajDostawce, "Miasto")
        sql.DodajKolumne(TabelaDodajDostawce, "Adres")
        sql.DodajKolumne(TabelaDodajDostawce, "KodPocztowy")
        sql.DodajKolumne(TabelaDodajDostawce, "NIP")
        sql.DodajKolumne(TabelaDodajDostawce, "Mail")
        sql.DodajKolumne(TabelaDodajDostawce, "Telefon")
        sql.DodajKolumneCheckbox(TabelaDodajDostawce, "Aktywny")
        DostawcaBindingSource = SqlDostawca.BindingData(StringSqlDostawca, TabelaDodajDostawce)
        LicznikDostawca.Text = "Liczba wierszy: " & Me.DostawcaBindingSource.List.Count.ToString


        TabelaDodajSerwis.Columns.Clear()
        sql.DodajKolumne(TabelaDodajSerwis, "ID")
        sql.DodajKolumne(TabelaDodajSerwis, "NazwaSerwisu")
        sql.DodajKolumne(TabelaDodajSerwis, "Opiekun")
        sql.DodajKolumne(TabelaDodajSerwis, "Miasto")
        sql.DodajKolumne(TabelaDodajSerwis, "Adres")
        sql.DodajKolumne(TabelaDodajSerwis, "KodPocztowy")
        sql.DodajKolumne(TabelaDodajSerwis, "NIP")
        sql.DodajKolumne(TabelaDodajSerwis, "Mail")
        sql.DodajKolumne(TabelaDodajSerwis, "Telefon")
        sql.DodajKolumneCheckbox(TabelaDodajSerwis, "Aktywny")
        SerwisBinding = SqlSerwis.BindingData(StringSqlSerwis, TabelaDodajSerwis)
        LicznikDodajSerwis.Text = "Liczba wierszy: " & Me.SerwisBinding.List.Count.ToString


        TabelaDodajFaktureSerwis.Columns.Clear()
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "ID")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "NrFaktury")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "DataFaktury")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "NazwaSerwisu")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "Miasto")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "NIP")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "TerminPłatności")
        sql.DodajKolumne(TabelaDodajFaktureSerwis, "FormaPłatności")
        sql.DodajKolumneCheckbox(TabelaDodajFaktureSerwis, "Aktywny")
        FakturySerwisBinding = SqlFakturySerwis.BindingData(StringSqlFakturySerwis, TabelaDodajFaktureSerwis)
        LicznikFakturySerwis.Text = "Liczba wierszy: " & Me.FakturySerwisBinding.List.Count.ToString

        TabelaDodajFakture.Columns.Clear()
        sql.DodajKolumne(TabelaDodajFakture, "ID")
        sql.DodajKolumne(TabelaDodajFakture, "NrFaktury")
        sql.DodajKolumne(TabelaDodajFakture, "DataFaktury")
        sql.DodajKolumne(TabelaDodajFakture, "Nazwa")
        sql.DodajKolumne(TabelaDodajFakture, "Miasto")
        sql.DodajKolumne(TabelaDodajFakture, "NIP")
        sql.DodajKolumne(TabelaDodajFakture, "TerminPłatności")
        sql.DodajKolumne(TabelaDodajFakture, "FormaPłatności")
        sql.DodajKolumneCheckbox(TabelaDodajFakture, "Aktywny")
        FakturyBindingSource = SqlFaktury.BindingData(StringSqlFaktury, TabelaDodajFakture)
        LicznikFaktury.Text = "Liczba wierszy: " & Me.FakturyBindingSource.List.Count.ToString

        TypNarzedziaTabela.Columns.Clear()
        sql.DodajKolumne(TypNarzedziaTabela, "ID")
        sql.DodajKolumne(TypNarzedziaTabela, "Nazwa")
        sql.DodajKolumneCheckbox(TypNarzedziaTabela, "Aktywny")
        TypNarzedziaBindingSource = SqlTypNarzedzia.BindingData(StringSqlTypNarzedzia, TypNarzedziaTabela)
        LicznikTypNarzedzia.Text = "Liczba wierszy: " & Me.TypNarzedziaBindingSource.List.Count.ToString

        WypożyczTabela.Columns.Clear()
        'sql.DodajKolumne(TypNarzedziaTabela, "ID")
        'sql.DodajKolumne(TypNarzedziaTabela, "Nazwa")
        'sql.DodajKolumneCheckbox(TypNarzedziaTabela, "Aktywny")
        StanMagazynuBindingSource = SqlTypNarzedzia.BindingData(StringSqlStanMagazynu, WypożyczTabela)
        LicznikWypożycz.Text = "Liczba wierszy: " & Me.StanMagazynuBindingSource.List.Count.ToString


        DodajFaktureFormaPłatności.SelectedIndex = 0
        DodajFaktureSerwisFormaPłatności.SelectedIndex = 0


        DodajNarzędzieGwarancja.MinDate = Now().ToShortDateString()
        DodajNarzędzieGwarancja.Value = DateAdd(DateInterval.Year, 1, Now()).ToShortDateString()

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("1", "Zwykły user")
        comboSource.Add("2", "Administrator")
        DodajPracownikLvlDostep.DataSource = New BindingSource(comboSource, Nothing)
        DodajPracownikLvlDostep.DisplayMember = "Value"
        DodajPracownikLvlDostep.ValueMember = "Key"
        ComboBoxLvlDostępEdytuj.DataSource = New BindingSource(comboSource, Nothing)
        ComboBoxLvlDostępEdytuj.DisplayMember = "Value"
        ComboBoxLvlDostępEdytuj.ValueMember = "Key"


        Dim TabelaWybierzSource As New Dictionary(Of String, String)()
        TabelaWybierzSource.Add("0", "Pracownik")
        TabelaWybierzSource.Add("1", "Dostawca")
        TabelaWybierzSource.Add("2", "Narzedzia")
        TabelaWybierzSource.Add("3", "Serwis")
        TabelaWybierzSource.Add("4", "Typ narzedzia")
        TabelaWybierz.DataSource = New BindingSource(TabelaWybierzSource, Nothing)
        TabelaWybierz.DisplayMember = "Value"
        TabelaWybierz.ValueMember = "Key"

        IdNarzędziaWypożycz.DataSource = StanMagazynuBindingSource
        ' IdNarzędziaWypożycz.DisplayMember = "Name"
        IdNarzędziaWypożycz.ValueMember = "ID"

        If MyLVL Then
            ' Tu robimy sprawdzenie czy amidn czy zwykły admin ma dostęp do wszyskich id zwykły ma tylko do swojego. Jak dodamy brygady to i brygdzisci mogą do wszystkich którzy mają te samo id co jego brygada
        End If
        Dim WybierzIdWypożycz As New Dictionary(Of String, string)()
        WybierzIdWypożycz.Add(MyId, MyId)

        IdPracownikaWypozycz.DataSource = New BindingSource(WybierzIdWypożycz, Nothing)
        IdPracownikaWypozycz.DisplayMember = "Value"
        IdPracownikaWypozycz.ValueMember = "Key"


    End Sub

    Private Sub Wypożycz_Click(sender As Object, e As EventArgs) Handles Wypożycz.Click
        TabControl.SelectedTab = WypożyczTab
    End Sub

    Private Sub Zwrot_Click(sender As Object, e As EventArgs) Handles Zwrot.Click
        TabControl.SelectedTab = ZwróćTab
    End Sub

    Private Sub SprawdźMojeWypożyczeniaMenu_Click(sender As Object, e As EventArgs) Handles SprawdźMojeWypożyczeniaMenu.Click
        TabControl.SelectedTab = MojeWypożyczenia
    End Sub

    Private Sub StanMagazynuMenu_Click(sender As Object, e As EventArgs) Handles StanMagazynuMenu.Click
        TabControl.SelectedTab = StanMagazynu
    End Sub

    Private Sub DodajNarzedzieMenu_Click(sender As Object, e As EventArgs) Handles NarzedzieMenu.Click
        TabControl.SelectedTab = DodajNarzędzie
    End Sub

    Private Sub DodajPracownikaMenu_Click(sender As Object, e As EventArgs) Handles PracownikMenu.Click
        TabControl.SelectedTab = DodajPracownika
    End Sub

    Private Sub DodajSerwisMenu_Click(sender As Object, e As EventArgs) Handles SerwisMenu.Click
        TabControl.SelectedTab = DodajSerwis
    End Sub

    Private Sub DodajDostawceMenu_Click(sender As Object, e As EventArgs) Handles DostawceMenu.Click
        TabControl.SelectedTab = DodajDostawce

    End Sub

    Private Sub OddajNaSerwisMenu_Click(sender As Object, e As EventArgs) Handles OddajNaSerwisMenu.Click
        TabControl.SelectedTab = OddajNaSerwis
    End Sub

    Private Sub WypożyczeniaNaPracownikaMenu_Click(sender As Object, e As EventArgs) Handles WypożyczeniaNaPracownikaMenu.Click
        TabControl.SelectedTab = WypożyczeniaNaPracownika
    End Sub

    Private Sub HistoriaNarzędziaMenu_Click(sender As Object, e As EventArgs) Handles HistoriaNarzędziaMenu.Click
        TabControl.SelectedTab = HistoriaNarzędzia
    End Sub

    Private Sub PowrotZserwisuMenu_Click(sender As Object, e As EventArgs) Handles PowrotZserwisuMenu.Click
        TabControl.SelectedTab = PowrótZserwisu
    End Sub


    Private Sub DodajDostawce_VisibleChanged(sender As Object, e As EventArgs) Handles DodajDostawce.VisibleChanged
        ErrLabelDostawca.Visible = False
        If DodajDostawce.Visible = True Then

        End If
    End Sub
    Private Sub DodajFakture_Click(sender As Object, e As EventArgs) Handles DodajFakture.VisibleChanged

        'sql.loadgrid("Select * from Faktury order by Id desc", TabelaDodajFakture)
        DodajFaktureDataFaktury.MaxDate = Now.ToShortDateString()
        DodajFaktureDataFaktury.Value = DateTime.Now.ToShortDateString()

        DodajFaktureDataPłatności.MinDate = DateAdd("m", -1, Now).ToShortDateString()
        DodajFaktureDataPłatności.Value = Now.ToShortDateString()
        DodajFaktureWybierzDostawce.DataSource = sql.ExecQueryDataSet("Select ID, cast(NIP as varchar(max)) + ' ||| ' + Nazwa + ' ||| ' + Miasto as FullName from dbo.dostawca Where Aktywny = 1").Tables(0)
        DodajFaktureWybierzDostawce.DisplayMember = "FullName"
        DodajFaktureWybierzDostawce.ValueMember = "ID"
    End Sub


    Private Sub DodajNarzędzie_VisibleChanged(sender As Object, e As EventArgs) Handles DodajNarzędzie.VisibleChanged
        ErrLabelNarzędzie.Visible = False
        If DodajNarzędzie.Visible = True Then
            '         sql.loadgrid("Select * from narzedzia order by id desc", TabelaDodajNarzędzie)

        End If


        DodajNarzędzieGwarancja.MinDate = DateTime.Now.ToShortDateString()
        DodajNarzędzieGwarancja.Value = DateTime.Now.ToShortDateString()

        DodajNarzędzieWybierzFakture.DataSource = sql.ExecQueryDataSet("
        select dbo.Faktury.ID as FakturyID,  CAST(DataFaktury as varchar) + ' ||| ' +  NrFaktury  +' ||| ' + nazwa as FullName 
        from Faktury   left join dbo.Dostawca   
        on Faktury.DostawcaID = dbo.Dostawca.ID   
        where faktury.aktywny = 1
        order by DataFaktury desc").Tables(0)
        DodajNarzędzieWybierzFakture.DisplayMember = "FullName"
        DodajNarzędzieWybierzFakture.ValueMember = "FakturyID"

        DodajNarzędzieTyp.DataSource = sql.ExecQueryDataSet("
        Select ID, Nazwa 
        from dbo.TypNarzedzia  
        where Aktywny = 1 ").Tables(0)
        DodajNarzędzieTyp.DisplayMember = "Nazwa"
        DodajNarzędzieTyp.ValueMember = "ID"

    End Sub


    Private Sub CenaTxt_TextChanged(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.LostFocus
        If DodajNarzędzieCena.Text <> "" Then
            DodajNarzędzieCena.Text = Math.Round(Convert.ToDecimal(DodajNarzędzieCena.Text), 2)
        End If
    End Sub

    Private Sub CenaTxt_GotFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.GotFocus
        InputValidation.AssignValidation(DodajNarzędzieCena, InputValidation.ValidationType1.Only_Numbers)
    End Sub
    Private Sub CenaTxt_KeyPress(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.KeyPress
        InputValidation.AssignValidation(DodajNarzędzieCena, InputValidation.ValidationType1.Only_Numbers)
    End Sub
    Private Sub CenaTxt_TextLostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieCena, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub

    Private Sub NumerSeryjnyTxT_LostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieNumerSeryjny.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieNumerSeryjny, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub

    Private Sub TypNarzedziaTxt_LostFocus(sender As Object, e As EventArgs) Handles TypNarzedziaTxt.LostFocus
        InputValidation.AssignValidation(TypNarzedziaTxt, InputValidation.ValidationType2.Not_Null, ErrLabelTypNarzedzia)
    End Sub
    Private Sub ModelTxT_LostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieModel.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieModel, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub

    Private Sub DodajFaktureMenu_Click(sender As Object, e As EventArgs) Handles FakturyMenu.Click
        TabControl.SelectedTab = DodajFakture
    End Sub

    Private Sub DostawcaKodPocztowy_LostFocus(sender As Object, e As EventArgs) Handles DostawcaKodPocztowy.LostFocus
        InputValidation.AssignValidation(DostawcaKodPocztowy, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
        InputValidation.AssignValidation(DostawcaKodPocztowy, InputValidation.ValidationType2.Postal_Code, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaNip_LostFocus(sender As Object, e As EventArgs) Handles DostawcaNip.LostFocus
        InputValidation.AssignValidation(DostawcaNip, InputValidation.ValidationType1.Only_Numbers)
        InputValidation.AssignValidation(DostawcaNip, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
        InputValidation.AssignValidation(DostawcaNip, InputValidation.ValidationType2.NIP, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaAdres_LostFocus(sender As Object, e As EventArgs) Handles DostawcaAdres.LostFocus
        InputValidation.AssignValidation(DostawcaAdres, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaMiasto_LostFocus(sender As Object, e As EventArgs) Handles DostawcaMiasto.LostFocus
        InputValidation.AssignValidation(DostawcaMiasto, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaOpiekun_LostFocus(sender As Object, e As EventArgs) Handles DostawcaOpiekun.LostFocus
        InputValidation.AssignValidation(DostawcaOpiekun, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaMail_LostFocus(sender As Object, e As EventArgs) Handles DostawcaMail.LostFocus
        InputValidation.AssignValidation(DostawcaMail, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
        InputValidation.AssignValidation(DostawcaMail, InputValidation.ValidationType2.Only_Email, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaTelefon_KeyPress(sender As Object, e As EventArgs) Handles DostawcaTelefon.KeyPress
        InputValidation.AssignValidation(DostawcaTelefon, InputValidation.ValidationType1.Only_Numbers)
    End Sub
    Private Sub DostawcaTelefon_GotFocus(sender As Object, e As EventArgs) Handles DostawcaTelefon.GotFocus
        InputValidation.AssignValidation(DostawcaTelefon, InputValidation.ValidationType1.Only_Numbers)
    End Sub
    Private Sub DostawcaTelefon_LostFocus(sender As Object, e As EventArgs) Handles DostawcaTelefon.LostFocus
        InputValidation.AssignValidation(DostawcaTelefon, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
    End Sub

    Private Sub DostawcaNazwa_LostFocus(sender As Object, e As EventArgs) Handles DostawcaNazwa.LostFocus
        InputValidation.AssignValidation(DostawcaNazwa, InputValidation.ValidationType2.Not_Null, ErrLabelDostawca)
    End Sub



    Private Sub DodajDostawceBtn_Click(sender As Object, e As EventArgs) Handles DodajDostawceBtn.Click

        If CheckFill(PanelDostawca) Then
            ErrLabelDostawca.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelDostawca.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelDostawca) Then
            ErrLabelDostawca.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelDostawca.Visible = True
            Exit Sub
        End If


        sql.ArrayFill("@Nazwa", DostawcaNazwa.Text, 1)
        sql.ArrayFill("@Telefon", DostawcaTelefon.Text, 1)
        sql.ArrayFill("@Mail", DostawcaMail.Text, 1)
        sql.ArrayFill("@OsobaKontaktowa", DostawcaOpiekun.Text, 1)
        sql.ArrayFill("@miasto", DostawcaMiasto.Text, 1)
        sql.ArrayFill("@Adres", DostawcaAdres.Text, 1)
        sql.ArrayFill("@KodPocztowy", DostawcaKodPocztowy.Text, 1)
        sql.ArrayFill("@NIP", DostawcaNip.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelDostawca.Text = sql.SpExec("[dbo].[DodajDostawce]", "@Desc")
        ErrLabelDostawca.Visible = True

        DostawcaBindingSource = sql.BindingData(StringSqlDostawca, TabelaDodajDostawce)
        LicznikDostawca.Text = "Liczba wierszy: " & Me.DostawcaBindingSource.List.Count.ToString
        If ErrLabelDostawca.Text.Contains("Prawidłowo dodany wiersz") Then
            DostawcaNazwa.Text = ""
            DostawcaTelefon.Text = ""
            DostawcaMail.Text = ""
            DostawcaOpiekun.Text = ""
            DostawcaMiasto.Text = ""
            DostawcaAdres.Text = ""
            DostawcaKodPocztowy.Text = ""
            DostawcaNip.Text = ""
        End If

    End Sub
    Private Sub DodajSerwisDodaj_Click(sender As Object, e As EventArgs) Handles DodajSerwisDodaj.Click

        If CheckFill(PanelDodajSerwis) Then
            ErrLabelDodajSerwis.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelDodajSerwis.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelDodajSerwis) Then
            ErrLabelDodajSerwis.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelDodajSerwis.Visible = True
            Exit Sub
        End If


        sql.ArrayFill("@NazwaSerwisu", DodajSerwisNazwa.Text, 1)
        sql.ArrayFill("@Telefon", DodajSerwisTelefon.Text, 1)
        sql.ArrayFill("@Mail", DodajSerwisMail.Text, 1)
        sql.ArrayFill("@OsobaKontaktowa", DodajSerwisOpiekun.Text, 1)
        sql.ArrayFill("@miasto", DodajSerwisMiasto.Text, 1)
        sql.ArrayFill("@Adres", DodajSerwisAdres.Text, 1)
        sql.ArrayFill("@KodPocztowy", DodajSerwisKodPocztowy.Text, 1)
        sql.ArrayFill("@NIP", DodajSerwisNIP.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelDodajSerwis.Text = sql.SpExec("[dbo].[DodajSerwis]", "@Desc")
        ErrLabelDodajSerwis.Visible = True

        SerwisBinding = SqlSerwis.BindingData(StringSqlSerwis, TabelaDodajSerwis)
        LicznikDodajSerwis.Text = "Liczba wierszy: " & Me.SerwisBinding.List.Count.ToString

        If ErrLabelDodajSerwis.Text.Contains("Prawidłowo dodany wiersz") Then
            DodajSerwisNazwa.Text = ""
            DodajSerwisTelefon.Text = ""
            DodajSerwisMail.Text = ""
            DodajSerwisOpiekun.Text = ""
            DodajSerwisMiasto.Text = ""
            DodajSerwisAdres.Text = ""
            DodajSerwisKodPocztowy.Text = ""
            DodajSerwisNIP.Text = ""
        End If

    End Sub


    Private Sub DodajNarzędzieBtn_Click(sender As Object, e As EventArgs) Handles DodajNarzędzieBtn.Click

        If CheckFill(PanelNarzędzie) Then
            ErrLabelDostawca.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelDostawca.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelNarzędzie) Then
            ErrLabelDostawca.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelDostawca.Visible = True
            Exit Sub
        End If


        sql.ArrayFill("@Model", DodajNarzędzieModel.Text, 1)
        sql.ArrayFill("@typ", DodajNarzędzieTyp.SelectedValue, 1)
        sql.ArrayFill("@numerSeryjny", DodajNarzędzieNumerSeryjny.Text, 1)
        sql.ArrayFill("@Gwarancja", DodajNarzędzieGwarancja.Text, 1)
        sql.ArrayFill("@FakturaID", DodajNarzędzieWybierzFakture.SelectedValue, 1)
        sql.ArrayFill("@Cena", Replace(DodajNarzędzieCena.Text, ",", "."), 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelNarzędzie.Text = sql.SpExec("[dbo].[DodajNarzedzieOrazDetaleFaktury]", "@Desc")
        ErrLabelNarzędzie.Visible = True

        NarzedziaBinding = SqlNarzędzie.BindingData(StringSqlNarzędzie, TabelaDodajNarzędzie)
        LicznikNarzędzia.Text = "Liczba wierszy: " & Me.NarzedziaBinding.List.Count.ToString


        If ErrLabelNarzędzie.Text.Contains("Prawidłowo dodany wiersz") Then
            DodajNarzędzieModel.Text = ""
            DodajNarzędzieTyp.Text = ""
            DodajNarzędzieNumerSeryjny.Text = ""
            DodajNarzędzieNumerSeryjny.Text = ""
            DodajNarzędzieCena.Text = ""
        End If


    End Sub

    Private Sub DodajFaktureBtn_Click(sender As Object, e As EventArgs) Handles DodajFaktureBtn.Click
        If CheckFill(PanelDodajFakture) Then
            ErrLabelFaktura.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelFaktura.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelDodajFakture) Then
            ErrLabelFaktura.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelFaktura.Visible = True
            Exit Sub
        End If

        sql.ArrayFill("@NrFaktury", DodajFaktureNrFaktury.Text, 1)
        sql.ArrayFill("@DataFaktury", DodajFaktureDataFaktury.Value, 1)
        sql.ArrayFill("@DostawcaID", DodajFaktureWybierzDostawce.SelectedValue, 1)
        sql.ArrayFill("@TerminPłatności", DodajFaktureDataPłatności.Value, 1)
        sql.ArrayFill("@FormaPłatności", DodajFaktureFormaPłatności.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelFaktura.Text = sql.SpExec("[dbo].[DodajFakture]", "@Desc")
        ErrLabelFaktura.Visible = True

        'sql.loadgrid("Select * from Faktury order by Id desc", TabelaDodajFakture)
        '    Me.FakturyTableAdapter.Fill(Me.Narzedziownia2DataSet.Faktury)
        FakturyBindingSource = SqlFaktury.BindingData(StringSqlFaktury, TabelaDodajFakture)
        LicznikFaktury.Text = "Liczba wierszy: " & Me.FakturyBindingSource.List.Count.ToString

        If ErrLabelFaktura.Text.Contains("Prawidłowo dodany wiersz") Then
            DodajFaktureNrFaktury.Text = ""
        End If


    End Sub

    Private Sub DodajPracownikaBtn_Click(sender As Object, e As EventArgs) Handles DodajPracownikaBtn.Click
        If CheckFill(PanelDodajPracownika) Then
            ErrLabelPracownik.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelPracownik.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelDodajPracownika) Then
            ErrLabelPracownik.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelPracownik.Visible = True
            Exit Sub
        End If

        sql.ArrayFill("@Imie", DodajPracownikaImie.Text, 1)
        sql.ArrayFill("@Nazwisko", DodajPracownikaNazwisko.Text, 1)
        sql.ArrayFill("@eMail", DodajPracownikaMail.Text, 1)
        sql.ArrayFill("@lvlDostep", DodajPracownikLvlDostep.SelectedValue, 1)
        sql.ArrayFill("@Haslo", DodajPracownikaHaslo.Text, 1)
        sql.ArrayFill("@Login", DodajPracownikaLogin.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelPracownik.Text = sql.SpExec("[dbo].[DodajUzytkownika]", "@Desc")
        ErrLabelPracownik.Visible = True
        PracownikBinding = sql.BindingData(StringSqlPracownik, TabelaDodajPracownika)
        LicznikDodajPracownika.Text = "Liczba wierszy: " & PracownikBinding.List.Count.ToString
        If ErrLabelFaktura.Text.Contains("Prawidłowo dodany wiersz") Then
            DodajFaktureNrFaktury.Text = ""
        End If

    End Sub
    Private Sub DodajFaktureSerwisBtn_Click(sender As Object, e As EventArgs) Handles DodajFaktureSerwisBtn.Click
        If CheckFill(PanelDodajFaktureSerwis) Then
            ErrLabelFakturaSerwis.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelFakturaSerwis.Visible = True
            Exit Sub
        End If
        If CheckWarns(PanelDodajFaktureSerwis) Then
            ErrLabelFakturaSerwis.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelFakturaSerwis.Visible = True
            Exit Sub
        End If

        sql.ArrayFill("@NrFaktury", DodajFaktureSerwisNrFaktury.Text, 1)
        sql.ArrayFill("@DataFaktury", DodajFaktureSerwisDataFaktury.Value, 1)
        sql.ArrayFill("@SerwisID", DodajFaktureSerwisWybierzDostawce.SelectedValue, 1)
        sql.ArrayFill("@TerminPłatności", DodajFaktureSerwisDataPłatności.Value, 1)
        sql.ArrayFill("@FormaPłatności", DodajFaktureSerwisFormaPłatności.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelFakturaSerwis.Text = sql.SpExec("[dbo].[DodajFaktureSerwis]", "@Desc")
        ErrLabelFakturaSerwis.Visible = True

        FakturySerwisBinding = SqlFakturySerwis.BindingData(StringSqlFakturySerwis, TabelaDodajFaktureSerwis)
        LicznikFakturySerwis.Text = "Liczba wierszy: " & Me.FakturySerwisBinding.List.Count.ToString

        If ErrLabelFakturaSerwis.Text.Contains("Prawidłowo dodany wiersz") Then
            DodajFaktureSerwisNrFaktury.Text = ""
        End If
    End Sub

    Private Sub DodajFaktureNrFaktury_LostFocus(sender As Object, e As EventArgs) Handles DodajFaktureNrFaktury.LostFocus
        InputValidation.AssignValidation(DodajFaktureNrFaktury, InputValidation.ValidationType2.Not_Null, ErrLabelFaktura)
    End Sub

    Private Sub DodajNarzędzieModel_LostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieModel.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieModel, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub

    Private Sub DodajNarzędzieNumerSeryjny_LostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieNumerSeryjny.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieNumerSeryjny, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub

    Private Sub DodajNarzędzieCena_LostFocus(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.LostFocus
        InputValidation.AssignValidation(DodajNarzędzieNumerSeryjny, InputValidation.ValidationType2.Not_Null, ErrLabelNarzędzie)
    End Sub
    Private Sub DodajNarzędzieCena_KeyPress(sender As Object, e As EventArgs) Handles DodajNarzędzieCena.KeyPress
        InputValidation.AssignValidation(DodajNarzędzieCena, InputValidation.ValidationType1.Only_Numbers)
    End Sub

    Private Sub TabelaDodajDostawce_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajDostawce.FilterStringChanged
        DostawcaBindingSource.Filter = Me.TabelaDodajDostawce.FilterString
        LicznikDostawca.Text = "Liczba wierszy: " & Me.DostawcaBindingSource.List.Count.ToString

    End Sub

    Private Sub TabelaDodajDostawce_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajDostawce.SortStringChanged
        DostawcaBindingSource.Sort = Me.TabelaDodajDostawce.SortString
    End Sub


    Private Sub Faktury_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajFakture.FilterStringChanged
        Me.FakturyBindingSource.Filter = Me.TabelaDodajFakture.FilterString
        LicznikFaktury.Text = "Liczba wierszy: " & Me.FakturyBindingSource.List.Count.ToString
    End Sub
    Private Sub Faktury_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajFakture.SortStringChanged
        Me.FakturyBindingSource.Sort = Me.TabelaDodajFakture.SortString
    End Sub


    Private Sub TabelaDodajNarzędzie_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajNarzędzie.FilterStringChanged
        NarzedziaBinding.Filter = Me.TabelaDodajNarzędzie.FilterString
        LicznikNarzędzia.Text = "Liczba wierszy: " & Me.NarzedziaBinding.List.Count.ToString
    End Sub
    Private Sub TabelaDodajNarzędzie_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajNarzędzie.SortStringChanged
        NarzedziaBinding.Sort = Me.TabelaDodajNarzędzie.SortString
        LicznikNarzędzia.Text = "Liczba wierszy: " & Me.NarzedziaBinding.List.Count.ToString
    End Sub


    Private Sub DodajPracownikaImie_LostFocus(sender As Object, e As EventArgs) Handles DodajPracownikaImie.LostFocus
        InputValidation.AssignValidation(DodajPracownikaImie, InputValidation.ValidationType2.Not_Null, ErrLabelPracownik)
    End Sub

    Private Sub DodajPracownikaNazwisko_LostFocus(sender As Object, e As EventArgs) Handles DodajPracownikaNazwisko.LostFocus
        InputValidation.AssignValidation(DodajPracownikaNazwisko, InputValidation.ValidationType2.Not_Null, ErrLabelPracownik)
    End Sub

    Private Sub DodajPracownikaMail_LostFocus(sender As Object, e As EventArgs) Handles DodajPracownikaMail.LostFocus
        InputValidation.AssignValidation(DodajPracownikaMail, InputValidation.ValidationType2.Not_Null, ErrLabelPracownik)
        InputValidation.AssignValidation(DodajPracownikaMail, InputValidation.ValidationType2.Only_Email, ErrLabelPracownik)
    End Sub

    Private Sub DodajPracownikaLogin_TextChanged(sender As Object, e As EventArgs) Handles DodajPracownikaLogin.LostFocus
        InputValidation.AssignValidation(DodajPracownikaLogin, InputValidation.ValidationType2.Not_Null, ErrLabelPracownik)
    End Sub

    Private Sub DodajPracownikaHaslo_TextChanged(sender As Object, e As EventArgs) Handles DodajPracownikaHaslo.LostFocus
        InputValidation.AssignValidation(DodajPracownikaHaslo, InputValidation.ValidationType2.Not_Null, ErrLabelPracownik)
    End Sub


    Private Sub TabelaDodajPracownika_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajPracownika.FilterStringChanged
        PracownikBinding.Filter = Me.TabelaDodajPracownika.FilterString
        LicznikDodajPracownika.Text = "Liczba wierszy: " & PracownikBinding.List.Count.ToString
    End Sub
    Private Sub TabelaDodajPracownika_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajPracownika.SortStringChanged
        PracownikBinding.Sort = Me.TabelaDodajPracownika.SortString
    End Sub

    Private Sub DodajSerwisNazwa_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisNazwa.LostFocus
        InputValidation.AssignValidation(DodajSerwisNazwa, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisTelefon_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisTelefon.LostFocus
        InputValidation.AssignValidation(DodajSerwisTelefon, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
    End Sub
    Private Sub DodajSerwisTelefon_KeyPress(sender As Object, e As EventArgs) Handles DodajSerwisTelefon.KeyPress
        InputValidation.AssignValidation(DodajSerwisTelefon, InputValidation.ValidationType1.Only_Numbers)
    End Sub

    Private Sub DodajSerwisMail_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisMail.LostFocus
        InputValidation.AssignValidation(DodajSerwisMail, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
        InputValidation.AssignValidation(DodajSerwisMail, InputValidation.ValidationType2.Only_Email, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisOpiekun_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisOpiekun.LostFocus
        InputValidation.AssignValidation(DodajSerwisOpiekun, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisMiasto_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisMiasto.LostFocus
        InputValidation.AssignValidation(DodajSerwisMiasto, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisAdres_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisAdres.LostFocus
        InputValidation.AssignValidation(DodajSerwisAdres, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisKodPocztowy_TextChanged(sender As Object, e As EventArgs) Handles DodajSerwisKodPocztowy.LostFocus
        InputValidation.AssignValidation(DodajSerwisKodPocztowy, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
        InputValidation.AssignValidation(DodajSerwisKodPocztowy, InputValidation.ValidationType2.Postal_Code, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajSerwisNIP_LostFocus(sender As Object, e As EventArgs) Handles DodajSerwisNIP.LostFocus
        InputValidation.AssignValidation(DodajSerwisNIP, InputValidation.ValidationType2.Not_Null, ErrLabelDodajSerwis)
        InputValidation.AssignValidation(DodajSerwisNIP, InputValidation.ValidationType2.NIP, ErrLabelDodajSerwis)
    End Sub
    Private Sub DodajSerwisNIP_KeyPress(sender As Object, e As EventArgs) Handles DodajSerwisNIP.KeyPress
        InputValidation.AssignValidation(DodajSerwisNIP, InputValidation.ValidationType1.Only_Numbers)
    End Sub

    Private Sub TabelaDodajSerwis_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajSerwis.FilterStringChanged
        Me.SerwisBinding.Filter = Me.TabelaDodajSerwis.FilterString
        LicznikDodajSerwis.Text = "Liczba wierszy: " & Me.SerwisBinding.List.Count.ToString
    End Sub
    Private Sub TabelaDodajSerwis_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajSerwis.SortStringChanged
        Me.SerwisBinding.Sort = Me.TabelaDodajSerwis.SortString
    End Sub


    Private Sub DodajFaktureSerwis_Click(sender As Object, e As EventArgs) Handles DodajFaktureSerwis.VisibleChanged
        DodajFaktureSerwisDataFaktury.Value = DateTime.Now.ToShortDateString()
        DodajFaktureSerwisDataFaktury.MaxDate = Now
        DodajFaktureSerwisDataPłatności.MinDate = DateAdd("m", -1, Now)
        DodajFaktureSerwisDataPłatności.Value = Now
        DodajFaktureSerwisWybierzDostawce.DataSource = sql.ExecQueryDataSet("Select ID, cast(NIP as varchar(max)) + ' ||| ' + NazwaSerwisu + ' ||| ' + Miasto as FullName from dbo.serwis Where Aktywny = 1").Tables(0)
        DodajFaktureSerwisWybierzDostawce.DisplayMember = "FullName"
        DodajFaktureSerwisWybierzDostawce.ValueMember = "ID"


    End Sub



    Private Sub DodajFaktureSerwis_SortStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajFaktureSerwis.FilterStringChanged
        Me.FakturySerwisBinding.Filter = Me.TabelaDodajFaktureSerwis.FilterString
        LicznikFakturySerwis.Text = "Liczba wierszy: " & Me.FakturySerwisBinding.List.Count.ToString
    End Sub
    Private Sub DodajFaktureSerwis_FilterStringChanged(sender As Object, e As EventArgs) Handles TabelaDodajFaktureSerwis.SortStringChanged
        Me.FakturySerwisBinding.Sort = Me.TabelaDodajFaktureSerwis.SortString
    End Sub

    Private Sub DodajFaktureSerwisMenu_Click(sender As Object, e As EventArgs) Handles FakturaSerwisMenu.Click
        TabControl.SelectedTab = DodajFaktureSerwis
    End Sub


    Private Sub TypNarzedziaBTN_Click(sender As Object, e As EventArgs) Handles TypNarzedziaBTN.Click
        If CheckFill(TypNarzedziaPanel) Then
            ErrLabelTypNarzedzia.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            ErrLabelTypNarzedzia.Visible = True
            Exit Sub
        End If
        If CheckWarns(TypNarzedziaPanel) Then
            ErrLabelTypNarzedzia.Text = "Przed dodaniem popraw czerwone pola!"
            ErrLabelTypNarzedzia.Visible = True
            Exit Sub
        End If

        sql.ArrayFill("@Nazwa", TypNarzedziaTxt.Text, 1)
        sql.ArrayFill("@Desc", "", 2)


        ErrLabelTypNarzedzia.Text = sql.SpExec("[dbo].[DodajTypNarzedzia]", "@Desc")
        ErrLabelTypNarzedzia.Visible = True

        TypNarzedziaBindingSource = SqlTypNarzedzia.BindingData("Select ID, Nazwa, Aktywny from TypNarzedzia order by Id desc", TypNarzedziaTabela)
        LicznikTypNarzedzia.Text = "Liczba wierszy: " & Me.TypNarzedziaBindingSource.List.Count.ToString

        If ErrLabelFakturaSerwis.Text.Contains("Prawidłowo dodany wiersz") Then
            TypNarzedziaTxt.Text = ""
        End If
    End Sub
    Private Sub WypożyczTabela_SortStringChanged(sender As Object, e As EventArgs) Handles WypożyczTabela.FilterStringChanged
        Me.StanMagazynuBindingSource.Filter = Me.WypożyczTabela.FilterString
        LicznikWypożycz.Text = "Liczba wierszy: " & Me.StanMagazynuBindingSource.List.Count.ToString
    End Sub
    Private Sub WypożyczTabela_FilterStringChanged(sender As Object, e As EventArgs) Handles WypożyczTabela.SortStringChanged
        Me.StanMagazynuBindingSource.Sort = Me.WypożyczTabela.SortString
    End Sub
    Private Sub TypNarzedzia_SortStringChanged(sender As Object, e As EventArgs) Handles TypNarzedziaTabela.FilterStringChanged
        Me.TypNarzedziaBindingSource.Filter = Me.TypNarzedziaTabela.FilterString
        LicznikTypNarzedzia.Text = "Liczba wierszy: " & Me.TypNarzedziaBindingSource.List.Count.ToString
    End Sub
    Private Sub TypNarzedzia_FilterStringChanged(sender As Object, e As EventArgs) Handles TypNarzedziaTabela.SortStringChanged
        Me.TypNarzedziaBindingSource.Sort = Me.TypNarzedziaTabela.SortString
    End Sub

    Private Sub TabelaDodajSerwis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajSerwis.CellClick
        CheckBoxAktywny(TabelaDodajSerwis, SerwisBinding, SqlSerwis, StringSqlSerwis, "Serwis")
    End Sub

    Private Sub TypNarzedziaTabela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TypNarzedziaTabela.CellClick
        CheckBoxAktywny(TypNarzedziaTabela, TypNarzedziaBindingSource, SqlTypNarzedzia, StringSqlTypNarzedzia, "TypNarzedzia")
    End Sub

    Private Sub TabelaDodajDostawce_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajDostawce.CellClick
        CheckBoxAktywny(TabelaDodajDostawce, DostawcaBindingSource, SqlDostawca, StringSqlDostawca, "Dostawca")
    End Sub

    Private Sub TabelaDodajNarzędzie_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajNarzędzie.CellClick
        CheckBoxAktywny(TabelaDodajNarzędzie, NarzedziaBinding, SqlNarzędzie, StringSqlNarzędzie, "narzedzia")
    End Sub

    Private Sub TabelaDodajPracownika_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajPracownika.CellClick
        CheckBoxAktywny(TabelaDodajPracownika, PracownikBinding, SqlPracownik, StringSqlPracownik, "uzytkownicy")
    End Sub
    Private Sub TabelaDodajFaktureSerwis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajFaktureSerwis.CellClick
        CheckBoxAktywny(TabelaDodajFaktureSerwis, FakturySerwisBinding, SqlFakturySerwis, StringSqlFakturySerwis, "FakturySerwis")
    End Sub

    Private Sub TabelaDodajFakture_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajFakture.CellClick
        CheckBoxAktywny(TabelaDodajFakture, FakturyBindingSource, SqlFaktury, StringSqlFaktury, "faktury")
    End Sub


    Private Sub TabelaWybierz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabelaWybierz.SelectedIndexChanged
        Dim WybierzKolumneSource As New Dictionary(Of String, String)()


        Select Case TabelaWybierz.SelectedIndex
            Case 0
                tabelaNazwa = "uzytkownicy"
                WybierzKolumneSource.Add("0", "Imie")
                WybierzKolumneSource.Add("1", "Nazwisko")
                WybierzKolumneSource.Add("2", "Email")
                WybierzKolumneSource.Add("3", "lvlDostep")
                EditSqlString = StringSqlPracownik
            Case 1
                tabelaNazwa = "Dostawca"
                WybierzKolumneSource.Add("0", "Nazwa")
                WybierzKolumneSource.Add("1", "Telefon")
                WybierzKolumneSource.Add("2", "Mail")
                WybierzKolumneSource.Add("3", "Opiekun")
                WybierzKolumneSource.Add("4", "Miasto")
                WybierzKolumneSource.Add("5", "Adres")
                WybierzKolumneSource.Add("6", "KodPocztowy")
                WybierzKolumneSource.Add("7", "Nip")
                EditSqlString = StringSqlDostawca
            Case 2
                tabelaNazwa = "narzedzia"
                WybierzKolumneSource.Add("0", "Model")
                WybierzKolumneSource.Add("1", "NumerSerjny")
                WybierzKolumneSource.Add("2", "Gwarancja")
                EditSqlString = StringSqlNarzędzie
            Case 3
                tabelaNazwa = "Serwis"
                WybierzKolumneSource.Add("0", "NazwaSerwisu")
                WybierzKolumneSource.Add("1", "Telefon")
                WybierzKolumneSource.Add("2", "Mail")
                WybierzKolumneSource.Add("3", "Opiekun")
                WybierzKolumneSource.Add("4", "Miasto")
                WybierzKolumneSource.Add("5", "Adres")
                WybierzKolumneSource.Add("6", "KodPocztowy")
                WybierzKolumneSource.Add("7", "Nip")
                EditSqlString = StringSqlSerwis
            Case 4
                tabelaNazwa = "TypNarzedzia"
                WybierzKolumneSource.Add("0", "Nazwa")
                EditSqlString = StringSqlTypNarzedzia
        End Select

        EdytujTabela.Columns.Clear()
        sql.DodajKolumneCheckbox(EdytujTabela, "Aktywny")
        WybierzKolumne.DataSource = New BindingSource(WybierzKolumneSource, Nothing)
        WybierzKolumne.DisplayMember = "Value"
        WybierzKolumne.ValueMember = "Key"
        MyBindingSource = sql.BindingData(EditSqlString, EdytujTabela)
        If MyBindingSource.ToString <> Nothing Then
            MyBindingSource.RemoveFilter()
            LicznikEdytuj.Text = "Liczba wierszy: " & Me.MyBindingSource.List.Count.ToString
        End If

        ComboBoxID.DataSource = MyBindingSource
        ComboBoxID.DisplayMember = "ID"
        ComboBoxID.ValueMember = "ID"

    End Sub

    Private Sub EdytujTabela_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EdytujTabela.CellContentDoubleClick
        CheckBoxAktywny(EdytujTabela, MyBindingSource, sql, EditSqlString, tabelaNazwa)
    End Sub
    Private Sub TabelaWybierz_SortStringChanged(sender As Object, e As EventArgs) Handles EdytujTabela.FilterStringChanged
        Me.MyBindingSource.Filter = Me.EdytujTabela.FilterString

        LicznikEdytuj.Text = "Liczba wierszy: " & Me.MyBindingSource.List.Count.ToString
    End Sub
    Private Sub TabelaWybierz_FilterStringChanged(sender As Object, e As EventArgs) Handles EdytujTabela.SortStringChanged
        Me.MyBindingSource.Sort = Me.EdytujTabela.SortString
    End Sub


    Private Sub ZmienBtn_Click(sender As Object, e As EventArgs) Handles ZmienBtn.Click
        If WybierzKolumne.Text = "lvlDostep" Then
            EdytowanaWartosc.Text = ComboBoxLvlDostępEdytuj.SelectedValue
        End If

        If EdytowanaWartosc.Text = "" Or ComboBoxID.Text = "" Then
            ErrLblEdit.Text = "Uzupełnij wszystkie pola!"
            ErrLblEdit.Visible = True
            Exit Sub
        End If
        ErrLblEdit.Text = sql.ExecQuery("Update " & tabelaNazwa & " Set " & WybierzKolumne.Text & " = '" & EdytowanaWartosc.Text & "' Where ID = " & ComboBoxID.Text) & ComboBoxID.Text
        ErrLblEdit.Visible = True
        MyBindingSource = sql.BindingData(EditSqlString, EdytujTabela)
        EdytowanaWartosc.Text = ""
    End Sub

    Private Sub WybierzKolumne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WybierzKolumne.SelectedIndexChanged

        If WybierzKolumne.Text = "lvlDostep" Then
            ComboBoxLvlDostępEdytuj.Visible = True
            EdytowanaWartosc.Visible = False
        Else
            ComboBoxLvlDostępEdytuj.Visible = False
            EdytowanaWartosc.Visible = True
        End If
    End Sub

    Private Sub CenaTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DodajNarzędzieCena.KeyPress

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles LicznikWypożycz.Click

    End Sub

    Private Sub WypożyczTab_Click(sender As Object, e As EventArgs) Handles WypożyczTab.VisibleChanged

    End Sub
End Class
