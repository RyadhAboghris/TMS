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
    public partial class FRM_USERS_ADD : Form
    {
        // main var
        DBTMSEntities1 db;
        TB_Users add;
        public int id;
        public FRM_USERS_ADD()
        {
            InitializeComponent();
        }
        // save data event
        private  void btn_save_Click(object sender, EventArgs e)
        {
            // check filed
            if (edt_fullname.Text == "" || edt_username.Text == "" || edt_password.Text == "" || edt_roll.SelectedItem == null )
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // check dublicated data
                try
                {
                    db = new DBTMSEntities1();
                    add = new TB_Users();
                    
                    var data = db.TB_Users.Where(x => x.UserName == edt_username.Text).FirstOrDefault();
                    if (data != null)
                    {
                        // dublicat data
                        MessageBox.Show("البيانات مكررة لا يمكن اجراء العملية");
                    }
                    else
                    {
                        // add or edit
                        // check if add or edit
                        if (id == 0)
                        {
                            //add
                            AddData();

                            Close();

                        }
                        else
                        {
                            //edit
                            EditData();
                            Close();
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
                add = new TB_Users();
                add.FullName = edt_fullname.Text;
                add.UserName = edt_username.Text;
                add.Password = edt_password.Text;
                add.Role = edt_roll.SelectedItem.ToString();
                add.State = "Off";

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
                add = new TB_Users();
                add.ID = id;
                add.FullName = edt_fullname.Text;
                add.UserName = edt_username.Text;
                add.Password = edt_password.Text;
                add.Role = edt_roll.SelectedItem.ToString();
                add.State =add.State;

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
