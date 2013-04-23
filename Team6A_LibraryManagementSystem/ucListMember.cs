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
        Window_Master MainWindowObject;
        //Window_Popup_Details ContainerWindowObject;

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }

        //public void setContainerWindowRefrence(Window_Popup_Details window)
        //{
        //    ContainerWindowObject = window;
        //}

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

        private void dgvMembersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int member_id = Convert.ToInt32(dgv.SelectedRows[0].Cells["MemberID"].Value);
                
                ucDetialsMember ucdm = new ucDetialsMember(member_id);
                ucdm.setMainWindowRefrence(MainWindowObject);
                Window_Popup_Details pd = new Window_Popup_Details(ucdm);
                ucdm.setParentWindowRefrence(pd);
                
                pd.Show();
            }
        }
    }
}
