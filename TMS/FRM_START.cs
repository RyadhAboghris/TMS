using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class FRM_START : SplashScreen
    {
        public FRM_START()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2022-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private async void FRM_START_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(3000));
           var State= await Task.Run(() => CheckConn());
            if(State == true)
            {
                PL.FRM_USERS_LOGIN frm_login = new PL.FRM_USERS_LOGIN();
                frm_login.Show();
            }
            else
            {
                MessageBox.Show("خطأ في الاتصال في السيرفير ,تحقق من الاتصال و حاول مرة اخرى");
           Application.Exit();
            
            }
        }
        private bool CheckConn()
        {
            try{
                DBTMSEntities1 db = new DBTMSEntities1();
                var list =  db.TB_Users.ToList();
            if(list != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch{
                return false;
            }
        }
    }
}