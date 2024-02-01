Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine.FormulaFieldDefinition
Public Class REPORTE_DE_VENTAS
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpersonal As System.Windows.Forms.TextBox
    Friend WithEvents lblpersonal As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbticket As System.Windows.Forms.RadioButton
    Friend WithEvents rbboleta As System.Windows.Forms.RadioButton
    Friend WithEvents rbfactura As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(REPORTE_DE_VENTAS))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lblpersonal = New System.Windows.Forms.Label
        Me.txtpersonal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbfactura = New System.Windows.Forms.RadioButton
        Me.rbboleta = New System.Windows.Forms.RadioButton
        Me.rbticket = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(16, 208)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1000, 528)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 1
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(384, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&AL"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 56)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese un itervalo de fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 48)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione una opción"
        '
        'RadioButton6
        '
        Me.RadioButton6.Location = New System.Drawing.Point(544, 24)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.Text = "Por Comprobante"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(392, 24)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(104, 16)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Por Estado"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(208, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Por Personal"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(24, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(128, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Todas las Ventas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton4)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(688, 96)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Location = New System.Drawing.Point(504, 40)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "A crédito"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(32, 40)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(184, 16)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "Canceladas"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Controls.Add(Me.lblpersonal)
        Me.GroupBox4.Controls.Add(Me.txtpersonal)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(688, 96)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(80, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(592, 56)
        Me.ListView1.TabIndex = 3
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apellido y Nombre"
        Me.ColumnHeader2.Width = 368
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI"
        Me.ColumnHeader3.Width = 130
        '
        'lblpersonal
        '
        Me.lblpersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblpersonal.Location = New System.Drawing.Point(48, 40)
        Me.lblpersonal.Name = "lblpersonal"
        Me.lblpersonal.Size = New System.Drawing.Size(24, 24)
        Me.lblpersonal.TabIndex = 2
        Me.lblpersonal.Visible = False
        '
        'txtpersonal
        '
        Me.txtpersonal.Location = New System.Drawing.Point(80, 8)
        Me.txtpersonal.Name = "txtpersonal"
        Me.txtpersonal.Size = New System.Drawing.Size(592, 20)
        Me.txtpersonal.TabIndex = 1
        Me.txtpersonal.Text = ""
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Personal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Info
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(16, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Location = New System.Drawing.Point(720, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(112, 192)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Info
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "&Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbfactura)
        Me.GroupBox6.Controls.Add(Me.rbboleta)
        Me.GroupBox6.Controls.Add(Me.rbticket)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(688, 96)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        '
        'rbfactura
        '
        Me.rbfactura.Location = New System.Drawing.Point(552, 40)
        Me.rbfactura.Name = "rbfactura"
        Me.rbfactura.TabIndex = 2
        Me.rbfactura.Text = "Factura"
        '
        'rbboleta
        '
        Me.rbboleta.Location = New System.Drawing.Point(272, 40)
        Me.rbboleta.Name = "rbboleta"
        Me.rbboleta.TabIndex = 1
        Me.rbboleta.Text = "Boleta"
        '
        'rbticket
        '
        Me.rbticket.Location = New System.Drawing.Point(40, 40)
        Me.rbticket.Name = "rbticket"
        Me.rbticket.TabIndex = 0
        Me.rbticket.Text = "Ticket"
        '
        'REPORTE_DE_VENTAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "REPORTE_DE_VENTAS"
        Me.Text = "Reporte de Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.DateTimePicker1.Value.Date > Me.DateTimePicker2.Value.Date Then
            MsgBox("El periodo de tiempo no ha sido especificado correctamente", MsgBoxStyle.Critical)
        Else
            If Me.RadioButton1.Checked = True Then
                Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo  WHERE V_FECHA>='" + Me.DateTimePicker1.Value.Date() + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date() + "' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                Dim ds As New Dataset4
                adaptador.Fill(ds.Tables("VENTA"))
                Dim cr As New CrystalReportVENTAS
                cr.DataDefinition.FormulaFields.Item("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields.Item("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.SetDataSource(ds.Tables("VENTA"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If
            If Me.RadioButton3.Checked = True Then
                If Me.RadioButton4.Checked = True Then
                    Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo  WHERE V.ESTADO='CANCELADA'AND V_FECHA>='" + Me.DateTimePicker1.Value.Date() + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date() + "' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                    Dim ds As New Dataset4
                    adaptador.Fill(ds.Tables("VENTA"))
                    Dim cr As New CrystalReportVCAN
                    cr.DataDefinition.FormulaFields.Item("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                    cr.SetDataSource(ds.Tables("VENTA"))
                    Me.CrystalReportViewer1.ReportSource = cr
                End If
                If Me.RadioButton5.Checked = True Then
                    Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad,cancelado,saldo FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo inner join amortizaciones a on v.v_codigo=a.v_codigo  WHERE V.ESTADO='A Credito'AND V_FECHA>='" + Me.DateTimePicker1.Value.Date() + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date() + "' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                    Dim ds As New DatasetVCRE
                    adaptador.Fill(ds.Tables("VENTA"))
                    Dim cr As New CrystalReportVCRE
                    cr.DataDefinition.FormulaFields.Item("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                    cr.SetDataSource(ds.Tables("VENTA"))
                    Me.CrystalReportViewer1.ReportSource = cr
                End If
            End If
            If Me.RadioButton2.Checked = True Then
                Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,cl_apellidos+' '+cl_nombres as dv_cantidad FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo inner join clientes cl on cl.cl_codigo=v.cl_codigo  WHERE  P.PE_CODIGO='" + Me.lblpersonal.Text + "'AND V_FECHA>='" + Me.DateTimePicker1.Value.Date() + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date() + "' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                Dim ds As New Dataset4
                adaptador.Fill(ds.Tables("VENTA"))
                Dim cr As New CrystalReportvxe
                cr.DataDefinition.FormulaFields.Item("Field10").Text = "'" + Me.DateTimePicker1.Text + "'"
                cr.DataDefinition.FormulaFields.Item("Field11").Text = "'" + Me.DateTimePicker2.Text + "'"
                cr.DataDefinition.FormulaFields.Item("emp").Text = "'" + Me.txtpersonal.Text + "'"
                cr.SetDataSource(ds.Tables("VENTA"))
                Me.CrystalReportViewer1.ReportSource = cr
            End If

            If Me.RadioButton6.Checked = True Then
                If Me.rbticket.Checked = True Then
                    Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad,descripcion,t.numero as comprobante FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante bv on bv.cod_tc=cv.cod_tc inner join ticket t on t.cod_comprobante=cv.cod_comprobante WHERE V_FECHA>='" + Me.DateTimePicker1.Value.Date + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date + "' and bv.cod_tc='c01' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                    Dim ds As New Datasetvxcmp
                    adaptador.Fill(ds.Tables("comprobantes"))
                    Dim cr As New CrystalReportvxcmp
                    cr.DataDefinition.FormulaFields.Item("Fiel10").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("Fiel11").Text = "'" + Me.DateTimePicker2.Text + "'"
                    cr.SetDataSource(ds.Tables("comprobantes"))
                    Me.CrystalReportViewer1.ReportSource = cr
                End If
                If Me.rbboleta.Checked = True Then
                    Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad,descripcion,cod_boleta as comprobante FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo  inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante bv on bv.cod_tc=cv.cod_tc inner join boletas_venta b on b.cod_comprobante=cv.cod_comprobante WHERE V_FECHA>='" + Me.DateTimePicker1.Value.Date + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date + "'and bv.cod_tc='c02' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                    Dim ds As New Datasetvxcmp
                    adaptador.Fill(ds.Tables("comprobantes"))
                    Dim cr As New CrystalReportvxcmp
                    cr.DataDefinition.FormulaFields.Item("Fiel10").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("Fiel11").Text = "'" + Me.DateTimePicker2.Text + "'"
                    cr.SetDataSource(ds.Tables("comprobantes"))
                    Me.CrystalReportViewer1.ReportSource = cr
                End If
                If Me.rbfactura.Checked = True Then
                    Dim adaptador As New SqlDataAdapter("SELECT V.V_CODIGO,CONVERT(CHAR(10),V_FECHA,103)AS V_FECHA,total ,estado as dv_precio,pe_apellido+' '+pe_nombre as dv_cantidad,descripcion,cod_factura as comprobante FROM VENTAS V inner join personal p on p.pe_codigo=v.pe_codigo  inner join comprobantes_venta cv on cv.cod_comprobante=v.cod_comprobante inner join tipo_comprobante bv on bv.cod_tc=cv.cod_tc inner join facturas_venta b on b.cod_comprobante=cv.cod_comprobante WHERE V_FECHA>='" + Me.DateTimePicker1.Value.Date + "' AND V_FECHA<='" + Me.DateTimePicker2.Value.Date + "'and bv.cod_tc='c03' ORDER BY YEAR(v_FECHA ) ,MONTH(v_FECHA ),DAY(v_FECHA )", cn)
                    Dim ds As New Datasetvxcmp
                    adaptador.Fill(ds.Tables("comprobantes"))
                    Dim cr As New CrystalReportvxcmp
                    cr.DataDefinition.FormulaFields.Item("Fiel10").Text = "'" + Me.DateTimePicker1.Text + "'"
                    cr.DataDefinition.FormulaFields.Item("Fiel11").Text = "'" + Me.DateTimePicker2.Text + "'"

                    cr.SetDataSource(ds.Tables("comprobantes"))
                    Me.CrystalReportViewer1.ReportSource = cr
                End If
            End If
        End If
    End Sub

    Private Sub REPORTE_DE_VENTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox1.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView1.Visible = False
        Me.GroupBox4.Visible = False
        Me.GroupBox6.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox1.Visible = True
        Me.GroupBox3.Visible = False
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.GroupBox4.Visible = False
        Me.GroupBox6.Visible = False
        Me.rbboleta.Checked = False
        Me.rbticket.Checked = False
        Me.rbfactura.Checked = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.GroupBox3.Visible = False
        Me.RadioButton5.Checked = False
        Me.GroupBox1.Visible = True
        Me.GroupBox4.Visible = True
        Me.GroupBox6.Visible = False
        Me.rbboleta.Checked = False
        Me.rbticket.Checked = False
        Me.rbfactura.Checked = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.rbboleta.Checked = False
        Me.rbticket.Checked = False
        Me.rbfactura.Checked = False
        Me.RadioButton4.Checked = False
        Me.GroupBox3.Visible = True
        Me.RadioButton5.Checked = False
        Me.GroupBox4.Visible = False
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.GroupBox6.Visible = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.GroupBox1.Visible = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Me.GroupBox1.Visible = True
    End Sub

    Private Sub txtpersonal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpersonal.TextChanged

    End Sub

    Private Sub txtpersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpersonal.KeyPress
        Me.ListView1.Visible = True
        Try
            Me.ListView1.Items.Clear()
            Dim datar As SqlClient.SqlDataReader
            cn.Open()
            cm.Connection = cn
            cm.CommandText = " SELECT Pe_CODIGO, Pe_apellido+' '+pe_nombre, dni fRom personal  WHERE Pe_apellido+' '+pe_nombre LIKE'%" & txtpersonal.Text & "%'"
            cm.CommandType = CommandType.Text
            datar = cm.ExecuteReader
            Dim I As Integer = 0
            If datar.HasRows Then
                While datar.Read
                    Me.ListView1.Items.Add(CStr((datar(0))), 1)
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(1).ToString))
                    Me.ListView1.Items(I).SubItems.Add(CStr(datar(2).ToString))
                    I += 1
                End While
            End If
            datar.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("INGRESE LOS DATOS COMPLETOS", MsgBoxStyle.Critical)
            cn.Close()
        End Try
    End Sub



    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblpersonal.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.txtpersonal.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.ListView1.Visible = False
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Me.GroupBox1.Visible = False
        Me.GroupBox3.Visible = False
        Me.ListView1.Visible = False
        Me.GroupBox4.Visible = False
        Me.GroupBox6.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("¿Desea salir de la ventana ?", MsgBoxStyle.YesNo, "PREGUNTA DE CONFIRMACION") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Me.GroupBox6.Visible = True
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.GroupBox3.Visible = False
        Me.RadioButton5.Checked = False
        Me.GroupBox1.Visible = True
        Me.GroupBox4.Visible = True
        Me.rbboleta.Checked = False
        Me.rbticket.Checked = False
        Me.rbfactura.Checked = False
    End Sub
End Class
