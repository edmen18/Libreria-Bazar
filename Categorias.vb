Imports System.Data.SqlClient
Public Class Categorias
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmarca1 As System.Windows.Forms.TextBox
    Friend WithEvents lblcodmarca As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Categorias))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtmarca1 = New System.Windows.Forms.TextBox
        Me.lblcodmarca = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNEDITAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNACTUALIZAR = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmarca1)
        Me.GroupBox2.Controls.Add(Me.lblcodmarca)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 88)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'txtmarca1
        '
        Me.txtmarca1.Location = New System.Drawing.Point(88, 56)
        Me.txtmarca1.Name = "txtmarca1"
        Me.txtmarca1.Size = New System.Drawing.Size(312, 20)
        Me.txtmarca1.TabIndex = 3
        Me.txtmarca1.Text = ""
        '
        'lblcodmarca
        '
        Me.lblcodmarca.Location = New System.Drawing.Point(88, 24)
        Me.lblcodmarca.Name = "lblcodmarca"
        Me.lblcodmarca.Size = New System.Drawing.Size(192, 24)
        Me.lblcodmarca.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código"
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
        Me.GroupBox3.Location = New System.Drawing.Point(424, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 304)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
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
        Me.BTNEDITAR.Size = New System.Drawing.Size(96, 40)
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 208)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 40)
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
        Me.BTNRETORNAR.Location = New System.Drawing.Point(8, 256)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 40)
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
        Me.BTNAGREGAR.Location = New System.Drawing.Point(8, 112)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 40)
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
        Me.BTNACTUALIZAR.Location = New System.Drawing.Point(8, 160)
        Me.BTNACTUALIZAR.Name = "BTNACTUALIZAR"
        Me.BTNACTUALIZAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNACTUALIZAR.TabIndex = 28
        Me.BTNACTUALIZAR.Text = "&Editar"
        Me.BTNACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.LinkColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 104)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 184
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(408, 208)
        Me.DataGrid1.TabIndex = 40
        '
        'Categorias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 318)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Categorias"
        Me.Text = "Categorias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private date1 As DataTable
    Private dta2 As SqlDataAdapter
    Private seleccion5 As String = "select cod_categoria as Código, descripcion as categoria from categorias"
    Sub llenargrilla()
        dta2 = New SqlDataAdapter(seleccion5, cn)
        date1 = New DataTable
        dta2.Fill(date1)
        Me.DataGrid1.DataSource = date1
    End Sub
    Private Sub Categorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrilla()
        Me.GroupBox2.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        Me.BTNAGREGAR.Enabled = False
    End Sub
    Private Sub BTNEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEDITAR.Click
        ' Me.GroupBox1.Visible = True
        Dim B As New Buscar_Categoria
        B.ShowDialog()
        If categoria = "" And nombrecate = "" Then
            Me.BTNEDITAR.Enabled = True
            Me.BTNACTUALIZAR.Enabled = False
            categoria = ""
            nombrecate = ""
        Else
            Me.txtmarca1.Text = nombrecate
            Me.lblcodmarca.Text = categoria
            nombrecate = ""
            categoria = ""
            Me.BTNEDITAR.Enabled = False
            Me.BTNACTUALIZAR.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.BTNEDITAR.Enabled = False
            Me.BTNAGREGAR.Enabled = False
            Me.Button1.Enabled = False
            Me.BTNCANCELAR.Enabled = True
        End If

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        CANCELAR()
    End Sub
    Sub GENERAPROVEEDOR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from categorias"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.lblcodmarca.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            cm.CommandText = "Select cod_categoria,descripcion from categoria WHERE cod_categoria='" + Me.lblcodmarca.Text + "'"
            cm.Connection = cn
            cn.Open()
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.lblcodmarca.Text = dr(0).ToString
                    Me.txtmarca1.Text = dr(1).ToString
                    Me.GroupBox2.Enabled = True
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

        If Me.txtmarca1.Text = "" Then
            MsgBox("Error.....Ingrese el nombre de la categoria", MsgBoxStyle.Critical)
        Else
            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert INTO categorias (cod_categoria,DESCRIPCION) values ('" + Me.lblcodmarca.Text + "','" + Me.txtmarca1.Text + "')"
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
        End If
    End Sub

    Private Sub BTNACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACTUALIZAR.Click
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE categorias SET DESCRIPCION='" + Me.txtmarca1.Text + " 'WHERE COD_categoria='" + Me.lblcodmarca.Text + "' "
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
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        Me.Button1.Enabled = True
        Me.BTNCANCELAR.Enabled = False
        llenargrilla()
        CANCELAR()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox2.Enabled = True
        Me.BTNEDITAR.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.Button1.Enabled = False
        Me.BTNCANCELAR.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        LIMPIAR()
        GENERAPROVEEDOR()
    End Sub
    Sub LIMPIAR()
        Me.txtmarca1.Text = ""
        Me.lblcodmarca.Text = ""
    End Sub
    Sub CANCELAR()
        Me.Button1.Enabled = True
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.lblcodmarca.ResetText()
        LIMPIAR()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
