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
    public partial class FRM_Project_Add : Form
    {
        // main var
        DBTMSEntities1 db;
        TB_Projects add;
        public int id;
        public FRM_Project_Add()
        {
            InitializeComponent();
        }
        // save data event
        private  void btn_save_Click(object sender, EventArgs e)
        {
            // check filed
            if (edt_name.Text == ""  )
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // check dublicated data
                try
                {
                    db = new DBTMSEntities1();

                    
                    var data = db.TB_Projects.Where(x => x.projectName == edt_name.Text).FirstOrDefault();
                    
                   
                        // add or edit
                        // check if add or edit
                        if (id == 0 )
                        {

                        if(data == null)
                        {
                            //add
                            AddData();

                            Close();
                        }
                        else
                        {

                            MessageBox.Show("البيانات مكررة لا يمكن اجراء العملية");
                        }
                           

                        }
                    

                      if(id>0)  {
                        var data1 = db.TB_Projects.Where(x => x.projectName == edt_name.Text&&x.ID!=id).FirstOrDefault();
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
        private  void AddData()
        {
            try
            {
                db = new DBTMSEntities1();
                add = new TB_Projects();
                add.projectName = edt_name.Text;
                add.projectDes = edt_des.Text;
           

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
                add = new TB_Projects();
                add.ID = id;
                add.projectName = edt_name.Text;
                add.projectDes = edt_des.Text;


                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("b116da34-9386-4ef0-a7b8-24ba094d47b0");
            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
