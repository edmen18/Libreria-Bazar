Imports System.Data.SqlClient
Public Class TICKET
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(720, 656)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Visible = False
        '
        'TICKET
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(720, 606)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TICKET"
        Me.Text = "Boleto de Venta"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TICKET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = ventas
        Dim adaptador As New SqlDataAdapter("SELECT CL_NOMBRES+' '+CL_APELLIDOS AS CLIENTE,PRO_DESCRIPCION,DV_CANTIDAD AS CANTIDAD,DV_PRECIO AS PRECIO,(DV_CANTIDAD*DV_PRECIO)AS SUBTOTAL,total,v.v_codigo as cod_venta, M.DESCRIPCION as marca,numero FROM ticket t inner join comprobantes_venta cv on cv.cod_comprobante=t.cod_comprobante inner join ventas v on v.cod_comprobante=cv.cod_comprobante inner join detalle_venta dv on dv.v_codigo=v.v_codigo inner join producto p on p.pro_codigo=dv.pro_codigo inner join marca M on M.cod_marca=p.cod_marca inner join clientes cl on cl.cl_codigo=v.cl_codigo where v.v_codigo='" + Me.Label1.Text + "' GROUP BY CL_NOMBRES+' '+CL_APELLIDOS,PRO_DESCRIPCION,DV_CANTIDAD, DV_PRECIO, total, v.v_codigo, M.DESCRIPCION,numero ", cn)
        Dim ds As New DataTICKET
        adaptador.Fill(ds.Tables("TICKET"))
        Dim cr As New CrystalReportTICKET
        cr.SetDataSource(ds.Tables("TICKET"))
        Me.CrystalReportViewer1.ReportSource = cr

        'Dim adaptador1 As New SqlDataAdapter("SELECT numero FROM ventas v inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join ticket t on t.cod_comprobante=cv.cod_comprobante where v.v_codigo='" + Me.Label1.Text + "'", cn)
        'Dim ds1 As New DataTICKET
        'adaptador.Fill(ds.Tables("TICKET"))
        'Dim cr1 As New CrystalReportTICKET
        'cr.SetDataSource(ds.Tables("TICKET"))
        'Me.CrystalReportViewer1.ReportSource = cr1
    End Sub
End Class
