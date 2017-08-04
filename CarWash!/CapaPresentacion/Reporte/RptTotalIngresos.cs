using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CapaPresentacion.Reporte
{
    public partial class RptTotalIngresos : DevExpress.XtraReports.UI.XtraReport
    {
        public RptTotalIngresos(int numeroMes)
        {
            InitializeComponent();
            dataTable2TableAdapter2.FillTotal(dsCarWash1.DataTable2, numeroMes);
        }

    }
}
