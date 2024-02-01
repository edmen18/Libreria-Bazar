Imports System.Data.SqlClient
Public Class Buscar_Cliente
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TXTAPELLIDOS As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcod_cliente As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Buscar_Cliente))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblcod_cliente = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.TXTAPELLIDOS = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.lblcod_cliente)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TXTAPELLIDOS)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 248)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese Cliente"
        '
        'lblcod_cliente
        '
        Me.lblcod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcod_cliente.Location = New System.Drawing.Point(432, 72)
        Me.lblcod_cliente.Name = "lblcod_cliente"
        Me.lblcod_cliente.Size = New System.Drawing.Size(24, 24)
        Me.lblcod_cliente.TabIndex = 15
        Me.lblcod_cliente.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(432, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 40)
        Me.Button4.TabIndex = 12
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTAPELLIDOS
        '
        Me.TXTAPELLIDOS.Location = New System.Drawing.Point(8, 24)
        Me.TXTAPELLIDOS.Name = "TXTAPELLIDOS"
        Me.TXTAPELLIDOS.Size = New System.Drawing.Size(408, 20)
        Me.TXTAPELLIDOS.TabIndex = 0
        Me.TXTAPELLIDOS.Text = ""
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(8, 56)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(408, 168)
        Me.ListView1.TabIndex = 29
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre y Apellidos"
        Me.ColumnHeader2.Width = 223
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI"
        Me.ColumnHeader3.Width = 123
        '
        'Buscar_Cliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 294)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Buscar_Cliente"
        Me.Text = "Buscar_Cliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcod_cliente.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.TXTAPELLIDOS.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.ListView1.Visible = False
        End If
    End Sub
    Private Sub TXTAPELLIDOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDOS.KeyPress
        Me.ListView1.Visible = True
        cn.Open()
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cm.Connection = cn
            cm.CommandText = " SELECT cl_CODIGO, cl_apellidos+' '+cl_nombres,cl_dni FROM clientes WHERE cl_apellidos+' '+cl_nombres LIKE'%" & TXTAPELLIDOS.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub Buscar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cn.Close()
        CCLIENTE = Me.lblcod_cliente.Text
        Me.Close()
    End Sub
End Class
