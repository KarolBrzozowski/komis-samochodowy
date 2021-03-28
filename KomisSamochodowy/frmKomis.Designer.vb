<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKomis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KomisSamochodowy1DataSet = New KomisSamochodowy.KomisSamochodowy1DataSet
        Me.ProduktyTableAdapter = New KomisSamochodowy.KomisSamochodowy1DataSetTableAdapters.ProduktyTableAdapter
        Me.txtID = New System.Windows.Forms.Label
        Me.txtKategoria = New System.Windows.Forms.Label
        Me.txtMarka = New System.Windows.Forms.Label
        Me.txtTyp = New System.Windows.Forms.Label
        Me.txtWersja = New System.Windows.Forms.Label
        Me.txtKolor = New System.Windows.Forms.Label
        Me.txtRocznik = New System.Windows.Forms.Label
        Me.txtPrzebieg = New System.Windows.Forms.Label
        Me.txtSilnik = New System.Windows.Forms.Label
        Me.txtInstalacjaLPG = New System.Windows.Forms.Label
        Me.txtCena = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.btnNastepnyLewo = New System.Windows.Forms.Button
        Me.btnNastepnyPrawo = New System.Windows.Forms.Button
        Me.btnPoczatekListy = New System.Windows.Forms.Button
        Me.btnKoniecListy = New System.Windows.Forms.Button
        Me.LblRekord = New System.Windows.Forms.Label
        Me.lblJleRekordow = New System.Windows.Forms.Label
        Me.txtNrRekordu = New System.Windows.Forms.TextBox
        Me.txtLiczbaRekordow = New System.Windows.Forms.TextBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnKomis2 = New System.Windows.Forms.Button
        Me.btnKomisNr1 = New System.Windows.Forms.Button
        Me.btnKomis3 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KomisSamochodowy1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Produkty"
        Me.BindingSource1.DataSource = Me.KomisSamochodowy1DataSet
        '
        'KomisSamochodowy1DataSet
        '
        Me.KomisSamochodowy1DataSet.DataSetName = "KomisSamochodowy1DataSet"
        Me.KomisSamochodowy1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduktyTableAdapter
        '
        Me.ProduktyTableAdapter.ClearBeforeFill = True
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(1, 46)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtID.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtID.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(150, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.Text = "ID produktu"
        Me.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKategoria
        '
        Me.txtKategoria.AutoSize = True
        Me.txtKategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKategoria.Location = New System.Drawing.Point(1, 66)
        Me.txtKategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtKategoria.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtKategoria.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtKategoria.Name = "txtKategoria"
        Me.txtKategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtKategoria.Size = New System.Drawing.Size(150, 20)
        Me.txtKategoria.TabIndex = 1
        Me.txtKategoria.Text = "Kategoria Pojazdu"
        Me.txtKategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMarka
        '
        Me.txtMarka.AutoSize = True
        Me.txtMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarka.Location = New System.Drawing.Point(1, 86)
        Me.txtMarka.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtMarka.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtMarka.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtMarka.Name = "txtMarka"
        Me.txtMarka.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMarka.Size = New System.Drawing.Size(150, 20)
        Me.txtMarka.TabIndex = 2
        Me.txtMarka.Text = "Marka Pojazdu"
        Me.txtMarka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTyp
        '
        Me.txtTyp.AutoSize = True
        Me.txtTyp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTyp.Location = New System.Drawing.Point(1, 106)
        Me.txtTyp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTyp.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtTyp.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtTyp.Name = "txtTyp"
        Me.txtTyp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTyp.Size = New System.Drawing.Size(150, 20)
        Me.txtTyp.TabIndex = 3
        Me.txtTyp.Text = "Typ Pojazdu"
        Me.txtTyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWersja
        '
        Me.txtWersja.AutoSize = True
        Me.txtWersja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWersja.Location = New System.Drawing.Point(1, 126)
        Me.txtWersja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtWersja.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtWersja.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtWersja.Name = "txtWersja"
        Me.txtWersja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWersja.Size = New System.Drawing.Size(150, 20)
        Me.txtWersja.TabIndex = 4
        Me.txtWersja.Text = "Wersja"
        Me.txtWersja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKolor
        '
        Me.txtKolor.AutoSize = True
        Me.txtKolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKolor.Location = New System.Drawing.Point(1, 146)
        Me.txtKolor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtKolor.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtKolor.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtKolor.Name = "txtKolor"
        Me.txtKolor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtKolor.Size = New System.Drawing.Size(150, 20)
        Me.txtKolor.TabIndex = 5
        Me.txtKolor.Text = "Kolor"
        Me.txtKolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRocznik
        '
        Me.txtRocznik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRocznik.Location = New System.Drawing.Point(1, 166)
        Me.txtRocznik.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtRocznik.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtRocznik.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtRocznik.Name = "txtRocznik"
        Me.txtRocznik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRocznik.Size = New System.Drawing.Size(150, 20)
        Me.txtRocznik.TabIndex = 6
        Me.txtRocznik.Text = "Rocznik"
        Me.txtRocznik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrzebieg
        '
        Me.txtPrzebieg.AutoSize = True
        Me.txtPrzebieg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrzebieg.Location = New System.Drawing.Point(1, 186)
        Me.txtPrzebieg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtPrzebieg.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtPrzebieg.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtPrzebieg.Name = "txtPrzebieg"
        Me.txtPrzebieg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrzebieg.Size = New System.Drawing.Size(150, 20)
        Me.txtPrzebieg.TabIndex = 7
        Me.txtPrzebieg.Text = "Przebieg"
        Me.txtPrzebieg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSilnik
        '
        Me.txtSilnik.AutoSize = True
        Me.txtSilnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSilnik.Location = New System.Drawing.Point(1, 206)
        Me.txtSilnik.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtSilnik.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtSilnik.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtSilnik.Name = "txtSilnik"
        Me.txtSilnik.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSilnik.Size = New System.Drawing.Size(150, 20)
        Me.txtSilnik.TabIndex = 8
        Me.txtSilnik.Text = "Silnik"
        Me.txtSilnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInstalacjaLPG
        '
        Me.txtInstalacjaLPG.AutoSize = True
        Me.txtInstalacjaLPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstalacjaLPG.Location = New System.Drawing.Point(1, 226)
        Me.txtInstalacjaLPG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInstalacjaLPG.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtInstalacjaLPG.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtInstalacjaLPG.Name = "txtInstalacjaLPG"
        Me.txtInstalacjaLPG.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInstalacjaLPG.Size = New System.Drawing.Size(150, 20)
        Me.txtInstalacjaLPG.TabIndex = 9
        Me.txtInstalacjaLPG.Text = "InstalacjaLPG"
        Me.txtInstalacjaLPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCena
        '
        Me.txtCena.AutoSize = True
        Me.txtCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCena.Location = New System.Drawing.Point(1, 246)
        Me.txtCena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtCena.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtCena.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtCena.Name = "txtCena"
        Me.txtCena.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCena.Size = New System.Drawing.Size(150, 20)
        Me.txtCena.TabIndex = 10
        Me.txtCena.Text = "Cena"
        Me.txtCena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = True
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStatus.Location = New System.Drawing.Point(1, 266)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtStatus.MaximumSize = New System.Drawing.Size(150, 20)
        Me.txtStatus.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStatus.Size = New System.Drawing.Size(150, 20)
        Me.txtStatus.TabIndex = 11
        Me.txtStatus.Text = "Status"
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "IDproduktu", True))
        Me.TextBox1.Location = New System.Drawing.Point(149, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 22)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "KategoriaPojazdu", True))
        Me.TextBox2.Location = New System.Drawing.Point(149, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "MarkaPojazdu", True))
        Me.TextBox3.Location = New System.Drawing.Point(149, 86)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(159, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "TypPojazdu", True))
        Me.TextBox4.Location = New System.Drawing.Point(149, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(159, 22)
        Me.TextBox4.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Wersja", True))
        Me.TextBox5.Location = New System.Drawing.Point(149, 126)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(159, 22)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Kolor", True))
        Me.TextBox6.Location = New System.Drawing.Point(149, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(159, 22)
        Me.TextBox6.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Rocznik", True))
        Me.TextBox7.Location = New System.Drawing.Point(149, 165)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(159, 22)
        Me.TextBox7.TabIndex = 18
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Przebieg", True))
        Me.TextBox8.Location = New System.Drawing.Point(149, 186)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(159, 22)
        Me.TextBox8.TabIndex = 19
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Silnik", True))
        Me.TextBox9.Location = New System.Drawing.Point(149, 206)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(159, 22)
        Me.TextBox9.TabIndex = 20
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "InstalacjaLPG", True))
        Me.TextBox10.Location = New System.Drawing.Point(149, 224)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(159, 22)
        Me.TextBox10.TabIndex = 21
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Cena", True))
        Me.TextBox11.Location = New System.Drawing.Point(149, 244)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(159, 22)
        Me.TextBox11.TabIndex = 22
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Status", True))
        Me.TextBox12.Location = New System.Drawing.Point(149, 264)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(159, 22)
        Me.TextBox12.TabIndex = 23
        '
        'btnNastepnyLewo
        '
        Me.btnNastepnyLewo.Location = New System.Drawing.Point(94, 324)
        Me.btnNastepnyLewo.Name = "btnNastepnyLewo"
        Me.btnNastepnyLewo.Size = New System.Drawing.Size(57, 28)
        Me.btnNastepnyLewo.TabIndex = 24
        Me.btnNastepnyLewo.Text = "<"
        Me.btnNastepnyLewo.UseVisualStyleBackColor = True
        '
        'btnNastepnyPrawo
        '
        Me.btnNastepnyPrawo.Location = New System.Drawing.Point(163, 324)
        Me.btnNastepnyPrawo.Name = "btnNastepnyPrawo"
        Me.btnNastepnyPrawo.Size = New System.Drawing.Size(60, 28)
        Me.btnNastepnyPrawo.TabIndex = 25
        Me.btnNastepnyPrawo.Text = ">"
        Me.btnNastepnyPrawo.UseVisualStyleBackColor = True
        '
        'btnPoczatekListy
        '
        Me.btnPoczatekListy.Location = New System.Drawing.Point(3, 325)
        Me.btnPoczatekListy.Name = "btnPoczatekListy"
        Me.btnPoczatekListy.Size = New System.Drawing.Size(75, 28)
        Me.btnPoczatekListy.TabIndex = 26
        Me.btnPoczatekListy.Text = "<<"
        Me.btnPoczatekListy.UseVisualStyleBackColor = True
        '
        'btnKoniecListy
        '
        Me.btnKoniecListy.Location = New System.Drawing.Point(238, 325)
        Me.btnKoniecListy.Name = "btnKoniecListy"
        Me.btnKoniecListy.Size = New System.Drawing.Size(70, 26)
        Me.btnKoniecListy.TabIndex = 27
        Me.btnKoniecListy.Text = ">>"
        Me.btnKoniecListy.UseVisualStyleBackColor = True
        '
        'LblRekord
        '
        Me.LblRekord.AutoSize = True
        Me.LblRekord.Location = New System.Drawing.Point(9, 300)
        Me.LblRekord.Name = "LblRekord"
        Me.LblRekord.Size = New System.Drawing.Size(53, 16)
        Me.LblRekord.TabIndex = 28
        Me.LblRekord.Text = "Rekord"
        '
        'lblJleRekordow
        '
        Me.lblJleRekordow.AutoSize = True
        Me.lblJleRekordow.Location = New System.Drawing.Point(149, 300)
        Me.lblJleRekordow.Name = "lblJleRekordow"
        Me.lblJleRekordow.Size = New System.Drawing.Size(17, 16)
        Me.lblJleRekordow.TabIndex = 29
        Me.lblJleRekordow.Text = "z "
        '
        'txtNrRekordu
        '
        Me.txtNrRekordu.Location = New System.Drawing.Point(71, 297)
        Me.txtNrRekordu.Name = "txtNrRekordu"
        Me.txtNrRekordu.Size = New System.Drawing.Size(58, 22)
        Me.txtNrRekordu.TabIndex = 30
        '
        'txtLiczbaRekordow
        '
        Me.txtLiczbaRekordow.Location = New System.Drawing.Point(172, 297)
        Me.txtLiczbaRekordow.Name = "txtLiczbaRekordow"
        Me.txtLiczbaRekordow.Size = New System.Drawing.Size(51, 22)
        Me.txtLiczbaRekordow.TabIndex = 31
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(3, 367)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 27)
        Me.btnEdit.TabIndex = 32
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(163, 368)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 27)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(94, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(53, 27)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(238, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 27)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnKomis2
        '
        Me.btnKomis2.Location = New System.Drawing.Point(536, 106)
        Me.btnKomis2.Name = "btnKomis2"
        Me.btnKomis2.Size = New System.Drawing.Size(176, 32)
        Me.btnKomis2.TabIndex = 37
        Me.btnKomis2.Text = "Komis Samochodowy Nr2"
        Me.btnKomis2.UseVisualStyleBackColor = True
        '
        'btnKomisNr1
        '
        Me.btnKomisNr1.Location = New System.Drawing.Point(533, 50)
        Me.btnKomisNr1.Name = "btnKomisNr1"
        Me.btnKomisNr1.Size = New System.Drawing.Size(179, 36)
        Me.btnKomisNr1.TabIndex = 38
        Me.btnKomisNr1.Text = "Konis Samochodowy Nr1"
        Me.btnKomisNr1.UseVisualStyleBackColor = True
        '
        'btnKomis3
        '
        Me.btnKomis3.Location = New System.Drawing.Point(536, 151)
        Me.btnKomis3.Name = "btnKomis3"
        Me.btnKomis3.Size = New System.Drawing.Size(176, 36)
        Me.btnKomis3.TabIndex = 39
        Me.btnKomis3.Text = "Komis Samochodowy Nr3"
        Me.btnKomis3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(462, 244)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 150)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(462, 224)
        Me.Label1.MinimumSize = New System.Drawing.Size(250, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 20)
        Me.Label1.TabIndex = 41
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Kolor do wyboru", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ListBox1.Location = New System.Drawing.Point(321, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(135, 180)
        Me.ListBox1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 28)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "KONIEC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmKomis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 406)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKomis3)
        Me.Controls.Add(Me.btnKomisNr1)
        Me.Controls.Add(Me.btnKomis2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtLiczbaRekordow)
        Me.Controls.Add(Me.txtNrRekordu)
        Me.Controls.Add(Me.lblJleRekordow)
        Me.Controls.Add(Me.LblRekord)
        Me.Controls.Add(Me.btnKoniecListy)
        Me.Controls.Add(Me.btnPoczatekListy)
        Me.Controls.Add(Me.btnNastepnyPrawo)
        Me.Controls.Add(Me.btnNastepnyLewo)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtCena)
        Me.Controls.Add(Me.txtInstalacjaLPG)
        Me.Controls.Add(Me.txtSilnik)
        Me.Controls.Add(Me.txtPrzebieg)
        Me.Controls.Add(Me.txtRocznik)
        Me.Controls.Add(Me.txtKolor)
        Me.Controls.Add(Me.txtWersja)
        Me.Controls.Add(Me.txtTyp)
        Me.Controls.Add(Me.txtMarka)
        Me.Controls.Add(Me.txtKategoria)
        Me.Controls.Add(Me.txtID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKomis"
        Me.Text = "KOMIS SAMOCHODOWY"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KomisSamochodowy1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KomisSamochodowy1DataSet As KomisSamochodowy.KomisSamochodowy1DataSet
    Friend WithEvents ProduktyTableAdapter As KomisSamochodowy.KomisSamochodowy1DataSetTableAdapters.ProduktyTableAdapter
    Friend WithEvents txtID As System.Windows.Forms.Label
    Friend WithEvents txtKategoria As System.Windows.Forms.Label
    Friend WithEvents txtMarka As System.Windows.Forms.Label
    Friend WithEvents txtTyp As System.Windows.Forms.Label
    Friend WithEvents txtWersja As System.Windows.Forms.Label
    Friend WithEvents txtKolor As System.Windows.Forms.Label
    Friend WithEvents txtRocznik As System.Windows.Forms.Label
    Friend WithEvents txtPrzebieg As System.Windows.Forms.Label
    Friend WithEvents txtSilnik As System.Windows.Forms.Label
    Friend WithEvents txtInstalacjaLPG As System.Windows.Forms.Label
    Friend WithEvents txtCena As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents btnNastepnyLewo As System.Windows.Forms.Button
    Friend WithEvents btnNastepnyPrawo As System.Windows.Forms.Button
    Friend WithEvents btnPoczatekListy As System.Windows.Forms.Button
    Friend WithEvents btnKoniecListy As System.Windows.Forms.Button
    Friend WithEvents LblRekord As System.Windows.Forms.Label
    Friend WithEvents lblJleRekordow As System.Windows.Forms.Label
    Friend WithEvents txtNrRekordu As System.Windows.Forms.TextBox
    Friend WithEvents txtLiczbaRekordow As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnKomis2 As System.Windows.Forms.Button
    Friend WithEvents btnKomisNr1 As System.Windows.Forms.Button
    Friend WithEvents btnKomis3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
