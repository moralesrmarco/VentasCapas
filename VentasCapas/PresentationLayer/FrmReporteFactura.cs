using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasCapas.BusinessLogicLayer;

namespace VentasCapas.PresentationLayer
{
    public partial class FrmReporteFactura : Form
    {

        public int idVenta = 0;

        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            VentasCapasDataSet ds = new VentasCapasDataSet();
            ReporteBLL reporteBLL = new ReporteBLL();
            ds = reporteBLL.reporteFactura(idVenta);
            var tbl = ds.Tables["reporteFactura"];
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tbl));
            this.reportViewer1.RefreshReport();
        }
    }
}
