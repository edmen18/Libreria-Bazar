Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    Public KeyAscii As Short
    Public KeyAscii1 As Short
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
    Friend WithEvents BTNRETORNAR As System.Windows.Forms.Button
    Friend WithEvents BTNEDITAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNACTUALIZAR As System.Windows.Forms.Button
    Friend WithEvents BTNAGREGAR As System.Windows.Forms.Button
    Friend WithEvents TXTAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LBLCOD_CLIENTE As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTTELEFONO1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLTC As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.BTNRETORNAR = New System.Windows.Forms.Button
        Me.BTNEDITAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNACTUALIZAR = New System.Windows.Forms.Button
        Me.BTNAGREGAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXTTELEFONO1 = New System.Windows.Forms.TextBox
        Me.TXTAPELLIDO = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LBLCOD_CLIENTE = New System.Windows.Forms.Label
        Me.LBLTC = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNRETORNAR
        '
        Me.BTNRETORNAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNRETORNAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRETORNAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRETORNAR.Image = CType(resources.GetObject("BTNRETORNAR.Image"), System.Drawing.Image)
        Me.BTNRETORNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNRETORNAR.Location = New System.Drawing.Point(8, 216)
        Me.BTNRETORNAR.Name = "BTNRETORNAR"
        Me.BTNRETORNAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNRETORNAR.TabIndex = 32
        Me.BTNRETORNAR.Text = "&Salir"
        Me.BTNRETORNAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 176)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNCANCELAR.TabIndex = 29
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNACTUALIZAR
        '
        Me.BTNACTUALIZAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNACTUALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNACTUALIZAR.Image = CType(resources.GetObject("BTNACTUALIZAR.Image"), System.Drawing.Image)
        Me.BTNACTUALIZAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACTUALIZAR.Location = New System.Drawing.Point(8, 136)
        Me.BTNACTUALIZAR.Name = "BTNACTUALIZAR"
        Me.BTNACTUALIZAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNACTUALIZAR.TabIndex = 28
        Me.BTNACTUALIZAR.Text = "&Editar"
        Me.BTNACTUALIZAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.BackColor = System.Drawing.SystemColors.Info
        Me.BTNAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Image = CType(resources.GetObject("BTNAGREGAR.Image"), System.Drawing.Image)
        Me.BTNAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAGREGAR.Location = New System.Drawing.Point(8, 96)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(96, 40)
        Me.BTNAGREGAR.TabIndex = 27
        Me.BTNAGREGAR.Text = "&Grabar"
        Me.BTNAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTTELEFONO1)
        Me.GroupBox1.Controls.Add(Me.TXTAPELLIDO)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LBLCOD_CLIENTE)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 272)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(520, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.Text = "No posee"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(112, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(480, 22)
        Me.ComboBox1.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Tipo_Cliente"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Teléfono"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dni"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Apellidos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXTTELEFONO1
        '
        Me.TXTTELEFONO1.Location = New System.Drawing.Point(112, 200)
        Me.TXTTELEFONO1.Name = "TXTTELEFONO1"
        Me.TXTTELEFONO1.Size = New System.Drawing.Size(480, 20)
        Me.TXTTELEFONO1.TabIndex = 10
        Me.TXTTELEFONO1.Text = ""
        '
        'TXTAPELLIDO
        '
        Me.TXTAPELLIDO.Location = New System.Drawing.Point(112, 88)
        Me.TXTAPELLIDO.Name = "TXTAPELLIDO"
        Me.TXTAPELLIDO.Size = New System.Drawing.Size(480, 20)
        Me.TXTAPELLIDO.TabIndex = 7
        Me.TXTAPELLIDO.Text = ""
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(112, 120)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(480, 20)
        Me.txtnombre.TabIndex = 8
        Me.txtnombre.Text = ""
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(112, 56)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(400, 20)
        Me.txtdni.TabIndex = 6
        Me.txtdni.Text = ""
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(112, 160)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(480, 20)
        Me.txtdireccion.TabIndex = 9
        Me.txtdireccion.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Código"
        '
        'LBLCOD_CLIENTE
        '
        Me.LBLCOD_CLIENTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCOD_CLIENTE.Location = New System.Drawing.Point(112, 16)
        Me.LBLCOD_CLIENTE.Name = "LBLCOD_CLIENTE"
        Me.LBLCOD_CLIENTE.Size = New System.Drawing.Size(480, 20)
        Me.LBLCOD_CLIENTE.TabIndex = 13
        '
        'LBLTC
        '
        Me.LBLTC.Location = New System.Drawing.Point(608, 304)
        Me.LBLTC.Name = "LBLTC"
        Me.LBLTC.Size = New System.Drawing.Size(32, 16)
        Me.LBLTC.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "&Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.BTNAGREGAR)
        Me.GroupBox3.Controls.Add(Me.BTNEDITAR)
        Me.GroupBox3.Controls.Add(Me.BTNACTUALIZAR)
        Me.GroupBox3.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox3.Controls.Add(Me.BTNRETORNAR)
        Me.GroupBox3.Location = New System.Drawing.Point(648, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 272)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Black
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(24, 320)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 100
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(736, 208)
        Me.DataGrid1.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(712, 536)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(584, 536)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Total de Clientes"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(776, 566)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLTC)
        Me.Name = "Form1"
        Me.Text = "Registro de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dat1 As DataTable
    Private dta1 As SqlDataAdapter
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DESACTIVAR()
        Me.BTNRETORNAR.Enabled = True
        cargar()
        generar2()
        LLENARCOMBO()
    End Sub
    Sub LLENARCOMBO()
        cn.Open()
        Me.ComboBox1.ResetText()
        Dim datRead As SqlDataReader
        cm = New SqlCommand("Select DESCRIPCION From TIPO_CLIENTE order by descripcion", cn)
        datRead = cm.ExecuteReader
        While datRead.Read()
            Me.ComboBox1.Items.Add(datRead.Item(0))
        End While
        datRead.Close()
        cn.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cn.Open()
        Dim datARead As SqlDataReader
        cm = New SqlCommand("Select TC_codigo From TIPO_CLIENTE WHERE DESCRIPCION ='" + Me.ComboBox1.Text + "'", cn)
        datARead = cm.ExecuteReader
        While datARead.Read()
            Me.LBLTC.Text = datARead(0).ToString
        End While
        cn.Close()
    End Sub
    Sub cargar()
        Dim seleccion1 As String = "select CL_CODIGO AS Código,CL_APELLIDOS as Apellidos,CL_NOMBRES as Nombres,CL_DNI as Dni,CL_DIRECCION as Dirección,TELEFONO as Teléfono,DESCRIPCION as Tipo_Cliente from clientes C INNER JOIN TIPO_CLIENTE TC ON TC.TC_CODIGO=C.TC_CODIGO"
        dta1 = New SqlDataAdapter(seleccion1, cn)
        dat1 = New DataTable
        dta1.Fill(dat1)
        Me.DataGrid1.DataSource = dat1
    End Sub
    Sub LIMPIAR()
        Me.RadioButton1.Checked = False
        Me.TXTAPELLIDO.ResetText()
        Me.txtnombre.ResetText()
        Me.txtdni.ResetText()
        Me.txtdireccion.ResetText()
        Me.TXTTELEFONO1.ResetText()
        Me.LBLCOD_CLIENTE.ResetText()
        Me.ComboBox1.Text = ""
        Me.LBLTC.ResetText()
    End Sub
    Function SoloLETRAS(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        ' Intercepta un código ASCII recibido admitiendo solamente
        ' letras, además:
        ' deja pasar sin afectar si recibe tecla de Backspace o enter
        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", Chr(KeyAscii)) = 0 Then
            SoloLETRAS = 0
        Else
            SoloLETRAS = KeyAscii
        End If
        ' teclas adicionales permitidas
        If KeyAscii = 8 Then SoloLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoloLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoloLETRAS = KeyAscii
    End Function
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Sub ACTIVAR()
        Me.BTNACTUALIZAR.Enabled = True
        Me.BTNAGREGAR.Enabled = True
        Me.TXTAPELLIDO.Enabled = True
        Me.txtdireccion.Enabled = True
        Me.txtdni.Enabled = True
        Me.txtnombre.Enabled = True
        Me.TXTTELEFONO1.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.RadioButton1.Enabled = True
    End Sub
    Sub DESACTIVAR()
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNAGREGAR.Enabled = False
        Me.TXTAPELLIDO.Enabled = False
        Me.txtdireccion.Enabled = False
        Me.txtdni.Enabled = False
        Me.txtnombre.Enabled = False
        Me.TXTTELEFONO1.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.LBLTC.ResetText()
        Me.RadioButton1.Enabled = False
    End Sub

    Private Sub BTNAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAGREGAR.Click
        If Me.TXTAPELLIDO.Text = "" Or Me.txtnombre.Text = "" Or Me.txtdireccion.Text = "" Or Me.TXTTELEFONO1.Text = "" Then
            MsgBox("INGRESE DATOS CORRECTOS", MsgBoxStyle.Information)
        Else

            Try
                Dim a As Integer
                cn.Open()
                cm.CommandType = CommandType.Text
                cm.CommandText = "Insert Into CLIENTES (Cl_CODIGO,Cl_APELLIDOS,Cl_NOMBRES,CL_DNI,CL_DIRECCION,TELEFONO,TC_CODIGO) values ('" + Me.LBLCOD_CLIENTE.Text + "','" + Me.txtnombre.Text + "','" + Me.TXTAPELLIDO.Text + "','" + Me.txtdni.Text + "','" + Me.txtdireccion.Text + "','" + Me.TXTTELEFONO1.Text + " ','" + Me.LBLTC.Text + " ')"
                cm.Connection = cn
                a = cm.ExecuteNonQuery
                MsgBox("Datos Guardados", MsgBoxStyle.Information)
                cn.Close()
            Catch ex As Exception
                MsgBox("DATOS NO SE GUARDARON CORRECTAMENTE..." + ex.Message, MsgBoxStyle.Information)
                cn.Close()
            End Try
            cargar()
            LIMPIAR()
            generar2()
            cancelar()
            cn.Close()
        End If
        cn.Close()
    End Sub
    Sub generar()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*)+1 from CLIENTES"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.LBLCOD_CLIENTE.Text = "CL0" + CStr(datar(0))
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
    Sub generar2()
        Try
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = "select count(*) from CLIENTES"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            If datar.HasRows Then
                While datar.Read
                    Me.Label6.Text = CStr(datar(0))
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
        ACTIVAR()
        LIMPIAR()
        generar()
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNEDITAR.Enabled = False
    End Sub

    Private Sub BTNEDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEDITAR.Click
        Dim B As New Buscar_Cliente
        B.ShowDialog()
        If CCLIENTE = "" Then
            Me.BTNEDITAR.Enabled = True
            CCLIENTE = ""
        Else
            Me.LBLCOD_CLIENTE.Text = CCLIENTE
            llena()
            CCLIENTE = ""
            Me.Button1.Enabled = False
            Me.BTNAGREGAR.Enabled = False
        End If
    End Sub
    Sub llena()
        Dim i, j As Integer
        Try
            cn.Close()
            cn.Open()
            cm.CommandText = "Select CL_CODIGO, CL_NOMBRES, CL_APELLIDOS,CL_DNI,CL_DIRECCION, TELEFONO,TC.TC_CODIGO,TC.DESCRIPCION from CLIENTES C INNER JOIN TIPO_CLIENTE TC ON TC.TC_CODIGO=C.TC_CODIGO WHERE cl_codigo='" + Me.LBLCOD_CLIENTE.Text + "'"
            cm.Connection = cn
            Dim dr As SqlClient.SqlDataReader
            dr = cm.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.HasRows Then
                ACTIVAR()
                Do While dr.Read
                    Me.LBLCOD_CLIENTE.Text = dr(0).ToString
                    Me.TXTAPELLIDO.Text = dr(1).ToString
                    Me.txtnombre.Text = dr(2).ToString
                    Me.txtdni.Text = dr(3).ToString
                    Me.txtdireccion.Text = dr(4).ToString
                    Me.TXTTELEFONO1.Text = dr(5).ToString
                    Me.LBLTC.Text = dr(6).ToString
                    Me.ComboBox1.Text = dr(7).ToString
                Loop
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        Me.BTNAGREGAR.Enabled = False
        Me.BTNEDITAR.Enabled = False
        Me.BTNRETORNAR.Enabled = False
        cn.Close()
    End Sub

    Private Sub BTNACTUALIZAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACTUALIZAR.Click
        cn.Open()
        Try
            Dim a As Integer
            Dim b As Integer
            cm.CommandType = CommandType.Text
            cm.CommandText = "UPDATE CLIENTES SET CL_APELLIDOS = '" + Me.txtnombre.Text + "',CL_NOMBRES= '" + Me.TXTAPELLIDO.Text + "',CL_DNI = '" + Me.txtdni.Text + "',CL_DIRECCION = '" + Me.txtdireccion.Text + "',TELEFONO = '" + Me.TXTTELEFONO1.Text + "',TC_CODIGO='" + Me.LBLTC.Text + "'  WHERE CL_CODIGO='" + Me.LBLCOD_CLIENTE.Text + "'"
            cm.Connection = cn
            a = cm.ExecuteNonQuery()
            If a >= 1 Then
                MsgBox("Datos Actualizados", MsgBoxStyle.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            cn.Close()
        End Try
        cargar()
        LIMPIAR()
        DESACTIVAR()
        Me.Button1.Enabled = True
        Me.BTNEDITAR.Enabled = True
        Me.BTNRETORNAR.Enabled = True
        LIMPIAR()
        cancelar()
    End Sub

    Private Sub BTNRETORNAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRETORNAR.Click
        If MsgBox("¿Desea salir de la ventana?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            cn.Close()
            Me.Close()
        End If
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        'If MsgBox("¿DESEA CANCELAR LA ACCIÓN?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
        cancelar()
        'End If
    End Sub
    Sub cancelar()
        DESACTIVAR()
        Me.Button1.Enabled = True
        Me.BTNEDITAR.Enabled = True
        Me.BTNRETORNAR.Enabled = True
        LIMPIAR()
        Me.ComboBox1.Items.Clear()
        LLENARCOMBO()
        cn.Close()
    End Sub
    Private Sub TXTAPELLIDO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAPELLIDO.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloLETRAS(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TXTTELEFONO1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTTELEFONO1.KeyPress
        Dim KeyAscii1 As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii1))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.txtdni.Text = "No posee"
        Me.ComboBox1.Items.Clear()
        LLENARCOMBO()
    End Sub
End Class
