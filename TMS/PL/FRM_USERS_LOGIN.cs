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
    public partial class FRM_USERS_LOGIN : Form
    {
        // main var
        DBTMSEntities1 db;
        TB_Users add;
        public int id;
        public FRM_USERS_LOGIN()
        {
            InitializeComponent();
        }
        // save data event
        private void btn_save_Click(object sender, EventArgs e)
        {
            // check filed
            if (edt_username.Text == "" || edt_password.Text == "")
            {
                MessageBox.Show("جميع الحقول مطلوبة", "خطأ في الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    db = new DBTMSEntities1();
                    add = new TB_Users();

                    add=db.TB_Users.Where(x => x.UserName == edt_username.Text && x.Password == edt_password.Text).FirstOrDefault();
                
                    if(add != null)
                    {
                        // login
                        Main main = new Main();
                        main.Show();
                        if (add.Role == "مستخدم")
                        {
                            main.btn_users.Enabled = false;
                        }
                        add.State = "On";
                        add.Password = add.Password;
                        add.UserName = add.UserName;
                        add.FullName = add.FullName;
                        add.Role = add.Role;    
                        db.Entry(add).State=System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        main.lb_userName.Text = add.FullName;
                        main.lb_roll.Text = add.Role;

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("معلومات تسجيل الدخول خاطئة");
                    }
                
                
                }

                catch
                {
                    MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }




        }

        private void FRM_USERS_LOGIN_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_USERS_LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
