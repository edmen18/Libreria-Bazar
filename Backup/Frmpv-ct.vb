Imports System.Data.SqlClient
Public Class Frmpv_ct
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(464, 312)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Frmpv_ct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 350)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Frmpv_ct"
        Me.Text = "Proveedores por Categoría"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frmpv_ct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adaptador As New SqlDataAdapter("select distinct pv.PV_CODIGO,PV_DESCRIPCION,TELEFONO,RUC,ct.cod_categoria,descripcion from compras c inner join detalle_compra dc on dc.c_codigo=c.c_codigo inner join producto p on p.pro_codigo=dc.pro_codigo inner join categorias ct on ct.cod_categoria=p.cod_categoria inner join proveedor pv on pv.pv_codigo=c.pv_codigo", cn)
        Dim ds As New Ds_pv_ct
        adaptador.Fill(ds.Tables("pv_ct"))
        Dim cr As New Cr_pv_ct
        cr.SetDataSource(ds.Tables("pv_ct"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub
End Class
