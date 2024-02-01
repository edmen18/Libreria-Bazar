Imports System.Data.SqlClient
Public Class Stock_actual
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(512, 408)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Stock_actual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(544, 438)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Stock_actual"
        Me.Text = "Stock_actual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Stock_actual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adaptador As New SqlDataAdapter("SELECT P.PRO_CODIGO AS CODIGO,P.PRO_DESCRIPCION AS PRODUCTO, m.descripcion AS UNIDAD ,PRO_STOCK AS STOCK_ACTUAL , convert(numeric(9,0),PRO_STOCKMIN) AS STOCK_MINIMO, convert(numeric(9,0),PRO_STOCKMAX) AS STOCK_MAXIMO,pro_precio FROM PRODUCTO P INNER JOIN STOCK S ON S.PRO_CODIGO=P.PRO_CODIGO inner join marca m on m.cod_marca=p.cod_marca order by p.pro_descripcion", cn)
        Dim ds As New DATASTOCK
        adaptador.Fill(ds.Tables("STOCK"))
        Dim cr As New CrystalReportstockcompleto
        cr.SetDataSource(ds.Tables("STOCK"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub
End Class
