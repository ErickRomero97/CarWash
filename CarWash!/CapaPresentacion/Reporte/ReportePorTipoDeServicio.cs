using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace CapaPresentacion.Reporte
{
    public partial class FrmReporteIngresos : Form
    {
        public FrmReporteIngresos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Text;
            string servicio = cboServicio.Text;

            RptIngresos reporte = new RptIngresos(fecha, servicio);
            ReportPrintTool viewer = new ReportPrintTool(reporte);
            viewer.ShowRibbonPreview();
        }
    }
}
