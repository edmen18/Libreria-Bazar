Imports System.Data
Imports System.Data.SqlClient
Public Class MANTENEDOR_DE_PROVEEDORES
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTDESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents TXTTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TXTRUC As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblcodigoproveedor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MANTENEDOR_DE_PROVEEDORES))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox
        Me.TXTRUC = New System.Windows.Forms.TextBox
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox
        Me.TXTDESCRIPCION = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblcodigoproveedor = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNEDITAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNACTUALIZAR = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTDIRECCION)
        Me.GroupBox1.Controls.Add(Me.TXTRUC)
        Me.GroupBox1.Controls.Add(Me.TXTTELEFONO)
        Me.GroupBox1.Controls.Add(Me.TXTDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblcodigoproveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL PROVEEDOR"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(152, 216)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(304, 20)
        Me.TXTDIRECCION.TabIndex = 11
        Me.TXTDIRECCION.Text = ""
        '
        'TXTRUC
        '
        Me.TXTRUC.Location = New System.Drawing.Point(152, 168)
        Me.TXTRUC.MaxLength = 12
        Me.TXTRUC.Name = "TXTRUC"
        Me.TXTRUC.Size = New System.Drawing.Size(304, 20)
        Me.TXTRUC.TabIndex = 10
        Me.TXTRUC.Text = ""
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(152, 120)
        Me.TXTTELEFONO.MaxLength = 6
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(304, 20)
        Me.TXTTELEFONO.TabIndex = 8
        Me.TXTTELEFONO.Text = ""
        '
        'TXTDESCRIPCION
        '
        Me.TXTDESCRIPCION.Location = New System.Drawing.Point(152, 80)
        Me.TXTDESCRIPCION.Name = "TXTDESCRIPCION"
        Me.TXTDESCRIPCION.Size = New System.Drawing.Size(304, 20)
        Me.TXTDESCRIPCION.TabIndex = 7
        Me.TXTDESCRIPCION.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ruc"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcodigoproveedor
        '
        Me.lblcodigoproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigoproveedor.Location = New System.Drawing.Point(152, 40)
        Me.lblcodigoproveedor.Name = "lblcodigoproveedor"
        Me.lblcodigoproveedor.Size = New System.Drawing.Size(304, 20)
        Me.lblcodigoproveedor.TabIndex = 43
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.BTNEDITAR)
        Me.GroupBox3.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox3.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox3.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox3.Controls.Add(Me.BTNACTUALIZAR)
        Me.GroupBox3.Location = New System.Drawing.Point(504, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 264)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 38)
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
        Me.BTNEDITAR.Location = New System.Drawing.Point(8, 16)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(96, 38)
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 176)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 38)
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
        Me.BTNRETORNAR.Location = New System.Drawing.Point(8, 216)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 38)
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
        Me.BTNAGREGAR.Location = New System.Drawing.Point(8, 96)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 38)
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
        Me.BTNACTUALIZAR.Location = New System.Drawing.Point(8, 136)
        Me.BTNACTUALIZAR.Name = "BTNACTUALIZAR"
        Me.BTNACTUALIZAR.Size = New System.Drawing.Size(96, 38)
        Me.BTNACTUALIZAR.TabIndex = 28
        Me.BTNACTUALIZAR.Text = "&Editar"
        Me.BTNACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.LinkColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.Location = New System.Drawing.Point(16, 296)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 120
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(600, 192)
        Me.DataGrid1.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(424, 504)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Total de Proveedores"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(544, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 42
        '
        'MANTENEDOR_DE_PROVEEDORES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(632, 526)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MANTENEDOR_DE_PROVEEDORES"
        Me.Text = "Mantenimiento Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private dat As DataTable
    'Private dta As SqlDataAdapter
    'Private seleccion As String = "SELECT PV_DESCRIPCION FROM PROVEEDOR"
    'Private iniciando As Boolean = True
    'Private dat1 As DataTable
    'Private dta1 As SqlDataAdapter
    'Private seleccion1 As String = "SELECT RAZON_EMPRESA FROM EMPRESAS_PROVEEDORAS"
    'Private iniciando1 As Boolean = True
    Private date1 As DataTable
    Private dta2 As SqlDataAdapter
    Private seleccion5 As String = "select pv_codigo as Código,pv_descripcion as Nombre,telefono as Teléfono,ruc as Ruc,dirección as Dirección from proveedor"

    Sub llenargrilla()
        dta2 = New SqlDataAdapter(seleccion5, cn)
        date1 = New DataTable
        dta2.Fill(date1)
        Me.DataGrid1.DataSource = date1
    End Sub
    'Private Sub TXTPROVEEDOR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTPROVEEDOR.TextChanged
    '    If iniciando Then Exit Sub

    '    ' Buscar en el DataTable usando el método Select
    '    ' que es como un filtro WHERE en una cadena de selección.

    '    ' El resultado se devuelve como un array de tipo DataRow
    '    Dim filas() As DataRow

    '    ' Si solo quieres mostrar los que empiecen por lo escrito.
    '    ' Al escribir "s" se buscarán los que empiecen por esa letra.
    '    filas = dat.Select("PV_DESCRIPCION LIKE '" & TXTPROVEEDOR.Text & "%'")

    '    ' Borrar los elementos anteriores
    '    Me.LISTAPROVEEDOR.Items.Clear()

    '    ' Si hay datos, mostrar los apellidos
    '    If filas.Length > 0 Then

    '        ' Recorrer cada fila y mostrar los apellidos
    '        For Each dr As DataRow In filas

    '            Me.LISTAPROVEEDOR.Items.Add( _
    '                        dr("PV_DESCRIPCION").ToString)

    '        Next
    '    End If
    'End Sub

    'Private Sub LISTAPROVEEDOR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If iniciando Then Exit Sub

    '    '     Al hacer clic, mostrar el dato
    '    Me.TXTPROVEEDOR.Text = Me.LISTAPROVEEDOR.SelectedItem.ToString
    '    Me.LBLNOMBRE.Text = Me.TXTPROVEEDOR.Text
    '    Try
    '        Dim CONT As Integer
    '        cm.CommandText = "SELECT PV_CODIGO FROM proveedor WHERE PV_DESCRIPCION='" + Me.LBLNOMBRE.Text + "'"
    '        cm.Connection = cn
    '        cn.Open()
    '        cm.CommandType = CommandType.Text
    '        Dim dr As SqlClient.SqlDataReader
    '        dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
    '        If dr.HasRows Then
    '            Do While dr.Read
    '                Me.LBLCODIGOPROVEEDOR.Text = dr(0).ToString
    '            Loop
    '        Else
    '            MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
    '        End If
    '        dr.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Private Sub MANTENEDOR_DE_PROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        contarPROVEEDOR()
        Me.BTNAGREGAR.Enabled = False
        llenargrilla()
        'dta = New SqlDataAdapter(seleccion, cn)
        'dat = New DataTable
        'dta.Fill(dat)
        'iniciando = False
        'dta1 = New SqlDataAdapter(seleccion1, cn)
        'dat1 = New DataTable
        ''dta1.Fill(dat1)
        'iniciando1 = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        Me.GroupBox1.Enabled = False

    End Sub
    Sub LIMPIAR()
        Me.TXTDESCRIPCION.Text = ""
        Me.TXTDIRECCION.Text = ""
        Me.TXTTELEFONO.Text = ""
        Me.TXTRUC.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BTNAGREGAR.Enabled = True
        Me.GroupBox1.Enabled = True
        GENERAPROVEEDOR()
        Me.BTNEDITAR.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.Button1.Enabled = False
        Me.BTNCANCELAR.Enabled = True
        LIMPIAR()
    End Sub

    Private Sub BTNEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEDITAR.Click
        'Me.gbproveedor.Visible = True
        Dim b As New Buscar_Proveedor
        b.ShowDialog()
        If CODIGOPROVEEDOR = "" Then
            Me.BTNEDITAR.Enabled = True
        Else
            Me.LBLCODIGOPROVEEDOR.Text = CODIGOPROVEEDOR
            Me.GroupBox1.Enabled = True
            Me.BTNEDITAR.Enabled = False
            Me.BTNAGREGAR.Enabled = False
            Me.Button1.Enabled = False
            Me.BTNCANCELAR.Enabled = True
            llenar()
            CODIGOPROVEEDOR = ""
        End If
        
    End Sub
    Sub GENERAPROVEEDOR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from PROVEEDOR"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLCODIGOPROVEEDOR.Text = "PV0" + CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub contarPROVEEDOR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*) from PROVEEDOR"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.Label8.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        llenar()
    End Sub
    Sub llenar()
        Try
            cm.CommandText = "Select pv_codigo,pv_descripcion,telefono,ruc,dirección from proveedor WHERE pv_codigo='" + Me.LBLCODIGOPROVEEDOR.Text + "'"
            cm.Connection = cn
            cn.Open()
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.LBLCODIGOPROVEEDOR.Text = dr(0).ToString
                    Me.TXTDESCRIPCION.Text = dr(1).ToString
                    Me.TXTTELEFONO.Text = dr(2).ToString
                    Me.TXTRUC.Text = dr(3).ToString
                    Me.TXTDIRECCION.Text = dr(4).ToString
                Loop
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        Me.BTNACTUALIZAR.Enabled = True
        cn.Close()
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Me.lblcodigoproveedor.Text = "" Or Me.TXTDESCRIPCION.Text = "" Or Me.TXTTELEFONO.Text = "" Or Me.TXTRUC.Text = "" Or Me.TXTDIRECCION.Text = "" Then
            MsgBox("Ingrese los datos correctos", MsgBoxStyle.Critical)
        Else
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert INTO PROVEEDOR (PV_codigo, PV_DESCRIPCION, TELEFONO,RUC,DIRECCIÓN) values ('" + Me.lblcodigoproveedor.Text + "','" + Me.TXTDESCRIPCION.Text + "','" + Me.TXTTELEFONO.Text + "','" + Me.TXTRUC.Text + "','" + Me.TXTDIRECCION.Text + "')"
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
            llenargrilla()
            LIMPIAR()
            CANCELAR()
            contarPROVEEDOR()
            cn.Close()
        End If
    End Sub

    Private Sub BTNACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACTUALIZAR.Click
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE PROVEEDOR SET PV_DESCRIPCION='" + Me.TXTDESCRIPCION.Text + " ',TELEFONO= '" + Me.TXTTELEFONO.Text + "', RUC='" + Me.TXTRUC.Text + "',DIRECCIÓN='" + Me.TXTDIRECCION.Text + "' WHERE PV_CODIGO='" + Me.LBLCODIGOPROVEEDOR.Text + "' "
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
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        Me.Button1.Enabled = True
        Me.BTNCANCELAR.Enabled = False
        llenargrilla()
        LIMPIAR()
        CANCELAR()
        cn.Close()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        CANCELAR()
    End Sub
    Sub CANCELAR()
        Me.Button1.Enabled = True
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        Me.GroupBox1.Enabled = False
        LIMPIAR()
    End Sub
End Class
