using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team6A_LibraryManagementSystem
{
    public partial class Report_TotalMembersConsumePieChatReport : Form
    {
        public Report_TotalMembersConsumePieChatReport()
        {
            InitializeComponent();
        }

        private void Report_TotalMembersConsumePieChatReport_Load(object sender, EventArgs e)
        {
            TotalMemberConsume ds = new TotalMemberConsume();
            TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter ta = new TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter();
            TotalMembersConsumePieChatReport cRpt = new TotalMembersConsumePieChatReport();
            ta.Fill(ds.TotalMembersConsume);
            cRpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRpt;    
        }

    }
}
