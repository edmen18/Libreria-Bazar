Imports System.Data.SqlClient
Public Class Igv
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Igv))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(96, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 24)
        Me.Label3.TabIndex = 3
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAGREGAR.Location = New System.Drawing.Point(112, 16)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNAGREGAR.TabIndex = 28
        Me.BTNAGREGAR.Text = "&Grabar"
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(424, 16)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNRETORNAR.TabIndex = 33
        Me.BTNRETORNAR.Text = "&Salir"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Image = CType(resources.GetObject("BTNCANCELAR.Image"), System.Drawing.Image)
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.Location = New System.Drawing.Point(320, 16)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNCANCELAR.TabIndex = 34
        Me.BTNCANCELAR.Text = "&Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 160)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 96)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(376, 56)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Motivo"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(8, 264)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(528, 112)
        Me.ListView1.TabIndex = 37
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Porcentaje"
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Estado"
        Me.ColumnHeader3.Width = 59
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Motivo"
        Me.ColumnHeader4.Width = 310
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "&Nuevo"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(216, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "&Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox2.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 64)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Igv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(560, 390)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Igv"
        Me.Text = "Mantenimiento IGV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dt5 As DataTable
    Private da5 As SqlDataAdapter
    Private seleccion5 As String = "SELECT * from igv"

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        Dim i As Integer
        Dim ban As Integer
        ban = 0
        For i = 0 To Me.ListView1.Items.Count - 1
            If Me.ListView1.Items(i).SubItems(2).Text = "Vigente" Then
                MsgBox("Ya hay un igv vigente", MsgBoxStyle.Critical)
                MsgBox("Para ingresar un nuevo Igv elimine el que está vigente", MsgBoxStyle.Information)
                ban = 1
            Else
                ban = 0
            End If
        Next
        If ban = 0 Then
            If Me.Label3.Text = "" Or Me.TextBox1.Text = "" Or Me.RichTextBox1.Text = "" Then
                MsgBox("Ingrese los datos completos", MsgBoxStyle.Information)
            Else

                Try
                    cn.Open()
                    Dim a As Integer
                    cm.CommandType = CommandType.Text
                    cm.CommandText = "Insert INTO igv (cod_igv,porcentaje,estado,motivo) values ('" + Me.Label3.Text + "','" + Me.TextBox1.Text + "','Vigente','" + Me.RichTextBox1.Text + "')"
                    cm.Connection = cn
                    a = cm.ExecuteNonQuery()
                    If a >= 1 Then
                        MsgBox("Datos guardados", MsgBoxStyle.Information)
                    End If
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    cn.Close()
                End Try
            End If

        End If
            Me.BTNAGREGAR.Enabled = False
        cancelar()
        Me.BTNCANCELAR.Enabled = True
        Me.ListView1.Items.Clear()
        llenar()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.BTNAGREGAR.Enabled = False
        If Me.ListView1.SelectedItems.Count > 0 Then
            Try
                cn.Open()
                Dim a As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "update igv set estado='Eliminado'where estado='vigente'"
                cm.Connection = cn
                a = cm.ExecuteNonQuery()
                If a >= 1 Then
                    MsgBox("Datos Eliminados", MsgBoxStyle.Information)
                End If
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                cn.Close()
            End Try
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
        cancelar()
        Me.ListView1.Items.Clear()
        llenar()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Igv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar()
        Me.GroupBox1.Enabled = False
        Me.BTNAGREGAR.Enabled = False
    End Sub
    Sub llenar()
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT * from igv where estado='Vigente'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(3).ToString))
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox1.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        GENERAR()
        Me.BTNCANCELAR.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.GroupBox1.Enabled = False
        Me.RichTextBox1.ResetText()
        Me.Label3.ResetText()
        Me.TextBox1.ResetText()
        Me.BTNAGREGAR.Enabled = False
        Me.BTNCANCELAR.Enabled = True
        Me.Button1.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Me.BTNAGREGAR.Enabled = False
        Me.Button1.Enabled = False
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.Label3.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.TextBox1.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.RichTextBox1.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
        End If
    End Sub
    Sub GENERAR()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from igv"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.Label3.Text = "igv" + CStr(datar(0))
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
End Class
