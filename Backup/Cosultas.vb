Imports System.Data.SqlClient
Public Class Cosultas
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents LBL_COD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_PRODUCTO As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcodigoventa As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Cosultas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.LBL_COD_CLIENTE = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.LBLCOD_PRODUCTO = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.lblcodigoventa = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(496, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Fecha"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(276, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Clientes"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(56, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.LBL_COD_CLIENTE)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 136)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(120, 56)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(544, 72)
        Me.ListView2.TabIndex = 42
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre y Apellidos"
        Me.ColumnHeader7.Width = 374
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DNI"
        Me.ColumnHeader8.Width = 105
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(120, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 24)
        Me.Label3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "DNI"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 8)
        Me.Label8.TabIndex = 15
        Me.Label8.Visible = False
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(16, 24)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(80, 24)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Apellidos"
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(120, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(544, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'LBL_COD_CLIENTE
        '
        Me.LBL_COD_CLIENTE.Location = New System.Drawing.Point(536, 24)
        Me.LBL_COD_CLIENTE.Name = "LBL_COD_CLIENTE"
        Me.LBL_COD_CLIENTE.Size = New System.Drawing.Size(40, 23)
        Me.LBL_COD_CLIENTE.TabIndex = 31
        Me.LBL_COD_CLIENTE.Text = "Label1"
        Me.LBL_COD_CLIENTE.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Buscar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.ListView3)
        Me.GroupBox3.Controls.Add(Me.LBLCOD_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 144)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'ListView3
        '
        Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader9})
        Me.ListView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(136, 56)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(528, 80)
        Me.ListView3.TabIndex = 44
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Código"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre"
        Me.ColumnHeader5.Width = 294
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Dni"
        Me.ColumnHeader9.Width = 173
        '
        'LBLCOD_PRODUCTO
        '
        Me.LBLCOD_PRODUCTO.Location = New System.Drawing.Point(16, 64)
        Me.LBLCOD_PRODUCTO.Name = "LBLCOD_PRODUCTO"
        Me.LBLCOD_PRODUCTO.TabIndex = 37
        Me.LBLCOD_PRODUCTO.Text = "Label2"
        Me.LBLCOD_PRODUCTO.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(-24, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 8)
        Me.Label14.TabIndex = 34
        Me.Label14.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 8)
        Me.Label10.TabIndex = 15
        Me.Label10.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(536, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(40, 32)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(8, 8)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLVENTAS.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(72, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 8)
        Me.Label1.TabIndex = 16
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(24, 256)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(800, 216)
        Me.ListView1.TabIndex = 31
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod_VENTA"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cliente"
        Me.ColumnHeader2.Width = 242
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total"
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Fecha"
        Me.ColumnHeader11.Width = 148
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Estado"
        Me.ColumnHeader12.Width = 92
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Comprobante"
        Me.ColumnHeader13.Width = 143
        '
        'lblcodigoventa
        '
        Me.lblcodigoventa.Location = New System.Drawing.Point(632, 8)
        Me.lblcodigoventa.Name = "lblcodigoventa"
        Me.lblcodigoventa.Size = New System.Drawing.Size(48, 16)
        Me.lblcodigoventa.TabIndex = 33
        Me.lblcodigoventa.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ver detalle"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Location = New System.Drawing.Point(720, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 208)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(8, 152)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(88, 40)
        Me.BTNRETORNAR.TabIndex = 39
        Me.BTNRETORNAR.Text = "&Salir"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 96)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(680, 144)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fechas"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(384, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "&Al"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "&Del"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(432, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Cosultas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(848, 502)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblcodigoventa)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cosultas"
        Me.Text = "Detalle Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cosultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTAPELLIDOS.Text = ""
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = False
        Me.TextBox3.Text = ""
    End Sub
    Sub limpiar()
        Me.TXTAPELLIDOS.ResetText()
        Me.TextBox3.ResetText()
        Me.Label3.ResetText()
    End Sub
    Sub LLENARLISTA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT V.V_CODIGO AS CODIGO_VENTA,c.cl_nombres+' '+c.cl_apellidos,TOTAL,CONVERT(CHAR(10),V_FECHA,103)AS FECHA,estado,tc.descripcion FROM VENTAS V inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante tc on tc.cod_tc=cv.cod_tc inner join clientes c on c.cl_codigo=v.cl_codigo inner join personal p on p.pe_codigo=v.pe_codigo WHERE p.pe_CODIGO='" + Me.LBLCOD_PRODUCTO.Text + "' order by v_fecha"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(4).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(5).ToString))
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
    Sub LLENARLISTA1()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT V.V_CODIGO AS CODIGO_VENTA,c.cl_nombres+' '+c.cl_apellidos,TOTAL,CONVERT(CHAR(10),V_FECHA,103)AS FECHA,estado,tc.descripcion FROM VENTAS V inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante tc on tc.cod_tc=cv.cod_tc inner join clientes c on c.cl_codigo=v.cl_codigo inner join personal p on p.pe_codigo=v.pe_codigo WHERE C.CL_CODIGO='" + Me.LBL_COD_CLIENTE.Text + "' order by v_fecha"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(4).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(5).ToString))
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
    Sub LLENARLISTA3()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT V.V_CODIGO AS CODIGO_VENTA,c.cl_nombres+' '+c.cl_apellidos,TOTAL,CONVERT(CHAR(10),V_FECHA,103)AS FECHA,estado,tc.descripcion FROM VENTAS V inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante tc on tc.cod_tc=cv.cod_tc inner join clientes c on c.cl_codigo=v.cl_codigo  WHERE v.v_fecha>='" + Me.DateTimePicker1.Value.Date() + "'AND V.V_FECHA<='" + Me.DateTimePicker2.Value.Date() + "'order by v_fecha"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(4).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(5).ToString))
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
            cm.CommandText = " SELECT cl_CODIGO, cl_apellidos+' '+cl_nombres,cl_dni FROM clientes WHERE cl_apellidos+' '+cl_nombres LIKE'%" & TXTAPELLIDOS.Text & "%'"
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

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = False
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False
        limpiar()
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox5.Visible = False
        Me.GroupBox3.Visible = True
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False
        limpiar()
        Me.ListView1.Items.Clear()
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView3.Visible = True

        Try
            Me.ListView3.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT Pe_CODIGO,Pe_nombre+' '+pe_apellido,dni FROM Personal where pe_nombre+' '+pe_apellido LIKE'%" & TextBox3.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView3.Items.Add(CStr((datar(0))), 1)
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(2).ToString))
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False
        If Me.RadioButton1.Checked Then
            Me.ListView1.Items.Clear()
            LLENARLISTA()
        Else
            If Me.RadioButton2.Checked Then
                Me.ListView1.Items.Clear()
                LLENARLISTA1()
            Else
                If Me.RadioButton3.Checked Then
                    Me.ListView1.Items.Clear()
                    LLENARLISTA3()
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigoventa.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ventas = Me.lblcodigoventa.Text
        Dim M As New DETALLE_VENTA
        M.ShowDialog()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged


    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = True
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False
        Me.ListView1.Items.Clear()
        limpiar()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBL_COD_CLIENTE.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.Label3.Text = Me.ListView2.SelectedItems(0).SubItems(2).Text
            Me.ListView2.Visible = False
        End If
    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBLCOD_PRODUCTO.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.ListView3.Visible = False
        End If
    End Sub

    Private Sub TXTAPELLIDOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TextChanged

    End Sub
End Class
