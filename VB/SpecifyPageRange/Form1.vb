Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...

Namespace SpecifyPageRange
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			AddHandler report.PrintingSystem.StartPrint, AddressOf printingSystem_StartPrint
			report.Print()
		End Sub

		Private Sub printingSystem_StartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			' Set the page range.
			e.PrintDocument.PrinterSettings.FromPage = 1
			e.PrintDocument.PrinterSettings.ToPage = 3
		End Sub

	End Class
End Namespace