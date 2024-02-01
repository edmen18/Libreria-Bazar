Imports System.Data.SqlClient
Public Class MANTENEDOR_DE_EMPRESAS
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents LBLCODIGOEMPRESA As System.Windows.Forms.Label
    Friend WithEvents LBLRAZON As System.Windows.Forms.Label
    Friend WithEvents LBLTELEFONO As System.Windows.Forms.Label
    Friend WithEvents LBLDIRECCION As System.Windows.Forms.Label
    Friend WithEvents TXTRAZON As System.Windows.Forms.TextBox
    Friend WithEvents TXTTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbotipoempresa As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodigotipoempresa As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MANTENEDOR_DE_EMPRESAS))
        Me.LBLCODIGOEMPRESA = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXTDIRECCION = New System.Windows.Forms.TextBox
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox
        Me.TXTRAZON = New System.Windows.Forms.TextBox
        Me.LBLDIRECCION = New System.Windows.Forms.Label
        Me.LBLTELEFONO = New System.Windows.Forms.Label
        Me.LBLRAZON = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNEDITAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNACTUALIZAR = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbotipoempresa = New System.Windows.Forms.ComboBox
        Me.lblcodigotipoempresa = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLCODIGOEMPRESA
        '
        Me.LBLCODIGOEMPRESA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCODIGOEMPRESA.Location = New System.Drawing.Point(104, 32)
        Me.LBLCODIGOEMPRESA.Name = "LBLCODIGOEMPRESA"
        Me.LBLCODIGOEMPRESA.Size = New System.Drawing.Size(416, 20)
        Me.LBLCODIGOEMPRESA.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcodigotipoempresa)
        Me.GroupBox2.Controls.Add(Me.cbotipoempresa)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtruc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXTDIRECCION)
        Me.GroupBox2.Controls.Add(Me.TXTTELEFONO)
        Me.GroupBox2.Controls.Add(Me.TXTRAZON)
        Me.GroupBox2.Controls.Add(Me.LBLDIRECCION)
        Me.GroupBox2.Controls.Add(Me.LBLTELEFONO)
        Me.GroupBox2.Controls.Add(Me.LBLRAZON)
        Me.GroupBox2.Controls.Add(Me.LBLCODIGOEMPRESA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 296)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(104, 128)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(416, 20)
        Me.txtruc.TabIndex = 9
        Me.txtruc.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ruc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTDIRECCION
        '
        Me.TXTDIRECCION.Location = New System.Drawing.Point(104, 208)
        Me.TXTDIRECCION.Name = "TXTDIRECCION"
        Me.TXTDIRECCION.Size = New System.Drawing.Size(416, 20)
        Me.TXTDIRECCION.TabIndex = 7
        Me.TXTDIRECCION.Text = ""
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(104, 168)
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(416, 20)
        Me.TXTTELEFONO.TabIndex = 6
        Me.TXTTELEFONO.Text = ""
        '
        'TXTRAZON
        '
        Me.TXTRAZON.Location = New System.Drawing.Point(104, 80)
        Me.TXTRAZON.Name = "TXTRAZON"
        Me.TXTRAZON.Size = New System.Drawing.Size(416, 20)
        Me.TXTRAZON.TabIndex = 4
        Me.TXTRAZON.Text = ""
        '
        'LBLDIRECCION
        '
        Me.LBLDIRECCION.Location = New System.Drawing.Point(16, 208)
        Me.LBLDIRECCION.Name = "LBLDIRECCION"
        Me.LBLDIRECCION.Size = New System.Drawing.Size(72, 24)
        Me.LBLDIRECCION.TabIndex = 3
        Me.LBLDIRECCION.Text = "Dirección"
        Me.LBLDIRECCION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTELEFONO
        '
        Me.LBLTELEFONO.Location = New System.Drawing.Point(16, 168)
        Me.LBLTELEFONO.Name = "LBLTELEFONO"
        Me.LBLTELEFONO.Size = New System.Drawing.Size(72, 24)
        Me.LBLTELEFONO.TabIndex = 2
        Me.LBLTELEFONO.Text = "Teléfono"
        Me.LBLTELEFONO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLRAZON
        '
        Me.LBLRAZON.Location = New System.Drawing.Point(16, 80)
        Me.LBLRAZON.Name = "LBLRAZON"
        Me.LBLRAZON.Size = New System.Drawing.Size(72, 24)
        Me.LBLRAZON.TabIndex = 0
        Me.LBLRAZON.Text = "Razón social"
        Me.LBLRAZON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Código"
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
        Me.GroupBox3.Location = New System.Drawing.Point(568, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 296)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 56)
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
        Me.BTNEDITAR.Location = New System.Drawing.Point(16, 8)
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(16, 200)
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
        Me.BTNRETORNAR.Location = New System.Drawing.Point(16, 248)
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
        Me.BTNAGREGAR.Location = New System.Drawing.Point(16, 104)
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
        Me.BTNACTUALIZAR.Location = New System.Drawing.Point(16, 152)
        Me.BTNACTUALIZAR.Name = "BTNACTUALIZAR"
        Me.BTNACTUALIZAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNACTUALIZAR.TabIndex = 28
        Me.BTNACTUALIZAR.Text = "&Editar"
        Me.BTNACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.SystemColors.Menu
        Me.DataGrid1.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 312)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 150
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(672, 216)
        Me.DataGrid1.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tipo_Empresa"
        '
        'cbotipoempresa
        '
        Me.cbotipoempresa.Location = New System.Drawing.Point(104, 248)
        Me.cbotipoempresa.Name = "cbotipoempresa"
        Me.cbotipoempresa.Size = New System.Drawing.Size(376, 21)
        Me.cbotipoempresa.TabIndex = 42
        '
        'lblcodigotipoempresa
        '
        Me.lblcodigotipoempresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigotipoempresa.Location = New System.Drawing.Point(488, 240)
        Me.lblcodigotipoempresa.Name = "lblcodigotipoempresa"
        Me.lblcodigotipoempresa.Size = New System.Drawing.Size(48, 32)
        Me.lblcodigotipoempresa.TabIndex = 43
        '
        'MANTENEDOR_DE_EMPRESAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(704, 534)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "MANTENEDOR_DE_EMPRESAS"
        Me.Text = "Mantenedor Empresas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private date1 As DataTable
    Private dta2 As SqlDataAdapter
    Private seleccion5 As String = "select cod_empresa as Código,razon_empresa as Nombre,telefono_empresa as Teléfono,ruc as Ruc,direccion_empresa as Dirección from empresas_pedidos"
    Sub LLENARCOMBO()
        cn.Open()
        Me.cbotipoempresa.ResetText()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select DESCRIPCION From TIPO_empresa", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.cbotipoempresa.Items.Add(datRead.Item(0))
        End While
        datRead.Close()
        cn.Close()
    End Sub
    Sub llenargrilla()
        dta2 = New SqlDataAdapter(seleccion5, cn)
        date1 = New DataTable
        dta2.Fill(date1)
        Me.DataGrid1.DataSource = date1
    End Sub
    Private Sub MANTENEDOR_DE_EMPRESAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = True
        llenargrilla()
        Me.GroupBox2.Enabled = False
        Me.BTNAGREGAR.Enabled = False
        LLENARCOMBO()

    End Sub
    Sub limpiar()
        Me.TXTRAZON.ResetText()
        Me.txtruc.ResetText()
        Me.LBLCODIGOEMPRESA.ResetText()
        Me.TXTTELEFONO.ResetText()
        Me.TXTDIRECCION.ResetText()
    End Sub
    Sub GENERAEMPRESA()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from EMPRESAS_Pedidos"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLCODIGOEMPRESA.Text = "EP0" + CStr(datar(0))
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox2.Enabled = True
        Me.BTNCANCELAR.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = False
        Me.BTNAGREGAR.Enabled = True
        limpiar()
        GENERAEMPRESA()
    End Sub
    Private Sub BTNEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEDITAR.Click

        Dim b As New Buscar_Empresas
        b.ShowDialog()
        If CODIGO = "" Then
            Me.BTNEDITAR.Enabled = True
            CODIGO = ""
        Else
            Me.LBLCODIGOEMPRESA.Text = CODIGO
            llenar()
            Me.Button1.Enabled = False
            Me.BTNAGREGAR.Enabled = False
            Me.BTNEDITAR.Enabled = False
            Me.BTNACTUALIZAR.Enabled = True
            Me.BTNCANCELAR.Enabled = True
            Me.GroupBox2.Enabled = True
        End If

    End Sub
    Sub llenar()
        Try
            cm.CommandText = "Select COD_EMPRESA,RAZON_EMPRESA, TELEFONO_EMPRESA, DIRECCION_EMPRESA,ruc,te.cod_tipoe,te.descripcion from EMPRESAS_Pedidos ep inner join tipo_empresa te on te.cod_tipoe=ep.cod_tipoe WHERE COD_EMPRESA='" + Me.LBLCODIGOEMPRESA.Text + "'"
            cm.Connection = cn
            cn.Open()
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.LBLCODIGOEMPRESA.Text = dr(0).ToString
                    Me.TXTRAZON.Text = dr(1).ToString
                    Me.TXTTELEFONO.Text = dr(2).ToString
                    Me.TXTDIRECCION.Text = dr(3).ToString
                    Me.txtruc.Text = dr(4).ToString
                    Me.lblcodigotipoempresa.Text = dr(5).ToString
                    Me.cbotipoempresa.Text = dr(6).ToString
                    Me.GroupBox2.Enabled = True
                Loop
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
        Me.BTNACTUALIZAR.Enabled = True
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Me.TXTRAZON.Text = "" Or Me.TXTDIRECCION.Text = "" Or Me.TXTTELEFONO.Text = "" Or Me.txtruc.Text = "" Or Me.LBLCODIGOEMPRESA.Text = "" Then
            MsgBox("Ingrese los datos correctos", MsgBoxStyle.Critical)
        Else
            cn.Open()
            Try
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert INTO EMPRESAS_Pedidos (COD_EMPRESA, RAZON_EMPRESA,TELEFONO_EMPRESA,DIRECCION_EMPRESA,ruc,cod_tipoe) values ('" + Me.LBLCODIGOEMPRESA.Text + "','" + Me.TXTRAZON.Text + "','" + Me.TXTTELEFONO.Text + "','" + Me.TXTDIRECCION.Text + "','" + Me.txtruc.Text + "','" + Me.lblcodigotipoempresa.Text + "')"
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
        End If
        CODIGO = Me.LBLCODIGOEMPRESA.Text
        NOMBREEMPRESA = Me.TXTRAZON.Text
        cn.Close()
        limpiar()
        Me.GroupBox2.Enabled = False
        llenargrilla()
        Me.BTNAGREGAR.Enabled = False
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.Button1.Enabled = True
        Me.BTNACTUALIZAR.Enabled = False
        Me.GroupBox2.Enabled = False
        Me.lblcodigotipoempresa.ResetText()
        Me.cbotipoempresa.Text = ""
        limpiar()
    End Sub

    Private Sub BTNACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACTUALIZAR.Click
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE EMPRESAS_Pedidos SET RAZON_EMPRESA='" + Me.TXTRAZON.Text + " ', TELEFONO_EMPRESA='" + Me.TXTTELEFONO.Text + " ',DIRECCION_EMPRESA='" + Me.TXTDIRECCION.Text + "',RUC='" + Me.txtruc.Text + "',cod_tipoe='" + Me.lblcodigotipoempresa.Text + "' WHERE COD_EMPRESA='" + Me.LBLCODIGOEMPRESA.Text + "' "
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
        cn.Close()
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = True
        Me.BTNAGREGAR.Enabled = False
        Me.Button1.Enabled = True
        Me.BTNCANCELAR.Enabled = False
        cn.Close()
        limpiar()
        llenargrilla()
        Me.GroupBox2.Enabled = False
    End Sub

    Private Sub cbotipoempresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipoempresa.SelectedIndexChanged
        cn.Open()
        Dim datARead As SqlDataReader
        cm = New SqlCommand("Select cod_tipoe From TIPO_empresa WHERE DESCRIPCION ='" + Me.cbotipoempresa.Text + "'", cn)
        datARead = cm.ExecuteReader
        While datARead.Read()
            Me.lblcodigotipoempresa.Text = datARead(0).ToString
        End While
        cn.Close()
    End Sub
End Class
