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
    public partial class FrmReporTotalIngresos : Form
    {
        public FrmReporTotalIngresos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RptTotalIngresos reporte = new RptTotalIngresos(cboMes.SelectedIndex);
            ReportPrintTool viewer = new ReportPrintTool(reporte);
            viewer.ShowRibbonPreview();
        }

        private void FrmReporTotalIngresos_Load(object sender, EventArgs e)
        {

        }
    }
}
