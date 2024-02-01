Imports System.Data.SqlClient
Public Class Buscar_Marca
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents listamarca As System.Windows.Forms.ListBox
    Friend WithEvents LBLCODMARCA As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Buscar_Marca))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LBLCODMARCA = New System.Windows.Forms.Label
        Me.txtmarca = New System.Windows.Forms.TextBox
        Me.listamarca = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.listamarca)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.LBLCODMARCA)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Marca"
        '
        'LBLCODMARCA
        '
        Me.LBLCODMARCA.Location = New System.Drawing.Point(32, 48)
        Me.LBLCODMARCA.Name = "LBLCODMARCA"
        Me.LBLCODMARCA.Size = New System.Drawing.Size(48, 24)
        Me.LBLCODMARCA.TabIndex = 2
        Me.LBLCODMARCA.Visible = False
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(8, 16)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(248, 20)
        Me.txtmarca.TabIndex = 1
        Me.txtmarca.Text = ""
        '
        'listamarca
        '
        Me.listamarca.Location = New System.Drawing.Point(8, 48)
        Me.listamarca.Name = "listamarca"
        Me.listamarca.Size = New System.Drawing.Size(248, 147)
        Me.listamarca.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(264, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Buscar_Marca
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 238)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Buscar_Marca"
        Me.Text = "Buscar_Marca"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dat As DataTable
    Private dta As SqlDataAdapter
    Private seleccion As String = "SELECT descripcion FROM marca"
    Private iniciando As Boolean = True
    Private Sub Buscar_Marca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dta = New SqlDataAdapter(seleccion, cn)
        dat = New DataTable
        dta.Fill(dat)
        iniciando = False
        Me.listamarca.Visible = False

    End Sub

    Private Sub txtmarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarca.TextChanged
        If iniciando Then Exit Sub

        ' Buscar en el DataTable usando el método Select
        ' que es como un filtro WHERE en una cadena de selección.

        ' El resultado se devuelve como un array de tipo DataRow
        Dim filas() As DataRow

        ' Si solo quieres mostrar los que empiecen por lo escrito.
        ' Al escribir "s" se buscarán los que empiecen por esa letra.
        filas = dat.Select("DESCRIPCION LIKE '%" & txtmarca.Text & "%'")

        ' Borrar los elementos anteriores
        Me.listamarca.Items.Clear()

        ' Si hay datos, mostrar los apellidos
        If filas.Length > 0 Then

            ' Recorrer cada fila y mostrar los apellidos
            For Each dr As DataRow In filas

                Me.listamarca.Items.Add( _
                            dr("DESCRIPCION").ToString)

            Next
        End If
    End Sub

    Private Sub listamarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listamarca.SelectedIndexChanged
        If iniciando Then Exit Sub
        '     Al hacer clic, mostrar el dato
        Me.txtmarca.Text = Me.listamarca.SelectedItem.ToString
        Try
            Dim CONT As Integer
            cm.CommandText = "SELECT cod_marca FROM marca WHERE DESCRIPCION='" + Me.txtmarca.Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.LBLCODMARCA.Text = dr(0).ToString
                Loop
            Else
                MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.listamarca.Visible = False
    End Sub

    Private Sub txtmarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        Me.listamarca.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        COD_MARCA = Me.LBLCODMARCA.Text
        NOMBREMARCA = Me.txtmarca.Text
        Me.Close()
    End Sub
End Class
