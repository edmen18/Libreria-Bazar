Imports System.Data.SqlClient
Public Class Consolidado
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consolidado))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(48, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(240, 32)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(136, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(32, 152)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(424, 264)
        Me.CrystalReportViewer1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese un rango de fechas"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Al"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Del"
        '
        'Consolidado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(528, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Consolidado"
        Me.Text = "Entradas y Salidas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DateTimePicker1.Value.Date > Me.DateTimePicker2.Value.Date Then
            MsgBox("El periodo de tiempo no ha sido especificado correctamente", MsgBoxStyle.Critical)
        Else
            Dim adaptador As New SqlDataAdapter("select p.pro_codigo,abreviatura as pro_unidad,pro_descripcion,m.descripcion as marca ,pro_precio,pro_stock,sum (dc_cantidad)as compras ,0 ventas,0 pedidos into #tempo5 from compras c inner join detalle_compra dc on c.c_codigo=dc.c_codigo inner join producto p on p.pro_codigo =dc.pro_codigo inner join marca m on m.cod_marca=p.cod_marca inner join stock s on s.pro_codigo=p.pro_codigo inner join unidad u on u.cod_unidad=p.cod_unidad where c.c_fecha>='" + Me.DateTimePicker1.Value.Date + "' and c.c_fecha<='" + Me.DateTimePicker2.Value.Date + "'and pro_stock>=0 group by pro_precio,m.descripcion,pro_descripcion,pro_stock,abreviatura ,p.pro_codigo insert into #tempo5   select p.pro_codigo,abreviatura as pro_unidad,pro_descripcion,m.descripcion as marca ,pro_precio,pro_stock, 0 compras ,sum (dv_cantidad)as ventas, 0 pedidos  from ventas v inner join detalle_venta dv on v.v_codigo=dv.v_codigo inner join producto p on p.pro_codigo =dv.pro_codigo inner join marca m on m.cod_marca=p.cod_marca inner join stock s on s.pro_codigo=p.pro_codigo inner join unidad u on u.cod_unidad=p.cod_unidad where v.v_fecha>='" + Me.DateTimePicker1.Value.Date + "' and v.v_fecha<='" + Me.DateTimePicker2.Value.Date + "'AND pro_stock>=0 group by  pro_precio,m.descripcion,pro_descripcion,pro_stock,abreviatura,p.pro_codigo insert into #tempo5 select p.pro_codigo,abreviatura as pro_unidad,pro_descripcion,m.descripcion as marca,pro_precio,pro_stock, 0 compras ,0 ventas, sum(cantidad) as pedidos from pedidos ped inner join detalle_pedido dp on ped.ped_codigo=dp.ped_codigo inner join producto p on p.pro_codigo =dp.pro_codigo inner join marca m on m.cod_marca=p.cod_marca inner join stock s on s.pro_codigo=p.pro_codigo inner join unidad u on u.cod_unidad=p.cod_unidad where ped_fecha>='" + Me.DateTimePicker1.Value.Date + "' and ped_fecha<='" + Me.DateTimePicker2.Value.Date + "'and pro_stock>=0 and ped.estado='Atendido' group by pro_precio,m.descripcion,pro_descripcion,pro_stock,abreviatura,p.pro_codigo select pro_codigo, pro_unidad,pro_descripcion, marca,pro_precio,pro_stock,sum(compras)as compras , sum(ventas)as ventas, sum(pedidos)as pedidos from #tempo5 group by pro_precio,pro_descripcion,marca,pro_stock,pro_unidad,pro_codigo ", cn)
            Dim ds As New Datasetcardex
            adaptador.Fill(ds.Tables("cardex"))
            Dim cr As New CrystalReportcardex
            cr.DataDefinition.FormulaFields("field10").Text = "'" + Me.DateTimePicker1.Text + "'"
            cr.DataDefinition.FormulaFields("field11").Text = "'" + Me.DateTimePicker2.Text + "'"
            cr.SetDataSource(ds.Tables("cardex"))
            Me.CrystalReportViewer1.ReportSource = cr
        End If
    End Sub
End Class
