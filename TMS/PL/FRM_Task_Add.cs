using DevExpress.Internal.WinApi;
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
    public partial class FRM_Task_Add : Form
    {
        // main var
        DBTMSEntities1 db;
       TB_Tasks add;
       public string TaskStateDate;
        public int id;
        public FRM_Task_Add()
        {
            InitializeComponent();
        }
        private  void AddData()
        {
            try
            {
                db = new DBTMSEntities1();
                add = new TB_Tasks();
                // هناك خطأ ما 
                var iduser = db.TB_Users.Where(x => x.FullName == edt_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                var idproject = db.TB_Projects.Where(x => x.projectName == edt_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                add.Task_Name = edt_taskname.Text;
                add.Task_Admin = edt_manger.SelectedItem.ToString();
                add.Task_User = edt_user.SelectedItem.ToString();
                add.Task_Project = edt_project.SelectedItem.ToString();
                add.Task_Des = edt_taskdes.Text;
                add.Task_Start = edt_startdate.Value;
                add.Task_End = edt_enddate.Value ;
                add.Task_Duration = Convert.ToInt16(edt_duration.Text);
                add.Task_State = TaskStateDate;
                add.ID_User = iduser;
                add.ID_Project = idproject;


                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("bfd447e2-ed8b-4663-ab05-cb67d842763b");
            }
            catch {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void EditData()
        {
            try
            {
                db = new DBTMSEntities1();
                add = new TB_Tasks();
                var iduser = db.TB_Users.Where(x => x.FullName == edt_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                var idproject = db.TB_Projects.Where(x => x.projectName == edt_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();

                add.ID = id;
                add.Task_Name = edt_taskname.Text;
                add.Task_Admin = edt_manger.SelectedItem.ToString();
                add.Task_User = edt_user.SelectedItem.ToString();
                add.Task_Project = edt_project.SelectedItem.ToString();
                add.Task_Des = edt_taskdes.Text;
                add.Task_Start = edt_startdate.Value;
                add.Task_End = edt_enddate.Value;
                add.Task_Duration = Convert.ToInt16(edt_duration.Text);
                add.Task_State = TaskStateDate;
                add.ID_User = iduser;
                add.ID_Project = idproject;



                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("b116da34-9386-4ef0-a7b8-24ba094d47b0");
            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }



        private void AddNote()
        {
           
            try
            {
                db = new DBTMSEntities1();
                TB_Note note = new TB_Note();
                note.NoteManger = edt_manger.SelectedItem.ToString();
                note.NoteUser= edt_user.SelectedItem.ToString();
                note.NoteDes=" تم اضافة فعالية"+ edt_taskname.Text + " الى"+ edt_user.SelectedItem.ToString() + "";
              
              


                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
               
            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void EditNote()
        {

            try
            {
                db = new DBTMSEntities1();
                TB_Note note = new TB_Note();
                note.NoteManger = edt_manger.SelectedItem.ToString();
                note.NoteUser = edt_user.SelectedItem.ToString();
                note.NoteDes = " تم تعديل فعالية" + edt_taskname.Text + " الى" + edt_user.SelectedItem.ToString() + "";




                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private void FRM_Task_Add_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Task_Add_Activated(object sender, EventArgs e)
        {
            db=new DBTMSEntities1();
            edt_manger.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
            edt_user.DataSource = db.TB_Users.Select(x => x.FullName).ToList();
            edt_project.DataSource = db.TB_Projects.Select(x => x.projectName).ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           PL.FRM_Project_Add frm =new FRM_Project_Add();
            frm.Show();
        }

        private void TaskDateCal()
        {
            var date1 = (edt_enddate.Value - edt_startdate.Value).Days;
            edt_duration.Text = date1.ToString();

            // set state 

            if(date1 == 0)
            {
                TaskStateDate = "اليوم";
            }else if (date1 == 1)
            {
                TaskStateDate = "غدا";
            }else if (date1 > 1)
            {
                TaskStateDate = "بعد" + date1.ToString()+"يوم";
            }else if(date1 < 1)
            {
                TaskStateDate = "غير مكتمل";

            }
            if (chbox_done.Checked == true)
            {
                TaskStateDate = "مكتمل";   
            }
        }

        private void edt_startdate_ValueChanged(object sender, EventArgs e)
        {
            TaskDateCal();
        }

        private void edt_enddate_ValueChanged(object sender, EventArgs e)
        {
            TaskDateCal();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
                // check filed
                if (edt_taskname.Text == ""|| edt_duration.Text=="")
                {
                    MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // check dublicated data
                    try
                    {
                        db = new DBTMSEntities1();


                        var data = db.TB_Tasks.Where(x => x.Task_Name == edt_taskname.Text).FirstOrDefault();


                        // add or edit
                        // check if add or edit
                        if (id == 0)
                        {

                            if (data == null)
                            {
                                //add
                                AddData();
                            AddNote();
                            EditNote();
                                Close();
                            }
                            else
                            {

                                MessageBox.Show("البيانات مكررة لا يمكن اجراء العملية");
                            }


                        }


                        if (id > 0)
                        {
                            var data1 = db.TB_Tasks.Where(x => x.Task_Name == edt_taskname.Text && x.ID != id).FirstOrDefault();
                            //edit
                            if (data1 == null)
                            {
                                EditData();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("البيانات مكررة لا يمكن اجراء العملية");
                            }

                        }


                    }
                    catch
                    {
                        MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    

                }
            }
        }
    }
}
