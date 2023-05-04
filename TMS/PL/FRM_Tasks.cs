using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.PL;

namespace TMS.PL
{
    public partial class FRM_Tasks : DevExpress.XtraEditors.XtraUserControl
    {
        // main var
        DBTMSEntities1 db;
        TB_Tasks users;
        FRM_Task_Add frm_add;
        public int id;
        public FRM_Tasks()
        {
            InitializeComponent();


            TMS.DBTMSEntities1 dbContext = new TMS.DBTMSEntities1();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Tasks.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Tasks.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        // update data event
        private void btn_update_Click(object sender, EventArgs e)
        {
            UserDataUpdata();
        }
        public void UserDataUpdata()
        {
            try
            {
                db = new DBTMSEntities1();
                gridControl1.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FRM_USER_Load(object sender, EventArgs e)
        {
            UserDataUpdata();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_add = new FRM_Task_Add();
            frm_add.id = 0;
            frm_add.btn_save.Text = "اضافة";
            frm_add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id == 0)
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها", "خطأ في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    db = new DBTMSEntities1();
                    users = new TB_Tasks();
                    users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                    frm_add = new FRM_Task_Add();
                    frm_add.id = id;
                    frm_add.btn_save.Text = "تعديل";


                    frm_add.Show();
                }

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db = new DBTMSEntities1();
                        users = new TB_Tasks();
                        users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("638bf85f-6b40-485b-93eb-c022c4c18b3e");
                    }

                }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متأكد من هذا الاجراء", "اجراء اكمال المهمة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "خطأ في عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db = new DBTMSEntities1();

                        users = new TB_Tasks();
                        users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        users.ID = id;
                        users.Task_Name = users.Task_Name;
                        users.Task_Admin = users.Task_Admin;
                        users.Task_User = users.Task_User;
                        users.Task_Project = users.Task_Project;
                        users.Task_Des = users.Task_Des;
                        users.Task_Start = users.Task_Start;
                        users.Task_End = users.Task_End;
                        users.Task_Duration = users.Task_Duration;
                        users.Task_State = "مكتمل";
                        //add.projectDes = edt_des.Text;


                        db.Entry(users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("a65863c1-c1a0-4a6f-bc12-1a698dd52071");
                        AddNote();
                    }

                }
                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void AddNote()
        {

            try
            {
                db = new DBTMSEntities1();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                users = new TB_Tasks();
                users = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                TB_Note note = new TB_Note();
                note.NoteManger = users.Task_Admin;
                note.NoteUser = users.Task_User;
                note.NoteDes = " تم اكمال الفعالية" + users.Task_Name + " من قبل" + users.Task_User + "";




                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                db = new DBTMSEntities1();
                TB_Tasks tasks = new TB_Tasks();
                var idlist = db.TB_Tasks.Select(x => x.ID).ToArray();


                for (int i = 0; i < idlist.Length; i++) {

                    var id = idlist[i];
                    tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                    var start = tasks.Task_Start;
                    var end = DateTime.Now.Date;
                    var date1 = (end - start).Value.Days;

                    tasks.ID = id;
                    tasks.Task_Name = tasks.Task_Name;
                    tasks.Task_Admin = tasks.Task_Admin;
                    tasks.Task_User = tasks.Task_User;
                    tasks.Task_Project = tasks.Task_Project;
                    tasks.Task_Des = tasks.Task_Des;
                    tasks.Task_Start = tasks.Task_Start;
                    tasks.Task_End = tasks.Task_End;
                    tasks.Task_Duration = tasks.Task_Duration;

                    if(date1 == 0 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "اليوم";

                        TB_Note note = new TB_Note();
                        note.NoteManger = tasks.Task_Admin;
                        note.NoteUser = tasks.Task_User;
                        note.NoteDes = "الفعالية" + tasks.Task_Name + "تنتهي اليوم";
                        db.Entry(note).State = EntityState.Added;
                        db.SaveChanges();

                    }
                    else if (date1 ==1 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "غدا";
                    }
                    else if (date1 > 1 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "بعد" + date1.ToString()+" يوم";
                    }
                    else if (date1 <0 && tasks.Task_State != "مكتمل")
                    {
                        tasks.Task_State = "غير مكتمل";
                    }
                    db.Entry(tasks).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                db = new DBTMSEntities1();
                gridControl1.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {
              
            }
        }
    }
}
