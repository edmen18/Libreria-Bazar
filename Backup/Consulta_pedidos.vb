Imports System.Data.SqlClient
Public Class Consulta_pedidos
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
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LABELNOMBRE As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consulta_pedidos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LBLCOD_CLIENTE = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LABELNOMBRE = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 64)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(232, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "Estado"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(392, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Fecha"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(88, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Empresa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.LBLCOD_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LABELNOMBRE)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 112)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'LBLCOD_CLIENTE
        '
        Me.LBLCOD_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCOD_CLIENTE.Location = New System.Drawing.Point(48, 48)
        Me.LBLCOD_CLIENTE.Name = "LBLCOD_CLIENTE"
        Me.LBLCOD_CLIENTE.Size = New System.Drawing.Size(48, 24)
        Me.LBLCOD_CLIENTE.TabIndex = 13
        Me.LBLCOD_CLIENTE.Visible = False
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(8, 24)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(72, 20)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Razón Social"
        Me.LDAPELLEDIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(96, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(456, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(48, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(8, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Visible = False
        '
        'LABELNOMBRE
        '
        Me.LABELNOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LABELNOMBRE.Enabled = False
        Me.LABELNOMBRE.Location = New System.Drawing.Point(40, 72)
        Me.LABELNOMBRE.Name = "LABELNOMBRE"
        Me.LABELNOMBRE.Size = New System.Drawing.Size(8, 8)
        Me.LABELNOMBRE.TabIndex = 29
        Me.LABELNOMBRE.Visible = False
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(24, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 112)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese un rango de fechas"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Del"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(304, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "&Al"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(360, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 7
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 200)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(680, 192)
        Me.ListView1.TabIndex = 55
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pedido"
        Me.ColumnHeader1.Width = 98
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Orden de Salida"
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Empresa"
        Me.ColumnHeader3.Width = 257
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Estado"
        Me.ColumnHeader9.Width = 113
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.lblcodigo)
        Me.GroupBox4.Location = New System.Drawing.Point(592, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 168)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(8, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "&Modificar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 24)
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
        Me.Button1.Location = New System.Drawing.Point(8, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ver detalle"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Location = New System.Drawing.Point(40, 32)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(32, 23)
        Me.lblcodigo.TabIndex = 37
        Me.lblcodigo.Visible = False
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader5})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(112, 120)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(456, 88)
        Me.ListView2.TabIndex = 60
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        Me.ColumnHeader6.Width = 52
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Descripción"
        Me.ColumnHeader7.Width = 202
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Telefono"
        Me.ColumnHeader8.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dirección"
        Me.ColumnHeader5.Width = 103
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.RadioButton7)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(568, 112)
        Me.GroupBox5.TabIndex = 61
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Seleccione una opción"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(264, 44)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 16)
        Me.RadioButton4.TabIndex = 16
        Me.RadioButton4.Text = "Pedidos Atendidos"
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(128, 44)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton5.TabIndex = 15
        Me.RadioButton5.Text = "Pedidos Pendientes"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(408, 44)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(136, 16)
        Me.RadioButton6.TabIndex = 14
        Me.RadioButton6.Text = "Pedidos Anulados"
        '
        'RadioButton7
        '
        Me.RadioButton7.Location = New System.Drawing.Point(8, 44)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(120, 16)
        Me.RadioButton7.TabIndex = 13
        Me.RadioButton7.Text = "Todos los pedidos"
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(600, 128)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(88, 40)
        Me.BTNRETORNAR.TabIndex = 62
        Me.BTNRETORNAR.Text = "&Salir"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Info
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(8, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 40)
        Me.Button6.TabIndex = 68
        Me.Button6.Text = "Agregar Pedido"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Location = New System.Drawing.Point(704, 200)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(104, 152)
        Me.GroupBox6.TabIndex = 69
        Me.GroupBox6.TabStop = False
        '
        'Consulta_pedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(832, 406)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BTNRETORNAR)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consulta_pedidos"
        Me.Text = "Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dat As DataTable
    Private dta As SqlDataAdapter
    Private seleccion As String = "SELECT razon_empresa FROM empresas_pedidos"
    Private iniciando As Boolean = True
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.RadioButton2.Checked Then
            Me.RadioButton4.Checked = False
            Me.RadioButton5.Checked = False
            Me.RadioButton6.Checked = False
            Me.RadioButton7.Checked = False
            Me.ListView1.Items.Clear()
            LLENARLISTA1()
        End If
        If Me.RadioButton3.Checked Then
            Me.RadioButton4.Checked = False
            Me.RadioButton5.Checked = False
            Me.RadioButton6.Checked = False
            Me.RadioButton7.Checked = False
            Me.ListView1.Items.Clear()
            LLENARLISTA2()
        End If
        If Me.RadioButton7.Checked Then
            Me.ListView1.Items.Clear()
            LLENARLISTAtodos()
        End If
        If Me.RadioButton5.Checked Then
            Me.ListView1.Items.Clear()
            LLENARLISTApendientes()
        End If
        If Me.RadioButton4.Checked Then
            Me.ListView1.Items.Clear()
            LLENARLISTAatendidos()
        End If
        If Me.RadioButton6.Checked Then
            Me.ListView1.Items.Clear()
            LLENARLISTAanulados()
        End If
    End Sub
    Sub LLENARLISTA1()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select P.ped_codigo, os.cod_ordensalida,razon_empresa,convert(char(10),ped_fecha,103),Estado from pedidos p inner join DETALLE_ORDEN os on p.PED_CODIGO=os.PED_CODIGO inner join empresas_pedidos ep on ep.cod_empresa=p.cod_empresa Where ep.cod_empresa='" + Me.LBLCOD_CLIENTE.Text + "'and razon_empresa='" + Me.Label8.Text + "'"
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
    Sub LLENARLISTA2()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select P.ped_codigo, os.cod_ordensalida,razon_empresa,convert(char(10),ped_fecha,103),Estado from pedidos p inner join DETALLE_ORDEN os on p.PED_CODIGO=os.PED_CODIGO inner join empresas_pedidos ep on ep.cod_empresa=p.cod_empresa where PED_FECHA>='" + Me.DateTimePicker1.Value.Date + "' AND PED_FECHA<='" + Me.DateTimePicker2.Value.Date + "'ORDER BY PED_FECHA "
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
    Sub LLENARLISTAtodos()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select PE.PED_CODIGO,COD_ORDENSALIDA,razon_empresa,convert(varchar(10),PED_FECHA,103)as fecha,Estado from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa INNER JOIN DETALLE_ORDEN DO ON DO.PED_CODIGO=PE.PED_CODIGO order by ped_fecha"
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
    Sub LLENARLISTApendientes()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select PE.PED_CODIGO,COD_ORDENSALIDA,razon_empresa,convert(varchar(10),PED_FECHA,103)as  fecha,Estado from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa INNER JOIN DETALLE_ORDEN DO ON DO.PED_CODIGO=PE.PED_CODIGO where estado='pendiente' order by ped_fecha"
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
    Sub LLENARLISTAatendidos()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select pe.PED_CODIGO,COD_ORDENSALIDA,razon_empresa,convert(varchar(10),PED_FECHA,103)as fecha,Estado from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where estado='atendido' order by ped_fecha"
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
    Sub LLENARLISTAanulados()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select pe.PED_CODIGO,COD_ORDENSALIDA,razon_empresa,convert(varchar(10),PED_FECHA,103)as fecha,Estado from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where estado='anulado' order by ped_fecha"
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
    Private Sub Consulta_pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTAPELLIDOS.Text = ""
        dta = New SqlDataAdapter(seleccion, cn)
        dat = New DataTable
        dta.Fill(dat)
        iniciando = False
        Me.GroupBox3.Visible = False
        Me.GroupBox2.Visible = False
        Me.ListView2.Visible = False
        Me.GroupBox5.Visible = False
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigo.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            tipo_empresa()
        End If
    End Sub

    'Private Sub LISTAAPELLIDOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LISTAAPELLIDOS.SelectedIndexChanged
    '    If iniciando Then Exit Sub
    '    '     Al hacer clic, mostrar el dato
    '    Me.TXTAPELLIDOS.Text = Me.LISTAAPELLIDOS.SelectedItem.ToString
    '    'Me.Label8.Text = Mid(Me.TXTAPELLIDOS.Text, 1, InStr(1, Me.TXTAPELLIDOS.Text, ",") - 1)
    '    Me.Label8.Text = Me.TXTAPELLIDOS.Text
    '    Try
    '        Dim CONT As Integer
    '        cm.CommandText = "SELECT cod_empresa FROM empresas_pedidos WHERE razon_empresa='" + Me.Label8.Text + "'"
    '        cm.Connection = cn
    '        cn.Open()
    '        cm.CommandType = CommandType.Text
    '        Dim dr As SqlClient.SqlDataReader
    '        dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    '        If dr.HasRows Then
    '            Do While dr.Read
    '                Me.LBLCOD_CLIENTE.Text = dr(0).ToString
    '            Loop
    '        Else
    '            MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
    '            cn.Close()
    '        End If
    '        dr.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        cn.Close()
    '    End Try
    '    cn.Close()
    '    Me.LISTAAPELLIDOS.Visible = False
    'End Sub

    'Private Sub TXTAPELLIDOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TextChanged
    '    If iniciando Then Exit Sub

    '    ' Buscar en el DataTable usando el método Select
    '    ' que es como un filtro WHERE en una cadena de selección.

    '    ' El resultado se devuelve como un array de tipo DataRow
    '    Dim filas() As DataRow

    '    ' Si solo quieres mostrar los que empiecen por lo escrito.
    '    ' Al escribir "s" se buscarán los que empiecen por esa letra.
    '    filas = dat.Select("razon_empresa LIKE '" & TXTAPELLIDOS.Text & "%'")

    '    ' Borrar los elementos anteriores
    '    Me.LISTAAPELLIDOS.Items.Clear()

    '    ' Si hay datos, mostrar los apellidos
    '    If filas.Length > 0 Then

    '        ' Recorrer cada fila y mostrar los apellidos
    '        For Each dr As DataRow In filas

    '            Me.LISTAAPELLIDOS.Items.Add( _
    '                        dr("razon_empresa").ToString)

    '        Next
    '    End If
    'End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox2.Visible = True
        Me.GroupBox3.Visible = False
        Me.ListView1.Items.Clear()
        Me.GroupBox5.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = True
        Me.ListView1.Items.Clear()
        Me.GroupBox5.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ListView1.SelectedItems.Count > 0 And Me.lblcodigo.Text <> "" Then
            ordensalida = Me.lblcodigo.Text
            Me.lblcodigo.ResetText()
            Dim O As New orden_de_salida
            O.ShowDialog()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TXTAPELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDOS.KeyPress
        Me.ListView2.Visible = True
        Try
            Me.ListView2.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT cod_empresa,razon_empresa,telefono_empresa,direccion_empresa FROM empresas_pedidos WHERE razon_empresa LIKE'%" & TXTAPELLIDOS.Text & "%'"
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
    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBLCOD_CLIENTE.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.Label8.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
        End If
        Me.ListView2.Visible = False
    End Sub

    Private Sub TXTAPELLIDOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TextChanged

    End Sub
    Sub tipo_empresa()
        Try
            Dim CONT As Integer
            cm.CommandText = "select cod_tipoe from empresas_pedidos where razon_empresa='" + Me.ListView1.SelectedItems(0).SubItems(2).Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    tipo = dr(0).ToString
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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.ListView1.SelectedItems.Count > 0 And Me.lblcodigo.Text <> "" Then
            ordensalida = ""
            ordensalida = Me.lblcodigo.Text
            Me.lblcodigo.ResetText()
            Dim O As New Devolución_Pedidos
            O.ShowDialog()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox5.Visible = True
        Me.GroupBox2.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView1.Items.Clear()
    End Sub
    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            orden1 = Me.ListView1.SelectedItems(0).SubItems(1).Text
            estado = Me.ListView1.SelectedItems(0).SubItems(4).Text
            If orden1 <> "" And estado = "Pendiente" Then
                Dim pedidos As New PEDIDOS
                pedidos.ShowDialog()
            Else
                MsgBox("No es posible agregar datos a un pedido " + estado + "", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Consulta_pedidos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    End Sub
End Class
