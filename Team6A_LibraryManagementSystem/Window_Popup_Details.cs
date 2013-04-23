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
    public partial class Window_Popup_Details : Template_Master
    {
        public Window_Popup_Details()
        {
            InitializeComponent();
        }

        public Window_Popup_Details(UserControl uc)
        {
            InitializeComponent();
            panelPopup.Controls.Add(uc);
        }

        public void RequestContentChange(UserControl uc)
        {
            panelPopup.Controls.Clear();
            panelPopup.Controls.Add(uc);
        }
    }
}
