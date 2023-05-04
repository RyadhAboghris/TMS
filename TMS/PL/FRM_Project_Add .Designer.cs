namespace TMS.PL
{
    partial class FRM_Project_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Project_Add));
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.edt_des = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(359, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المشروع";
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(108, 166);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(392, 37);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(331, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف المشروع";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(0, 644);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_save.Size = new System.Drawing.Size(622, 59);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("bfd447e2-ed8b-4663-ab05-cb67d842763b", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b116da34-9386-4ef0-a7b8-24ba094d47b0", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "  private  void AddData()", "تمت عملية التعديل بنجاح", "  private  void AddData()", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // edt_des
            // 
            this.edt_des.Location = new System.Drawing.Point(108, 274);
            this.edt_des.Name = "edt_des";
            this.edt_des.Size = new System.Drawing.Size(392, 312);
            this.edt_des.TabIndex = 5;
            this.edt_des.Text = "";
            // 
            // FRM_Project_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 703);
            this.Controls.Add(this.edt_des);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Project_Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public System.Windows.Forms.TextBox edt_name;
        public System.Windows.Forms.RichTextBox edt_des;
    }
}