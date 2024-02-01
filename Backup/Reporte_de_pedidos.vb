Imports System.Data.SqlClient
Public Class Reporte_de_pedidos
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Reporte_de_pedidos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 96)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese un itervalo de fechas"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(384, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&AL"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(432, 24)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&DEL"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(288, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(24, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 16)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.Text = "Todos los pedidos"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(560, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(136, 16)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Pedidos Anulados"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(200, 56)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.Text = "Pedidos Pendientes"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(392, 56)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 16)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.Text = "Pedidos Atendidos"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 216)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(688, 280)
        Me.CrystalReportViewer1.TabIndex = 13
        '
        'Reporte_de_pedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(728, 510)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reporte_de_pedidos"
        Me.Text = "Reporte_de_pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Reporte_de_pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RadioButton1.Checked = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DateTimePicker1.Value.Date > Me.DateTimePicker2.Value.Date Then
            MsgBox("El periodo de tiempo no ha sido especificado correctamente", MsgBoxStyle.Critical)
        Else
            If Me.RadioButton1.Checked = True Then
                Dim adaptador As New SqlDataAdapter("select pe.PED_CODIGO,convert(varchar(10),PED_FECHA,103)as fecha,COD_ORDENSALIDA,razon_empresa as cliente,Estado,PE_apellido+' '+pe_nombre as personal,convert(varchar(10),fecha_modificacion,103)as modificacion,observacion from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where ped_fecha>='" + Me.DateTimePicker1.Value.Date + "' and ped_fecha<='" + Me.DateTimePicker2.Value.Date + "'order by ped_fecha", cn)
                Dim ds As New datapedidosAyTP
                adaptador.Fill(ds.Tables("pedidos"))
                Dim cr As New CrystalReportpedidosAyTP
                cr.DataDefinition.FormulaFields("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.SetDataSource(ds.Tables("pedidos"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
            If Me.RadioButton2.Checked = True Then
                Dim adaptador As New SqlDataAdapter("select pe.PED_CODIGO,convert(varchar(10),PED_FECHA,103)as fecha,COD_ORDENSALIDA,razon_empresa as cliente,Estado,PE_apellido+' '+pe_nombre as personal,convert(varchar(10),fecha_modificacion,103)as modificacion,observacion from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where ped_fecha>='" + Me.DateTimePicker1.Value.Date + "' and ped_fecha<='" + Me.DateTimePicker2.Value.Date + "'and pe.estado='anulado' order by ped_fecha", cn)
                Dim ds As New datapedidosAyTP
                adaptador.Fill(ds.Tables("pedidos"))
                Dim cr As New CrystalReport5
                cr.DataDefinition.FormulaFields("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.SetDataSource(ds.Tables("pedidos"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
            If Me.RadioButton3.Checked = True Then
                Dim adaptador As New SqlDataAdapter("select pe.PED_CODIGO,convert(varchar(10),PED_FECHA,103)as fecha,COD_ORDENSALIDA,razon_empresa as cliente,Estado,PE_apellido+' '+pe_nombre as personal,convert(varchar(10),fecha_modificacion,103)as modificacion,observacion from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where ped_fecha>='" + Me.DateTimePicker1.Value.Date + "' and ped_fecha<='" + Me.DateTimePicker2.Value.Date + "'and pe.estado='pendiente' order by ped_fecha", cn)
                Dim ds As New datapedidosAyTP
                adaptador.Fill(ds.Tables("pedidos"))
                Dim cr As New CrystalReport5
                cr.DataDefinition.FormulaFields("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.SetDataSource(ds.Tables("pedidos"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
            If Me.RadioButton4.Checked = True Then
                Dim adaptador As New SqlDataAdapter("select pe.PED_CODIGO,convert(varchar(10),PED_FECHA,103)as fecha,COD_ORDENSALIDA,razon_empresa as cliente,Estado,PE_apellido+' '+pe_nombre as personal,convert(varchar(10),fecha_modificacion,103)as modificacion,observacion from Pedidos pe inner join personal per on pe.pe_codigo=per.pe_codigo inner join empresas_pedidos ep on ep.cod_empresa=pe.cod_empresa inner join detalle_orden do on do.ped_codigo=pe.ped_codigo where ped_fecha>='" + Me.DateTimePicker1.Value.Date + "' and ped_fecha<='" + Me.DateTimePicker2.Value.Date + "'and pe.estado='atendido' order by ped_fecha", cn)
                Dim ds As New datapedidosAyTP
                adaptador.Fill(ds.Tables("pedidos"))
                Dim cr As New CrystalReport5
                cr.DataDefinition.FormulaFields("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.SetDataSource(ds.Tables("pedidos"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
