using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CapaPresentacion.Reporte
{
    public partial class RptIngresos : DevExpress.XtraReports.UI.XtraReport
    {
        public RptIngresos(string fecha, string servicio)
        {
            InitializeComponent();
            servicio1TableAdapter1.FillDatos(dsCarWash1.Servicio1, fecha, servicio);
        }

    }
}
