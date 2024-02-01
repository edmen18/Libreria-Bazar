Public Class MENÚ
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MENÚ))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem17, Me.MenuItem7, Me.MenuItem38, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem41, Me.MenuItem24, Me.MenuItem2, Me.MenuItem43, Me.MenuItem42, Me.MenuItem8, Me.MenuItem31, Me.MenuItem39, Me.MenuItem14})
        Me.MenuItem1.Text = "Mantenimiento"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Productos"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 1
        Me.MenuItem41.Text = "Categorias"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Text = "Marcas"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "Clientes"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 4
        Me.MenuItem43.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem44, Me.MenuItem13, Me.MenuItem46})
        Me.MenuItem43.Text = "Personal"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 0
        Me.MenuItem44.Text = "Registrar"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "Registrar usuario y contraseña"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Text = "Cambiar Contraseña"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 5
        Me.MenuItem42.Text = "Tipo de Cliente"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "Proveedores"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 7
        Me.MenuItem31.Text = "Empresas"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 8
        Me.MenuItem39.Text = "Igv"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 9
        Me.MenuItem14.Text = "Limite de credito"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem47, Me.MenuItem48, Me.MenuItem51, Me.MenuItem6})
        Me.MenuItem3.Text = "Operaciones"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = " Ventas"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem50})
        Me.MenuItem47.Text = "Compras"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "Boletas"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "Facturas"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.Text = "Pedidos"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 3
        Me.MenuItem51.Text = "Amortizaciones"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "Costo de Carga"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem21, Me.MenuItem15, Me.MenuItem30, Me.MenuItem45})
        Me.MenuItem17.Text = "Consultas"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Text = "Stock_Actual"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Text = "Ventas"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem53})
        Me.MenuItem15.Text = "Compras"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Text = "Boletas"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 1
        Me.MenuItem53.Text = "Facturas"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 3
        Me.MenuItem30.Text = "Pedidos"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 4
        Me.MenuItem45.Text = "Guia de Remisión"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem19, Me.MenuItem22, Me.MenuItem40, Me.MenuItem28})
        Me.MenuItem7.Text = "Reportes"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem54, Me.MenuItem55})
        Me.MenuItem10.Text = "Proveedores Actuales"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Ventas"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem12.Text = "Compras"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "Compras"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Boletas"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "Facturas"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem37, Me.MenuItem23, Me.MenuItem20})
        Me.MenuItem19.Text = "Productos"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 0
        Me.MenuItem37.Text = "Stock de Productos"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Productos mas Consumidos"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "Productos por adquirir"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem35, Me.MenuItem29})
        Me.MenuItem22.Text = "Clientes"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 0
        Me.MenuItem35.Text = "Clientes actuales"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33})
        Me.MenuItem29.Text = "Clientes Deudores"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Text = "Deuda Total"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Text = "Deuda por fechas"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 5
        Me.MenuItem40.Text = "Pedidos"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 6
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem34, Me.MenuItem36})
        Me.MenuItem28.Text = "Consolidado"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 0
        Me.MenuItem34.Text = "Entradas y Salidas"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 1
        Me.MenuItem36.Text = "Balance"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 4
        Me.MenuItem38.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem52})
        Me.MenuItem38.Text = "Ayuda"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 0
        Me.MenuItem52.Text = "Manual de Usuario"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(120, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(760, 47)
        Me.ToolBar1.TabIndex = 5
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 5
        Me.ToolBarButton1.Text = "&Productos"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 2
        Me.ToolBarButton2.Text = "&Clientes"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 3
        Me.ToolBarButton3.Text = "&Ventas"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 1
        Me.ToolBarButton4.Text = "&Facturas"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 4
        Me.ToolBarButton5.Text = "&Pedidos"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 6
        Me.ToolBarButton6.Text = "&Amortizaciones"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 7
        Me.ToolBarButton7.Text = "&Salir"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 329)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(760, 32)
        Me.StatusBar1.TabIndex = 7
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 870
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(616, 224)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sistema Informático para el Control de Compra y Venta de Librería Bazar Ingenierí" & _
        "a y Negocios Generales E.I.R.L."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 0
        Me.MenuItem54.Text = "General"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        Me.MenuItem55.Text = "Por Categoría"
        '
        'MENÚ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(15, 33)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu = Me.MainMenu1
        Me.Name = "MENÚ"
        Me.Text = "Librería Bazar Ingeniería"
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim wb As Object
    Private Sub MENÚ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SEGURIDAD As New INICIO_DE_SESION
        SEGURIDAD.ShowDialog()
        Label1.Text = CODIGOP
        Me.StatusBarPanel1.Text = NOMBRE
        Me.StatusBarPanel2.Text = Date.Today

        If Me.Label1.Text = "" Then
            MsgBox("Debe ingresar un usuario y contraseña", MsgBoxStyle.Critical)
            Me.Close()
        Else
            If CODIGOUNICO = "N2" Then
                'MsgBox("VENDEDOR", MsgBoxStyle.Critical)
                Me.MenuItem1.Enabled = False
                Me.ToolBarButton4.Enabled = False
                Me.MenuItem47.Enabled = False
                Me.MenuItem6.Enabled = False
                Me.ToolBarButton1.Enabled = False
                Me.ToolBarButton2.Enabled = False
            Else
                'MsgBox("ADMINISTRADOR", MsgBoxStyle.Critical)
            End If
        End If
        cn.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim A As New Form1
        A.ShowDialog()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim venta As New REGISTRAR_VENTA
        venta.ShowDialog()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim PRODUCTO As New PRODUCTOS
        PRODUCTO.ShowDialog()

    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim CTR As New REPORTE_DE_COMPRAS
        CTR.ShowDialog()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim PROVEEDOR As New MANTENEDOR_DE_PROVEEDORES
        PROVEEDOR.ShowDialog()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case Me.ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                Dim a As New PRODUCTOS
                a.ShowDialog()
            Case 1
                Dim b As New Form1
                b.ShowDialog()
            Case 2
                Dim c As New REGISTRAR_VENTA
                c.ShowDialog()
            Case 3
                Dim d As New Registro_de_compras
                d.ShowDialog()
            Case 4
                Dim a As New PEDIDOS
                a.ShowDialog()
            Case 5
                Dim a As New AMORTIZACIONES
                a.ShowDialog()
            Case 6
                If MsgBox("¿Desea salir del sistema ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
                    Me.Close()
                End If
        End Select

    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim c1 As New Form2
        c1.ShowDialog()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim pa As New PRODUCTOS_ESCASOS
        pa.ShowDialog()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim ventas As New Cosultas
        ventas.ShowDialog()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim m As New Marcas
        m.ShowDialog()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim boletas As New Reporte_de_boletas
        boletas.ShowDialog()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click

    End Sub

    Private Sub StatusBar1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles StatusBar1.PanelClick

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim ore As New Consulta_pedidos
        ore.ShowDialog()
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Dim em As New MANTENEDOR_DE_EMPRESAS
        em.ShowDialog()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim d As New Clientes_Deudores
        d.ShowDialog()
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Dim d As New Form3
        d.ShowDialog()
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Dim con As New Consolidado
        con.ShowDialog()
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Dim a As New Consulta_Consolidada
        a.ShowDialog()
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim a As New Stock_actual
        a.ShowDialog()
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        Dim igv As New Igv
        igv.ShowDialog()
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim d As New PEDIDOS
        d.ShowDialog()

    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim a As New Reporte_de_pedidos
        a.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub MenuItem41_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        Dim a As New Categorias
        a.ShowDialog()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim f As New Reporte_Facturas
        f.ShowDialog()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim am As New Tipo_Cliente
        am.ShowDialog()
    End Sub

    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Dim con As New balance
        con.ShowDialog()
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim cli As New Reporte_de_clientes
        cli.ShowDialog()
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Dim p As New Personal
        p.ShowDialog()
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim bol As New Boletas
        bol.ShowDialog()
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        Dim compra As New Registro_de_compras
        compra.ShowDialog()
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Dim a As New PEDIDOS
        a.ShowDialog()
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        Dim a As New AMORTIZACIONES
        a.ShowDialog()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MsgBox("¿Desea salir del sistema ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Dim a As New Cambiar_Contraseña
        a.ShowDialog()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim a As New Asignar_usuario
        a.ShowDialog()
    End Sub

    Private Sub MenuItem45_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Dim a As New Consulta_Guia
        a.ShowDialog()
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        wb = CreateObject("Word.Basic")
        wb.ChDefaultDir("D:\libreria", 0)
        wb.FileOpen(Name:="Manual.doc")
        wb.AppShow()
        wb.AppMaximize()
    End Sub

    Private Sub MenuItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim vbol As New consulta_boletas
        vbol.ShowDialog()
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Dim fac As New Consulta_Facturas
        fac.ShowDialog()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim VTR As New REPORTE_DE_VENTAS
        VTR.ShowDialog()
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim f As New FLETE
        f.ShowDialog(Me)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim ra As New CREDITO
        ra.ShowDialog()

    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Dim p As New Frmpv_ct
        p.ShowDialog()
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        Dim PROV As New REPORTE_DE_PROVEEDORES
        PROV.ShowDialog()
    End Sub
End Class
