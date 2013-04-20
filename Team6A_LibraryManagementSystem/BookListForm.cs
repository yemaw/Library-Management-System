using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team6A_LibraryManagementSystem
{
    public partial class BookListForm : FormTemplates.ListingTemplate
    {
        public BookListForm()
        {
            InitializeComponent();
            this.Text = "Books List - " + Configs.SystemName;
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookDetailsForm bdf = new BookDetailsForm();
            bdf.Show();
        }

    }
}
