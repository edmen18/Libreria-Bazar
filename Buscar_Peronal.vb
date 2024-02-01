Public Class Buscar_Peronal
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TXTPROVEEDOR As System.Windows.Forms.TextBox
    Friend WithEvents LBLCODIGOPROVEEDOR As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Buscar_Peronal))
        Me.gbproveedor = New System.Windows.Forms.GroupBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Button3 = New System.Windows.Forms.Button
        Me.TXTPROVEEDOR = New System.Windows.Forms.TextBox
        Me.LBLCODIGOPROVEEDOR = New System.Windows.Forms.Label
        Me.gbproveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbproveedor
        '
        Me.gbproveedor.Controls.Add(Me.ListView3)
        Me.gbproveedor.Controls.Add(Me.Button3)
        Me.gbproveedor.Controls.Add(Me.TXTPROVEEDOR)
        Me.gbproveedor.Controls.Add(Me.LBLCODIGOPROVEEDOR)
        Me.gbproveedor.Location = New System.Drawing.Point(-4, 23)
        Me.gbproveedor.Name = "gbproveedor"
        Me.gbproveedor.Size = New System.Drawing.Size(472, 264)
        Me.gbproveedor.TabIndex = 55
        Me.gbproveedor.TabStop = False
        Me.gbproveedor.Text = "Ingrese Personal"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader11})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(16, 56)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(448, 200)
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(368, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTPROVEEDOR
        '
        Me.TXTPROVEEDOR.Location = New System.Drawing.Point(16, 24)
        Me.TXTPROVEEDOR.Name = "TXTPROVEEDOR"
        Me.TXTPROVEEDOR.Size = New System.Drawing.Size(344, 20)
        Me.TXTPROVEEDOR.TabIndex = 1
        Me.TXTPROVEEDOR.Text = ""
        '
        'LBLCODIGOPROVEEDOR
        '
        Me.LBLCODIGOPROVEEDOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCODIGOPROVEEDOR.Location = New System.Drawing.Point(16, 72)
        Me.LBLCODIGOPROVEEDOR.Name = "LBLCODIGOPROVEEDOR"
        Me.LBLCODIGOPROVEEDOR.Size = New System.Drawing.Size(56, 23)
        Me.LBLCODIGOPROVEEDOR.TabIndex = 0
        Me.LBLCODIGOPROVEEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBLCODIGOPROVEEDOR.Visible = False
        '
        'Buscar_Peronal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 310)
        Me.Controls.Add(Me.gbproveedor)
        Me.Name = "Buscar_Peronal"
        Me.Text = "Buscar_Personal"
        Me.gbproveedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CODIGOPERSONAL = Me.LBLCODIGOPROVEEDOR.Text
        Me.Close()
    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBLCODIGOPROVEEDOR.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TXTPROVEEDOR.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.ListView3.Visible = False
        End If
    End Sub

    Private Sub Buscar_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListView3.Visible = False
    End Sub
    Private Sub TXTPROVEEDOR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPROVEEDOR.KeyPress
        Me.ListView3.Visible = True
        Try
            Me.ListView3.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PE_CODIGO, PE_APELLIDO+' '+PE_NOMBRE,DNI from pERSONAL WHERE PE_APELLIDO+' '+PE_NOMBRE LIKE'%" & TXTPROVEEDOR.Text & "%'"
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

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged

    End Sub
End Class
