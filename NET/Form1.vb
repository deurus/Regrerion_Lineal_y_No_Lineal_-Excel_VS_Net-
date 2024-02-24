#Region "INFO"
'Creado por garikoitz.info en Junio de 2021
'Entrada del Blog: https://garikoitz.info/blog/?p=1321 (Regresión Lineal y No Lineal - Excel VS .Net)
#End Region
#Region "Imports"
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports Accord.Math
Imports Accord.Math.Differentiation
Imports Accord.Math.Optimization
Imports Accord.Math.Optimization.Losses
Imports Accord.Statistics.Models.Regression
Imports Accord.Statistics.Models.Regression.Fitting
Imports Accord.Statistics.Models.Regression.Linear
'http://accord-framework.net/docs/html/T_Accord_Statistics_Models_Regression_NonlinearRegression.htm
'http://accord-framework.net/docs/html/T_Accord_Statistics_Models_Regression_Linear_OrdinaryLeastSquares.htm
#End Region
Public Class Form1
#Region "Variables"
	Dim dt_api As DataTable
	Dim dt_api_NL As DataTable
	Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CurrentCulture
	Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
	Dim T As Double() = {65.44, 73.78, 82.11, 90.45, 98.78, 107.12, 115.46, 123.79, 132.13, 140.46, 148.8, 157.13, 165.47, 173.8, 182.14}
	Dim P As Double() = {41.17, 47.32, 54.15, 61.7, 70.02, 79.15, 89.14, 100.03, 111.87, 124.7, 138.58, 153.54, 169.64, 186.9, 205.39}
	Dim A, B, C As Double
#End Region
#Region "Functions"
	Public Sub MakeGridViewDoubleBuffered(ByVal dgv As DataGridView)
		Dim dgvType As Type = dgv.[GetType]()
		Dim pis As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
		pis.SetValue(dgv, True, Nothing)
	End Sub
	Sub APIcalc()
		Try
			Dim T1, T2, T3, temp, P, Pcalc, SEC As Double
			SEC = 0.0
			If TabControl1.SelectedIndex = 0 Then
				For i = 0 To 14
					temp = DGV_API.Rows(i).Cells(0).Value
					P = DGV_API.Rows(i).Cells(1).Value
					Pcalc = DGV_API.Rows(i).Cells(2).Value
					T1 = 10 ^ (A - B / (temp + C))
					T2 = (+P - Pcalc)
					T3 = ((-Math.Log10(P) + (A - B / (temp + C))) ^ 2)
					DGV_API.Rows(i).Cells(2).Value = T1 'Pcalc
					DGV_API.Rows(i).Cells(3).Value = T2 'DP psia
					DGV_API.Rows(i).Cells(4).Value = T3 'Error PCT
					SEC += T3
				Next
				DGV_API.Rows(15).Cells(4).Value = SEC
			ElseIf TabControl1.SelectedIndex = 1 Then
				For i = 0 To 14
					temp = DGV_API_NL.Rows(i).Cells(0).Value
					P = DGV_API_NL.Rows(i).Cells(1).Value
					Pcalc = 10 ^ (A - B / (temp + C))
					'T1 = 10 ^ (A - B / (temp + C))
					T2 = (+P - Pcalc)
					T3 = ((-Math.Log10(P) + (A - B / (temp + C))) ^ 2)
					DGV_API_NL.Rows(i).Cells(2).Value = Pcalc 'Pcalc
					DGV_API_NL.Rows(i).Cells(3).Value = T2 'DP psia
					DGV_API_NL.Rows(i).Cells(4).Value = T3 'Error PCT
					SEC += T3
				Next
				DGV_API_NL.Rows(15).Cells(4).Value = SEC
			End If
		Catch ex As Exception
			'MsgBox(ex.ToString)
		End Try
	End Sub
	Function CalcLineal()
		Txt_resul.Text = ""
		TXT_A.Text = ""
		TXT_B.Text = ""
		TXT_C.Text = ""
		dt_api = Nothing
		'
		Dim dt As Date = Now
		Txt_resul.Text = "Cálculos - " & dt.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) & vbNewLine & vbNewLine
		Txt_resul.Text &= "Linealización de la equación de Antoine --> log10(P) = A - B / (T + C)" & vbNewLine & vbNewLine
		Txt_resul.Text &= "T * log10(P) + C * log10(P) = A * T + A * C - B" & vbNewLine
		Txt_resul.Text &= "log10(P) = A + (A * C - B) / T" & vbNewLine
		Txt_resul.Text &= "y = a0 + a1 * x1 + a2 * x2" & vbNewLine
		Txt_resul.Text &= "y = log10(P)  |  x1 = 1 / T  |  x2 = log10(P) / T" & vbNewLine & vbNewLine

		'PREPARO DGVs
		dt_api = New DataTable
		dt_api.Columns.Add("Temp ºF")
		dt_api.Columns.Add("P psia")
		dt_api.Columns.Add("P(calc) psia")
		dt_api.Columns.Add("DP psia")
		dt_api.Columns.Add("Error TCP")
		'
		For i = 0 To 14
			dt_api.Rows.Add(New String() {T(i), P(i), "0", "0", "0"})
		Next i
		'
		DGV_API.DataSource = dt_api
		DGV_API.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		DGV_API.AllowUserToOrderColumns = False
		DGV_API.RowHeadersVisible = False
		DGV_API.ColumnHeadersVisible = True
		Application.DoEvents()
		'
		'----------------
		'Regresión Lineal
		'----------------
		Try
			Dim Tx, Px As Double
			'inputs(x1)(x2)  -> x1 = 1 / T  |  x2 = log10(P) / T
			Dim inputs As Double()() = New Double(14)() {}
			For i = 0 To 14
				Tx = DGV_API.Rows(i).Cells(0).Value
				Px = DGV_API.Rows(i).Cells(1).Value
				inputs(i) = New Double() {1 / Tx, Math.Log10(Px) / Tx}
			Next
			'outputs = y -> y = log10(P)
			Dim outputs As Double() = {1.615316424, 1.675711408, 1.734153592, 1.790736182, 1.845546545, 1.898666658, 1.950173521, 2.000139525, 2.048632796, 2.0957175, 2.141454129, 2.185899763, 2.229108299, 2.271130681, 2.312015089} 'data.GetRow(2)
			'
			Dim ols As New OrdinaryLeastSquares()
			ols.UseIntercept = True
			Dim regression As MultipleLinearRegression = ols.Learn(inputs, outputs)
			'
			Dim a1 As Double = regression.Weights(0)
			Dim a2 As Double = regression.Weights(1)
			Dim a0 As Double = regression.Intercept
			' This Is the plane described by the equation
			' y = a0 + a1*x1 + a2*x2
			Dim predicted As Double() = regression.Transform(inputs)
			Dim Serror As Double = New SquareLoss(outputs).Loss(predicted)
			Dim r2 As Double = New RSquaredLoss(2, outputs).Loss(predicted)
			'Resultados
			Txt_resul.Text &= "a0: " & a0.ToString & vbNewLine
			Txt_resul.Text &= "a1: " & a1.ToString & vbNewLine
			Txt_resul.Text &= "a2: " & a2.ToString & vbNewLine & vbNewLine
			Txt_resul.Text &= "Error: " & Serror.ToString & vbNewLine
			Txt_resul.Text &= "R²: " & r2.ToString & vbNewLine & vbNewLine
			Txt_resul.Text &= ">>> Coeficientes de Antoine <<<" & vbNewLine
			Txt_resul.Text &= "A: " & a0.ToString & vbNewLine
			Txt_resul.Text &= "B: " & (a0 * Math.Abs(a2) - a1).ToString & vbNewLine
			Txt_resul.Text &= "C: " & Math.Abs(a2).ToString & vbNewLine & vbNewLine
			A = a0
			B = (a0 * Math.Abs(a2) - a1)
			C = Math.Abs(a2)
			TXT_A.Text = A
			TXT_B.Text = B
			TXT_C.Text = C
			'
			Txt_resul.SelectionStart = Len(Txt_resul.Text)
			Txt_resul.ScrollToCaret()
			Txt_resul.Select()
			Application.DoEvents()
			'
			APIcalc()
			'
			Chart1.Series.Clear()
			Chart1.Legends.Clear()
			Chart1.Legends.Add("")
			Chart1.Titles.Clear()
			Chart1.Titles.Add("R²: " & r2.ToString("0.#####################"))
			Chart1.Titles(0).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
			For i = 1 To 2
				Chart1.Series.Add(DGV_API.Columns(i).Name)
				Chart1.Series(i - 1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Square
				Chart1.Series(i - 1).IsVisibleInLegend = True
				Chart1.Series(i - 1).ChartType = DataVisualization.Charting.SeriesChartType.Line
				Chart1.Series(i - 1).BorderWidth = 2
				Chart1.Series(i - 1).ToolTip = "#SERIESNAME | T: #VALX{f2} P: #VALY{f2}"
				For j = 0 To 14
					Chart1.Series(i - 1).Points.AddXY(CDbl(DGV_API.Rows(j).Cells(0).Value), CDbl(DGV_API.Rows(j).Cells(i).Value))
				Next j
			Next i
			Chart1.ChartAreas(0).AxisX.Title = "Temperatura (ºF)"
			Chart1.ChartAreas(0).AxisY.Title = "Presión de vapor (psia)"
			Chart1.ChartAreas(0).AxisX.Maximum = Double.NaN
			Chart1.ChartAreas(0).AxisY.Maximum = Double.NaN
			Chart1.ChartAreas(0).AxisX.ScaleView.Size = Double.NaN
			Chart1.ChartAreas(0).AxisY.ScaleView.Size = Double.NaN
			Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "#"
			Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "#"
			Chart1.ChartAreas(0).RecalculateAxesScale()
			'
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Function
	Function CalcNoLineal()
		Txt_Resul_NL.Text = ""
		TXT_A.Text = ""
		TXT_B.Text = ""
		TXT_C.Text = ""
		dt_api_NL = Nothing
		'
		Dim dt As Date = Now
		Txt_Resul_NL.Text = "Cálculos - " & dt.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) & vbNewLine & vbNewLine
		Txt_Resul_NL.Text &= "Regresión No Lineal usando el algoritmo de Levenberg-Marquardt (LM)" & vbNewLine & vbNewLine

		'PREPARO DGV
		dt_api_NL = New DataTable
		dt_api_NL.Columns.Add("Temp ºF")
		dt_api_NL.Columns.Add("P psia")
		dt_api_NL.Columns.Add("P(calc) psia")
		dt_api_NL.Columns.Add("DP psia")
		dt_api_NL.Columns.Add("Error TCP")
		'
		For i = 0 To 14
			dt_api_NL.Rows.Add(New String() {T(i), P(i), "0", "0", "0"})
		Next i
		'
		DGV_API_NL.DataSource = dt_api_NL
		DGV_API_NL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		DGV_API_NL.AllowUserToOrderColumns = False
		DGV_API_NL.RowHeadersVisible = False
		DGV_API_NL.ColumnHeadersVisible = True
		Application.DoEvents()
		'
		'------------------
		'Regresión NoLineal
		'------------------
		'https://discuss.mathdotnet.com/t/using-mathnet-to-convert-an-excel-solver-problem-to-c/795
		'https://stackoverflow.com/questions/53502851/nonlinear-weighted-least-squares-estimates-of-the-parameters-of-a-nonlinear-mo
		Try
			Dim Tx, Px As Double
			'inputs(T)(-)
			Dim inputs As Double()() = New Double(14)() {}
			Dim output As Double() = New Double(14) {}
			For i = 0 To 14
				Tx = DGV_API_NL.Rows(i).Cells(0).Value
				Px = DGV_API_NL.Rows(i).Cells(1).Value
				inputs(i) = New Double() {Tx, 0}
				output(i) = Px
			Next
			' Create a Nonlinear regression using LevenbergMarquardt algorithm
			Dim nls As NonlinearLeastSquares = New NonlinearLeastSquares
			With nls
				.NumberOfParameters = 3 'A, B, C
				' Initialize to some random values
				.StartValues = {CDbl(Txt_A_ini.Text), CDbl(Txt_B_ini.Text), CDbl(Txt_C_ini.Text)}
				'
				' y = 10^(A-B / (T+C))
				.Function = Function(par, inp) 10 ^ (par(0) - par(1) / (inp(0) + par(2)))
				'
				'Derivative in respect to the weights | Derivadas parciales
				'https://www.wolframalpha.com/input/?i=d%2FdA+%2810%5E%28A-B+%2F+%28T%2BC%29%29%29+%3B+d%2FdB+%2810%5E%28A-B+%2F+%28T%2BC%29%29%29+%3B+d%2FdC+%2810%5E%28A-B+%2F+%28T%2BC%29%29%29
				.Gradient = Sub(par, inp, result)
								result(0) = Math.Log(10) * 10 ^ (par(0) - par(1) / (inp(0) + par(2)))                                       ' d/dA | En Wolfram alpha: d/dA (10^(A-B / (T+C)))
								result(1) = -Math.Log(10) * 10 ^ (par(0) - par(1) / (par(2) + inp(0)))                                      ' d/dB
								result(2) = (par(1) * Math.Log(10) * 10 ^ (par(0) - par(1) / (par(2) + inp(0)))) / (par(2) + inp(0)) ^ 2    ' d/dC
							End Sub
			End With
			'
			Dim algorithm As LevenbergMarquardt = New LevenbergMarquardt
			With algorithm
				.MaxIterations = CInt(Txt_iter.Text)
				.Tolerance = 0
			End With
			'
			nls.Algorithm = algorithm
			'
			Dim regression As NonlinearRegression = nls.Learn(inputs, output)
			' Use the function to compute the input values
			Dim predict As Double() = regression.Transform(inputs)
			' The solution will be at
			'Txt_Resul_NL.Text = ""
			TXT_A.Text &= regression.Coefficients(0)
			TXT_B.Text &= regression.Coefficients(1)
			TXT_C.Text &= regression.Coefficients(2)
			A = regression.Coefficients(0) & vbNewLine 'A
			B = regression.Coefficients(1) & vbNewLine 'B
			C = regression.Coefficients(2) & vbNewLine 'C
			'
			Txt_Resul_NL.SelectionStart = Len(Txt_resul.Text)
			Txt_Resul_NL.ScrollToCaret()
			Txt_Resul_NL.Select()
			Application.DoEvents()
			'
			APIcalc()
			'
			'Chart
			Chart2.Series.Clear()
			Chart2.Legends.Clear()
			Chart2.Legends.Add("")
			Chart2.Titles.Clear()
			Chart2.Titles.Add("")
			Chart2.Titles(0).Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
			For i = 1 To 2
				Chart2.Series.Add(DGV_API_NL.Columns(i).Name)
				Chart2.Series(i - 1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Square
				Chart2.Series(i - 1).IsVisibleInLegend = True
				Chart2.Series(i - 1).ChartType = DataVisualization.Charting.SeriesChartType.Line
				Chart2.Series(i - 1).BorderWidth = 2
				Chart2.Series(i - 1).ToolTip = "#SERIESNAME | T: #VALX{f2} P: #VALY{f2}"
				For j = 0 To 14
					Chart2.Series(i - 1).Points.AddXY(CDbl(DGV_API_NL.Rows(j).Cells(0).Value), CDbl(DGV_API_NL.Rows(j).Cells(i).Value))
				Next j
			Next i
			Chart2.ChartAreas(0).AxisX.Title = "Temperatura (ºF)"
			Chart2.ChartAreas(0).AxisY.Title = "Presión de vapor (psia)"
			Chart2.ChartAreas(0).AxisX.Maximum = Double.NaN
			Chart2.ChartAreas(0).AxisY.Maximum = Double.NaN
			Chart2.ChartAreas(0).AxisX.ScaleView.Size = Double.NaN
			Chart2.ChartAreas(0).AxisY.ScaleView.Size = Double.NaN
			Chart2.ChartAreas(0).AxisX.LabelStyle.Format = "#"
			Chart2.ChartAreas(0).AxisY.LabelStyle.Format = "#"
			'Chart1.ChartAreas(0).AxisX.Interval = 15
			'Chart1.ChartAreas(0).AxisY.Interval = 15
			Chart2.ChartAreas(0).RecalculateAxesScale()
			'
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Function
#End Region
#Region "Code"
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MakeGridViewDoubleBuffered(DGV_API)
		MakeGridViewDoubleBuffered(DGV_API_NL)
	End Sub
	Private Sub TXT_A_TextChanged_1(sender As Object, e As EventArgs) Handles TXT_A.TextChanged
		Try
			APIcalc()
		Catch
		End Try
	End Sub
	Private Sub TXT_B_TextChanged_1(sender As Object, e As EventArgs) Handles TXT_B.TextChanged
		Try
			APIcalc()
		Catch
		End Try
	End Sub
	Private Sub TXT_C_TextChanged_1(sender As Object, e As EventArgs) Handles TXT_C.TextChanged
		Try
			APIcalc()
		Catch
		End Try
	End Sub
	Private Sub TXT_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_A.KeyPress
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub TXT_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_B.KeyPress
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub TXT_C_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_C.KeyPress
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub Txt_Pbase_KeyPress(sender As Object, e As KeyPressEventArgs)
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub Txt_SG_KeyPress(sender As Object, e As KeyPressEventArgs)
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub Txt_temp_KeyPress(sender As Object, e As KeyPressEventArgs)
		Try
			e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
			If e.KeyChar = "."c AndAlso decimalSeparator <> "."c Then
				e.Handled = True
				SendKeys.Send(",")
			End If
			If e.KeyChar = ","c AndAlso decimalSeparator <> ","c Then
				e.Handled = True
				SendKeys.Send(".")
			End If
		Catch ex As Exception
		End Try
	End Sub
	Private Sub Btn_calcular_Click_1(sender As Object, e As EventArgs) Handles Btn_calcular.Click
		If TabControl1.SelectedIndex = 0 Then CalcLineal()
		If TabControl1.SelectedIndex = 1 Then CalcNoLineal()
	End Sub
	Private Sub DGV_API_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_API.CellFormatting
		Try
			For j = 0 To DGV_API.Rows.Count - 1
				DGV_API.Rows(j).Cells(1).Style.BackColor = Drawing.Color.FromArgb(65, 140, 240) '418CF0
				DGV_API.Rows(j).Cells(2).Style.BackColor = Drawing.Color.FromArgb(252, 180, 65) 'FCB441
			Next
		Catch ex As Exception

		End Try
	End Sub
	Private Sub DGV_API_NL_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_API_NL.CellFormatting
		Try
			For j = 0 To DGV_API.Rows.Count - 1
				DGV_API_NL.Rows(j).Cells(1).Style.BackColor = Drawing.Color.FromArgb(65, 140, 240) '418CF0
				DGV_API_NL.Rows(j).Cells(2).Style.BackColor = Drawing.Color.FromArgb(252, 180, 65) 'FCB441
			Next
		Catch ex As Exception

		End Try
	End Sub
#End Region
End Class




