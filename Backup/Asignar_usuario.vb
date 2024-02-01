Imports System.Data.SqlClient
Public Class Asignar_usuario
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
    Friend WithEvents gbproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents TXTPROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents LBLCODIGOPROVEEDOR As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña1 As System.Windows.Forms.TextBox
    Friend WithEvents lusuarios As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblnivel As System.Windows.Forms.Label
    Friend WithEvents cbocargo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Asignar_usuario))
        Me.gbproveedor = New System.Windows.Forms.GroupBox
        Me.TXTPROVEEDOR = New System.Windows.Forms.TextBox
        Me.LBLCODIGOPROVEEDOR = New System.Windows.Forms.Label
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcontraseña1 = New System.Windows.Forms.TextBox
        Me.txtcontraseña = New System.Windows.Forms.TextBox
        Me.txtusuario = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblnivel = New System.Windows.Forms.Label
        Me.lusuarios = New System.Windows.Forms.ListBox
        Me.cbocargo = New System.Windows.Forms.ComboBox
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.gbproveedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbproveedor
        '
        Me.gbproveedor.Controls.Add(Me.TXTPROVEEDOR)
        Me.gbproveedor.Controls.Add(Me.LBLCODIGOPROVEEDOR)
        Me.gbproveedor.Location = New System.Drawing.Point(8, 8)
        Me.gbproveedor.Name = "gbproveedor"
        Me.gbproveedor.Size = New System.Drawing.Size(472, 81)
        Me.gbproveedor.TabIndex = 56
        Me.gbproveedor.TabStop = False
        Me.gbproveedor.Text = "Ingrese Personal"
        '
        'TXTPROVEEDOR
        '
        Me.TXTPROVEEDOR.Location = New System.Drawing.Point(16, 24)
        Me.TXTPROVEEDOR.Name = "TXTPROVEEDOR"
        Me.TXTPROVEEDOR.Size = New System.Drawing.Size(440, 20)
        Me.TXTPROVEEDOR.TabIndex = 1
        Me.TXTPROVEEDOR.Text = ""
        '
        'LBLCODIGOPROVEEDOR
        '
        Me.LBLCODIGOPROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCODIGOPROVEEDOR.Location = New System.Drawing.Point(16, 56)
        Me.LBLCODIGOPROVEEDOR.Name = "LBLCODIGOPROVEEDOR"
        Me.LBLCODIGOPROVEEDOR.Size = New System.Drawing.Size(200, 23)
        Me.LBLCODIGOPROVEEDOR.TabIndex = 0
        Me.LBLCODIGOPROVEEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader11})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(24, 56)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(448, 80)
        Me.ListView3.TabIndex = 55
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 113
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apellidos Nombre"
        Me.ColumnHeader2.Width = 211
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DNI"
        Me.ColumnHeader11.Width = 118
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña1)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblnivel)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 224)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(432, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 32)
        Me.Button1.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nivel"
        '
        'txtcontraseña1
        '
        Me.txtcontraseña1.Location = New System.Drawing.Point(136, 120)
        Me.txtcontraseña1.Name = "txtcontraseña1"
        Me.txtcontraseña1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña1.Size = New System.Drawing.Size(280, 20)
        Me.txtcontraseña1.TabIndex = 5
        Me.txtcontraseña1.Text = ""
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(136, 72)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(280, 20)
        Me.txtcontraseña.TabIndex = 4
        Me.txtcontraseña.Text = ""
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(136, 32)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(280, 20)
        Me.txtusuario.TabIndex = 3
        Me.txtusuario.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir Contraseña"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'lblnivel
        '
        Me.lblnivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnivel.Location = New System.Drawing.Point(424, 160)
        Me.lblnivel.Name = "lblnivel"
        Me.lblnivel.Size = New System.Drawing.Size(24, 24)
        Me.lblnivel.TabIndex = 60
        '
        'lusuarios
        '
        Me.lusuarios.Location = New System.Drawing.Point(496, 16)
        Me.lusuarios.Name = "lusuarios"
        Me.lusuarios.Size = New System.Drawing.Size(96, 108)
        Me.lusuarios.TabIndex = 58
        Me.lusuarios.Visible = False
        '
        'cbocargo
        '
        Me.cbocargo.Location = New System.Drawing.Point(144, 312)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Size = New System.Drawing.Size(280, 21)
        Me.cbocargo.TabIndex = 59
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAGREGAR.Location = New System.Drawing.Point(496, 216)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNAGREGAR.TabIndex = 60
        Me.BTNAGREGAR.Text = "&Grabar"
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.Location = New System.Drawing.Point(496, 272)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNCANCELAR.TabIndex = 61
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
        Me.BTNRETORNAR.Location = New System.Drawing.Point(496, 320)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNRETORNAR.TabIndex = 62
        Me.BTNRETORNAR.Text = "&Salir"
        Me.BTNRETORNAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Asignar_usuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 414)
        Me.Controls.Add(Me.BTNRETORNAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.cbocargo)
        Me.Controls.Add(Me.lusuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.gbproveedor)
        Me.Name = "Asignar_usuario"
        Me.Text = "Asignar_usuario"
        Me.gbproveedor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TXTPROVEEDOR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPROVEEDOR.KeyPress
        Me.ListView3.Visible = True
        Try
            Me.ListView3.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PE_CODIGO, PE_APELLIDO+' '+PE_NOMBRE,DNI from pERSONAL WHERE PE_APELLIDO+' '+PE_NOMBRE LIKE'%" & TXTPROVEEDOR.Text & "%'and (pe_codigo)not in (select p.pe_codigo from personal p inner join usuarios u on u.pe_codigo=p.pe_codigo)"
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
    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBLCODIGOPROVEEDOR.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TXTPROVEEDOR.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.ListView3.Visible = False
            Me.txtusuario.Enabled = True
        Else
            funcion()
        End If
    End Sub
    Private Sub Asignar_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView3.Visible = False
        cargarusuarios()
        LLENARCOMBO()
        funcion()
    End Sub
    Sub funcion()
        Me.txtcontraseña.Enabled = False
        Me.txtcontraseña1.Enabled = False
        Me.txtusuario.Enabled = False
        Me.cbocargo.Enabled = False
    End Sub
    Sub cargarusuarios()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " Select usuario From usuarios"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.lusuarios.Items.Add(datar(0))
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
    Sub LLENARCOMBO()
        cn.Open()
        Me.cbocargo.ResetText()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select DESCRIPCION From niveles", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.cbocargo.Items.Add(datRead.Item(0))
        End While
        datRead.Close()
        cn.Close()
    End Sub

    Private Sub cbocargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocargo.SelectedIndexChanged
        cn.Open()
        Dim datARead As SqlDataReader
        cm = New SqlCommand("Select codigo_nivel From niveles WHERE DESCRIPCION ='" + Me.cbocargo.Text + "'", cn)
        datARead = cm.ExecuteReader
        While datARead.Read()
            Me.lblnivel.Text = datARead(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub lblnivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnivel.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim b As Integer
        b = 0
        For i = 0 To Me.lusuarios.Items.Count - 1
            If Me.lusuarios.Items(i).ToString = Me.txtusuario.Text Then
                b = b + 1
            End If
        Next
        If b > 0 Then
            MsgBox("El usuario ya existe por favor ingrese otro", MsgBoxStyle.Critical)
            Me.txtcontraseña.Enabled = False
            Me.txtcontraseña1.Enabled = False
            Me.cbocargo.Enabled = False
            Me.txtusuario.Enabled = True
            Me.txtusuario.ResetText()
        Else
            Me.txtusuario.Enabled = False
            Me.txtcontraseña.Enabled = True
            Me.txtcontraseña1.Enabled = True
            Me.cbocargo.Enabled = True
        End If
    End Sub
    Sub limpiar()
        Me.txtusuario.ResetText()
        Me.txtcontraseña.ResetText()
        Me.txtcontraseña1.ResetText()
        Me.cbocargo.Text = ""
        Me.LBLCODIGOPROVEEDOR.ResetText()
        Me.lblnivel.ResetText()
        Me.TXTPROVEEDOR.ResetText()
        funcion()
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Me.txtcontraseña.Text = "" Or Me.txtusuario.Text = "" Or Me.LBLCODIGOPROVEEDOR.Text = "" Or Me.txtcontraseña1.Text = "" Or Me.lblnivel.Text = "" Then
            MsgBox("Ingrese los datos completos", MsgBoxStyle.Critical)
        Else
            If Me.txtcontraseña.Text <> Me.txtcontraseña1.Text Then
                MsgBox("Contraseña no válida.........por favor ingrese la misma contraseña en ambos espacios", MsgBoxStyle.Critical)
                Me.txtcontraseña1.ResetText()
                Me.txtcontraseña.ResetText()
            Else
                cn.Open()
                Try
                    Dim a As Integer
                    Dim b As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO usuarios (pe_codigo,usuario,contraseña,codigo_nivel) values ('" + Me.LBLCODIGOPROVEEDOR.Text + "','" + Me.txtusuario.Text + "','" + Me.txtcontraseña1.Text + "','" + Me.lblnivel.Text + "')"
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
                limpiar()
            End If
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        limpiar()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
