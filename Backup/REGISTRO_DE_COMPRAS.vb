Imports System.Data.SqlClient
Public Class Registro_de_compras
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_PROVEEDOR As System.Windows.Forms.Label
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLSTOCK As System.Windows.Forms.Label
    Friend WithEvents LBLSMAXIMO As System.Windows.Forms.Label
    Friend WithEvents LBLPROD As System.Windows.Forms.Label
    Friend WithEvents LBLPRODUCTO As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents LBLCOMPRA As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DETALLES As System.Windows.Forms.ListView
    Friend WithEvents COMPRA As System.Windows.Forms.ColumnHeader
    Friend WithEvents producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodigopersonal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcod_igv As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbligv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbltotalpagar As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents cbomotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtpunto_partida As System.Windows.Forms.TextBox
    Friend WithEvents dtfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtutilidad As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Registro_de_compras))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblruc = New System.Windows.Forms.Label
        Me.lbltelefono = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LBLCOD_PROVEEDOR = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LBLSTOCK = New System.Windows.Forms.Label
        Me.LBLSMAXIMO = New System.Windows.Forms.Label
        Me.LBLPROD = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LBLPRODUCTO = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXTPRECIO = New System.Windows.Forms.TextBox
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.LBLCOMPRA = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblcod_igv = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.DETALLES = New System.Windows.Forms.ListView
        Me.COMPRA = New System.Windows.Forms.ColumnHeader
        Me.producto = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.cantidad = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lblcodigopersonal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbligv = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTTOTAL = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbltotalpagar = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtpesototal = New System.Windows.Forms.TextBox
        Me.txtpesocarga = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblestado = New System.Windows.Forms.Label
        Me.cbomotivo = New System.Windows.Forms.ComboBox
        Me.txtpunto_partida = New System.Windows.Forms.TextBox
        Me.dtfin = New System.Windows.Forms.DateTimePicker
        Me.dtinicio = New System.Windows.Forms.DateTimePicker
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtutilidad = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.lblruc)
        Me.GroupBox2.Controls.Add(Me.lbltelefono)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LBLCOD_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(208, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 120)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Proveedor"
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.SystemColors.Control
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblruc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblruc.Location = New System.Drawing.Point(312, 56)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(96, 20)
        Me.lblruc.TabIndex = 21
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltelefono
        '
        Me.lbltelefono.BackColor = System.Drawing.SystemColors.Control
        Me.lbltelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltelefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltelefono.Location = New System.Drawing.Point(88, 88)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(64, 20)
        Me.lbltelefono.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(248, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "RUC"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Código"
        '
        'LBLCOD_PROVEEDOR
        '
        Me.LBLCOD_PROVEEDOR.BackColor = System.Drawing.SystemColors.Control
        Me.LBLCOD_PROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCOD_PROVEEDOR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLCOD_PROVEEDOR.Location = New System.Drawing.Point(88, 56)
        Me.LBLCOD_PROVEEDOR.Name = "LBLCOD_PROVEEDOR"
        Me.LBLCOD_PROVEEDOR.Size = New System.Drawing.Size(64, 20)
        Me.LBLCOD_PROVEEDOR.TabIndex = 13
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.BackColor = System.Drawing.SystemColors.Control
        Me.LDAPELLEDIS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(16, 24)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(56, 24)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Proveedor"
        Me.LDAPELLEDIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(88, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(376, 20)
        Me.TXTAPELLIDOS.TabIndex = 1
        Me.TXTAPELLIDOS.Text = ""
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(296, 48)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(536, 72)
        Me.ListView3.TabIndex = 2
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripción"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Ruc"
        Me.ColumnHeader11.Width = 82
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Dirección"
        Me.ColumnHeader12.Width = 218
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LBLSTOCK)
        Me.GroupBox1.Controls.Add(Me.LBLSMAXIMO)
        Me.GroupBox1.Controls.Add(Me.LBLPROD)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(432, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(32, 16)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'LBLSTOCK
        '
        Me.LBLSTOCK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSTOCK.Location = New System.Drawing.Point(488, 56)
        Me.LBLSTOCK.Name = "LBLSTOCK"
        Me.LBLSTOCK.Size = New System.Drawing.Size(24, 16)
        Me.LBLSTOCK.TabIndex = 36
        Me.LBLSTOCK.Visible = False
        '
        'LBLSMAXIMO
        '
        Me.LBLSMAXIMO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSMAXIMO.Location = New System.Drawing.Point(512, 72)
        Me.LBLSMAXIMO.Name = "LBLSMAXIMO"
        Me.LBLSMAXIMO.Size = New System.Drawing.Size(16, 16)
        Me.LBLSMAXIMO.TabIndex = 35
        Me.LBLSMAXIMO.Visible = False
        '
        'LBLPROD
        '
        Me.LBLPROD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLPROD.Location = New System.Drawing.Point(488, 80)
        Me.LBLPROD.Name = "LBLPROD"
        Me.LBLPROD.Size = New System.Drawing.Size(16, 8)
        Me.LBLPROD.TabIndex = 34
        Me.LBLPROD.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 32)
        Me.Label10.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Visible = False
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.Location = New System.Drawing.Point(16, 312)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(48, 24)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.Visible = False
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(312, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 20)
        Me.Label13.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(320, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Marca"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLPRODUCTO
        '
        Me.LBLPRODUCTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLPRODUCTO.Location = New System.Drawing.Point(8, 368)
        Me.LBLPRODUCTO.Name = "LBLPRODUCTO"
        Me.LBLPRODUCTO.Size = New System.Drawing.Size(64, 20)
        Me.LBLPRODUCTO.TabIndex = 33
        Me.LBLPRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(88, 368)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(488, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(32, 16)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(464, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad (Unid.)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(464, 368)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(568, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Importe"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.BackColor = System.Drawing.Color.White
        Me.TXTPRECIO.Location = New System.Drawing.Point(568, 368)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(72, 20)
        Me.TXTPRECIO.TabIndex = 6
        Me.TXTPRECIO.Text = ""
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(728, 368)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNAGREGAR.TabIndex = 7
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(784, 360)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(112, 192)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Grabar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "&Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(16, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(88, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "&Salir"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(728, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TextBox5)
        Me.GroupBox11.Controls.Add(Me.Label15)
        Me.GroupBox11.Controls.Add(Me.Label17)
        Me.GroupBox11.Controls.Add(Me.Label16)
        Me.GroupBox11.Controls.Add(Me.Label25)
        Me.GroupBox11.Controls.Add(Me.TextBox6)
        Me.GroupBox11.Controls.Add(Me.LBLCOMPRA)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(192, 120)
        Me.GroupBox11.TabIndex = 45
        Me.GroupBox11.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(80, 40)
        Me.TextBox5.MaxLength = 11
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.Text = ""
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Factura Nº"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(112, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 24)
        Me.Label17.TabIndex = 4
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 23)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Cmprobante Nº:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label16.Visible = False
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Location = New System.Drawing.Point(112, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 24)
        Me.Label25.TabIndex = 4
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label25.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(80, 40)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(88, 20)
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = ""
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLCOMPRA
        '
        Me.LBLCOMPRA.BackColor = System.Drawing.SystemColors.Control
        Me.LBLCOMPRA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCOMPRA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLCOMPRA.Location = New System.Drawing.Point(80, 80)
        Me.LBLCOMPRA.Name = "LBLCOMPRA"
        Me.LBLCOMPRA.Size = New System.Drawing.Size(96, 24)
        Me.LBLCOMPRA.TabIndex = 37
        Me.LBLCOMPRA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(16, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 23)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Compra"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcod_igv
        '
        Me.lblcod_igv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcod_igv.Location = New System.Drawing.Point(392, 16)
        Me.lblcod_igv.Name = "lblcod_igv"
        Me.lblcod_igv.Size = New System.Drawing.Size(24, 8)
        Me.lblcod_igv.TabIndex = 55
        Me.lblcod_igv.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox10.Location = New System.Drawing.Point(528, 8)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(8, 16)
        Me.GroupBox10.TabIndex = 46
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Datos de la Compra"
        Me.GroupBox10.Visible = False
        '
        'DETALLES
        '
        Me.DETALLES.BackColor = System.Drawing.SystemColors.Menu
        Me.DETALLES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.COMPRA, Me.producto, Me.ColumnHeader3, Me.cantidad, Me.ColumnHeader5, Me.ColumnHeader4})
        Me.DETALLES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DETALLES.FullRowSelect = True
        Me.DETALLES.GridLines = True
        Me.DETALLES.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DETALLES.HideSelection = False
        Me.DETALLES.Location = New System.Drawing.Point(8, 416)
        Me.DETALLES.Name = "DETALLES"
        Me.DETALLES.Size = New System.Drawing.Size(712, 128)
        Me.DETALLES.TabIndex = 25
        Me.DETALLES.View = System.Windows.Forms.View.Details
        '
        'COMPRA
        '
        Me.COMPRA.Text = "Compra"
        Me.COMPRA.Width = 84
        '
        'producto
        '
        Me.producto.Text = "Cod_Producto"
        Me.producto.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Producto"
        Me.ColumnHeader3.Width = 348
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.Width = 78
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Importe"
        Me.ColumnHeader5.Width = 98
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(576, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(144, 552)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(328, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'lblcodigopersonal
        '
        Me.lblcodigopersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigopersonal.Location = New System.Drawing.Point(480, 552)
        Me.lblcodigopersonal.Name = "lblcodigopersonal"
        Me.lblcodigopersonal.Size = New System.Drawing.Size(8, 16)
        Me.lblcodigopersonal.TabIndex = 49
        Me.lblcodigopersonal.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 552)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Compra realizada por"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(88, 392)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(632, 112)
        Me.ListView2.TabIndex = 4
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Código"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Producto"
        Me.ColumnHeader8.Width = 270
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Precio"
        Me.ColumnHeader9.Width = 65
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Marca"
        Me.ColumnHeader10.Width = 238
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Código"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(592, 576)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 24)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "IGV"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbligv
        '
        Me.lbligv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbligv.Location = New System.Drawing.Point(632, 576)
        Me.lbligv.Name = "lbligv"
        Me.lbligv.Size = New System.Drawing.Size(88, 23)
        Me.lbligv.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(560, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Total (S/.)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Enabled = False
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(632, 552)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(88, 20)
        Me.TXTTOTAL.TabIndex = 55
        Me.TXTTOTAL.Text = ""
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(512, 608)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 24)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Total a Pagar"
        '
        'lbltotalpagar
        '
        Me.lbltotalpagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotalpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpagar.Location = New System.Drawing.Point(632, 608)
        Me.lbltotalpagar.Name = "lbltotalpagar"
        Me.lbltotalpagar.Size = New System.Drawing.Size(88, 24)
        Me.lbltotalpagar.TabIndex = 60
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(728, 440)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 61
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtpesototal)
        Me.GroupBox6.Controls.Add(Me.txtpesocarga)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Location = New System.Drawing.Point(456, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(208, 96)
        Me.GroupBox6.TabIndex = 63
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos Adicionales"
        '
        'txtpesototal
        '
        Me.txtpesototal.Location = New System.Drawing.Point(96, 64)
        Me.txtpesototal.Name = "txtpesototal"
        Me.txtpesototal.Size = New System.Drawing.Size(104, 20)
        Me.txtpesototal.TabIndex = 5
        Me.txtpesototal.Text = ""
        '
        'txtpesocarga
        '
        Me.txtpesocarga.Location = New System.Drawing.Point(96, 24)
        Me.txtpesocarga.Name = "txtpesocarga"
        Me.txtpesocarga.Size = New System.Drawing.Size(104, 20)
        Me.txtpesocarga.TabIndex = 3
        Me.txtpesocarga.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(24, 64)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 23)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Peso Total"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(24, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 23)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Peso Carga"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblestado)
        Me.GroupBox4.Controls.Add(Me.cbomotivo)
        Me.GroupBox4.Controls.Add(Me.txtpunto_partida)
        Me.GroupBox4.Controls.Add(Me.dtfin)
        Me.GroupBox4.Controls.Add(Me.dtinicio)
        Me.GroupBox4.Controls.Add(Me.txtnumero)
        Me.GroupBox4.Controls.Add(Me.lblcodigo)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 200)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos de Guia"
        '
        'lblestado
        '
        Me.lblestado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblestado.Location = New System.Drawing.Point(112, 208)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(272, 23)
        Me.lblestado.TabIndex = 14
        Me.lblestado.Text = "Por cancelar"
        Me.lblestado.Visible = False
        '
        'cbomotivo
        '
        Me.cbomotivo.Items.AddRange(New Object() {"Venta", "Compra", "Devolución", "Canje", "Recojo de Bienes", "Traslado de bienes para transformación", "Consignación", "Venta sujeta a confirmación del comprador", "Traslado entre establecimientos de la misma empresa"})
        Me.cbomotivo.Location = New System.Drawing.Point(112, 168)
        Me.cbomotivo.Name = "cbomotivo"
        Me.cbomotivo.Size = New System.Drawing.Size(288, 21)
        Me.cbomotivo.TabIndex = 11
        '
        'txtpunto_partida
        '
        Me.txtpunto_partida.Location = New System.Drawing.Point(112, 128)
        Me.txtpunto_partida.Name = "txtpunto_partida"
        Me.txtpunto_partida.Size = New System.Drawing.Size(280, 20)
        Me.txtpunto_partida.TabIndex = 10
        Me.txtpunto_partida.Text = ""
        '
        'dtfin
        '
        Me.dtfin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtfin.Location = New System.Drawing.Point(304, 96)
        Me.dtfin.Name = "dtfin"
        Me.dtfin.Size = New System.Drawing.Size(88, 20)
        Me.dtfin.TabIndex = 9
        '
        'dtinicio
        '
        Me.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtinicio.Location = New System.Drawing.Point(112, 96)
        Me.dtinicio.Name = "dtinicio"
        Me.dtinicio.Size = New System.Drawing.Size(104, 20)
        Me.dtinicio.TabIndex = 8
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(112, 56)
        Me.txtnumero.MaxLength = 11
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(168, 20)
        Me.txtnumero.TabIndex = 7
        Me.txtnumero.Text = ""
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Location = New System.Drawing.Point(112, 16)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(168, 24)
        Me.lblcodigo.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(16, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Motivo traslado"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(16, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 16)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Punto Partida"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(224, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 16)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Vencimiento"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(16, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 23)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Inicio traslado"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Número"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(16, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Código"
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label28.Location = New System.Drawing.Point(784, 128)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 24)
        Me.Label28.TabIndex = 66
        Me.Label28.Visible = False
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PRECIO_VENTA"
        Me.ColumnHeader4.Width = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(648, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Utilidad (%)"
        '
        'txtutilidad
        '
        Me.txtutilidad.Location = New System.Drawing.Point(656, 368)
        Me.txtutilidad.Name = "txtutilidad"
        Me.txtutilidad.Size = New System.Drawing.Size(56, 20)
        Me.txtutilidad.TabIndex = 68
        Me.txtutilidad.Text = ""
        '
        'Registro_de_compras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(920, 646)
        Me.Controls.Add(Me.txtutilidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.DETALLES)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbligv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lbltotalpagar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblcodigopersonal)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LBLPRODUCTO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTPRECIO)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblcod_igv)
        Me.Name = "Registro_de_compras"
        Me.Text = "Registro de Facturas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub Boletas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTTOTAL.Text = 0
        'Me.TXTAPELLIDOS.Text = ""
        Me.TextBox5.TabIndex = 0
        Me.ListView2.Visible = False
        Me.Button3.Enabled = True
        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
        Me.ListView3.Visible = False
        Me.TextBox3.Text = ""
        Me.ListView3.Visible = False
        'Me.gbfactura.Visible = False
        If Me.Label28.Text = "1" Then
            generarguia()
            cargargrupo()
        Else
            generarguia()
            ocultar()
            GENERAR() ' para compra
            comprobante()
            cargargrupo()
        End If
        
    End Sub
    
    Sub generarguia()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from guia_remision"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.lblcodigo.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub cargargrupo()
        cn.Open()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select pe_apellido+' '+pe_nombre From personal order by pe_apellido", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.ComboBox1.Items.Add(datRead.Item(0))
        End While
        datRead.Close()
        cn.Close()
    End Sub
    Sub ACTUALIZAR()
        Dim I As Integer
        For I = 0 To DETALLES.Items.Count - 1
            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "UPDATE STOCK SET PRO_STOCK = PRO_STOCK + '" + DETALLES.Items(I).SubItems(3).Text + "'  WHERE PRO_CODIGO='" + DETALLES.Items(I).SubItems(1).Text + "'"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
        Next
        Me.DETALLES.Items.Clear()
        Me.Button5.Enabled = True
        Me.Button2.Enabled = False
        Me.TXTTOTAL.Text = ""
        Me.BTNAGREGAR.Enabled = True
        Me.TextBox3.Text = ""
    End Sub
    Sub mostrar()
        Me.Label2.Visible = True
        Me.Label7.Visible = True
        Me.Label8.Visible = True
        Me.lblruc.Visible = True
        Me.lbltelefono.Visible = True
        Me.LBLCOD_PROVEEDOR.Visible = True
    End Sub
    Sub LIMPIAR()
        Me.TXTPRECIO.Text = ""
        Me.TextBox1.Text = ""
        Me.LBLSMAXIMO.Text = ""
        Me.LBLSTOCK.Text = ""
        Me.TextBox3.ResetText()
        Me.LBLPRODUCTO.ResetText()
        Me.Label13.ResetText()
    End Sub
    Sub comprobante()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select max(codigo_comprobante)+1 from Comprobantes"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.Label17.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub GENERAR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from COMPRAS"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLCOMPRA.Text = "C" + CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub igv()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select cod_igv,porcentaje from igv"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.lblcod_igv.Text = CStr(datar(0))
                    Me.lbligv.Text = CStr(datar(1))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub ocultar()
        Me.Label2.Visible = False
        Me.Label7.Visible = False
        Me.Label8.Visible = False
        Me.lblruc.Visible = False
        Me.lbltelefono.Visible = False
        Me.LBLCOD_PROVEEDOR.Visible = False
    End Sub
    Sub LLENARLISTA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT PRO_STOCK FROM STOCK WHERE PRO_CODIGO ='" + Me.LBLPRODUCTO.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.LBLSTOCK.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try

    End Sub

    'Private Sub LISTAPROVEEDOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTAPROVEEDOR.SelectedIndexChanged
    '    If iniciando Then Exit Sub

    '    '     Al hacer clic, mostrar el dato
    '    Me.TXTAPELLIDOS.Text = Me.LISTAPROVEEDOR.SelectedItem.ToString
    '    Me.LBLPROVEEDOR.Text = Me.TXTAPELLIDOS.Text
    '    Try
    '        Dim CONT As Integer
    '        cm.CommandText = "SELECT PV_CODIGO,telefono,celular,ruc FROM proveedor WHERE PV_DESCRIPCION='" + Me.LBLPROVEEDOR.Text + "'"
    '        cm.Connection = cn
    '        cn.Open()
    '        cm.CommandType = CommandType.Text
    '        Dim dr As SqlClient.SqlDataReader
    '        dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    '        If dr.HasRows Then
    '            Do While dr.Read
    '                Me.LBLCOD_PROVEEDOR.Text = dr(0).ToString
    '                Me.lbltelefono.Text = dr(1).ToString
    '                Me.lblcelular.Text = dr(2).ToString
    '                Me.lblruc.Text = dr(3).ToString
    '            Loop
    '        Else
    '            MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    '    Me.LISTAPROVEEDOR.Visible = False
    '    mostrar()
    'End Sub

    Private Sub TXTAPELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDOS.KeyPress
        Me.ListView3.Visible = True
        Try
            Me.ListView3.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT Pv_CODIGO, Pv_DESCRIPCION,ruc,dirección from proveedor WHERE Pv_DESCRIPCION LIKE'%" & TXTAPELLIDOS.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView3.Items.Add(CStr((datar(0))), 1)
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try

    End Sub

    'Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
    '    If INICIANDO1 Then Exit Sub

    '    ' Buscar en el DataTable usando el método Select
    '    ' que es como un filtro WHERE en una cadena de selección.

    '    ' El resultado se devuelve como un array de tipo DataRow
    '    Dim filas() As DataRow

    '    ' Si solo quieres mostrar los que empiecen por lo escrito.
    '    ' Al escribir "s" se buscarán los que empiecen por esa letra.
    '    filas = dt.Select("PRO_DESCRIPCION LIKE '" & TextBox3.Text & "%'")

    '    ' Borrar los elementos anteriores
    '    Me.LISTAPRO.Items.Clear()

    '    ' Si hay datos, mostrar los apellidos
    '    If filas.Length > 0 Then

    '        ' Recorrer cada fila y mostrar los apellidos
    '        For Each dr As DataRow In filas

    '            Me.LISTAPRO.Items.Add( _
    '                        dr("PRO_DESCRIPCION").ToString & ", " & _
    '                        dr("PRO_PRECIO").ToString)
    '        Next
    '    End If

    'End Sub

    'Private Sub LISTAPRO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTAPRO.SelectedIndexChanged
    '    Me.BTNAGREGAR.Enabled = True
    '    If INICIANDO1 Then Exit Sub
    '    '     Al hacer clic, mostrar el dato
    '    Me.TextBox3.Text = Me.LISTAPRO.SelectedItem.ToString
    '    Me.LBLPROD.Text = Mid(Me.TextBox3.Text, 1, InStr(1, Me.TextBox3.Text, ",") - 1)
    '    Try
    '        Dim CONT As Integer
    '        cm.CommandText = "SELECT PRO_CODIGO,pro_unidad FROM PRODUCTO WHERE PRO_DESCRIPCION='" + Me.LBLPROD.Text + "'"
    '        cm.Connection = cn
    '        cn.Open()
    '        cm.CommandType = CommandType.Text
    '        Dim dr As SqlClient.SqlDataReader
    '        dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    '        If dr.HasRows Then
    '            Do While dr.Read
    '                Me.LBLPRODUCTO.Text = dr(0).ToString
    '            Loop
    '        Else
    '            MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    '    LLENARLISTA()
    '    Me.LISTAPRO.Visible = False
    'End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView2.Visible = True
        Try
            Me.ListView2.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PRO_CODIGO, PRO_DESCRIPCION,PRO_PRECIO,M.DESCRIPCION FROM PRODUCTO P INNER JOIN MARCA M ON M.COD_MARCA=P.COD_MARCA WHERE PRO_DESCRIPCION LIKE'%" & TextBox3.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView2.Items.Add(CStr((datar(0))), 1)
                    Me.ListView2.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView2.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView2.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        igv()
        If Me.TXTPRECIO.Text = "" Or Me.TextBox1.Text = "" Or Me.txtutilidad.Text = "" Then
            MsgBox("INGRESE LOS DATOS CORRECTOS", MsgBoxStyle.Exclamation)
            Me.ListView2.Visible = False
        Else
            Dim P As Integer
            Dim BANDERA As Integer
            BANDERA = 0
            For P = 0 To Me.DETALLES.Items.Count - 1
                If Me.Label10.Text = Me.DETALLES.Items(P).SubItems(1).Text Then
                    BANDERA = 1
                Else
                    BANDERA = 0
                End If
            Next
            If BANDERA = 0 Then
                Dim lSingleItem As ListViewItem
                lSingleItem = DETALLES.Items.Add(Me.LBLCOMPRA.Text)
                lSingleItem.SubItems.Add(Me.LBLPRODUCTO.Text)
                lSingleItem.SubItems.Add(Me.TextBox3.Text.Trim + "," + Me.Label13.Text)
                lSingleItem.SubItems.Add(Me.TextBox1.Text)
                lSingleItem.SubItems.Add(Me.TXTPRECIO.Text)
                lSingleItem.SubItems.Add((Val(Me.TXTPRECIO.Text) / Val(Me.TextBox1.Text)) * (1 + (Val(Me.txtutilidad.Text) / 100)))
            Else
                MsgBox("No se permite agregar dos veces el mismo producto", MsgBoxStyle.Critical)
            End If
            Dim i As Integer
            Me.TXTTOTAL.Text = 0
            For i = 0 To Me.DETALLES.Items.Count - 1
                Me.TXTTOTAL.Text = Val(Me.TXTTOTAL.Text) + Val(Me.DETALLES.Items(i).SubItems(4).Text)
            Next
            Me.Button1.Enabled = True
            Me.Button2.Enabled = True
            LIMPIAR()
            funcion()
        End If

    End Sub
    Sub funcion()
        Dim m As Integer
        Dim total As Decimal
        Dim totalpagar As Decimal
        total = 0
        For m = 0 To Me.DETALLES.Items.Count - 1
            total = total + Val(Me.DETALLES.Items(m).SubItems(4).Text)
        Next
        totalpagar = total * Val(Me.lbligv.Text)
        Me.lbltotalpagar.Text = totalpagar + total


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.DETALLES.SelectedItems.Count > 0 Then
            Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
            lista()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub lista()
        Dim j As Integer
        Dim tsf As Double
        Me.TXTTOTAL.Text = 0
        For j = 0 To Me.DETALLES.Items.Count - 1
            Me.TXTTOTAL.Text = Val(Me.TXTTOTAL.Text) + Val(Me.DETALLES.Items(j).SubItems(4).Text)
        Next
        tsf = Val(Me.TXTTOTAL.Text) * Val(Me.lbligv.Text)
        Me.lbltotalpagar.Text = Val(Me.TXTTOTAL.Text) + tsf

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancelar()
        limpiarGUIA()
        generarguia()
    End Sub
    Sub cancelar()
        LIMPIAR()
        ocultar()
        Me.Button1.Enabled = False
        DETALLES.Items.Clear()
        Me.TextBox3.Text = ""
        Me.TXTTOTAL.Text = ""
        Me.TextBox5.ResetText()
        Me.TXTAPELLIDOS.ResetText()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.TextBox5.Text = "" Or Me.DETALLES.Items.Count = 0 Or Me.lblcodigopersonal.Text = "" Then
            MsgBox("Ingrese los datos correctos", MsgBoxStyle.Exclamation)
        Else
            If Me.Label28.Text <> "1" Then
                'GUARDAR EN COMPROBANTE
                Try
                    cn.Open()
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO COMPROBANTES(codigo_COMPROBANTE, fecha, PE_codigo) values ('" + Me.Label17.Text + "','" + Me.DateTimePicker1.Text + "','" + Me.lblcodigopersonal.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
                'guardar en FACTURA
                Try
                    cn.Open()
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO Facturas(codigo_comprobante,codigo_factura,cod_igv ) values ('" + Me.Label17.Text + "','" + Me.TextBox5.Text + "','" + Me.lblcod_igv.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
                'guardar en COMPRA
                Try
                    cn.Open()
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO COMPRAS(C_codigo, C_fecha, PV_codigo,CODIGO_COMPROBANTE,total) values ('" + Me.LBLCOMPRA.Text + "','" + Me.DateTimePicker1.Text + "','" + Me.LBLCOD_PROVEEDOR.Text + "','" + Me.Label17.Text + "','" + Me.lbltotalpagar.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
                'guardar en detalle de COMPRA
                Dim i As Integer
                For i = 0 To DETALLES.Items.Count - 1
                    Try
                        cn.Open()
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "Insert Into detalle_COMPRA (C_CODIGO, pro_codigo, DC_cantidad,importe) values ('" + DETALLES.Items(i).SubItems(0).Text + "','" + DETALLES.Items(i).SubItems(1).Text + "','" + DETALLES.Items(i).SubItems(3).Text + "','" + DETALLES.Items(i).SubItems(4).Text + "')"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                    cn.Close()
                Next
                Me.LBLVENTAS.Text = ""
                Me.Button5.Enabled = False
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
                GUARDARGUIAREMISION()
                actualizarprecio()
                ACTUALIZAR()
                MsgBox("Datos Guardados", MsgBoxStyle.Information)
                GENERAR()
                comprobante()
                cancelar()
                generarguia()
            Else
                'Actualizar monto de la compra
                Try
                    cn.Open()
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "update Compras set total = total + '" + Me.lbltotalpagar.Text + "' where  c_codigo='" + Me.LBLCOMPRA.Text + "'"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
                'guardar en detalle de COMPRA
                Dim i As Integer
                For i = 0 To DETALLES.Items.Count - 1
                    Try
                        cn.Open()
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "Insert Into detalle_COMPRA (C_CODIGO, pro_codigo, DC_cantidad,importe) values ('" + DETALLES.Items(i).SubItems(0).Text + "','" + DETALLES.Items(i).SubItems(1).Text + "','" + DETALLES.Items(i).SubItems(3).Text + "','" + DETALLES.Items(i).SubItems(4).Text + "')"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                    cn.Close()
                Next
                Me.LBLVENTAS.Text = ""
                Me.Button5.Enabled = False
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
                GUARDARGUIAREMISION()
                actualizarprecio()
                ACTUALIZAR()
                MsgBox("Datos Guardados", MsgBoxStyle.Information)
                GENERAR()
                comprobante()
                cancelar()
                generarguia()
            End If
        End If

    End Sub
    Sub GUARDARGUIAREMISION()
        guardarguia()
        limpiarGUIA()
    End Sub
    Sub limpiarGUIA()
        Me.TXTAPELLIDOS.ResetText()
        Me.LBLCOD_PROVEEDOR.ResetText()
        Me.lblruc.ResetText()
        Me.lbltelefono.ResetText()
        Me.lblcodigo.ResetText()
        Me.txtnumero.ResetText()
        Me.txtpunto_partida.ResetText()
        Me.cbomotivo.ResetText()
        Me.lblestado.ResetText()
        Me.txtpesototal.ResetText()
        'Me.txtmonto.ResetText()
        Me.txtpesocarga.ResetText()
    End Sub
    Sub guardarguia()
        Try
            cn.Open()
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "Insert INTO guia_remision(CODIGO_GUIA,NUMERO_GUIA,INICIO_TRASLADO,VENCIMIENTO,PUNTO_PARTIDA,MOTIVO,PESO_CARGA,PESO_TOTAL,C_CODIGO,ESTADO) values ('" + Me.lblcodigo.Text + "','" + Me.txtnumero.Text + "','" + Me.dtinicio.Text + "','" + Me.dtfin.Text + "','" + Me.txtpunto_partida.Text + "','" + Me.cbomotivo.Text + "','" + Me.txtpesocarga.Text + "','" + Me.txtpesototal.Text + "','" + Me.LBLCOMPRA.Text + "','" + Me.lblestado.Text + "')"
            cm.Connection = cn
            a = cm.ExecuteNonQuery()
            If a >= 1 Then
                'MsgBox("Datos Guardados", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Sub actualizarprecio()
        Dim p As Integer
        For p = 0 To Me.DETALLES.Items.Count - 1

            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "update producto set pro_precio=((pro_precio+ '" + Me.DETALLES.Items(p).SubItems(5).Text + "')/2) where pro_codigo='" + Me.DETALLES.Items(p).SubItems(1).Text + "' "
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            cn.Close()
        Next
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cn.Open()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select pe_codigo From personal where pe_apellido+' '+pe_nombre ='" + Me.ComboBox1.Text + "'", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.lblcodigopersonal.Text = datRead(0).ToString
        End While
        cn.Close()
    End Sub
    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        Me.ListView3.Visible = False
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBLCOD_PROVEEDOR.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
        End If
        Try
            Dim CONT As Integer
            cm.CommandText = "SELECT telefono,ruc FROM proveedor WHERE PV_codigo='" + Me.LBLCOD_PROVEEDOR.Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.lbltelefono.Text = dr(0).ToString
                    Me.lblruc.Text = dr(1).ToString
                Loop
            Else
                MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        mostrar()
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBLPRODUCTO.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.Label13.Text = Me.ListView2.SelectedItems(0).SubItems(3).Text
        End If
        Me.ListView2.Visible = False

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DETALLES.SelectedItems.Count > 0 Then
            Me.LBLPRODUCTO.Text = Me.DETALLES.SelectedItems(0).SubItems(1).Text
            Me.Label10.Text = Me.DETALLES.SelectedItems(0).SubItems(1).Text
            Me.TextBox1.Text = Me.DETALLES.SelectedItems(0).SubItems(3).Text
            Me.TXTPRECIO.Text = Me.DETALLES.SelectedItems(0).SubItems(4).Text
            Me.TextBox3.Text = Mid(Me.DETALLES.SelectedItems(0).SubItems(2).Text, 1, InStr(1, Me.DETALLES.SelectedItems(0).SubItems(2).Text, ",") - 1)
            marca()
            If Me.DETALLES.SelectedItems.Count > 0 Then
                Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
                lista()
                If Me.DETALLES.Items.Count = 0 Then
                    Me.TXTTOTAL.Text = 0
                End If
            End If
        Else
            MsgBox("Seleccione un elento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub marca()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT m.descripcion from producto p inner join marca m on m.cod_marca=p.cod_marca where p.pro_codigo='" + Me.LBLPRODUCTO.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 1
            If datar.HasRows Then
                While datar.Read
                    Me.Label13.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtpesocarga As System.Windows.Forms.TextBox
    Friend WithEvents txtpesototal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class

