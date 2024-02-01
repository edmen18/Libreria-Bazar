Imports System.Data.SqlClient
Public Class Consulta_Consolidada
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Consulta_Consolidada))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 120)
        Me.GroupBox1.TabIndex = 8
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(60, 179)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(424, 264)
        Me.CrystalReportViewer1.TabIndex = 7
        '
        'Consulta_Consolidada
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(544, 486)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Consulta_Consolidada"
        Me.Text = "Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DateTimePicker1.Value.Date > Me.DateTimePicker2.Value.Date Then
            MsgBox("El periodo de tiempo no ha sido especificado correctamente", MsgBoxStyle.Critical)
        Else
            Dim adaptador As New SqlDataAdapter("select sum (TOTAL)as compras ,convert(numeric(9,2),0)as ventas,convert(numeric(9,2),0)as pedidos,convert(numeric(9,2),0)as gastos,convert(numeric(9,2),0)as gastosAD into #temp11 from compras c  where c.c_fecha>='" + Me.DateTimePicker1.Value.Date + "' and c.c_fecha<='" + Me.DateTimePicker2.Value.Date + "' insert into #temp11 select convert(numeric(9,2),0) as compras ,convert(numeric(9,2),sum (TOTAL))as ventas,convert(numeric(9,2),0)as pedidos,convert(numeric(9,2),0)as gastos,convert(numeric(9,2),0)as gastosAD from ventas v where v.v_fecha>='" + Me.DateTimePicker1.Value.Date + "' and v.v_fecha<='" + Me.DateTimePicker2.Value.Date + "'insert into #temp11 select convert(numeric(9,2),0)as compras ,convert(numeric(9,2),0)as ventas, convert(numeric(9,2),sum(saldo))as pedidos,convert(numeric(9,2),0)as gastos,convert(numeric(9,2),0)as gastosAD from amortizaciones a  inner join ventas v on v.v_codigo=a.v_codigo where v_fecha>='" + Me.DateTimePicker1.Value.Date + "' and v_fecha<='" + Me.DateTimePicker2.Value.Date + "'and  saldo>0 insert into #temp11 select convert(numeric(9,2),0)as compras ,convert(numeric(9,2),0)as ventas, convert(numeric(9,2),0)as pedidos,convert(numeric(9,2),sum(monto))as gastos,convert(numeric(9,2),0)as gastosAD from FACTURA_guia where fecha>='" + Me.DateTimePicker1.Value.Date + "' and fecha<='" + Me.DateTimePicker2.Value.Date + "' select sum(compras)as compras , sum(ventas)as ventas, sum(pedidos)as pedidos,sum(gastos) as gastos from #temp11 ", cn)
            Dim ds As New Dataset8
            adaptador.Fill(ds.Tables("consolidado"))
            Dim cr As New CrystalReport4
            cr.DataDefinition.FormulaFields("field10").Text = "'" + Me.DateTimePicker1.Text + "'"
            cr.DataDefinition.FormulaFields("field11").Text = "'" + Me.DateTimePicker2.Text + "'"
            cr.SetDataSource(ds.Tables("consolidado"))
            Me.CrystalReportViewer1.ReportSource = cr
        End If
    End Sub
End Class
