Imports System.Data.SqlClient
Public Class Form2
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
    Friend WithEvents txtcategoria As System.Windows.Forms.TextBox
    Friend WithEvents lcategoria As System.Windows.Forms.ListBox
    Friend WithEvents lblcodigocategoria As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLCOD_PRODUCTO As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLVENTAS As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcategoria As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcategoria = New System.Windows.Forms.TextBox
        Me.lcategoria = New System.Windows.Forms.ListBox
        Me.lblcodigocategoria = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblcategoria = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LBLCOD_PRODUCTO = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLVENTAS = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(272, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categoría"
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(160, 56)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(352, 20)
        Me.txtcategoria.TabIndex = 1
        Me.txtcategoria.Text = ""
        '
        'lcategoria
        '
        Me.lcategoria.Location = New System.Drawing.Point(168, 168)
        Me.lcategoria.Name = "lcategoria"
        Me.lcategoria.Size = New System.Drawing.Size(352, 69)
        Me.lcategoria.TabIndex = 2
        '
        'lblcodigocategoria
        '
        Me.lblcodigocategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigocategoria.Location = New System.Drawing.Point(32, 56)
        Me.lblcodigocategoria.Name = "lblcodigocategoria"
        Me.lblcodigocategoria.Size = New System.Drawing.Size(104, 20)
        Me.lblcodigocategoria.TabIndex = 3
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 192)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 130
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(632, 192)
        Me.DataGrid1.TabIndex = 5
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.Info
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscar.Image = CType(resources.GetObject("btnbuscar.Image"), System.Drawing.Image)
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.Location = New System.Drawing.Point(8, 8)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(80, 40)
        Me.btnbuscar.TabIndex = 6
        Me.btnbuscar.Text = "&Buscar"
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(656, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcategoria)
        Me.GroupBox1.Controls.Add(Me.lblcodigocategoria)
        Me.GroupBox1.Controls.Add(Me.lblcategoria)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 88)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Código"
        '
        'lblcategoria
        '
        Me.lblcategoria.Location = New System.Drawing.Point(312, 104)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(48, 23)
        Me.lblcategoria.TabIndex = 4
        Me.lblcategoria.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 64)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(120, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "categoria"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Producto"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.LBLCOD_PRODUCTO)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LBLVENTAS)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(624, 88)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(456, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Marca"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLCOD_PRODUCTO
        '
        Me.LBLCOD_PRODUCTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCOD_PRODUCTO.Location = New System.Drawing.Point(8, 48)
        Me.LBLCOD_PRODUCTO.Name = "LBLCOD_PRODUCTO"
        Me.LBLCOD_PRODUCTO.Size = New System.Drawing.Size(96, 20)
        Me.LBLCOD_PRODUCTO.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(392, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 20)
        Me.Label9.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(-24, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 8)
        Me.Label14.TabIndex = 34
        Me.Label14.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 8)
        Me.Label10.TabIndex = 15
        Me.Label10.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(264, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLVENTAS
        '
        Me.LBLVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLVENTAS.Location = New System.Drawing.Point(128, 16)
        Me.LBLVENTAS.Name = "LBLVENTAS"
        Me.LBLVENTAS.Size = New System.Drawing.Size(8, 8)
        Me.LBLVENTAS.TabIndex = 3
        Me.LBLVENTAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLVENTAS.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(96, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 8)
        Me.Label3.TabIndex = 16
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'ListView3
        '
        Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(120, 160)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(352, 80)
        Me.ListView3.TabIndex = 44
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Código"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Producto"
        Me.ColumnHeader5.Width = 104
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Marca"
        Me.ColumnHeader9.Width = 124
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Precio"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(8, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "&Reporte de Productos "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(8, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 80)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "&Reporte de Productos Escasos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Location = New System.Drawing.Point(648, 192)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(96, 192)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Info
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "&Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnbuscar)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Location = New System.Drawing.Point(648, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(96, 96)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 446)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lcategoria)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Consulta Stock"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dt2 As DataTable
    Private da2 As SqlDataAdapter
    Private seleccion2 As String = "SELECT DESCRIPCION FROM categorias"
    Private INICIANDO2 As Boolean = True
    Private dt As DataTable
    Private da As SqlDataAdapter
    Private DT1 As DataTable
    Private DA1 As SqlDataAdapter

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtcategoria.Text = ""
        da2 = New SqlDataAdapter(seleccion2, cn)
        dt2 = New DataTable
        da2.Fill(dt2)
        INICIANDO2 = False
        Me.lcategoria.Visible = False
        Me.GroupBox1.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView3.Visible = False

    End Sub

    Private Sub txtcategoria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcategoria.TextChanged
        If INICIANDO2 Then Exit Sub

        ' Buscar en el DataTable usando el método Select
        ' que es como un filtro WHERE en una cadena de selección.

        ' El resultado se devuelve como un array de tipo DataRow
        Dim filas() As DataRow

        ' Si solo quieres mostrar los que empiecen por lo escrito.
        ' Al escribir "s" se buscarán los que empiecen por esa letra.
        filas = dt2.Select("DESCRIPCION LIKE '" & txtcategoria.Text & "%'")

        ' Borrar los elementos anteriores
        Me.lcategoria.Items.Clear()

        ' Si hay datos, mostrar los apellidos
        If filas.Length > 0 Then

            ' Recorrer cada fila y mostrar los apellidos
            For Each dr As DataRow In filas

                Me.lcategoria.Items.Add( _
                            dr("DESCRIPCION").ToString)

            Next
            Me.lcategoria.Visible = True
        End If
    End Sub

    Private Sub lcategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lcategoria.SelectedIndexChanged
        If INICIANDO2 Then Exit Sub
        '     Al hacer clic, mostrar el dato
        Me.txtcategoria.Text = Me.lcategoria.SelectedItem.ToString
        Me.lblcategoria.Text = Me.txtcategoria.Text
        Try
            Dim CONT As Integer
            cm.CommandText = "SELECT COD_categoria FROM categorias WHERE DESCRIPCION ='" + Me.lblcategoria.Text + "'"
            cm.Connection = cn
            cn.Open()
            cm.CommandType = CommandType.Text
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                Do While dr.Read
                    Me.lblcodigocategoria.Text = dr(0).ToString
                Loop
            Else
                MsgBox("No se encontro el usuario", MsgBoxStyle.Exclamation)
                cn.Close()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cn.Close()
        Me.lcategoria.Visible = False
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Me.ListView3.Visible = False
        If Me.RadioButton2.Checked Then
            Dim seleccion As String = "SELECT p.pro_codigo as Código,PRO_DESCRIPCION as Producto,pro_precio as Precio,m.descripcion as Marca,CONVERT(VARCHAR(5),PRO_STOCK)+' '+PRO_UNIDAD as Stock_Actual,PRO_STOCKMIN as Mínimo,PRO_STOCKMAX as Máximo FROM STOCK S INNER JOIN PRODUCTO P ON P.PRO_CODIGO=S.PRO_CODIGO INNER JOIN CATEGORIAS C ON C.COD_CATEGORIA=P.COD_CATEGORIA inner join marca m on p.cod_marca=m.cod_marca WHERE C.COD_CATEGORIA='" + Me.lblcodigocategoria.Text + "' "
            da = New SqlDataAdapter(seleccion, cn)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid1.DataSource = dt
        End If
        If Me.RadioButton1.Checked Then
            Dim seleccion As String = "SELECT p.pro_codigo as Código,PRO_DESCRIPCION as Producto,pro_precio as Precio,m.descripcion as Marca,CONVERT(VARCHAR(5),PRO_STOCK)+' '+PRO_UNIDAD as Stock_Actual,PRO_STOCKMIN as Mínimo,PRO_STOCKMAX as Máximo FROM STOCK S INNER JOIN PRODUCTO P ON P.PRO_CODIGO=S.PRO_CODIGO inner join marca m on p.cod_marca=m.cod_marca WHERE P.PRO_CODIGO='" + Me.LBLCOD_PRODUCTO.Text + "'"
            da = New SqlDataAdapter(seleccion, cn)
            dt = New DataTable
            da.Fill(dt)
            Me.DataGrid1.DataSource = dt
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtcategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcategoria.KeyPress
        Me.lcategoria.Visible = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.GroupBox1.Visible = True
        Me.GroupBox3.Visible = False
        cancelar1()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox1.Visible = False
        Me.GroupBox3.Visible = True
        cancelar1()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.ListView3.Visible = True

        Try
            Me.ListView3.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT PRO_CODIGO, PRO_DESCRIPCION,M.DESCRIPCION, PRO_PRECIO FROM PRODUCTO P INNER JOIN MARCA M ON M.COD_MARCA=P.COD_MARCA WHERE PRO_DESCRIPCION LIKE'%" & TextBox3.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView3.Items.Add(CStr((datar(0))), 1)
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    Me.ListView3.Items(I).SubItems.Add(CStr(datar(3).ToString))
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As New Stock_actual
        a.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pa As New PRODUCTOS_ESCASOS
        pa.ShowDialog()
    End Sub

    Private Sub ListView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.DoubleClick
        If Me.ListView3.SelectedItems.Count > 0 Then
            Me.LBLCOD_PRODUCTO.Text = Me.ListView3.SelectedItems(0).SubItems(0).Text
            Me.TextBox3.Text = Me.ListView3.SelectedItems(0).SubItems(1).Text
            Me.Label9.Text = Me.ListView3.SelectedItems(0).SubItems(2).Text
        End If
        Me.ListView3.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cancelar()
    End Sub
    Sub cancelar()
        Me.lblcodigocategoria.ResetText()
        Me.lblcategoria.ResetText()
        Me.txtcategoria.ResetText()
        Me.LBLCOD_PRODUCTO.ResetText()
        Me.TextBox3.ResetText()
        Me.Label9.ResetText()
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.GroupBox1.Visible = False
        Me.GroupBox3.Visible = False
        Me.lcategoria.Visible = False
        Me.ListView3.Visible = False
    End Sub
    Sub cancelar1()
        Me.lblcodigocategoria.ResetText()
        Me.lblcategoria.ResetText()
        Me.txtcategoria.ResetText()
        Me.LBLCOD_PRODUCTO.ResetText()
        Me.TextBox3.ResetText()
        Me.Label9.ResetText()
        Me.lcategoria.Visible = False
        Me.ListView3.Visible = False
    End Sub
End Class
