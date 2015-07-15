using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Printer.Controllers
{
    using Neodynamic.SDK.Web;
    using Properties;

    public class PrintController : Controller
    {
        // GET: Print
        public ActionResult Print()
        {
            return View();
        }

        public void PrintInvoice()
        {
            var printJob = new ClientPrintJob();
            printJob.ClientPrinter= new DefaultPrinter();

            printJob.PrinterCommands = Resources.PrinterText;

            printJob.SendToClient(System.Web.HttpContext.Current.Response);
        }
    }
}