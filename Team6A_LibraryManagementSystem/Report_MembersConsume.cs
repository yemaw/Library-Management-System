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
    public partial class Report_MembersConsume : Form
    {
        public Report_MembersConsume()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            TotalMemberConsume ds = new TotalMemberConsume();
            TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter ta = new TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter();
            TotalMemberConsumeStandardReport cRpt = new TotalMemberConsumeStandardReport();
            ta.Fill(ds.TotalMembersConsume);
            cRpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRpt;
        }
    }
}
