Public Class Consulta_Facturas
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLCOD_PRODUCTO As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents LBL_COD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents LISTAAPELLIDOS As System.Windows.Forms.ListBox
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consulta_Facturas))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LBLCOD_PRODUCTO = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.Label8 = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.LBL_COD_CLIENTE = New System.Windows.Forms.Label
        Me.LISTAAPELLIDOS = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(648, 136)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fechas"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(384, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Al"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Del"
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.LBLCOD_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 136)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'LBLCOD_PRODUCTO
        '
        Me.LBLCOD_PRODUCTO.Location = New System.Drawing.Point(16, 80)
        Me.LBLCOD_PRODUCTO.Name = "LBLCOD_PRODUCTO"
        Me.LBLCOD_PRODUCTO.Size = New System.Drawing.Size(64, 23)
        Me.LBLCOD_PRODUCTO.TabIndex = 37
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
        Me.TextBox3.Location = New System.Drawing.Point(120, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(512, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Personal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(40, 32)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(8, 8)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(64, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 8)
        Me.Label1.TabIndex = 16
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(120, 48)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(512, 88)
        Me.ListView2.TabIndex = 44
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Código"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre"
        Me.ColumnHeader6.Width = 237
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Dni"
        Me.ColumnHeader7.Width = 156
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(664, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 200)
        Me.GroupBox4.TabIndex = 44
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
        Me.BTNRETORNAR.TabIndex = 38
        Me.BTNRETORNAR.Text = "&Salir"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Buscar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ver detalle"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Location = New System.Drawing.Point(632, -8)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(32, 23)
        Me.lblcodigo.TabIndex = 37
        Me.lblcodigo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.ListView3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.LBL_COD_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.LISTAAPELLIDOS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 136)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(120, 48)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(520, 80)
        Me.ListView3.TabIndex = 32
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Código"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Descripción"
        Me.ColumnHeader10.Width = 170
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Ruc"
        Me.ColumnHeader11.Width = 103
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Dirección"
        Me.ColumnHeader12.Width = 180
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
        Me.LDAPELLEDIS.Text = "Proveedor"
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(120, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(520, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'LBL_COD_CLIENTE
        '
        Me.LBL_COD_CLIENTE.Location = New System.Drawing.Point(592, 24)
        Me.LBL_COD_CLIENTE.Name = "LBL_COD_CLIENTE"
        Me.LBL_COD_CLIENTE.Size = New System.Drawing.Size(40, 23)
        Me.LBL_COD_CLIENTE.TabIndex = 31
        Me.LBL_COD_CLIENTE.Text = "Label1"
        Me.LBL_COD_CLIENTE.Visible = False
        '
        'LISTAAPELLIDOS
        '
        Me.LISTAAPELLIDOS.Location = New System.Drawing.Point(88, 48)
        Me.LISTAAPELLIDOS.Name = "LISTAAPELLIDOS"
        Me.LISTAAPELLIDOS.Size = New System.Drawing.Size(8, 43)
        Me.LISTAAPELLIDOS.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 64)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(520, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Fecha"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(276, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Proveedores"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(56, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Personal"
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(8, 232)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 264)
        Me.ListView1.TabIndex = 37
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod_Compra"
        Me.ColumnHeader1.Width = 74
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Factura"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha"
        Me.ColumnHeader3.Width = 111
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Importe"
        Me.ColumnHeader5.Width = 67
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Personal"
        Me.ColumnHeader13.Width = 232
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Proveedor"
        Me.ColumnHeader14.Width = 189
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(8, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "&Agregar Guia Remisión"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Consulta_Facturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(776, 518)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Consulta_Facturas"
        Me.Text = "Detalle Facturas"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Consulta_Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TXTAPELLIDOS.Text = ""
        Me.LISTAAPELLIDOS.Visible = False
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = False
        Me.TextBox3.Text = ""
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False

    End Sub
    Sub LLENARLISTA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select cm.c_codigo, codigo_factura,convert(varchar(10),c_fecha,103)as fecha,total,pe_nombre+' '+pe_apellido,pv_descripcion from comprobantes c inner join facturas b on b.codigo_comprobante=c.codigo_comprobante inner join compras cm on cm.codigo_comprobante=c.codigo_comprobante inner join proveedor pv on pv.pv_codigo=cm.pv_codigo inner join personal p on p.pe_codigo=c.pe_codigo where p.pe_codigo='" + Me.LBLCOD_PRODUCTO.Text + "'order by c_fecha"
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
            cm.CommandText = "select cm.c_codigo, codigo_factura,convert(varchar(10),c_fecha,103)as fecha,total,pe_nombre+' '+pe_apellido,pv_descripcion from comprobantes c inner join facturas b on b.codigo_comprobante=c.codigo_comprobante inner join compras cm on cm.codigo_comprobante=c.codigo_comprobante inner join proveedor pv on pv.pv_codigo=cm.pv_codigo inner join personal p on p.pe_codigo=c.pe_codigo   where pv.pv_codigo='" + Me.LBL_COD_CLIENTE.Text + "'order by c_fecha "
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
            cm.CommandText = "select cm.c_codigo, codigo_factura,convert(varchar(10),c_fecha,103)as fecha,total,pe_nombre+' '+pe_apellido,pv_descripcion from comprobantes c inner join facturas b on b.codigo_comprobante=c.codigo_comprobante inner join compras cm on cm.codigo_comprobante=c.codigo_comprobante inner join proveedor pv on pv.pv_codigo=cm.pv_codigo inner join personal p on p.pe_codigo=c.pe_codigo   where c_fecha>='" + Me.DateTimePicker1.Value.Date() + "'and c_fecha<='" + Me.DateTimePicker2.Value.Date + "'order by c_fecha"
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
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = True
        Me.GroupBox5.Visible = False
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = False
        Me.ListView1.Items.Clear()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView2.Visible = True

        Try
            Me.ListView2.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT Pe_CODIGO, Pe_nombre+''+pe_apellido, dni FROM Personal  WHERE Pe_nombre+' '+pe_apellido LIKE'%" & TextBox3.Text & "%'"
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
        Me.ListView2.Visible = False
        Me.ListView3.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        COMPROBANTE1 = Me.lblcodigo.Text
        Dim C As New DETALLE_FACTURA
        C.ShowDialog()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigo.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.GroupBox5.Visible = True
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBLCOD_PRODUCTO.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.ListView2.Visible = False
        End If
    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBL_COD_CLIENTE.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.ListView3.Visible = False
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigo.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim RC As New Registro_de_compras
        RC.Label28.Text = "1"
        If Me.ListView1.SelectedItems.Count > 0 Then
            RC.LBLCOMPRA.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            RC.TextBox5.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            RC.TXTAPELLIDOS.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
            RC.ShowDialog()
        End If

    End Sub
End Class
