Imports System.Data.SqlClient
Public Class Consulta_Guia
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
    Friend WithEvents rbproveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents LBL_COD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents gbfecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consulta_Guia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbfecha = New System.Windows.Forms.RadioButton
        Me.rbproveedor = New System.Windows.Forms.RadioButton
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.gbproveedor = New System.Windows.Forms.GroupBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.Label8 = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.LBL_COD_CLIENTE = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.gbfecha = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.gbproveedor.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbfecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.rbproveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción"
        '
        'rbfecha
        '
        Me.rbfecha.Location = New System.Drawing.Point(312, 24)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(120, 16)
        Me.rbfecha.TabIndex = 2
        Me.rbfecha.Text = "Fecha de Emisión"
        '
        'rbproveedor
        '
        Me.rbproveedor.Location = New System.Drawing.Point(64, 24)
        Me.rbproveedor.Name = "rbproveedor"
        Me.rbproveedor.Size = New System.Drawing.Size(104, 16)
        Me.rbproveedor.TabIndex = 0
        Me.rbproveedor.Text = "Proveedor"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 216)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(624, 136)
        Me.ListView1.TabIndex = 1
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código Guia"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Proveedor"
        Me.ColumnHeader2.Width = 184
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Número"
        Me.ColumnHeader3.Width = 91
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Factura"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Monto"
        Me.ColumnHeader4.Width = 52
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Fecha"
        Me.ColumnHeader7.Width = 90
        '
        'gbproveedor
        '
        Me.gbproveedor.BackColor = System.Drawing.SystemColors.Control
        Me.gbproveedor.Controls.Add(Me.ListView3)
        Me.gbproveedor.Controls.Add(Me.Label8)
        Me.gbproveedor.Controls.Add(Me.LDAPELLEDIS)
        Me.gbproveedor.Controls.Add(Me.TXTAPELLIDOS)
        Me.gbproveedor.Controls.Add(Me.LBL_COD_CLIENTE)
        Me.gbproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbproveedor.Location = New System.Drawing.Point(8, 72)
        Me.gbproveedor.Name = "gbproveedor"
        Me.gbproveedor.Size = New System.Drawing.Size(504, 128)
        Me.gbproveedor.TabIndex = 35
        Me.gbproveedor.TabStop = False
        Me.gbproveedor.Text = "Proveedor"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(88, 48)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(408, 80)
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
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(56, 24)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Proveedor"
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(88, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(408, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'LBL_COD_CLIENTE
        '
        Me.LBL_COD_CLIENTE.Location = New System.Drawing.Point(464, 24)
        Me.LBL_COD_CLIENTE.Name = "LBL_COD_CLIENTE"
        Me.LBL_COD_CLIENTE.Size = New System.Drawing.Size(40, 23)
        Me.LBL_COD_CLIENTE.TabIndex = 31
        Me.LBL_COD_CLIENTE.Text = "Label1"
        Me.LBL_COD_CLIENTE.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.lblcodigo)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(528, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 200)
        Me.GroupBox4.TabIndex = 39
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
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Location = New System.Drawing.Point(40, 24)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(32, 23)
        Me.lblcodigo.TabIndex = 37
        Me.lblcodigo.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ver detalle"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbfecha
        '
        Me.gbfecha.Controls.Add(Me.Label3)
        Me.gbfecha.Controls.Add(Me.Label2)
        Me.gbfecha.Controls.Add(Me.DateTimePicker2)
        Me.gbfecha.Controls.Add(Me.DateTimePicker1)
        Me.gbfecha.Location = New System.Drawing.Point(8, 72)
        Me.gbfecha.Name = "gbfecha"
        Me.gbfecha.Size = New System.Drawing.Size(504, 56)
        Me.gbfecha.TabIndex = 55
        Me.gbfecha.TabStop = False
        Me.gbfecha.Text = "Ingrese un rango de fechas"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "&Del"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "&Al"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(328, 24)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Consulta_Guia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 366)
        Me.Controls.Add(Me.gbfecha)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbproveedor)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consulta_Guia"
        Me.Text = "Consulta_Guia"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbproveedor.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gbfecha.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TXTAPELLIDOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TextChanged

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

    Private Sub Consulta_Guia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView3.Visible = False
        Me.gbfecha.Visible = False
        Me.gbproveedor.Visible = False
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBL_COD_CLIENTE.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.ListView3.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.rbproveedor.Checked = True Then
            llenarporproveedor()
        End If
        If Me.rbfecha.Checked = True Then
            llenarporfecha()
        End If
    End Sub
    Sub llenarporproveedor()
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select gr.codigo_guia,pv_descripcion,NUMERO_GUIA,numero_factura,total,convert(char(10),c_fecha,103)as fecha from guia_remision gr inner join compras c on c.c_codigo=gr.c_codigo inner join proveedor pv on pv.pv_codigo=c.pv_codigo inner join factura_guia f on f.codigo_factura=gr.codigo_factura where pv.pv_codigo='" + Me.LBL_COD_CLIENTE.Text + "'order by c_fecha"
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
                    'Me.ListView1.Items(I).SubItems.Add(CStr(datar(6).ToString))
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
    Sub llenarporfecha()
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select gr.codigo_guia,pv_descripcion,NUMERO_GUIA,numero_factura,total,convert(char(10),c_fecha,103)as fecha from guia_remision gr inner join compras c on c.c_codigo=gr.c_codigo inner join proveedor pv on pv.pv_codigo=c.pv_codigo inner join factura_guia f on f.codigo_factura=gr.codigo_factura where c.c_fecha>'" + Me.DateTimePicker1.Value.Date + "'and c.c_fecha<'" + Me.DateTimePicker2.Value.Date + "'order by c_fecha"
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
                    'Me.ListView1.Items(I).SubItems.Add(CStr(datar(6).ToString))
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

    Private Sub rbproveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbproveedor.CheckedChanged
        Me.gbproveedor.Visible = True
        Me.gbfecha.Visible = False
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub rbestado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.gbproveedor.Visible = False
        Me.gbfecha.Visible = False
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub rbfecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfecha.CheckedChanged
        Me.gbfecha.Visible = True
        Me.gbproveedor.Visible = False
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            codigo_guia = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Dim a As New Detalle_Guia
            a.ShowDialog()
        End If
    End Sub
End Class
