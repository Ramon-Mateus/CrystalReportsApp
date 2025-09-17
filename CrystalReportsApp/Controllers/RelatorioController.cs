using CrystalDecisions.CrystalReports.Engine;
using CrystalReportsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrystalReportsApp.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: Relatorio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExportarPDFEstatico()
        {

            ReportDocument rd = new ReportDocument();

            string caminho = Path.Combine(Server.MapPath("~/Reports"), "RelatorioEstatico.rpt");
            rd.Load(caminho);

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);

            rd.Close();
            rd.Dispose();

            return File(stream, "application/pdf", "MeuPdfEstatico.pdf");
        }

        public ActionResult ExportarProdutos()
        {

            ReportDocument rd = new ReportDocument();


            string caminho = Path.Combine(Server.MapPath("~/Reports"), "RelatorioProdutos.rpt");
            rd.Load(caminho);

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);

            rd.Close();
            rd.Dispose();

            return File(stream, "application/pdf", "RelatorioProdutos.pdf");
        }
    }
}