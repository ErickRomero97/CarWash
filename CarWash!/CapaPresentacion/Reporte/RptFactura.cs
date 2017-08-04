using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CapaPresentacion.Reporte
{
    public partial class RptFactura : DevExpress.XtraReports.UI.XtraReport
    {
        public RptFactura(int id, string isv, string total)
        {
            InitializeComponent();
            dataTable1TableAdapter1.FillId(dsCarWash1.DataTable1, id);
            xrLabel22.Text = isv;
            xrLabel23.Text = total;  
        }

    }
}
