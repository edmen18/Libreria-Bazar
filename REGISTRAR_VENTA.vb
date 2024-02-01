Imports System.Data
Imports System.Data.SqlClient
Public Class REGISTRAR_VENTA
    Inherits System.Windows.Forms.Form
    Public KeyAscii As Short
    Public KeyAscii1 As Short

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents TXTPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents DETALLES As System.Windows.Forms.ListView
    Friend WithEvents LABELNOMBRE As System.Windows.Forms.Label
    Friend WithEvents venta As System.Windows.Forms.ColumnHeader
    Friend WithEvents producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents cantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents precio1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LBLTC As System.Windows.Forms.Label
    Friend WithEvents LBLMAXIMO As System.Windows.Forms.Label
    Friend WithEvents LBLDEBE As System.Windows.Forms.Label
    Friend WithEvents lblexibe As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbticket As System.Windows.Forms.RadioButton
    Friend WithEvents rbboleta As System.Windows.Forms.RadioButton
    Friend WithEvents rbfactura As System.Windows.Forms.RadioButton
    Friend WithEvents lbltcp As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_IGV As System.Windows.Forms.Label
    Friend WithEvents LBLIGV As System.Windows.Forms.Label
    Friend WithEvents TXTCOMPROBANTE As System.Windows.Forms.TextBox
    Friend WithEvents LBLCMP As System.Windows.Forms.Label
    Friend WithEvents LBLTICKET As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(REGISTRAR_VENTA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTPRECIO = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.LABELNOMBRE = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBLCOD_CLIENTE = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.LBLTC = New System.Windows.Forms.Label
        Me.DETALLES = New System.Windows.Forms.ListView
        Me.venta = New System.Windows.Forms.ColumnHeader
        Me.producto = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.cantidad = New System.Windows.Forms.ColumnHeader
        Me.precio1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.TXTTOTAL = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LBLMAXIMO = New System.Windows.Forms.Label
        Me.LBLDEBE = New System.Windows.Forms.Label
        Me.lblexibe = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TXTCOMPROBANTE = New System.Windows.Forms.TextBox
        Me.rbfactura = New System.Windows.Forms.RadioButton
        Me.rbboleta = New System.Windows.Forms.RadioButton
        Me.rbticket = New System.Windows.Forms.RadioButton
        Me.lbltcp = New System.Windows.Forms.Label
        Me.LBLCOD_IGV = New System.Windows.Forms.Label
        Me.LBLIGV = New System.Windows.Forms.Label
        Me.LBLCMP = New System.Windows.Forms.Label
        Me.LBLTICKET = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(344, 480)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(24, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        Me.GroupBox1.Visible = False
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(56, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 8)
        Me.Label1.TabIndex = 16
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(16, 24)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(392, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 20)
        Me.Label16.TabIndex = 36
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Marca"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(24, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(264, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(576, 144)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(136, 24)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(584, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(584, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Location = New System.Drawing.Point(656, 240)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(56, 20)
        Me.TXTPRECIO.TabIndex = 4
        Me.TXTPRECIO.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(656, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Precio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(720, 240)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(40, 40)
        Me.BTNAGREGAR.TabIndex = 5
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(-16, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Visible = False
        '
        'LABELNOMBRE
        '
        Me.LABELNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LABELNOMBRE.Enabled = False
        Me.LABELNOMBRE.Location = New System.Drawing.Point(-16, 64)
        Me.LABELNOMBRE.Name = "LABELNOMBRE"
        Me.LABELNOMBRE.Size = New System.Drawing.Size(16, 8)
        Me.LABELNOMBRE.TabIndex = 29
        Me.LABELNOMBRE.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Location = New System.Drawing.Point(776, 232)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 160)
        Me.GroupBox4.TabIndex = 12
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
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(720, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LBLCOD_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LABELNOMBRE)
        Me.GroupBox2.Controls.Add(Me.LBLTC)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 88)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS "
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Dni"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(112, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(352, 23)
        Me.Label7.TabIndex = 30
        '
        'LBLCOD_CLIENTE
        '
        Me.LBLCOD_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCOD_CLIENTE.Location = New System.Drawing.Point(-24, 56)
        Me.LBLCOD_CLIENTE.Name = "LBLCOD_CLIENTE"
        Me.LBLCOD_CLIENTE.Size = New System.Drawing.Size(24, 16)
        Me.LBLCOD_CLIENTE.TabIndex = 13
        Me.LBLCOD_CLIENTE.Visible = False
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(16, 24)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(56, 20)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Cliente"
        Me.LDAPELLEDIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(112, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(352, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'LBLTC
        '
        Me.LBLTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTC.Location = New System.Drawing.Point(-24, 24)
        Me.LBLTC.Name = "LBLTC"
        Me.LBLTC.Size = New System.Drawing.Size(24, 16)
        Me.LBLTC.TabIndex = 46
        Me.LBLTC.Visible = False
        '
        'DETALLES
        '
        Me.DETALLES.BackColor = System.Drawing.SystemColors.Menu
        Me.DETALLES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.venta, Me.producto, Me.ColumnHeader3, Me.cantidad, Me.precio1, Me.ColumnHeader1})
        Me.DETALLES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DETALLES.FullRowSelect = True
        Me.DETALLES.GridLines = True
        Me.DETALLES.HideSelection = False
        Me.DETALLES.Location = New System.Drawing.Point(24, 264)
        Me.DETALLES.Name = "DETALLES"
        Me.DETALLES.Size = New System.Drawing.Size(688, 144)
        Me.DETALLES.TabIndex = 15
        Me.DETALLES.View = System.Windows.Forms.View.Details
        '
        'venta
        '
        Me.venta.Text = "Venta"
        Me.venta.Width = 78
        '
        'producto
        '
        Me.producto.Text = "Cod_Producto"
        Me.producto.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Producto"
        Me.ColumnHeader3.Width = 302
        '
        'cantidad
        '
        Me.cantidad.Text = "Cantidad"
        Me.cantidad.Width = 76
        '
        'precio1
        '
        Me.precio1.Text = "Precio"
        Me.precio1.Width = 64
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Importe"
        Me.ColumnHeader1.Width = 69
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Enabled = False
        Me.TXTTOTAL.Location = New System.Drawing.Point(640, 416)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.Size = New System.Drawing.Size(72, 20)
        Me.TXTTOTAL.TabIndex = 36
        Me.TXTTOTAL.Text = "00.00"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(568, 416)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 24)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Total"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 23)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "S/."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLMAXIMO
        '
        Me.LBLMAXIMO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLMAXIMO.Location = New System.Drawing.Point(832, 168)
        Me.LBLMAXIMO.Name = "LBLMAXIMO"
        Me.LBLMAXIMO.Size = New System.Drawing.Size(40, 24)
        Me.LBLMAXIMO.TabIndex = 46
        Me.LBLMAXIMO.Text = "0.00"
        Me.LBLMAXIMO.Visible = False
        '
        'LBLDEBE
        '
        Me.LBLDEBE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDEBE.Location = New System.Drawing.Point(832, 200)
        Me.LBLDEBE.Name = "LBLDEBE"
        Me.LBLDEBE.Size = New System.Drawing.Size(40, 24)
        Me.LBLDEBE.TabIndex = 47
        Me.LBLDEBE.Text = "0.00"
        Me.LBLDEBE.Visible = False
        '
        'lblexibe
        '
        Me.lblexibe.Location = New System.Drawing.Point(24, 632)
        Me.lblexibe.Name = "lblexibe"
        Me.lblexibe.Size = New System.Drawing.Size(48, 24)
        Me.lblexibe.TabIndex = 48
        Me.lblexibe.Visible = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(136, 152)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(480, 96)
        Me.ListView1.TabIndex = 49
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Código"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nombre y Apellidos"
        Me.ColumnHeader4.Width = 263
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DNI"
        Me.ColumnHeader5.Width = 82
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipo cliente"
        Me.ColumnHeader6.Width = 74
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(120, 264)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(592, 88)
        Me.ListView2.TabIndex = 50
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Código"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Producto"
        Me.ColumnHeader8.Width = 305
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Precio"
        Me.ColumnHeader9.Width = 54
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Marca"
        Me.ColumnHeader10.Width = 167
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(576, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 16)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Venta Nº"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(40, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton1.TabIndex = 53
        Me.RadioButton1.Text = "Contado"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(40, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 54
        Me.RadioButton2.Text = "Crédito"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(176, 88)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TIPO VENTA"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(720, 296)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 56
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TXTCOMPROBANTE)
        Me.GroupBox6.Controls.Add(Me.rbfactura)
        Me.GroupBox6.Controls.Add(Me.rbboleta)
        Me.GroupBox6.Controls.Add(Me.rbticket)
        Me.GroupBox6.Controls.Add(Me.LBLTICKET)
        Me.GroupBox6.Location = New System.Drawing.Point(216, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(288, 88)
        Me.GroupBox6.TabIndex = 57
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "COMPROBANTE"
        '
        'TXTCOMPROBANTE
        '
        Me.TXTCOMPROBANTE.Location = New System.Drawing.Point(112, 56)
        Me.TXTCOMPROBANTE.MaxLength = 11
        Me.TXTCOMPROBANTE.Name = "TXTCOMPROBANTE"
        Me.TXTCOMPROBANTE.Size = New System.Drawing.Size(152, 20)
        Me.TXTCOMPROBANTE.TabIndex = 3
        Me.TXTCOMPROBANTE.Text = ""
        '
        'rbfactura
        '
        Me.rbfactura.Location = New System.Drawing.Point(24, 64)
        Me.rbfactura.Name = "rbfactura"
        Me.rbfactura.Size = New System.Drawing.Size(64, 16)
        Me.rbfactura.TabIndex = 2
        Me.rbfactura.Text = "Factura"
        '
        'rbboleta
        '
        Me.rbboleta.Location = New System.Drawing.Point(24, 40)
        Me.rbboleta.Name = "rbboleta"
        Me.rbboleta.Size = New System.Drawing.Size(64, 16)
        Me.rbboleta.TabIndex = 1
        Me.rbboleta.Text = "Boleta"
        '
        'rbticket
        '
        Me.rbticket.Location = New System.Drawing.Point(24, 16)
        Me.rbticket.Name = "rbticket"
        Me.rbticket.Size = New System.Drawing.Size(56, 16)
        Me.rbticket.TabIndex = 0
        Me.rbticket.Text = "Ticket"
        '
        'lbltcp
        '
        Me.lbltcp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltcp.Location = New System.Drawing.Point(824, 80)
        Me.lbltcp.Name = "lbltcp"
        Me.lbltcp.Size = New System.Drawing.Size(40, 24)
        Me.lbltcp.TabIndex = 58
        Me.lbltcp.Visible = False
        '
        'LBLCOD_IGV
        '
        Me.LBLCOD_IGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCOD_IGV.Location = New System.Drawing.Point(824, 8)
        Me.LBLCOD_IGV.Name = "LBLCOD_IGV"
        Me.LBLCOD_IGV.Size = New System.Drawing.Size(40, 23)
        Me.LBLCOD_IGV.TabIndex = 59
        Me.LBLCOD_IGV.Visible = False
        '
        'LBLIGV
        '
        Me.LBLIGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLIGV.Location = New System.Drawing.Point(824, 40)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(40, 23)
        Me.LBLIGV.TabIndex = 60
        Me.LBLIGV.Visible = False
        '
        'LBLCMP
        '
        Me.LBLCMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCMP.Location = New System.Drawing.Point(824, 112)
        Me.LBLCMP.Name = "LBLCMP"
        Me.LBLCMP.Size = New System.Drawing.Size(40, 23)
        Me.LBLCMP.TabIndex = 61
        Me.LBLCMP.Visible = False
        '
        'LBLTICKET
        '
        Me.LBLTICKET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTICKET.Location = New System.Drawing.Point(112, 16)
        Me.LBLTICKET.Name = "LBLTICKET"
        Me.LBLTICKET.Size = New System.Drawing.Size(152, 23)
        Me.LBLTICKET.TabIndex = 62
        '
        'REGISTRAR_VENTA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(888, 454)
        Me.Controls.Add(Me.LBLCMP)
        Me.Controls.Add(Me.LBLIGV)
        Me.Controls.Add(Me.LBLCOD_IGV)
        Me.Controls.Add(Me.lbltcp)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblexibe)
        Me.Controls.Add(Me.LBLDEBE)
        Me.Controls.Add(Me.LBLMAXIMO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.DETALLES)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTPRECIO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LBLVENTAS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button5)
        Me.Name = "REGISTRAR_VENTA"
        Me.Text = "Registro Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dat As DataTable
    Private dta As SqlDataAdapter
    Private seleccion As String = "SELECT CL_NOMBRES, CL_APELLIDOS FROM CLIENTES"
    Private iniciando As Boolean = True
    Private dt As DataTable
    Private da As SqlDataAdapter
    Private seleccion1 As String = "SELECT PRO_DESCRIPCION, PRO_PRECIO FROM PRODUCTO"
    Private INICIANDO1 As Boolean = True
    Sub EVALUAR()
        If Me.LBLTC.Text <> "01" And Me.RadioButton2.Checked = True Then
            MsgBox("A este cliente no se le puede otorgar crédito")
            Me.Close()
        End If
    End Sub
    Sub ticket()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT cod_TC from TIPO_comprobante where cod_TC='C01'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 1
            If datar.HasRows Then
                While datar.Read
                    Me.lbltcp.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub boleta()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT cod_TC from TIPO_comprobante where cod_TC='C02'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 1
            If datar.HasRows Then
                While datar.Read
                    Me.lbltcp.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub factura()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT cod_TC from TIPO_comprobante where cod_TC='C03'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 1
            If datar.HasRows Then
                While datar.Read
                    Me.lbltcp.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
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

    Private Sub REGISTRAR_VENTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LBLTICKET.Visible = False
        Me.TXTCOMPROBANTE.Visible = False
        Me.TXTPRECIO.Enabled = False
        Me.TXTAPELLIDOS.Focus.Equals(True)
        Me.RadioButton1.Checked = True
        dta = New SqlDataAdapter(seleccion, cn)
        dat = New DataTable
        dta.Fill(dat)
        iniciando = False
        'VALIDACION
        Me.Button1.Enabled = False
        Me.Button5.Enabled = False
        Me.ListView1.Visible = False
        Me.ListView2.Visible = False
        Me.ListView2.Visible = False
        'CARGAR PRODUCTOS
        Me.TextBox3.Text = ""
        da = New SqlDataAdapter(seleccion1, cn)
        dt = New DataTable
        da.Fill(dt)
        GENERAR()
        GENERARCOM()
        Me.Label1.Text = CODIGOP
    End Sub
    Sub credito()
        If Me.RadioButton2.Checked = True And Me.LBLTC.Text = "01" Then
            ACRGARCREDITO()
            Try
                Dim datar As SqlClient.SqlDataReader
                cn.Open()
                cm.Connection = cn
                cm.CommandText = "SELECT sum (saldo)as debe from clientes c inner join ventas v on v.cl_codigo=c.cl_codigo inner join amortizaciones a on a.v_codigo=v.v_codigo where v.estado='moroso' AND C.CL_CODIGO='" + Me.LBLCOD_CLIENTE.Text + "'"
                cm.CommandType = CommandType.Text
                datar = cm.ExecuteReader
                Dim I As Integer = 1
                If datar.HasRows Then
                    While datar.Read
                        Me.LBLDEBE.Text = datar(0).ToString
                    End While
                End If
                datar.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
                cn.Close()
            End Try

        End If
    End Sub
    Sub ACRGARCREDITO()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select MAXIMO from CREDITO WHERE ESTADO='ACTIVO'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.LBLMAXIMO.Text = datar(0).ToString
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try

    End Sub
    Sub GENERAR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+2 from VENTAS"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLVENTAS.Text = "V" + CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub GENERARTICKET()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from TICKET"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLTICKET.Text = "0" + CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub GENERARCOM()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from COMPROBANTES_VENTA"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLCMP.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
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
    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        Dim t As Integer
        If Val(Me.TextBox1.Text) > Val(Me.Label14.Text) Then
            MsgBox("LA CANTIDAD QUE HA INGRESADO SUPERA AL STOCK ACTUAL, POR FAVOR INGRESE UNA CANTIDAD MENOR", MsgBoxStyle.Information)
            Me.TextBox1.Text = ""
        Else
            If Me.LBLCOD_CLIENTE.Text = "" Or Me.Label1.Text = "" Or Me.TXTPRECIO.Text = "" Or Me.TextBox1.Text = "" Then
                MsgBox("INGRESE LOS DATOS CORRECTOS", MsgBoxStyle.Exclamation)
            Else
                If Me.LBLTC.Text <> "01" And Me.RadioButton2.Checked = True Then
                    MsgBox("No es posible otorgar crédito a este cliente ya que no es trabajador de la UCV", MsgBoxStyle.Critical)
                    LIMPIAR()
                    limpiaresto()
                    Me.DETALLES.Items.Clear()
                    Me.LBLCOD_CLIENTE.ResetText()
                Else
                    credito()
                    If Val(Me.LBLDEBE.Text) > Val(Me.LBLMAXIMO.Text) Then
                        MsgBox("A este cliente no se le puede otorgar crédito debido a esta fuera del limite permitido", MsgBoxStyle.Critical)
                    Else
                        If Me.rbticket.Checked = False And Me.rbboleta.Checked = False And Me.rbfactura.Checked = False Then
                            MsgBox("Debe seleccionar ticket, boleta o factura", MsgBoxStyle.Critical)
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
                                lSingleItem.SubItems.Add(Me.TextBox3.Text.Trim + "," + Me.Label16.Text)
                                lSingleItem.SubItems.Add(Me.TextBox1.Text)
                                lSingleItem.SubItems.Add(Me.TXTPRECIO.Text)
                                lSingleItem.SubItems.Add(Val(Me.TXTPRECIO.Text) * Val(Me.TextBox1.Text))
                                Me.Button1.Enabled = True
                                Me.Button5.Enabled = False
                                Me.TextBox3.Focus()
                            Else
                                MsgBox("No se permite agregar dos veces el mismo producto", MsgBoxStyle.Critical)
                            End If
                        End If

                    End If
                End If
            End If
        End If
        Me.Button5.Enabled = True
        Me.TXTTOTAL.ResetText()
        For t = 0 To Me.DETALLES.Items.Count - 1
            Me.TXTTOTAL.Text = Val(Me.TXTTOTAL.Text) + Val(Me.DETALLES.Items(t).SubItems(5).Text)
        Next
        Me.TXTTOTAL.Text = Val(Me.TXTTOTAL.Text) + (Val(Me.TXTTOTAL.Text) * Val(Me.LBLIGV.Text))
        LIMPIAR()
        Me.TXTPRECIO.ResetText()
    End Sub
    Sub LIMPIAR()
        Me.TXTPRECIO.ResetText()
        Me.TextBox3.Text = ""
        Me.TextBox1.Text = ""
        Me.Label16.ResetText()
        Me.Label10.ResetText()
    End Sub
    Sub limpiaresto()
        Me.TXTAPELLIDOS.ResetText()
        Me.Label7.ResetText()
        Me.RadioButton2.Checked = False
        Me.RadioButton1.Checked = True
        Me.TXTCOMPROBANTE.ResetText()
        Me.TXTCOMPROBANTE.Visible = False
        Me.rbboleta.Checked = False
        Me.rbfactura.Checked = False
        Me.rbticket.Checked = False
        Me.lbltcp.ResetText()
        Me.LBLIGV.Text = 0
        Me.LBLCOD_IGV.ResetText()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guardartodo()
        Me.LBLTICKET.Visible = False
    End Sub
    Sub guardartodo()
        If Me.RadioButton2.Checked = True And Me.LBLTC.Text = "01" Then
            If Me.RadioButton2.Checked = True And Me.LBLTC.Text = "01" Then
                Dim subtotal As Double
                subtotal = Val(Me.LBLMAXIMO.Text) - Val(Me.LBLDEBE.Text)
                If Val(Me.TXTTOTAL.Text) > subtotal Then
                    Me.lblexibe.Text = subtotal
                    MsgBox("Error .... el monto maximo que el cliente puede comprar a crédito es S/." + Me.lblexibe.Text + " ", MsgBoxStyle.Critical)
                Else
                    guardar()
                End If
            End If
        Else
            guardar()
        End If
    End Sub
    Sub guardar()
        'GUARDAR EN COMPROBANTE
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "Insert COMPROBANTES_VENTA (COD_COMPROBANTE,COD_TC) values ('" + Me.LBLCMP.Text + "','" + Me.lbltcp.Text + "')"
            cm.Connection = cn
            a = cm.ExecuteNonQuery()
            If a >= 1 Then
                'MsgBox("Datos Guardados COMPROBANTE", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
        If Me.RadioButton2.Checked = True And Me.LBLTC.Text = "01" Then
            'ghuardar en venta
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert ventas (v_codigo, v_fecha, cl_codigo, pe_codigo,total,estado,COD_COMPROBANTE) values ('" + Me.LBLVENTAS.Text + "','" + Me.DateTimePicker1.Text + "','" + Me.LBLCOD_CLIENTE.Text + "','" + Me.Label1.Text + "','" + Me.TXTTOTAL.Text + "','A CREDITO','" + Me.LBLCMP.Text + "')"
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
            'guardar en detalle de venta
            Dim i As Integer
            Dim NuevaFila As DataRow
            Dim data As New DataTable
            Dim venta = 0
            Dim producto = 1
            Dim cantidad = 3
            Dim precio1 = 4
            For i = 0 To DETALLES.Items.Count - 1
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert Into detalle_venta (v_codigo, pro_codigo, dv_cantidad, dv_precio) values ('" + Me.DETALLES.Items(i).SubItems(0).Text + "','" + DETALLES.Items(i).SubItems(1).Text + "','" + DETALLES.Items(i).SubItems(3).Text + "','" + DETALLES.Items(i).SubItems(4).Text + "')"
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
            Next
            'GUARDAR EN PAGOS DE DEUDAS
            Try
                cn.Open()
                Dim a As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert Into AMORTIZACIONES(v_codigo,CANCELADO,saldo) values ('" + Me.LBLVENTAS.Text + "','0.00','" + Me.TXTTOTAL.Text + "')"
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
            'GUARDAR EN COMPROBANTES
            GUARDARCMP()
            MsgBox("Datos Guardados", MsgBoxStyle.Information)
            ventas = Me.LBLVENTAS.Text
            Me.Button2.Enabled = False
            Me.BTNAGREGAR.Enabled = False
            Me.Button3.Enabled = False
            Me.Button1.Enabled = False
            Me.TXTTOTAL.Text = 0
            cn.Close()
            actualizar()
            If Me.rbticket.Checked = True Then
                Dim ticket As New TICKET
                ticket.ShowDialog()
            End If
            ventas = Me.LBLVENTAS.Text
            Me.LBLVENTAS.Text = ""
            Me.LBLCMP.Text = ""
            limpiaresto()
            GENERAR()
            GENERARCOM()
            GENERARTICKET()
        Else
            If Me.RadioButton1.Checked = True Then
                'ghuardar en venta
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert ventas (v_codigo, v_fecha, cl_codigo, pe_codigo,total,estado,COD_COMPROBANTE) values ('" + Me.LBLVENTAS.Text + "','" + Me.DateTimePicker1.Text + "','" + Me.LBLCOD_CLIENTE.Text + "','" + Me.Label1.Text + "','" + Me.TXTTOTAL.Text + "','CANCELADA','" + Me.LBLCMP.Text + "')"
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
                'guardar en detalle de venta
                Dim i As Integer
                Dim NuevaFila As DataRow
                Dim data As New DataTable
                Dim venta = 0
                Dim producto = 1
                Dim cantidad = 3
                Dim precio1 = 4
                For i = 0 To DETALLES.Items.Count - 1
                    cn.Open()
                    Try
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "Insert Into detalle_venta (v_codigo, pro_codigo, dv_cantidad, dv_precio) values ('" + Me.DETALLES.Items(i).SubItems(0).Text + "','" + DETALLES.Items(i).SubItems(1).Text + "','" + DETALLES.Items(i).SubItems(3).Text + "','" + DETALLES.Items(i).SubItems(4).Text + "')"
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
                Next
                'GUARDAR EN COMPROBANTES
                GUARDARCMP()
                ventas = Me.LBLVENTAS.Text
                Me.Button2.Enabled = False
                Me.BTNAGREGAR.Enabled = False
                Me.Button3.Enabled = False
                Me.Button1.Enabled = False
                Me.TXTTOTAL.Text = 0
                cn.Close()
                actualizar()
                MsgBox("Datos Guardados", MsgBoxStyle.Information)
                If Me.rbticket.Checked = True Then
                    Dim ticket As New TICKET
                    ticket.ShowDialog()
                End If
                ventas = Me.LBLVENTAS.Text
                Me.LBLVENTAS.Text = ""
                Me.LBLCMP.ResetText()
                limpiaresto()
                GENERAR()
                GENERARCOM()
                GENERARTICKET()
            Else
                MsgBox("No es posible otorgar crédito a este cliente ya que no es trabajador de la UCV", MsgBoxStyle.Critical)
                LIMPIAR()
                limpiaresto()
                Me.DETALLES.Items.Clear()
                Me.LBLCOD_CLIENTE.ResetText()
            End If
        End If
    End Sub
    Sub GUARDARCMP()
        If Me.rbboleta.Checked = True Then
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert BOLETAS_VENTA (COD_BOLETA,COD_COMPROBANTE) values ('" + Me.TXTCOMPROBANTE.Text + "','" + Me.LBLCMP.Text + "')"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    'MsgBox("Datos Guardados BOLETA", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
            cn.Close()
        Else
            If Me.rbfactura.Checked = True Then
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert FACTURAS_VENTA (COD_FACTURA,COD_IGV,COD_COMPROBANTE) values ('" + Me.TXTCOMPROBANTE.Text + "','" + Me.LBLCOD_IGV.Text + "','" + Me.LBLCMP.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados FACTURAS", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
                cn.Close()
            Else
                If Me.rbticket.Checked = True Then
                    cn.Open()
                    Try
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "Insert TICKET (COD_COMPROBANTE,NUMERO) values ('" + Me.LBLCMP.Text + "','" + Me.LBLTICKET.Text + "')"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                            'MsgBox("Datos Guardados TICKET", MsgBoxStyle.Information)
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                    cn.Close()
                End If
            End If
        End If

    End Sub
    Private Sub TXTAPELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDOS.KeyPress
        Me.ListView1.Visible = True
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT cl_CODIGO, cl_apellidos+' '+cl_nombres,cl_dni,TC_CODIGO FROM clientes WHERE cl_apellidos+' '+cl_nombres LIKE'%" & TXTAPELLIDOS.Text & "%'"
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
    Function SoloLETRAS(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        ' Intercepta un código ASCII recibido admitiendo solamente
        ' letras, además:
        ' deja pasar sin afectar si recibe tecla de Backspace o enter
        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", Chr(KeyAscii)) = 0 Then
            SoloLETRAS = 0
        Else
            SoloLETRAS = KeyAscii
        End If
        ' teclas adicionales permitidas
        If KeyAscii = 8 Then SoloLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoloLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoloLETRAS = KeyAscii
    End Function
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 46
                SoloNumeros = Keyascii
        End Select
    End Function
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DETALLES.Items.Clear()
        Me.Button1.Enabled = False
        Me.Button2.Enabled = False
        Me.TXTTOTAL.ResetText()
        LIMPIAR()
        limpiaresto()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.DETALLES.SelectedItems.Count > 0 Then
            Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
            eliminar()
            evaluavacio()
            If Me.DETALLES.Items.Count = 0 Then
                Me.TXTTOTAL.Text = 0
            End If
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub eliminar()
        Dim a As Integer
        Dim total As Double
        total = 0
        For a = 0 To Me.DETALLES.Items.Count - 1
            total = total + Me.DETALLES.Items(a).SubItems(3).Text * Me.DETALLES.Items(a).SubItems(4).Text
            Me.TXTTOTAL.Text = total
        Next
    End Sub
    Private Sub TXTPRECIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPRECIO.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.LBLCOD_CLIENTE.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.Label7.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.LBLTC.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.ListView1.Visible = False
        End If
        Me.TextBox3.Focus()
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.Label10.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.TXTPRECIO.Text = Me.ListView2.SelectedItems(0).SubItems(2).Text
            Me.Label16.Text = Me.ListView2.SelectedItems(0).SubItems(3).Text
        End If
        LLENARLISTA()
        Me.ListView2.Visible = False
        Me.TextBox1.Focus()
    End Sub

    Private Sub DETALLES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DETALLES.SelectedIndexChanged

    End Sub

    Private Sub DETALLES_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DETALLES.DoubleClick

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
                    Me.Label16.Text = datar(0).ToString
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
            Me.TXTPRECIO.Text = Me.DETALLES.SelectedItems(0).SubItems(4).Text
            Me.TextBox3.Text = Mid(Me.DETALLES.SelectedItems(0).SubItems(2).Text, 1, InStr(1, Me.DETALLES.SelectedItems(0).SubItems(2).Text, ",") - 1)
            marca()
            If Me.DETALLES.SelectedItems.Count > 0 Then
                Me.DETALLES.Items.RemoveAt(Me.DETALLES.SelectedItems(0).Index)
                eliminar()
                evaluavacio()
                If Me.DETALLES.Items.Count = 0 Then
                    Me.TXTTOTAL.Text = 0
                End If
            End If
        Else
            MsgBox("Seleccione un elento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub TXTAPELLIDOS_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TabIndexChanged
        Me.ListView1.Focus()
    End Sub

    Private Sub rbticket_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbticket.CheckedChanged
        ticket()
        GENERARTICKET()
        Me.LBLTICKET.Visible = True
        Me.LBLIGV.Text = 0
        Me.LBLCOD_IGV.ResetText()
        Me.TXTCOMPROBANTE.Visible = False
    End Sub

    Private Sub rbboleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbboleta.CheckedChanged
        boleta()
        Me.LBLTICKET.ResetText()
        Me.LBLTICKET.Visible = False
        Me.LBLIGV.Text = 0
        Me.LBLCOD_IGV.ResetText()
        Me.TXTCOMPROBANTE.Visible = True
    End Sub

    Private Sub rbfactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfactura.CheckedChanged
        factura()
        igv()
        Me.LBLTICKET.ResetText()
        Me.LBLTICKET.Visible = False
        Me.TXTCOMPROBANTE.Visible = True
    End Sub
End Class
