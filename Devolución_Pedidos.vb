Imports System.Data.SqlClient
Public Class Devolución_Pedidos
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblproducto As System.Windows.Forms.Label
    Friend WithEvents lblmarca As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigop As System.Windows.Forms.Label
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Devolución_Pedidos))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.lblcodigop = New System.Windows.Forms.Label
        Me.lblmarca = New System.Windows.Forms.Label
        Me.lblproducto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Location = New System.Drawing.Point(672, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 176)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(16, 128)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(88, 40)
        Me.BTNRETORNAR.TabIndex = 70
        Me.BTNRETORNAR.Text = "&Salir"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "&Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "&Grabar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(16, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 40)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "&Eliminar Pedido"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(592, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Location = New System.Drawing.Point(96, 24)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(264, 23)
        Me.lblcodigo.TabIndex = 37
        Me.lblcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 160)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(568, 160)
        Me.ListView1.TabIndex = 64
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod_Producto"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Producto"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Marca"
        Me.ColumnHeader3.Width = 229
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cantidad"
        Me.ColumnHeader4.Width = 131
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(592, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 40)
        Me.Button5.TabIndex = 66
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(592, 216)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 67
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.lblcodigop)
        Me.GroupBox2.Controls.Add(Me.lblmarca)
        Me.GroupBox2.Controls.Add(Me.lblproducto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 104)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(472, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(472, 72)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(104, 20)
        Me.txtcantidad.TabIndex = 5
        Me.txtcantidad.Text = ""
        '
        'lblcodigop
        '
        Me.lblcodigop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigop.Location = New System.Drawing.Point(480, 32)
        Me.lblcodigop.Name = "lblcodigop"
        Me.lblcodigop.Size = New System.Drawing.Size(16, 8)
        Me.lblcodigop.TabIndex = 6
        '
        'lblmarca
        '
        Me.lblmarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmarca.Location = New System.Drawing.Point(152, 72)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(288, 24)
        Me.lblmarca.TabIndex = 4
        Me.lblmarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblproducto
        '
        Me.lblproducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblproducto.Location = New System.Drawing.Point(144, 24)
        Me.lblproducto.Name = "lblproducto"
        Me.lblproducto.Size = New System.Drawing.Size(320, 24)
        Me.lblproducto.TabIndex = 3
        Me.lblproducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(32, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(592, 40)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(32, 32)
        Me.BTNAGREGAR.TabIndex = 70
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(112, 368)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(472, 88)
        Me.ListView2.TabIndex = 71
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        Me.ColumnHeader6.Width = 51
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Producto"
        Me.ColumnHeader7.Width = 246
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Marca"
        Me.ColumnHeader8.Width = 109
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Precio"
        Me.ColumnHeader9.Width = 63
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 104)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(344, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(16, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Marca"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(32, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 8)
        Me.Label10.TabIndex = 15
        Me.Label10.Visible = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(96, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 23)
        Me.Label6.TabIndex = 35
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
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLVENTAS.Location = New System.Drawing.Point(40, 32)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(8, 8)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLVENTAS.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(56, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 8)
        Me.Label5.TabIndex = 16
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(496, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(496, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cantidad"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Info
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(592, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 32)
        Me.Button7.TabIndex = 28
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.RichTextBox1)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.lblcodigo)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(568, 144)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Pedido"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 24)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Observación:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 56)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 48)
        Me.RichTextBox1.TabIndex = 75
        Me.RichTextBox1.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 24)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Estado"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(440, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 24)
        Me.Label12.TabIndex = 40
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(384, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 24)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Fecha"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Pedido Nº"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(96, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 24)
        Me.Label13.TabIndex = 73
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(480, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 77
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader10})
        Me.ListView3.Location = New System.Drawing.Point(592, 16)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(48, 136)
        Me.ListView3.TabIndex = 78
        Me.ListView3.View = System.Windows.Forms.View.Details
        Me.ListView3.Visible = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Codigo"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "cantidad"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(704, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 23)
        Me.Label17.TabIndex = 79
        Me.Label17.Visible = False
        '
        'Devolución_Pedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(808, 470)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Devolución_Pedidos"
        Me.Text = "Modificar Pedidos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub LIMPIAR()
        Me.lblcodigo.ResetText()
        Me.Label12.ResetText()
        Me.Label13.ResetText()
        Me.RichTextBox1.ResetText()
        Me.ListView1.Items.Clear()
        Me.lblproducto.ResetText()
        Me.TextBox3.ResetText()
    End Sub
    Private Sub Devolución_Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblcodigo.Text = ordensalida
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView2.Visible = False
        Me.lblcodigop.ResetText()
        Me.Label17.Text = 0
        LLENAR()
    End Sub
    Sub LLENAR()
        'LLENAR LA LISTA CON LOS DATOS DEL PEDIDO
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select pro.pro_codigo, PRO_DESCRIPCION,m.descripcion,cantidad,convert(char(10),ped_fecha,103) from pedidos ped inner join detalle_orden os on ped.ped_codigo=os.ped_codigo inner join detalle_pedido dp on dp.ped_codigo=ped.ped_codigo inner join empresas_pedidoS ep on ep.cod_empresa=ped.cod_empresa inner join personal per on per.PE_CODIGO=PED.PE_CODIGO INNER JOIN PRODUCTO PRO ON PRO.PRO_CODIGO=DP.PRO_CODIGO inner join marca m on m.cod_marca=pro.cod_marca where ped.ped_codigo='" + Me.lblcodigo.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    Me.Label12.Text = datar(4).ToString
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try

        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select pro.pro_codigo,cantidad from  pedidos ped inner join detalle_orden os on ped.ped_codigo=os.ped_codigo inner join detalle_pedido dp on dp.ped_codigo=ped.ped_codigo inner join empresas_pedidoS ep on ep.cod_empresa=ped.cod_empresa inner join personal per on per.PE_CODIGO=PED.PE_CODIGO INNER JOIN PRODUCTO PRO ON PRO.PRO_CODIGO=DP.PRO_CODIGO inner join marca m on m.cod_marca=pro.cod_marca where ped.ped_codigo='" + Me.lblcodigo.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView3.Items.Add(CStr((datar(0))), 1)
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try

        ' COLOCAR EL ESTADO Y LA OBSERVACION SEGUN EL PEDIDO
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select ESTADO,observacion From PEDIDOS where ped_codigo='" + Me.lblcodigo.Text + "'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.Label13.Text = datar(0)
                    Me.RichTextBox1.Text = datar(1)
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
        If Me.ListView1.SelectedItems.Count > 0 Then
            If Me.Label13.Text = "Pendiente" Then
                Me.lblcodigop.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
                Me.lblproducto.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
                Me.lblmarca.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
                Me.txtcantidad.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
                Me.GroupBox2.Visible = True
                Me.GroupBox3.Visible = False
                Me.ListView2.Visible = False
            Else
                If Me.Label13.Text = "Atendido" Then
                    Me.lblcodigop.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
                    Me.lblproducto.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
                    Me.lblmarca.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
                    Me.txtcantidad.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
                    Me.GroupBox2.Visible = True
                    Me.GroupBox3.Visible = False
                    Me.ListView2.Visible = False
                Else
                    MsgBox("Los datos no se pueden modificar", MsgBoxStyle.Critical)
                End If
            End If
        Else
                MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Exclamation)
        End If
        LLENARLISTA()
    End Sub
    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        Me.GroupBox3.Visible = False
        Me.ListView2.Visible = False
        If Val(Me.txtcantidad.Text) > Val(Me.Label14.Text) Then
            MsgBox("LA CANTIDAD QUE HA INGRESADO SUPERA AL STOCK ACTUAL, POR FAVOR INGRESE UNA CANTIDAD MENOR", MsgBoxStyle.Information)
            Me.TextBox1.Text = ""
        Else
            If Me.Label13.Text = "Pendiente" Then
                Dim o As Integer
                For o = 0 To Me.ListView1.Items.Count - 1
                    If Me.ListView1.Items(o).SubItems(0).Text = Me.lblcodigop.Text Then
                        Me.ListView1.Items(o).SubItems(3).Text = Me.txtcantidad.Text
                    End If
                Next
                Me.lblcodigop.ResetText()
                Me.GroupBox2.Visible = False
            Else
                If Me.Label13.Text = "Atendido" Then
                    Dim o As Integer
                    For o = 0 To Me.ListView1.Items.Count - 1
                        If Me.ListView1.Items(o).SubItems(0).Text = Me.lblcodigop.Text Then
                            If Val(Me.ListView1.Items(o).SubItems(3).Text) >= Val(Me.txtcantidad.Text) Then
                                Me.ListView1.Items(o).SubItems(3).Text = Me.txtcantidad.Text
                            Else
                                MsgBox("Debe ingresar una cantidad menor o igual a la q ha sido ingresada anteriormente", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    Me.lblcodigop.ResetText()
                    Me.GroupBox2.Visible = False
                Else
                    MsgBox("Los datos no se pueden modificar", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.GroupBox2.Visible = False
        If Me.Label13.Text = "Pendiente" Then
            Me.GroupBox3.Visible = True
        Else
            MsgBox("Los datos no se pueden modificar", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView2.Visible = False
        If MsgBox("¿Desea eliminar el producto ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            If tipo = "2" Then
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Me.ListView1.Items.RemoveAt(Me.ListView1.SelectedItems(0).Index)
                Else
                    MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Exclamation)
                End If
            Else
                If Me.Label13.Text = "Pendiente" Then
                    If Me.ListView1.SelectedItems.Count > 0 Then
                        Me.ListView1.Items.RemoveAt(Me.ListView1.SelectedItems(0).Index)
                    Else
                        MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Exclamation)
                    End If
                Else
                    If Me.Label13.Text = "Atendido" Then
                        Me.Label17.Text = 1
                        If Me.ListView1.SelectedItems.Count > 0 Then
                            actualizarstocksumar()
                            Me.ListView1.Items.RemoveAt(Me.ListView1.SelectedItems(0).Index)
                        Else
                            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Exclamation)
                        End If
                    Else
                        MsgBox("Los datos no se pueden modificar", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If
        End If
    End Sub
    Sub actualizarstocksumar()
        'actualizar stock de productos sumar
        Dim i As Integer
        For i = 0 To Me.ListView1.Items.Count - 1
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "update stock set pro_stock= pro_stock+ '" + Me.ListView1.Items(i).SubItems(3).Text + "'where pro_codigo='" + Me.ListView1.Items(i).SubItems(0).Text + "'"
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
    End Sub
    Sub actualizarstocksumar1()
        Dim i As Integer
        For i = 0 To Me.ListView3.Items.Count - 1
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "update stock set pro_stock= pro_stock+ '" + Me.ListView3.Items(i).SubItems(1).Text + "'where pro_codigo='" + Me.ListView3.Items(i).SubItems(0).Text + "'"
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
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView2.Visible = False
        Me.ListView1.Items.Clear()
        LLENAR()
    End Sub
    Sub borrar()
        'borrar el detalle anterior
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "delete detalle_pedido where ped_codigo='" + Me.lblcodigo.Text + "'"
            cm.Connection = cn
            a = cm.ExecuteNonQuery()
            If a >= 1 Then
                ' MsgBox("Datos GuardadosCorrectamente", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub nuevodetalle()
        'ingresar el nuevo detalle
        Dim i As Integer
        For i = 0 To Me.ListView1.Items.Count - 1
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert detalle_pedido (ped_codigo,pro_codigo, cantidad) values ('" + Me.lblcodigo.Text + "','" + Me.ListView1.Items(i).SubItems(0).Text + "','" + Me.ListView1.Items(i).SubItems(3).Text + "')"
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
    Sub actualizarstockrestar()
        Dim d As Integer
        For d = 0 To Me.ListView1.Items.Count - 1
            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "UPDATE STOCK SET PRO_STOCK = PRO_STOCK - '" + Me.ListView1.Items(d).SubItems(3).Text + "'  WHERE PRO_CODIGO='" + Me.ListView1.Items(d).SubItems(0).Text + "'"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    'MsgBox("Datos actualizados", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
        Next
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.lblcodigo.Text = "" Or Me.Label12.Text = "" Or Me.Label13.Text = "" Then
            MsgBox("Grabación no permitida", MsgBoxStyle.Critical)
        Else
            If Me.RichTextBox1.Text = "Ninguna" Then
                MsgBox("Debe Ingresar el comentario del pedido en el campo observación", MsgBoxStyle.Exclamation)
            Else
                If tipo = "2" Then
                    Try
                        cn.Open()
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "update pedidos set estado='Atendido',observacion='" + Me.RichTextBox1.Text + "',fecha_modificacion='" + Me.DateTimePicker1.Text + "'where ped_codigo='" + Me.lblcodigo.Text + "'"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                            MsgBox("Datos Guardados", MsgBoxStyle.Information)
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                Else
                    If Me.Label13.Text = "Pendiente" Then
                        'borrar detalle anterior
                        borrar()
                        'ingresar nuevo detalle
                        nuevodetalle()
                        'actualizar el estado,FECHA y la observacion del pedido de Pendiente a atendido
                        Try
                            cn.Open()
                            Dim a As Integer
                            Dim b As Integer
                            cm.CommandType = CommandType.Text
                            cm.CommandText = "update pedidos set estado='Atendido',observacion='" + Me.RichTextBox1.Text + "',fecha_modificacion='" + Me.DateTimePicker1.Text + "'where ped_codigo='" + Me.lblcodigo.Text + "'"
                            cm.Connection = cn
                            a = cm.ExecuteNonQuery()
                            If a >= 1 Then
                                'MsgBox("Datos Guardadosy actualizados", MsgBoxStyle.Information)
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                            cn.Close()
                        End Try
                        'actualizar stock de productos
                        actualizarstockrestar()
                    End If

                    If Me.Label13.Text = "Atendido" Then
                        'borrar detalle anterior
                        borrar()
                        'ingresar nuevo detalle
                        nuevodetalle()
                        'actualizar stock de productos restar
                        actualizarstockrestar()
                        If Me.Label17.Text = 0 Then
                            actualizarstocksumar1()
                        End If
                    End If
                    Me.GroupBox2.Visible = False
                    Me.GroupBox3.Visible = False
                    Me.ListView2.Visible = False
                    LIMPIAR()
                End If
                MsgBox("Datos Guardados", MsgBoxStyle.Information)
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView2.Visible = False
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView2.Visible = True
        Try
            Me.ListView2.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PRO_CODIGO, PRO_DESCRIPCION,M.DESCRIPCION, PRO_PRECIO FROM PRODUCTO P INNER JOIN MARCA M ON M.COD_MARCA=P.COD_MARCA WHERE PRO_DESCRIPCION LIKE'%" & TextBox3.Text & "%'"
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
    Sub LLENARLISTA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT pro_stock FROM STOCK WHERE PRO_CODIGO ='" + Me.lblcodigop.Text + "'"
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
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.lblcodigop.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.Label6.Text = Me.ListView2.SelectedItems(0).SubItems(2).Text
        End If
        Me.ListView2.Visible = False
        LLENARLISTA()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Val(Me.TextBox1.Text) > Val(Me.Label14.Text) Then
            MsgBox("LA CANTIDAD QUE HA INGRESADO SUPERA AL STOCK ACTUAL, POR FAVOR INGRESE UNA CANTIDAD MENOR", MsgBoxStyle.Information)
            Me.TextBox1.Text = ""
        Else
            If Me.Label13.Text = "Pendiente" Then
                Dim lSingleItem As ListViewItem
                lSingleItem = Me.ListView1.Items.Add(Me.lblcodigop.Text)
                lSingleItem.SubItems.Add(Me.TextBox3.Text)
                lSingleItem.SubItems.Add(Me.Label6.Text)
                lSingleItem.SubItems.Add(Me.TextBox1.Text)
            End If
        End If
        Me.lblcodigop.Text = ""
        Me.GroupBox3.Visible = False
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
            ordensalida = ""
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("¿Desea eliminar el pedido ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            If tipo = "2" Then
                Try
                    cn.Open()
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "update pedidos set estado='Anulado',observacion='" + Me.RichTextBox1.Text + "',fecha_modificacion='" + Me.DateTimePicker1.Text + "' where Ped_CODIGo ='" + Me.lblcodigo.Text + "'"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos actualizados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
            Else
                If Me.Label13.Text = "Atendido" Then
                    'actualizamos el estado Y MODIFICACION del pedido
                    Try
                        cn.Open()
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "update pedidos set estado='Anulado',observacion='" + Me.RichTextBox1.Text + "',fecha_modificacion='" + Me.DateTimePicker1.Text + "' where Ped_CODIGo ='" + Me.lblcodigo.Text + "'"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                            'MsgBox("Datos actualizados", MsgBoxStyle.Information)
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                    'actualizamos el stock
                    Dim i As Integer
                    For i = 0 To Me.ListView1.Items.Count - 1
                        cn.Open()
                        Try
                            Dim a As Integer
                            Dim b As Integer
                            cm.CommandType = CommandType.Text
                            cm.CommandText = "update stock set pro_stock= pro_stock+ '" + Me.ListView1.Items(i).SubItems(3).Text + "'where pro_codigo='" + Me.ListView1.Items(i).SubItems(0).Text + "'"
                            cm.Connection = cn
                            a = cm.ExecuteNonQuery()
                            If a >= 1 Then
                                'MsgBox("stock Guardados", MsgBoxStyle.Information)
                            End If
                            cn.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical)
                            cn.Close()
                        End Try
                        cn.Close()
                    Next
                End If
                LIMPIAR()
                If Me.Label13.Text = "Pendiente" Then
                    Try
                        cn.Open()
                        Dim a As Integer
                        Dim b As Integer
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "update pedidos set estado='Anulado',observacion='" + Me.RichTextBox1.Text + "' ,fecha_modificacion='" + Me.DateTimePicker1.Text + "'where Ped_CODIGo ='" + Me.lblcodigo.Text + "'"
                        cm.Connection = cn
                        a = cm.ExecuteNonQuery()
                        If a >= 1 Then
                            'MsgBox("Datos actualizados", MsgBoxStyle.Information)
                        End If
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical)
                        cn.Close()
                    End Try
                    LIMPIAR()
                End If
                If Me.Label13.Text = "Anulado" Then
                    MsgBox("Error............. el pedido ya fue anulado", MsgBoxStyle.Critical)
                    LIMPIAR()
                End If
            End If
        End If
    End Sub
    Private Sub Devolución_Pedidos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ordensalida = ""
    End Sub
End Class
