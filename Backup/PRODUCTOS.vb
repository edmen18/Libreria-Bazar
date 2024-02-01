Imports System.Data
Imports System.Data.SqlClient
Public Class PRODUCTOS
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
    Friend WithEvents DGBPRODUCTO As System.Windows.Forms.GroupBox
    Friend WithEvents LBLCOD As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdesc_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents BTNACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents LMARCA As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcantidad_productos As System.Windows.Forms.Label
    Friend WithEvents lbltotal_unidades As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLCOD_MARCA As System.Windows.Forms.Label
    Friend WithEvents LBLNOMBREMARCA As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents lcategoria As System.Windows.Forms.ListBox
    Friend WithEvents lblcodigocategoria As System.Windows.Forms.Label
    Friend WithEvents lblcategoria As System.Windows.Forms.Label
    Friend WithEvents Cmbunidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblunidad As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PRODUCTOS))
        Me.DGBPRODUCTO = New System.Windows.Forms.GroupBox
        Me.Cmbunidad = New System.Windows.Forms.ComboBox
        Me.LMARCA = New System.Windows.Forms.ListBox
        Me.txtcategoria = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbltotal_unidades = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdesc_producto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtmarca = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblcodigocategoria = New System.Windows.Forms.Label
        Me.lblcategoria = New System.Windows.Forms.Label
        Me.LBLCOD_MARCA = New System.Windows.Forms.Label
        Me.LBLNOMBREMARCA = New System.Windows.Forms.Label
        Me.LBLCOD = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lcategoria = New System.Windows.Forms.ListBox
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNEDITAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNACTUALIZAR = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblcantidad_productos = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblunidad = New System.Windows.Forms.Label
        Me.DGBPRODUCTO.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGBPRODUCTO
        '
        Me.DGBPRODUCTO.BackColor = System.Drawing.SystemColors.Control
        Me.DGBPRODUCTO.Controls.Add(Me.Cmbunidad)
        Me.DGBPRODUCTO.Controls.Add(Me.LMARCA)
        Me.DGBPRODUCTO.Controls.Add(Me.txtcategoria)
        Me.DGBPRODUCTO.Controls.Add(Me.Label13)
        Me.DGBPRODUCTO.Controls.Add(Me.lbltotal_unidades)
        Me.DGBPRODUCTO.Controls.Add(Me.Label5)
        Me.DGBPRODUCTO.Controls.Add(Me.txtdesc_producto)
        Me.DGBPRODUCTO.Controls.Add(Me.Label3)
        Me.DGBPRODUCTO.Controls.Add(Me.Label2)
        Me.DGBPRODUCTO.Controls.Add(Me.txtprecio)
        Me.DGBPRODUCTO.Controls.Add(Me.Label8)
        Me.DGBPRODUCTO.Controls.Add(Me.TextBox2)
        Me.DGBPRODUCTO.Controls.Add(Me.Label11)
        Me.DGBPRODUCTO.Controls.Add(Me.txtmarca)
        Me.DGBPRODUCTO.Controls.Add(Me.Label4)
        Me.DGBPRODUCTO.Controls.Add(Me.TextBox1)
        Me.DGBPRODUCTO.Controls.Add(Me.lblcodigocategoria)
        Me.DGBPRODUCTO.Controls.Add(Me.lblcategoria)
        Me.DGBPRODUCTO.Controls.Add(Me.LBLCOD_MARCA)
        Me.DGBPRODUCTO.Controls.Add(Me.LBLNOMBREMARCA)
        Me.DGBPRODUCTO.Controls.Add(Me.LBLCOD)
        Me.DGBPRODUCTO.Controls.Add(Me.Label10)
        Me.DGBPRODUCTO.Controls.Add(Me.Label9)
        Me.DGBPRODUCTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.DGBPRODUCTO.Location = New System.Drawing.Point(32, 16)
        Me.DGBPRODUCTO.Name = "DGBPRODUCTO"
        Me.DGBPRODUCTO.Size = New System.Drawing.Size(424, 256)
        Me.DGBPRODUCTO.TabIndex = 1
        Me.DGBPRODUCTO.TabStop = False
        Me.DGBPRODUCTO.Text = "DATOS DEL PRODUCTO "
        '
        'Cmbunidad
        '
        Me.Cmbunidad.Location = New System.Drawing.Point(128, 96)
        Me.Cmbunidad.Name = "Cmbunidad"
        Me.Cmbunidad.Size = New System.Drawing.Size(104, 21)
        Me.Cmbunidad.TabIndex = 37
        '
        'LMARCA
        '
        Me.LMARCA.Location = New System.Drawing.Point(128, 200)
        Me.LMARCA.Name = "LMARCA"
        Me.LMARCA.Size = New System.Drawing.Size(272, 30)
        Me.LMARCA.TabIndex = 16
        '
        'txtcategoria
        '
        Me.txtcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtcategoria.Location = New System.Drawing.Point(128, 216)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(272, 20)
        Me.txtcategoria.TabIndex = 33
        Me.txtcategoria.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 24)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Categoría"
        '
        'lbltotal_unidades
        '
        Me.lbltotal_unidades.Location = New System.Drawing.Point(408, 136)
        Me.lbltotal_unidades.Name = "lbltotal_unidades"
        Me.lbltotal_unidades.Size = New System.Drawing.Size(8, 24)
        Me.lbltotal_unidades.TabIndex = 31
        Me.lbltotal_unidades.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Unidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdesc_producto
        '
        Me.txtdesc_producto.Location = New System.Drawing.Point(128, 56)
        Me.txtdesc_producto.Name = "txtdesc_producto"
        Me.txtdesc_producto.Size = New System.Drawing.Size(272, 20)
        Me.txtdesc_producto.TabIndex = 5
        Me.txtdesc_producto.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Unitario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(344, 96)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(56, 20)
        Me.txtprecio.TabIndex = 1
        Me.txtprecio.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Stock Mínimo (Unid.)"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(216, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 23)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Stock Máximo (Unid.)"
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(128, 176)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(272, 20)
        Me.txtmarca.TabIndex = 2
        Me.txtmarca.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Marca"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(344, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = ""
        '
        'lblcodigocategoria
        '
        Me.lblcodigocategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigocategoria.Location = New System.Drawing.Point(328, 232)
        Me.lblcodigocategoria.Name = "lblcodigocategoria"
        Me.lblcodigocategoria.Size = New System.Drawing.Size(24, 23)
        Me.lblcodigocategoria.TabIndex = 35
        Me.lblcodigocategoria.Visible = False
        '
        'lblcategoria
        '
        Me.lblcategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcategoria.Location = New System.Drawing.Point(352, 176)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(24, 16)
        Me.lblcategoria.TabIndex = 36
        Me.lblcategoria.Visible = False
        '
        'LBLCOD_MARCA
        '
        Me.LBLCOD_MARCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCOD_MARCA.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LBLCOD_MARCA.Location = New System.Drawing.Point(328, 176)
        Me.LBLCOD_MARCA.Name = "LBLCOD_MARCA"
        Me.LBLCOD_MARCA.Size = New System.Drawing.Size(24, 16)
        Me.LBLCOD_MARCA.TabIndex = 17
        Me.LBLCOD_MARCA.Visible = False
        '
        'LBLNOMBREMARCA
        '
        Me.LBLNOMBREMARCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNOMBREMARCA.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LBLNOMBREMARCA.Location = New System.Drawing.Point(328, 200)
        Me.LBLNOMBREMARCA.Name = "LBLNOMBREMARCA"
        Me.LBLNOMBREMARCA.Size = New System.Drawing.Size(24, 24)
        Me.LBLNOMBREMARCA.TabIndex = 19
        Me.LBLNOMBREMARCA.Visible = False
        '
        'LBLCOD
        '
        Me.LBLCOD.Location = New System.Drawing.Point(360, 216)
        Me.LBLCOD.Name = "LBLCOD"
        Me.LBLCOD.TabIndex = 13
        Me.LBLCOD.Visible = False
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(128, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(272, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lcategoria
        '
        Me.lcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcategoria.Location = New System.Drawing.Point(160, 264)
        Me.lcategoria.Name = "lcategoria"
        Me.lcategoria.Size = New System.Drawing.Size(272, 43)
        Me.lcategoria.TabIndex = 34
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(384, 384)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(8, 8)
        Me.LBLVENTAS.TabIndex = 16
        Me.LBLVENTAS.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 39)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "&Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNEDITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Image = CType(resources.GetObject("BTNEDITAR.Image"), System.Drawing.Image)
        Me.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNEDITAR.Location = New System.Drawing.Point(8, 8)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(96, 39)
        Me.BTNEDITAR.TabIndex = 30
        Me.BTNEDITAR.Text = "&Buscar"
        Me.BTNEDITAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 168)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 39)
        Me.BTNCANCELAR.TabIndex = 29
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(8, 208)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 39)
        Me.BTNRETORNAR.TabIndex = 32
        Me.BTNRETORNAR.Text = "&Salir"
        Me.BTNRETORNAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAGREGAR.Location = New System.Drawing.Point(8, 88)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 39)
        Me.BTNAGREGAR.TabIndex = 27
        Me.BTNAGREGAR.Text = "&Grabar"
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNACTUALIZAR
        '
        Me.BTNACTUALIZAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNACTUALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNACTUALIZAR.Image = CType(resources.GetObject("BTNACTUALIZAR.Image"), System.Drawing.Image)
        Me.BTNACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACTUALIZAR.Location = New System.Drawing.Point(8, 128)
        Me.BTNACTUALIZAR.Name = "BTNACTUALIZAR"
        Me.BTNACTUALIZAR.Size = New System.Drawing.Size(96, 39)
        Me.BTNACTUALIZAR.TabIndex = 28
        Me.BTNACTUALIZAR.Text = "&Editar"
        Me.BTNACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(32, 280)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 150
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.Size = New System.Drawing.Size(552, 216)
        Me.DataGrid1.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Total de Productos"
        '
        'lblcantidad_productos
        '
        Me.lblcantidad_productos.Location = New System.Drawing.Point(520, 504)
        Me.lblcantidad_productos.Name = "lblcantidad_productos"
        Me.lblcantidad_productos.Size = New System.Drawing.Size(64, 23)
        Me.lblcantidad_productos.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BTNEDITAR)
        Me.GroupBox2.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox2.Controls.Add(Me.BTNACTUALIZAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox2.Location = New System.Drawing.Point(472, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 256)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'lblunidad
        '
        Me.lblunidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblunidad.Location = New System.Drawing.Point(8, 200)
        Me.lblunidad.Name = "lblunidad"
        Me.lblunidad.Size = New System.Drawing.Size(8, 23)
        Me.lblunidad.TabIndex = 43
        Me.lblunidad.Visible = False
        '
        'PRODUCTOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(616, 534)
        Me.Controls.Add(Me.lblunidad)
        Me.Controls.Add(Me.lcategoria)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblcantidad_productos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.DGBPRODUCTO)
        Me.Controls.Add(Me.LBLVENTAS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PRODUCTOS"
        Me.Text = "Mnatenimiento Productos"
        Me.DGBPRODUCTO.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dt1 As DataTable
    'para marca
    Private da1 As SqlDataAdapter
    Private seleccion As String = "SELECT DESCRIPCION FROM MARCA"
    Private INICIANDO As Boolean = True
    'para cargar el datagrid
    Private dt5 As DataTable
    Private da5 As SqlDataAdapter
    Private seleccion5 As String = "SELECT p.pro_codigo as Codigo,pro_descripcion as Descripcion, pro_precio as Precio,convert(varchar(10),pro_stock)+'    '+ u.abreviatura as Stock from producto p inner join stock s on s.pro_codigo=p.pro_codigo inner join unidad u on u.cod_unidad=p.cod_unidad"
    'para categoria
    Private dt2 As DataTable
    Private da2 As SqlDataAdapter
    Private seleccion2 As String = "SELECT DESCRIPCION FROM categorias"
    Private INICIANDO2 As Boolean = True
    Sub LLENARCOMBO()
        cn.Open()
        Me.Cmbunidad.ResetText()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select nombre From unidad order by nombre", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.Cmbunidad.Items.Add(datRead.Item(0))
        End While
        datRead.Close()
        cn.Close()
    End Sub
    Private Sub PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrilla()
        Me.BTNAGREGAR.Enabled = False
        contar()
        Me.LMARCA.Visible = False
        Me.lcategoria.Visible = False
        'CARGAMOS MARCA
        Me.txtmarca.Text = ""
        da1 = New SqlDataAdapter(seleccion, cn)
        dt1 = New DataTable
        da1.Fill(dt1)
        INICIANDO = False
        'cargamos(categoria)
        Me.txtcategoria.Text = ""
        da2 = New SqlDataAdapter(seleccion2, cn)
        dt2 = New DataTable
        da2.Fill(dt2)
        LLENARCOMBO()
        INICIANDO2 = False
        Me.DGBPRODUCTO.Enabled = False
        Me.LMARCA.Visible = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
    End Sub
    Sub llenargrilla()
        da5 = New SqlDataAdapter(seleccion5, cn)
        dt5 = New DataTable
        da5.Fill(dt5)
        Me.DataGrid1.DataSource = dt5

    End Sub
    Sub contar()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*) from PRODUCTO"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.lblcantidad_productos.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Sub LIMPIAR()
        Me.txtdesc_producto.Text = ""
        Me.txtmarca.Text = ""
        Me.txtprecio.Text = ""
        Me.Cmbunidad.Text = ""
        Me.LMARCA.Items.Clear()
        Me.LBLCOD_MARCA.Text = ""
        Me.LBLNOMBREMARCA.Text = ""
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.txtcategoria.ResetText()
        Me.Label10.ResetText()
        cn.Close()

    End Sub
    Private Sub BTNEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEDITAR.Click
        'Me.GroupBox1.Visible = True
        Dim B As New Buscar_Producto
        B.ShowDialog()
        If cproducto = "" Then
            Me.BTNEDITAR.Enabled = True
            Me.BTNACTUALIZAR.Enabled = False
            nproducto = ""
            cproducto = ""
        Else
            Me.Label10.Text = cproducto
            Me.BTNCANCELAR.Enabled = True
            cproducto = ""
            nproducto = ""
            Me.Button1.Enabled = False
            Me.BTNEDITAR.Enabled = False
            Me.BTNAGREGAR.Enabled = False
            llena()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DGBPRODUCTO.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = False
        Me.Button1.Enabled = False
        Me.BTNRETORNAR.Enabled = False
        Me.BTNCANCELAR.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        LIMPIAR()
        GENERAR()
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
            Case 13
                SoloNumeros = Keyascii
            Case 46
                SoloNumeros = Keyascii
        End Select
    End Function
    Private Sub cmbunidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub TXTSTOCK_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarca.TextChanged
        If INICIANDO Then Exit Sub

        ' Buscar en el DataTable usando el método Select
        ' que es como un filtro WHERE en una cadena de selección.

        ' El resultado se devuelve como un array de tipo DataRow
        Dim filas() As DataRow

        ' Si solo quieres mostrar los que empiecen por lo escrito.
        ' Al escribir "s" se buscarán los que empiecen por esa letra.
        filas = dt1.Select("DESCRIPCION LIKE '" & txtmarca.Text & "%'")

        ' Borrar los elementos anteriores
        Me.LMARCA.Items.Clear()

        ' Si hay datos, mostrar los apellidos
        If filas.Length > 0 Then

            ' Recorrer cada fila y mostrar los apellidos
            For Each dr As DataRow In filas

                Me.LMARCA.Items.Add( _
                            dr("DESCRIPCION").ToString)

            Next
            Me.LMARCA.Visible = True
        End If
    End Sub

    Private Sub LMARCA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMARCA.SelectedIndexChanged
        If INICIANDO Then Exit Sub
        '     Al hacer clic, mostrar el dato
        Me.txtmarca.Text = Me.LMARCA.SelectedItem.ToString
        Me.LBLNOMBREMARCA.Text = Me.txtmarca.Text
        Try
            Dim CONT As Integer
            cm.CommandText = "SELECT COD_MARCA FROM MARCA WHERE DESCRIPCION ='" + Me.LBLNOMBREMARCA.Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.LBLCOD_MARCA.Text = dr(0).ToString
                Loop
            Else
                MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
                cn.Close()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
        Me.LMARCA.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena()
    End Sub
    Sub llena()
        Dim i, j As Integer
        Try
            cm.CommandText = "Select P.PRO_CODIGO, PRO_DESCRIPCION, PRO_PRECIO,u.cod_UNIDAD,M.DESCRIPCION, P.cod_marca,S.PRO_STOCKMIN,S.PRO_STOCKMAX,c.descripcion,c.cod_categoria,nombre from PRODUCTO P INNER JOIN STOCK S ON P.PRO_CODIGO=S.PRO_CODIGO INNER JOIN MARCA M ON P.COD_MARCA=M.COD_MARCA inner join categorias c on c.cod_categoria=p.cod_categoria inner join unidad u on u.cod_unidad=p.cod_unidad WHERE P.PRO_codigo='" + Me.Label10.Text + "'"
            cm.Connection = cn
            cn.Open()
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    'Me.Label10.Text = dr(0).ToString
                    Me.txtdesc_producto.Text = dr(1).ToString
                    Me.txtprecio.Text = dr(2).ToString
                    Me.lblunidad.Text = dr(3).ToString
                    Me.txtmarca.Text = dr(4).ToString
                    Me.LBLCOD_MARCA.Text = dr(5).ToString
                    Me.TextBox2.Text = dr(6).ToString
                    Me.TextBox1.Text = dr(7).ToString
                    Me.txtcategoria.Text = dr(8).ToString
                    Me.LMARCA.Visible = False
                    Me.lblcodigocategoria.Text = dr(9).ToString
                    Me.Cmbunidad.Text = dr(10).ToString
                    Me.lcategoria.Visible = False
                    Me.DGBPRODUCTO.Enabled = True
                Loop
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        INABILITAR()
        Me.Button1.Enabled = False
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = False
        Me.BTNRETORNAR.Enabled = True
        Me.BTNACTUALIZAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True
        cn.Close()
    End Sub
    Sub INABILITAR()
        If Me.txtdesc_producto.Text = "" Then
            MsgBox("Error al ingresar datos verifique que el producto y la marca sean correctos", MsgBoxStyle.Critical)
            cancelar()
            Me.DGBPRODUCTO.Enabled = False
        Else
            Me.DGBPRODUCTO.Enabled = True
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        cancelar()

    End Sub
    Sub cancelar()
        Me.Button1.Enabled = True
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNRETORNAR.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        Me.DGBPRODUCTO.Enabled = False
        Me.lblunidad.ResetText()
        Me.LMARCA.Visible = False
        LIMPIAR()
        Me.LMARCA.Visible = False
        Me.lcategoria.Visible = False
    End Sub

    Private Sub BTNACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACTUALIZAR.Click
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE PRODUCTO SET PRO_DESCRIPCION='" + Me.txtdesc_producto.Text + " ',PRO_PRECIO= '" + Me.txtprecio.Text + "', cod_UNIDAD='" + Me.lblunidad.Text + " ', COD_MARCA='" + Me.LBLCOD_MARCA.Text + "', cod_categoria='" + Me.lblcodigocategoria.Text + "'WHERE PRO_CODIGO='" + Me.Label10.Text + "' "
            cm.Connection = cn
            a = cm.ExecuteNonQuery
            If a >= 1 Then
                MsgBox("Datos Actualizados", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE STOCK SET pro_stockmin='" + Me.TextBox2.Text + "', pro_stockmax='" + Me.TextBox1.Text + "'  WHERE PRO_CODIGO='" + Me.Label10.Text + "'"
            cm.Connection = cn
            a = cm.ExecuteNonQuery()
            If a >= 1 Then
                MsgBox("Datos Actualizados", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
        LIMPIAR()
        llenargrilla()
        Me.LMARCA.Visible = False
        Me.lcategoria.Visible = False
        cancelar()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Me.txtdesc_producto.Text = "" Or Me.Cmbunidad.Text = "" Or Me.txtprecio.Text = "" Or Me.TextBox2.Text = "" Or Me.TextBox1.Text = "" Or Me.LBLCOD_MARCA.Text = "" Then
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Information)
        Else
            If Val(Me.TextBox1.Text) < Val(Me.TextBox2.Text) Then
                MsgBox("El Stock máximo y mínimo son incorrectos", MsgBoxStyle.Critical)
            Else
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO PRODUCTO (PRO_codigo, PRO_DESCRIPCION, PRO_PRECIO, COD_MARCA,COD_CATEGORIA,cod_unidad) values ('" + Me.Label10.Text + "','" + Me.txtdesc_producto.Text + "','" + Me.txtprecio.Text + "','" + Me.LBLCOD_MARCA.Text + "','" + Me.lblcodigocategoria.Text + "','" + Me.lblunidad.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        'MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO stock(PRO_codigo, PRO_stockmin, PRO_stockmax,pro_stock) values ('" + Me.Label10.Text + "','" + Me.TextBox2.Text + "','" + Me.TextBox1.Text + "','0')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        MsgBox("Datos Guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            Me.BTNRETORNAR.Enabled = True
            LIMPIAR()
            cn.Close()
            cancelar()
        End If
        contar()
        llenargrilla()
    End Sub
    Sub GENERAR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from PRODUCTO"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.Label10.Text = "PR0" + CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Sub GENERARMARCA()
    '    Try
    '        Dim datar As SqlClient.SqlDataReader
    '        cn.Open()
    '        cm.Connection = cn
    '        cm.CommandText = "select count(*)+1 from MARCA"
    '        cm.CommandType = CommandType.Text
    '        datar = cm.ExecuteReader
    '        If datar.HasRows Then
    '            While datar.Read
    '                Me.LBLCOD_MARCA.Text = CStr(datar(0))
    '            End While
    '        End If
    '        datar.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        cn.Close()
    '    End Try
    '    cn.Close()
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "Insert INTO MARCA (COD_MARCA,DESCRIPCION) values ('" + Me.LBLCOD_MARCA.Text + "','" + Me.txtmarca.Text + "')"
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
        cn.Close()
    End Sub
    Private Sub txtmarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        Me.LMARCA.Visible = True
    End Sub

    Private Sub txtcategoria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcategoria.TextChanged
        If INICIANDO2 Then Exit Sub

        ' Buscar en el DataTable usando el método Select
        ' que es como un filtro WHERE en una cadena de selección.

        ' El resultado se devuelve como un array de tipo DataRow
        Dim filas() As DataRow

        ' Si solo quieres mostrar los que empiecen por lo escrito.
        ' Al escribir "s" se buscarán los que empiecen por esa letra.
        filas = dt2.Select("DESCRIPCION LIKE '" & txtcategoria.Text & "%'")

        ' Borrar los elementos anteriores
        Me.lcategoria.Items.Clear()

        ' Si hay datos, mostrar los apellidos
        If filas.Length > 0 Then

            ' Recorrer cada fila y mostrar los apellidos
            For Each dr As DataRow In filas

                Me.lcategoria.Items.Add( _
                            dr("DESCRIPCION").ToString)

            Next
            Me.lcategoria.Visible = True
        End If
    End Sub

    Private Sub lcategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lcategoria.SelectedIndexChanged
        If INICIANDO2 Then Exit Sub
        '     Al hacer clic, mostrar el dato
        Me.txtcategoria.Text = Me.lcategoria.SelectedItem.ToString
        Me.lblcategoria.Text = Me.txtcategoria.Text
        Try
            Dim CONT As Integer
            cm.CommandText = "SELECT COD_categoria FROM categorias WHERE DESCRIPCION ='" + Me.lblcategoria.Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.lblcodigocategoria.Text = dr(0).ToString
                Loop
            Else
                MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
                cn.Close()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
        Me.lcategoria.Visible = False
    End Sub

    Private Sub txtcategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcategoria.KeyPress
        Me.lcategoria.Visible = True
    End Sub

    Private Sub Cmbunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbunidad.SelectedIndexChanged
        cn.Open()
        Dim datARead As SqlDataReader
        cm = New SqlCommand("Select cod_unidad From unidad WHERE nombre ='" + Me.Cmbunidad.Text + "'", cn)
        datARead = cm.ExecuteReader
        While datARead.Read()
            Me.lblunidad.Text = datARead(0).ToString
        End While
        cn.Close()
    End Sub
End Class
