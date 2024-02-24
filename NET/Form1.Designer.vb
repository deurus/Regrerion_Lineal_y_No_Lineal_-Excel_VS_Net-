<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Btn_calcular = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TXT_C = New System.Windows.Forms.TextBox()
		Me.TXT_B = New System.Windows.Forms.TextBox()
		Me.TXT_A = New System.Windows.Forms.TextBox()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
		Me.DGV_API = New System.Windows.Forms.DataGridView()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Txt_resul = New System.Windows.Forms.RichTextBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
		Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
		Me.DGV_API_NL = New System.Windows.Forms.DataGridView()
		Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Txt_Resul_NL = New System.Windows.Forms.RichTextBox()
		Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.Txt_A_ini = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
		Me.Txt_B_ini = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
		Me.Txt_C_ini = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
		Me.Txt_iter = New System.Windows.Forms.ToolStripTextBox()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer3.Panel1.SuspendLayout()
		Me.SplitContainer3.Panel2.SuspendLayout()
		Me.SplitContainer3.SuspendLayout()
		CType(Me.DGV_API, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage2.SuspendLayout()
		CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer4.Panel1.SuspendLayout()
		Me.SplitContainer4.Panel2.SuspendLayout()
		Me.SplitContainer4.SuspendLayout()
		CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer5.Panel1.SuspendLayout()
		Me.SplitContainer5.Panel2.SuspendLayout()
		Me.SplitContainer5.SuspendLayout()
		CType(Me.DGV_API_NL, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip2.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.IsSplitterFixed = True
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
		Me.SplitContainer1.Size = New System.Drawing.Size(841, 561)
		Me.SplitContainer1.SplitterDistance = 250
		Me.SplitContainer1.TabIndex = 1
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.Btn_calcular)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.TXT_C)
		Me.GroupBox2.Controls.Add(Me.TXT_B)
		Me.GroupBox2.Controls.Add(Me.TXT_A)
		Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(244, 145)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Resultado"
		'
		'Btn_calcular
		'
		Me.Btn_calcular.Location = New System.Drawing.Point(8, 99)
		Me.Btn_calcular.Name = "Btn_calcular"
		Me.Btn_calcular.Size = New System.Drawing.Size(229, 33)
		Me.Btn_calcular.TabIndex = 18
		Me.Btn_calcular.Text = "CALCULAR"
		Me.Btn_calcular.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(24, 74)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(17, 13)
		Me.Label6.TabIndex = 17
		Me.Label6.Text = "C:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(24, 48)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(17, 13)
		Me.Label5.TabIndex = 16
		Me.Label5.Text = "B:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(24, 26)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(17, 13)
		Me.Label4.TabIndex = 15
		Me.Label4.Text = "A:"
		'
		'TXT_C
		'
		Me.TXT_C.BackColor = System.Drawing.Color.DarkOrange
		Me.TXT_C.Location = New System.Drawing.Point(47, 71)
		Me.TXT_C.Name = "TXT_C"
		Me.TXT_C.Size = New System.Drawing.Size(191, 20)
		Me.TXT_C.TabIndex = 14
		Me.TXT_C.Text = "0"
		'
		'TXT_B
		'
		Me.TXT_B.BackColor = System.Drawing.Color.DarkOrange
		Me.TXT_B.Location = New System.Drawing.Point(47, 45)
		Me.TXT_B.Name = "TXT_B"
		Me.TXT_B.Size = New System.Drawing.Size(191, 20)
		Me.TXT_B.TabIndex = 13
		Me.TXT_B.Text = "0"
		'
		'TXT_A
		'
		Me.TXT_A.BackColor = System.Drawing.Color.DarkOrange
		Me.TXT_A.Location = New System.Drawing.Point(47, 19)
		Me.TXT_A.Name = "TXT_A"
		Me.TXT_A.Size = New System.Drawing.Size(191, 20)
		Me.TXT_A.TabIndex = 12
		Me.TXT_A.Text = "0"
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(587, 561)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage1.Controls.Add(Me.SplitContainer2)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(579, 535)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Lineal"
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.Txt_resul)
		Me.SplitContainer2.Size = New System.Drawing.Size(573, 529)
		Me.SplitContainer2.SplitterDistance = 288
		Me.SplitContainer2.TabIndex = 0
		'
		'SplitContainer3
		'
		Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer3.Name = "SplitContainer3"
		'
		'SplitContainer3.Panel1
		'
		Me.SplitContainer3.Panel1.Controls.Add(Me.DGV_API)
		'
		'SplitContainer3.Panel2
		'
		Me.SplitContainer3.Panel2.Controls.Add(Me.Chart1)
		Me.SplitContainer3.Size = New System.Drawing.Size(573, 288)
		Me.SplitContainer3.SplitterDistance = 287
		Me.SplitContainer3.TabIndex = 0
		'
		'DGV_API
		'
		Me.DGV_API.BackgroundColor = System.Drawing.SystemColors.Control
		Me.DGV_API.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DGV_API.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_API.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGV_API.Location = New System.Drawing.Point(0, 0)
		Me.DGV_API.Name = "DGV_API"
		Me.DGV_API.Size = New System.Drawing.Size(287, 288)
		Me.DGV_API.TabIndex = 0
		'
		'Chart1
		'
		Me.Chart1.BackColor = System.Drawing.SystemColors.Control
		ChartArea1.BackColor = System.Drawing.SystemColors.Control
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Chart1.Location = New System.Drawing.Point(0, 0)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Size = New System.Drawing.Size(282, 288)
		Me.Chart1.TabIndex = 1
		Me.Chart1.Text = "Chart1"
		'
		'Txt_resul
		'
		Me.Txt_resul.BackColor = System.Drawing.SystemColors.Control
		Me.Txt_resul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_resul.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Txt_resul.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Txt_resul.Location = New System.Drawing.Point(0, 0)
		Me.Txt_resul.Name = "Txt_resul"
		Me.Txt_resul.Size = New System.Drawing.Size(573, 237)
		Me.Txt_resul.TabIndex = 1
		Me.Txt_resul.Text = ""
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.SplitContainer4)
		Me.TabPage2.Controls.Add(Me.ToolStrip2)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(579, 535)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "No lineal"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'SplitContainer4
		'
		Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer4.Location = New System.Drawing.Point(0, 25)
		Me.SplitContainer4.Name = "SplitContainer4"
		Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer4.Panel1
		'
		Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer5)
		'
		'SplitContainer4.Panel2
		'
		Me.SplitContainer4.Panel2.Controls.Add(Me.Txt_Resul_NL)
		Me.SplitContainer4.Size = New System.Drawing.Size(579, 510)
		Me.SplitContainer4.SplitterDistance = 294
		Me.SplitContainer4.TabIndex = 1
		'
		'SplitContainer5
		'
		Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer5.Name = "SplitContainer5"
		'
		'SplitContainer5.Panel1
		'
		Me.SplitContainer5.Panel1.Controls.Add(Me.DGV_API_NL)
		'
		'SplitContainer5.Panel2
		'
		Me.SplitContainer5.Panel2.Controls.Add(Me.Chart2)
		Me.SplitContainer5.Size = New System.Drawing.Size(579, 294)
		Me.SplitContainer5.SplitterDistance = 298
		Me.SplitContainer5.TabIndex = 0
		'
		'DGV_API_NL
		'
		Me.DGV_API_NL.BackgroundColor = System.Drawing.SystemColors.Control
		Me.DGV_API_NL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DGV_API_NL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_API_NL.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DGV_API_NL.Location = New System.Drawing.Point(0, 0)
		Me.DGV_API_NL.Name = "DGV_API_NL"
		Me.DGV_API_NL.Size = New System.Drawing.Size(298, 294)
		Me.DGV_API_NL.TabIndex = 1
		'
		'Chart2
		'
		Me.Chart2.BackColor = System.Drawing.SystemColors.Control
		ChartArea2.BackColor = System.Drawing.SystemColors.Control
		ChartArea2.Name = "ChartArea1"
		Me.Chart2.ChartAreas.Add(ChartArea2)
		Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Chart2.Location = New System.Drawing.Point(0, 0)
		Me.Chart2.Name = "Chart2"
		Me.Chart2.Size = New System.Drawing.Size(277, 294)
		Me.Chart2.TabIndex = 2
		Me.Chart2.Text = "Chart2"
		'
		'Txt_Resul_NL
		'
		Me.Txt_Resul_NL.BackColor = System.Drawing.SystemColors.Control
		Me.Txt_Resul_NL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Txt_Resul_NL.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Txt_Resul_NL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Txt_Resul_NL.Location = New System.Drawing.Point(0, 0)
		Me.Txt_Resul_NL.Name = "Txt_Resul_NL"
		Me.Txt_Resul_NL.Size = New System.Drawing.Size(579, 212)
		Me.Txt_Resul_NL.TabIndex = 2
		Me.Txt_Resul_NL.Text = ""
		'
		'ToolStrip2
		'
		Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.ToolStripLabel1, Me.Txt_A_ini, Me.ToolStripLabel2, Me.Txt_B_ini, Me.ToolStripLabel3, Me.Txt_C_ini, Me.ToolStripSeparator2, Me.ToolStripLabel5, Me.Txt_iter})
		Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip2.Name = "ToolStrip2"
		Me.ToolStrip2.Size = New System.Drawing.Size(579, 25)
		Me.ToolStrip2.TabIndex = 0
		Me.ToolStrip2.Text = "ToolStrip2"
		'
		'ToolStripLabel4
		'
		Me.ToolStripLabel4.Name = "ToolStripLabel4"
		Me.ToolStripLabel4.Size = New System.Drawing.Size(89, 22)
		Me.ToolStripLabel4.Text = "Valores iniciales"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(18, 22)
		Me.ToolStripLabel1.Text = "A:"
		'
		'Txt_A_ini
		'
		Me.Txt_A_ini.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Txt_A_ini.Name = "Txt_A_ini"
		Me.Txt_A_ini.Size = New System.Drawing.Size(50, 25)
		Me.Txt_A_ini.Text = "2"
		'
		'ToolStripLabel2
		'
		Me.ToolStripLabel2.Name = "ToolStripLabel2"
		Me.ToolStripLabel2.Size = New System.Drawing.Size(17, 22)
		Me.ToolStripLabel2.Text = "B:"
		'
		'Txt_B_ini
		'
		Me.Txt_B_ini.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Txt_B_ini.Name = "Txt_B_ini"
		Me.Txt_B_ini.Size = New System.Drawing.Size(50, 25)
		Me.Txt_B_ini.Text = "1500"
		'
		'ToolStripLabel3
		'
		Me.ToolStripLabel3.Name = "ToolStripLabel3"
		Me.ToolStripLabel3.Size = New System.Drawing.Size(18, 22)
		Me.ToolStripLabel3.Text = "C:"
		'
		'Txt_C_ini
		'
		Me.Txt_C_ini.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Txt_C_ini.Name = "Txt_C_ini"
		Me.Txt_C_ini.Size = New System.Drawing.Size(50, 25)
		Me.Txt_C_ini.Text = "273"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel5
		'
		Me.ToolStripLabel5.Name = "ToolStripLabel5"
		Me.ToolStripLabel5.Size = New System.Drawing.Size(73, 22)
		Me.ToolStripLabel5.Text = "Iteracciones:"
		'
		'Txt_iter
		'
		Me.Txt_iter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Txt_iter.Name = "Txt_iter"
		Me.Txt_iter.Size = New System.Drawing.Size(50, 25)
		Me.Txt_iter.Text = "1000"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(841, 561)
		Me.Controls.Add(Me.SplitContainer1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Regresión Lineal y No Lineal"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		Me.SplitContainer3.Panel1.ResumeLayout(False)
		Me.SplitContainer3.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer3.ResumeLayout(False)
		CType(Me.DGV_API, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.SplitContainer4.Panel1.ResumeLayout(False)
		Me.SplitContainer4.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer4.ResumeLayout(False)
		Me.SplitContainer5.Panel1.ResumeLayout(False)
		Me.SplitContainer5.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer5.ResumeLayout(False)
		CType(Me.DGV_API_NL, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip2.ResumeLayout(False)
		Me.ToolStrip2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents SplitContainer2 As SplitContainer
	Friend WithEvents SplitContainer3 As SplitContainer
	Friend WithEvents DGV_API As DataGridView
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TXT_C As TextBox
	Friend WithEvents TXT_B As TextBox
	Friend WithEvents TXT_A As TextBox
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents Txt_resul As RichTextBox
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents SplitContainer4 As SplitContainer
	Friend WithEvents SplitContainer5 As SplitContainer
	Friend WithEvents ToolStrip2 As ToolStrip
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents DGV_API_NL As DataGridView
	Friend WithEvents Chart2 As DataVisualization.Charting.Chart
	Friend WithEvents Txt_A_ini As ToolStripTextBox
	Friend WithEvents ToolStripLabel2 As ToolStripLabel
	Friend WithEvents Txt_B_ini As ToolStripTextBox
	Friend WithEvents ToolStripLabel3 As ToolStripLabel
	Friend WithEvents Txt_C_ini As ToolStripTextBox
	Friend WithEvents Txt_Resul_NL As RichTextBox
	Friend WithEvents ToolStripLabel4 As ToolStripLabel
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripLabel5 As ToolStripLabel
	Friend WithEvents Txt_iter As ToolStripTextBox
	Friend WithEvents Btn_calcular As Button
End Class
