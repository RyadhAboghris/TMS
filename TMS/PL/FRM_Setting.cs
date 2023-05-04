using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.PL
{
    partial class FRM_Setting : Form
    {
        public FRM_Setting()
        {
            InitializeComponent();

        }


        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_Setting_Load(object sender, EventArgs e)
        {
            edt_getNote.Text = ((Properties.Settings.Default.StateTime) / 60000).ToString();
            edt_dataupdate.Text = ((Properties.Settings.Default.UpdateData) / 60000).ToString();
            edt_updatenote.Text = ((Properties.Settings.Default.GetNotTimer) / 60000).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StateTime = (Convert.ToInt16(edt_getNote.Text)) * 60000;
            Properties.Settings.Default.UpdateData = (Convert.ToInt16(edt_dataupdate.Text)) * 60000;
            Properties.Settings.Default.GetNotTimer = (Convert.ToInt16(edt_updatenote.Text)) * 60000;
            Properties.Settings.Default.Save();
            Close();

        }
    }
}
