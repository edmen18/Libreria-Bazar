Imports System.Data.SqlClient
Public Class DETALLE_FACTURA
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(268, -57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(24, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(656, 440)
        Me.CrystalReportViewer1.TabIndex = 4
        '
        'DETALLE_FACTURA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 526)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DETALLE_FACTURA"
        Me.Text = "Detalle Factura"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DETALLE_FACTURA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = COMPROBANTE1
        Me.Label2.Visible = False
        Dim adaptador As New SqlDataAdapter("select c.codigo_comprobante, codigo_factura,convert(varchar(10),c_fecha,103)as fecha,pro_descripcion,dc_cantidad,total,importe,PV_DESCRIPCION,RUC,dirección,telefono,m.descripcion as marca from comprobantes c inner join facturas b on b.codigo_comprobante=c.codigo_comprobante  inner join compras cm on cm.codigo_comprobante=c.codigo_comprobante inner join proveedor pv on pv.pv_codigo=cm.pv_codigo inner join detalle_compra dc on dc.c_codigo=cm.c_codigo inner join producto prd on prd.pro_codigo= dc.pro_codigo inner join marca m on m.cod_marca=prd.cod_marca where cm.c_codigo='" + Me.Label2.Text + "'", cn)
        Dim ds As New DataseTFACTURAS_DETALLE
        adaptador.Fill(ds.Tables("factura"))
        Dim cr As New CrystalReportdetalle_factura
        cr.SetDataSource(ds.Tables("factura"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub
End Class
