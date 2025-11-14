using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.DataAccessLayer;
using VentasCapas.Entities;

namespace VentasCapas.BusinessLogicLayer
{
    internal class ReporteBLL
    {
        public VentasCapasDataSet listarClientes()
        {
            try
            {
                VentasCapasDataSet ds = new VentasCapasDataSet();
                ReporteDAL reporteDAL = new ReporteDAL();
                ds = reporteDAL.listarClientes();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VentasCapasDataSet reporteFactura(int idVenta)
        {
            try
            {
                VentasCapasDataSet ds = new VentasCapasDataSet();
                ReporteDAL reporteDAL = new ReporteDAL();
                ds = reporteDAL.reporteFactura(idVenta);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
