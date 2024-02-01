Imports System.Data.SqlClient
Public Class Buscar_Empresas
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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TXTEMPRESA As System.Windows.Forms.TextBox
    Friend WithEvents LBLCODIGOEMPRESA As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Buscar_Empresas))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TXTEMPRESA = New System.Windows.Forms.TextBox
        Me.LBLCODIGOEMPRESA = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 48)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(424, 160)
        Me.ListView1.TabIndex = 7
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Razón"
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ruc"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Teléfono"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Dirección"
        Me.ColumnHeader5.Width = 103
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TXTEMPRESA)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.LBLCODIGOEMPRESA)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 224)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Empresa"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(456, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTEMPRESA
        '
        Me.TXTEMPRESA.Location = New System.Drawing.Point(16, 24)
        Me.TXTEMPRESA.Name = "TXTEMPRESA"
        Me.TXTEMPRESA.Size = New System.Drawing.Size(424, 20)
        Me.TXTEMPRESA.TabIndex = 1
        Me.TXTEMPRESA.Text = ""
        '
        'LBLCODIGOEMPRESA
        '
        Me.LBLCODIGOEMPRESA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLCODIGOEMPRESA.Location = New System.Drawing.Point(312, 144)
        Me.LBLCODIGOEMPRESA.Name = "LBLCODIGOEMPRESA"
        Me.LBLCODIGOEMPRESA.Size = New System.Drawing.Size(32, 24)
        Me.LBLCODIGOEMPRESA.TabIndex = 4
        Me.LBLCODIGOEMPRESA.Visible = False
        '
        'Buscar_Empresas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 254)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Buscar_Empresas"
        Me.Text = "Buscar_Empresas"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CODIGO = Me.LBLCODIGOEMPRESA.Text
        Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.LBLCODIGOEMPRESA.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.TXTEMPRESA.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.ListView1.Visible = False
        End If
    End Sub

    Private Sub TXTEMPRESA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTEMPRESA.TextChanged
        Me.ListView1.Visible = True
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT cod_empresa, razon_empresa,ruc,telefono_empresa,direccion_empresa from empresas_pedidos WHERE razon_empresa LIKE'%" & TXTEMPRESA.Text & "%'"
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

    Private Sub Buscar_Empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView1.Visible = False
    End Sub
End Class
