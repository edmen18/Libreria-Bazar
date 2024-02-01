Imports System.Data.SqlClient
Public Class Clientes_Deudores
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 32)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(728, 448)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Clientes_Deudores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 494)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Clientes_Deudores"
        Me.Text = "Clientes_Deudores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Clientes_Deudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim adaptador As New SqlDataAdapter("select cl_apellidos+' '+cl_nombres as nombre,cl_dni,cl_direccion,telefono,sum (saldo)as debe,SUM(CANCELADO)AS CANCELADO,SUM(TOTAL)AS TOTAL from clientes c inner join ventas v on v.cl_codigo=c.cl_codigo inner join amortizaciones a on a.v_codigo=v.v_codigo where v.estado='A CREDITO' group by cl_apellidos,cl_nombres,cl_dni,cl_direccion,telefono", cn)
        Dim ds As New Datasetdeudores
        adaptador.Fill(ds.Tables("deudores"))
        Dim cr As New CrystalReportdeudores
        cr.SetDataSource(ds.Tables("deudores"))
        Me.CrystalReportViewer1.ReportSource = cr
    End Sub
End Class
