using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.UI.UiReportsUserControls
{
    public partial class ReportViewerSale : DevExpress.XtraEditors.XtraForm
    {
        public ReportViewerSale()
        {
            InitializeComponent();
        }
        public void DisplayReport(XtraReport report)
        {
            documentViewer1.DocumentSource = report;
        }
    }
}