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
    public partial class FrmReporteClientes : Form
    {
        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            VentasCapasDataSet ds = new VentasCapasDataSet();
            ReporteBLL reporteBLL = new ReporteBLL();
            ds = reporteBLL.listarClientes();
            var tbl = ds.Tables["reporteClientes"];
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tbl));
            this.reportViewer1.RefreshReport();
        }
    }
}
