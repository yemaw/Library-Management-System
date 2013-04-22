using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team6A_LibraryManagementSystem
{
    public partial class ucListMember : ucList
    {
        public ucListMember()
        {
            InitializeComponent();
        }

        private void ucListMember_Load(object sender, EventArgs e)
        {
            LibraryDBEntities le = new LibraryDBEntities();
            //label1.Text = le.BooksModels.ToString();

            LibraryDBEntities context = new LibraryDBEntities();

            var query = from m in context.Members select new { m.MemberID, m.MemberName, m.PhoneNumber,m.Address, m.Email };

            var bookmodels = query.ToList();

            dgvMembersList.DataSource = bookmodels;
        }
    }
}
