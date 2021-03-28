Public Class frmKomis

    Dim inc As Integer
    Dim maxRows As Integer
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim nrKomisu As String
    Dim frmKomis As System.Drawing.Graphics
    Dim TabObraz(10) As Bitmap

    Sub WybierzRekord(ByVal inc)
        TextBox1.Text = ds.Tables(nrKomisu).Rows(inc).Item(0)
        TextBox2.Text = ds.Tables(nrKomisu).Rows(inc).Item(1)
        TextBox3.Text = ds.Tables(nrKomisu).Rows(inc).Item(2)
        TextBox4.Text = ds.Tables(nrKomisu).Rows(inc).Item(3)
        TextBox5.Text = ds.Tables(nrKomisu).Rows(inc).Item(4)
        TextBox6.Text = ds.Tables(nrKomisu).Rows(inc).Item(5)
        TextBox7.Text = ds.Tables(nrKomisu).Rows(inc).Item(6)
        TextBox8.Text = ds.Tables(nrKomisu).Rows(inc).Item(7)
        TextBox9.Text = ds.Tables(nrKomisu).Rows(inc).Item(8)
        TextBox10.Text = ds.Tables(nrKomisu).Rows(inc).Item(9)
        TextBox11.Text = ds.Tables(nrKomisu).Rows(inc).Item(10)
        TextBox12.Text = ds.Tables(nrKomisu).Rows(inc).Item(11)
    End Sub
    Sub Blokada()
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        btnEdit.Enabled = True
        btnKoniecListy.Enabled = True
        btnNastepnyLewo.Enabled = True
        btnNastepnyPrawo.Enabled = True
        btnPoczatekListy.Enabled = True
        btnSave.Enabled = False
        btnAdd.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Sub WybierzKolor()
        If TextBox6.Text = "metalik" Then
            PictureBox1.Image = CType(TabObraz(0), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "biały" Then
            PictureBox1.Image = CType(TabObraz(1), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "czerwony" Then
            PictureBox1.Image = CType(TabObraz(2), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "żółty" Then
            PictureBox1.Image = CType(TabObraz(3), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "pomarańcz" Then
            PictureBox1.Image = CType(TabObraz(4), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "brązowy" Then
            PictureBox1.Image = CType(TabObraz(5), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "zielony" Then
            PictureBox1.Image = CType(TabObraz(6), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "niebieski" Then
            PictureBox1.Image = CType(TabObraz(7), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "czarny" Then
            PictureBox1.Image = CType(TabObraz(8), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "granatowy" Then
            PictureBox1.Image = CType(TabObraz(9), System.Drawing.Bitmap)
        End If

        If TextBox6.Text = "" Then
            PictureBox1.Image = CType(TabObraz(10), System.Drawing.Bitmap)
        End If

    End Sub

    Private Sub frmKomis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Blokada()

        TabObraz(0) = New Bitmap("Modele\metalik.jpg")
        TabObraz(1) = New Bitmap("Modele\biały.jpg")
        TabObraz(2) = New Bitmap("Modele\czerwony.jpg")
        TabObraz(3) = New Bitmap("Modele\żółty.jpg")
        TabObraz(4) = New Bitmap("Modele\pomarańcz.jpg")
        TabObraz(5) = New Bitmap("Modele\brązowy.jpg")
        TabObraz(6) = New Bitmap("Modele\zielony.jpg")
        TabObraz(7) = New Bitmap("Modele\niebieski.jpg")
        TabObraz(8) = New Bitmap("Modele\czarny.jpg")
        TabObraz(9) = New Bitmap("Modele\granatowy.jpg")
        TabObraz(10) = New Bitmap("Modele\bezKoloru.jpg")

        ListBox1.Items(1) = "metalik"
        ListBox1.Items(2) = "biały"
        ListBox1.Items(3) = "czerwony"
        ListBox1.Items(4) = "żółty"
        ListBox1.Items(5) = "pomarańcz"
        ListBox1.Items(6) = "brązowy"
        ListBox1.Items(7) = "zielony"
        ListBox1.Items(8) = "niebieski"
        ListBox1.Items(9) = "czarny"
        ListBox1.Items(10) = "granatowy"
        ListBox1.Items(11) = ""
        ListBox1.Items(12) = ""

    End Sub

    Private Sub btnKomisNr1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKomisNr1.Click
        nrKomisu = "KomisSamochodowy1"
        Blokada()
        'Połączenie z bazą
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & nrKomisu & ".mdb"
        'con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=C:\KB\KomisSamochodowy\bin\Debug\" & nrKomisu & ".mdb"
        con.Open()
        sql = "SELECT * FROM Produkty"
        da = New OleDb.OleDbDataAdapter(sql, con)
        MsgBox(" połączenie z baza jest otwarte")
        da.Fill(ds, nrKomisu)

        WybierzRekord(0)
        con.Close()
        MsgBox(" połączenie z baza jest zamkniete")

        maxRows = ds.Tables(nrKomisu).Rows.Count
        inc = -1
        PictureBox1.Image = CType(TabObraz(10), System.Drawing.Bitmap)

        Label1.Text = "Wybrano Komis Samochodowy Nr 1"
        
    End Sub

    Private Sub btnKomis2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKomis2.Click
        nrKomisu = "KomisSamochodowy2"
        Blokada()
        'Połączenie z bazą
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & nrKomisu & ".mdb"
        'con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=C:\KB\KomisSamochodowy\bin\Debug\" & nrKomisu & ".mdb"
        con.Open()
        sql = "SELECT * FROM Produkty"
        da = New OleDb.OleDbDataAdapter(sql, con)
        MsgBox(" połączenie z baza jest otwarte")
        da.Fill(ds, nrKomisu)

        WybierzRekord(0)
        con.Close()
        MsgBox(" połączenie z baza jest zamkniete")

        maxRows = ds.Tables(nrKomisu).Rows.Count
        inc = -1
        PictureBox1.Image = CType(TabObraz(10), System.Drawing.Bitmap)
        
        Label1.Text = "Wybrano Komis Samochodowy Nr 2"
    End Sub

    Private Sub btnKomis3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKomis3.Click
        nrKomisu = "KomisSamochodowy3"
        Blokada()
        'Połączenie z bazą
        con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & nrKomisu & ".mdb"
        'con.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=C:\KB\KomisSamochodowy\bin\Debug\" & nrKomisu & ".mdb"
        con.Open()
        sql = "SELECT * FROM Produkty"
        da = New OleDb.OleDbDataAdapter(sql, con)
        MsgBox(" połączenie z baza jest otwarte")
        da.Fill(ds, nrKomisu)

        WybierzRekord(0)
        con.Close()
        MsgBox(" połączenie z baza jest zamkniete")

        maxRows = ds.Tables(nrKomisu).Rows.Count
        inc = -1
        PictureBox1.Image = CType(TabObraz(10), System.Drawing.Bitmap)

        Label1.Text = "Wybrano Komis Samochodowy Nr 3"
    End Sub

    Private Sub btnNastepnyPrawo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastepnyPrawo.Click
        'przewijanie o 1 rekord do przodu
        If inc <> maxRows - 1 Then
            inc = inc + 1
            WybierzRekord(inc)
        Else
            MsgBox("To jest ostatni rekord!")
        End If
        txtNrRekordu.Text = 1 + inc
        txtLiczbaRekordow.Text = Val(maxRows)
        WybierzKolor()
    End Sub

    Private Sub btnNastepnyLewo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNastepnyLewo.Click
        'przewijanie o 1 rekord wstecz
        If inc > 0 Then
            inc = inc - 1
            WybierzRekord(inc)
        ElseIf inc = -1 Then
            MsgBox("To jest pierwszy rekord")
        ElseIf inc = 0 Then
            MsgBox("To jest 1-szy rekord")
        End If
        txtNrRekordu.Text = 1 + inc
        txtLiczbaRekordow.Text = Val(maxRows)
        WybierzKolor()
    End Sub

    Private Sub btnPoczatekListy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoczatekListy.Click
        ' przewijanie na poczatek
        If inc <> 0 Then
            inc = 0
            WybierzRekord(inc)
        End If
        If inc = 0 Then
            MsgBox("Jest poczatek listy")
        End If

        txtNrRekordu.Text = 1 + inc
        txtLiczbaRekordow.Text = Val(maxRows)
        WybierzKolor()
    End Sub

    Private Sub btnKoniecListy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKoniecListy.Click
        'przewijanie do konca
        If inc <> maxRows - 1 Then
            inc = maxRows - 1
            WybierzRekord(inc)
        End If
        If inc = maxRows - 1 Then
            MsgBox("Jest koniec listy")
        End If
        txtNrRekordu.Text = 1 + inc
        txtLiczbaRekordow.Text = Val(maxRows)
        WybierzKolor()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'przygotowanie do edycji

        btnKomisNr1.Enabled = False
        btnKomis2.Enabled = False
        btnKomis3.Enabled = False
        Dim haslo As String
        haslo = InputBox("Podaj hało", "Hasło do edycji", "123", , )
        If haslo = "123" Then
            btnEdit.Enabled = True
            'btnEdit.Enabled = False
            btnKoniecListy.Enabled = False
            btnNastepnyLewo.Enabled = False
            btnNastepnyPrawo.Enabled = False
            btnPoczatekListy.Enabled = False
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox5.ReadOnly = False
            TextBox6.ReadOnly = False
            TextBox7.ReadOnly = False
            TextBox8.ReadOnly = False
            TextBox9.ReadOnly = False
            TextBox10.ReadOnly = False
            TextBox11.ReadOnly = False
            TextBox12.ReadOnly = False
            TextBox1.Focus()
            btnSave.Enabled = True
            btnAdd.Enabled = True
            btnDelete.Enabled = True
        Else
            MsgBox("Hasło nieprawidłowe")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'zapisuje zmiany wprowadzone przez edycje       
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables(nrKomisu).Rows(inc).Item(0) = TextBox1.Text
        ds.Tables(nrKomisu).Rows(inc).Item(1) = TextBox2.Text
        ds.Tables(nrKomisu).Rows(inc).Item(2) = TextBox3.Text
        ds.Tables(nrKomisu).Rows(inc).Item(3) = TextBox4.Text
        ds.Tables(nrKomisu).Rows(inc).Item(4) = TextBox5.Text
        ds.Tables(nrKomisu).Rows(inc).Item(5) = TextBox6.Text
        ds.Tables(nrKomisu).Rows(inc).Item(6) = TextBox7.Text
        ds.Tables(nrKomisu).Rows(inc).Item(7) = TextBox8.Text
        ds.Tables(nrKomisu).Rows(inc).Item(8) = TextBox9.Text
        ds.Tables(nrKomisu).Rows(inc).Item(9) = TextBox10.Text
        ds.Tables(nrKomisu).Rows(inc).Item(10) = TextBox11.Text
        ds.Tables(nrKomisu).Rows(inc).Item(11) = TextBox12.Text
        da.Update(ds, nrKomisu)
        MsgBox("Dane zostały zmienione")
        btnKomisNr1.Enabled = True
        btnKomis2.Enabled = True
        btnKomis3.Enabled = True
        Blokada()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'dodaje nowy rekord

        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim nowyRekord As DataRow   'nowa zmienna
            nowyRekord = ds.Tables(nrKomisu).NewRow()
            maxRows = 1 + maxRows

            nowyRekord.Item(0) = TextBox1.Text
            nowyRekord.Item(1) = TextBox2.Text
            nowyRekord.Item(2) = TextBox3.Text
            nowyRekord.Item(3) = TextBox4.Text
            nowyRekord.Item(4) = TextBox5.Text
            nowyRekord.Item(5) = TextBox6.Text
            nowyRekord.Item(6) = TextBox7.Text
            nowyRekord.Item(7) = TextBox8.Text
            nowyRekord.Item(8) = TextBox9.Text
            nowyRekord.Item(9) = TextBox10.Text
            nowyRekord.Item(10) = TextBox11.Text
            nowyRekord.Item(11) = TextBox12.Text

            ds.Tables(nrKomisu).Rows.Add(nowyRekord)
            da.Update(ds, nrKomisu)

            MsgBox("nowy rekord dodano")

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'usuwa rekord
        Dim pytanie As DialogResult    'nowa zmienna
        pytanie = MsgBox(AcceptButton, MsgBoxStyle.YesNoCancel, "Czy napewno chcesz usunąć ten rekord?")
        If pytanie = Windows.Forms.DialogResult.Yes Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            ds.Tables(nrKomisu).Rows(inc).Delete()
            maxRows = maxRows - 1
            inc = maxRows
        End If
        Blokada()
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        'wybór koloru
        TextBox6.Text = ListBox1.SelectedItem
        WybierzKolor()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'zamyka działanie programu
        End
    End Sub
End Class

