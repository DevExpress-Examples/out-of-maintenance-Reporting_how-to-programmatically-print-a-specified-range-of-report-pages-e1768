using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
// ...

namespace SpecifyPageRange {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.PrintingSystem.StartPrint += 
                new PrintDocumentEventHandler(printingSystem_StartPrint);
            report.Print();
        }
        
        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e) {
            // Set the page range.
            e.PrintDocument.PrinterSettings.FromPage = 1;
            e.PrintDocument.PrinterSettings.ToPage = 3;
        }

    }
}