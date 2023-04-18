<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ObsługaWypożyczeńToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Wypożycz = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zwrot = New System.Windows.Forms.ToolStripMenuItem()
        Me.SprawdźMojeWypożyczeniaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.NarzedzieMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajNarzedzieMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujNarzedzieMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracownikMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajPracownikMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujPracownikMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FakturyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DostawceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DostawcaDodajMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujDostawceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FakturaSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajFaktureSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujFaktureSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypNarzędziaToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajTypNarzedziaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujTypNarzedziaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Admin = New System.Windows.Forms.ToolStripSeparator()
        Me.OddajNaSerwisMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowrotZserwisuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaportyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StanMagazynuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.WypożyczeniaNaPracownikaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriaNarzędziaMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Narzedziownia2DataSet1 = New Narzedziownia.Narzedziownia2DataSet1()
        Me.Narzedziownia2DataSet5 = New Narzedziownia.Narzedziownia2DataSet5()
        Me.Narzedziownia2DataSet4 = New Narzedziownia.Narzedziownia2DataSet4()
        Me.UzytkownicyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarzedziaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Narzedziownia2DataSet2 = New Narzedziownia.Narzedziownia2DataSet2()
        Me.Narzedziownia2DataSet7 = New Narzedziownia.Narzedziownia2DataSet7()
        Me.Narzedziownia2DataSet = New Narzedziownia.Narzedziownia2DataSet()
        Me.FakturyTableAdapter = New Narzedziownia.Narzedziownia2DataSetTableAdapters.FakturyTableAdapter()
        Me.DostawcaTableAdapter = New Narzedziownia.Narzedziownia2DataSet1TableAdapters.DostawcaTableAdapter()
        Me.NarzedziaTableAdapter = New Narzedziownia.Narzedziownia2DataSet2TableAdapters.narzedziaTableAdapter()
        Me.Narzedziownia2DataSet3 = New Narzedziownia.Narzedziownia2DataSet3()
        Me.UzytkownicyTableAdapter = New Narzedziownia.Narzedziownia2DataSet3TableAdapters.uzytkownicyTableAdapter()
        Me.SerwisTableAdapter = New Narzedziownia.Narzedziownia2DataSet4TableAdapters.serwisTableAdapter()
        Me.SerwisTableAdapter1 = New Narzedziownia.Narzedziownia2DataSet5TableAdapters.serwisTableAdapter()
        Me.Narzedziownia2DataSet6 = New Narzedziownia.Narzedziownia2DataSet6()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypNarzedziaTableAdapter = New Narzedziownia.Narzedziownia2DataSet6TableAdapters.TypNarzedziaTableAdapter()
        Me.DostawcaTableAdapter1 = New Narzedziownia.Narzedziownia2DataSet7TableAdapters.DostawcaTableAdapter()
        Me.Edytuj = New System.Windows.Forms.TabPage()
        Me.EdytujTabela = New ADGV.AdvancedDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxLvlDostępEdytuj = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.ComboBoxID = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.WybierzKolumne = New System.Windows.Forms.ComboBox()
        Me.TabelaWybierz = New System.Windows.Forms.ComboBox()
        Me.LicznikEdytuj = New System.Windows.Forms.Label()
        Me.EdytowanaWartosc = New System.Windows.Forms.TextBox()
        Me.ZmienBtn = New System.Windows.Forms.Button()
        Me.ErrLblEdit = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TypNarzedzia = New System.Windows.Forms.TabPage()
        Me.TypNarzedziaTabela = New ADGV.AdvancedDataGridView()
        Me.TypNarzedziaPanel = New System.Windows.Forms.Panel()
        Me.LicznikTypNarzedzia = New System.Windows.Forms.Label()
        Me.TypNarzedziaTxt = New System.Windows.Forms.TextBox()
        Me.TypNarzedziaBTN = New System.Windows.Forms.Button()
        Me.ErrLabelTypNarzedzia = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwis = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabelaDodajFaktureSerwis = New ADGV.AdvancedDataGridView()
        Me.PanelDodajFaktureSerwis = New System.Windows.Forms.Panel()
        Me.LicznikFakturySerwis = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwisFormaPłatności = New System.Windows.Forms.ComboBox()
        Me.DodajFaktureSerwisDataPłatności = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwisBtn = New System.Windows.Forms.Button()
        Me.ErrLabelFakturaSerwis = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwisDataFaktury = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwisWybierzDostawce = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DodajFaktureSerwisNrFaktury = New System.Windows.Forms.TextBox()
        Me.DodajFakture = New System.Windows.Forms.TabPage()
        Me.TabelaDodajFakture = New ADGV.AdvancedDataGridView()
        Me.PanelDodajFakture = New System.Windows.Forms.Panel()
        Me.LicznikFaktury = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DodajFaktureFormaPłatności = New System.Windows.Forms.ComboBox()
        Me.DodajFaktureDataPłatności = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DodajFaktureBtn = New System.Windows.Forms.Button()
        Me.ErrLabelFaktura = New System.Windows.Forms.Label()
        Me.DodajFaktureDataFaktury = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DodajFaktureWybierzDostawce = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DodajFaktureNrFaktury = New System.Windows.Forms.TextBox()
        Me.HistoriaNarzędzia = New System.Windows.Forms.TabPage()
        Me.DodajDostawce = New System.Windows.Forms.TabPage()
        Me.TabelaDodajDostawce = New ADGV.AdvancedDataGridView()
        Me.PanelDostawca = New System.Windows.Forms.Panel()
        Me.LicznikDostawca = New System.Windows.Forms.Label()
        Me.DostawcaKodPocztowy = New System.Windows.Forms.TextBox()
        Me.DostawcaNip = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DostawcaMiasto = New System.Windows.Forms.TextBox()
        Me.DostawcaNazwa = New System.Windows.Forms.TextBox()
        Me.DodajDostawceBtn = New System.Windows.Forms.Button()
        Me.ErrLabelDostawca = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DostawcaAdres = New System.Windows.Forms.TextBox()
        Me.DostawcaOpiekun = New System.Windows.Forms.TextBox()
        Me.DostawcaMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DostawcaTelefon = New System.Windows.Forms.TextBox()
        Me.PowrótZserwisu = New System.Windows.Forms.TabPage()
        Me.OddajNaSerwis = New System.Windows.Forms.TabPage()
        Me.StanMagazynu = New System.Windows.Forms.TabPage()
        Me.DodajSerwis = New System.Windows.Forms.TabPage()
        Me.TabelaDodajSerwis = New ADGV.AdvancedDataGridView()
        Me.PanelDodajSerwis = New System.Windows.Forms.Panel()
        Me.LicznikDodajSerwis = New System.Windows.Forms.Label()
        Me.DodajSerwisKodPocztowy = New System.Windows.Forms.TextBox()
        Me.DodajSerwisNIP = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DodajSerwisMiasto = New System.Windows.Forms.TextBox()
        Me.DodajSerwisNazwa = New System.Windows.Forms.TextBox()
        Me.DodajSerwisDodaj = New System.Windows.Forms.Button()
        Me.ErrLabelDodajSerwis = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DodajSerwisAdres = New System.Windows.Forms.TextBox()
        Me.DodajSerwisOpiekun = New System.Windows.Forms.TextBox()
        Me.DodajSerwisMail = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.DodajSerwisTelefon = New System.Windows.Forms.TextBox()
        Me.DodajPracownika = New System.Windows.Forms.TabPage()
        Me.TabelaDodajPracownika = New ADGV.AdvancedDataGridView()
        Me.PanelDodajPracownika = New System.Windows.Forms.Panel()
        Me.DodajPracownikaImie = New System.Windows.Forms.TextBox()
        Me.LicznikDodajPracownika = New System.Windows.Forms.Label()
        Me.DodajPracownikLvlDostep = New System.Windows.Forms.ComboBox()
        Me.DodajPracownikaBtn = New System.Windows.Forms.Button()
        Me.ErrLabelPracownik = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DodajPracownikaHaslo = New System.Windows.Forms.TextBox()
        Me.DodajPracownikaLogin = New System.Windows.Forms.TextBox()
        Me.DodajPracownikaMail = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DodajPracownikaNazwisko = New System.Windows.Forms.TextBox()
        Me.DodajNarzędzie = New System.Windows.Forms.TabPage()
        Me.TabelaDodajNarzędzie = New ADGV.AdvancedDataGridView()
        Me.PanelNarzędzie = New System.Windows.Forms.Panel()
        Me.DodajNarzędzieTyp = New System.Windows.Forms.ComboBox()
        Me.LicznikNarzędzia = New System.Windows.Forms.Label()
        Me.DodajNarzędzieBtn = New System.Windows.Forms.Button()
        Me.ErrLabelNarzędzie = New System.Windows.Forms.Label()
        Me.DodajNarzędzieGwarancja = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DodajNarzędzieWybierzFakture = New System.Windows.Forms.ComboBox()
        Me.DodajNarzędzieCena = New System.Windows.Forms.TextBox()
        Me.DodajNarzędzieNumerSeryjny = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DodajNarzędzieModel = New System.Windows.Forms.TextBox()
        Me.MojeWypożyczenia = New System.Windows.Forms.TabPage()
        Me.TabelaMojeWypo = New ADGV.AdvancedDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChckFiltrPracownika = New System.Windows.Forms.CheckBox()
        Me.IdPracownikaMojeWypo = New System.Windows.Forms.ComboBox()
        Me.LicznikMojeWypo = New System.Windows.Forms.Label()
        Me.WybierzWypo = New System.Windows.Forms.Button()
        Me.ErrLabelMojeWypożyczenia = New System.Windows.Forms.Label()
        Me.IdPracownikaMojeWypoLabel = New System.Windows.Forms.Label()
        Me.ZwróćTab = New System.Windows.Forms.TabPage()
        Me.ZwróćTabela = New ADGV.AdvancedDataGridView()
        Me.ZwróćPanel = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.UwagiZwróć = New System.Windows.Forms.TextBox()
        Me.IdNarzędziaZwróć = New System.Windows.Forms.ComboBox()
        Me.LicznikZwróc = New System.Windows.Forms.Label()
        Me.ZwróćBtn = New System.Windows.Forms.Button()
        Me.ErrLabelZwróc = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.WypożyczTab = New System.Windows.Forms.TabPage()
        Me.WypożyczTabela = New ADGV.AdvancedDataGridView()
        Me.WypożyczPanel = New System.Windows.Forms.Panel()
        Me.UwagiLblWypożycz = New System.Windows.Forms.Label()
        Me.UwagiWypożycz = New System.Windows.Forms.TextBox()
        Me.IdNarzedziaWypożycz = New System.Windows.Forms.ComboBox()
        Me.LicznikWypożycz = New System.Windows.Forms.Label()
        Me.WypożyczBtn = New System.Windows.Forms.Button()
        Me.ErrLblWypożycz = New System.Windows.Forms.Label()
        Me.IDPracownikaWypożyczLbl = New System.Windows.Forms.Label()
        Me.IdPracownikaWypozycz = New System.Windows.Forms.ComboBox()
        Me.IdNarzedziaWypożyczLbl = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.Narzedziownia2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UzytkownicyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarzedziaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Narzedziownia2DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Edytuj.SuspendLayout()
        CType(Me.EdytujTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TypNarzedzia.SuspendLayout()
        CType(Me.TypNarzedziaTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypNarzedziaPanel.SuspendLayout()
        Me.DodajFaktureSerwis.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TabelaDodajFaktureSerwis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDodajFaktureSerwis.SuspendLayout()
        Me.DodajFakture.SuspendLayout()
        CType(Me.TabelaDodajFakture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDodajFakture.SuspendLayout()
        Me.DodajDostawce.SuspendLayout()
        CType(Me.TabelaDodajDostawce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDostawca.SuspendLayout()
        Me.DodajSerwis.SuspendLayout()
        CType(Me.TabelaDodajSerwis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDodajSerwis.SuspendLayout()
        Me.DodajPracownika.SuspendLayout()
        CType(Me.TabelaDodajPracownika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDodajPracownika.SuspendLayout()
        Me.DodajNarzędzie.SuspendLayout()
        CType(Me.TabelaDodajNarzędzie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNarzędzie.SuspendLayout()
        Me.MojeWypożyczenia.SuspendLayout()
        CType(Me.TabelaMojeWypo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ZwróćTab.SuspendLayout()
        CType(Me.ZwróćTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZwróćPanel.SuspendLayout()
        Me.WypożyczTab.SuspendLayout()
        CType(Me.WypożyczTabela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WypożyczPanel.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObsługaWypożyczeńToolStripMenuItem, Me.AdminToolStrip, Me.RaportyToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 4, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(1241, 38)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ObsługaWypożyczeńToolStripMenuItem
        '
        Me.ObsługaWypożyczeńToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Wypożycz, Me.Zwrot, Me.SprawdźMojeWypożyczeniaMenu})
        Me.ObsługaWypożyczeńToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ObsługaWypożyczeńToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.ObsługaWypożyczeńToolStripMenuItem.Name = "ObsługaWypożyczeńToolStripMenuItem"
        Me.ObsługaWypożyczeńToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.ObsługaWypożyczeńToolStripMenuItem.Text = "Obsługa wypożyczeń"
        '
        'Wypożycz
        '
        Me.Wypożycz.Name = "Wypożycz"
        Me.Wypożycz.Size = New System.Drawing.Size(369, 32)
        Me.Wypożycz.Text = "Wypożycz"
        '
        'Zwrot
        '
        Me.Zwrot.Name = "Zwrot"
        Me.Zwrot.Size = New System.Drawing.Size(369, 32)
        Me.Zwrot.Text = "Zwróć narzędzie"
        '
        'SprawdźMojeWypożyczeniaMenu
        '
        Me.SprawdźMojeWypożyczeniaMenu.Name = "SprawdźMojeWypożyczeniaMenu"
        Me.SprawdźMojeWypożyczeniaMenu.Size = New System.Drawing.Size(369, 32)
        Me.SprawdźMojeWypożyczeniaMenu.Text = "Sprawdź moje wypożyczenia"
        '
        'AdminToolStrip
        '
        Me.AdminToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NarzedzieMenu, Me.PracownikMenu, Me.SerwisMenu, Me.FakturyMenu, Me.DostawceMenu, Me.FakturaSerwisMenu, Me.TypNarzędziaToolStripMenu, Me.Admin, Me.OddajNaSerwisMenu, Me.PowrotZserwisuMenu})
        Me.AdminToolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AdminToolStrip.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.AdminToolStrip.Name = "AdminToolStrip"
        Me.AdminToolStrip.Size = New System.Drawing.Size(157, 32)
        Me.AdminToolStrip.Text = "Administracja"
        '
        'NarzedzieMenu
        '
        Me.NarzedzieMenu.BackColor = System.Drawing.SystemColors.Control
        Me.NarzedzieMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajNarzedzieMenu, Me.EdytujNarzedzieMenu})
        Me.NarzedzieMenu.Name = "NarzedzieMenu"
        Me.NarzedzieMenu.Size = New System.Drawing.Size(259, 32)
        Me.NarzedzieMenu.Text = "Narzedzie"
        '
        'DodajNarzedzieMenu
        '
        Me.DodajNarzedzieMenu.Name = "DodajNarzedzieMenu"
        Me.DodajNarzedzieMenu.Size = New System.Drawing.Size(158, 32)
        Me.DodajNarzedzieMenu.Text = "Dodaj"
        '
        'EdytujNarzedzieMenu
        '
        Me.EdytujNarzedzieMenu.Name = "EdytujNarzedzieMenu"
        Me.EdytujNarzedzieMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujNarzedzieMenu.Text = "Edytuj"
        '
        'PracownikMenu
        '
        Me.PracownikMenu.BackColor = System.Drawing.SystemColors.Control
        Me.PracownikMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajPracownikMenu, Me.EdytujPracownikMenu})
        Me.PracownikMenu.Name = "PracownikMenu"
        Me.PracownikMenu.Size = New System.Drawing.Size(259, 32)
        Me.PracownikMenu.Text = "Pracownik"
        '
        'DodajPracownikMenu
        '
        Me.DodajPracownikMenu.BackColor = System.Drawing.SystemColors.Control
        Me.DodajPracownikMenu.Name = "DodajPracownikMenu"
        Me.DodajPracownikMenu.Size = New System.Drawing.Size(158, 32)
        Me.DodajPracownikMenu.Text = "Dodaj"
        '
        'EdytujPracownikMenu
        '
        Me.EdytujPracownikMenu.Name = "EdytujPracownikMenu"
        Me.EdytujPracownikMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujPracownikMenu.Text = "Edytuj"
        '
        'SerwisMenu
        '
        Me.SerwisMenu.BackColor = System.Drawing.SystemColors.Control
        Me.SerwisMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdytujSerwisMenu, Me.DodajSerwisMenu})
        Me.SerwisMenu.Name = "SerwisMenu"
        Me.SerwisMenu.Size = New System.Drawing.Size(259, 32)
        Me.SerwisMenu.Text = "Serwis"
        '
        'EdytujSerwisMenu
        '
        Me.EdytujSerwisMenu.Name = "EdytujSerwisMenu"
        Me.EdytujSerwisMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujSerwisMenu.Text = "Edytuj"
        '
        'DodajSerwisMenu
        '
        Me.DodajSerwisMenu.Name = "DodajSerwisMenu"
        Me.DodajSerwisMenu.Size = New System.Drawing.Size(158, 32)
        Me.DodajSerwisMenu.Text = "Dodaj"
        '
        'FakturyMenu
        '
        Me.FakturyMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajToolStripMenuItem1, Me.EdytujToolStripMenuItem2})
        Me.FakturyMenu.Name = "FakturyMenu"
        Me.FakturyMenu.Size = New System.Drawing.Size(259, 32)
        Me.FakturyMenu.Text = "Faktury"
        '
        'DodajToolStripMenuItem1
        '
        Me.DodajToolStripMenuItem1.Name = "DodajToolStripMenuItem1"
        Me.DodajToolStripMenuItem1.Size = New System.Drawing.Size(158, 32)
        Me.DodajToolStripMenuItem1.Text = "Dodaj"
        '
        'EdytujToolStripMenuItem2
        '
        Me.EdytujToolStripMenuItem2.Name = "EdytujToolStripMenuItem2"
        Me.EdytujToolStripMenuItem2.Size = New System.Drawing.Size(158, 32)
        Me.EdytujToolStripMenuItem2.Text = "Edytuj"
        '
        'DostawceMenu
        '
        Me.DostawceMenu.BackColor = System.Drawing.SystemColors.Control
        Me.DostawceMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DostawcaDodajMenu, Me.EdytujDostawceMenu})
        Me.DostawceMenu.Name = "DostawceMenu"
        Me.DostawceMenu.Size = New System.Drawing.Size(259, 32)
        Me.DostawceMenu.Text = "Dostawca"
        '
        'DostawcaDodajMenu
        '
        Me.DostawcaDodajMenu.Name = "DostawcaDodajMenu"
        Me.DostawcaDodajMenu.Size = New System.Drawing.Size(158, 32)
        Me.DostawcaDodajMenu.Text = "Dodaj"
        '
        'EdytujDostawceMenu
        '
        Me.EdytujDostawceMenu.Name = "EdytujDostawceMenu"
        Me.EdytujDostawceMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujDostawceMenu.Text = "Edytuj"
        '
        'FakturaSerwisMenu
        '
        Me.FakturaSerwisMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajFaktureSerwisMenu, Me.EdytujFaktureSerwisMenu})
        Me.FakturaSerwisMenu.Name = "FakturaSerwisMenu"
        Me.FakturaSerwisMenu.Size = New System.Drawing.Size(259, 32)
        Me.FakturaSerwisMenu.Text = "Faktury serwis"
        '
        'DodajFaktureSerwisMenu
        '
        Me.DodajFaktureSerwisMenu.Name = "DodajFaktureSerwisMenu"
        Me.DodajFaktureSerwisMenu.Size = New System.Drawing.Size(158, 32)
        Me.DodajFaktureSerwisMenu.Text = "Dodaj"
        '
        'EdytujFaktureSerwisMenu
        '
        Me.EdytujFaktureSerwisMenu.Name = "EdytujFaktureSerwisMenu"
        Me.EdytujFaktureSerwisMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujFaktureSerwisMenu.Text = "Edytuj"
        '
        'TypNarzędziaToolStripMenu
        '
        Me.TypNarzędziaToolStripMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DodajTypNarzedziaMenu, Me.EdytujTypNarzedziaMenu})
        Me.TypNarzędziaToolStripMenu.Name = "TypNarzędziaToolStripMenu"
        Me.TypNarzędziaToolStripMenu.Size = New System.Drawing.Size(259, 32)
        Me.TypNarzędziaToolStripMenu.Text = "Typ narzędzia"
        '
        'DodajTypNarzedziaMenu
        '
        Me.DodajTypNarzedziaMenu.Name = "DodajTypNarzedziaMenu"
        Me.DodajTypNarzedziaMenu.Size = New System.Drawing.Size(158, 32)
        Me.DodajTypNarzedziaMenu.Text = "Dodaj"
        '
        'EdytujTypNarzedziaMenu
        '
        Me.EdytujTypNarzedziaMenu.Name = "EdytujTypNarzedziaMenu"
        Me.EdytujTypNarzedziaMenu.Size = New System.Drawing.Size(158, 32)
        Me.EdytujTypNarzedziaMenu.Text = "Edytuj"
        '
        'Admin
        '
        Me.Admin.BackColor = System.Drawing.Color.Blue
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(256, 6)
        '
        'OddajNaSerwisMenu
        '
        Me.OddajNaSerwisMenu.BackColor = System.Drawing.SystemColors.Control
        Me.OddajNaSerwisMenu.Name = "OddajNaSerwisMenu"
        Me.OddajNaSerwisMenu.Size = New System.Drawing.Size(259, 32)
        Me.OddajNaSerwisMenu.Text = "Oddaj na serwis"
        '
        'PowrotZserwisuMenu
        '
        Me.PowrotZserwisuMenu.Name = "PowrotZserwisuMenu"
        Me.PowrotZserwisuMenu.Size = New System.Drawing.Size(259, 32)
        Me.PowrotZserwisuMenu.Text = "Powrot z serwisu"
        '
        'RaportyToolStripMenuItem
        '
        Me.RaportyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StanMagazynuMenu, Me.WypożyczeniaNaPracownikaMenu, Me.HistoriaNarzędziaMenu})
        Me.RaportyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RaportyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.RaportyToolStripMenuItem.Name = "RaportyToolStripMenuItem"
        Me.RaportyToolStripMenuItem.Size = New System.Drawing.Size(102, 32)
        Me.RaportyToolStripMenuItem.Text = "Raporty"
        '
        'StanMagazynuMenu
        '
        Me.StanMagazynuMenu.Name = "StanMagazynuMenu"
        Me.StanMagazynuMenu.Size = New System.Drawing.Size(378, 32)
        Me.StanMagazynuMenu.Text = "Stan magazynu"
        '
        'WypożyczeniaNaPracownikaMenu
        '
        Me.WypożyczeniaNaPracownikaMenu.Name = "WypożyczeniaNaPracownikaMenu"
        Me.WypożyczeniaNaPracownikaMenu.Size = New System.Drawing.Size(378, 32)
        Me.WypożyczeniaNaPracownikaMenu.Text = "Wypożyczenia na pracownika"
        '
        'HistoriaNarzędziaMenu
        '
        Me.HistoriaNarzędziaMenu.Name = "HistoriaNarzędziaMenu"
        Me.HistoriaNarzędziaMenu.Size = New System.Drawing.Size(378, 32)
        Me.HistoriaNarzędziaMenu.Text = "Historia narzędzia"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Narzedziownia2DataSet1
        '
        Me.Narzedziownia2DataSet1.DataSetName = "Narzedziownia2DataSet1"
        Me.Narzedziownia2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Narzedziownia2DataSet5
        '
        Me.Narzedziownia2DataSet5.DataSetName = "Narzedziownia2DataSet5"
        Me.Narzedziownia2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Narzedziownia2DataSet4
        '
        Me.Narzedziownia2DataSet4.DataSetName = "Narzedziownia2DataSet4"
        Me.Narzedziownia2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UzytkownicyBindingSource1
        '
        Me.UzytkownicyBindingSource1.DataMember = "uzytkownicy"
        '
        'NarzedziaBindingSource
        '
        Me.NarzedziaBindingSource.DataMember = "narzedzia"
        Me.NarzedziaBindingSource.DataSource = Me.Narzedziownia2DataSet2
        '
        'Narzedziownia2DataSet2
        '
        Me.Narzedziownia2DataSet2.DataSetName = "Narzedziownia2DataSet2"
        Me.Narzedziownia2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Narzedziownia2DataSet7
        '
        Me.Narzedziownia2DataSet7.DataSetName = "Narzedziownia2DataSet7"
        Me.Narzedziownia2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Narzedziownia2DataSet
        '
        Me.Narzedziownia2DataSet.DataSetName = "Narzedziownia2DataSet"
        Me.Narzedziownia2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FakturyTableAdapter
        '
        Me.FakturyTableAdapter.ClearBeforeFill = True
        '
        'DostawcaTableAdapter
        '
        Me.DostawcaTableAdapter.ClearBeforeFill = True
        '
        'NarzedziaTableAdapter
        '
        Me.NarzedziaTableAdapter.ClearBeforeFill = True
        '
        'Narzedziownia2DataSet3
        '
        Me.Narzedziownia2DataSet3.DataSetName = "Narzedziownia2DataSet3"
        Me.Narzedziownia2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UzytkownicyTableAdapter
        '
        Me.UzytkownicyTableAdapter.ClearBeforeFill = True
        '
        'SerwisTableAdapter
        '
        Me.SerwisTableAdapter.ClearBeforeFill = True
        '
        'SerwisTableAdapter1
        '
        Me.SerwisTableAdapter1.ClearBeforeFill = True
        '
        'Narzedziownia2DataSet6
        '
        Me.Narzedziownia2DataSet6.DataSetName = "Narzedziownia2DataSet6"
        Me.Narzedziownia2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "TypNarzedzia"
        Me.BindingSource1.DataSource = Me.Narzedziownia2DataSet6
        '
        'TypNarzedziaTableAdapter
        '
        Me.TypNarzedziaTableAdapter.ClearBeforeFill = True
        '
        'DostawcaTableAdapter1
        '
        Me.DostawcaTableAdapter1.ClearBeforeFill = True
        '
        'Edytuj
        '
        Me.Edytuj.BackColor = System.Drawing.Color.LightSlateGray
        Me.Edytuj.Controls.Add(Me.EdytujTabela)
        Me.Edytuj.Controls.Add(Me.Panel1)
        Me.Edytuj.Location = New System.Drawing.Point(4, 25)
        Me.Edytuj.Name = "Edytuj"
        Me.Edytuj.Padding = New System.Windows.Forms.Padding(3)
        Me.Edytuj.Size = New System.Drawing.Size(1233, 656)
        Me.Edytuj.TabIndex = 15
        Me.Edytuj.Text = "Edytuj"
        '
        'EdytujTabela
        '
        Me.EdytujTabela.AllowUserToAddRows = False
        Me.EdytujTabela.AllowUserToDeleteRows = False
        Me.EdytujTabela.AllowUserToOrderColumns = True
        Me.EdytujTabela.AutoGenerateContextFilters = True
        Me.EdytujTabela.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.EdytujTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EdytujTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EdytujTabela.DateWithTime = False
        Me.EdytujTabela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EdytujTabela.Location = New System.Drawing.Point(525, 3)
        Me.EdytujTabela.Name = "EdytujTabela"
        Me.EdytujTabela.RowHeadersWidth = 51
        Me.EdytujTabela.RowTemplate.Height = 24
        Me.EdytujTabela.Size = New System.Drawing.Size(705, 650)
        Me.EdytujTabela.TabIndex = 4
        Me.EdytujTabela.TimeFilter = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ComboBoxLvlDostępEdytuj)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.ComboBoxID)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.WybierzKolumne)
        Me.Panel1.Controls.Add(Me.TabelaWybierz)
        Me.Panel1.Controls.Add(Me.LicznikEdytuj)
        Me.Panel1.Controls.Add(Me.EdytowanaWartosc)
        Me.Panel1.Controls.Add(Me.ZmienBtn)
        Me.Panel1.Controls.Add(Me.ErrLblEdit)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 650)
        Me.Panel1.TabIndex = 2
        '
        'ComboBoxLvlDostępEdytuj
        '
        Me.ComboBoxLvlDostępEdytuj.FormattingEnabled = True
        Me.ComboBoxLvlDostępEdytuj.Location = New System.Drawing.Point(184, 137)
        Me.ComboBoxLvlDostępEdytuj.Name = "ComboBoxLvlDostępEdytuj"
        Me.ComboBoxLvlDostępEdytuj.Size = New System.Drawing.Size(326, 24)
        Me.ComboBoxLvlDostępEdytuj.TabIndex = 18
        Me.ComboBoxLvlDostępEdytuj.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label42.Location = New System.Drawing.Point(8, 106)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(91, 17)
        Me.Label42.TabIndex = 17
        Me.Label42.Text = "Wybierz ID:"
        '
        'ComboBoxID
        '
        Me.ComboBoxID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxID.FormattingEnabled = True
        Me.ComboBoxID.Location = New System.Drawing.Point(185, 106)
        Me.ComboBoxID.Name = "ComboBoxID"
        Me.ComboBoxID.Size = New System.Drawing.Size(326, 24)
        Me.ComboBoxID.TabIndex = 16
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label41.Location = New System.Drawing.Point(8, 76)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(136, 17)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "Wybierz kolumne:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label40.Location = New System.Drawing.Point(8, 46)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(121, 17)
        Me.Label40.TabIndex = 14
        Me.Label40.Text = "Wybierz tabele:"
        '
        'WybierzKolumne
        '
        Me.WybierzKolumne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WybierzKolumne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WybierzKolumne.FormattingEnabled = True
        Me.WybierzKolumne.Location = New System.Drawing.Point(185, 76)
        Me.WybierzKolumne.Name = "WybierzKolumne"
        Me.WybierzKolumne.Size = New System.Drawing.Size(326, 24)
        Me.WybierzKolumne.TabIndex = 2
        '
        'TabelaWybierz
        '
        Me.TabelaWybierz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabelaWybierz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TabelaWybierz.FormattingEnabled = True
        Me.TabelaWybierz.Location = New System.Drawing.Point(186, 46)
        Me.TabelaWybierz.Name = "TabelaWybierz"
        Me.TabelaWybierz.Size = New System.Drawing.Size(325, 24)
        Me.TabelaWybierz.TabIndex = 1
        '
        'LicznikEdytuj
        '
        Me.LicznikEdytuj.BackColor = System.Drawing.Color.LightSlateGray
        Me.LicznikEdytuj.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikEdytuj.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikEdytuj.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikEdytuj.Location = New System.Drawing.Point(0, 601)
        Me.LicznikEdytuj.Name = "LicznikEdytuj"
        Me.LicznikEdytuj.Size = New System.Drawing.Size(522, 49)
        Me.LicznikEdytuj.TabIndex = 5
        Me.LicznikEdytuj.Text = "Label7"
        Me.LicznikEdytuj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EdytowanaWartosc
        '
        Me.EdytowanaWartosc.Location = New System.Drawing.Point(185, 137)
        Me.EdytowanaWartosc.Margin = New System.Windows.Forms.Padding(4)
        Me.EdytowanaWartosc.Name = "EdytowanaWartosc"
        Me.EdytowanaWartosc.Size = New System.Drawing.Size(326, 22)
        Me.EdytowanaWartosc.TabIndex = 3
        '
        'ZmienBtn
        '
        Me.ZmienBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.ZmienBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZmienBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZmienBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ZmienBtn.Location = New System.Drawing.Point(11, 178)
        Me.ZmienBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ZmienBtn.Name = "ZmienBtn"
        Me.ZmienBtn.Size = New System.Drawing.Size(500, 52)
        Me.ZmienBtn.TabIndex = 4
        Me.ZmienBtn.Text = "Zmień"
        Me.ZmienBtn.UseVisualStyleBackColor = False
        '
        'ErrLblEdit
        '
        Me.ErrLblEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLblEdit.ForeColor = System.Drawing.Color.Black
        Me.ErrLblEdit.Location = New System.Drawing.Point(4, 253)
        Me.ErrLblEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLblEdit.Name = "ErrLblEdit"
        Me.ErrLblEdit.Size = New System.Drawing.Size(505, 346)
        Me.ErrLblEdit.TabIndex = 11
        Me.ErrLblEdit.Text = "Komunikat:"
        Me.ErrLblEdit.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 137)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(112, 17)
        Me.Label44.TabIndex = 10
        Me.Label44.Text = "Nowa wartość:"
        '
        'TypNarzedzia
        '
        Me.TypNarzedzia.BackColor = System.Drawing.Color.LightSlateGray
        Me.TypNarzedzia.Controls.Add(Me.TypNarzedziaTabela)
        Me.TypNarzedzia.Controls.Add(Me.TypNarzedziaPanel)
        Me.TypNarzedzia.Location = New System.Drawing.Point(4, 25)
        Me.TypNarzedzia.Name = "TypNarzedzia"
        Me.TypNarzedzia.Padding = New System.Windows.Forms.Padding(3)
        Me.TypNarzedzia.Size = New System.Drawing.Size(1233, 656)
        Me.TypNarzedzia.TabIndex = 14
        Me.TypNarzedzia.Text = "Typ narzedzia"
        '
        'TypNarzedziaTabela
        '
        Me.TypNarzedziaTabela.AllowUserToAddRows = False
        Me.TypNarzedziaTabela.AllowUserToDeleteRows = False
        Me.TypNarzedziaTabela.AllowUserToOrderColumns = True
        Me.TypNarzedziaTabela.AutoGenerateContextFilters = True
        Me.TypNarzedziaTabela.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TypNarzedziaTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TypNarzedziaTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TypNarzedziaTabela.DateWithTime = False
        Me.TypNarzedziaTabela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypNarzedziaTabela.Location = New System.Drawing.Point(510, 3)
        Me.TypNarzedziaTabela.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.TypNarzedziaTabela.Name = "TypNarzedziaTabela"
        Me.TypNarzedziaTabela.ReadOnly = True
        Me.TypNarzedziaTabela.RowHeadersWidth = 51
        Me.TypNarzedziaTabela.RowTemplate.Height = 24
        Me.TypNarzedziaTabela.Size = New System.Drawing.Size(720, 650)
        Me.TypNarzedziaTabela.TabIndex = 8
        Me.TypNarzedziaTabela.TimeFilter = False
        '
        'TypNarzedziaPanel
        '
        Me.TypNarzedziaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TypNarzedziaPanel.Controls.Add(Me.LicznikTypNarzedzia)
        Me.TypNarzedziaPanel.Controls.Add(Me.TypNarzedziaTxt)
        Me.TypNarzedziaPanel.Controls.Add(Me.TypNarzedziaBTN)
        Me.TypNarzedziaPanel.Controls.Add(Me.ErrLabelTypNarzedzia)
        Me.TypNarzedziaPanel.Controls.Add(Me.Label43)
        Me.TypNarzedziaPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TypNarzedziaPanel.Location = New System.Drawing.Point(3, 3)
        Me.TypNarzedziaPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TypNarzedziaPanel.Name = "TypNarzedziaPanel"
        Me.TypNarzedziaPanel.Size = New System.Drawing.Size(507, 650)
        Me.TypNarzedziaPanel.TabIndex = 7
        '
        'LicznikTypNarzedzia
        '
        Me.LicznikTypNarzedzia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikTypNarzedzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikTypNarzedzia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikTypNarzedzia.Location = New System.Drawing.Point(0, 617)
        Me.LicznikTypNarzedzia.Name = "LicznikTypNarzedzia"
        Me.LicznikTypNarzedzia.Size = New System.Drawing.Size(505, 31)
        Me.LicznikTypNarzedzia.TabIndex = 8
        Me.LicznikTypNarzedzia.Text = "Licznik typ narzedzia:"
        Me.LicznikTypNarzedzia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TypNarzedziaTxt
        '
        Me.TypNarzedziaTxt.Location = New System.Drawing.Point(170, 8)
        Me.TypNarzedziaTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.TypNarzedziaTxt.Name = "TypNarzedziaTxt"
        Me.TypNarzedziaTxt.Size = New System.Drawing.Size(325, 22)
        Me.TypNarzedziaTxt.TabIndex = 0
        '
        'TypNarzedziaBTN
        '
        Me.TypNarzedziaBTN.BackColor = System.Drawing.Color.RoyalBlue
        Me.TypNarzedziaBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TypNarzedziaBTN.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.TypNarzedziaBTN.FlatAppearance.BorderSize = 2
        Me.TypNarzedziaBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.TypNarzedziaBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.TypNarzedziaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TypNarzedziaBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TypNarzedziaBTN.Location = New System.Drawing.Point(9, 38)
        Me.TypNarzedziaBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.TypNarzedziaBTN.Name = "TypNarzedziaBTN"
        Me.TypNarzedziaBTN.Size = New System.Drawing.Size(486, 52)
        Me.TypNarzedziaBTN.TabIndex = 8
        Me.TypNarzedziaBTN.Text = "Dodaj"
        Me.TypNarzedziaBTN.UseVisualStyleBackColor = False
        '
        'ErrLabelTypNarzedzia
        '
        Me.ErrLabelTypNarzedzia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelTypNarzedzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelTypNarzedzia.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelTypNarzedzia.Location = New System.Drawing.Point(5, 94)
        Me.ErrLabelTypNarzedzia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelTypNarzedzia.Name = "ErrLabelTypNarzedzia"
        Me.ErrLabelTypNarzedzia.Size = New System.Drawing.Size(504, 322)
        Me.ErrLabelTypNarzedzia.TabIndex = 11
        Me.ErrLabelTypNarzedzia.Text = "Komunikat:"
        Me.ErrLabelTypNarzedzia.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label43.Location = New System.Drawing.Point(7, 8)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(116, 17)
        Me.Label43.TabIndex = 10
        Me.Label43.Text = "Typ narzędzia:"
        '
        'DodajFaktureSerwis
        '
        Me.DodajFaktureSerwis.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajFaktureSerwis.Controls.Add(Me.Panel2)
        Me.DodajFaktureSerwis.Controls.Add(Me.PanelDodajFaktureSerwis)
        Me.DodajFaktureSerwis.Location = New System.Drawing.Point(4, 25)
        Me.DodajFaktureSerwis.Name = "DodajFaktureSerwis"
        Me.DodajFaktureSerwis.Padding = New System.Windows.Forms.Padding(3)
        Me.DodajFaktureSerwis.Size = New System.Drawing.Size(1233, 656)
        Me.DodajFaktureSerwis.TabIndex = 13
        Me.DodajFaktureSerwis.Text = "Dodaj fakture serwis"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel2.Controls.Add(Me.TabelaDodajFaktureSerwis)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(507, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 650)
        Me.Panel2.TabIndex = 7
        '
        'TabelaDodajFaktureSerwis
        '
        Me.TabelaDodajFaktureSerwis.AllowUserToAddRows = False
        Me.TabelaDodajFaktureSerwis.AllowUserToDeleteRows = False
        Me.TabelaDodajFaktureSerwis.AllowUserToOrderColumns = True
        Me.TabelaDodajFaktureSerwis.AutoGenerateContextFilters = True
        Me.TabelaDodajFaktureSerwis.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajFaktureSerwis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajFaktureSerwis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajFaktureSerwis.DateWithTime = False
        Me.TabelaDodajFaktureSerwis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajFaktureSerwis.Location = New System.Drawing.Point(0, 0)
        Me.TabelaDodajFaktureSerwis.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.TabelaDodajFaktureSerwis.Name = "TabelaDodajFaktureSerwis"
        Me.TabelaDodajFaktureSerwis.ReadOnly = True
        Me.TabelaDodajFaktureSerwis.RowHeadersWidth = 51
        Me.TabelaDodajFaktureSerwis.RowTemplate.Height = 24
        Me.TabelaDodajFaktureSerwis.Size = New System.Drawing.Size(723, 650)
        Me.TabelaDodajFaktureSerwis.TabIndex = 7
        Me.TabelaDodajFaktureSerwis.TimeFilter = False
        '
        'PanelDodajFaktureSerwis
        '
        Me.PanelDodajFaktureSerwis.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.LicznikFakturySerwis)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.Label7)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisFormaPłatności)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisDataPłatności)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.Label29)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisBtn)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.ErrLabelFakturaSerwis)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisDataFaktury)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.Label37)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisWybierzDostawce)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.Label38)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.Label39)
        Me.PanelDodajFaktureSerwis.Controls.Add(Me.DodajFaktureSerwisNrFaktury)
        Me.PanelDodajFaktureSerwis.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDodajFaktureSerwis.Location = New System.Drawing.Point(3, 3)
        Me.PanelDodajFaktureSerwis.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDodajFaktureSerwis.Name = "PanelDodajFaktureSerwis"
        Me.PanelDodajFaktureSerwis.Size = New System.Drawing.Size(504, 650)
        Me.PanelDodajFaktureSerwis.TabIndex = 6
        '
        'LicznikFakturySerwis
        '
        Me.LicznikFakturySerwis.BackColor = System.Drawing.Color.Transparent
        Me.LicznikFakturySerwis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikFakturySerwis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikFakturySerwis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikFakturySerwis.Location = New System.Drawing.Point(0, 619)
        Me.LicznikFakturySerwis.Name = "LicznikFakturySerwis"
        Me.LicznikFakturySerwis.Size = New System.Drawing.Size(504, 31)
        Me.LicznikFakturySerwis.TabIndex = 8
        Me.LicznikFakturySerwis.Text = "Label40"
        Me.LicznikFakturySerwis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 131)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Forma płatności:"
        '
        'DodajFaktureSerwisFormaPłatności
        '
        Me.DodajFaktureSerwisFormaPłatności.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureSerwisFormaPłatności.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajFaktureSerwisFormaPłatności.FormattingEnabled = True
        Me.DodajFaktureSerwisFormaPłatności.Items.AddRange(New Object() {"Przelew", "Gotówka"})
        Me.DodajFaktureSerwisFormaPłatności.Location = New System.Drawing.Point(166, 131)
        Me.DodajFaktureSerwisFormaPłatności.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisFormaPłatności.Name = "DodajFaktureSerwisFormaPłatności"
        Me.DodajFaktureSerwisFormaPłatności.Size = New System.Drawing.Size(325, 24)
        Me.DodajFaktureSerwisFormaPłatności.TabIndex = 4
        '
        'DodajFaktureSerwisDataPłatności
        '
        Me.DodajFaktureSerwisDataPłatności.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureSerwisDataPłatności.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DodajFaktureSerwisDataPłatności.Location = New System.Drawing.Point(167, 101)
        Me.DodajFaktureSerwisDataPłatności.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisDataPłatności.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DodajFaktureSerwisDataPłatności.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.DodajFaktureSerwisDataPłatności.Name = "DodajFaktureSerwisDataPłatności"
        Me.DodajFaktureSerwisDataPłatności.Size = New System.Drawing.Size(324, 22)
        Me.DodajFaktureSerwisDataPłatności.TabIndex = 3
        Me.DodajFaktureSerwisDataPłatności.Value = New Date(2023, 3, 20, 10, 12, 4, 0)
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 101)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(133, 17)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "Termin płatności:"
        '
        'DodajFaktureSerwisBtn
        '
        Me.DodajFaktureSerwisBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajFaktureSerwisBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureSerwisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajFaktureSerwisBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajFaktureSerwisBtn.Location = New System.Drawing.Point(10, 175)
        Me.DodajFaktureSerwisBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisBtn.Name = "DodajFaktureSerwisBtn"
        Me.DodajFaktureSerwisBtn.Size = New System.Drawing.Size(481, 52)
        Me.DodajFaktureSerwisBtn.TabIndex = 5
        Me.DodajFaktureSerwisBtn.Text = "Dodaj"
        Me.DodajFaktureSerwisBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelFakturaSerwis
        '
        Me.ErrLabelFakturaSerwis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelFakturaSerwis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelFakturaSerwis.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelFakturaSerwis.Location = New System.Drawing.Point(6, 255)
        Me.ErrLabelFakturaSerwis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelFakturaSerwis.Name = "ErrLabelFakturaSerwis"
        Me.ErrLabelFakturaSerwis.Size = New System.Drawing.Size(491, 270)
        Me.ErrLabelFakturaSerwis.TabIndex = 11
        Me.ErrLabelFakturaSerwis.Text = "Komunikat"
        Me.ErrLabelFakturaSerwis.Visible = False
        '
        'DodajFaktureSerwisDataFaktury
        '
        Me.DodajFaktureSerwisDataFaktury.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureSerwisDataFaktury.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DodajFaktureSerwisDataFaktury.Location = New System.Drawing.Point(166, 39)
        Me.DodajFaktureSerwisDataFaktury.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisDataFaktury.Name = "DodajFaktureSerwisDataFaktury"
        Me.DodajFaktureSerwisDataFaktury.Size = New System.Drawing.Size(324, 22)
        Me.DodajFaktureSerwisDataFaktury.TabIndex = 1
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label37.Location = New System.Drawing.Point(7, 69)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(143, 17)
        Me.Label37.TabIndex = 10
        Me.Label37.Text = "Wybierz dostawce:"
        '
        'DodajFaktureSerwisWybierzDostawce
        '
        Me.DodajFaktureSerwisWybierzDostawce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureSerwisWybierzDostawce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajFaktureSerwisWybierzDostawce.FormattingEnabled = True
        Me.DodajFaktureSerwisWybierzDostawce.Location = New System.Drawing.Point(165, 69)
        Me.DodajFaktureSerwisWybierzDostawce.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisWybierzDostawce.Name = "DodajFaktureSerwisWybierzDostawce"
        Me.DodajFaktureSerwisWybierzDostawce.Size = New System.Drawing.Size(325, 24)
        Me.DodajFaktureSerwisWybierzDostawce.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label38.Location = New System.Drawing.Point(7, 39)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(102, 17)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Data faktury:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label39.Location = New System.Drawing.Point(7, 9)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(85, 17)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "Nr faktury:"
        '
        'DodajFaktureSerwisNrFaktury
        '
        Me.DodajFaktureSerwisNrFaktury.Location = New System.Drawing.Point(166, 9)
        Me.DodajFaktureSerwisNrFaktury.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureSerwisNrFaktury.Name = "DodajFaktureSerwisNrFaktury"
        Me.DodajFaktureSerwisNrFaktury.Size = New System.Drawing.Size(325, 22)
        Me.DodajFaktureSerwisNrFaktury.TabIndex = 0
        '
        'DodajFakture
        '
        Me.DodajFakture.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajFakture.Controls.Add(Me.TabelaDodajFakture)
        Me.DodajFakture.Controls.Add(Me.PanelDodajFakture)
        Me.DodajFakture.Location = New System.Drawing.Point(4, 25)
        Me.DodajFakture.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFakture.Name = "DodajFakture"
        Me.DodajFakture.Padding = New System.Windows.Forms.Padding(4)
        Me.DodajFakture.Size = New System.Drawing.Size(1233, 656)
        Me.DodajFakture.TabIndex = 12
        Me.DodajFakture.Text = "Dodaj fakture"
        '
        'TabelaDodajFakture
        '
        Me.TabelaDodajFakture.AllowUserToAddRows = False
        Me.TabelaDodajFakture.AllowUserToDeleteRows = False
        Me.TabelaDodajFakture.AllowUserToOrderColumns = True
        Me.TabelaDodajFakture.AutoGenerateContextFilters = True
        Me.TabelaDodajFakture.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajFakture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajFakture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.TabelaDodajFakture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajFakture.DateWithTime = False
        Me.TabelaDodajFakture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajFakture.Location = New System.Drawing.Point(504, 4)
        Me.TabelaDodajFakture.Name = "TabelaDodajFakture"
        Me.TabelaDodajFakture.ReadOnly = True
        Me.TabelaDodajFakture.RowHeadersWidth = 51
        Me.TabelaDodajFakture.RowTemplate.Height = 24
        Me.TabelaDodajFakture.Size = New System.Drawing.Size(725, 648)
        Me.TabelaDodajFakture.TabIndex = 6
        Me.TabelaDodajFakture.TimeFilter = False
        '
        'PanelDodajFakture
        '
        Me.PanelDodajFakture.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelDodajFakture.Controls.Add(Me.LicznikFaktury)
        Me.PanelDodajFakture.Controls.Add(Me.Label19)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureFormaPłatności)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureDataPłatności)
        Me.PanelDodajFakture.Controls.Add(Me.Label17)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureBtn)
        Me.PanelDodajFakture.Controls.Add(Me.ErrLabelFaktura)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureDataFaktury)
        Me.PanelDodajFakture.Controls.Add(Me.Label16)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureWybierzDostawce)
        Me.PanelDodajFakture.Controls.Add(Me.Label18)
        Me.PanelDodajFakture.Controls.Add(Me.Label21)
        Me.PanelDodajFakture.Controls.Add(Me.DodajFaktureNrFaktury)
        Me.PanelDodajFakture.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDodajFakture.Location = New System.Drawing.Point(4, 4)
        Me.PanelDodajFakture.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDodajFakture.Name = "PanelDodajFakture"
        Me.PanelDodajFakture.Size = New System.Drawing.Size(500, 648)
        Me.PanelDodajFakture.TabIndex = 5
        '
        'LicznikFaktury
        '
        Me.LicznikFaktury.BackColor = System.Drawing.Color.LightSlateGray
        Me.LicznikFaktury.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikFaktury.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikFaktury.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikFaktury.Location = New System.Drawing.Point(0, 599)
        Me.LicznikFaktury.Name = "LicznikFaktury"
        Me.LicznikFaktury.Size = New System.Drawing.Size(500, 49)
        Me.LicznikFaktury.TabIndex = 7
        Me.LicznikFaktury.Text = "Licznik:"
        Me.LicznikFaktury.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 131)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Forma płatności:"
        '
        'DodajFaktureFormaPłatności
        '
        Me.DodajFaktureFormaPłatności.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureFormaPłatności.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajFaktureFormaPłatności.FormattingEnabled = True
        Me.DodajFaktureFormaPłatności.Items.AddRange(New Object() {"Przelew", "Gotówka"})
        Me.DodajFaktureFormaPłatności.Location = New System.Drawing.Point(166, 131)
        Me.DodajFaktureFormaPłatności.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureFormaPłatności.Name = "DodajFaktureFormaPłatności"
        Me.DodajFaktureFormaPłatności.Size = New System.Drawing.Size(325, 24)
        Me.DodajFaktureFormaPłatności.TabIndex = 4
        '
        'DodajFaktureDataPłatności
        '
        Me.DodajFaktureDataPłatności.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureDataPłatności.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DodajFaktureDataPłatności.Location = New System.Drawing.Point(167, 101)
        Me.DodajFaktureDataPłatności.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureDataPłatności.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DodajFaktureDataPłatności.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.DodajFaktureDataPłatności.Name = "DodajFaktureDataPłatności"
        Me.DodajFaktureDataPłatności.Size = New System.Drawing.Size(324, 22)
        Me.DodajFaktureDataPłatności.TabIndex = 3
        Me.DodajFaktureDataPłatności.Value = New Date(2023, 3, 20, 10, 12, 4, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 101)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Termin płatności:"
        '
        'DodajFaktureBtn
        '
        Me.DodajFaktureBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajFaktureBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajFaktureBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajFaktureBtn.Location = New System.Drawing.Point(11, 177)
        Me.DodajFaktureBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureBtn.Name = "DodajFaktureBtn"
        Me.DodajFaktureBtn.Size = New System.Drawing.Size(479, 52)
        Me.DodajFaktureBtn.TabIndex = 5
        Me.DodajFaktureBtn.Text = "Dodaj"
        Me.DodajFaktureBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelFaktura
        '
        Me.ErrLabelFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelFaktura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelFaktura.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelFaktura.Location = New System.Drawing.Point(6, 255)
        Me.ErrLabelFaktura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelFaktura.Name = "ErrLabelFaktura"
        Me.ErrLabelFaktura.Size = New System.Drawing.Size(491, 292)
        Me.ErrLabelFaktura.TabIndex = 11
        Me.ErrLabelFaktura.Text = "Komunikat"
        Me.ErrLabelFaktura.Visible = False
        '
        'DodajFaktureDataFaktury
        '
        Me.DodajFaktureDataFaktury.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureDataFaktury.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DodajFaktureDataFaktury.Location = New System.Drawing.Point(166, 39)
        Me.DodajFaktureDataFaktury.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureDataFaktury.Name = "DodajFaktureDataFaktury"
        Me.DodajFaktureDataFaktury.Size = New System.Drawing.Size(324, 22)
        Me.DodajFaktureDataFaktury.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 69)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Wybierz dostawce:"
        '
        'DodajFaktureWybierzDostawce
        '
        Me.DodajFaktureWybierzDostawce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajFaktureWybierzDostawce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajFaktureWybierzDostawce.FormattingEnabled = True
        Me.DodajFaktureWybierzDostawce.Location = New System.Drawing.Point(167, 69)
        Me.DodajFaktureWybierzDostawce.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureWybierzDostawce.Name = "DodajFaktureWybierzDostawce"
        Me.DodajFaktureWybierzDostawce.Size = New System.Drawing.Size(325, 24)
        Me.DodajFaktureWybierzDostawce.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 39)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 17)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Data faktury:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 9)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 17)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Nr faktury:"
        '
        'DodajFaktureNrFaktury
        '
        Me.DodajFaktureNrFaktury.Location = New System.Drawing.Point(167, 9)
        Me.DodajFaktureNrFaktury.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajFaktureNrFaktury.Name = "DodajFaktureNrFaktury"
        Me.DodajFaktureNrFaktury.Size = New System.Drawing.Size(325, 22)
        Me.DodajFaktureNrFaktury.TabIndex = 0
        '
        'HistoriaNarzędzia
        '
        Me.HistoriaNarzędzia.AutoScroll = True
        Me.HistoriaNarzędzia.BackColor = System.Drawing.Color.LightSlateGray
        Me.HistoriaNarzędzia.Location = New System.Drawing.Point(4, 25)
        Me.HistoriaNarzędzia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistoriaNarzędzia.Name = "HistoriaNarzędzia"
        Me.HistoriaNarzędzia.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistoriaNarzędzia.Size = New System.Drawing.Size(1233, 656)
        Me.HistoriaNarzędzia.TabIndex = 11
        Me.HistoriaNarzędzia.Text = "Historia narzędzia"
        '
        'DodajDostawce
        '
        Me.DodajDostawce.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajDostawce.Controls.Add(Me.TabelaDodajDostawce)
        Me.DodajDostawce.Controls.Add(Me.PanelDostawca)
        Me.DodajDostawce.Location = New System.Drawing.Point(4, 25)
        Me.DodajDostawce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajDostawce.Name = "DodajDostawce"
        Me.DodajDostawce.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajDostawce.Size = New System.Drawing.Size(1233, 656)
        Me.DodajDostawce.TabIndex = 10
        Me.DodajDostawce.Text = "Dodaj dostawce"
        '
        'TabelaDodajDostawce
        '
        Me.TabelaDodajDostawce.AllowUserToAddRows = False
        Me.TabelaDodajDostawce.AllowUserToDeleteRows = False
        Me.TabelaDodajDostawce.AllowUserToOrderColumns = True
        Me.TabelaDodajDostawce.AutoGenerateContextFilters = True
        Me.TabelaDodajDostawce.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajDostawce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajDostawce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajDostawce.DateWithTime = False
        Me.TabelaDodajDostawce.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajDostawce.Location = New System.Drawing.Point(525, 2)
        Me.TabelaDodajDostawce.Name = "TabelaDodajDostawce"
        Me.TabelaDodajDostawce.RowHeadersWidth = 51
        Me.TabelaDodajDostawce.RowTemplate.Height = 24
        Me.TabelaDodajDostawce.Size = New System.Drawing.Size(705, 652)
        Me.TabelaDodajDostawce.TabIndex = 3
        Me.TabelaDodajDostawce.TimeFilter = False
        '
        'PanelDostawca
        '
        Me.PanelDostawca.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelDostawca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDostawca.Controls.Add(Me.LicznikDostawca)
        Me.PanelDostawca.Controls.Add(Me.DostawcaKodPocztowy)
        Me.PanelDostawca.Controls.Add(Me.DostawcaNip)
        Me.PanelDostawca.Controls.Add(Me.Label14)
        Me.PanelDostawca.Controls.Add(Me.Label15)
        Me.PanelDostawca.Controls.Add(Me.DostawcaMiasto)
        Me.PanelDostawca.Controls.Add(Me.DostawcaNazwa)
        Me.PanelDostawca.Controls.Add(Me.DodajDostawceBtn)
        Me.PanelDostawca.Controls.Add(Me.ErrLabelDostawca)
        Me.PanelDostawca.Controls.Add(Me.Label8)
        Me.PanelDostawca.Controls.Add(Me.DostawcaAdres)
        Me.PanelDostawca.Controls.Add(Me.DostawcaOpiekun)
        Me.PanelDostawca.Controls.Add(Me.DostawcaMail)
        Me.PanelDostawca.Controls.Add(Me.Label9)
        Me.PanelDostawca.Controls.Add(Me.Label10)
        Me.PanelDostawca.Controls.Add(Me.Label11)
        Me.PanelDostawca.Controls.Add(Me.Label12)
        Me.PanelDostawca.Controls.Add(Me.Label13)
        Me.PanelDostawca.Controls.Add(Me.DostawcaTelefon)
        Me.PanelDostawca.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDostawca.Location = New System.Drawing.Point(3, 2)
        Me.PanelDostawca.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDostawca.Name = "PanelDostawca"
        Me.PanelDostawca.Size = New System.Drawing.Size(522, 652)
        Me.PanelDostawca.TabIndex = 1
        '
        'LicznikDostawca
        '
        Me.LicznikDostawca.BackColor = System.Drawing.Color.LightSlateGray
        Me.LicznikDostawca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikDostawca.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikDostawca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikDostawca.Location = New System.Drawing.Point(0, 603)
        Me.LicznikDostawca.Name = "LicznikDostawca"
        Me.LicznikDostawca.Size = New System.Drawing.Size(522, 49)
        Me.LicznikDostawca.TabIndex = 5
        Me.LicznikDostawca.Text = "Label7"
        Me.LicznikDostawca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DostawcaKodPocztowy
        '
        Me.DostawcaKodPocztowy.Location = New System.Drawing.Point(186, 202)
        Me.DostawcaKodPocztowy.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaKodPocztowy.Name = "DostawcaKodPocztowy"
        Me.DostawcaKodPocztowy.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaKodPocztowy.TabIndex = 6
        '
        'DostawcaNip
        '
        Me.DostawcaNip.Location = New System.Drawing.Point(186, 234)
        Me.DostawcaNip.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaNip.Name = "DostawcaNip"
        Me.DostawcaNip.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaNip.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 234)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "NIP:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 202)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Kod pocztowy:"
        '
        'DostawcaMiasto
        '
        Me.DostawcaMiasto.Location = New System.Drawing.Point(186, 138)
        Me.DostawcaMiasto.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaMiasto.Name = "DostawcaMiasto"
        Me.DostawcaMiasto.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaMiasto.TabIndex = 4
        '
        'DostawcaNazwa
        '
        Me.DostawcaNazwa.Location = New System.Drawing.Point(186, 10)
        Me.DostawcaNazwa.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaNazwa.Name = "DostawcaNazwa"
        Me.DostawcaNazwa.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaNazwa.TabIndex = 0
        '
        'DodajDostawceBtn
        '
        Me.DodajDostawceBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajDostawceBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajDostawceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajDostawceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajDostawceBtn.Location = New System.Drawing.Point(25, 279)
        Me.DodajDostawceBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajDostawceBtn.Name = "DodajDostawceBtn"
        Me.DodajDostawceBtn.Size = New System.Drawing.Size(487, 52)
        Me.DodajDostawceBtn.TabIndex = 8
        Me.DodajDostawceBtn.Text = "Dodaj"
        Me.DodajDostawceBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelDostawca
        '
        Me.ErrLabelDostawca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelDostawca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelDostawca.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelDostawca.Location = New System.Drawing.Point(7, 335)
        Me.ErrLabelDostawca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelDostawca.Name = "ErrLabelDostawca"
        Me.ErrLabelDostawca.Size = New System.Drawing.Size(505, 238)
        Me.ErrLabelDostawca.TabIndex = 11
        Me.ErrLabelDostawca.Text = "Komunikat:"
        Me.ErrLabelDostawca.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nazwa:"
        '
        'DostawcaAdres
        '
        Me.DostawcaAdres.Location = New System.Drawing.Point(186, 170)
        Me.DostawcaAdres.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaAdres.Name = "DostawcaAdres"
        Me.DostawcaAdres.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaAdres.TabIndex = 5
        '
        'DostawcaOpiekun
        '
        Me.DostawcaOpiekun.Location = New System.Drawing.Point(187, 106)
        Me.DostawcaOpiekun.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaOpiekun.Name = "DostawcaOpiekun"
        Me.DostawcaOpiekun.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaOpiekun.TabIndex = 3
        '
        'DostawcaMail
        '
        Me.DostawcaMail.Location = New System.Drawing.Point(186, 74)
        Me.DostawcaMail.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaMail.Name = "DostawcaMail"
        Me.DostawcaMail.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaMail.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 170)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Adres:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Miasto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Opiekun:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 74)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Mail:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Telefon:"
        '
        'DostawcaTelefon
        '
        Me.DostawcaTelefon.Location = New System.Drawing.Point(186, 42)
        Me.DostawcaTelefon.Margin = New System.Windows.Forms.Padding(4)
        Me.DostawcaTelefon.Name = "DostawcaTelefon"
        Me.DostawcaTelefon.Size = New System.Drawing.Size(325, 22)
        Me.DostawcaTelefon.TabIndex = 1
        '
        'PowrótZserwisu
        '
        Me.PowrótZserwisu.BackColor = System.Drawing.Color.LightSlateGray
        Me.PowrótZserwisu.Location = New System.Drawing.Point(4, 25)
        Me.PowrótZserwisu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PowrótZserwisu.Name = "PowrótZserwisu"
        Me.PowrótZserwisu.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PowrótZserwisu.Size = New System.Drawing.Size(1233, 656)
        Me.PowrótZserwisu.TabIndex = 9
        Me.PowrótZserwisu.Text = "Powrót z serwisu"
        '
        'OddajNaSerwis
        '
        Me.OddajNaSerwis.BackColor = System.Drawing.Color.LightSlateGray
        Me.OddajNaSerwis.Location = New System.Drawing.Point(4, 25)
        Me.OddajNaSerwis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OddajNaSerwis.Name = "OddajNaSerwis"
        Me.OddajNaSerwis.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OddajNaSerwis.Size = New System.Drawing.Size(1233, 656)
        Me.OddajNaSerwis.TabIndex = 8
        Me.OddajNaSerwis.Text = "Oddaj na serwis"
        '
        'StanMagazynu
        '
        Me.StanMagazynu.BackColor = System.Drawing.Color.LightSlateGray
        Me.StanMagazynu.Location = New System.Drawing.Point(4, 25)
        Me.StanMagazynu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StanMagazynu.Name = "StanMagazynu"
        Me.StanMagazynu.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StanMagazynu.Size = New System.Drawing.Size(1233, 656)
        Me.StanMagazynu.TabIndex = 6
        Me.StanMagazynu.Text = "Stan magazynu"
        '
        'DodajSerwis
        '
        Me.DodajSerwis.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajSerwis.Controls.Add(Me.TabelaDodajSerwis)
        Me.DodajSerwis.Controls.Add(Me.PanelDodajSerwis)
        Me.DodajSerwis.Location = New System.Drawing.Point(4, 25)
        Me.DodajSerwis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajSerwis.Name = "DodajSerwis"
        Me.DodajSerwis.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajSerwis.Size = New System.Drawing.Size(1233, 656)
        Me.DodajSerwis.TabIndex = 5
        Me.DodajSerwis.Text = "Dodaj serwis"
        '
        'TabelaDodajSerwis
        '
        Me.TabelaDodajSerwis.AllowUserToAddRows = False
        Me.TabelaDodajSerwis.AllowUserToDeleteRows = False
        Me.TabelaDodajSerwis.AllowUserToOrderColumns = True
        Me.TabelaDodajSerwis.AutoGenerateContextFilters = True
        Me.TabelaDodajSerwis.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajSerwis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajSerwis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajSerwis.DateWithTime = False
        Me.TabelaDodajSerwis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajSerwis.Location = New System.Drawing.Point(536, 2)
        Me.TabelaDodajSerwis.Name = "TabelaDodajSerwis"
        Me.TabelaDodajSerwis.ReadOnly = True
        Me.TabelaDodajSerwis.RowHeadersWidth = 51
        Me.TabelaDodajSerwis.RowTemplate.Height = 24
        Me.TabelaDodajSerwis.Size = New System.Drawing.Size(694, 652)
        Me.TabelaDodajSerwis.TabIndex = 7
        Me.TabelaDodajSerwis.TimeFilter = False
        '
        'PanelDodajSerwis
        '
        Me.PanelDodajSerwis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDodajSerwis.Controls.Add(Me.LicznikDodajSerwis)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisKodPocztowy)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisNIP)
        Me.PanelDodajSerwis.Controls.Add(Me.Label20)
        Me.PanelDodajSerwis.Controls.Add(Me.Label28)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisMiasto)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisNazwa)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisDodaj)
        Me.PanelDodajSerwis.Controls.Add(Me.ErrLabelDodajSerwis)
        Me.PanelDodajSerwis.Controls.Add(Me.Label30)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisAdres)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisOpiekun)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisMail)
        Me.PanelDodajSerwis.Controls.Add(Me.Label31)
        Me.PanelDodajSerwis.Controls.Add(Me.Label32)
        Me.PanelDodajSerwis.Controls.Add(Me.Label33)
        Me.PanelDodajSerwis.Controls.Add(Me.Label34)
        Me.PanelDodajSerwis.Controls.Add(Me.Label35)
        Me.PanelDodajSerwis.Controls.Add(Me.DodajSerwisTelefon)
        Me.PanelDodajSerwis.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDodajSerwis.Location = New System.Drawing.Point(3, 2)
        Me.PanelDodajSerwis.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDodajSerwis.Name = "PanelDodajSerwis"
        Me.PanelDodajSerwis.Size = New System.Drawing.Size(533, 652)
        Me.PanelDodajSerwis.TabIndex = 6
        '
        'LicznikDodajSerwis
        '
        Me.LicznikDodajSerwis.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikDodajSerwis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikDodajSerwis.Location = New System.Drawing.Point(0, 589)
        Me.LicznikDodajSerwis.Name = "LicznikDodajSerwis"
        Me.LicznikDodajSerwis.Size = New System.Drawing.Size(531, 61)
        Me.LicznikDodajSerwis.TabIndex = 8
        Me.LicznikDodajSerwis.Text = "Label7"
        Me.LicznikDodajSerwis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DodajSerwisKodPocztowy
        '
        Me.DodajSerwisKodPocztowy.Location = New System.Drawing.Point(186, 185)
        Me.DodajSerwisKodPocztowy.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisKodPocztowy.Name = "DodajSerwisKodPocztowy"
        Me.DodajSerwisKodPocztowy.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisKodPocztowy.TabIndex = 6
        '
        'DodajSerwisNIP
        '
        Me.DodajSerwisNIP.Location = New System.Drawing.Point(186, 215)
        Me.DodajSerwisNIP.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisNIP.Name = "DodajSerwisNIP"
        Me.DodajSerwisNIP.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisNIP.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.Location = New System.Drawing.Point(22, 215)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 17)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "NIP:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label28.Location = New System.Drawing.Point(22, 188)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 17)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Kod pocztowy:"
        '
        'DodajSerwisMiasto
        '
        Me.DodajSerwisMiasto.Location = New System.Drawing.Point(186, 125)
        Me.DodajSerwisMiasto.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisMiasto.Name = "DodajSerwisMiasto"
        Me.DodajSerwisMiasto.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisMiasto.TabIndex = 4
        '
        'DodajSerwisNazwa
        '
        Me.DodajSerwisNazwa.Location = New System.Drawing.Point(186, 5)
        Me.DodajSerwisNazwa.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisNazwa.Name = "DodajSerwisNazwa"
        Me.DodajSerwisNazwa.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisNazwa.TabIndex = 0
        '
        'DodajSerwisDodaj
        '
        Me.DodajSerwisDodaj.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajSerwisDodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajSerwisDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.DodajSerwisDodaj.FlatAppearance.BorderSize = 2
        Me.DodajSerwisDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue
        Me.DodajSerwisDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.DodajSerwisDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajSerwisDodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajSerwisDodaj.Location = New System.Drawing.Point(25, 276)
        Me.DodajSerwisDodaj.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisDodaj.Name = "DodajSerwisDodaj"
        Me.DodajSerwisDodaj.Size = New System.Drawing.Size(486, 52)
        Me.DodajSerwisDodaj.TabIndex = 8
        Me.DodajSerwisDodaj.Text = "Dodaj"
        Me.DodajSerwisDodaj.UseVisualStyleBackColor = False
        '
        'ErrLabelDodajSerwis
        '
        Me.ErrLabelDodajSerwis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelDodajSerwis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelDodajSerwis.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelDodajSerwis.Location = New System.Drawing.Point(7, 332)
        Me.ErrLabelDodajSerwis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelDodajSerwis.Name = "ErrLabelDodajSerwis"
        Me.ErrLabelDodajSerwis.Size = New System.Drawing.Size(504, 260)
        Me.ErrLabelDodajSerwis.TabIndex = 11
        Me.ErrLabelDodajSerwis.Text = "Komunikat:"
        Me.ErrLabelDodajSerwis.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label30.Location = New System.Drawing.Point(22, 10)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 17)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Nazwa:"
        '
        'DodajSerwisAdres
        '
        Me.DodajSerwisAdres.Location = New System.Drawing.Point(186, 155)
        Me.DodajSerwisAdres.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisAdres.Name = "DodajSerwisAdres"
        Me.DodajSerwisAdres.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisAdres.TabIndex = 5
        '
        'DodajSerwisOpiekun
        '
        Me.DodajSerwisOpiekun.Location = New System.Drawing.Point(186, 65)
        Me.DodajSerwisOpiekun.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisOpiekun.Name = "DodajSerwisOpiekun"
        Me.DodajSerwisOpiekun.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisOpiekun.TabIndex = 2
        '
        'DodajSerwisMail
        '
        Me.DodajSerwisMail.Location = New System.Drawing.Point(186, 95)
        Me.DodajSerwisMail.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisMail.Name = "DodajSerwisMail"
        Me.DodajSerwisMail.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisMail.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label31.Location = New System.Drawing.Point(22, 158)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 17)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "Adres:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label32.Location = New System.Drawing.Point(22, 128)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 17)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Miasto:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label33.Location = New System.Drawing.Point(22, 68)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 17)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Opiekun:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label34.Location = New System.Drawing.Point(22, 100)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 17)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Mail:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label35.Location = New System.Drawing.Point(22, 40)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 17)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "Telefon:"
        '
        'DodajSerwisTelefon
        '
        Me.DodajSerwisTelefon.Location = New System.Drawing.Point(186, 35)
        Me.DodajSerwisTelefon.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajSerwisTelefon.Name = "DodajSerwisTelefon"
        Me.DodajSerwisTelefon.Size = New System.Drawing.Size(325, 22)
        Me.DodajSerwisTelefon.TabIndex = 1
        '
        'DodajPracownika
        '
        Me.DodajPracownika.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajPracownika.Controls.Add(Me.TabelaDodajPracownika)
        Me.DodajPracownika.Controls.Add(Me.PanelDodajPracownika)
        Me.DodajPracownika.Location = New System.Drawing.Point(4, 25)
        Me.DodajPracownika.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajPracownika.Name = "DodajPracownika"
        Me.DodajPracownika.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajPracownika.Size = New System.Drawing.Size(1233, 656)
        Me.DodajPracownika.TabIndex = 4
        Me.DodajPracownika.Text = "Dodaj pracownika"
        '
        'TabelaDodajPracownika
        '
        Me.TabelaDodajPracownika.AllowUserToAddRows = False
        Me.TabelaDodajPracownika.AllowUserToDeleteRows = False
        Me.TabelaDodajPracownika.AllowUserToOrderColumns = True
        Me.TabelaDodajPracownika.AutoGenerateContextFilters = True
        Me.TabelaDodajPracownika.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajPracownika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajPracownika.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TabelaDodajPracownika.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TabelaDodajPracownika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajPracownika.DateWithTime = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TabelaDodajPracownika.DefaultCellStyle = DataGridViewCellStyle2
        Me.TabelaDodajPracownika.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajPracownika.Location = New System.Drawing.Point(523, 2)
        Me.TabelaDodajPracownika.Name = "TabelaDodajPracownika"
        Me.TabelaDodajPracownika.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TabelaDodajPracownika.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TabelaDodajPracownika.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabelaDodajPracownika.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TabelaDodajPracownika.RowTemplate.Height = 24
        Me.TabelaDodajPracownika.Size = New System.Drawing.Size(707, 652)
        Me.TabelaDodajPracownika.TabIndex = 12
        Me.TabelaDodajPracownika.TimeFilter = False
        '
        'PanelDodajPracownika
        '
        Me.PanelDodajPracownika.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaImie)
        Me.PanelDodajPracownika.Controls.Add(Me.LicznikDodajPracownika)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikLvlDostep)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaBtn)
        Me.PanelDodajPracownika.Controls.Add(Me.ErrLabelPracownik)
        Me.PanelDodajPracownika.Controls.Add(Me.Label22)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaHaslo)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaLogin)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaMail)
        Me.PanelDodajPracownika.Controls.Add(Me.Label23)
        Me.PanelDodajPracownika.Controls.Add(Me.Label24)
        Me.PanelDodajPracownika.Controls.Add(Me.Label25)
        Me.PanelDodajPracownika.Controls.Add(Me.Label26)
        Me.PanelDodajPracownika.Controls.Add(Me.Label27)
        Me.PanelDodajPracownika.Controls.Add(Me.DodajPracownikaNazwisko)
        Me.PanelDodajPracownika.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDodajPracownika.Location = New System.Drawing.Point(3, 2)
        Me.PanelDodajPracownika.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDodajPracownika.Name = "PanelDodajPracownika"
        Me.PanelDodajPracownika.Size = New System.Drawing.Size(520, 652)
        Me.PanelDodajPracownika.TabIndex = 9
        '
        'DodajPracownikaImie
        '
        Me.DodajPracownikaImie.Location = New System.Drawing.Point(188, 6)
        Me.DodajPracownikaImie.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaImie.Name = "DodajPracownikaImie"
        Me.DodajPracownikaImie.Size = New System.Drawing.Size(325, 22)
        Me.DodajPracownikaImie.TabIndex = 0
        '
        'LicznikDodajPracownika
        '
        Me.LicznikDodajPracownika.BackColor = System.Drawing.Color.LightSlateGray
        Me.LicznikDodajPracownika.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikDodajPracownika.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikDodajPracownika.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikDodajPracownika.Location = New System.Drawing.Point(0, 618)
        Me.LicznikDodajPracownika.Name = "LicznikDodajPracownika"
        Me.LicznikDodajPracownika.Size = New System.Drawing.Size(520, 34)
        Me.LicznikDodajPracownika.TabIndex = 11
        Me.LicznikDodajPracownika.Text = "Label7"
        Me.LicznikDodajPracownika.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'DodajPracownikLvlDostep
        '
        Me.DodajPracownikLvlDostep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajPracownikLvlDostep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajPracownikLvlDostep.FormattingEnabled = True
        Me.DodajPracownikLvlDostep.Items.AddRange(New Object() {"Zwykły", "Administrator"})
        Me.DodajPracownikLvlDostep.Location = New System.Drawing.Point(188, 156)
        Me.DodajPracownikLvlDostep.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikLvlDostep.Name = "DodajPracownikLvlDostep"
        Me.DodajPracownikLvlDostep.Size = New System.Drawing.Size(325, 24)
        Me.DodajPracownikLvlDostep.TabIndex = 5
        '
        'DodajPracownikaBtn
        '
        Me.DodajPracownikaBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajPracownikaBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajPracownikaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajPracownikaBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajPracownikaBtn.Location = New System.Drawing.Point(28, 197)
        Me.DodajPracownikaBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaBtn.Name = "DodajPracownikaBtn"
        Me.DodajPracownikaBtn.Size = New System.Drawing.Size(485, 52)
        Me.DodajPracownikaBtn.TabIndex = 6
        Me.DodajPracownikaBtn.Text = "Dodaj"
        Me.DodajPracownikaBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelPracownik
        '
        Me.ErrLabelPracownik.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelPracownik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelPracownik.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelPracownik.Location = New System.Drawing.Point(4, 253)
        Me.ErrLabelPracownik.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelPracownik.Name = "ErrLabelPracownik"
        Me.ErrLabelPracownik.Size = New System.Drawing.Size(516, 294)
        Me.ErrLabelPracownik.TabIndex = 11
        Me.ErrLabelPracownik.Text = "ErrLabel"
        Me.ErrLabelPracownik.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.Location = New System.Drawing.Point(26, 6)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 17)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Imie:"
        '
        'DodajPracownikaHaslo
        '
        Me.DodajPracownikaHaslo.Location = New System.Drawing.Point(188, 126)
        Me.DodajPracownikaHaslo.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaHaslo.Name = "DodajPracownikaHaslo"
        Me.DodajPracownikaHaslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DodajPracownikaHaslo.Size = New System.Drawing.Size(325, 22)
        Me.DodajPracownikaHaslo.TabIndex = 4
        '
        'DodajPracownikaLogin
        '
        Me.DodajPracownikaLogin.Location = New System.Drawing.Point(188, 96)
        Me.DodajPracownikaLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaLogin.Name = "DodajPracownikaLogin"
        Me.DodajPracownikaLogin.Size = New System.Drawing.Size(325, 22)
        Me.DodajPracownikaLogin.TabIndex = 3
        '
        'DodajPracownikaMail
        '
        Me.DodajPracownikaMail.Location = New System.Drawing.Point(188, 66)
        Me.DodajPracownikaMail.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaMail.Name = "DodajPracownikaMail"
        Me.DodajPracownikaMail.Size = New System.Drawing.Size(325, 22)
        Me.DodajPracownikaMail.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.Location = New System.Drawing.Point(25, 95)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 17)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Login:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.Location = New System.Drawing.Point(26, 125)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 17)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Haslo:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.Location = New System.Drawing.Point(26, 155)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 17)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Poziom dostępu:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label26.Location = New System.Drawing.Point(26, 65)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Mail:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label27.Location = New System.Drawing.Point(26, 36)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 17)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Nazwisko:"
        '
        'DodajPracownikaNazwisko
        '
        Me.DodajPracownikaNazwisko.Location = New System.Drawing.Point(188, 36)
        Me.DodajPracownikaNazwisko.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajPracownikaNazwisko.Name = "DodajPracownikaNazwisko"
        Me.DodajPracownikaNazwisko.Size = New System.Drawing.Size(325, 22)
        Me.DodajPracownikaNazwisko.TabIndex = 1
        '
        'DodajNarzędzie
        '
        Me.DodajNarzędzie.BackColor = System.Drawing.Color.LightSlateGray
        Me.DodajNarzędzie.Controls.Add(Me.TabelaDodajNarzędzie)
        Me.DodajNarzędzie.Controls.Add(Me.PanelNarzędzie)
        Me.DodajNarzędzie.Location = New System.Drawing.Point(4, 25)
        Me.DodajNarzędzie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajNarzędzie.Name = "DodajNarzędzie"
        Me.DodajNarzędzie.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DodajNarzędzie.Size = New System.Drawing.Size(1233, 656)
        Me.DodajNarzędzie.TabIndex = 3
        Me.DodajNarzędzie.Text = "Dodaj narzędzie"
        '
        'TabelaDodajNarzędzie
        '
        Me.TabelaDodajNarzędzie.AllowUserToAddRows = False
        Me.TabelaDodajNarzędzie.AllowUserToDeleteRows = False
        Me.TabelaDodajNarzędzie.AllowUserToOrderColumns = True
        Me.TabelaDodajNarzędzie.AutoGenerateContextFilters = True
        Me.TabelaDodajNarzędzie.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaDodajNarzędzie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaDodajNarzędzie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaDodajNarzędzie.DateWithTime = False
        Me.TabelaDodajNarzędzie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaDodajNarzędzie.Location = New System.Drawing.Point(522, 2)
        Me.TabelaDodajNarzędzie.Name = "TabelaDodajNarzędzie"
        Me.TabelaDodajNarzędzie.ReadOnly = True
        Me.TabelaDodajNarzędzie.RowHeadersWidth = 51
        Me.TabelaDodajNarzędzie.RowTemplate.Height = 24
        Me.TabelaDodajNarzędzie.Size = New System.Drawing.Size(708, 652)
        Me.TabelaDodajNarzędzie.TabIndex = 4
        Me.TabelaDodajNarzędzie.TimeFilter = False
        '
        'PanelNarzędzie
        '
        Me.PanelNarzędzie.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieTyp)
        Me.PanelNarzędzie.Controls.Add(Me.LicznikNarzędzia)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieBtn)
        Me.PanelNarzędzie.Controls.Add(Me.ErrLabelNarzędzie)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieGwarancja)
        Me.PanelNarzędzie.Controls.Add(Me.Label6)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieWybierzFakture)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieCena)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieNumerSeryjny)
        Me.PanelNarzędzie.Controls.Add(Me.Label5)
        Me.PanelNarzędzie.Controls.Add(Me.Label4)
        Me.PanelNarzędzie.Controls.Add(Me.Label3)
        Me.PanelNarzędzie.Controls.Add(Me.Label2)
        Me.PanelNarzędzie.Controls.Add(Me.Label1)
        Me.PanelNarzędzie.Controls.Add(Me.DodajNarzędzieModel)
        Me.PanelNarzędzie.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelNarzędzie.Location = New System.Drawing.Point(3, 2)
        Me.PanelNarzędzie.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelNarzędzie.Name = "PanelNarzędzie"
        Me.PanelNarzędzie.Size = New System.Drawing.Size(519, 652)
        Me.PanelNarzędzie.TabIndex = 0
        '
        'DodajNarzędzieTyp
        '
        Me.DodajNarzędzieTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajNarzędzieTyp.FormattingEnabled = True
        Me.DodajNarzędzieTyp.Location = New System.Drawing.Point(186, 68)
        Me.DodajNarzędzieTyp.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieTyp.Name = "DodajNarzędzieTyp"
        Me.DodajNarzędzieTyp.Size = New System.Drawing.Size(325, 24)
        Me.DodajNarzędzieTyp.TabIndex = 12
        '
        'LicznikNarzędzia
        '
        Me.LicznikNarzędzia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikNarzędzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikNarzędzia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikNarzędzia.Location = New System.Drawing.Point(0, 613)
        Me.LicznikNarzędzia.Name = "LicznikNarzędzia"
        Me.LicznikNarzędzia.Size = New System.Drawing.Size(519, 39)
        Me.LicznikNarzędzia.TabIndex = 8
        Me.LicznikNarzędzia.Text = "Licznik narzędzia:"
        Me.LicznikNarzędzia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DodajNarzędzieBtn
        '
        Me.DodajNarzędzieBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.DodajNarzędzieBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DodajNarzędzieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DodajNarzędzieBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DodajNarzędzieBtn.Location = New System.Drawing.Point(29, 195)
        Me.DodajNarzędzieBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieBtn.Name = "DodajNarzędzieBtn"
        Me.DodajNarzędzieBtn.Size = New System.Drawing.Size(485, 52)
        Me.DodajNarzędzieBtn.TabIndex = 6
        Me.DodajNarzędzieBtn.Text = "Dodaj"
        Me.DodajNarzędzieBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelNarzędzie
        '
        Me.ErrLabelNarzędzie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelNarzędzie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelNarzędzie.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelNarzędzie.Location = New System.Drawing.Point(5, 335)
        Me.ErrLabelNarzędzie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelNarzędzie.Name = "ErrLabelNarzędzie"
        Me.ErrLabelNarzędzie.Size = New System.Drawing.Size(526, 252)
        Me.ErrLabelNarzędzie.TabIndex = 11
        Me.ErrLabelNarzędzie.Text = "ErrLabel"
        Me.ErrLabelNarzędzie.Visible = False
        '
        'DodajNarzędzieGwarancja
        '
        Me.DodajNarzędzieGwarancja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DodajNarzędzieGwarancja.Location = New System.Drawing.Point(186, 131)
        Me.DodajNarzędzieGwarancja.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieGwarancja.Name = "DodajNarzędzieGwarancja"
        Me.DodajNarzędzieGwarancja.Size = New System.Drawing.Size(327, 22)
        Me.DodajNarzędzieGwarancja.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Wybierz fakture:"
        '
        'DodajNarzędzieWybierzFakture
        '
        Me.DodajNarzędzieWybierzFakture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DodajNarzędzieWybierzFakture.FormattingEnabled = True
        Me.DodajNarzędzieWybierzFakture.Location = New System.Drawing.Point(187, 4)
        Me.DodajNarzędzieWybierzFakture.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieWybierzFakture.Name = "DodajNarzędzieWybierzFakture"
        Me.DodajNarzędzieWybierzFakture.Size = New System.Drawing.Size(325, 24)
        Me.DodajNarzędzieWybierzFakture.TabIndex = 0
        '
        'DodajNarzędzieCena
        '
        Me.DodajNarzędzieCena.Location = New System.Drawing.Point(187, 163)
        Me.DodajNarzędzieCena.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieCena.Name = "DodajNarzędzieCena"
        Me.DodajNarzędzieCena.Size = New System.Drawing.Size(325, 22)
        Me.DodajNarzędzieCena.TabIndex = 5
        '
        'DodajNarzędzieNumerSeryjny
        '
        Me.DodajNarzędzieNumerSeryjny.Location = New System.Drawing.Point(187, 99)
        Me.DodajNarzędzieNumerSeryjny.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieNumerSeryjny.Name = "DodajNarzędzieNumerSeryjny"
        Me.DodajNarzędzieNumerSeryjny.Size = New System.Drawing.Size(325, 22)
        Me.DodajNarzędzieNumerSeryjny.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cena:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gwarancja:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Numer seryjny:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Typ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Model:"
        '
        'DodajNarzędzieModel
        '
        Me.DodajNarzędzieModel.Location = New System.Drawing.Point(187, 38)
        Me.DodajNarzędzieModel.Margin = New System.Windows.Forms.Padding(4)
        Me.DodajNarzędzieModel.Name = "DodajNarzędzieModel"
        Me.DodajNarzędzieModel.Size = New System.Drawing.Size(325, 22)
        Me.DodajNarzędzieModel.TabIndex = 1
        '
        'MojeWypożyczenia
        '
        Me.MojeWypożyczenia.BackColor = System.Drawing.Color.LightSlateGray
        Me.MojeWypożyczenia.Controls.Add(Me.TabelaMojeWypo)
        Me.MojeWypożyczenia.Controls.Add(Me.Panel3)
        Me.MojeWypożyczenia.Location = New System.Drawing.Point(4, 25)
        Me.MojeWypożyczenia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MojeWypożyczenia.Name = "MojeWypożyczenia"
        Me.MojeWypożyczenia.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MojeWypożyczenia.Size = New System.Drawing.Size(1233, 656)
        Me.MojeWypożyczenia.TabIndex = 2
        Me.MojeWypożyczenia.Text = "Wypożyczenia"
        '
        'TabelaMojeWypo
        '
        Me.TabelaMojeWypo.AllowUserToAddRows = False
        Me.TabelaMojeWypo.AllowUserToDeleteRows = False
        Me.TabelaMojeWypo.AllowUserToOrderColumns = True
        Me.TabelaMojeWypo.AutoGenerateContextFilters = True
        Me.TabelaMojeWypo.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.TabelaMojeWypo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabelaMojeWypo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelaMojeWypo.DateWithTime = False
        Me.TabelaMojeWypo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabelaMojeWypo.Location = New System.Drawing.Point(535, 2)
        Me.TabelaMojeWypo.Name = "TabelaMojeWypo"
        Me.TabelaMojeWypo.ReadOnly = True
        Me.TabelaMojeWypo.RowHeadersWidth = 51
        Me.TabelaMojeWypo.RowTemplate.Height = 24
        Me.TabelaMojeWypo.Size = New System.Drawing.Size(695, 652)
        Me.TabelaMojeWypo.TabIndex = 6
        Me.TabelaMojeWypo.TimeFilter = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.ChckFiltrPracownika)
        Me.Panel3.Controls.Add(Me.IdPracownikaMojeWypo)
        Me.Panel3.Controls.Add(Me.LicznikMojeWypo)
        Me.Panel3.Controls.Add(Me.WybierzWypo)
        Me.Panel3.Controls.Add(Me.ErrLabelMojeWypożyczenia)
        Me.Panel3.Controls.Add(Me.IdPracownikaMojeWypoLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(532, 652)
        Me.Panel3.TabIndex = 3
        '
        'ChckFiltrPracownika
        '
        Me.ChckFiltrPracownika.AutoSize = True
        Me.ChckFiltrPracownika.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChckFiltrPracownika.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ChckFiltrPracownika.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ChckFiltrPracownika.Location = New System.Drawing.Point(190, 35)
        Me.ChckFiltrPracownika.Name = "ChckFiltrPracownika"
        Me.ChckFiltrPracownika.Size = New System.Drawing.Size(237, 28)
        Me.ChckFiltrPracownika.TabIndex = 13
        Me.ChckFiltrPracownika.Text = "Włącz filtr pracownika"
        Me.ChckFiltrPracownika.UseVisualStyleBackColor = True
        '
        'IdPracownikaMojeWypo
        '
        Me.IdPracownikaMojeWypo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPracownikaMojeWypo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IdPracownikaMojeWypo.FormattingEnabled = True
        Me.IdPracownikaMojeWypo.Location = New System.Drawing.Point(190, 4)
        Me.IdPracownikaMojeWypo.Margin = New System.Windows.Forms.Padding(4)
        Me.IdPracownikaMojeWypo.Name = "IdPracownikaMojeWypo"
        Me.IdPracownikaMojeWypo.Size = New System.Drawing.Size(325, 24)
        Me.IdPracownikaMojeWypo.TabIndex = 12
        '
        'LicznikMojeWypo
        '
        Me.LicznikMojeWypo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikMojeWypo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikMojeWypo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikMojeWypo.Location = New System.Drawing.Point(0, 597)
        Me.LicznikMojeWypo.Name = "LicznikMojeWypo"
        Me.LicznikMojeWypo.Size = New System.Drawing.Size(532, 55)
        Me.LicznikMojeWypo.TabIndex = 8
        Me.LicznikMojeWypo.Text = "Licznik wypożyczenia:"
        Me.LicznikMojeWypo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WybierzWypo
        '
        Me.WybierzWypo.BackColor = System.Drawing.Color.RoyalBlue
        Me.WybierzWypo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WybierzWypo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WybierzWypo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.WybierzWypo.Location = New System.Drawing.Point(40, 81)
        Me.WybierzWypo.Margin = New System.Windows.Forms.Padding(4)
        Me.WybierzWypo.Name = "WybierzWypo"
        Me.WybierzWypo.Size = New System.Drawing.Size(485, 52)
        Me.WybierzWypo.TabIndex = 6
        Me.WybierzWypo.Text = "Wybierz"
        Me.WybierzWypo.UseVisualStyleBackColor = False
        '
        'ErrLabelMojeWypożyczenia
        '
        Me.ErrLabelMojeWypożyczenia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelMojeWypożyczenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelMojeWypożyczenia.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelMojeWypożyczenia.Location = New System.Drawing.Point(4, 169)
        Me.ErrLabelMojeWypożyczenia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelMojeWypożyczenia.Name = "ErrLabelMojeWypożyczenia"
        Me.ErrLabelMojeWypożyczenia.Size = New System.Drawing.Size(511, 345)
        Me.ErrLabelMojeWypożyczenia.TabIndex = 11
        Me.ErrLabelMojeWypożyczenia.Text = "ErrLabel"
        Me.ErrLabelMojeWypożyczenia.Visible = False
        '
        'IdPracownikaMojeWypoLabel
        '
        Me.IdPracownikaMojeWypoLabel.AutoSize = True
        Me.IdPracownikaMojeWypoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IdPracownikaMojeWypoLabel.Location = New System.Drawing.Point(27, 4)
        Me.IdPracownikaMojeWypoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdPracownikaMojeWypoLabel.Name = "IdPracownikaMojeWypoLabel"
        Me.IdPracownikaMojeWypoLabel.Size = New System.Drawing.Size(107, 17)
        Me.IdPracownikaMojeWypoLabel.TabIndex = 4
        Me.IdPracownikaMojeWypoLabel.Text = "Id pracownika"
        '
        'ZwróćTab
        '
        Me.ZwróćTab.BackColor = System.Drawing.Color.LightSlateGray
        Me.ZwróćTab.Controls.Add(Me.ZwróćTabela)
        Me.ZwróćTab.Controls.Add(Me.ZwróćPanel)
        Me.ZwróćTab.Location = New System.Drawing.Point(4, 25)
        Me.ZwróćTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZwróćTab.Name = "ZwróćTab"
        Me.ZwróćTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZwróćTab.Size = New System.Drawing.Size(1233, 656)
        Me.ZwróćTab.TabIndex = 1
        Me.ZwróćTab.Text = "Zwróć"
        '
        'ZwróćTabela
        '
        Me.ZwróćTabela.AllowUserToAddRows = False
        Me.ZwróćTabela.AllowUserToDeleteRows = False
        Me.ZwróćTabela.AllowUserToOrderColumns = True
        Me.ZwróćTabela.AutoGenerateContextFilters = True
        Me.ZwróćTabela.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.ZwróćTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ZwróćTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ZwróćTabela.DateWithTime = False
        Me.ZwróćTabela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZwróćTabela.Location = New System.Drawing.Point(535, 2)
        Me.ZwróćTabela.Name = "ZwróćTabela"
        Me.ZwróćTabela.ReadOnly = True
        Me.ZwróćTabela.RowHeadersWidth = 51
        Me.ZwróćTabela.RowTemplate.Height = 24
        Me.ZwróćTabela.Size = New System.Drawing.Size(695, 652)
        Me.ZwróćTabela.TabIndex = 6
        Me.ZwróćTabela.TimeFilter = False
        '
        'ZwróćPanel
        '
        Me.ZwróćPanel.BackColor = System.Drawing.Color.LightSlateGray
        Me.ZwróćPanel.Controls.Add(Me.Label36)
        Me.ZwróćPanel.Controls.Add(Me.UwagiZwróć)
        Me.ZwróćPanel.Controls.Add(Me.IdNarzędziaZwróć)
        Me.ZwróćPanel.Controls.Add(Me.LicznikZwróc)
        Me.ZwróćPanel.Controls.Add(Me.ZwróćBtn)
        Me.ZwróćPanel.Controls.Add(Me.ErrLabelZwróc)
        Me.ZwróćPanel.Controls.Add(Me.Label48)
        Me.ZwróćPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ZwróćPanel.Location = New System.Drawing.Point(3, 2)
        Me.ZwróćPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ZwróćPanel.Name = "ZwróćPanel"
        Me.ZwróćPanel.Size = New System.Drawing.Size(532, 652)
        Me.ZwróćPanel.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label36.Location = New System.Drawing.Point(28, 35)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 17)
        Me.Label36.TabIndex = 14
        Me.Label36.Text = "Uwagi:"
        '
        'UwagiZwróć
        '
        Me.UwagiZwróć.Location = New System.Drawing.Point(190, 35)
        Me.UwagiZwróć.Name = "UwagiZwróć"
        Me.UwagiZwróć.Size = New System.Drawing.Size(325, 22)
        Me.UwagiZwróć.TabIndex = 13
        '
        'IdNarzędziaZwróć
        '
        Me.IdNarzędziaZwróć.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdNarzędziaZwróć.FormattingEnabled = True
        Me.IdNarzędziaZwróć.Location = New System.Drawing.Point(190, 4)
        Me.IdNarzędziaZwróć.Margin = New System.Windows.Forms.Padding(4)
        Me.IdNarzędziaZwróć.Name = "IdNarzędziaZwróć"
        Me.IdNarzędziaZwróć.Size = New System.Drawing.Size(325, 24)
        Me.IdNarzędziaZwróć.TabIndex = 12
        '
        'LicznikZwróc
        '
        Me.LicznikZwróc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikZwróc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikZwróc.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikZwróc.Location = New System.Drawing.Point(0, 597)
        Me.LicznikZwróc.Name = "LicznikZwróc"
        Me.LicznikZwróc.Size = New System.Drawing.Size(532, 55)
        Me.LicznikZwróc.TabIndex = 8
        Me.LicznikZwróc.Text = "Licznik narzędzia:"
        Me.LicznikZwróc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ZwróćBtn
        '
        Me.ZwróćBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.ZwróćBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ZwróćBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ZwróćBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ZwróćBtn.Location = New System.Drawing.Point(30, 64)
        Me.ZwróćBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ZwróćBtn.Name = "ZwróćBtn"
        Me.ZwróćBtn.Size = New System.Drawing.Size(485, 52)
        Me.ZwróćBtn.TabIndex = 6
        Me.ZwróćBtn.Text = "Zwróć"
        Me.ZwróćBtn.UseVisualStyleBackColor = False
        '
        'ErrLabelZwróc
        '
        Me.ErrLabelZwróc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLabelZwróc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLabelZwróc.ForeColor = System.Drawing.Color.Black
        Me.ErrLabelZwróc.Location = New System.Drawing.Point(4, 169)
        Me.ErrLabelZwróc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLabelZwróc.Name = "ErrLabelZwróc"
        Me.ErrLabelZwróc.Size = New System.Drawing.Size(511, 345)
        Me.ErrLabelZwróc.TabIndex = 11
        Me.ErrLabelZwróc.Text = "ErrLabel"
        Me.ErrLabelZwróc.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label48.Location = New System.Drawing.Point(27, 4)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(102, 17)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "Id narzędzia:"
        '
        'WypożyczTab
        '
        Me.WypożyczTab.BackColor = System.Drawing.Color.LightSlateGray
        Me.WypożyczTab.Controls.Add(Me.WypożyczTabela)
        Me.WypożyczTab.Controls.Add(Me.WypożyczPanel)
        Me.WypożyczTab.Location = New System.Drawing.Point(4, 25)
        Me.WypożyczTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WypożyczTab.Name = "WypożyczTab"
        Me.WypożyczTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WypożyczTab.Size = New System.Drawing.Size(1233, 656)
        Me.WypożyczTab.TabIndex = 0
        Me.WypożyczTab.Text = "Wypożycz"
        '
        'WypożyczTabela
        '
        Me.WypożyczTabela.AllowUserToAddRows = False
        Me.WypożyczTabela.AllowUserToDeleteRows = False
        Me.WypożyczTabela.AllowUserToOrderColumns = True
        Me.WypożyczTabela.AutoGenerateContextFilters = True
        Me.WypożyczTabela.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.WypożyczTabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WypożyczTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WypożyczTabela.DateWithTime = False
        Me.WypożyczTabela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WypożyczTabela.Location = New System.Drawing.Point(527, 2)
        Me.WypożyczTabela.Name = "WypożyczTabela"
        Me.WypożyczTabela.ReadOnly = True
        Me.WypożyczTabela.RowHeadersWidth = 51
        Me.WypożyczTabela.RowTemplate.Height = 24
        Me.WypożyczTabela.Size = New System.Drawing.Size(703, 652)
        Me.WypożyczTabela.TabIndex = 5
        Me.WypożyczTabela.TimeFilter = False
        '
        'WypożyczPanel
        '
        Me.WypożyczPanel.BackColor = System.Drawing.Color.LightSlateGray
        Me.WypożyczPanel.Controls.Add(Me.UwagiLblWypożycz)
        Me.WypożyczPanel.Controls.Add(Me.UwagiWypożycz)
        Me.WypożyczPanel.Controls.Add(Me.IdNarzedziaWypożycz)
        Me.WypożyczPanel.Controls.Add(Me.LicznikWypożycz)
        Me.WypożyczPanel.Controls.Add(Me.WypożyczBtn)
        Me.WypożyczPanel.Controls.Add(Me.ErrLblWypożycz)
        Me.WypożyczPanel.Controls.Add(Me.IDPracownikaWypożyczLbl)
        Me.WypożyczPanel.Controls.Add(Me.IdPracownikaWypozycz)
        Me.WypożyczPanel.Controls.Add(Me.IdNarzedziaWypożyczLbl)
        Me.WypożyczPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.WypożyczPanel.Location = New System.Drawing.Point(3, 2)
        Me.WypożyczPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.WypożyczPanel.Name = "WypożyczPanel"
        Me.WypożyczPanel.Size = New System.Drawing.Size(524, 652)
        Me.WypożyczPanel.TabIndex = 1
        '
        'UwagiLblWypożycz
        '
        Me.UwagiLblWypożycz.AutoSize = True
        Me.UwagiLblWypożycz.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UwagiLblWypożycz.Location = New System.Drawing.Point(25, 67)
        Me.UwagiLblWypożycz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UwagiLblWypożycz.Name = "UwagiLblWypożycz"
        Me.UwagiLblWypożycz.Size = New System.Drawing.Size(56, 17)
        Me.UwagiLblWypożycz.TabIndex = 14
        Me.UwagiLblWypożycz.Text = "Uwagi:"
        '
        'UwagiWypożycz
        '
        Me.UwagiWypożycz.Location = New System.Drawing.Point(187, 67)
        Me.UwagiWypożycz.Name = "UwagiWypożycz"
        Me.UwagiWypożycz.Size = New System.Drawing.Size(325, 22)
        Me.UwagiWypożycz.TabIndex = 13
        '
        'IdNarzedziaWypożycz
        '
        Me.IdNarzedziaWypożycz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdNarzedziaWypożycz.FormattingEnabled = True
        Me.IdNarzedziaWypożycz.Location = New System.Drawing.Point(187, 36)
        Me.IdNarzedziaWypożycz.Margin = New System.Windows.Forms.Padding(4)
        Me.IdNarzedziaWypożycz.Name = "IdNarzedziaWypożycz"
        Me.IdNarzedziaWypożycz.Size = New System.Drawing.Size(325, 24)
        Me.IdNarzedziaWypożycz.TabIndex = 12
        '
        'LicznikWypożycz
        '
        Me.LicznikWypożycz.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LicznikWypożycz.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LicznikWypożycz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicznikWypożycz.Location = New System.Drawing.Point(0, 557)
        Me.LicznikWypożycz.Name = "LicznikWypożycz"
        Me.LicznikWypożycz.Size = New System.Drawing.Size(524, 95)
        Me.LicznikWypożycz.TabIndex = 8
        Me.LicznikWypożycz.Text = "Licznik narzędzia:"
        Me.LicznikWypożycz.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WypożyczBtn
        '
        Me.WypożyczBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.WypożyczBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WypożyczBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WypożyczBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.WypożyczBtn.Location = New System.Drawing.Point(27, 113)
        Me.WypożyczBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.WypożyczBtn.Name = "WypożyczBtn"
        Me.WypożyczBtn.Size = New System.Drawing.Size(485, 52)
        Me.WypożyczBtn.TabIndex = 6
        Me.WypożyczBtn.Text = "Wypożycz"
        Me.WypożyczBtn.UseVisualStyleBackColor = False
        '
        'ErrLblWypożycz
        '
        Me.ErrLblWypożycz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrLblWypożycz.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ErrLblWypożycz.ForeColor = System.Drawing.Color.Black
        Me.ErrLblWypożycz.Location = New System.Drawing.Point(4, 169)
        Me.ErrLblWypożycz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrLblWypożycz.Name = "ErrLblWypożycz"
        Me.ErrLblWypożycz.Size = New System.Drawing.Size(511, 345)
        Me.ErrLblWypożycz.TabIndex = 11
        Me.ErrLblWypożycz.Text = "ErrLabel"
        Me.ErrLblWypożycz.Visible = False
        '
        'IDPracownikaWypożyczLbl
        '
        Me.IDPracownikaWypożyczLbl.AutoSize = True
        Me.IDPracownikaWypożyczLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IDPracownikaWypożyczLbl.Location = New System.Drawing.Point(25, 4)
        Me.IDPracownikaWypożyczLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDPracownikaWypożyczLbl.Name = "IDPracownikaWypożyczLbl"
        Me.IDPracownikaWypożyczLbl.Size = New System.Drawing.Size(112, 17)
        Me.IDPracownikaWypożyczLbl.TabIndex = 10
        Me.IDPracownikaWypożyczLbl.Text = "Id pracownika:"
        '
        'IdPracownikaWypozycz
        '
        Me.IdPracownikaWypozycz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdPracownikaWypozycz.FormattingEnabled = True
        Me.IdPracownikaWypozycz.Location = New System.Drawing.Point(187, 4)
        Me.IdPracownikaWypozycz.Margin = New System.Windows.Forms.Padding(4)
        Me.IdPracownikaWypozycz.Name = "IdPracownikaWypozycz"
        Me.IdPracownikaWypozycz.Size = New System.Drawing.Size(325, 24)
        Me.IdPracownikaWypozycz.TabIndex = 0
        '
        'IdNarzedziaWypożyczLbl
        '
        Me.IdNarzedziaWypożyczLbl.AutoSize = True
        Me.IdNarzedziaWypożyczLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IdNarzedziaWypożyczLbl.Location = New System.Drawing.Point(24, 36)
        Me.IdNarzedziaWypożyczLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdNarzedziaWypożyczLbl.Name = "IdNarzedziaWypożyczLbl"
        Me.IdNarzedziaWypożyczLbl.Size = New System.Drawing.Size(102, 17)
        Me.IdNarzedziaWypożyczLbl.TabIndex = 4
        Me.IdNarzedziaWypożyczLbl.Text = "Id narzędzia:"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.WypożyczTab)
        Me.TabControl.Controls.Add(Me.ZwróćTab)
        Me.TabControl.Controls.Add(Me.MojeWypożyczenia)
        Me.TabControl.Controls.Add(Me.DodajNarzędzie)
        Me.TabControl.Controls.Add(Me.DodajPracownika)
        Me.TabControl.Controls.Add(Me.DodajSerwis)
        Me.TabControl.Controls.Add(Me.StanMagazynu)
        Me.TabControl.Controls.Add(Me.OddajNaSerwis)
        Me.TabControl.Controls.Add(Me.PowrótZserwisu)
        Me.TabControl.Controls.Add(Me.DodajDostawce)
        Me.TabControl.Controls.Add(Me.HistoriaNarzędzia)
        Me.TabControl.Controls.Add(Me.DodajFakture)
        Me.TabControl.Controls.Add(Me.DodajFaktureSerwis)
        Me.TabControl.Controls.Add(Me.TypNarzedzia)
        Me.TabControl.Controls.Add(Me.Edytuj)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 38)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl.MinimumSize = New System.Drawing.Size(1067, 685)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1241, 685)
        Me.TabControl.TabIndex = 2
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1241, 647)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1067, 685)
        Me.Name = "form"
        Me.Text = "Narzędziownia - Menu"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.Narzedziownia2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UzytkownicyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarzedziaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Narzedziownia2DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Edytuj.ResumeLayout(False)
        CType(Me.EdytujTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TypNarzedzia.ResumeLayout(False)
        CType(Me.TypNarzedziaTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypNarzedziaPanel.ResumeLayout(False)
        Me.TypNarzedziaPanel.PerformLayout()
        Me.DodajFaktureSerwis.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.TabelaDodajFaktureSerwis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDodajFaktureSerwis.ResumeLayout(False)
        Me.PanelDodajFaktureSerwis.PerformLayout()
        Me.DodajFakture.ResumeLayout(False)
        CType(Me.TabelaDodajFakture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDodajFakture.ResumeLayout(False)
        Me.PanelDodajFakture.PerformLayout()
        Me.DodajDostawce.ResumeLayout(False)
        CType(Me.TabelaDodajDostawce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDostawca.ResumeLayout(False)
        Me.PanelDostawca.PerformLayout()
        Me.DodajSerwis.ResumeLayout(False)
        CType(Me.TabelaDodajSerwis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDodajSerwis.ResumeLayout(False)
        Me.PanelDodajSerwis.PerformLayout()
        Me.DodajPracownika.ResumeLayout(False)
        CType(Me.TabelaDodajPracownika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDodajPracownika.ResumeLayout(False)
        Me.PanelDodajPracownika.PerformLayout()
        Me.DodajNarzędzie.ResumeLayout(False)
        CType(Me.TabelaDodajNarzędzie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNarzędzie.ResumeLayout(False)
        Me.PanelNarzędzie.PerformLayout()
        Me.MojeWypożyczenia.ResumeLayout(False)
        CType(Me.TabelaMojeWypo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ZwróćTab.ResumeLayout(False)
        CType(Me.ZwróćTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZwróćPanel.ResumeLayout(False)
        Me.ZwróćPanel.PerformLayout()
        Me.WypożyczTab.ResumeLayout(False)
        CType(Me.WypożyczTabela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WypożyczPanel.ResumeLayout(False)
        Me.WypożyczPanel.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ObsługaWypożyczeńToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Wypożycz As ToolStripMenuItem
    Friend WithEvents Zwrot As ToolStripMenuItem
    Friend WithEvents SprawdźMojeWypożyczeniaMenu As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents AdminToolStrip As ToolStripMenuItem
    Friend WithEvents NarzedzieMenu As ToolStripMenuItem
    Friend WithEvents PracownikMenu As ToolStripMenuItem
    Friend WithEvents Admin As ToolStripSeparator
    Friend WithEvents SerwisMenu As ToolStripMenuItem
    Friend WithEvents DostawceMenu As ToolStripMenuItem
    Friend WithEvents OddajNaSerwisMenu As ToolStripMenuItem
    Friend WithEvents RaportyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StanMagazynuMenu As ToolStripMenuItem
    Friend WithEvents WypożyczeniaNaPracownikaMenu As ToolStripMenuItem
    Friend WithEvents HistoriaNarzędziaMenu As ToolStripMenuItem
    Friend WithEvents PowrotZserwisuMenu As ToolStripMenuItem
    Friend WithEvents FakturyMenu As ToolStripMenuItem
    Friend WithEvents Narzedziownia2DataSet As Narzedziownia2DataSet
    Friend WithEvents FakturyTableAdapter As Narzedziownia2DataSetTableAdapters.FakturyTableAdapter
    Friend WithEvents Narzedziownia2DataSet1 As Narzedziownia2DataSet1
    Friend WithEvents DostawcaTableAdapter As Narzedziownia2DataSet1TableAdapters.DostawcaTableAdapter
    Friend WithEvents Narzedziownia2DataSet2 As Narzedziownia2DataSet2
    Friend WithEvents NarzedziaBindingSource As BindingSource
    Friend WithEvents NarzedziaTableAdapter As Narzedziownia2DataSet2TableAdapters.narzedziaTableAdapter
    Friend WithEvents Narzedziownia2DataSet3 As Narzedziownia2DataSet3
    Friend WithEvents UzytkownicyTableAdapter As Narzedziownia2DataSet3TableAdapters.uzytkownicyTableAdapter
    Friend WithEvents UzytkownicyBindingSource1 As BindingSource
    Friend WithEvents Narzedziownia2DataSet4 As Narzedziownia2DataSet4
    Friend WithEvents SerwisTableAdapter As Narzedziownia2DataSet4TableAdapters.serwisTableAdapter
    Friend WithEvents Narzedziownia2DataSet5 As Narzedziownia2DataSet5
    Friend WithEvents SerwisTableAdapter1 As Narzedziownia2DataSet5TableAdapters.serwisTableAdapter

    Friend WithEvents PracownikBinding As BindingSource
    '    Friend WithEvents NarzedziaBinding As BindingSource
    Friend WithEvents DostawcaBinding As BindingSource
    Friend WithEvents FakturaSerwisMenu As ToolStripMenuItem
    Friend WithEvents DodajNarzedzieMenu As ToolStripMenuItem
    Friend WithEvents EdytujNarzedzieMenu As ToolStripMenuItem
    Friend WithEvents TypNarzędziaToolStripMenu As ToolStripMenuItem
    Friend WithEvents DodajPracownikMenu As ToolStripMenuItem
    Friend WithEvents EdytujPracownikMenu As ToolStripMenuItem
    Friend WithEvents DodajToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EdytujSerwisMenu As ToolStripMenuItem
    Friend WithEvents DodajSerwisMenu As ToolStripMenuItem
    Friend WithEvents DostawcaDodajMenu As ToolStripMenuItem
    Friend WithEvents EdytujDostawceMenu As ToolStripMenuItem
    Friend WithEvents DodajFaktureSerwisMenu As ToolStripMenuItem
    Friend WithEvents EdytujFaktureSerwisMenu As ToolStripMenuItem
    Friend WithEvents DodajTypNarzedziaMenu As ToolStripMenuItem
    Friend WithEvents EdytujTypNarzedziaMenu As ToolStripMenuItem
    Friend WithEvents Narzedziownia2DataSet6 As Narzedziownia2DataSet6
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TypNarzedziaTableAdapter As Narzedziownia2DataSet6TableAdapters.TypNarzedziaTableAdapter
    Friend WithEvents Narzedziownia2DataSet7 As Narzedziownia2DataSet7
    Friend WithEvents DostawcaTableAdapter1 As Narzedziownia2DataSet7TableAdapters.DostawcaTableAdapter
    Friend WithEvents Edytuj As TabPage
    Friend WithEvents EdytujTabela As ADGV.AdvancedDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxLvlDostępEdytuj As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents WybierzKolumne As ComboBox
    Friend WithEvents TabelaWybierz As ComboBox
    Friend WithEvents LicznikEdytuj As Label
    Friend WithEvents EdytowanaWartosc As TextBox
    Friend WithEvents ZmienBtn As Button
    Friend WithEvents ErrLblEdit As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents TypNarzedzia As TabPage
    Friend WithEvents TypNarzedziaTabela As ADGV.AdvancedDataGridView
    Friend WithEvents TypNarzedziaPanel As Panel
    Friend WithEvents LicznikTypNarzedzia As Label
    Friend WithEvents TypNarzedziaTxt As TextBox
    Friend WithEvents TypNarzedziaBTN As Button
    Friend WithEvents ErrLabelTypNarzedzia As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents DodajFaktureSerwis As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabelaDodajFaktureSerwis As ADGV.AdvancedDataGridView
    Friend WithEvents PanelDodajFaktureSerwis As Panel
    Friend WithEvents LicznikFakturySerwis As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DodajFaktureSerwisFormaPłatności As ComboBox
    Friend WithEvents DodajFaktureSerwisDataPłatności As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents DodajFaktureSerwisBtn As Button
    Friend WithEvents ErrLabelFakturaSerwis As Label
    Friend WithEvents DodajFaktureSerwisDataFaktury As DateTimePicker
    Friend WithEvents Label37 As Label
    Friend WithEvents DodajFaktureSerwisWybierzDostawce As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents DodajFaktureSerwisNrFaktury As TextBox
    Friend WithEvents DodajFakture As TabPage
    Friend WithEvents TabelaDodajFakture As ADGV.AdvancedDataGridView
    Friend WithEvents PanelDodajFakture As Panel
    Friend WithEvents LicznikFaktury As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DodajFaktureFormaPłatności As ComboBox
    Friend WithEvents DodajFaktureDataPłatności As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents DodajFaktureBtn As Button
    Friend WithEvents ErrLabelFaktura As Label
    Friend WithEvents DodajFaktureDataFaktury As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents DodajFaktureWybierzDostawce As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DodajFaktureNrFaktury As TextBox
    Friend WithEvents HistoriaNarzędzia As TabPage
    Friend WithEvents DodajDostawce As TabPage
    Friend WithEvents TabelaDodajDostawce As ADGV.AdvancedDataGridView
    Friend WithEvents PanelDostawca As Panel
    Friend WithEvents LicznikDostawca As Label
    Friend WithEvents DostawcaKodPocztowy As TextBox
    Friend WithEvents DostawcaNip As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DostawcaMiasto As TextBox
    Friend WithEvents DostawcaNazwa As TextBox
    Friend WithEvents DodajDostawceBtn As Button
    Friend WithEvents ErrLabelDostawca As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DostawcaAdres As TextBox
    Friend WithEvents DostawcaOpiekun As TextBox
    Friend WithEvents DostawcaMail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DostawcaTelefon As TextBox
    Friend WithEvents PowrótZserwisu As TabPage
    Friend WithEvents OddajNaSerwis As TabPage
    Friend WithEvents StanMagazynu As TabPage
    Friend WithEvents DodajSerwis As TabPage
    Friend WithEvents TabelaDodajSerwis As ADGV.AdvancedDataGridView
    Friend WithEvents PanelDodajSerwis As Panel
    Friend WithEvents LicznikDodajSerwis As Label
    Friend WithEvents DodajSerwisKodPocztowy As TextBox
    Friend WithEvents DodajSerwisNIP As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DodajSerwisMiasto As TextBox
    Friend WithEvents DodajSerwisNazwa As TextBox
    Friend WithEvents DodajSerwisDodaj As Button
    Friend WithEvents ErrLabelDodajSerwis As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents DodajSerwisAdres As TextBox
    Friend WithEvents DodajSerwisOpiekun As TextBox
    Friend WithEvents DodajSerwisMail As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents DodajSerwisTelefon As TextBox
    Friend WithEvents DodajPracownika As TabPage
    Friend WithEvents TabelaDodajPracownika As ADGV.AdvancedDataGridView
    Friend WithEvents PanelDodajPracownika As Panel
    Friend WithEvents DodajPracownikaImie As TextBox
    Friend WithEvents LicznikDodajPracownika As Label
    Friend WithEvents DodajPracownikLvlDostep As ComboBox
    Friend WithEvents DodajPracownikaBtn As Button
    Friend WithEvents ErrLabelPracownik As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents DodajPracownikaHaslo As TextBox
    Friend WithEvents DodajPracownikaLogin As TextBox
    Friend WithEvents DodajPracownikaMail As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents DodajPracownikaNazwisko As TextBox
    Friend WithEvents DodajNarzędzie As TabPage
    Friend WithEvents TabelaDodajNarzędzie As ADGV.AdvancedDataGridView
    Friend WithEvents PanelNarzędzie As Panel
    Friend WithEvents DodajNarzędzieTyp As ComboBox
    Friend WithEvents LicznikNarzędzia As Label
    Friend WithEvents DodajNarzędzieBtn As Button
    Friend WithEvents ErrLabelNarzędzie As Label
    Friend WithEvents DodajNarzędzieGwarancja As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DodajNarzędzieWybierzFakture As ComboBox
    Friend WithEvents DodajNarzędzieCena As TextBox
    Friend WithEvents DodajNarzędzieNumerSeryjny As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DodajNarzędzieModel As TextBox
    Friend WithEvents MojeWypożyczenia As TabPage
    Friend WithEvents TabelaMojeWypo As ADGV.AdvancedDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChckFiltrPracownika As CheckBox
    Friend WithEvents IdPracownikaMojeWypo As ComboBox
    Friend WithEvents LicznikMojeWypo As Label
    Friend WithEvents WybierzWypo As Button
    Friend WithEvents ErrLabelMojeWypożyczenia As Label
    Friend WithEvents IdPracownikaMojeWypoLabel As Label
    Friend WithEvents ZwróćTab As TabPage
    Friend WithEvents ZwróćTabela As ADGV.AdvancedDataGridView
    Friend WithEvents ZwróćPanel As Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents UwagiZwróć As TextBox
    Friend WithEvents IdNarzędziaZwróć As ComboBox
    Friend WithEvents LicznikZwróc As Label
    Friend WithEvents ZwróćBtn As Button
    Friend WithEvents ErrLabelZwróc As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents WypożyczTab As TabPage
    Friend WithEvents WypożyczTabela As ADGV.AdvancedDataGridView
    Friend WithEvents WypożyczPanel As Panel
    Friend WithEvents UwagiLblWypożycz As Label
    Friend WithEvents UwagiWypożycz As TextBox
    Friend WithEvents IdNarzedziaWypożycz As ComboBox
    Friend WithEvents LicznikWypożycz As Label
    Friend WithEvents WypożyczBtn As Button
    Friend WithEvents ErrLblWypożycz As Label
    Friend WithEvents IDPracownikaWypożyczLbl As Label
    Friend WithEvents IdPracownikaWypozycz As ComboBox
    Friend WithEvents IdNarzedziaWypożyczLbl As Label
    Friend WithEvents TabControl As TabControl
End Class
