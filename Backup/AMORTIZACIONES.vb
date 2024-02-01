Imports System.Data.SqlClient
Public Class AMORTIZACIONES
    Inherits System.Windows.Forms.Form
    'Private dat As DataTable
    'Private dta As SqlDataAdapter
    'Private seleccion As String = "SELECT CL_NOMBRES, CL_APELLIDOS FROM CLIENTES"
    'Private iniciando As Boolean = True
    Private dat1 As DataTable
    Private dta1 As SqlDataAdapter
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LDAPELLEDIS As System.Windows.Forms.Label
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents LBLCOD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents txtcancelar As System.Windows.Forms.TextBox
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcodigodeuda As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AMORTIZACIONES))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.LBLCOD_CLIENTE = New System.Windows.Forms.Label
        Me.LDAPELLEDIS = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.txtcancelar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblcodigodeuda = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.LBLCOD_CLIENTE)
        Me.GroupBox2.Controls.Add(Me.LDAPELLEDIS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 96)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(120, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Dni"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 8)
        Me.Label8.TabIndex = 15
        Me.Label8.Visible = False
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(120, 32)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(360, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'LBLCOD_CLIENTE
        '
        Me.LBLCOD_CLIENTE.Location = New System.Drawing.Point(72, 24)
        Me.LBLCOD_CLIENTE.Name = "LBLCOD_CLIENTE"
        Me.LBLCOD_CLIENTE.Size = New System.Drawing.Size(32, 23)
        Me.LBLCOD_CLIENTE.TabIndex = 31
        Me.LBLCOD_CLIENTE.Visible = False
        '
        'LDAPELLEDIS
        '
        Me.LDAPELLEDIS.Location = New System.Drawing.Point(16, 32)
        Me.LDAPELLEDIS.Name = "LDAPELLEDIS"
        Me.LDAPELLEDIS.Size = New System.Drawing.Size(80, 24)
        Me.LDAPELLEDIS.TabIndex = 1
        Me.LDAPELLEDIS.Text = "Apellidos"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(16, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Buscar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 128)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(488, 144)
        Me.ListView1.TabIndex = 31
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código_venta"
        Me.ColumnHeader1.Width = 118
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Monto Inicial"
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amortizado"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Saldo"
        Me.ColumnHeader4.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha"
        Me.ColumnHeader5.Width = 153
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox1.Controls.Add(Me.txtcancelar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 56)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Total (S/.)"
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.Location = New System.Drawing.Point(440, 16)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(32, 32)
        Me.BTNAGREGAR.TabIndex = 29
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcancelar
        '
        Me.txtcancelar.Location = New System.Drawing.Point(328, 24)
        Me.txtcancelar.Name = "txtcancelar"
        Me.txtcancelar.Size = New System.Drawing.Size(88, 20)
        Me.txtcancelar.TabIndex = 1
        Me.txtcancelar.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(224, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto a Cancelar"
        '
        'lbltotal
        '
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(80, 24)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(112, 20)
        Me.lbltotal.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Ver detalle"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(528, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 152)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(16, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 40)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "&Salir"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "&Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "&Grabar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Location = New System.Drawing.Point(528, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 96)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'lblcodigodeuda
        '
        Me.lblcodigodeuda.Location = New System.Drawing.Point(32, 40)
        Me.lblcodigodeuda.Name = "lblcodigodeuda"
        Me.lblcodigodeuda.Size = New System.Drawing.Size(48, 16)
        Me.lblcodigodeuda.TabIndex = 40
        Me.lblcodigodeuda.Text = "Label2"
        Me.lblcodigodeuda.Visible = False
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(136, 80)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(360, 96)
        Me.ListView2.TabIndex = 41
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Código"
        Me.ColumnHeader6.Width = 47
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre y Apellidos"
        Me.ColumnHeader7.Width = 208
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DNI"
        Me.ColumnHeader8.Width = 105
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(568, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 42
        '
        'AMORTIZACIONES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(664, 358)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblcodigodeuda)
        Me.Name = "AMORTIZACIONES"
        Me.Text = "Amortizaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub AMORTIZACIONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXTAPELLIDOS.Text = ""
        'dta = New SqlDataAdapter(seleccion, cn)
        'dat = New DataTable
        'dta.Fill(dat)
        'iniciando = False
        Me.ListView2.Visible = False
    End Sub
    Private Sub TXTAPELLIDOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTAPELLIDOS.TextChanged
        'If iniciando Then Exit Sub

        '' Buscar en el DataTable usando el método Select
        '' que es como un filtro WHERE en una cadena de selección.

        '' El resultado se devuelve como un array de tipo DataRow
        'Dim filas() As DataRow

        '' Si solo quieres mostrar los que empiecen por lo escrito.
        '' Al escribir "s" se buscarán los que empiecen por esa letra.
        'filas = dat.Select("CL_APELLIDOS LIKE '" & TXTAPELLIDOS.Text & "%'")

        '' Borrar los elementos anteriores
        'Me.LISTAAPELLIDOS.Items.Clear()

        '' Si hay datos, mostrar los apellidos
        'If filas.Length > 0 Then

        '    ' Recorrer cada fila y mostrar los apellidos
        '    For Each dr As DataRow In filas

        '        Me.LISTAAPELLIDOS.Items.Add( _
        '                    dr("CL_APELLIDOS").ToString & " " & _
        '                    dr("CL_NOMBRES").ToString)

        '    Next
        'End If
    End Sub

    'Private Sub LISTAAPELLIDOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'If iniciando Then Exit Sub

    ''     Al hacer clic, mostrar el dato
    'Me.TXTAPELLIDOS.Text = Me.LISTAAPELLIDOS.SelectedItem.ToString
    ''Me.Label8.Text = Mid(Me.TXTAPELLIDOS.Text, 1, InStr(1, Me.TXTAPELLIDOS.Text, ",") - 1)
    'Me.Label8.Text = Me.TXTAPELLIDOS.Text
    'Try
    '    Dim CONT As Integer
    '    cm.CommandText = "SELECT CL_CODIGO,cl_dni FROM CLIENTES WHERE CL_APELLIDOS+' '+cl_nombres='" + Me.Label8.Text + "'"
    '    cm.Connection = cn
    '    cn.Open()
    '    cm.CommandType = CommandType.Text
    '    Dim dr As SqlClient.SqlDataReader
    '    dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    '    If dr.HasRows Then
    '        Do While dr.Read
    '            Me.LBLCOD_CLIENTE.Text = dr(0).ToString
    '            Me.Label6.Text = dr(1).ToString

    '        Loop
    '    Else
    '        MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
    '    End If
    '    dr.Close()
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical)
    'End Try
    'Me.LISTAAPELLIDOS.Visible = False
    'End Sub

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
    Sub rrecorrer()
        Dim i As Integer
        Dim a As Integer
        Me.lbltotal.Text = 0
        For i = 0 To Me.ListView1.Items.Count - 1
            Me.lbltotal.Text = Val(Me.lbltotal.Text) + Val(Me.ListView1.Items(i).SubItems(3).Text)
        Next
    End Sub
    Sub validar()
        Dim i As Integer
        Dim total As Integer
        total = 0
        For i = 0 To Me.ListView1.Items.Count - 1
            total = total + 1
        Next
        If total = 0 Then
            MsgBox("El cliente no tiene ninguna deuda pendiente", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ListView2.Visible = False
        Me.lblcodigodeuda.ResetText()
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "SELECT V.V_CODIGO,V.TOTAL AS MONTO_POR_CANCELAR,CANCELADO,(total-cancelado)as SALDO,CONVERT(CHAR(10),V_FECHA,103)AS FECHA FROM AMORTIZACIONES A INNER JOIN VENTAS V ON  V.V_CODIGO=A.V_CODIGO WHERE CL_CODIGO='" + Me.LBLCOD_CLIENTE.Text + "' AND V.ESTADO='A CREDITO' "
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
        rrecorrer()
        validar()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigodeuda.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Val(Me.txtcancelar.Text) > Val(Me.lbltotal.Text) Then
            MsgBox("El monto ingresado supera la deuda,por favor ingrese un monto menor", MsgBoxStyle.Critical)
        Else
            If Me.txtcancelar.Text = "" Or Me.LBLCOD_CLIENTE.Text = "" Then
                MsgBox("Ingrese los datos completos", MsgBoxStyle.Critical)

            Else
                funtion()
                funtion2()
                funtion3()
                Me.BTNAGREGAR.Enabled = False
            End If
        End If
        rrecorrer()

    End Sub
    Sub funtion2()
        Dim i As Integer
        For i = 0 To Me.ListView1.Items.Count - 1
            If Val(Me.ListView1.Items(i).SubItems(3).Text) = 0 Then
                Me.ListView1.Items(i).SubItems(2).Text() = Me.ListView1.Items(i).SubItems(1).Text
            Else
                Me.ListView1.Items(i).SubItems(2).Text = Val(Me.ListView1.Items(i).SubItems(1).Text) - Val(Me.ListView1.Items(i).SubItems(3).Text)
            End If
        Next
    End Sub
    Sub funtion3()
        Dim o As Integer
        Dim total As Double
        total = 0
        For o = 0 To Me.ListView1.Items.Count - 1
            total = total + Val(Me.ListView1.Items(o).SubItems(3).Text)
        Next
        Me.lbltotal.Text = total
    End Sub

    Sub funtion()
        Dim monto As Double
        Dim j As Integer
        monto = Val(Me.txtcancelar.Text)
        For j = 0 To Me.ListView1.Items.Count - 1
            If monto = 0.0 Then
            Else
                If monto > Val(Me.ListView1.Items(j).SubItems(3).Text) Then
                    monto = monto - Val(Me.ListView1.Items(j).SubItems(3).Text)
                    Me.ListView1.Items(j).SubItems(3).Text = 0.0
                Else
                    Me.ListView1.Items(j).SubItems(3).Text = Val(Me.ListView1.Items(j).SubItems(3).Text) - monto
                    monto = 0.0
                End If
            End If
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.lblcodigodeuda.Text = "" Then
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        Else
            ventas = Me.lblcodigodeuda.Text
            Dim a As New DETALLE_VENTA
            a.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = 0 To Me.ListView1.Items.Count - 1
            If Me.ListView1.Items(i).SubItems(3).Text = 0 Then
                Try
                    cn.Open()
                    Dim a As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "update AMORTIZACIONES set CANCELADO=cancelado+'" + Me.ListView1.Items(i).SubItems(2).Text + "',saldo='" + Me.ListView1.Items(i).SubItems(3).Text + "'where v_codigo='" + Me.ListView1.Items(i).SubItems(0).Text + "'"
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
                Try
                    cn.Open()
                    Dim a As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "update ventas set estado='CANCELADA'where v_codigo='" + Me.ListView1.Items(i).SubItems(0).Text + "'"
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
            Else
                Try
                    cn.Open()
                    Dim a As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "update AMORTIZACIONES set CANCELADO=cancelado+'" + Me.ListView1.Items(i).SubItems(2).Text + "',saldo='" + Me.ListView1.Items(i).SubItems(3).Text + "'where v_codigo='" + Me.ListView1.Items(i).SubItems(0).Text + "'"
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
            End If
        Next
        MsgBox("Datos Guardados", MsgBoxStyle.Information)
        cancelar()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.TXTAPELLIDOS.ResetText()
        Me.Label6.ResetText()
        Me.LBLCOD_CLIENTE.ResetText()
        Me.lbltotal.ResetText()
        Me.ListView1.Items.Clear()
        Me.txtcancelar.ResetText()
        Me.BTNAGREGAR.Enabled = True
        Me.lblcodigodeuda.ResetText()
    End Sub


    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        If Me.ListView2.SelectedItems.Count > 0 Then
            Me.LBLCOD_CLIENTE.Text = Me.ListView2.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView2.SelectedItems(0).SubItems(1).Text
            Me.Label6.Text = Me.ListView2.SelectedItems(0).SubItems(2).Text
            Me.ListView2.Visible = False

        End If
    End Sub
End Class
