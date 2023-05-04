using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.PL
{
    public partial class FRM_HOME : DevExpress.XtraEditors.XtraUserControl
    {

        DBTMSEntities1 db= new DBTMSEntities1();
        public FRM_HOME()
        {
            InitializeComponent();
        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            LoadDoneTask();
        }

        private void LoadDoneTask()
        {
            try
            {
                db = new DBTMSEntities1();
                var TaskList = db.TB_Tasks.Where(x => x.Task_State == "اليوم").Select(x => x.ID).ToList();
                lb_tasksdone.Text = TaskList.Count.ToString();
            }
            catch { }
          


        }
    }
}
