using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ExPro.Client;
using ExPro.Server;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using J4L.TextPrinter;
using J4L.TextPrinter.Ports;
using J4L.TextPrinter.Printers;
namespace eChandanCanteen
{
    public class Printing
    {
        /// <summary>
        /// PRINTER DECLARATION
        /// </summary>
        static LPrinter MyPrinter;
        static PrinterPort port; //=new PrinterPort ;
        static TextPrinter printer;// =new TextPrinter;
        static JobProperties job;//=new JobProperties ;
        static J4L.TextPrinter.TextProperties txtprop = new J4L.TextPrinter.TextProperties();
        CurrencyTowords Cur = new CurrencyTowords();
        /// <summary>
        /// PRINTER DECLARATION
        /// </summary>
        public static void  PrinterDeclaration(int TopMargin,int Rows,int Columns,bool Condensed)
        {
            
            MyPrinter = new LPrinter(); 
            string PrinterName = MyPrinter.PrinterName;
            port = new WindowsPrinter(PrinterName);
            printer = PrinterFactory.getPrinter("EPSON-ESCP");
            printer.debug = true;
            job = printer.getDefaultJobProperties();
            job.draftQuality = true;
            job.topMargin = TopMargin;
            job.rows = Rows;
            job.cols = Columns;
            printer.startJob(port, job);
            job.condensed = Condensed;
        }
        public void Int_Footer()
        {
            printer.printString("Operator :" + GlobalUsage.gLogin_id);
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "Print Date/Time :" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
        }

        public  void Voucher(string Voucher_No,string Cr_Ledger,string Dr_Ledger,decimal Amount,string Narration)
        {
            #region Printing of Voucher
            Font f = new Font("Arial Narrow", 8, FontStyle.Bold);
            PrinterDeclaration(3,36,50,false);
            printer.printString("\t" + "\t" + GlobalUsage.gUnitName, f);
            printer.newLine();
            job.condensed = true;
            printer.printString("\t" + "\t" + "\t" + "[Unit of Chandan Healthcare Limited]");
            printer.newLine();
            printer.printString("\t" + "\t" + GlobalUsage.gAddress);
            printer.newLine();
            printer.printString("\t" + "\t" + "\t" + "\t" + "[VOUCHER]");
            printer.newLine();
            printer.printString("Voucher No.  " + Voucher_No);
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "DATE :" + DateTime.Now.ToShortDateString());
            printer.newLine();
            printer.printString("========================================================================================");
            printer.newLine();
            printer.printString("[DEBIT]");
            printer.newLine();
            printer.printString("\t" + Dr_Ledger);
            printer.newLine();
            printer.printString("\t" + Narration);
            printer.newLine();
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + Amount.ToString("##.00"));
            printer.newLine();
            printer.newLine();
            printer.printString("[CREDIT]");
            printer.newLine();
            printer.printString("\t" + Cr_Ledger);
            printer.newLine();
            printer.printString("\t" + Narration );
            printer.newLine();
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + Amount.ToString("##.00"));
            printer.newLine();
            printer.printString("========================================================================================");
            printer.newLine();
            printer.printString("Received with thanks the sum of Rs. " + Amount.ToString("##.00"));
            printer.newLine();
            printer.printString("(In Words Rs.");
            printer.printString( Cur.changeCurrencyToWords(Convert.ToDouble(Amount)));
            printer.newLine();
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "Signature");
            printer.newLine();
            printer.newLine();
            printer.printString("Accountant ");
            printer.printString("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "Manager ");
            printer.newLine();
            printer.newLine();
            Int_Footer();
            printer.endJob();
            #endregion
        }

      }
}
