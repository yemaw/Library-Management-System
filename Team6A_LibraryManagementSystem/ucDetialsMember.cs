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
    public partial class ucDetialsMember : ucDetails
    {
        private LibraryDBEntities entity;
        private Member member;
        Window_Master MainWindowObject;
        Window_Popup_Details ParentWindowObject;
        int member_id = 0;

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }

        public void setParentWindowRefrence(Window_Popup_Details window)
        {
            ParentWindowObject = window;
        }

        public ucDetialsMember()
        {
            InitializeComponent();
            
        }

        public ucDetialsMember(int _member_id)
        {
            InitializeComponent();

            member_id = _member_id;
            entity = new LibraryDBEntities();
            
            member = EntityBroker.getMemberByMemberID(_member_id);
        }

        private void ucDetialsMember_Load(object sender, EventArgs e)
        {
            if (member_id > 0)
            {
                lblMemberIDValue.Text = Convert.ToString(member.MemberID);
                txtMemberName.Text = member.MemberName;
                txtAddress.Text = member.Address;
                txtPhoneNumber.Text = member.PhoneNumber;
                txtNIRCNumber.Text = member.NIRC;
                txtEmail.Text = member.Email;
            }
            else {
                lblMemberIDValue.Text = "";
            }
            
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (member_id > 0)
            {
                member.MemberName = txtMemberName.Text;
                member.Address = txtAddress.Text;
                member.PhoneNumber = txtPhoneNumber.Text;
                member.NIRC = txtNIRCNumber.Text;
                member.Email = txtEmail.Text;

                i = EntityBroker.updateMember(member);
            }
            else
            {
                Member mb = new Member();
                mb.MemberName = txtMemberName.Text;
                mb.Address = txtAddress.Text;
                mb.PhoneNumber = txtPhoneNumber.Text;
                mb.NIRC = txtNIRCNumber.Text;
                mb.Email = txtEmail.Text;

                i = EntityBroker.createMember(mb);
            }


            if (i == 1)
            {
                MessageBox.Show("Book Information Saved");
                //#TODO::
                //ucListMember ml = new ucListMember();
                //ml.setMainWindowRefrence(MainWindowObject);
                //MainWindowObject.RequestContentChange(ml);

                ParentWindowObject.Close();
            }
            else
            {
                MessageBox.Show("Error in updating. Error code :: {0}", i.ToString());
            }
            
        }
    }
}
