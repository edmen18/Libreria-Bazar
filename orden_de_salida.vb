Imports System.Data.SqlClient
Public Class orden_de_salida
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
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 40)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(576, 432)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Visible = False
        '
        'orden_de_salida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(592, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "orden_de_salida"
        Me.Text = "Orden de Salida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub orden_de_salida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = ordensalida
        Dim adaptador As New SqlDataAdapter("select OS.cod_ordensalida, PRO_DESCRIPCION,cantidad,PED.ped_codigo,razon_empresa,pe_apellido+' '+pe_nombre AS PERSONAL,convert(varchar(10),ped_fecha,103) as fecha,m.descripcion as marca from  pedidos ped inner join detalle_orden os on ped.ped_codigo=os.ped_codigo inner join detalle_pedido dp on dp.ped_codigo=ped.ped_codigo inner join empresas_pedidoS ep on ep.cod_empresa=ped.cod_empresa inner join personal per on per.PE_CODIGO=PED.PE_CODIGO INNER JOIN PRODUCTO PRO ON PRO.PRO_CODIGO=DP.PRO_CODIGO inner join marca m on m.cod_marca=pro.cod_marca where PED.ped_codigo='" + Me.Label1.Text + "'", cn)
        Dim ds As New Dataorden
        adaptador.Fill(ds.Tables("orden_salidas"))
        Dim cr As New CrystalReportORDEN
        cr.SetDataSource(ds.Tables("orden_salidas"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub

    Private Sub orden_de_salida_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ordensalida = ""
    End Sub
End Class
