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
    public partial class Report_MemberBookLastRentCrossTab : Form
    {
        public Report_MemberBookLastRentCrossTab()
        {
            InitializeComponent();
        }

        private void Report_MemberBookLastRentCrossTab_Load(object sender, EventArgs e)
        {
            TotalMemberConsume ds = new TotalMemberConsume();
            TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter ta = new TotalMemberConsumeTableAdapters.TotalMembersConsumeTableAdapter();
            MemberBookLastRentReport cRpt = new MemberBookLastRentReport();
            ta.Fill(ds.TotalMembersConsume);
            cRpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cRpt;
        }

    }
}
