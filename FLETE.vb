Public Class FLETE
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
    Friend WithEvents gbfactura As System.Windows.Forms.GroupBox
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblcodigofactura As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lstguias As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FLETE))
        Me.gbfactura = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblcodigofactura = New System.Windows.Forms.Label
        Me.txtfactura = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.lstguias = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.gbfactura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbfactura
        '
        Me.gbfactura.Controls.Add(Me.Button3)
        Me.gbfactura.Controls.Add(Me.txtmonto)
        Me.gbfactura.Controls.Add(Me.Label2)
        Me.gbfactura.Controls.Add(Me.Label1)
        Me.gbfactura.Controls.Add(Me.lblcodigofactura)
        Me.gbfactura.Controls.Add(Me.txtfactura)
        Me.gbfactura.Controls.Add(Me.Label29)
        Me.gbfactura.Location = New System.Drawing.Point(8, 16)
        Me.gbfactura.Name = "gbfactura"
        Me.gbfactura.Size = New System.Drawing.Size(208, 192)
        Me.gbfactura.TabIndex = 65
        Me.gbfactura.TabStop = False
        Me.gbfactura.Text = "Datos Factura"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(48, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 40)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "&Agregar Guia Remisión"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(64, 112)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(136, 20)
        Me.txtmonto.TabIndex = 6
        Me.txtmonto.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'lblcodigofactura
        '
        Me.lblcodigofactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigofactura.Location = New System.Drawing.Point(64, 24)
        Me.lblcodigofactura.Name = "lblcodigofactura"
        Me.lblcodigofactura.Size = New System.Drawing.Size(136, 23)
        Me.lblcodigofactura.TabIndex = 3
        '
        'txtfactura
        '
        Me.txtfactura.Location = New System.Drawing.Point(64, 72)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(136, 20)
        Me.txtfactura.TabIndex = 1
        Me.txtfactura.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Número"
        '
        'lstguias
        '
        Me.lstguias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstguias.GridLines = True
        Me.lstguias.Location = New System.Drawing.Point(224, 16)
        Me.lstguias.Name = "lstguias"
        Me.lstguias.Size = New System.Drawing.Size(416, 192)
        Me.lstguias.TabIndex = 66
        Me.lstguias.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código_Guia"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Número"
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Estado"
        Me.ColumnHeader5.Width = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 64)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "&Grabar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(112, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "&Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Info
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(208, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(88, 40)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "&Salir"
        '
        'FLETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 286)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstguias)
        Me.Controls.Add(Me.gbfactura)
        Me.Name = "FLETE"
        Me.Text = "Registrar Flete"
        Me.gbfactura.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public LISTA As ListViewItem
    Public band As Integer
    Private Sub FLETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generarfactura()
    End Sub
    Sub cancelar()
        Me.lstguias.Items.Clear()
        Me.txtfactura.ResetText()
        Me.txtmonto.ResetText()
    End Sub
    Sub generarfactura()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from factura_guia"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.lblcodigofactura.Text = CStr(datar(0))
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub
    Sub guardarfactura()
        Try
            cn.Open()
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "Insert INTO factura_guia(codigo_factura,numero_factura,MONTO) values ('" + Me.lblcodigofactura.Text + "','" + Me.txtfactura.Text + "','" + Me.txtmonto.Text + "')"
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
        cn.Close()
    End Sub
    Sub actualizarguias()
        Dim m As Integer
        For m = 0 To Me.lstguias.Items.Count - 1
            Try
                cn.Open()
                Dim a As Integer
                Dim b As Integer
                cm.CommandType = CommandType.Text
                cm.CommandText = "update guia_remision set estado='cancelado', codigo_factura='" + Me.lblcodigofactura.Text + "'where codigo_guia='" + Me.lstguias.Items(m).SubItems(0).Text + "'"
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
            cn.Close()
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As New Guias
        a.ShowDialog(Me)
    End Sub

    Private Sub FLETE_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If A <> "" And C <> "" And D <> "" And Q <> "" Then
            validardatosrepetidos()
            If band = 0 Then
                Dim LISTA As ListViewItem
                LISTA = Me.lstguias.Items.Add(A)
                LISTA.SubItems.Add(C)
                LISTA.SubItems.Add(D)
                LISTA.SubItems.Add(Q)
                A = ""
                C = ""
                D = ""
                Q = ""
            End If
        End If
    End Sub
    Sub validardatosrepetidos()
        Dim j As Integer
        band = 0
        For j = 0 To Me.lstguias.Items.Count - 1
            If Me.lstguias.Items(j).SubItems(0).Text = A Then
                band = band + 1
            End If
        Next
        'If band > 0 Then
        '    MsgBox("Esta Guia de Remisión ya fue agregada", MsgBoxStyle.Critical)
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        guardarfactura()
        actualizarguias()
        cancelar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancelar()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
