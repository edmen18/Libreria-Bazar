Imports System.Data.SqlClient
Public Class Detalle_Guia
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 8)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(576, 480)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Detalle_Guia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 494)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Detalle_Guia"
        Me.Text = "Detalle_Guia"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Detalle_Guia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adaptador As New SqlDataAdapter("select codigo_guia,pv_descripcion,NUMERO_GUIA,total as monto,estado,dc_cantidad,importe,dc.pro_codigo,pro_descripcion,m.descripcion,peso_carga,peso_total,punto_partida,pv.ruc from guia_remision gr inner join compras c on c.c_codigo=gr.c_codigo inner join detalle_compra dc on dc.c_codigo=c.c_codigo inner join proveedor pv on pv.pv_codigo=c.pv_codigo inner join producto pr on pr.pro_codigo=dc.pro_codigo inner join marca m on m.cod_marca=pr.cod_marca where gr.codigo_guia='" + codigo_guia + "'", cn)
        Dim ds As New Datasetdetalle_guia
        adaptador.Fill(ds.Tables("GUIA"))
        Dim cr As New CrystalReportdetalle_guia
        cr.SetDataSource(ds.Tables("GUIA"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub
    Private Sub Detalle_Guia_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        codigo_guia = ""
    End Sub
End Class
