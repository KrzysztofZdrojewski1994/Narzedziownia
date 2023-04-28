Public Class Menu
    Public sql As New SQLServerConnection
    Public SqlDostawca As New SQLServerConnection
    Public SqlNarzędzie As New SQLServerConnection
    Public SqlPracownik As New SQLServerConnection
    Public SqlSerwis As New SQLServerConnection
    Public SqlFakturySerwis As New SQLServerConnection
    Public SqlFaktury As New SQLServerConnection
    Public SqlTypNarzedzia As New SQLServerConnection
    Public SqlTypStanMagazynu As New SQLServerConnection
    Public SqlDoZwrotu As New SQLServerConnection


    Dim NarzędzieKL As New MyDataGridSetting
    Dim PracownikKL As New MyDataGridSetting
    Dim DostawcaKL As New MyDataGridSetting
    Dim SerwisKL As New MyDataGridSetting
    Dim DodajFaktureSerwisKL As New MyDataGridSetting
    Dim DodajFaktureKL As New MyDataGridSetting
    Dim TypNarzedziaKL As New MyDataGridSetting
    Dim WypozyczKL As New MyDataGridSetting
    Dim ZwrocKL As New MyDataGridSetting
    Dim OddajSerwisKL As New MyDataGridSetting
    Dim MojeWypozyczeniaKL As New MyDataGridSetting
    Dim OddajNaSerwisKL As New MyDataGridSetting
    Dim PodsumowanieNarzędziaKL As New MyDataGridSetting
    Dim HistoriaNarzędziaKL As New MyDataGridSetting
    Dim StanMagazynuKL As New MyDataGridSetting

    Public MyId As Integer = Logowanie.IDproperty
    Public MyLVL As String = Logowanie.LvlProperty



    Dim StringSqlHistoriaNarzędzia As String = "
        select *  from HistoriaNarzedziaView"

    Dim StringSqlDostawca As String = "
        select ID, Nazwa, Telefon, Mail, Opiekun, Miasto, Adres, KodPocztowy, NIP, Aktywny
        from Dostawca order by Id desc"
    Dim StringSqlNarzędzie As String = "
          Select narzedzia.ID, Model, TypNarzedzia.Nazwa as TypNarzedzia, narzedzia.Aktywny, NumerSeryjny, Gwarancja, DetaleFv.Cena
        from narzedzia 
        left join dbo.TypNarzedzia on
        TypNarzedzia.Id = narzedzia.TypNarzedziaID
		left join [DetaleFv] on
		 narzedzia.ID = DetaleFv.NarzedzieID
        Order by narzedzia.Id desc"
    Dim StringSqlPracownik As String = "
        Select ID, Imie, Nazwisko, eMail, 
        case when LvlDostep = 1 then 'Zwykły użytkownik' else 'Administrator' end as LvlDostep, LOGIN,  Aktywny
        from uzytkownicy 
        order by Id desc"
    Dim StringSqlSerwis As String = "
        Select ID, NazwaSerwisu, Telefon, Mail, Opiekun, Miasto, Adres, KodPocztowy, NIP, Aktywny 
        from serwis order by Id desc"
    Dim StringSqlFakturySerwis As String =
    "  Select FakturySerwis.ID, NrFaktury, DataFaktury, serwis.NazwaSerwisu, serwis.NIP, Serwis.Miasto, TerminPłatności, FormaPłatności, FakturySerwis.Aktywny, sum(DetaleSerwisFv.Cena) as Stawka
        from FakturySerwis 
        left join Serwis
        on SerwisID = serwis.ID
		left join DetaleSerwisFv
		on FakturySerwis.id = DetaleSerwisFv.FakturaSerwisID
		group by FakturySerwis.ID, NrFaktury, DataFaktury, serwis.NazwaSerwisu, serwis.NIP, Serwis.Miasto, TerminPłatności, FormaPłatności, FakturySerwis.Aktywny
        order by Id desc"
    Dim StringSqlFaktury As String = "
	    Select Faktury.ID, Faktury.NrFaktury, DataFaktury, Dostawca.Nazwa, Dostawca.NIP, Dostawca.Miasto, TerminPłatności, FormaPłatności, Faktury.Aktywny, SUM(DetaleFv.Cena) as Wartość
        from Faktury 
        Left join Dostawca
        on dostawcaID = Dostawca.ID
	    left join DetaleFv
	    on Faktury.id = DetaleFv.FakturaID 
	    group by Faktury.ID, Faktury.NrFaktury, DataFaktury, Dostawca.Nazwa, Dostawca.NIP, Dostawca.Miasto, TerminPłatności, FormaPłatności, Faktury.Aktywny
        order by Id desc"
    Dim StringSqlTypNarzedzia As String = "Select ID, Nazwa, Aktywny from TypNarzedzia order by Id desc"
    Dim StringSqlStanMagazynu As String = "SELECT [ID], [Model], [Nazwa], [NumerSeryjny], [Gwarancja] FROM [Narzedziownia2].[dbo].[StanMagazynu] order by Id desc"
    Dim StringSqlDoZwrotu As String = "Select [ID], [IDpracownika], [IDnarzedzia], [dataWypożyczenia], [dataZwrotu], [uwagi] fROM [Narzedziownia2].[dbo].[wypozyczenia] where (DataZwrotu IS NULL OR DataZwrotu = '') "
    Dim StringSqlDoZwrotuSerwis As String = "  Select [WydaniaSerwis].[ID], [IDserwis], serwis.NazwaSerwisu, serwis.Miasto, [IDnarzedzia], narzedzia.Model, narzedzia.NumerSeryjny, TypNarzedzia.Nazwa [dataWydania], [dataZwrotu], [uwagi] 
     fROM [Narzedziownia2].[dbo].[WydaniaSerwis] 
     left join serwis
     on [WydaniaSerwis].[IDserwis] = serwis.id
     left join narzedzia
     on [WydaniaSerwis].[IDnarzedzia] = narzedzia.id
     left join TypNarzedzia
     on TypNarzedzia.Id = narzedzia.TypNarzedziaID
     where DataZwrotu IS NULL OR DataZwrotu = ''"
    Dim StringMojeWypo As String = "Select [wypozyczenia].ID, [IDpracownika], uzytkownicy.Imie, uzytkownicy.Nazwisko, [IDnarzedzia], narzedzia.Model, narzedzia.NumerSeryjny, TypNarzedzia.nazwa, [dataWypożyczenia], [dataZwrotu], [uwagi] 
     fROM [Narzedziownia2].[dbo].[wypozyczenia] 
     Left Join narzedzia 
     on  wypozyczenia.IDnarzedzia = narzedzia.ID
     left join TypNarzedzia
     on narzedzia.TypNarzedziaID = TypNarzedzia.Id
     left join uzytkownicy 
     on wypozyczenia.IDpracownika = uzytkownicy.ID"
    Dim StringMojeWypoWhere As String
    Dim StringPodsumowanieNarzędzia As String = "Select * from PodsumowanieNarzędzia"

    Dim MyBindingSource As BindingSource
    Dim EditSqlString As String
    Dim tabelaNazwa As String

    Dim InputValidation As New InputValidation



    Function CheckBoxAktywny(Tabela As ADGV.AdvancedDataGridView, MyBindingSource As BindingSource, SqlServerConnection As Narzedziownia.SQLServerConnection, SqlString As String, SqlTable As String)


        If Tabela.CurrentCell.OwningColumn.HeaderText = "Aktywny" Then

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

    Function Validation(InputPanel As Panel, errLbl As Label) As Boolean
        If CheckFill(InputPanel) Then
            errLbl.Text = "Przed dodaniem uzupełnij wszystkie pola!"
            errLbl.Visible = True
            Validation = True
            Return Validation
        End If
        If CheckWarns(InputPanel) Then
            errLbl.Text = "Przed dodaniem popraw czerwone pola!"
            errLbl.Visible = True
            Validation = True
            Return Validation
        End If
    End Function
    Function ClearTxtInPanel(InputPanel As Panel, errLbl As Label)
        Dim InputCtrl As Control
        If errLbl.Text.Contains("Prawidłowo dodan") Then
            For Each InputCtrl In InputPanel.Controls
                If TypeOf InputCtrl Is TextBox Then
                    InputCtrl.Text = ""
                End If
            Next
        End If
    End Function



    Private Sub Narzędziownia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' MsgBox(my)
        ' MsgBox(MyLVL)

        StanMagazynuKL.RefreshData(StanMagazynuTabela, StringSqlStanMagazynu, LicznikStanMagazynu)
        HistoriaNarzędziaKL.RefreshData(HistoriaNarzędziaTabela, StringSqlHistoriaNarzędzia, LicznikHistoriaNarzędzia)
        PodsumowanieNarzędziaKL.RefreshData(PodsumowanieNarzędziTabela, StringPodsumowanieNarzędzia, PodsumowanieLicznik)

        sql.DodajKolumne(TabelaDodajNarzędzie, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajNarzędzie, "Aktywny")
        NarzędzieKL.RefreshData(TabelaDodajNarzędzie, StringSqlNarzędzie, LicznikNarzędzia)


        sql.DodajKolumne(TabelaDodajPracownika, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajPracownika, "Aktywny")
        PracownikKL.RefreshData(TabelaDodajPracownika, StringSqlPracownik, LicznikDodajPracownika)

        sql.DodajKolumne(TabelaDodajDostawce, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajDostawce, "Aktywny")
        DostawcaKL.RefreshData(TabelaDodajDostawce, StringSqlDostawca, LicznikDostawca)

        sql.DodajKolumne(TabelaDodajSerwis, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajSerwis, "Aktywny")
        SerwisKL.RefreshData(TabelaDodajSerwis, StringSqlSerwis, LicznikDodajSerwis)

        sql.DodajKolumne(TabelaDodajFaktureSerwis, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajFaktureSerwis, "Aktywny")
        DodajFaktureSerwisKL.RefreshData(TabelaDodajFaktureSerwis, StringSqlFakturySerwis, LicznikFakturySerwis)

        sql.DodajKolumne(TabelaDodajFakture, "ID")
        sql.DodajKolumneCheckbox(TabelaDodajFakture, "Aktywny")
        DodajFaktureKL.RefreshData(TabelaDodajFakture, StringSqlFaktury, LicznikFaktury)

        sql.DodajKolumne(TypNarzedziaTabela, "ID")
        sql.DodajKolumneCheckbox(TypNarzedziaTabela, "Aktywny")
        TypNarzedziaKL.RefreshData(TypNarzedziaTabela, StringSqlTypNarzedzia, LicznikTypNarzedzia)

        WypozyczKL.RefreshData(WypożyczTabela, StringSqlStanMagazynu, LicznikWypożycz)
        ZwrocKL.RefreshData(ZwróćTabela, StringSqlDoZwrotu, LicznikZwróc)

        OddajNaSerwisKL.RefreshData(SerwisOddajTabela, StringSqlStanMagazynu, LicznikOddajNaSerwis)
        OddajSerwisKL.RefreshData(PowrotSerwisTable, StringSqlDoZwrotuSerwis, LicznikPowrotSerwis)


        StringMojeWypoWhere = StringMojeWypo & " Where wypozyczenia.IDpracownika = '" & MyId & "'"
        MojeWypozyczeniaKL.RefreshData(TabelaMojeWypo, StringMojeWypoWhere, LicznikMojeWypo)

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

        IdNarzedziaWypożycz.DataSource = WypozyczKL.MyBindingSource
        IdNarzedziaWypożycz.ValueMember = "ID"



        IdNarzedzieOddajSerwis.DataSource = OddajNaSerwisKL.MyBindingSource
        IdNarzedzieOddajSerwis.ValueMember = "ID"


        PowrotSerwisIdNarzedzia.DataSource = OddajSerwisKL.MyBindingSource
        PowrotSerwisIdNarzedzia.ValueMember = "ID"
        PowrotSerwisIdNarzedzia.DisplayMember = "IDnarzedzia"


        If sql.ExecQueryDataSet("Select ID, cast([NIP] as varchar(max)) + ' ||| ' + [NazwaSerwisu] + ' ||| ' + [Miasto] as FullName from [serwis] where aktywny = 1") IsNot Nothing Then
            IdSerwisOddaj.DataSource = sql.ExecQueryDataSet("Select ID, cast([NIP] as varchar(max)) + ' ||| ' + [NazwaSerwisu] + ' ||| ' + [Miasto] as FullName from [serwis] where aktywny = 1").Tables(0)
            IdSerwisOddaj.DisplayMember = "FullName"
            IdSerwisOddaj.ValueMember = "ID"
        End If

        Dim sqlString As String
        sqlString = "select ID, cast(DataFaktury as varchar(max))  + ' ||| ' + NrFaktury as Fullname from FakturySerwis
        Where  Aktywny = 1 and SerwisID = (Select [IDserwis] from [WydaniaSerwis] where ID = '" & PowrotSerwisIdNarzedzia.SelectedValue & "')"
        If sql.ExecQueryDataSet(sqlString) IsNot Nothing Then
            PowrotSerwisNrFaktury.DataSource = sql.ExecQueryDataSet(sqlString).Tables(0)
            PowrotSerwisNrFaktury.DisplayMember = "FullName"
            PowrotSerwisNrFaktury.ValueMember = "ID"
        End If

        If MyLVL = 1 Then
            Dim WybierzIdWypożycz As New Dictionary(Of String, String)()
            WybierzIdWypożycz.Add(MyId, MyId)
            ' Tu robimy sprawdzenie czy amidn czy zwykły admin ma dostęp do wszyskich id zwykły ma tylko do swojego. Jak dodamy brygady to i brygdzisci mogą do wszystkich którzy mają te samo id co jego brygada
            ' tak samo ogarniamy StringSqlDoZwrotu żeb widzieli tylko to na co mają uprawnienia
            StringSqlDoZwrotu = StringSqlDoZwrotu & " And IDpracownika = " & MyId & " order by ID desc"
            IdPracownikaWypozycz.DataSource = New BindingSource(WybierzIdWypożycz, Nothing)
            IdPracownikaWypozycz.DisplayMember = "Value"
            IdPracownikaWypozycz.ValueMember = "Key"
            IdPracownikaMojeWypo.Visible = False
            ChckFiltrPracownika.Visible = False
            WybierzWypo.Visible = False
            IdPracownikaMojeWypoLabel.Visible = False
            MyTab.TabPages.Remove(MyTab.TabPages("DodajPracownika"))
            MyTab.TabPages.Remove(MyTab.TabPages("DodajNarzędzie"))
            MyTab.TabPages.Remove(MyTab.TabPages("DodajSerwis"))
            MyTab.TabPages.Remove(MyTab.TabPages("StanMagazynu"))
            MyTab.TabPages.Remove(MyTab.TabPages("OddajNaSerwis"))
            MyTab.TabPages.Remove(MyTab.TabPages("PowrótZserwisu"))
            MyTab.TabPages.Remove(MyTab.TabPages("DodajDostawce"))
            MyTab.TabPages.Remove(MyTab.TabPages("HistoriaNarzędzia"))
            MyTab.TabPages.Remove(MyTab.TabPages("DodajFakture"))
            MyTab.TabPages.Remove(MyTab.TabPages("DodajFaktureSerwis"))
            MyTab.TabPages.Remove(MyTab.TabPages("TypNarzedzia"))
            MyTab.TabPages.Remove(MyTab.TabPages("Edytuj"))
            MyTab.TabPages.Remove(MyTab.TabPages("PodsumowanieNarzędzi"))
            AdminToolStrip.Visible = False
            RaportyToolStripMenuItem.Visible = False

            ' DodajPracownika.Visible = False

        ElseIf MyLVL = 2 Then
            ' MsgBox(sql.ExecQueryDataSet("Select ID from uzytkownicy where aktywny = 1").Tables(0).Rows)

            'For Each elem As String In sql.ExecQueryToList("Select ID from uzytkownicy where aktywny = 1")
            '    WybierzIdWypożycz.Add(elem, elem)
            'Next

            IdPracownikaWypozycz.DataSource = sql.ExecQueryDataSet("Select ID, cast(ID as varchar(max)) + ' ||| ' + [Imie] + ' ||| ' + [Nazwisko] as FullName from uzytkownicy where aktywny = 1").Tables(0)
            IdPracownikaWypozycz.DisplayMember = "FullName"
            IdPracownikaWypozycz.ValueMember = "ID"

            IdPracownikaMojeWypo.DataSource = sql.ExecQueryDataSet("Select ID, cast(ID as varchar(max)) + ' ||| ' + [Imie] + ' ||| ' + [Nazwisko] as FullName from uzytkownicy where aktywny = 1").Tables(0)
            IdPracownikaMojeWypo.DisplayMember = "FullName"
            IdPracownikaMojeWypo.ValueMember = "ID"
            'For Each MyDataRow In sql.ExecQueryDataSet("Select ID from uzytkownicy where aktywny = 1").Tables(0).Rows
            '    'WybierzIdWypożycz.Add(MyId, MyId)

            '    MsgBox("Stes")
            'Next
            StringSqlDoZwrotu = StringSqlDoZwrotu & " order by ID desc"
        End If

    End Sub
    Private Sub OddajNaSerwis_VisibleChanged(sender As Object, e As EventArgs) Handles OddajNaSerwis.VisibleChanged
        If Me.Visible = True Then
            OddajNaSerwisKL.RefreshData(SerwisOddajTabela, StringSqlStanMagazynu, LicznikOddajNaSerwis)

            IdNarzedzieOddajSerwis.DataSource = OddajNaSerwisKL.MyBindingSource
            IdNarzedzieOddajSerwis.ValueMember = "ID"


            If sql.ExecQueryDataSet("Select ID, cast([NIP] as varchar(max)) + ' ||| ' + [NazwaSerwisu] + ' ||| ' + [Miasto] as FullName from [serwis] where aktywny = 1") IsNot Nothing Then
                IdSerwisOddaj.DataSource = sql.ExecQueryDataSet("Select ID, cast([NIP] as varchar(max)) + ' ||| ' + [NazwaSerwisu] + ' ||| ' + [Miasto] as FullName from [serwis] where aktywny = 1").Tables(0)
                IdSerwisOddaj.DisplayMember = "FullName"
                IdSerwisOddaj.ValueMember = "ID"
            End If
        End If



    End Sub
    Private Sub PowrótZserwisu_VisibleChanged(sender As Object, e As EventArgs) Handles PowrótZserwisu.VisibleChanged
        If Me.Visible = True Then
            OddajSerwisKL.RefreshData(PowrotSerwisTable, StringSqlDoZwrotuSerwis, LicznikPowrotSerwis)
            Dim sqlString As String
            sqlString = "select ID, cast(DataFaktury as varchar(max))  + ' ||| ' + NrFaktury as Fullname from FakturySerwis
            Where  Aktywny = 1 and SerwisID = (Select [IDserwis] from [WydaniaSerwis] where ID = '" & PowrotSerwisIdNarzedzia.SelectedValue & "')"
            If sql.ExecQueryDataSet(sqlString) IsNot Nothing Then
                PowrotSerwisNrFaktury.DataSource = sql.ExecQueryDataSet(sqlString).Tables(0)
                PowrotSerwisNrFaktury.DisplayMember = "FullName"
                PowrotSerwisNrFaktury.ValueMember = "ID"
            End If
            PowrotSerwisIdNarzedzia.DataSource = OddajSerwisKL.MyBindingSource
            PowrotSerwisIdNarzedzia.ValueMember = "ID"
            PowrotSerwisIdNarzedzia.DisplayMember = "IDnarzedzia"
        End If
    End Sub

    Private Sub DodajDostawce_VisibleChanged(sender As Object, e As EventArgs) Handles DodajDostawce.VisibleChanged
        If Me.Visible = True Then
            DostawcaKL.RefreshData(TabelaDodajDostawce, StringSqlDostawca, LicznikDostawca)
        End If
    End Sub
    Private Sub DodajFakture_VisibleChanged(sender As Object, e As EventArgs) Handles DodajFakture.VisibleChanged
        ErrLabelNarzędzie.Visible = False
        If Me.Visible = True Then
            DodajFaktureKL.RefreshData(TabelaDodajFakture, StringSqlFaktury, LicznikFaktury)
        End If

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
        If Me.Visible = True Then
            NarzędzieKL.RefreshData(TabelaDodajNarzędzie, StringSqlNarzędzie, LicznikNarzędzia)
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
    Private Sub DodajFaktureSerwis_Click(sender As Object, e As EventArgs) Handles DodajFaktureSerwis.VisibleChanged
        If Me.Visible = True Then
            DodajFaktureSerwisKL.RefreshData(TabelaDodajFaktureSerwis, StringSqlFakturySerwis, LicznikFakturySerwis)
        End If

        DodajFaktureSerwisDataFaktury.Value = DateTime.Now.ToShortDateString()
        DodajFaktureSerwisDataFaktury.MaxDate = Now
        DodajFaktureSerwisDataPłatności.MinDate = DateAdd("m", -1, Now)
        DodajFaktureSerwisDataPłatności.Value = Now
        DodajFaktureSerwisWybierzDostawce.DataSource = sql.ExecQueryDataSet("Select ID, cast(NIP as varchar(max)) + ' ||| ' + NazwaSerwisu + ' ||| ' + Miasto as FullName from dbo.serwis Where Aktywny = 1").Tables(0)
        DodajFaktureSerwisWybierzDostawce.DisplayMember = "FullName"
        DodajFaktureSerwisWybierzDostawce.ValueMember = "ID"
    End Sub
    Private Sub ZwróćTabela_VisibleChanged(sender As Object, e As EventArgs) Handles ZwróćTabela.VisibleChanged
        If Me.Visible = True Then
            ZwrocKL.RefreshData(ZwróćTabela, StringSqlDoZwrotu, LicznikZwróc)
            IdNarzędziaZwróć.DataSource = ZwrocKL.MyBindingSource
            IdNarzędziaZwróć.DisplayMember = "IDnarzedzia"
            IdNarzędziaZwróć.ValueMember = "IDnarzedzia"
        End If

    End Sub

    Private Sub WypożyczTab_VisibleChanged(sender As Object, e As EventArgs) Handles WypożyczTab.VisibleChanged
        If Me.Visible = True Then
            WypozyczKL.RefreshData(WypożyczTabela, StringSqlStanMagazynu, LicznikWypożycz)
            If MyLVL = 2 Then
                IdPracownikaWypozycz.DataSource = sql.ExecQueryDataSet("Select ID, cast(ID as varchar(max)) + ' ||| ' + [Imie] + ' ||| ' + [Nazwisko] as FullName from uzytkownicy where aktywny = 1").Tables(0)
                IdPracownikaWypozycz.DisplayMember = "FullName"
                IdPracownikaWypozycz.ValueMember = "ID"
            End If
            IdNarzedziaWypożycz.DataSource = WypozyczKL.MyBindingSource
            IdNarzedziaWypożycz.ValueMember = "ID"
        End If

    End Sub
    Private Sub MojeWypożyczenia_VisibleChanged(sender As Object, e As EventArgs) Handles MojeWypożyczenia.VisibleChanged
        If Me.Visible = True Then
            '  WypozyczKL.RefreshData(WypożyczTabela, StringSqlStanMagazynu, LicznikWypożycz)

            MojeWypozyczeniaKL.RefreshData(TabelaMojeWypo, StringMojeWypoWhere, LicznikMojeWypo)
            If MyLVL = 2 Then
                IdPracownikaMojeWypo.DataSource = sql.ExecQueryDataSet("Select ID, cast(ID as varchar(max)) + ' ||| ' + [Imie] + ' ||| ' + [Nazwisko] as FullName from uzytkownicy where aktywny = 1").Tables(0)
                IdPracownikaMojeWypo.DisplayMember = "FullName"
                IdPracownikaMojeWypo.ValueMember = "ID"
            End If
        End If


    End Sub

    Private Sub DodajDostawceBtn_Click(sender As Object, e As EventArgs) Handles DodajDostawceBtn.Click

        If Validation(PanelDostawca, ErrLabelDostawca) Then
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

        DostawcaKL.RefreshData(TabelaDodajDostawce, StringSqlDostawca, LicznikDostawca)
        ClearTxtInPanel(PanelDostawca, ErrLabelDostawca)


    End Sub
    Private Sub DodajSerwisDodaj_Click(sender As Object, e As EventArgs) Handles DodajSerwisDodaj.Click

        If Validation(PanelDodajSerwis, ErrLabelDodajSerwis) Then
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

        SerwisKL.RefreshData(TabelaDodajSerwis, StringSqlSerwis, LicznikDodajSerwis)
        ClearTxtInPanel(PanelDodajSerwis, ErrLabelDodajSerwis)
    End Sub

    Private Sub DodajNarzędzieBtn_Click(sender As Object, e As EventArgs) Handles DodajNarzędzieBtn.Click

        If Validation(PanelNarzędzie, ErrLabelNarzędzie) Then
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

        NarzędzieKL.RefreshData(TabelaDodajNarzędzie, StringSqlNarzędzie, LicznikNarzędzia)
        ClearTxtInPanel(PanelNarzędzie, ErrLabelNarzędzie)

    End Sub

    Private Sub DodajFaktureBtn_Click(sender As Object, e As EventArgs) Handles DodajFaktureBtn.Click

        If Validation(PanelDodajFakture, ErrLabelFaktura) Then
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

        DodajFaktureKL.RefreshData(TabelaDodajFakture, StringSqlFaktury, LicznikFaktury)
        ClearTxtInPanel(PanelDodajFakture, ErrLabelFaktura)



    End Sub

    Private Sub DodajPracownikaBtn_Click(sender As Object, e As EventArgs) Handles DodajPracownikaBtn.Click
        If Validation(PanelDodajPracownika, ErrLabelPracownik) Then
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

        PracownikKL.RefreshData(TabelaDodajPracownika, StringSqlPracownik, LicznikDodajPracownika)
        ClearTxtInPanel(PanelDodajPracownika, ErrLabelPracownik)


    End Sub
    Private Sub DodajFaktureSerwisBtn_Click(sender As Object, e As EventArgs) Handles DodajFaktureSerwisBtn.Click
        If Validation(PanelDodajFaktureSerwis, ErrLabelFakturaSerwis) Then
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

        DodajFaktureSerwisKL.RefreshData(TabelaDodajFaktureSerwis, StringSqlFakturySerwis, LicznikFakturySerwis)
        ClearTxtInPanel(PanelDodajFaktureSerwis, ErrLabelFakturaSerwis)

    End Sub

    Private Sub TypNarzedziaBTN_Click(sender As Object, e As EventArgs) Handles TypNarzedziaBTN.Click
        If Validation(TypNarzedziaPanel, ErrLabelTypNarzedzia) Then
            Exit Sub
        End If

        sql.ArrayFill("@Nazwa", TypNarzedziaTxt.Text, 1)
        sql.ArrayFill("@Desc", "", 2)

        ErrLabelTypNarzedzia.Text = sql.SpExec("[dbo].[DodajTypNarzedzia]", "@Desc")
        ErrLabelTypNarzedzia.Visible = True

        TypNarzedziaKL.RefreshData(TypNarzedziaTabela, StringSqlTypNarzedzia, LicznikTypNarzedzia)
        ClearTxtInPanel(TypNarzedziaPanel, ErrLabelTypNarzedzia)

    End Sub
    Private Sub OddajSerwsiBtn_Click(sender As Object, e As EventArgs) Handles OddajSerwsiBtn.Click

        sql.ArrayFill("@idSerwisu", IdSerwisOddaj.SelectedValue, 1)
        sql.ArrayFill("@idNarzędzia", IdNarzedzieOddajSerwis.SelectedValue, 1)
        sql.ArrayFill("@Desc", "", 2)
        sql.ArrayFill("@Uwagi", UwagiOddajSerwis.Text, 1)

        ErrLblSerwisOddaj.Text = sql.SpExec("[dbo].[OddajSerwis]", "@Desc")
        ErrLblSerwisOddaj.Visible = True

        OddajNaSerwisKL.RefreshData(SerwisOddajTabela, StringSqlStanMagazynu, LicznikOddajNaSerwis)

        ClearTxtInPanel(WydajPanel, ErrLblSerwisOddaj)
    End Sub


    Private Sub DodajFaktureSerwisMenu_Click(sender As Object, e As EventArgs) Handles FakturaSerwisMenu.Click
        MyTab.SelectedTab = DodajFaktureSerwis
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
                WybierzKolumneSource.Add("1", "NumerSeryjny")
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

    Private Sub EdytujTabela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EdytujTabela.CellClick
        For i = 0 To WybierzKolumne.Items.Count - 1
            If WybierzKolumne.Items.Item(i).ToString().ToLower().Contains(EdytujTabela.CurrentCell.OwningColumn.Name.ToString.ToLower()) Then
                WybierzKolumne.SelectedIndex = i
            End If
        Next
    End Sub
    Private Sub EdytujTabela_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EdytujTabela.CellContentDoubleClick

        CheckBoxAktywny(EdytujTabela, MyBindingSource, sql, EditSqlString, tabelaNazwa)
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

    Private Sub WypożyczBtn_Click(sender As Object, e As EventArgs) Handles WypożyczBtn.Click

        sql.ArrayFill("@idPracownika", IdPracownikaWypozycz.SelectedValue, 1)
        sql.ArrayFill("@idNarzędzia", IdNarzedziaWypożycz.SelectedValue, 1)
        sql.ArrayFill("@Desc", "", 2)
        sql.ArrayFill("@Uwagi", UwagiWypożycz.Text, 1)

        ErrLabelFaktura.Text = sql.SpExec("[dbo].[Wypożycz]", "@Desc")
        ErrLabelFaktura.Visible = True

        WypozyczKL.RefreshData(WypożyczTabela, StringSqlStanMagazynu, LicznikWypożycz)

        ClearTxtInPanel(WypożyczPanel, ErrLblWypożycz)

    End Sub
    Private Sub PowrotSerwisBtn_Click(sender As Object, e As EventArgs) Handles PowrotSerwisBtn.Click
        sql.ArrayFill("@FakturaSerwisID", PowrotSerwisNrFaktury.SelectedValue, 1)
        sql.ArrayFill("@WydanieID", PowrotSerwisIdNarzedzia.SelectedValue, 1)
        sql.ArrayFill("@Cena", PowrotSerwisStawka.Text, 1)
        sql.ArrayFill("@Desc", "", 2)
        '     sql.ArrayFill("@Uwagi", PowrotSerwisUwagi.Text, 1)

        ErrLblPowrotSerwis.Text = sql.SpExec("[dbo].[DodajDetaleFakturSerwis]", "@Desc")
        ErrLblPowrotSerwis.Visible = True

        OddajSerwisKL.RefreshData(PowrotSerwisTable, StringSqlDoZwrotuSerwis, LicznikPowrotSerwis)
        ClearTxtInPanel(PowrotSerwisPanel, ErrLblPowrotSerwis)
    End Sub


    Private Sub ZwróćTabela_FilterStringChanged(sender As Object, e As EventArgs) Handles ZwróćTabela.FilterStringChanged
        ZwrocKL.RefreshData(ZwróćTabela, StringSqlDoZwrotu, LicznikZwróc)
    End Sub

    Private Sub ZwróćBtn_Click(sender As Object, e As EventArgs) Handles ZwróćBtn.Click

        sql.ArrayFill("@idNarzędzia", IdNarzędziaZwróć.SelectedValue, 1)
        sql.ArrayFill("@Desc", "", 2)
        sql.ArrayFill("@Uwagi", UwagiZwróć.Text, 1)

        ErrLabelZwróc.Text = sql.SpExec("[dbo].[Zwroc]", "@Desc")
        ErrLabelZwróc.Visible = True

        ZwrocKL.RefreshData(ZwróćTabela, StringSqlDoZwrotu, LicznikZwróc)
        ClearTxtInPanel(ZwróćPanel, ErrLabelZwróc)

    End Sub
    Private Sub ChckFiltrPracownika_CheckedChanged(sender As Object, e As EventArgs) Handles ChckFiltrPracownika.CheckedChanged

        If ChckFiltrPracownika.Checked Then
            StringMojeWypoWhere = StringMojeWypo & " Where IDpracownika = '" & IdPracownikaMojeWypo.SelectedValue & "'"
            MojeWypozyczeniaKL.RefreshData(TabelaMojeWypo, StringMojeWypoWhere, LicznikMojeWypo)
        Else
            MojeWypozyczeniaKL.RefreshData(TabelaMojeWypo, StringMojeWypo, LicznikMojeWypo)
        End If
    End Sub

    Private Sub IdPracownikaMojeWypo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdPracownikaMojeWypo.SelectedIndexChanged
        If ChckFiltrPracownika.Checked Then
            StringMojeWypoWhere = StringMojeWypo & " Where IDpracownika = '" & IdPracownikaMojeWypo.SelectedValue & "'"
            MojeWypozyczeniaKL.RefreshData(TabelaMojeWypo, StringMojeWypoWhere, LicznikMojeWypo)
        End If
    End Sub


    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------- Checkbox in Tabel ----------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------

    Private Sub TabelaDodajSerwis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajSerwis.CellClick
        CheckBoxAktywny(TabelaDodajSerwis, SerwisKL.MyBindingSource, SqlSerwis, StringSqlSerwis, "Serwis")
    End Sub

    Private Sub TypNarzedziaTabela_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TypNarzedziaTabela.CellClick
        CheckBoxAktywny(TypNarzedziaTabela, TypNarzedziaKL.MyBindingSource, SqlTypNarzedzia, StringSqlTypNarzedzia, "TypNarzedzia")
    End Sub

    Private Sub TabelaDodajDostawce_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajDostawce.CellClick
        CheckBoxAktywny(TabelaDodajDostawce, DostawcaKL.MyBindingSource, SqlDostawca, StringSqlDostawca, "Dostawca")
    End Sub

    Private Sub TabelaDodajNarzędzie_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajNarzędzie.CellClick
        CheckBoxAktywny(TabelaDodajNarzędzie, NarzędzieKL.MyBindingSource, SqlNarzędzie, StringSqlNarzędzie, "narzedzia")
    End Sub

    Private Sub TabelaDodajPracownika_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajPracownika.CellClick
        CheckBoxAktywny(TabelaDodajPracownika, PracownikBinding, SqlPracownik, StringSqlPracownik, "uzytkownicy")
    End Sub
    Private Sub TabelaDodajFaktureSerwis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajFaktureSerwis.CellClick
        CheckBoxAktywny(TabelaDodajFaktureSerwis, DodajFaktureSerwisKL.MyBindingSource, SqlFakturySerwis, StringSqlFakturySerwis, "FakturySerwis")
    End Sub

    Private Sub TabelaDodajFakture_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TabelaDodajFakture.CellClick
        CheckBoxAktywny(TabelaDodajFakture, DodajFaktureKL.MyBindingSource, SqlFaktury, StringSqlFaktury, "faktury")
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------- INPUT Validation --------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------


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
        MyTab.SelectedTab = DodajFakture
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


    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------- Menu Select --------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------------

    Private Sub Wypożycz_Click(sender As Object, e As EventArgs) Handles Wypożycz.Click
        MyTab.SelectedTab = WypożyczTab
    End Sub

    Private Sub Zwrot_Click(sender As Object, e As EventArgs) Handles Zwrot.Click
        MyTab.SelectedTab = ZwróćTab
    End Sub

    Private Sub SprawdźMojeWypożyczeniaMenu_Click(sender As Object, e As EventArgs) Handles SprawdźMojeWypożyczeniaMenu.Click
        MyTab.SelectedTab = MojeWypożyczenia
    End Sub

    Private Sub StanMagazynuMenu_Click(sender As Object, e As EventArgs) Handles StanMagazynuMenu.Click
        MyTab.SelectedTab = StanMagazynu
    End Sub

    Private Sub DodajNarzedzieMenu_Click(sender As Object, e As EventArgs) Handles NarzedzieMenu.Click
        MyTab.SelectedTab = DodajNarzędzie
    End Sub

    Private Sub DodajPracownikaMenu_Click(sender As Object, e As EventArgs) Handles PracownikMenu.Click
        MyTab.SelectedTab = DodajPracownika
    End Sub

    Private Sub DodajSerwisMenu_Click(sender As Object, e As EventArgs) Handles SerwisMenu.Click
        MyTab.SelectedTab = DodajSerwis
    End Sub

    Private Sub DodajDostawceMenu_Click(sender As Object, e As EventArgs) Handles DostawceMenu.Click
        MyTab.SelectedTab = DodajDostawce
    End Sub

    Private Sub OddajNaSerwisMenu_Click(sender As Object, e As EventArgs) Handles OddajNaSerwisMenu.Click
        MyTab.SelectedTab = OddajNaSerwis
    End Sub

    Private Sub HistoriaNarzędziaMenu_Click(sender As Object, e As EventArgs) Handles HistoriaNarzędziaMenu.Click
        MyTab.SelectedTab = HistoriaNarzędzia
    End Sub

    Private Sub PowrotZserwisuMenu_Click(sender As Object, e As EventArgs) Handles PowrotZserwisuMenu.Click
        MyTab.SelectedTab = PowrótZserwisu
    End Sub



    Private Sub PowrotSerwisIdNarzedzia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PowrotSerwisIdNarzedzia.SelectedIndexChanged
        Dim sqlString As String
        sqlString = "select ID, cast(DataFaktury as varchar(max))  + ' ||| ' + NrFaktury as Fullname from FakturySerwis
        Where  Aktywny = 1 and SerwisID = (Select [IDserwis] from [WydaniaSerwis] where ID = '" & PowrotSerwisIdNarzedzia.SelectedValue & "')"

        If sql.ExecQueryDataSet(sqlString) IsNot Nothing Then
            PowrotSerwisNrFaktury.DataSource = sql.ExecQueryDataSet(sqlString).Tables(0)
            PowrotSerwisNrFaktury.DisplayMember = "FullName"
            PowrotSerwisNrFaktury.ValueMember = "ID"
        Else
            PowrotSerwisNrFaktury.Items.Clear()
        End If


    End Sub


End Class



