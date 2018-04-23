Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Namespace SpecifyPageRange
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim pt As New ReportPrintTool(New XtraReport1())
			AddHandler pt.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
			pt.Print()
		End Sub

		Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			' Set the page range.
			e.PrintDocument.PrinterSettings.FromPage = 1
			e.PrintDocument.PrinterSettings.ToPage = 3
		End Sub

	End Class
End Namespace