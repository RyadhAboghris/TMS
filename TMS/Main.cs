using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.PL;
using System.Data.Entity;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace TMS
{
    public partial class Main : Form
    {
        // main init
        FRM_HOME HOME;
        FRM_USER USERS;

        FRM_Projects _Projects;
        FRM_Tasks tasks;
        int id;
        TB_Note note;
        DBTMSEntities1 db;
        public Main()
        {
            InitializeComponent();
            loadDataNote();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        // home event
        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }
        // user event
        private void btn_users_Click(object sender, EventArgs e)
        {
            USERS = new FRM_USER();
            USERS.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(USERS);
            // change the state of label
            lb_state.Text = "المستخدمين";
        }



        private void LoadHomePage()
        {
            HOME = new FRM_HOME();
            HOME.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(HOME);
            // change the state of label
            lb_state.Text = "الرئيسة";
        }

        //Form load
        private void Main_Load(object sender, EventArgs e)
        {
            LoadHomePage();
            loadDataNote();
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            tasks = new FRM_Tasks();
            tasks.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(tasks);
            // change the state of label
            lb_state.Text = "المهام";
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            _Projects = new FRM_Projects();
            _Projects.Dock = DockStyle.Fill;
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(_Projects);
            // change the state of label
            lb_state.Text = "المشاريع";
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            FRM_Setting _setting = new FRM_Setting();
            _setting.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = true;
            transitionManager1.EndTransition();
        }

        private void gridControl1_MouseLeave(object sender, EventArgs e)
        {

            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = false;
            transitionManager1.EndTransition();
            loadDataNote();
        }

        private void loadDataNote()
        {

            try
            {
                db = new DBTMSEntities1();
                gridControl1.DataSource = db.TB_Note.Where(x => x.NoteUser == lb_userName.Text || x.NoteManger == lb_userName.Text).ToList();
                var idnumber = db.TB_Note.Where(x => x.NoteUser == lb_userName.Text || x.NoteManger == lb_userName.Text).Select(x => x.ID).ToList();

                if (idnumber.Count == 0)
                {
                    btn_shownote.Text = "";
                }
                else
                {
                    btn_shownote.Text = idnumber.Count.ToString();
                }
            }
            catch
            {

            }
           
            
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tileView1_DoubleClick(object sender, EventArgs e)
        {

            try { 
            id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                db = new DBTMSEntities1();

                note = new TB_Note();
                note = db.TB_Note.Where(x => x.ID == id).FirstOrDefault();
                


                db.Entry(note).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                loadDataNote();
                
            }

        }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
}

        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadDataNote();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Main_Leave(object sender, EventArgs e)
        {
                   }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
