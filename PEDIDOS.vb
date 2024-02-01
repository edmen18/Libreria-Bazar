Imports System.Data.SqlClient
Public Class PEDIDOS
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DETALLES As System.Windows.Forms.ListView
    Friend WithEvents venta As System.Windows.Forms.ColumnHeader
    Friend WithEvents producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LABELNOMBRE As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PEDIDOS))
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DETALLES = New System.Windows.Forms.ListView
        Me.venta = New System.Windows.Forms.ColumnHeader
        Me.producto = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.cantidad = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.LBLCOD_CLIENTE = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LABELNOMBRE = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(-136, -17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 24)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Tipo de Venta"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-8, -65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 55)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Registro  de Ventas"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DETALLES
        '
        Me.DETALLES.BackColor = System.Drawing.SystemColors.Menu
        Me.DETALLES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.venta, Me.producto, Me.ColumnHeader3, Me.cantidad})
        Me.DETALLES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DETALLES.FullRowSelect = True
        Me.DETALLES.GridLines = True
        Me.DETALLES.HideSelection = False
        Me.DETALLES.Location = New System.Drawing.Point(16, 200)
        Me.DETALLES.Name = "DETALLES"
        Me.DETALLES.Size = New System.Drawing.Size(624, 144)
        Me.DETALLES.TabIndex = 53
        Me.DETALLES.View = System.Windows.Forms.View.Details
        '
        'venta
        '
        Me.venta.Text = "Pedido Nº"
        Me.venta.Width = 78
        '
        'producto
        '
        Me.producto.Text = "Cod_Producto"
        Me.producto.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Producto"
        Me.ColumnHeader3.Width = 300
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.Width = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LBLCOD_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LABELNOMBRE)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 88)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Código"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLCOD_CLIENTE
        '
        Me.LBLCOD_CLIENTE.Location = New System.Drawing.Point(96, 56)
        Me.LBLCOD_CLIENTE.Name = "LBLCOD_CLIENTE"
        Me.LBLCOD_CLIENTE.Size = New System.Drawing.Size(248, 24)
        Me.LBLCOD_CLIENTE.TabIndex = 13
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(8, 24)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(72, 20)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Razón Social"
        Me.LDAPELLEDIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(96, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(392, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(16, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(8, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Visible = False
        '
        'LABELNOMBRE
        '
        Me.LABELNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LABELNOMBRE.Enabled = False
        Me.LABELNOMBRE.Location = New System.Drawing.Point(16, 64)
        Me.LABELNOMBRE.Name = "LABELNOMBRE"
        Me.LABELNOMBRE.Size = New System.Drawing.Size(8, 8)
        Me.LABELNOMBRE.TabIndex = 29
        Me.LABELNOMBRE.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(720, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 160)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(8, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 16)
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
        Me.Button2.Location = New System.Drawing.Point(8, 64)
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
        Me.Button5.Location = New System.Drawing.Point(648, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(368, -65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, -65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 54)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(520, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 88)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(-24, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 8)
        Me.Label14.TabIndex = 34
        Me.Label14.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(16, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Pedido Nº"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Orden de Salida Nº"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(16, 24)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(88, 20)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(600, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 24)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Marca"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(392, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(16, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 168)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(280, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(576, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(576, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(648, 168)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNAGREGAR.TabIndex = 28
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(96, 192)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(544, 80)
        Me.ListView1.TabIndex = 58
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Producto"
        Me.ColumnHeader2.Width = 258
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marca"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Precio"
        Me.ColumnHeader5.Width = 70
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(112, 80)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(376, 88)
        Me.ListView2.TabIndex = 59
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Descripción"
        Me.ColumnHeader7.Width = 350
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Telefono"
        Me.ColumnHeader8.Width = 100
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(88, 360)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(560, 56)
        Me.RichTextBox1.TabIndex = 60
        Me.RichTextBox1.Text = "Ninguna"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Observación:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 23)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Código"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(648, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 65
        '
        'PEDIDOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(832, 430)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DETALLES)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PEDIDOS"
        Me.Text = "Registro de Pedidos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click

        If Val(Me.TextBox1.Text) > Val(Me.Label14.Text) Then
            MsgBox("LA CANTIDAD QUE HA INGRESADO SUPERA AL STOCK ACTUAL, POR FAVOR INGRESE UNA CANTIDAD MENOR", MsgBoxStyle.Information)
            Me.TextBox1.Text = ""
        Else
            'Me.Button1.Enabled = True
            'Me.Button2.Enabled = True
            'Me.Button5.Enabled = False
            If Me.LBLCOD_CLIENTE.Text = "" Or Me.Label1.Text = "" Or Me.TextBox1.Text = "" Then
                MsgBox("INGRESE LOS DATOS CORRECTOS", MsgBoxStyle.Exclamation)
            Else

                Dim lSingleItem As ListViewItem
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
                    lSingleItem = DETALLES.Items.Add(Me.LBLVENTAS.Text)
                    lSingleItem.SubItems.Add(Me.Label10.Text)
                    lSingleItem.SubItems.Add(Me.TextBox3.Text.Trim + "," + Me.Label6.Text)
                    lSingleItem.SubItems.Add(Me.TextBox1.Text)
                    Me.Button5.Enabled = True
                    Me.TextBox3.Text = ""
                    Me.TextBox1.Text = ""
                    Me.Label6.ResetText()
                    Me.Label10.ResetText()
                    Me.Button2.Enabled = True
                    Me.Button1.Enabled = True
                  
                Else
                    MsgBox("No está permitido ingresar dos productos iguales", MsgBoxStyle.Critical)
                End If
            End If
        End If
        
       
    End Sub
    Sub LIMPIAR()
        Me.TextBox3.Text = ""
        Me.TextBox1.Text = ""
        Me.Label6.ResetText()
        Me.TXTAPELLIDOS.ResetText()
        Me.DETALLES.Items.Clear()
        Me.Label9.ResetText()
        Me.LBLCOD_CLIENTE.ResetText()
        Me.LABELNOMBRE.ResetText()
        Me.RichTextBox1.ResetText()
        Me.Label10.ResetText()
    End Sub
    Private Sub PEDIDOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTAPELLIDOS.Text = ""
        Me.Button1.Enabled = False
        Me.Button5.Enabled = False
        Me.ListView1.Visible = False
        Me.ListView2.Visible = False
        'CARGAR PRODUCTOS
        Me.TextBox3.Text = ""
        GENERARPEDIDO()
        GENERAR()
        Me.Label1.Text = CODIGOP
    End Sub
    Sub actualizar()
        Dim I As Integer
        For I = 0 To DETALLES.Items.Count - 1
            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "UPDATE STOCK SET PRO_STOCK = PRO_STOCK - '" + DETALLES.Items(I).SubItems(3).Text + "'  WHERE PRO_CODIGO='" + DETALLES.Items(I).SubItems(1).Text + "'"
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
        Me.Button3.Enabled = True
        Me.Button2.Enabled = False
        Me.BTNAGREGAR.Enabled = True
        cn.Close()
    End Sub

    Sub GENERARPEDIDO()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from PEDIDOS"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLVENTAS.Text = "00" + CStr(datar(0))
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
        If orden1 = "" Then
            Try
                Dim datar As SqlClient.SqlDataReader
                cn.Open()
                cm.Connection = cn
                cm.CommandText = "select count(*)+1 from ORDEN_SALIDAs"
                cm.CommandType = CommandType.Text
                datar = cm.ExecuteReader
                If datar.HasRows Then
                    While datar.Read
                        Me.Label2.Text = "00" + CStr(datar(0))
                    End While
                End If
                datar.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
        Else
            Me.Label2.Text = orden1
        End If
    End Sub

    Sub LLENARLISTA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT pro_stock FROM STOCK WHERE PRO_CODIGO ='" + Me.Label10.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.Label14.Text = datar(0).ToString
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView1.Visible = True
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PRO_CODIGO, PRO_DESCRIPCION,M.DESCRIPCION, PRO_PRECIO FROM PRODUCTO P INNER JOIN MARCA M ON M.COD_MARCA=P.COD_MARCA WHERE PRO_DESCRIPCION LIKE'%" & TextBox3.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
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

    Private Sub TXTAPELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDOS.KeyPress
        Me.ListView2.Visible = True
        Try
            Me.ListView2.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT cod_empresa,razon_empresa,telefono_empresa FROM empresas_pedidos WHERE razon_empresa LIKE'%" & TXTAPELLIDOS.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView2.Items.Add(CStr((datar(0))), 1)
                    Me.ListView2.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView2.Items(I).SubItems.Add(CStr(datar(2).ToString))
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'recorremos la lista
        Dim k As Integer
        Dim indicador As Integer
        indicador = 0
        For k = 0 To Me.DETALLES.Items.Count - 1
            indicador = indicador + 1
        Next
        'guardamos los datos
        If Me.LBLCOD_CLIENTE.Text = "" Or Me.Label1.Text = "" Or indicador = 0 Then
            MsgBox("Los datos no se pueden guardar debido a que están incompletos", MsgBoxStyle.Critical)
        Else
            'guardamos en orden de salida
            If orden1 = "" Then
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert orden_salidas (cod_ordensalida,fecha) values ('" + Me.Label2.Text + "','" + Me.DateTimePicker1.Text + "')"
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
            Else

            End If
            'guardamos en pedidos
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert pedidos (ped_codigo,ped_fecha,cod_empresa,estado,observacion,pe_codigo) values ('" + Me.LBLVENTAS.Text + "','" + Me.DateTimePicker1.Text + "','" + Me.LBLCOD_CLIENTE.Text + "','Pendiente','" + Me.RichTextBox1.Text + "','" + Me.Label1.Text + "')"
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
            'guardamos en detalle pedido
            detalle()
            'guardamos en detalle orden
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert detalle_orden (ped_codigo,cod_ordensalida) values ('" + Me.LBLVENTAS.Text + "','" + Me.Label2.Text + "')"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    MsgBox("Datos Guardados en detalle_orden", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            cn.Close()
            'llamamos al reporte de la orden de salida
            llamar()
            'limpiamos
            LIMPIAR()
            'volvemos a generar
            GENERAR()
            GENERARPEDIDO()
        End If
    End Sub
    Sub llamar()
        ordensalida = Me.LBLVENTAS.Text
        Dim o As New orden_de_salida
        o.ShowDialog()
    End Sub
    Sub detalle()
        Dim i As Integer
        For i = 0 To Me.DETALLES.Items.Count - 1
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert detalle_pedido (ped_codigo,pro_codigo, cantidad) values ('" + Me.LBLVENTAS.Text + "','" + Me.DETALLES.Items(i).SubItems(1).Text + "','" + Me.DETALLES.Items(i).SubItems(3).Text + "')"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    'MsgBox("Datos Guardados en detalle_pedidos", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            cn.Close()
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DETALLES.Items.Clear()
        Me.Button1.Enabled = False
        Me.TXTAPELLIDOS.ResetText()
        LIMPIAR()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.DETALLES.SelectedItems.Count > 0 Then
            Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
            evaluavacio()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub evaluavacio()
        Dim o As Integer
        Dim ind As Integer
        ind = 0
        For o = 0 To Me.DETALLES.Items.Count - 1
            ind = ind + 1
        Next
        If ind = 0 Then
            Me.Button1.Enabled = False
        Else
            Me.Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
            orden1 = ""
        End If
    End Sub
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBLCOD_CLIENTE.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
        End If
        Me.ListView2.Visible = False
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.Label10.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.Label6.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
        End If
        Me.ListView1.Visible = False
        LLENARLISTA()
    End Sub
    Sub marca()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT m.descripcion from producto p inner join marca m on m.cod_marca=p.cod_marca where p.pro_codigo='" + Me.Label10.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 1
            If datar.HasRows Then
                While datar.Read
                    Me.Label6.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DETALLES.SelectedItems.Count > 0 Then
            Me.Label10.Text = Me.DETALLES.SelectedItems(0).SubItems(1).Text
            Me.TextBox1.Text = Me.DETALLES.SelectedItems(0).SubItems(3).Text
            Me.TextBox3.Text = Mid(Me.DETALLES.SelectedItems(0).SubItems(2).Text, 1, InStr(1, Me.DETALLES.SelectedItems(0).SubItems(2).Text, ",") - 1)
            marca()
            If Me.DETALLES.SelectedItems.Count > 0 Then
                Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
                evaluavacio()
            End If
        Else
            MsgBox("Seleccione un elento de la lista", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub PEDIDOS_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        orden1 = ""
        estado = ""
    End Sub
End Class
